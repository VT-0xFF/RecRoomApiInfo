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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2A00", Offset = "0x7DA1C00", VA = "0x187DA2A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F150", Offset = "0x7D9E350", VA = "0x187D9F150", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7120", Offset = "0x7DA6320", VA = "0x187DA7120", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GCPAODKNOIB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E970", Offset = "0x7D8DB70", VA = "0x187D8E970")]
	public GCPAODKNOIB(string DCEACFEGBDC, Exception EBAOCMFIDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class PBCKJCMKDDC : MOPEIKDKFHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PCJHNBFIBIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DGAHAKEJLEJ>> <>t__builder;

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
		private TaskAwaiter<JAOEKBCPPFJ<DFMNJLHLEJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4220", Offset = "0x7DA3420", VA = "0x187DA4220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4460", Offset = "0x7DA3660", VA = "0x187DA4460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EFKDJHNPFDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AONEBGNACKH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<AONEBGNACKH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D89760", Offset = "0x7D88960", VA = "0x187D89760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D89970", Offset = "0x7D88B70", VA = "0x187D89970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	[UnityEngine.Scripting.Preserve]
	public PBCKJCMKDDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3FF0", Offset = "0x7DA31F0", VA = "0x187DA3FF0", Slot = "4")]
	[AsyncStateMachine(typeof(PCJHNBFIBIC))]
	public Task<IReadOnlyList<DGAHAKEJLEJ>> ELIGFMHDDCM(long KCAAOMDKNIH, long NFFPLNPCCNI, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4110", Offset = "0x7DA3310", VA = "0x187DA4110", Slot = "5")]
	[AsyncStateMachine(typeof(EFKDJHNPFDA))]
	public Task<IReadOnlyList<AONEBGNACKH>> PCDJFNNHOLL(IReadOnlyList<int> HPHJMHDHNBC, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HMFDODFNHDA : IEquatable<HMFDODFNHDA>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NMKBIJKKLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AONEBGNACKH IBOIBJLFGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime NIKPLPIIHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ICLCGPHPAPG? FFCBGOLOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ECEPKFMEKIM? CNOCAMHHBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NFLLCMCCJMK ONEGKBDNHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KLKDBEPMPLI> BHGFNDOJHGE();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NFLLCMCCJMK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MOPEIKDKFHI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DGAHAKEJLEJ>> ELIGFMHDDCM(long KCAAOMDKNIH, long NFFPLNPCCNI, [Optional] CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<AONEBGNACKH>> PCDJFNNHOLL(IReadOnlyList<int> HPHJMHDHNBC, [Optional] CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IEKJMPNOPID
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class COILDPJENFK : HMFDODFNHDA, IEquatable<HMFDODFNHDA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct EIOALIPALDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public COILDPJENFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private EJMGGDFKJAB <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<AELLMCLLHFN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KLKDBEPMPLI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A670", Offset = "0x7D89870", VA = "0x187D8A670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D8AC00", Offset = "0x7D89E00", VA = "0x187D8AC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DGAHAKEJLEJ FPCDLPGNHIN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NMKBIJKKLDN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AONEBGNACKH IBOIBJLFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IJNJLAEKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D893B0", Offset = "0x7D885B0", VA = "0x187D893B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ICLCGPHPAPG? FFCBGOLOHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x670CB40", Offset = "0x670BD40", VA = "0x18670CB40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ECEPKFMEKIM? CNOCAMHHBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x27E5B80", Offset = "0x27E4D80", VA = "0x1827E5B80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NFLLCMCCJMK ONEGKBDNHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "10")]
			get
			{
				return default(NFLLCMCCJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D89100", Offset = "0x7D88300", VA = "0x187D89100", Slot = "9")]
		[AsyncStateMachine(typeof(EIOALIPALDI))]
		public Task<KLKDBEPMPLI> BHGFNDOJHGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D89410", Offset = "0x7D88610", VA = "0x187D89410")]
		public COILDPJENFK(int JKGKKDPCAKG, AONEBGNACKH NGEPMLJGCNP, DGAHAKEJLEJ FPCDLPGNHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D892A0", Offset = "0x7D884A0", VA = "0x187D892A0", Slot = "11")]
		public bool Equals(HMFDODFNHDA LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D89200", Offset = "0x7D88400", VA = "0x187D89200", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D893D0", Offset = "0x7D885D0", VA = "0x187D893D0")]
		private bool NMCHHBCGMOL(COILDPJENFK LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D89330", Offset = "0x7D88530", VA = "0x187D89330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class BFBOELGFICI : HMFDODFNHDA, IEquatable<HMFDODFNHDA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct LCNCENFKCMF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public BFBOELGFICI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<KLKDBEPMPLI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DBF0", Offset = "0x7D9CDF0", VA = "0x187D9DBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DE40", Offset = "0x7D9D040", VA = "0x187D9DE40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly FLDEFDNOGMD LPMMCMBBBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly ICLCGPHPAPG HBNMPLJKOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly ECEPKFMEKIM NPLLCLBAJJD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NMKBIJKKLDN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D890C0", Offset = "0x7D882C0", VA = "0x187D890C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AONEBGNACKH IBOIBJLFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D88D10", Offset = "0x7D87F10", VA = "0x187D88D10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IJNJLAEKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D88FC0", Offset = "0x7D881C0", VA = "0x187D88FC0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ICLCGPHPAPG? FFCBGOLOHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D88DA0", Offset = "0x7D87FA0", VA = "0x187D88DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ECEPKFMEKIM? CNOCAMHHBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D89010", Offset = "0x7D88210", VA = "0x187D89010", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NFLLCMCCJMK ONEGKBDNHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC6460", Offset = "0xAC5660", VA = "0x180AC6460", Slot = "10")]
			get
			{
				return default(NFLLCMCCJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C8BA10", Offset = "0x1C8AC10", VA = "0x181C8BA10")]
		public BFBOELGFICI(FLDEFDNOGMD KJOBADLNJGB, ICLCGPHPAPG KHLFJANMKDO, ECEPKFMEKIM PNEAPGPKKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D88C20", Offset = "0x7D87E20", VA = "0x187D88C20", Slot = "9")]
		[AsyncStateMachine(typeof(LCNCENFKCMF))]
		public Task<KLKDBEPMPLI> BHGFNDOJHGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D88DF0", Offset = "0x7D87FF0", VA = "0x187D88DF0", Slot = "11")]
		public bool Equals(HMFDODFNHDA LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D88E90", Offset = "0x7D88090", VA = "0x187D88E90", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D89060", Offset = "0x7D88260", VA = "0x187D89060")]
		private bool NMCHHBCGMOL(BFBOELGFICI LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D88F40", Offset = "0x7D88140", VA = "0x187D88F40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PEBDNENADEE : HMFDODFNHDA, IEquatable<HMFDODFNHDA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PIACNFKBEKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<KLKDBEPMPLI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4940", Offset = "0x7DA3B40", VA = "0x187DA4940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4BA0", Offset = "0x7DA3DA0", VA = "0x187DA4BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly AONEBGNACKH FFGKMCCDILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly ICLCGPHPAPG HBNMPLJKOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly ECEPKFMEKIM NPLLCLBAJJD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NMKBIJKKLDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7DA48A0", Offset = "0x7DA3AA0", VA = "0x187DA48A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public AONEBGNACKH IBOIBJLFGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IJNJLAEKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ICLCGPHPAPG? FFCBGOLOHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7DA45A0", Offset = "0x7DA37A0", VA = "0x187DA45A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ECEPKFMEKIM? CNOCAMHHBMK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4770", Offset = "0x7DA3970", VA = "0x187DA4770", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NFLLCMCCJMK ONEGKBDNHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "10")]
			get
			{
				return default(NFLLCMCCJMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1C8BA10", Offset = "0x1C8AC10", VA = "0x181C8BA10")]
		public PEBDNENADEE(AONEBGNACKH NGEPMLJGCNP, ICLCGPHPAPG KHLFJANMKDO, ECEPKFMEKIM PNEAPGPKKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7DA44D0", Offset = "0x7DA36D0", VA = "0x187DA44D0", Slot = "9")]
		[AsyncStateMachine(typeof(PIACNFKBEKD))]
		public Task<KLKDBEPMPLI> BHGFNDOJHGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7DA45F0", Offset = "0x7DA37F0", VA = "0x187DA45F0", Slot = "11")]
		public bool Equals(HMFDODFNHDA LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4660", Offset = "0x7DA3860", VA = "0x187DA4660", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DA46E0", Offset = "0x7DA38E0", VA = "0x187DA46E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7DA47C0", Offset = "0x7DA39C0", VA = "0x187DA47C0")]
		private bool NMCHHBCGMOL(PEBDNENADEE LDKNLBHIGFL)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JDDCNOGLLBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<HMFDODFNHDA>> <>t__builder;

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
		public IEKJMPNOPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<DGAHAKEJLEJ> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<DGAHAKEJLEJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, AONEBGNACKH account, DGAHAKEJLEJ roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D93030", Offset = "0x7D92230", VA = "0x187D93030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7D93E60", Offset = "0x7D93060", VA = "0x187D93E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FFEIMMHEPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, AONEBGNACKH account, DGAHAKEJLEJ roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<DGAHAKEJLEJ> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IEKJMPNOPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<AONEBGNACKH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B4A0", Offset = "0x7D8A6A0", VA = "0x187D8B4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D8BE70", Offset = "0x7D8B070", VA = "0x187D8BE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BAEJHPKFLFN GFBOFLDLNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MOPEIKDKFHI EIIKGDPAFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GEIMDBFEJML NFBCJJIIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OFPMMIIHGKO<(long, long), IReadOnlyList<DGAHAKEJLEJ>> PENKBHADLDO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D92030", Offset = "0x7D91230", VA = "0x187D92030")]
	[UnityEngine.Scripting.Preserve]
	public IEKJMPNOPID([KMMHIEIDBEA(null)] MOPEIKDKFHI PLCCELNLMIC, [KMMHIEIDBEA(null)] GEIMDBFEJML DEPPFGGLAAA, [KMMHIEIDBEA(null)] BAEJHPKFLFN NOFEJKELOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D91EE0", Offset = "0x7D910E0", VA = "0x187D91EE0")]
	[AsyncStateMachine(typeof(JDDCNOGLLBP))]
	public Task<IList<HMFDODFNHDA>> OOBNNECPJNL(long KCAAOMDKNIH, long HPHKCHODKPD, bool KBOFMMOBKJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D91C30", Offset = "0x7D90E30", VA = "0x187D91C30")]
	private bool APMDJAHLMAF(DateTime? GMICBJPJAKE, long KCAAOMDKNIH, long HPHKCHODKPD, [Out] FLDEFDNOGMD GFNOBBEDINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D91DD0", Offset = "0x7D90FD0", VA = "0x187D91DD0")]
	[AsyncStateMachine(typeof(FFEIMMHEPLE))]
	private Task<IReadOnlyList<(int, AONEBGNACKH, DGAHAKEJLEJ)>> CPLNJCKOJDO(IReadOnlyList<DGAHAKEJLEJ> EMIJABLFDMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GEIMDBFEJML
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FLDEFDNOGMD> HLLHDEMOIDM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ODONGMBIAPH(long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC, NCDJJBLPPNH KMONDJFBELJ);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LNJBKKGDECP(long KCAAOMDKNIH, long HPHKCHODKPD, [Out] FLDEFDNOGMD GFNOBBEDINA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MAGAKEPBMCF(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, [Out] FLDEFDNOGMD GFNOBBEDINA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEFIKKIJPIF(long KCAAOMDKNIH, long HPHKCHODKPD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IHIBHEFPCBK : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GCGCGJNLPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task JBHFONGBMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMEHGEFCMLM(Task JJCLBODJJAC, string OCGEOMEEIHA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface GMBJDHDGECL : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KLKDBEPMPLI> NLFOBPPEDPD(FLDEFDNOGMD GFNOBBEDINA);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NOHNCJFAHGB(CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface KDNDMHBGPCF : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LNAMJHHEPDO DGPFGGCBDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEMCNBPEJEE();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKMJGLDCIBJ();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface EEOOMGAHGDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface HOGAEMMAIKH
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan GIMOOHAMCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan ADBNOHHDGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan IABOOIKEDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JCOLKMPKKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MPFFODBIMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool ICHLBFLMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HAAAFBEHPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NAJOHOMNJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MLHKIFCDMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool CIMMJGJBBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool IDIALNKGOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OEMEKMAFHNI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KEKDHGAJBOE
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
public struct GMLPEAHICBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long FJDAKEJJBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long NFFPLNPCCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OEMEKMAFHNI NNILCBOLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception PGFFPNHLDJH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D90150", Offset = "0x7D8F350", VA = "0x187D90150")]
	public GMLPEAHICBN(long FJDAKEJJBCI, long NFFPLNPCCNI, OEMEKMAFHNI NNILCBOLNDI, [CanBeNull] Exception PGFFPNHLDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7D90100", Offset = "0x7D8F300", VA = "0x187D90100")]
	public static GMLPEAHICBN DALNKPHMLDL(DCEEACKECED PLFBJLPBIAD, OEMEKMAFHNI NNILCBOLNDI, [Optional] Exception PGFFPNHLDJH)
	{
		return default(GMLPEAHICBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void ANIEAIKLAOO(GMLPEAHICBN LBBDJNJENGD);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface DMMMKGMLBNC : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CHNFBDCLMDM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ANIEAIKLAOO JCFGJKJLMPJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ANIEAIKLAOO BDKONAGKPNG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ANIEAIKLAOO JFAFGGMOMMO;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HHADBCPBHMO();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFHCDJMCGNO(GMLPEAHICBN LBBDJNJENGD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JPKMGNOCPEK(GMLPEAHICBN LBBDJNJENGD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FBGIHJJCIPM(GMLPEAHICBN LBBDJNJENGD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BALLMLJODFE(KEKDHGAJBOE BFCANANPGGJ, bool GDICEIEOEJN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OKBKAJFNCDB : EEOOMGAHGDG, IDisposable
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
	bool EPOIKHLENGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JLJLJMNLLDD(Reason HIIOCAFDBNN = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLHMNOFPCPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface GCDDOLCNHFB : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus KOGFOOBOCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NCKLMHIDGOL(DCEEACKECED GIOGPIENINB, BFHDIDLNEHP MOOINICOGCG, CancellationToken BAIPNBEOGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OHGMGLIBKCL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3170", Offset = "0x7DA2370", VA = "0x187DA3170")]
	public static bool LPMFMDGEMMI(this GCDDOLCNHFB IHGFLKGFIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task IMGIIFJINKK(CancellationToken GIIKHLJPAKH, int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface JFAHGAEHFDA : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPBAAGFEBNC(IMGIIFJINKK JGHHDEOFBIH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OKOJPAHMDCL : EJMGGDFKJAB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken NOCGNEOCAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ANOENEDKKHA PMEHLBDEPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	APCKJEBLMJJ JNLDEFJLACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EPICOIONIAM LCOFLKIHACE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HLHIINNPBJD BEEJCKPCDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	LHEOODGMJJF HJOHGEECNHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JIEMHCCKOBO JLMBLPAGIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IBKCJDIIGLE BNAHPBGJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	IHIBHEFPCBK PMNJANDAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	GMBJDHDGECL FPEJAMFABIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DMMMKGMLBNC KJGBEJNKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OKBKAJFNCDB HOIEBPHHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GCDDOLCNHFB JJAPEOFJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JFAHGAEHFDA BAOFMAJBHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CIFDPDCNFIG JODFKNPJHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BBGOBGNCLGF GFKCOIHKNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CHAMJEFPGHI NPJHBJBMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FONCOCMPMBL DGMLAGPCDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LFJJMFMMIKG NLKDFGPFPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BFIHLPDIKKA GPACGDDIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CDIKLNAHEEG BACGNCINJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JOOACOGBMBP HJMMIHOOKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OOHMFJPEEND DFNBKNHAJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OLKHEBKFDJM MEKCGPHBMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KDNDMHBGPCF MJFICKLCNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	HOGAEMMAIKH IPBKLKAAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EKPCAHHLKFA AELFDPLLLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GEIMDBFEJML IMCNNDFEJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	HDNOMHMPCPC NNACPLDLDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	POMBJKBIJBC DADFODOMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ABACIFJECMC FPPAKFBCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	IKPNPMMECHH FBDMMOADGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool JPDHEKODHNH
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
	void AEBAJOIPAPG(BFHDIDLNEHP PCKHCELEEOD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CIFDPDCNFIG : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFAPCMBODMM OFEFHMDJLMD(Guid LDHEJEOPGBF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGPGHNCGHLC(Guid LDHEJEOPGBF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKPKGHBBBKF(Guid LDHEJEOPGBF, Task GGEMLBFGGFO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FHLEOAJFMGK(Guid LDHEJEOPGBF, KLKDBEPMPLI KLPGPAKOMEL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(KLKDBEPMPLI, Task)> PPHHGCJGPLC(Guid LDHEJEOPGBF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KMMJGDINDJF : EEOOMGAHGDG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface BBGOBGNCLGF : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OABGHBGOECP(AHCJONDEEIE DCEACFEGBDC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFMFHGAPGKF(AHCJONDEEIE DCEACFEGBDC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BKELAGLEEBH> CDALNHHAHOB(CancellationToken HEDHNGBDJGJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface CHAMJEFPGHI : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFAPCMBODMM LPFCAMBKBOH(AHCJONDEEIE CIFFMLEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIBHOGIBKIC(Guid LDHEJEOPGBF, Task GGEMLBFGGFO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface FONCOCMPMBL : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KLKDBEPMPLI> DGMLAGPCDPB(AHCJONDEEIE AGMJBICPPII);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface LFJJMFMMIKG : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNACBPJKCJM> BCAACFCNNGI(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, DCEEACKECED GIOGPIENINB, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface CDIKLNAHEEG : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLKDBEPMPLI BNLMDNGKOCC(GJGNFGDHFCI FIJGOHBDHEF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BOCMBCMDKMO(string PFECANJBHHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface BFIHLPDIKKA : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AHCJONDEEIE> BHIOEDOAENA(AHCJONDEEIE NKJDMJIDCOG, LDKHAKHICKG BFFNLNLHDNI, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AHCJONDEEIE> JMBDPNOEBPK(CancellationToken KPIINMODKFJ, LDKHAKHICKG BFFNLNLHDNI);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCDEPCDPKFP DHFDBMHJDCE(MBCPBGIAHHB GOAOFFKBLLA, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCDEPCDPKFP BBDEDMECOBF(MBCPBGIAHHB GOAOFFKBLLA, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface JOOACOGBMBP : EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLKDBEPMPLI MJBKELGELDA(GJGNFGDHFCI FIJGOHBDHEF, BKELAGLEEBH BGIMNFJPNPG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLKDBEPMPLI MBJCMGIGMAF(GJGNFGDHFCI PDJEIBBABLL);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FGGJAJBLNFC
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int BGELFPPFECH = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, NADNLLDMLID> CEAMCDGHICP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action ACDGOLJNHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> IMMDNAIMJHG();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task PEJANEPJKKH([Optional] CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LGLGPBNPGIM([Optional] CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OOHMFJPEEND
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEGCIBGBCBJ(OICEGJBLAJM KGNIHOMDFDM);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHFGFDOBIOE(OICEGJBLAJM KGNIHOMDFDM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLHOAEKNBAE(OICEGJBLAJM KGNIHOMDFDM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGDAEJFHDAG(OICEGJBLAJM KGNIHOMDFDM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OICEGJBLAJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly DCEEACKECED NGBBBKGACEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> HICGIAOIDCI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public AGOOCHPPHOP<string> FFEAJECBAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public OICEGJBLAJM(DCEEACKECED EGGCEGONBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3F20", Offset = "0x7DA3120", VA = "0x187DA3F20")]
	public OICEGJBLAJM KOGAEJBNKFL(string MBDBONINAPC, string OMFJNFBDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3E90", Offset = "0x7DA3090", VA = "0x187DA3E90")]
	public bool DJKCJCKGLPL([Out] IEnumerable<KeyValuePair<string, string>> NJNDPLNILOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BE70", Offset = "0x6E4B070", VA = "0x186E4BE70")]
	public OICEGJBLAJM EAHOEMFJLAO(AGOOCHPPHOP<string> MLINJELIMFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EKPCAHHLKFA
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FGKJFPEJADL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CJGHNHIJIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JDCMDNEPOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIIHOPFKHJC();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPDPBNNNMLI CCJENJLOILF(long AKDHEFBHHEM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GCEJENCOLBB<MMBNINEADFK, LAJHLLHOHBL> JDEHBEFOMFM(long AKDHEFBHHEM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GCEJENCOLBB<MMBNINEADFK, HKFACLJBOKN> ONFOHAMKKAC(long AKDHEFBHHEM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GCEJENCOLBB<long, FKCHFKNPPJJ> GJCAIFIOAGG();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<KLOJHPLIIPH>> JDCNKJNCMBD(long AKDHEFBHHEM, IReadOnlyCollection<KLOJHPLIIPH> KPNAKBCEMIB, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NHBFOFFAAKK(long AKDHEFBHHEM, [Out] bool HFKFGPNMNBB);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> GJGMMNHLPFP(byte[] EMKKMOEAANC, byte[] HEELDKPGNPB, IReadOnlyCollection<Guid> FPMOHCFJHEH, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KJAHHAOJJBK
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNACBPJKCJM JENMMFKNHKF(long FJDAKEJJBCI, long NFFPLNPCCNI, string GKPPNHGGCHI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNACBPJKCJM JENMMFKNHKF(long FJDAKEJJBCI, long NFFPLNPCCNI, MMBNINEADFK EMKKMOEAANC, Guid? DLJNNAGIBHN, long KABHILPEPNB, bool KGMLFDOODMA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNACBPJKCJM JENMMFKNHKF(FCICKLINDLO JKFDNAJJIKD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNACBPJKCJM JENMMFKNHKF(AELLMCLLHFN ABFAHKGEPBG, DGAHAKEJLEJ BCNHMPKMAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface EJMGGDFKJAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool LPMFMDGEMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool PMIKEPOLMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool JPDHEKODHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	KJAHHAOJJBK IILBCABPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	BFHDIDLNEHP NBPGCHCIBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action CHNFBDCLMDM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event ANIEAIKLAOO JCFGJKJLMPJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ANIEAIKLAOO BDKONAGKPNG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event ANIEAIKLAOO JFAFGGMOMMO;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KLHMNOFPCPJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ILGGHPDIBFD DMCODAMEDPP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LKPENNDKMMF KDKKPBHPJEB();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task KIOLHEFJLFE(int BLIGPFACMIG, JKFKKPNMGNI KPFKBHEJGDG, Func<OACJBLAPPIE, OACJBLAPPIE> APAIGGIABEH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<KLKDBEPMPLI> NLFOBPPEDPD(FLDEFDNOGMD KJOBADLNJGB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NOHNCJFAHGB(CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HLHIINNPBJD
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NNOPMHLFOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool LLDPONDLIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? KBLOJMEHBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFLINFHHIOD(Scene LKDMLKAMMEN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NHIALJOKCFO(HODAFIKOEPP CLGDNAMKPHK, IReadOnlyList<HODAFIKOEPP> IAKAIBHHHLN, IReadOnlyList<HODAFIKOEPP> JDDIJADEILL, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NFHDIILEEGL(HPHJCLDCIFB HJJJDKINAHA);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OBOPAIOKNAH(IReadOnlyList<Guid> NKPGMFENEFL, CancellationToken LFGLGGOIFMC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PJPNKJFDJAD DGAOKCKIMGL();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task DFDKHOCPFMP();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task BFHHBIOHFEA();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MGJHPJBBLPE
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool DIFLMCEILFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool KFAJCAHEJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool NNGENBIPOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool NCDOMGEGMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int PCGNGGNHFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool GOOJPLKEBAO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool LCBBCLMALDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int JJJDKLHCDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int KLDHDGECCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool GINJLBHBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool GEKJBPDADPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool GPMLFGKICMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float AHHBPNFCLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> PINMNDIGOEC;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANOENEDKKHA LEMCPFEFBOH(ANOENEDKKHA BDFODELEDCH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNGMBCPKFPI(ANOENEDKKHA GFOILLNHEFN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLJLFMACNMG();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DIFHEHMBOAD(AGOOCHPPHOP<string>.ABBPACGFNKJ HEFLKEOKKLK, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCFIBOEAAJC(float DNNMNKNHFJD);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OGHOCCFKHML(string OOCHKCHNNFA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<GNEMDIILJJK> DCEPJMFBKKO();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable NEGABPFBMGK(object IBLIOEFMDMM, GNEMDIILJJK BNLCMDHEADN);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<AIKOBDJNFOG> IDHHFONOHDF();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LAJHLLHOHBL BNEMHBKDDMH(IEnumerable<KAGCABDCBHB> PNMPINBPHEN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EHHFIEMEBIC(int GEDIIGIDHKB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task KOGOEIIMCKF();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HLAJHKNIFBJ();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KCPJCFJJFDL();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BMDJJFBLAHB(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task DJNAIAMBBEH(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<FKGPPDNDGMO> IEHLNFIIDMM(DateTime FKPFEBFFDMG, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> OIHHNBJBDGJ(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FCCDHDEGBKO(string DCEACFEGBDC = "", float MBNMMCCMGDC = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BADNMFAKOPK KIENOHGCGPG(LBFHGLMDMIM CKICEELPJDM, AAOJKBBEPMH NHLCNELBIHF, HKFACLJBOKN IAHPDEBNPIK, IEnumerable<PersistenceView> ALAMLDPHMGI, HMDAMBJBOKL EFGLGCACOME);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DPHJGODMPMI(HKFACLJBOKN IAHPDEBNPIK);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MPNFJABAEIE(KAGCABDCBHB CPOBHMMPOAL, [In] BADNMFAKOPK FPNMJGKPFDH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task APAIAPMGKJN(HKFACLJBOKN IGEGFGAAILO, bool NLFDACGFLLF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task PLMEPPNMPPP(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OLBEKJCJODE(long KCAAOMDKNIH, long NFFPLNPCCNI, AELLMCLLHFN ADEJBLKPJCF, DGAHAKEJLEJ JDAAINMNGIA, OACJBLAPPIE HAJPGAGBAGC, JKFKKPNMGNI? KPFKBHEJGDG, PFFHBCJMHCN? IDGCPBDFJAF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DNOCANLBEMI(long KCAAOMDKNIH, long NFFPLNPCCNI, PFFHBCJMHCN? IDGCPBDFJAF);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KMODOONFCBH(PersistenceView KFMCOHGEGAG);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BPJOJCKHDPK(string HGJJFBKINHA, DCEEACKECED EGGCEGONBOC, BPGCHHIIALM KPPPMECLGJI, [Optional] string? JFPJNBABKPE, [Optional] string? NKACPNJDCID, [Optional] string? ABEKCECFGJP);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool ICMCKHFICFJ(PersistenceView JEEIAMNAPAO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool ODPCDHHFNJC(KAGCABDCBHB CPOBHMMPOAL, EGINAFIELCE GHLNCENHFDM, [Out] LFFBJMMABAE KJHKLJNPMGL);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task KHFHDFNKIDA(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void IBKFBPFPOAE();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable EPJOOBDMFKB();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void LDGPMFAJONK(HKFACLJBOKN IGEGFGAAILO, EGINAFIELCE GHLNCENHFDM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> BLKKKBBCDLF(APCKJEBLMJJ IMAAHCGDBEG, CancellationToken KPIINMODKFJ, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void JMIHCOPLLKN(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FCICKLINDLO> KGNIDAIEIHL(MMEEKKCOAAG NKJDMJIDCOG);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<AELLMCLLHFN> BBAMMBJHPJE(long KCAAOMDKNIH, bool MFDHACILPND, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<DFMNJLHLEJJ> LMKJLBHIFGP(long KCAAOMDKNIH, long NFFPLNPCCNI, long KABHILPEPNB, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<DFMNJLHLEJJ> BCKLFAMNGIJ(long KCAAOMDKNIH, long NFFPLNPCCNI, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	GCEJENCOLBB<NLGNBINCOCE, IEnumerable<LBDMABPMNIA>> ACLBGBIDEPL();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<KPKMHPKPMHN> IKDKANOLCMK(string GKPPNHGGCHI, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<KPKMHPKPMHN> NCFNOKHAMGN(string GKPPNHGGCHI, long KCAAOMDKNIH, long NFFPLNPCCNI, Guid? BKFAPPIPDIN, JLLIDOHIODH.JKPAPCBAMGJ JEICPGHJIDH, JLLIDOHIODH.JKPAPCBAMGJ HEELDKPGNPB, int BLIGPFACMIG);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool NKBCNKJKDAA();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool NMALGLLMFAC();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool GAABCHJFPJD(IEnumerable<LFFBJMMABAE> BPHPGHFJLNG);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void OEHCLCCPJEK(List<GameObject> HIIAHDEKENE);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float IEJIELDLLPA();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task<bool> LLFEAJPMEHP(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<Scene> FHNFBHICDOM(string KHFLPBDLHLB, LoadSceneMode MAJMBOBLCJM, bool MJALFHIMEFL, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void OGIPGOBLKPH();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BHBFAKOKBPL(bool DOAMCAICJBD);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void FEKFDBMHPMG();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AOEMFGMFJIA();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MMOJBJJJKGJ(bool IKHALEGNJIF);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void LLMFGIKBDJB(DCEEACKECED CNADGJBNNEO);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task AJKFBIEAEKD(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task IMBKOKPMCOD(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task DBFDCPCLFOB(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task AAGCENKNNJJ(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	IDisposable IKMKNIPAACH();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	GHKAOHBFGHI OKDEIDFBAPN();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	Task OPAMAGBLEHG(CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GHKAOHBFGHI
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GPMDOIPNFHL(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LIHCOKMMAPF(CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BADNMFAKOPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> DIPIFMJCFHF;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum FKGPPDNDGMO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LBFHGLMDMIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? EIGKBGFLILH;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IHCEMGMGPLM
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DCEEACKECED OAFPDKKGMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	AELLMCLLHFN NMEBGLMKIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	BJLNPLMLHJE DOHIBMHBNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool OHOPIGOIGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool NDFOPIFLGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int OCKBCEHHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action FOLJPHBFHAO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> CFDLIDPDMGI;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GLDJBFLBAAI();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LOLCFHIHAGD> CMCMOIMANJA(long AKDHEFBHHEM, [Optional] CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KBBHGNGFMNG> BPCAEDJDNPH(DCEEACKECED EGGCEGONBOC, [Optional] BFHDIDLNEHP MOOINICOGCG);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<KBBHGNGFMNG> IHMMIGDCFLM();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FHJDLDGCLIO();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(DCEEACKECED, BFHDIDLNEHP) ENPMJNFHLNP();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BAIODOPPBMJ MEMGHLBMBOI();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IJGHEMMLCLJ(long AKDHEFBHHEM);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EEPCFKNMBOG(DCEEACKECED EGGCEGONBOC, Matchmaking.FKADNPICGNH CMLOHOMLNDL, (int Major, int? Minor)? CAPIHDDNOAD);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OLKHEBKFDJM
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJJKOCFDOPF([Out] IEnumerable<int> LKAJKICJMAH);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKPLKMGKKEP(NIMCCIBCNBA GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKBLJKGMEHD(NIMCCIBCNBA GIIKHLJPAKH);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JLJMNJMCDKF
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ACMALCBJMML(KLKDBEPMPLI KOPLFBCPDKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface GKKADDMNNLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBKGAAJOLEL(IGOOGFGGDPE.ODFLONFMBEJ JBNAHMIAHDM);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNANLEOJOOO(IGOOGFGGDPE.ODFLONFMBEJ JBNAHMIAHDM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LHEOODGMJJF : GKKADDMNNLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLKDBEPMPLI MNMHMCMHDNP(GJGNFGDHFCI PDJEIBBABLL);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JIEMHCCKOBO : GKKADDMNNLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLKDBEPMPLI BNLMDNGKOCC(GJGNFGDHFCI CIGHHJOJKIO);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DPDPBNNNMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CPEANPEHCAG<EPLJHAOMIIN, ILEHMOEGHGD>> FEOKNLOONPP(Guid? BKFAPPIPDIN, IReadOnlyCollection<KLOJHPLIIPH> NKAKEDIAPHJ, IReadOnlyCollection<KLOJHPLIIPH> MBPADGIAHMB, DKPHJPNIPLK JAIFHLIDLDP, long? KCAAOMDKNIH, long? NFFPLNPCCNI, AJLCGOBAEIE.DLKLBEFPKOI HIMBCBBDNEJ, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class EPLJHAOMIIN
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public HODAFIKOEPP CMHODFPPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<HODAFIKOEPP> JALLKPADDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<HODAFIKOEPP> EPLMAPBHIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0xB44BF0", Offset = "0xB43DF0", VA = "0x180B44BF0")]
	public EPLJHAOMIIN(HODAFIKOEPP ECOHODMDOKD, IReadOnlyList<HODAFIKOEPP> GBKLMPCFIDD, IReadOnlyList<HODAFIKOEPP> BMMHMPAKMEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GCEJENCOLBB<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CPEANPEHCAG<KPOLCABDGNG<TData>, ILEHMOEGHGD>> FFEKFCBNHBF(TGetDataArg DLGGINKGFFM, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class GKGBBKCHFOF : OKOJPAHMDCL, EJMGGDFKJAB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DFGOBIHBDFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public GKGBBKCHFOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public FLDEFDNOGMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<KLKDBEPMPLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D89470", Offset = "0x7D88670", VA = "0x187D89470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D896F0", Offset = "0x7D888F0", VA = "0x187D896F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MMIHEILJOIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GKGBBKCHFOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DA21F0", Offset = "0x7DA13F0", VA = "0x187DA21F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2420", Offset = "0x7DA1620", VA = "0x187DA2420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class FGLDIHOONEP : IEnumerable<EEOOMGAHGDG>, IEnumerable, IEnumerator<EEOOMGAHGDG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EEOOMGAHGDG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public GKGBBKCHFOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private EEOOMGAHGDG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public FGLDIHOONEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C460", Offset = "0x7D8B660", VA = "0x187D8C460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C8C0", Offset = "0x7D8BAC0", VA = "0x187D8C8C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C810", Offset = "0x7D8BA10", VA = "0x187D8C810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EEOOMGAHGDG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C810", Offset = "0x7D8BA10", VA = "0x187D8C810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource JMFODNJEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly ANOENEDKKHA GFOILLNHEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private EBBJFPPIPHC LMPALCFKLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool LCODKHKPAAG;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public APCKJEBLMJJ JNLDEFJLACG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x961610", Offset = "0x960810", VA = "0x180961610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public EPICOIONIAM LCOFLKIHACE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960840", VA = "0x180961640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x961600", Offset = "0x960800", VA = "0x180961600", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x961660", Offset = "0x960860", VA = "0x180961660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HLHIINNPBJD BEEJCKPCDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960870", VA = "0x180961670", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960850", VA = "0x180961650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public LHEOODGMJJF HJOHGEECNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x966D60", Offset = "0x965F60", VA = "0x180966D60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x966D50", Offset = "0x965F50", VA = "0x180966D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JIEMHCCKOBO JLMBLPAGIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x970660", Offset = "0x96F860", VA = "0x180970660", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9707C0", Offset = "0x96F9C0", VA = "0x1809707C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public KJAHHAOJJBK IILBCABPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9707D0", Offset = "0x96F9D0", VA = "0x1809707D0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x970750", Offset = "0x96F950", VA = "0x180970750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public IBKCJDIIGLE BNAHPBGJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x970710", Offset = "0x96F910", VA = "0x180970710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x970670", Offset = "0x96F870", VA = "0x180970670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public IHIBHEFPCBK PMNJANDAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2120", Offset = "0xAD1320", VA = "0x180AD2120", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x117A830", Offset = "0x1179A30", VA = "0x18117A830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GMBJDHDGECL FPEJAMFABIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9707A0", Offset = "0x96F9A0", VA = "0x1809707A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9706F0", Offset = "0x96F8F0", VA = "0x1809706F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public DMMMKGMLBNC KJGBEJNKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xBDB360", Offset = "0xBDA560", VA = "0x180BDB360", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xD5E830", Offset = "0xD5DA30", VA = "0x180D5E830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OKBKAJFNCDB HOIEBPHHHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x969760", Offset = "0x968960", VA = "0x180969760", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x969740", Offset = "0x968940", VA = "0x180969740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GCDDOLCNHFB JJAPEOFJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12C30", VA = "0x180B13A30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xD33230", Offset = "0xD32430", VA = "0x180D33230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JFAHGAEHFDA BAOFMAJBHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC32830", Offset = "0xC31A30", VA = "0x180C32830", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xC32840", Offset = "0xC31A40", VA = "0x180C32840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public CIFDPDCNFIG JODFKNPJHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xBDB190", Offset = "0xBDA390", VA = "0x180BDB190", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xFF3050", Offset = "0xFF2250", VA = "0x180FF3050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KMMJGDINDJF IGFPDDFNLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xBC6550", Offset = "0xBC5750", VA = "0x180BC6550", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xC63500", Offset = "0xC62700", VA = "0x180C63500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public BBGOBGNCLGF GFKCOIHKNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA96D70", Offset = "0xA95F70", VA = "0x180A96D70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA96860", Offset = "0xA95A60", VA = "0x180A96860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public CHAMJEFPGHI NPJHBJBMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x969710", Offset = "0x968910", VA = "0x180969710", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x969790", Offset = "0x968990", VA = "0x180969790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public FONCOCMPMBL DGMLAGPCDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xAA7240", Offset = "0xAA6440", VA = "0x180AA7240", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAA6D30", Offset = "0xAA5F30", VA = "0x180AA6D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public LFJJMFMMIKG NLKDFGPFPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAB49E0", Offset = "0xAB3BE0", VA = "0x180AB49E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xAB2F60", Offset = "0xAB2160", VA = "0x180AB2F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public BFIHLPDIKKA GPACGDDIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA90", Offset = "0x9D9C90", VA = "0x1809DAA90", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAB38A0", Offset = "0xAB2AA0", VA = "0x180AB38A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public CDIKLNAHEEG BACGNCINJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA94F90", Offset = "0xA94190", VA = "0x180A94F90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAA69E0", Offset = "0xAA5BE0", VA = "0x180AA69E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public JOOACOGBMBP HJMMIHOOKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA94FA0", Offset = "0xA941A0", VA = "0x180A94FA0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA91F50", Offset = "0xA91150", VA = "0x180A91F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OOHMFJPEEND DFNBKNHAJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3BD0", Offset = "0x9F2DD0", VA = "0x1809F3BD0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3160", Offset = "0x9F2360", VA = "0x1809F3160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public OLKHEBKFDJM MEKCGPHBMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA82460", Offset = "0xA81660", VA = "0x180A82460", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x107D480", Offset = "0x107C680", VA = "0x18107D480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public KDNDMHBGPCF MJFICKLCNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9F27D0", Offset = "0x9F19D0", VA = "0x1809F27D0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA91780", Offset = "0xA90980", VA = "0x180A91780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public HOGAEMMAIKH IPBKLKAAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F4840", Offset = "0x9F3A40", VA = "0x1809F4840", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xABD140", Offset = "0xABC340", VA = "0x180ABD140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public EKPCAHHLKFA AELFDPLLLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9D83A0", Offset = "0x9D75A0", VA = "0x1809D83A0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9D7490", Offset = "0x9D6690", VA = "0x1809D7490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GEIMDBFEJML IMCNNDFEJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F4560", Offset = "0x9F3760", VA = "0x1809F4560", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HDNOMHMPCPC NNACPLDLDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9D6A10", Offset = "0x9D5C10", VA = "0x1809D6A10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public POMBJKBIJBC DADFODOMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EE0", Offset = "0x9D90E0", VA = "0x1809D9EE0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ABACIFJECMC FPPAKFBCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DB040", Offset = "0x9DA240", VA = "0x1809DB040", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IKPNPMMECHH FBDMMOADGND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9D9450", Offset = "0x9D8650", VA = "0x1809D9450", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BFHDIDLNEHP NBPGCHCIBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9D9640", Offset = "0x9D8840", VA = "0x1809D9640", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xE24DC0", Offset = "0xE23FC0", VA = "0x180E24DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool OJJIFIKAPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F630", Offset = "0x7D8E830", VA = "0x187D8F630", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool PIJIKKCFLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F7A0", Offset = "0x7D8E9A0", VA = "0x187D8F7A0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool CFDAJNGNFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F5E0", Offset = "0x1A1E7E0", VA = "0x181A1F5E0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken PPONJFHDIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EEC0", Offset = "0x7D8E0C0", VA = "0x187D8EEC0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ANOENEDKKHA FAOJMCDCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool MCFJPMPCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1A1F5E0", Offset = "0x1A1E7E0", VA = "0x181A1F5E0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A18B10", Offset = "0x1A17D10", VA = "0x181A18B10", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event Action MIHGNJNLGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F080", Offset = "0x7D8E280", VA = "0x187D8F080", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EE00", Offset = "0x7D8E000", VA = "0x187D8EE00", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event ANIEAIKLAOO NBMKLBCLPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F0E0", Offset = "0x7D8E2E0", VA = "0x187D8F0E0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F5D0", Offset = "0x7D8E7D0", VA = "0x187D8F5D0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event ANIEAIKLAOO CDDOEMMACEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F820", Offset = "0x7D8EA20", VA = "0x187D8F820", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F690", Offset = "0x7D8E890", VA = "0x187D8F690", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event ANIEAIKLAOO GOFJDAILMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EB80", Offset = "0x7D8DD80", VA = "0x187D8EB80", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EB20", Offset = "0x7D8DD20", VA = "0x187D8EB20", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xE24DC0", Offset = "0xE23FC0", VA = "0x180E24DC0", Slot = "39")]
	public void AEBAJOIPAPG(BFHDIDLNEHP PCKHCELEEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F880", Offset = "0x7D8EA80", VA = "0x187D8F880")]
	[UnityEngine.Scripting.Preserve]
	internal GKGBBKCHFOF([KMMHIEIDBEA(null)] ANOENEDKKHA GFOILLNHEFN, [KMMHIEIDBEA(null)] APCKJEBLMJJ IMAAHCGDBEG, [KMMHIEIDBEA(null)] EPICOIONIAM EOMOGMHDBHG, [KMMHIEIDBEA(null)] MGJHPJBBLPE EKJOCLHFECK, [KMMHIEIDBEA(null)] HLHIINNPBJD JNHFLAHHFNC, [KMMHIEIDBEA(null)] LHEOODGMJJF KJJDCAPJGGN, [KMMHIEIDBEA(null)] JIEMHCCKOBO BGBNHCPMMFB, [KMMHIEIDBEA(null)] IBKCJDIIGLE GDKELIHNJLK, [KMMHIEIDBEA(null)] IHIBHEFPCBK IFNICHLDFHC, [KMMHIEIDBEA(null)] GMBJDHDGECL GOCHHDGEAIH, [KMMHIEIDBEA(null)] DMMMKGMLBNC CHFDDPBNFEP, [KMMHIEIDBEA(null)] OKBKAJFNCDB IKCMKKMGIMG, [KMMHIEIDBEA(null)] GCDDOLCNHFB IHGFLKGFIOM, [KMMHIEIDBEA(null)] JFAHGAEHFDA DPILIIBJHAH, [KMMHIEIDBEA(null)] CIFDPDCNFIG JMHDKOIPCBA, [KMMHIEIDBEA(null)] KMMJGDINDJF PEOBKEKCBMC, [KMMHIEIDBEA(null)] BBGOBGNCLGF NOKAAEGIOBO, [KMMHIEIDBEA(null)] CHAMJEFPGHI PLIABIFPICH, [KMMHIEIDBEA(null)] FONCOCMPMBL NCPHCJCHJEM, [KMMHIEIDBEA(null)] LFJJMFMMIKG DHGADAOGBND, [KMMHIEIDBEA(null)] CDIKLNAHEEG FICJBEPHFCP, [KMMHIEIDBEA(null)] BFIHLPDIKKA GBKPDLHACLE, [KMMHIEIDBEA(null)] JOOACOGBMBP IKIBJELCNLM, [KMMHIEIDBEA(null)] OOHMFJPEEND BGIGGJFIIJM, [KMMHIEIDBEA(null)] OLKHEBKFDJM LCCJDPAIEDH, [KMMHIEIDBEA(null)] HOGAEMMAIKH PEFAADKBJGB, [KMMHIEIDBEA(null)] EKPCAHHLKFA DIJGKECAJAJ, [KMMHIEIDBEA(null)] GEIMDBFEJML FJIAPHKPMCA, [KMMHIEIDBEA(null)] HDNOMHMPCPC JNFFFPLMGAF, [KMMHIEIDBEA(null)] POMBJKBIJBC IDBCFACOCDL, [KMMHIEIDBEA(null)] ABACIFJECMC FJFNENFOEBJ, [KMMHIEIDBEA(null)] IKPNPMMECHH CKHELNMFCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F6F0", Offset = "0x7D8E8F0", VA = "0x187D8F6F0")]
	private void PDAIGIIELDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EC70", Offset = "0x7D8DE70", VA = "0x187D8EC70", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E9E0", Offset = "0x7D8DBE0", VA = "0x187D8E9E0", Slot = "51")]
	private void AOGKFFLCFBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EEE0", Offset = "0x7D8E0E0", VA = "0x187D8EEE0", Slot = "52")]
	private ILGGHPDIBFD HHKHMKNGNDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EBE0", Offset = "0x7D8DDE0", VA = "0x187D8EBE0", Slot = "53")]
	private LKPENNDKMMF DMPMAFJALIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F2D0", Offset = "0x7D8E4D0", VA = "0x187D8F2D0", Slot = "55")]
	public Task KIOLHEFJLFE(int BLIGPFACMIG, JKFKKPNMGNI KPFKBHEJGDG, Func<OACJBLAPPIE, OACJBLAPPIE> APAIGGIABEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F1C0", Offset = "0x7D8E3C0", VA = "0x187D8F1C0")]
	private JHJBDAMJBJJ KIOFEMGCJID(int BLIGPFACMIG, JKFKKPNMGNI KPFKBHEJGDG, Func<OACJBLAPPIE, OACJBLAPPIE> APAIGGIABEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EF70", Offset = "0x7D8E170", VA = "0x187D8EF70", Slot = "56")]
	[AsyncStateMachine(typeof(DFGOBIHBDFN))]
	private Task<KLKDBEPMPLI> IMDKLICDJGA(FLDEFDNOGMD GFNOBBEDINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EA30", Offset = "0x7D8DC30", VA = "0x187D8EA30", Slot = "57")]
	[AsyncStateMachine(typeof(MMIHEILJOIF))]
	private Task BLPOBOFIJOD(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F140", Offset = "0x7D8E340", VA = "0x187D8F140")]
	[IteratorStateMachine(typeof(FGLDIHOONEP))]
	private IEnumerable<EEOOMGAHGDG> KECFNGIHMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EE60", Offset = "0x7D8E060", VA = "0x187D8EE60")]
	[CompilerGenerated]
	private void GNJJNEDOMOO(EEOOMGAHGDG BNCELPABAGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KCPHCABILLL : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x15EEBF0", Offset = "0x15EDDF0", VA = "0x1815EEBF0")]
	public KCPHCABILLL(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class KOGOKKNOJDH : EHEKMGMBLAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AADPEBFKHAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<EHEKMGMBLAE.MHOIBEHGCGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<OKBKAJFNCDB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public KOGOKKNOJDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D86CC0", Offset = "0x7D85EC0", VA = "0x187D86CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D86FC0", Offset = "0x7D861C0", VA = "0x187D86FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string GFKAFJLJJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DAF0", Offset = "0x7D9CCF0", VA = "0x187D9DAF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public KOGOKKNOJDH(OKOJPAHMDCL FAFBKMPEOID, MGJHPJBBLPE EKJOCLHFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D9E0", Offset = "0x7D9CBE0", VA = "0x187D9D9E0", Slot = "5")]
	[AsyncStateMachine(typeof(AADPEBFKHAP))]
	public Task<EHEKMGMBLAE.MHOIBEHGCGE> ADHMIGIOCDC(HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class ALGKLALBOBJ : EOLEFHEHNPF, EHEKMGMBLAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct AFEHNCMIOCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<EHEKMGMBLAE.MHOIBEHGCGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public ALGKLALBOBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<OKBKAJFNCDB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private DCEEACKECED <localRoomInstance>5__2;

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
		private TaskAwaiter<EHEKMGMBLAE.MHOIBEHGCGE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D878D0", Offset = "0x7D86AD0", VA = "0x187D878D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D88230", Offset = "0x7D87430", VA = "0x187D88230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string GFKAFJLJJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D883F0", Offset = "0x7D875F0", VA = "0x187D883F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public ALGKLALBOBJ(OKOJPAHMDCL FAFBKMPEOID, MGJHPJBBLPE EKJOCLHFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D882A0", Offset = "0x7D874A0", VA = "0x187D882A0", Slot = "5")]
	[AsyncStateMachine(typeof(AFEHNCMIOCE))]
	public Task<EHEKMGMBLAE.MHOIBEHGCGE> ADHMIGIOCDC(HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class MCCOEAJDKFG : EOLEFHEHNPF, EHEKMGMBLAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HAPECJOMOLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<EHEKMGMBLAE.MHOIBEHGCGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public MCCOEAJDKFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<OKBKAJFNCDB.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<KBBHGNGFMNG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<EHEKMGMBLAE.MHOIBEHGCGE> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7D90170", Offset = "0x7D8F370", VA = "0x187D90170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7D90B60", Offset = "0x7D8FD60", VA = "0x187D90B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string GFKAFJLJJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FF60", Offset = "0x7D9F160", VA = "0x187D9FF60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public MCCOEAJDKFG(OKOJPAHMDCL FAFBKMPEOID, MGJHPJBBLPE EKJOCLHFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FE10", Offset = "0x7D9F010", VA = "0x187D9FE10", Slot = "5")]
	[AsyncStateMachine(typeof(HAPECJOMOLI))]
	public Task<EHEKMGMBLAE.MHOIBEHGCGE> ADHMIGIOCDC(HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class LEGIIKKOBID : EOLEFHEHNPF, EHEKMGMBLAE
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PLMIDKKBCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public KBBHGNGFMNG matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PLMIDKKBCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5D60", Offset = "0x7DA4F60", VA = "0x187DA5D60")]
		internal object DPFKFFJNNAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5DE0", Offset = "0x7DA4FE0", VA = "0x187DA5DE0")]
		internal object LOFBDBHBIKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct EFPNKOOPCDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<EHEKMGMBLAE.MHOIBEHGCGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LEGIIKKOBID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<OKBKAJFNCDB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PLMIDKKBCLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<KBBHGNGFMNG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<EHEKMGMBLAE.MHOIBEHGCGE> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7D899E0", Offset = "0x7D88BE0", VA = "0x187D899E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A600", Offset = "0x7D89800", VA = "0x187D8A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string GFKAFJLJJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E000", Offset = "0x7D9D200", VA = "0x187D9E000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public LEGIIKKOBID(OKOJPAHMDCL FAFBKMPEOID, MGJHPJBBLPE EKJOCLHFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DEB0", Offset = "0x7D9D0B0", VA = "0x187D9DEB0", Slot = "5")]
	[AsyncStateMachine(typeof(EFPNKOOPCDN))]
	public Task<EHEKMGMBLAE.MHOIBEHGCGE> ADHMIGIOCDC(HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class EOLEFHEHNPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct FFEIPCJMODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public PBBCGFNIILA log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<OKBKAJFNCDB.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public EOLEFHEHNPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<OKBKAJFNCDB.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8BEE0", Offset = "0x7D8B0E0", VA = "0x187D8BEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C400", Offset = "0x7D8B600", VA = "0x187D8C400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AE80", Offset = "0x7D8A080", VA = "0x187D8AE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public EOLEFHEHNPF(OKOJPAHMDCL FAFBKMPEOID, MGJHPJBBLPE EKJOCLHFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7D8AD50", Offset = "0x7D89F50", VA = "0x187D8AD50")]
	[AsyncStateMachine(typeof(FFEIPCJMODI))]
	protected Task DPFBAIBAJOE(PBBCGFNIILA NPAEAIAJLAP, HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GMHJCBBMDDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct GAKKHBGFBGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<EHEKMGMBLAE.MHOIBEHGCGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public MGJHPJBBLPE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E580", Offset = "0x7D8D780", VA = "0x187D8E580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E900", Offset = "0x7D8DB00", VA = "0x187D8E900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HGONLFACJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public OKOJPAHMDCL roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HGONLFACJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D91070", Offset = "0x7D90270", VA = "0x187D91070")]
		internal object GOEMJAPHMOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float IFHFKBFPOCH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<OKBKAJFNCDB.Reason> PCKLGDHPCOC;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FED0", Offset = "0x7D8F0D0", VA = "0x187D8FED0")]
	[AsyncStateMachine(typeof(GAKKHBGFBGA))]
	internal static Task<EHEKMGMBLAE.MHOIBEHGCGE> JMHCIEIJOMN(MGJHPJBBLPE EKJOCLHFECK, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7D8FD50", Offset = "0x7D8EF50", VA = "0x187D8FD50")]
	internal static void EICKICBBJFH(OKOJPAHMDCL FAFBKMPEOID, PBBCGFNIILA NPAEAIAJLAP, string HGJJFBKINHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface EHEKMGMBLAE
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct MHOIBEHGCGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool GDICEIEOEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public OKBKAJFNCDB.Reason HIIOCAFDBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? ABEKCECFGJP;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0410", Offset = "0x7D9F610", VA = "0x187DA0410")]
		public static MHOIBEHGCGE MKJMACJPHKF()
		{
			return default(MHOIBEHGCGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7DA03E0", Offset = "0x7D9F5E0", VA = "0x187DA03E0")]
		public static MHOIBEHGCGE KLIHFJCANKP(OKBKAJFNCDB.Reason HIIOCAFDBNN, [Optional] Enum? ABEKCECFGJP)
		{
			return default(MHOIBEHGCGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string CJNLOAJOEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MHOIBEHGCGE> ADHMIGIOCDC(HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct KMJEONHJGIH
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LAJPAJBFNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public OKOJPAHMDCL manager;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LAJPAJBFNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DBA0", Offset = "0x7D9CDA0", VA = "0x187D9DBA0")]
		internal Task MABNAGOHHNI(CancellationToken cancellationToken, int roomTotalVersion, MMOLBELIPAC localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct MKKOCPPAHIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KMJEONHJGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private FLDEFDNOGMD <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<FKGPPDNDGMO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<KLKDBEPMPLI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0750", Offset = "0x7D9F950", VA = "0x187DA0750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0CE0", Offset = "0x7D9FEE0", VA = "0x187DA0CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct ACBACJALNJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KMJEONHJGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7D87030", Offset = "0x7D86230", VA = "0x187D87030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7D87350", Offset = "0x7D86550", VA = "0x187D87350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken KPIINMODKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly OKOJPAHMDCL CKLPHBNMNHA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private APCKJEBLMJJ JNLDEFJLACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D480", Offset = "0x7D9C680", VA = "0x187D9D480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D7F0", Offset = "0x7D9C9F0", VA = "0x187D9D7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D910", Offset = "0x7D9CB10", VA = "0x187D9D910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private GMBJDHDGECL FPEJAMFABIB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D990", Offset = "0x7D9CB90", VA = "0x187D9D990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x25C3460", Offset = "0x25C2660", VA = "0x1825C3460")]
	public KMJEONHJGIH(CancellationToken KPIINMODKFJ, OKOJPAHMDCL CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D3D0", Offset = "0x7D9C5D0", VA = "0x187D9D3D0")]
	public static IMGIIFJINKK EDLLMHDHPNI(OKOJPAHMDCL CKLPHBNMNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D4D0", Offset = "0x7D9C6D0", VA = "0x187D9D4D0")]
	[AsyncStateMachine(typeof(MKKOCPPAHIK))]
	public Task<bool> IDKCINHHAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D5E0", Offset = "0x7D9C7E0", VA = "0x187D9D5E0")]
	private bool LGDCIHAKEBM([Out] FLDEFDNOGMD GFNOBBEDINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D840", Offset = "0x7D9CA40", VA = "0x187D9D840")]
	[AsyncStateMachine(typeof(ACBACJALNJK))]
	private Task NAPJIPPDCDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D2A0", Offset = "0x7D9C4A0", VA = "0x187D9D2A0")]
	private Task<FKGPPDNDGMO> ADDOKMMHKEP(FLDEFDNOGMD OLKOLECGIAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct LFAPCMBODMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly CIFDPDCNFIG JMHDKOIPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid LDHEJEOPGBF;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(KLKDBEPMPLI, Task)> IGAMNIAMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E180", Offset = "0x7D9D380", VA = "0x187D9E180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BA00", Offset = "0x4B1AC00", VA = "0x184B1BA00")]
	public LFAPCMBODMM(CIFDPDCNFIG JMHDKOIPCBA, Guid LDHEJEOPGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E250", Offset = "0x7D9D450", VA = "0x187D9E250")]
	public TaskAwaiter<(KLKDBEPMPLI, Task)> KJDMAOPKNEK()
	{
		return default(TaskAwaiter<(KLKDBEPMPLI, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E0B0", Offset = "0x7D9D2B0", VA = "0x187D9E0B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct MGMCFIBAIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(KLKDBEPMPLI, Task)> NIDHGMEHIAC;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(KLKDBEPMPLI, Task)> IGAMNIAMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0130", Offset = "0x7D9F330", VA = "0x187DA0130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0260", Offset = "0x7D9F460", VA = "0x187DA0260")]
	public MGMCFIBAIGN(TimeSpan KLKCOGKAFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7DA01C0", Offset = "0x7D9F3C0", VA = "0x187DA01C0")]
	public void MCGCOCJHDJH(Task GGEMLBFGGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7DA00A0", Offset = "0x7D9F2A0", VA = "0x187DA00A0")]
	public void FNMOCAEMJNL(KLKDBEPMPLI KOPLFBCPDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0170", Offset = "0x7D9F370", VA = "0x187DA0170")]
	public void JGHDCFCMBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0010", Offset = "0x7D9F210", VA = "0x187DA0010")]
	internal void DJMHLIFFHNP(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class MJNDONHDLJC
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0420", Offset = "0x7D9F620", VA = "0x187DA0420")]
	public static FNACBPJKCJM JJCPEEGECCG(this FNACBPJKCJM FKKLLADNDBA, AELLMCLLHFN KNKIELBEDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7DA05C0", Offset = "0x7D9F7C0", VA = "0x187DA05C0")]
	public static FNACBPJKCJM OEHOMMIDJDI(this FNACBPJKCJM FKKLLADNDBA, DGAHAKEJLEJ HAHDKGEKHJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class BACBAACPNAK : KJAHHAOJJBK
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JDCKJLAKMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public DGAHAKEJLEJ subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JDCKJLAKMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7D93000", Offset = "0x7D92200", VA = "0x187D93000")]
		internal bool PHJHDBOFFKE(BJLNPLMLHJE s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly HOGAEMMAIKH KDBLBJCPGCO;

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public BACBAACPNAK(HOGAEMMAIKH PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7D884A0", Offset = "0x7D876A0", VA = "0x187D884A0", Slot = "4")]
	public FNACBPJKCJM JENMMFKNHKF(long FJDAKEJJBCI, long NFFPLNPCCNI, string GKPPNHGGCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7D88730", Offset = "0x7D87930", VA = "0x187D88730", Slot = "5")]
	public FNACBPJKCJM JENMMFKNHKF(long FJDAKEJJBCI, long NFFPLNPCCNI, MMBNINEADFK EMKKMOEAANC, Guid? DLJNNAGIBHN, long KABHILPEPNB, bool KGMLFDOODMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7D88530", Offset = "0x7D87730", VA = "0x187D88530", Slot = "6")]
	public FNACBPJKCJM JENMMFKNHKF(FCICKLINDLO JKFDNAJJIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7D88890", Offset = "0x7D87A90", VA = "0x187D88890", Slot = "7")]
	public FNACBPJKCJM JENMMFKNHKF(AELLMCLLHFN ABFAHKGEPBG, DGAHAKEJLEJ BCNHMPKMAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7D88B70", Offset = "0x7D87D70", VA = "0x187D88B70")]
	private Guid? LJKPKLOMGBG(AELLMCLLHFN HNJDLFCKAHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class ACHNMOJBNJP : IHIBHEFPCBK, EEOOMGAHGDG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct OBLCCPFDPME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public ACHNMOJBNJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2A80", Offset = "0x7DA1C80", VA = "0x187DA2A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3110", Offset = "0x7DA2310", VA = "0x187DA3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly NIMCCIBCNBA IDMFPEAGLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string KIFFHCGNIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task KGMEEHEMJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GCGCGJNLPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7D87440", Offset = "0x7D86640", VA = "0x187D87440", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task JBHFONGBMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7D873B0", Offset = "0x7D865B0", VA = "0x187D873B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0", Slot = "7")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7D87470", Offset = "0x7D86670", VA = "0x187D87470", Slot = "6")]
	public void LMEHGEFCMLM(Task JJCLBODJJAC, string OCGEOMEEIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7D875D0", Offset = "0x7D867D0", VA = "0x187D875D0")]
	[AsyncStateMachine(typeof(OBLCCPFDPME))]
	private Task OFAEFBKCNLJ(Task EECAOFEPDNG, string OCGEOMEEIHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7D876F0", Offset = "0x7D868F0", VA = "0x187D876F0")]
	public ACHNMOJBNJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class HEFOPGHANMN : KDNDMHBGPCF, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool LPLKBPLMNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private LNAMJHHEPDO LAHIOKLLJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private HOGAEMMAIKH PEFAADKBJGB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public LNAMJHHEPDO DGPFGGCBDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7D90C10", Offset = "0x7D8FE10", VA = "0x187D90C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7D90D40", Offset = "0x7D8FF40", VA = "0x187D90D40", Slot = "7")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7D90EC0", Offset = "0x7D900C0", VA = "0x187D90EC0", Slot = "5")]
	public void PEMCNBPEJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7D90BD0", Offset = "0x7D8FDD0", VA = "0x187D90BD0", Slot = "6")]
	public void NKMJGLDCIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7D90C80", Offset = "0x7D8FE80", VA = "0x187D90C80")]
	private Task PCHGGOEFDGN(EIOAANDKFEH JEBOOCGPANP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7D90BD0", Offset = "0x7D8FDD0", VA = "0x187D90BD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public HEFOPGHANMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class MMCNCDBIJEM : HOGAEMMAIKH
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class PMJNIKFMIAA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly JDFJKMABMDJ PGKELCELKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string MBDBONINAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T OGPHJJMKHNA;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB96CD0", Offset = "0xB95ED0", VA = "0x180B96CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5134D00", Offset = "0x5133F00", VA = "0x185134D00")]
		public PMJNIKFMIAA(JDFJKMABMDJ PGKELCELKPP, string MBDBONINAPC, T OGPHJJMKHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5134420", Offset = "0x5133620", VA = "0x185134420")]
		private void NDFNHBHEGBL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly JDFJKMABMDJ PGKELCELKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly PMJNIKFMIAA<TimeSpan> KDNDMHJDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly PMJNIKFMIAA<TimeSpan> CPJMFBOKBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly PMJNIKFMIAA<TimeSpan> ELNKDKDLNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly PMJNIKFMIAA<TimeSpan> GNPGBDFAKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PMJNIKFMIAA<bool> LBNONEGLFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PMJNIKFMIAA<bool> KHDEPDPCKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly PMJNIKFMIAA<bool> EEPPODANAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly PMJNIKFMIAA<int> MOKLMOEHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly PMJNIKFMIAA<bool> POKBAAHEPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly PMJNIKFMIAA<bool> EGCJMNFPPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly PMJNIKFMIAA<OKEMGKIMBMH> EFCIHLFFIPB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan GIMOOHAMCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1B90", Offset = "0x7DA0D90", VA = "0x187DA1B90", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan ADBNOHHDGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1A50", Offset = "0x7DA0C50", VA = "0x187DA1A50", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan IABOOIKEDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1C10", Offset = "0x7DA0E10", VA = "0x187DA1C10", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan JCOLKMPKKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1B50", Offset = "0x7DA0D50", VA = "0x187DA1B50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MPFFODBIMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1C50", Offset = "0x7DA0E50", VA = "0x187DA1C50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool ICHLBFLMFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1A90", Offset = "0x7DA0C90", VA = "0x187DA1A90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool HAAAFBEHPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1C90", Offset = "0x7DA0E90", VA = "0x187DA1C90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NAJOHOMNJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1AD0", Offset = "0x7DA0CD0", VA = "0x187DA1AD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MLHKIFCDMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1B10", Offset = "0x7DA0D10", VA = "0x187DA1B10", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool CIMMJGJBBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1BD0", Offset = "0x7DA0DD0", VA = "0x187DA1BD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool IDIALNKGOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1CD0", Offset = "0x7DA0ED0", VA = "0x187DA1CD0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1D20", Offset = "0x7DA0F20", VA = "0x187DA1D20")]
	[UnityEngine.Scripting.Preserve]
	public MMCNCDBIJEM([KMMHIEIDBEA(null)] JDFJKMABMDJ PGKELCELKPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class MBNPGGDIJAN : DMMMKGMLBNC, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EOFFBLOBGOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public GMLPEAHICBN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EOFFBLOBGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AC70", Offset = "0x7D89E70", VA = "0x187D8AC70")]
		internal object LGDPPHNEFAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[CompilerGenerated]
	private Action<KEKDHGAJBOE, bool> BEBAGALJDNE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action CHNFBDCLMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F640", Offset = "0x7D9E840", VA = "0x187D9F640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F970", Offset = "0x7D9EB70", VA = "0x187D9F970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event ANIEAIKLAOO JCFGJKJLMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FC30", Offset = "0x7D9EE30", VA = "0x187D9FC30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FCD0", Offset = "0x7D9EED0", VA = "0x187D9FCD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ANIEAIKLAOO BDKONAGKPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F6E0", Offset = "0x7D9E8E0", VA = "0x187D9F6E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FD70", Offset = "0x7D9EF70", VA = "0x187D9FD70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event ANIEAIKLAOO JFAFGGMOMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F570", Offset = "0x7D9E770", VA = "0x187D9F570", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F480", Offset = "0x7D9E680", VA = "0x187D9F480", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "17")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F780", Offset = "0x7D9E980", VA = "0x187D9F780", Slot = "12")]
	public void HHADBCPBHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FC00", Offset = "0x7D9EE00", VA = "0x187D9FC00", Slot = "13")]
	public void MFHCDJMCGNO(GMLPEAHICBN LBBDJNJENGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FA10", Offset = "0x7D9EC10", VA = "0x187D9FA10", Slot = "14")]
	public void JPKMGNOCPEK(GMLPEAHICBN LBBDJNJENGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F610", Offset = "0x7D9E810", VA = "0x187D9F610", Slot = "15")]
	public void FBGIHJJCIPM(GMLPEAHICBN LBBDJNJENGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F520", Offset = "0x7D9E720", VA = "0x187D9F520", Slot = "16")]
	public void BALLMLJODFE(KEKDHGAJBOE BFCANANPGGJ, bool GDICEIEOEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FA40", Offset = "0x7D9EC40", VA = "0x187D9FA40")]
	private void LKNMLKMEAKD(ANIEAIKLAOO BNLCMDHEADN, GMLPEAHICBN LBBDJNJENGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MBNPGGDIJAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class LKIDDKHMLFN : OKBKAJFNCDB, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class FKELOJDLECB : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct PJOEFGPNGEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public FKELOJDLECB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public OKBKAJFNCDB.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private IFOOKNGMDBJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private EHEKMGMBLAE[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<EHEKMGMBLAE.MHOIBEHGCGE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4C10", Offset = "0x7DA3E10", VA = "0x187DA4C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5340", Offset = "0x7DA4540", VA = "0x187DA5340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct ILIOHHOKHIN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<EHEKMGMBLAE.MHOIBEHGCGE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public EHEKMGMBLAE fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public FKELOJDLECB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public OKBKAJFNCDB.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private IFOOKNGMDBJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private NDPFDHHIEGL <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<EHEKMGMBLAE.MHOIBEHGCGE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7D92210", Offset = "0x7D91410", VA = "0x187D92210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7D92EA0", Offset = "0x7D920A0", VA = "0x187D92EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class PECANJCDOKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public EHEKMGMBLAE fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public PECANJCDOKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x7DA48C0", Offset = "0x7DA3AC0", VA = "0x187DA48C0")]
			internal object LHPGHHGJBBM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task JJCLBODJJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource MLNGJPIHIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NDPFDHHIEGL CONICNCAIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public MGJHPJBBLPE EKJOCLHFECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BPGCHHIIALM KPPPMECLGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DCEEACKECED EGGCEGONBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public EHEKMGMBLAE[] FKNAFLKIIPC;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool CMJCGBCLKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7D8CC90", Offset = "0x7D8BE90", VA = "0x187D8CC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HMOGDNKLBME
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C910", Offset = "0x7D8BB10", VA = "0x187D8C910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E460", Offset = "0x7D8D660", VA = "0x187D8E460")]
		public FKELOJDLECB(MGJHPJBBLPE EKJOCLHFECK, BPGCHHIIALM KPPPMECLGJI, DCEEACKECED EGGCEGONBOC, EHEKMGMBLAE[] FKNAFLKIIPC, CancellationToken KPIINMODKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7D8CB00", Offset = "0x7D8BD00", VA = "0x187D8CB00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D5D0", Offset = "0x7D8C7D0", VA = "0x187D8D5D0")]
		public void KIPDMLIOINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D640", Offset = "0x7D8C840", VA = "0x187D8D640")]
		public void MDKFKHJNEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D220", Offset = "0x7D8C420", VA = "0x187D8D220")]
		public void INLCGOGOJEB(OKBKAJFNCDB.Reason EHOGPOMLDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D4D0", Offset = "0x7D8C6D0", VA = "0x187D8D4D0")]
		[AsyncStateMachine(typeof(PJOEFGPNGEN))]
		public Task KDIJDMGBFKB(OKBKAJFNCDB.Reason HIIOCAFDBNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D850", Offset = "0x7D8CA50", VA = "0x187D8D850")]
		[AsyncStateMachine(typeof(ILIOHHOKHIN))]
		private Task<EHEKMGMBLAE.MHOIBEHGCGE> MKHPOHKBMFO(OKBKAJFNCDB.Reason HIIOCAFDBNN, EHEKMGMBLAE CEGJGEFNOKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D100", Offset = "0x7D8C300", VA = "0x187D8D100")]
		private void FLBJBGHNBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D7A0", Offset = "0x7D8C9A0", VA = "0x187D8D7A0")]
		public bool MHEIHKBOOEH(OKBKAJFNCDB.Reason NMGNOKHIAAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8CCB0", Offset = "0x7D8BEB0", VA = "0x187D8CCB0")]
		private void EBGAMPPGDEN(NDPFDHHIEGL LEOMHHEDCFC, OKBKAJFNCDB.Reason HIIOCAFDBNN = OKBKAJFNCDB.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C930", Offset = "0x7D8BB30", VA = "0x187D8C930")]
		private void CPHCGIAFKGH(NDPFDHHIEGL LEOMHHEDCFC, EHEKMGMBLAE.MHOIBEHGCGE CMLOHOMLNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8CF60", Offset = "0x7D8C160", VA = "0x187D8CF60")]
		private void FDMFHCMPEHE(NDPFDHHIEGL LEOMHHEDCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7D8D990", Offset = "0x7D8CB90", VA = "0x187D8D990")]
		private void NBOGLKBKOJL(NDPFDHHIEGL LEOMHHEDCFC, EHEKMGMBLAE.MHOIBEHGCGE CMLOHOMLNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DD50", Offset = "0x7D8CF50", VA = "0x187D8DD50")]
		private void OHJOJCJHCHF(NDPFDHHIEGL LEOMHHEDCFC, Exception GMEDNHNLLCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DFC0", Offset = "0x7D8D1C0", VA = "0x187D8DFC0")]
		private void PPHCCKMKKEI(EHEKMGMBLAE CEGJGEFNOKP, OKBKAJFNCDB.Reason HIIOCAFDBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7D8DEB0", Offset = "0x7D8D0B0", VA = "0x187D8DEB0")]
		private void OLJKNOGCMKC(EHEKMGMBLAE CEGJGEFNOKP, OKBKAJFNCDB.Reason HIIOCAFDBNN, string ABEKCECFGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E0D0", Offset = "0x7D8D2D0", VA = "0x187D8E0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class NDPFDHHIEGL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<EHEKMGMBLAE.MHOIBEHGCGE> JJCLBODJJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource MLNGJPIHIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public EHEKMGMBLAE CEGJGEFNOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public OKBKAJFNCDB.Reason EHOGPOMLDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<OKBKAJFNCDB.Reason> MMBBNJODIOL;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool CMJCGBCLKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x7D8CC90", Offset = "0x7D8BE90", VA = "0x187D8CC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool HMOGDNKLBME
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C910", Offset = "0x7D8BB10", VA = "0x187D8C910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7DA24A0", Offset = "0x7DA16A0", VA = "0x187DA24A0")]
		public void OGCCBPDGCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2480", Offset = "0x7DA1680", VA = "0x187DA2480", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2600", Offset = "0x7DA1800", VA = "0x187DA2600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2970", Offset = "0x7DA1B70", VA = "0x187DA2970")]
		public NDPFDHHIEGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class ADBGENMLIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public OKBKAJFNCDB.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ADBGENMLIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7D87780", Offset = "0x7D86980", VA = "0x187D87780")]
		internal object CNGGGKOIECF(NDPFDHHIEGL x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7D877F0", Offset = "0x7D869F0", VA = "0x187D877F0")]
		internal object IHGHLHIAJMP(FKELOJDLECB x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D87860", Offset = "0x7D86A60", VA = "0x187D87860")]
		internal object LEKKFKHFMJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct HOJMCLAFCJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public OKBKAJFNCDB.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public LKIDDKHMLFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private ADBGENMLIEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D91170", Offset = "0x7D90370", VA = "0x187D91170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D91BD0", Offset = "0x7D90DD0", VA = "0x187D91BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct OHNMNLGNCJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public LKIDDKHMLFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public OKBKAJFNCDB.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private FKELOJDLECB <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA31C0", Offset = "0x7DA23C0", VA = "0x187DA31C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3E30", Offset = "0x7DA3030", VA = "0x187DA3E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct FDEMMDEEJFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public LKIDDKHMLFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D8AED0", Offset = "0x7D8A0D0", VA = "0x187D8AED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B440", Offset = "0x7D8A640", VA = "0x187D8B440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly PBBCGFNIILA CHBPKPHNCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private FKELOJDLECB CGLFGBKDAKH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7D9ED70", Offset = "0x7D9DF70", VA = "0x187D9ED70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool EPOIKHLENGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2166F70", Offset = "0x2166170", VA = "0x182166F70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool IAILDEMKHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E2A0", Offset = "0x7D9D4A0", VA = "0x187D9E2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7D9F010", Offset = "0x7D9E210", VA = "0x187D9F010", Slot = "7")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E7C0", Offset = "0x7D9D9C0", VA = "0x187D9E7C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EE90", Offset = "0x7D9E090", VA = "0x187D9EE90", Slot = "9")]
	public void OGCCBPDGCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E6E0", Offset = "0x7D9D8E0", VA = "0x187D9E6E0")]
	private bool DJEMANEEIBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EDC0", Offset = "0x7D9DFC0", VA = "0x187D9EDC0", Slot = "6")]
	private void NPFELOFAFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EB70", Offset = "0x7D9DD70", VA = "0x187D9EB70", Slot = "5")]
	[AsyncStateMachine(typeof(HOJMCLAFCJB))]
	private Task LFHHHECDPGL(OKBKAJFNCDB.Reason HIIOCAFDBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E7D0", Offset = "0x7D9D9D0", VA = "0x187D9E7D0")]
	private bool GPFNECDEIFN(OKBKAJFNCDB.Reason HIIOCAFDBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E310", Offset = "0x7D9D510", VA = "0x187D9E310")]
	private EHEKMGMBLAE[] BKJOONCHIFP(DCEEACKECED LENKPMNANLO, BPGCHHIIALM OBHNFGBFFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EC60", Offset = "0x7D9DE60", VA = "0x187D9EC60")]
	[AsyncStateMachine(typeof(OHNMNLGNCJC))]
	private Task MNBEPAAOOPK(OKBKAJFNCDB.Reason HIIOCAFDBNN, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9EAA0", Offset = "0x7D9DCA0", VA = "0x187D9EAA0")]
	[AsyncStateMachine(typeof(FDEMMDEEJFP))]
	private Task HAINEHIEBKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LKIDDKHMLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class JOCHJLMJBAC : GCDDOLCNHFB, EEOOMGAHGDG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct PKLGOFHJGFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public BFHDIDLNEHP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DA53A0", Offset = "0x7DA45A0", VA = "0x187DA53A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5D00", Offset = "0x7DA4F00", VA = "0x187DA5D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MLECCAOBIKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public BFHDIDLNEHP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private AGOOCHPPHOP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IFOOKNGMDBJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private LDKHAKHICKG <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private OICEGJBLAJM <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0D50", Offset = "0x7D9FF50", VA = "0x187DA0D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DA19F0", Offset = "0x7DA0BF0", VA = "0x187DA19F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class IHEFBBBGHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.FKADNPICGNH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public MPMBFLBDMHG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IHEFBBBGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D92160", Offset = "0x7D91360", VA = "0x187D92160")]
		internal object BGAJFIIDCBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HEBMCAPHFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<FNACBPJKCJM> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HEBMCAPHFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		internal Task<FNACBPJKCJM> DBMJAIHFFOA(AGOOCHPPHOP<string>.ABBPACGFNKJ _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct KLMELMAFBCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public BFHDIDLNEHP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public LDKHAKHICKG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private HEBMCAPHFOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private OKGFHNJKKJH <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IFOOKNGMDBJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private MLLBPDODABK <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.LOLCFHIHAGD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private KNEHOLBKBDE <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.LOLCFHIHAGD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<FNACBPJKCJM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D97800", Offset = "0x7D96A00", VA = "0x187D97800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D240", Offset = "0x7D9C440", VA = "0x187D9D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct AGIHICGIAFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <disconnectTimerScope>5__3;

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
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DA88D0", Offset = "0x7DA7AD0", VA = "0x187DA88D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9330", Offset = "0x7DA8530", VA = "0x187DA9330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct ECAGEIDDOLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ANOENEDKKHA <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0870", Offset = "0x7DAFA70", VA = "0x187DB0870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0CF0", Offset = "0x7DAFEF0", VA = "0x187DB0CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct HGHLHBKIEKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.LOLCFHIHAGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.LOLCFHIHAGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7180", Offset = "0x7DB6380", VA = "0x187DB7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7650", Offset = "0x7DB6850", VA = "0x187DB7650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IEFLNPMNKNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.LOLCFHIHAGD serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public LDKHAKHICKG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<NNHHOEKKBAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7DA0", Offset = "0x7DB6FA0", VA = "0x187DB7DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DB83E0", Offset = "0x7DB75E0", VA = "0x187DB83E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class NJGAIHDAGGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NJGAIHDAGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2290", Offset = "0x7DC1490", VA = "0x187DC2290")]
		internal object AAPGKOHOKCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2390", Offset = "0x7DC1590", VA = "0x187DC2390")]
		internal string BKDDKJCFOHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct FCGNJHPFHJB : IAsyncStateMachine
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
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private NJGAIHDAGGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IFOOKNGMDBJ <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2B70", Offset = "0x7DB1D70", VA = "0x187DB2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3700", Offset = "0x7DB2900", VA = "0x187DB3700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct BOIHNJMNJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public LDKHAKHICKG joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public FNACBPJKCJM initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public DCEEACKECED targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public OKGFHNJKKJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC190", Offset = "0x7DAB390", VA = "0x187DAC190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC980", Offset = "0x7DABB80", VA = "0x187DAC980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CLABHBJLKJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private IFOOKNGMDBJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap3;

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
		private IFOOKNGMDBJ <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DADC00", Offset = "0x7DACE00", VA = "0x187DADC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF3E0", Offset = "0x7DAE5E0", VA = "0x187DAF3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct PPFLLFKFAIG : IAsyncStateMachine
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
		public MMOLBELIPAC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public JOCHJLMJBAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<KLKDBEPMPLI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4660", Offset = "0x7DC3860", VA = "0x187DC4660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4E50", Offset = "0x7DC4050", VA = "0x187DC4E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ALPILDMIONO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ALPILDMIONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA3B0", Offset = "0x7DA95B0", VA = "0x187DAA3B0")]
		internal object PJGLBLPKGMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class KOFBCJNHKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KOFBCJNHKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF0C0", Offset = "0x7DBE2C0", VA = "0x187DBF0C0")]
		internal void MPKOAEAMPNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class LLCEPKNBOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LLCEPKNBOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1200", Offset = "0x7DC0400", VA = "0x187DC1200")]
		internal object HLPPIKJFLKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class JIMEABPDHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JIMEABPDHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC440", Offset = "0x7DBB640", VA = "0x187DBC440")]
		internal string KFCIINNAFCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly PBBCGFNIILA LDIOALJBEIF;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly PBBCGFNIILA PJGJJBADJHL;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly PBBCGFNIILA KCIKADLKLME;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string BCFMFLEADGH;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string LNBBCONPJII;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string NPMIAGBIAKE;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid KLBLHNNJCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private IBKCJDIIGLE GDKELIHNJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private EPICOIONIAM EOMOGMHDBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private OKBKAJFNCDB IKCMKKMGIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private IHIBHEFPCBK IFNICHLDFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private DMMMKGMLBNC CHFDDPBNFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private POMBJKBIJBC IDBCFACOCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private HDNOMHMPCPC JNFFFPLMGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable EJHKEGHPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private IKPNPMMECHH CKHELNMFCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly NIMCCIBCNBA INOCFPMELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private KNEHOLBKBDE BBIACEHODNK;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus KOGFOOBOCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x989F40", Offset = "0x989140", VA = "0x180989F40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x11712B0", Offset = "0x11704B0", VA = "0x1811712B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D96840", Offset = "0x7D95A40", VA = "0x187D96840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D96CF0", Offset = "0x7D95EF0", VA = "0x187D96CF0", Slot = "6")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D949E0", Offset = "0x7D93BE0", VA = "0x187D949E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D963D0", Offset = "0x7D955D0", VA = "0x187D963D0", Slot = "5")]
	[AsyncStateMachine(typeof(PKLGOFHJGFI))]
	public Task NCKLMHIDGOL(DCEEACKECED GIOGPIENINB, BFHDIDLNEHP MOOINICOGCG, CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D97420", Offset = "0x7D96620", VA = "0x187D97420")]
	[AsyncStateMachine(typeof(MLECCAOBIKB))]
	private Task PJOKBPBBLMO(DCEEACKECED GIOGPIENINB, BFHDIDLNEHP MOOINICOGCG, CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D96890", Offset = "0x7D95A90", VA = "0x187D96890")]
	private void OILEAKGGKFH(POMBJKBIJBC IDBCFACOCDL, DCEEACKECED GIOGPIENINB, Exception GMEDNHNLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D95B90", Offset = "0x7D94D90", VA = "0x187D95B90")]
	private static void MLJDLPCDKIP(OICEGJBLAJM BMCBBHKLCFG, Exception GMEDNHNLLCJ, [Optional] List<int> EGMFAPFAADK, int FJMBLFHPBKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D94FB0", Offset = "0x7D941B0", VA = "0x187D94FB0")]
	[AsyncStateMachine(typeof(KLMELMAFBCO))]
	private Task HCHGAPNPAJB(AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, DCEEACKECED GIOGPIENINB, BFHDIDLNEHP MOOINICOGCG, LDKHAKHICKG FLBDHBKFDHH, CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D95190", Offset = "0x7D94390", VA = "0x187D95190")]
	private void HMPELEMEONC([CallerMemberName] string AEONDEPJMMG = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D94E80", Offset = "0x7D94080", VA = "0x187D94E80")]
	[AsyncStateMachine(typeof(AGIHICGIAFF))]
	private Task GNAJELAEKPK(AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D96510", Offset = "0x7D95710", VA = "0x187D96510")]
	private void NFAANHBMHAA(DCEEACKECED GIOGPIENINB, CancellationToken BAIPNBEOGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D95370", Offset = "0x7D94570", VA = "0x187D95370")]
	private void IFPGGIGKGKD(DCEEACKECED GIOGPIENINB, TaskStatus POCFLKBIFGF, string DCEACFEGBDC, LDKHAKHICKG FLBDHBKFDHH, Exception MEOLMCJHMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D93ED0", Offset = "0x7D930D0", VA = "0x187D93ED0")]
	private void AOPJOGCBFHL(DCEEACKECED GIOGPIENINB, LDKHAKHICKG FLBDHBKFDHH, OperationCanceledException HFICDEMOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D95110", Offset = "0x7D94310", VA = "0x187D95110")]
	private void HMLJHELILKA(DCEEACKECED GIOGPIENINB, LDKHAKHICKG FLBDHBKFDHH, Exception GMEDNHNLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D97020", Offset = "0x7D96220", VA = "0x187D97020")]
	private void PFFFHFPIMEM(DCEEACKECED GIOGPIENINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D95310", Offset = "0x7D94510", VA = "0x187D95310")]
	private static GMLPEAHICBN IDMACAOLAFF(DCEEACKECED GIOGPIENINB)
	{
		return default(GMLPEAHICBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D94130", Offset = "0x7D93330", VA = "0x187D94130")]
	[AsyncStateMachine(typeof(ECAGEIDDOLF))]
	private Task CFDEIOFICAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D94330", Offset = "0x7D93530", VA = "0x187D94330")]
	[AsyncStateMachine(typeof(HGHLHBKIEKA))]
	private Task<Matchmaking.LOLCFHIHAGD> CMCMOIMANJA(DCEEACKECED GIOGPIENINB, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D94B70", Offset = "0x7D93D70", VA = "0x187D94B70")]
	private static NNHHOEKKBAP FLHMMDIMEND(Matchmaking.LOLCFHIHAGD KMPHGBKIECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D93F50", Offset = "0x7D93150", VA = "0x187D93F50")]
	[AsyncStateMachine(typeof(IEFLNPMNKNP))]
	private Task BABKGPLIDBM(Matchmaking.LOLCFHIHAGD KMPHGBKIECO, LDKHAKHICKG FLBDHBKFDHH, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken ALDCJBEHBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D94A30", Offset = "0x7D93C30", VA = "0x187D94A30")]
	[AsyncStateMachine(typeof(FCGNJHPFHJB))]
	private Task EFDMGGDHINL(DCEEACKECED GIOGPIENINB, CancellationTokenSource CGAKFJCHGLN, Task PELJFLDCBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D94C80", Offset = "0x7D93E80", VA = "0x187D94C80")]
	[AsyncStateMachine(typeof(BOIHNJMNJJE))]
	private Task FOPCKCENKCN(FNACBPJKCJM EPGKJGLOHMG, OKGFHNJKKJH AJMKPOADDFB, DCEEACKECED OOEOHGPPKKK, LDKHAKHICKG NGBLJNKPDEM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken NMPEOEDHDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D97230", Offset = "0x7D96430", VA = "0x187D97230")]
	private LDKHAKHICKG PJICBMPJMOD(LDKHAKHICKG NGBLJNKPDEM, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D957A0", Offset = "0x7D949A0", VA = "0x187D957A0")]
	[AsyncStateMachine(typeof(CLABHBJLKJP))]
	private Task LIECBFEMIAL(AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D94200", Offset = "0x7D93400", VA = "0x187D94200")]
	[AsyncStateMachine(typeof(PPFLLFKFAIG))]
	private Task CKIBNBJDCHL(CancellationToken KPIINMODKFJ, int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D94490", Offset = "0x7D93690", VA = "0x187D94490")]
	private static void CMGEBHMOHLN(DCEEACKECED GIOGPIENINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D94610", Offset = "0x7D93810", VA = "0x187D94610")]
	private void COMABGIIJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D94860", Offset = "0x7D93A60", VA = "0x187D94860")]
	private void DBBIFBHMFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D94DF0", Offset = "0x7D93FF0", VA = "0x187D94DF0")]
	private void GHBEMBIKLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D940A0", Offset = "0x7D932A0", VA = "0x187D940A0")]
	private void BLCLAFDLJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D948F0", Offset = "0x7D93AF0", VA = "0x187D948F0")]
	private static void DKMKJOAMJNJ(DCEEACKECED GIOGPIENINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D95630", Offset = "0x7D94830", VA = "0x187D95630")]
	private static CancellationTokenRegistration KGEFBHLPDKG(DCEEACKECED GIOGPIENINB, CancellationToken ALDCJBEHBPD)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7D95A90", Offset = "0x7D94C90", VA = "0x187D95A90")]
	private static void MLCGAMPLMFN(DCEEACKECED GIOGPIENINB, Exception GMEDNHNLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7D958E0", Offset = "0x7D94AE0", VA = "0x187D958E0")]
	private void MJOABIIHKNG(DCEEACKECED GIOGPIENINB, Task PELJFLDCBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D955D0", Offset = "0x7D947D0", VA = "0x187D955D0")]
	private static void IPKFDHIOJFD(Func<string> MMKAMPGMPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D97770", Offset = "0x7D96970", VA = "0x187D97770")]
	public JOCHJLMJBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D95740", Offset = "0x7D94940", VA = "0x187D95740")]
	[CompilerGenerated]
	internal static (int, int?) LDHAINCHCEJ(MPMBFLBDMHG CAPIHDDNOAD)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class JHNHAEFMCKJ : JFAHGAEHFDA, EEOOMGAHGDG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct AMNEMGHOMPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public JHNHAEFMCKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public MMOLBELIPAC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA580", Offset = "0x7DA9780", VA = "0x187DAA580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAA60", Offset = "0x7DA9C60", VA = "0x187DAAA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class HLPPHAHBDFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JHNHAEFMCKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public MMOLBELIPAC localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HLPPHAHBDFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7700", Offset = "0x7DB6900", VA = "0x187DB7700")]
		internal List<Task> BGPGBDPFEEO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct MGNKFIIBKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public IMGIIFJINKK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public MMOLBELIPAC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1350", Offset = "0x7DC0550", VA = "0x187DC1350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7DC16F0", Offset = "0x7DC08F0", VA = "0x187DC16F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct MKLEAJBOFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JHNHAEFMCKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1750", Offset = "0x7DC0950", VA = "0x187DC1750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1A30", Offset = "0x7DC0C30", VA = "0x187DC1A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<IMGIIFJINKK> IBHPBKDIGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EPICOIONIAM EOMOGMHDBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private GNEMDIILJJK MKPFAKGHFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private GJOMKKMGMFJ OIOPOKGCDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable EJHKEGHPACA;

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB8D0", Offset = "0x7DBAAD0", VA = "0x187DBB8D0", Slot = "5")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB1C0", Offset = "0x7DBA3C0", VA = "0x187DBB1C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB700", Offset = "0x7DBA900", VA = "0x187DBB700", Slot = "4")]
	public bool IPBAAGFEBNC(IMGIIFJINKK JGHHDEOFBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB2F0", Offset = "0x7DBA4F0", VA = "0x187DBB2F0")]
	private void EMCAGNANOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB4E0", Offset = "0x7DBA6E0", VA = "0x187DBB4E0")]
	private void HIOMOBMFPDI(JCDLFPMDPEJ JEICPGHJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB760", Offset = "0x7DBA960", VA = "0x187DBB760")]
	[AsyncStateMachine(typeof(AMNEMGHOMPO))]
	private Task LIDOBOLJBBB(int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAC20", Offset = "0x7DB9E20", VA = "0x187DBAC20")]
	private Func<CancellationToken, List<Task>> ABKDOGNDPME(int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7DBACF0", Offset = "0x7DB9EF0", VA = "0x187DBACF0")]
	private List<Task> DMKMHCFHCNC(int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB3C0", Offset = "0x7DBA5C0", VA = "0x187DBB3C0")]
	[AsyncStateMachine(typeof(MGNKFIIBKIA))]
	private Task FNHMHINGPCE(IMGIIFJINKK BDBLHJDLOGM, CancellationToken GIIKHLJPAKH, int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB220", Offset = "0x7DBA420", VA = "0x187DBB220")]
	[AsyncStateMachine(typeof(MKLEAJBOFAD))]
	private Task EDHICPFMMJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB850", Offset = "0x7DBAA50", VA = "0x187DBB850")]
	private void OGCCBPDGCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBBB0", Offset = "0x7DBADB0", VA = "0x187DBBBB0")]
	public JHNHAEFMCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class GAELKCEIDHD : CIFDPDCNFIG, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class AHJIDEAGIOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AHJIDEAGIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9390", Offset = "0x7DA8590", VA = "0x187DA9390")]
		internal object BGBNCDANPDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class MAGDMAKIONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MAGDMAKIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7DC12F0", Offset = "0x7DC04F0", VA = "0x187DC12F0")]
		internal object HAMKNIIKGFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class EKAKLGPLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EKAKLGPLDLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class FEJGDHIAFIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FEJGDHIAFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3760", Offset = "0x7DB2960", VA = "0x187DB3760")]
		internal object EIIMJCKJJKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class PIMNMGGEIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PIMNMGGEIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3FA0", Offset = "0x7DC31A0", VA = "0x187DC3FA0")]
		internal object ADOGEGOBLDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, MGMCFIBAIGN> JMHDKOIPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan MEMAFGGJAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "9")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3BB0", Offset = "0x7DB2DB0", VA = "0x187DB3BB0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3FD0", Offset = "0x7DB31D0", VA = "0x187DB3FD0", Slot = "4")]
	public LFAPCMBODMM OFEFHMDJLMD(Guid LDHEJEOPGBF)
	{
		return default(LFAPCMBODMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7DB41F0", Offset = "0x7DB33F0", VA = "0x187DB41F0", Slot = "5")]
	public bool OGPGHNCGHLC(Guid LDHEJEOPGBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3880", Offset = "0x7DB2A80", VA = "0x187DB3880", Slot = "6")]
	public bool AKPKGHBBBKF(Guid LDHEJEOPGBF, Task GGEMLBFGGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3DF0", Offset = "0x7DB2FF0", VA = "0x187DB3DF0", Slot = "7")]
	public bool FHLEOAJFMGK(Guid LDHEJEOPGBF, KLKDBEPMPLI KOPLFBCPDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4400", Offset = "0x7DB3600", VA = "0x187DB4400", Slot = "8")]
	public Task<(KLKDBEPMPLI, Task)> PPHHGCJGPLC(Guid LDHEJEOPGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3BC0", Offset = "0x7DB2DC0", VA = "0x187DB3BC0")]
	private void EPMLHMDJNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4470", Offset = "0x7DB3670", VA = "0x187DB4470")]
	public GAELKCEIDHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class ECGJLJEMGFF : KMMJGDINDJF, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class EOECGEMKHDN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly DCEEACKECED CNADGJBNNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource IFEDHDENNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken GEKPFJDHKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool IFGDIMOMBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool FEHOKBMGFLG;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2AC0", Offset = "0x7DB1CC0", VA = "0x187DB2AC0")]
		public EOECGEMKHDN(DCEEACKECED CNADGJBNNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2970", Offset = "0x7DB1B70", VA = "0x187DB2970")]
		public void OGCCBPDGCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2940", Offset = "0x7DB1B40", VA = "0x187DB2940", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class IEBAMOEEABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EIOAANDKFEH disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IEBAMOEEABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7D10", Offset = "0x7DB6F10", VA = "0x187DB7D10")]
		internal object DGDKJOEGIGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct KNCNAFCKKGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public EIOAANDKFEH disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public ECGJLJEMGFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEC10", Offset = "0x7DBDE10", VA = "0x187DBEC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF060", Offset = "0x7DBE260", VA = "0x187DBF060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class HFHGCFFFNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public ECGJLJEMGFF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HFHGCFFFNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7110", Offset = "0x7DB6310", VA = "0x187DB7110")]
		internal object BGMBGBCEIHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class CGIBBPNLOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public DCEEACKECED newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public HFHGCFFFNCA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CGIBBPNLOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7DADB40", Offset = "0x7DACD40", VA = "0x187DADB40")]
		internal object IELDCDOHLBA((DCEEACKECED lastLocalPlayerRoomInstance, DCEEACKECED newRoomInstance, OKBKAJFNCDB fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct GKOJHJAILKJ : IAsyncStateMachine
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
		public ECGJLJEMGFF <>4__this;

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
		private IFOOKNGMDBJ <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4530", Offset = "0x7DB3730", VA = "0x187DB4530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class BOFCDBIKIHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public DCEEACKECED newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BOFCDBIKIHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC070", Offset = "0x7DAB270", VA = "0x187DAC070")]
		internal object KMHFDEFHAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC110", Offset = "0x7DAB310", VA = "0x187DAC110")]
		internal void OIMDPKJPAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7DABFF0", Offset = "0x7DAB1F0", VA = "0x187DABFF0")]
		internal object BHLJOOAPIHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC030", Offset = "0x7DAB230", VA = "0x187DAC030")]
		internal object EDNNGCDOICA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct ADGMAGEFOCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public DCEEACKECED newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public ECGJLJEMGFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public BFHDIDLNEHP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private BOFCDBIKIHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private IFOOKNGMDBJ <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA78B0", Offset = "0x7DA6AB0", VA = "0x187DA78B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8870", Offset = "0x7DA7A70", VA = "0x187DA8870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly PKJBPHJIIMM.PCCGGJINHEM AJMJPLHIDPJ;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly KAIOHIEPLEK OECBOMPNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private EPICOIONIAM EOMOGMHDBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private OKBKAJFNCDB IKCMKKMGIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private HOGAEMMAIKH PEFAADKBJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private GCDDOLCNHFB IHGFLKGFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private DCEEACKECED GDKKLEICKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private EOECGEMKHDN IMMFPEIOPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool MNAEOKFNEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task CCKAALADNHI;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1360", Offset = "0x7DB0560", VA = "0x187DB1360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool JKOOEBLKHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xB62A00", Offset = "0xB61C00", VA = "0x180B62A00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7DB18D0", Offset = "0x7DB0AD0", VA = "0x187DB18D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7DB18E0", Offset = "0x7DB0AE0", VA = "0x187DB18E0", Slot = "4")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0FA0", Offset = "0x7DB01A0", VA = "0x187DB0FA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1CB0", Offset = "0x7DB0EB0", VA = "0x187DB1CB0")]
	[AsyncStateMachine(typeof(KNCNAFCKKGL))]
	private Task PNFGEDFFODF(EIOAANDKFEH DAOEJOBLMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1110", Offset = "0x7DB0310", VA = "0x187DB1110")]
	private void FOLJPHBFHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB13B0", Offset = "0x7DB05B0", VA = "0x187DB13B0")]
	private void NGINPOPICNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0D50", Offset = "0x7DAFF50", VA = "0x187DB0D50")]
	private void BLJEBJANMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB12F0", Offset = "0x7DB04F0", VA = "0x187DB12F0")]
	private bool KIPDOFLJEJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0ED0", Offset = "0x7DB00D0", VA = "0x187DB0ED0")]
	[AsyncStateMachine(typeof(GKOJHJAILKJ))]
	private void CFDLIDPDMGI(int ADIMAPFNMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1540", Offset = "0x7DB0740", VA = "0x187DB1540")]
	private void NNAMFMELCNF([Out] IDisposable BOKGDDNOMNC, [Out] IDisposable PMOECODHEHD, [Out] IDisposable AGFHPGFJNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7DB17D0", Offset = "0x7DB09D0", VA = "0x187DB17D0")]
	private bool OLELEMGGIJA(DCEEACKECED CNADGJBNNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7DB12A0", Offset = "0x7DB04A0", VA = "0x187DB12A0")]
	private void JLOJMIBNEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1B80", Offset = "0x7DB0D80", VA = "0x187DB1B80")]
	[AsyncStateMachine(typeof(ADGMAGEFOCN))]
	private Task PJOKBPBBLMO(DCEEACKECED CNADGJBNNEO, BFHDIDLNEHP MOOINICOGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2130", Offset = "0x7DB1330", VA = "0x187DB2130")]
	public ECGJLJEMGFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class LHNMFBMNLLO : BBGOBGNCLGF, EEOOMGAHGDG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct JMLKGJCKJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<BKELAGLEEBH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public LHNMFBMNLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<BKELAGLEEBH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCCB0", Offset = "0x7DBBEB0", VA = "0x187DBCCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCF40", Offset = "0x7DBC140", VA = "0x187DBCF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class NAPKPKALCJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AHCJONDEEIE message;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NAPKPKALCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1A90", Offset = "0x7DC0C90", VA = "0x187DC1A90")]
		internal object LEFJPBFOLJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OHHOJCNNCKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AHCJONDEEIE messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OHHOJCNNCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3410", Offset = "0x7DC2610", VA = "0x187DC3410")]
		internal object HMKGBFAJIIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class JPIGHPLOKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JPIGHPLOKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCFB0", Offset = "0x7DBC1B0", VA = "0x187DBCFB0")]
		internal object DDPBDIADPAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct AIMCCCCEOLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public LHNMFBMNLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<MBCPBGIAHHB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7DA93F0", Offset = "0x7DA85F0", VA = "0x187DA93F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9CC0", Offset = "0x7DA8EC0", VA = "0x187DA9CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class NEMEMEHOFGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AHCJONDEEIE operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NEMEMEHOFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2230", Offset = "0x7DC1430", VA = "0x187DC2230")]
		internal object FKGFGFAKKIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct DILCPLIKEDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AHCJONDEEIE operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public LHNMFBMNLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private LDKHAKHICKG <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFCA0", Offset = "0x7DAEEA0", VA = "0x187DAFCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0810", Offset = "0x7DAFA10", VA = "0x187DB0810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct BOILCCEAGHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<MBCPBGIAHHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public LHNMFBMNLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private JLIEJKGEDBE.JJKOIHNABMK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private LDKHAKHICKG <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC9E0", Offset = "0x7DABBE0", VA = "0x187DAC9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7DACF10", Offset = "0x7DAC110", VA = "0x187DACF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class CPANGKJGMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public MBCPBGIAHHB operation;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CPANGKJGMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF540", Offset = "0x7DAE740", VA = "0x187DAF540")]
		internal object GCDDGHMJGEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct AKFCEEHNLGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public MBCPBGIAHHB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public LHNMFBMNLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private AGOOCHPPHOP<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9D20", Offset = "0x7DA8F20", VA = "0x187DA9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7DAA350", Offset = "0x7DA9550", VA = "0x187DAA350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class EIKEDKGHFMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EIKEDKGHFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7DB21A0", Offset = "0x7DB13A0", VA = "0x187DB21A0")]
		internal object CNEENNBAINB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class FPCAMFMPKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FPCAMFMPKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3820", Offset = "0x7DB2A20", VA = "0x187DB3820")]
		internal object IBKCGGLODAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private IHIBHEFPCBK IFNICHLDFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private CHAMJEFPGHI PLIABIFPICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private BFIHLPDIKKA GBKPDLHACLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<BKELAGLEEBH> CPOFNKGJMAN;

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1110", Offset = "0x7DC0310", VA = "0x187DC1110", Slot = "7")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7DBFF70", Offset = "0x7DBF170", VA = "0x187DBFF70", Slot = "6")]
	[AsyncStateMachine(typeof(JMLKGJCKJOD))]
	public Task<BKELAGLEEBH> CDALNHHAHOB(CancellationToken HEDHNGBDJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0C70", Offset = "0x7DBFE70", VA = "0x187DC0C70", Slot = "4")]
	public void OABGHBGOECP(AHCJONDEEIE DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7DC05B0", Offset = "0x7DBF7B0", VA = "0x187DC05B0", Slot = "5")]
	public void JFMFHGAPGKF(AHCJONDEEIE KIDJEHGJPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1000", Offset = "0x7DC0200", VA = "0x187DC1000")]
	[AsyncStateMachine(typeof(AIMCCCCEOLF))]
	private Task OGOHABBCOMB(AHCJONDEEIE NKJDMJIDCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0410", Offset = "0x7DBF610", VA = "0x187DC0410")]
	[AsyncStateMachine(typeof(DILCPLIKEDN))]
	private Task FDFPFEFCKPA(AHCJONDEEIE ABEJAFALOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0B20", Offset = "0x7DBFD20", VA = "0x187DC0B20")]
	[AsyncStateMachine(typeof(BOILCCEAGHM))]
	private Task<MBCPBGIAHHB> LMIKBMOCBAN(AHCJONDEEIE NKJDMJIDCOG, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0520", Offset = "0x7DBF720", VA = "0x187DC0520")]
	private LDKHAKHICKG FEAFOOIOKBP(AHCJONDEEIE AGMJBICPPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7DBFE50", Offset = "0x7DBF050", VA = "0x187DBFE50")]
	[AsyncStateMachine(typeof(AKFCEEHNLGH))]
	private Task BKFMNECEPPA(MBCPBGIAHHB BHEFDPAMAKP, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0910", Offset = "0x7DBFB10", VA = "0x187DC0910")]
	private MBCPBGIAHHB KMPOMAKFEOL(AHCJONDEEIE NKJDMJIDCOG, LDKHAKHICKG BFFNLNLHDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x3532020", Offset = "0x3531220", VA = "0x183532020")]
	private T BEGHJFILIJD<T>(T OMFJNFBDJCA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0080", Offset = "0x7DBF280", VA = "0x187DC0080")]
	private MBCPBGIAHHB ENODNJLLNAC(AHCJONDEEIE NKJDMJIDCOG, LDKHAKHICKG BFFNLNLHDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LHNMFBMNLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class INBJEAEDOCO : CHAMJEFPGHI, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class ANKCIEJAMFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ANKCIEJAMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAAC0", Offset = "0x7DA9CC0", VA = "0x187DAAAC0")]
		internal object DNBBCEJMCHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class LPGKOIEBJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LPGKOIEBJIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1280", Offset = "0x7DC0480", VA = "0x187DC1280")]
		internal object BALFIMOHKJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private JOOACOGBMBP IKIBJELCNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private BBGOBGNCLGF NOKAAEGIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private CIFDPDCNFIG JMHDKOIPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private OLKHEBKFDJM LCCJDPAIEDH;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9F20", Offset = "0x7DB9120", VA = "0x187DB9F20", Slot = "6")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8BA0", Offset = "0x7DB7DA0", VA = "0x187DB8BA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9A30", Offset = "0x7DB8C30", VA = "0x187DB9A30", Slot = "4")]
	public LFAPCMBODMM LPFCAMBKBOH(AHCJONDEEIE CIFFMLEDNCJ)
	{
		return default(LFAPCMBODMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9300", Offset = "0x7DB8500", VA = "0x187DB9300", Slot = "5")]
	public void KIBHOGIBKIC(Guid LDHEJEOPGBF, Task GGEMLBFGGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9E50", Offset = "0x7DB9050", VA = "0x187DB9E50")]
	private void MIDMOIKKAJL(byte BHACABOKOII, int KPBNGNEIDLH, object CBIPNFNFEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8620", Offset = "0x7DB7820", VA = "0x187DB8620")]
	private void CPMEMNLICNA(CIIEBPEGBGH ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8C50", Offset = "0x7DB7E50", VA = "0x187DB8C50")]
	private void EMOLMGJFMMD(CIIEBPEGBGH ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8EC0", Offset = "0x7DB80C0", VA = "0x187DB8EC0")]
	private void FHBFGOIHDAK(CIIEBPEGBGH ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9790", Offset = "0x7DB8990", VA = "0x187DB9790")]
	private KLKDBEPMPLI LMKNPGKFKID(AHCJONDEEIE AGMJBICPPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9100", Offset = "0x7DB8300", VA = "0x187DB9100")]
	private void IKNJJCOFJEH(AHCJONDEEIE ABEJAFALOCI, KLKDBEPMPLI KOPLFBCPDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8440", Offset = "0x7DB7640", VA = "0x187DB8440")]
	private bool ABGBCKLLAJJ(AHCJONDEEIE ABEJAFALOCI, KLKDBEPMPLI KOPLFBCPDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA090", Offset = "0x7DB9290", VA = "0x187DBA090")]
	private bool PJDFDCGDEFP(AHCJONDEEIE MNAALLMEADB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9510", Offset = "0x7DB8710", VA = "0x187DB9510")]
	private bool LJAJFEFLNAJ(byte BHACABOKOII, ExitGames.Client.Photon.Hashtable ELLEMLBGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public INBJEAEDOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class BFBOEGKFOIP : FONCOCMPMBL, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class GPFLBILGFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public BKELAGLEEBH operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public BFBOEGKFOIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AHCJONDEEIE roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GPFLBILGFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5C70", Offset = "0x7DB4E70", VA = "0x187DB5C70")]
		internal object DCLLJMACNCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5CE0", Offset = "0x7DB4EE0", VA = "0x187DB5CE0")]
		internal object KCGMDDBMOGO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LGBNMCFMGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public BFBOEGKFOIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AHCJONDEEIE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<KLKDBEPMPLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF740", Offset = "0x7DBE940", VA = "0x187DBF740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFDE0", Offset = "0x7DBEFE0", VA = "0x187DBFDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class HDCHFBHNJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public BKELAGLEEBH operationType;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HDCHFBHNJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB70A0", Offset = "0x7DB62A0", VA = "0x187DB70A0")]
		internal object OOGCHGJEFMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class GPJCOICJLLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GPJCOICJLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5F00", Offset = "0x7DB5100", VA = "0x187DB5F00")]
		internal object HJBMNKIDADO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5F70", Offset = "0x7DB5170", VA = "0x187DB5F70")]
		internal object IOBLGCANAHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5E90", Offset = "0x7DB5090", VA = "0x187DB5E90")]
		internal object CLDLNDEIOPP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct NPJLFAIFPIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public BFBOEGKFOIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private GPJCOICJLLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private LFAPCMBODMM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private KLKDBEPMPLI <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(KLKDBEPMPLI validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2AD0", Offset = "0x7DC1CD0", VA = "0x187DC2AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DC33A0", Offset = "0x7DC25A0", VA = "0x187DC33A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private JOOACOGBMBP IKIBJELCNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private CHAMJEFPGHI PLIABIFPICH;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7DABE90", Offset = "0x7DAB090", VA = "0x187DABE90", Slot = "5")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7DABB80", Offset = "0x7DAAD80", VA = "0x187DABB80", Slot = "4")]
	[AsyncStateMachine(typeof(LGBNMCFMGMG))]
	private Task<KLKDBEPMPLI> EMEINLHNNBC(AHCJONDEEIE AGMJBICPPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7DABCA0", Offset = "0x7DAAEA0", VA = "0x187DABCA0")]
	private bool FMADBOMEFBJ(BKELAGLEEBH BFCANANPGGJ, [Out] KLKDBEPMPLI CMLOHOMLNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7DABA40", Offset = "0x7DAAC40", VA = "0x187DABA40")]
	[AsyncStateMachine(typeof(NPJLFAIFPIN))]
	private Task<KLKDBEPMPLI> AEICEKOPMFM(AHCJONDEEIE NKJDMJIDCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public BFBOEGKFOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JIDBMGFGJON : LFJJMFMMIKG, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct CCHJBLGEMDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public MMBNINEADFK OAMLIBCKHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long IJMAHOEDKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? EKACCJAFHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool LBMAJHEBFGG;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct NMECIGDBJMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<FNACBPJKCJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public JIDBMGFGJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<AELLMCLLHFN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<FNACBPJKCJM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2490", Offset = "0x7DC1690", VA = "0x187DC2490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2A60", Offset = "0x7DC1C60", VA = "0x187DC2A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class HCOPJEMGBJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HCOPJEMGBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6FF0", Offset = "0x7DB61F0", VA = "0x187DB6FF0")]
		internal object JDALGGGICHO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct PELMGPHMHBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<AELLMCLLHFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public JIDBMGFGJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private HCOPJEMGBJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<AELLMCLLHFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3470", Offset = "0x7DC2670", VA = "0x187DC3470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3A60", Offset = "0x7DC2C60", VA = "0x187DC3A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct LECIFIDLHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<FNACBPJKCJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public JIDBMGFGJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AELLMCLLHFN roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<CCHJBLGEMDL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF160", Offset = "0x7DBE360", VA = "0x187DBF160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF6D0", Offset = "0x7DBE8D0", VA = "0x187DBF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class JEJKJIHBKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AELLMCLLHFN roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JEJKJIHBKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xD632F0", Offset = "0xD624F0", VA = "0x180D632F0")]
		internal bool DHDMIFEEPGC(BJLNPLMLHJE sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DBAB60", Offset = "0x7DB9D60", VA = "0x187DBAB60")]
		internal object MLIGBDNOELC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DBAA40", Offset = "0x7DB9C40", VA = "0x187DBAA40")]
		internal object ABELOLHAFGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DBAAD0", Offset = "0x7DB9CD0", VA = "0x187DBAAD0")]
		internal object DKFDFKODLJO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class CLPDDLJDEBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public JEJKJIHBKHA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CLPDDLJDEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF440", Offset = "0x7DAE640", VA = "0x187DAF440")]
		internal object IBDKPNBDDGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct KDJCFOBIFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<CCHJBLGEMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public AELLMCLLHFN roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public JIDBMGFGJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public DCEEACKECED targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private CLPDDLJDEBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<CCHJBLGEMDL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<NLGNBINCOCE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDC70", Offset = "0x7DBCE70", VA = "0x187DBDC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEBA0", Offset = "0x7DBDDA0", VA = "0x187DBEBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class BJHGDKGNJJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BJHGDKGNJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DABF40", Offset = "0x7DAB140", VA = "0x187DABF40")]
		internal object JADINHGEAMG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct NCHIJPNEALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<CCHJBLGEMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public BJLNPLMLHJE subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JIDBMGFGJON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public DCEEACKECED dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private BJHGDKGNJJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<DFMNJLHLEJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1AF0", Offset = "0x7DC0CF0", VA = "0x187DC1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DC21C0", Offset = "0x7DC13C0", VA = "0x187DC21C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private HOGAEMMAIKH PEFAADKBJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private ABACIFJECMC FJFNENFOEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private KJAHHAOJJBK DEIAMCBADPJ;

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC350", Offset = "0x7DBB550", VA = "0x187DBC350", Slot = "5")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBDA0", Offset = "0x7DBAFA0", VA = "0x187DBBDA0", Slot = "4")]
	[AsyncStateMachine(typeof(NMECIGDBJMP))]
	public Task<FNACBPJKCJM> BCAACFCNNGI(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, DCEEACKECED GIOGPIENINB, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBC40", Offset = "0x7DBAE40", VA = "0x187DBBC40")]
	[AsyncStateMachine(typeof(PELMGPHMHBA))]
	private Task<AELLMCLLHFN> AAOPPPMHNHI(DCEEACKECED GIOGPIENINB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC070", Offset = "0x7DBB270", VA = "0x187DBC070")]
	[AsyncStateMachine(typeof(LECIFIDLHEJ))]
	private Task<FNACBPJKCJM> HENBGMOGDHF(DCEEACKECED GIOGPIENINB, AELLMCLLHFN OIGFHLOIIFP, long HPHKCHODKPD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBF00", Offset = "0x7DBB100", VA = "0x187DBBF00")]
	[AsyncStateMachine(typeof(KDJCFOBIFEB))]
	private Task<CCHJBLGEMDL> CDLMGMGJNML(DCEEACKECED GIOGPIENINB, AELLMCLLHFN OIGFHLOIIFP, long HPHKCHODKPD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC1E0", Offset = "0x7DBB3E0", VA = "0x187DBC1E0")]
	[AsyncStateMachine(typeof(NCHIJPNEALJ))]
	private Task<CCHJBLGEMDL> JPKFHLOFFBM(DCEEACKECED APPAFONKBFL, BJLNPLMLHJE IPKAFFDLFGI, long HPHKCHODKPD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public JIDBMGFGJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class ENKCHBGNGJM : BFIHLPDIKKA, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class FNKJBGLPMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FNKJBGLPMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB37C0", Offset = "0x7DB29C0", VA = "0x187DB37C0")]
		internal object KLOCJPOMOHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct DCGDDENBIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public ENKCHBGNGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public LDKHAKHICKG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF5C0", Offset = "0x7DAE7C0", VA = "0x187DAF5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFBD0", Offset = "0x7DAEDD0", VA = "0x187DAFBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct PKFCIKHDMJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public ENKCHBGNGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public LDKHAKHICKG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<PDCIEKOKJKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7DC4000", Offset = "0x7DC3200", VA = "0x187DC4000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DC45F0", Offset = "0x7DC37F0", VA = "0x187DC45F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class DGBPIHHDCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DGBPIHHDCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFC40", Offset = "0x7DAEE40", VA = "0x187DAFC40")]
		internal object NPNGPNHKDHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct KAAOMDCJJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AHCJONDEEIE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public ENKCHBGNGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public LDKHAKHICKG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private HLMOGNAOHJD <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private LLLBBGCEHPI <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<PDCIEKOKJKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD010", Offset = "0x7DBC210", VA = "0x187DBD010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDC00", Offset = "0x7DBCE00", VA = "0x187DBDC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private KDNDMHBGPCF GOMIBMIGPMA;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private LNAMJHHEPDO DGPFGGCBDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB27F0", Offset = "0x7DB19F0", VA = "0x187DB27F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB28B0", Offset = "0x7DB1AB0", VA = "0x187DB28B0", Slot = "8")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2330", Offset = "0x7DB1530", VA = "0x187DB2330", Slot = "4")]
	[AsyncStateMachine(typeof(DCGDDENBIPK))]
	public Task<AHCJONDEEIE> BHIOEDOAENA(AHCJONDEEIE NKJDMJIDCOG, LDKHAKHICKG BFFNLNLHDNI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2540", Offset = "0x7DB1740", VA = "0x187DB2540", Slot = "5")]
	[AsyncStateMachine(typeof(PKFCIKHDMJE))]
	public Task<AHCJONDEEIE> JMBDPNOEBPK(CancellationToken KPIINMODKFJ, LDKHAKHICKG BFFNLNLHDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2490", Offset = "0x7DB1690", VA = "0x187DB2490", Slot = "6")]
	public FCDEPCDPKFP DHFDBMHJDCE(MBCPBGIAHHB GOAOFFKBLLA, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2200", Offset = "0x7DB1400", VA = "0x187DB2200", Slot = "7")]
	public FCDEPCDPKFP BBDEDMECOBF(MBCPBGIAHHB GOAOFFKBLLA, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2690", Offset = "0x7DB1890", VA = "0x187DB2690")]
	[AsyncStateMachine(typeof(KAAOMDCJJFA))]
	private Task<AHCJONDEEIE> OFFIEJJLDBO(AHCJONDEEIE NKJDMJIDCOG, LDKHAKHICKG BFFNLNLHDNI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x34395D0", Offset = "0x34387D0", VA = "0x1834395D0")]
	private static byte[] FGKHOHCPFKO(AHCJONDEEIE DCEACFEGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public ENKCHBGNGJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class HPDDKPMPDDH : JOOACOGBMBP, EEOOMGAHGDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private LHEOODGMJJF KJJDCAPJGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private IHIBHEFPCBK IFNICHLDFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private CDIKLNAHEEG FICJBEPHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private GCDDOLCNHFB IHGFLKGFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private JFAHGAEHFDA DPILIIBJHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private HOGAEMMAIKH PEFAADKBJGB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7B50", Offset = "0x7DB6D50", VA = "0x187DB7B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static KLKDBEPMPLI MKJMACJPHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7740", Offset = "0x7DB6940", VA = "0x187DB7740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7BA0", Offset = "0x7DB6DA0", VA = "0x187DB7BA0", Slot = "6")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7DB79E0", Offset = "0x7DB6BE0", VA = "0x187DB79E0", Slot = "4")]
	public KLKDBEPMPLI MJBKELGELDA(GJGNFGDHFCI FIJGOHBDHEF, BKELAGLEEBH BGIMNFJPNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7760", Offset = "0x7DB6960", VA = "0x187DB7760", Slot = "5")]
	public KLKDBEPMPLI MBJCMGIGMAF(GJGNFGDHFCI PDJEIBBABLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7750", Offset = "0x7DB6950", VA = "0x187DB7750")]
	private static KLKDBEPMPLI KJBOLHODBLN(HJMEGJOFMMJ HIIOCAFDBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public HPDDKPMPDDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class HHGGLDPIBOK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB76C0", Offset = "0x7DB68C0", VA = "0x187DB76C0")]
	public HHGGLDPIBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x70817D0", Offset = "0x70809D0", VA = "0x1870817D0")]
	public HHGGLDPIBOK(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HAEGCOKFGMH : GMBJDHDGECL, EEOOMGAHGDG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct CGEEPBMCFLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public HAEGCOKFGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public FLDEFDNOGMD autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private AGOOCHPPHOP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private GMEMBNLFIDN <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<KLKDBEPMPLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7DACF80", Offset = "0x7DAC180", VA = "0x187DACF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DADAD0", Offset = "0x7DACCD0", VA = "0x187DADAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct BBPALILALHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public HAEGCOKFGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DAAB30", Offset = "0x7DA9D30", VA = "0x187DAAB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB270", Offset = "0x7DAA470", VA = "0x187DAB270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct BEFGCHADPGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public HAEGCOKFGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB4D0", Offset = "0x7DAA6D0", VA = "0x187DAB4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB9E0", Offset = "0x7DAABE0", VA = "0x187DAB9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct JAPBNDBHELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public HAEGCOKFGMH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA2A0", Offset = "0x7DB94A0", VA = "0x187DBA2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA9E0", Offset = "0x7DB9BE0", VA = "0x187DBA9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct BEDMBPEKHHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public HAEGCOKFGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB2D0", Offset = "0x7DAA4D0", VA = "0x187DAB2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB470", Offset = "0x7DAA670", VA = "0x187DAB470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct JJCHOIEPOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public HAEGCOKFGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC540", Offset = "0x7DBB740", VA = "0x187DBC540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCC50", Offset = "0x7DBBE50", VA = "0x187DBCC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct PIBFGFJNCNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public HAEGCOKFGMH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3AD0", Offset = "0x7DC2CD0", VA = "0x187DC3AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3F40", Offset = "0x7DC3140", VA = "0x187DC3F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct AFIJECLOIFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public HAEGCOKFGMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public NCDJJBLPPNH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private AGOOCHPPHOP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5A50", Offset = "0x7DC4C50", VA = "0x187DC5A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5FF0", Offset = "0x7DC51F0", VA = "0x187DC5FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private BFIHLPDIKKA GBKPDLHACLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private IHIBHEFPCBK IFNICHLDFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private JFAHGAEHFDA DPILIIBJHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource PLLGGDOLFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task LEOILGNKIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> LFMDHDPECAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int BFJDPPCABAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int HAOMGKJHHHC;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6E40", Offset = "0x7DB6040", VA = "0x187DB6E40", Slot = "6")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x113C7E0", Offset = "0x113B9E0", VA = "0x18113C7E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB63F0", Offset = "0x7DB55F0", VA = "0x187DB63F0")]
	private void DNLEKMKBAEM(float HCGBIGBGNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB68B0", Offset = "0x7DB5AB0", VA = "0x187DB68B0", Slot = "4")]
	[AsyncStateMachine(typeof(CGEEPBMCFLA))]
	public Task<KLKDBEPMPLI> NLFOBPPEDPD(FLDEFDNOGMD GFNOBBEDINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6AF0", Offset = "0x7DB5CF0", VA = "0x187DB6AF0", Slot = "5")]
	[AsyncStateMachine(typeof(BBPALILALHF))]
	public Task NOHNCJFAHGB([Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x113C7E0", Offset = "0x113B9E0", VA = "0x18113C7E0")]
	public void DANBEBPMEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6CD0", Offset = "0x7DB5ED0", VA = "0x187DB6CD0")]
	private GMEMBNLFIDN OHHPELBPLKD(FLDEFDNOGMD GFNOBBEDINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6BE0", Offset = "0x7DB5DE0", VA = "0x187DB6BE0")]
	[AsyncStateMachine(typeof(BEFGCHADPGH))]
	private Task NPMKAAAMMDA(CancellationToken BAIPNBEOGFG, int IPKLFEDBAFK, MMOLBELIPAC LPEOOMMIFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7DB66C0", Offset = "0x7DB58C0", VA = "0x187DB66C0")]
	[AsyncStateMachine(typeof(JAPBNDBHELB))]
	private Task JLNGMDHNDJF(CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DB64D0", Offset = "0x7DB56D0", VA = "0x187DB64D0")]
	[AsyncStateMachine(typeof(BEDMBPEKHHM))]
	private Task GALHGIAMPFJ([Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB67C0", Offset = "0x7DB59C0", VA = "0x187DB67C0")]
	[AsyncStateMachine(typeof(JJCHOIEPOCH))]
	private Task KNODNDEFCDM(CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB65C0", Offset = "0x7DB57C0", VA = "0x187DB65C0")]
	[AsyncStateMachine(typeof(PIBFGFJNCNA))]
	private Task ILNGKEBHBPH(CancellationToken DFKEOCKBOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6260", Offset = "0x7DB5460", VA = "0x187DB6260")]
	private Task CGKCDPICHII(NCDJJBLPPNH KMONDJFBELJ, CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7DB69E0", Offset = "0x7DB5BE0", VA = "0x187DB69E0")]
	[AsyncStateMachine(typeof(AFIJECLOIFF))]
	private Task NLPLHCOLPJL(NCDJJBLPPNH KMONDJFBELJ, CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5FE0", Offset = "0x7DB51E0", VA = "0x187DB5FE0")]
	private bool BNLMDNGKOCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public HAEGCOKFGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class DMGDNNBCNGN : CDIKLNAHEEG, EEOOMGAHGDG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct PAHDKNLGHLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public DMGDNNBCNGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private AGOOCHPPHOP<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE02C0", Offset = "0x7DDF4C0", VA = "0x187DE02C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0870", Offset = "0x7DDFA70", VA = "0x187DE0870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private JIEMHCCKOBO BGBNHCPMMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private JOOACOGBMBP IKIBJELCNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private BFIHLPDIKKA GBKPDLHACLE;

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC7E0", Offset = "0x7DCB9E0", VA = "0x187DCC7E0", Slot = "6")]
	public void PDAIGIIELDH(OKOJPAHMDCL FAFBKMPEOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC650", Offset = "0x7DCB850", VA = "0x187DCC650", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC550", Offset = "0x7DCB750", VA = "0x187DCC550", Slot = "5")]
	[AsyncStateMachine(typeof(PAHDKNLGHLM))]
	public Task BOCMBCMDKMO(string PFECANJBHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC490", Offset = "0x7DCB690", VA = "0x187DCC490", Slot = "4")]
	public KLKDBEPMPLI BNLMDNGKOCC(GJGNFGDHFCI FIJGOHBDHEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC6A0", Offset = "0x7DCB8A0", VA = "0x187DCC6A0")]
	private KKFLAFCIEON EMMIFHGKGNG(string PFECANJBHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DMGDNNBCNGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class GLNENOGNGFA
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFAD0", Offset = "0x7DCECD0", VA = "0x187DCFAD0")]
	public static void IOMBJANHNMN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFD10", Offset = "0x7DCEF10", VA = "0x187DCFD10")]
	internal static void LFELPEACMBA(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF9F0", Offset = "0x7DCEBF0", VA = "0x187DCF9F0")]
	internal static void FEIKIGBLNAD(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF5C0", Offset = "0x7DCE7C0", VA = "0x187DCF5C0")]
	internal static void BDPMDNAAGHJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x34A0000", Offset = "0x349F200", VA = "0x1834A0000")]
	private static void FMHNABJKLBP<Interface, Impl, Interface>(ANOENEDKKHA GFOILLNHEFN) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class BEIHNMCHBFL : FAIGFMJDNFC<AHCJONDEEIE>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class NIMCFJDDEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AHCJONDEEIE message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NIMCFJDDEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCCA0", Offset = "0x7DDBEA0", VA = "0x187DDCCA0")]
		internal object PJGBABKJLIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly BEIHNMCHBFL JLGHKLNHGNO;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7DC71F0", Offset = "0x7DC63F0", VA = "0x187DC71F0")]
	public ExitGames.Client.Photon.Hashtable JEAAONFOJJH(AHCJONDEEIE DCEACFEGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6FB0", Offset = "0x7DC61B0", VA = "0x187DC6FB0", Slot = "5")]
	protected override void GJNLMFIHHKG(AHCJONDEEIE DCEACFEGBDC, IDictionary<object, object> LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6D80", Offset = "0x7DC5F80", VA = "0x187DC6D80", Slot = "6")]
	public override AHCJONDEEIE ANADGBKPLNB(IDictionary<object, object> LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7DC70E0", Offset = "0x7DC62E0", VA = "0x187DC70E0")]
	private static void IPKFDHIOJFD(string PMBOOKAGMPH, AHCJONDEEIE DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7310", Offset = "0x7DC6510", VA = "0x187DC7310")]
	public BEIHNMCHBFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6AD0", Offset = "0x7DC5CD0", VA = "0x187DC6AD0")]
	[CompilerGenerated]
	internal static string AJKPGBAJEJN(FNACBPJKCJM FKKLLADNDBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class ALOBPAIKNNG
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static KLKDBEPMPLI MKJMACJPHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7DC64B0", Offset = "0x7DC56B0", VA = "0x187DC64B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6050", Offset = "0x7DC5250", VA = "0x187DC6050")]
	public static bool CGKGGNHECDL(this KLKDBEPMPLI KOPLFBCPDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6510", Offset = "0x7DC5710", VA = "0x187DC6510")]
	public static KLKDBEPMPLI KJBOLHODBLN(HJMEGJOFMMJ CBIFFECGLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6070", Offset = "0x7DC5270", VA = "0x187DC6070")]
	public static KLKDBEPMPLI EKHDDJAKGGC(IEnumerable<KLKDBEPMPLI> OBALIGHEKFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6260", Offset = "0x7DC5460", VA = "0x187DC6260")]
	public static string FCFDDHBDPOG(this KLKDBEPMPLI CMLOHOMLNDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class IGOOGFGGDPE : GKKADDMNNLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate KLKDBEPMPLI ODFLONFMBEJ([NotNull] GJGNFGDHFCI HLALJHGPAMC);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class CHDENKKMPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public GJGNFGDHFCI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CHDENKKMPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x13DEE80", Offset = "0x13DE080", VA = "0x1813DEE80")]
		internal KLKDBEPMPLI IJOPCEFFGKL(ODFLONFMBEJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<ODFLONFMBEJ> JNDBMLIEOKH;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3160", Offset = "0x7DD2360", VA = "0x187DD3160", Slot = "4")]
	public void HBKGAAJOLEL(ODFLONFMBEJ JBNAHMIAHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3450", Offset = "0x7DD2650", VA = "0x187DD3450", Slot = "5")]
	public void JNANLEOJOOO(ODFLONFMBEJ JBNAHMIAHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3110", Offset = "0x7DD2310", VA = "0x187DD3110", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD31C0", Offset = "0x7DD23C0", VA = "0x187DD31C0")]
	protected KLKDBEPMPLI IFJONPANLAA(GJGNFGDHFCI PDJEIBBABLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD34B0", Offset = "0x7DD26B0", VA = "0x187DD34B0")]
	protected IGOOGFGGDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class BLHHEOIFHBF : IGOOGFGGDPE, LHEOODGMJJF, GKKADDMNNLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class GIBCDALNENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public KLKDBEPMPLI result;

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GIBCDALNENF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF180", Offset = "0x7DCE380", VA = "0x187DCF180")]
		internal object CAOJCELMEGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9AE0", Offset = "0x7DC8CE0", VA = "0x187DC9AE0")]
	[UnityEngine.Scripting.Preserve]
	public BLHHEOIFHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7DC99D0", Offset = "0x7DC8BD0", VA = "0x187DC99D0", Slot = "8")]
	public KLKDBEPMPLI MNMHMCMHDNP(GJGNFGDHFCI PDJEIBBABLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class EHIIBMJOJBH : IGOOGFGGDPE, JIEMHCCKOBO, GKKADDMNNLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class CEHEOGOKCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public KLKDBEPMPLI result;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CEHEOGOKCEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC9EE0", Offset = "0x7DC90E0", VA = "0x187DC9EE0")]
		internal object BNEEMIFCEFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9AE0", Offset = "0x7DC8CE0", VA = "0x187DC9AE0")]
	[UnityEngine.Scripting.Preserve]
	public EHIIBMJOJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD160", Offset = "0x7DCC360", VA = "0x187DCD160", Slot = "8")]
	public KLKDBEPMPLI BNLMDNGKOCC(GJGNFGDHFCI CIGHHJOJKIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class ADCHDEBJNKA
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class OMIMPJOOPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AGOOCHPPHOP<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OMIMPJOOPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0020", Offset = "0x7DDF220", VA = "0x187DE0020")]
		internal object OCEOGPHHIOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5970", Offset = "0x7DC4B70", VA = "0x187DC5970")]
	public static AGOOCHPPHOP<string> LAPDIKHECJH(PBBCGFNIILA NPAEAIAJLAP, [Optional] string IGAGFKLJBKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC58B0", Offset = "0x7DC4AB0", VA = "0x187DC58B0")]
	public static void KLPNEJCGFPH(AGOOCHPPHOP<string> MLINJELIMFI, PBBCGFNIILA NPAEAIAJLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC57F0", Offset = "0x7DC49F0", VA = "0x187DC57F0")]
	public static string EMOJPAEPENL(AHCJONDEEIE AGMJBICPPII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class KJDIMMJFEPM
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D50", Offset = "0x7DD4F50", VA = "0x187DD5D50")]
	public static void PPEJMGLBKEL(this APCKJEBLMJJ IMAAHCGDBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D40", Offset = "0x7DD4F40", VA = "0x187DD5D40")]
	public static void PJGBBDHJDBA(this APCKJEBLMJJ IMAAHCGDBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5C20", Offset = "0x7DD4E20", VA = "0x187DD5C20")]
	private static void NJBDHNEEHHI(this APCKJEBLMJJ IMAAHCGDBEG, bool AOBEFDOKLAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class ODMPCCFNAAK : AKLAOMBEFFF, AJKKBOPPAOC, HKNLHLGNMIC, CNLDJBNEPAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly AJKKBOPPAOC HJOEPKDFBAN;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public GJGNFGDHFCI HGFGBJPFNNN
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE850", Offset = "0x7DDDA50", VA = "0x187DDE850", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int DLKFEOFPFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE5E0", Offset = "0x7DDD7E0", VA = "0x187DDE5E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int LPKKIPCPONM
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE3A0", Offset = "0x7DDD5A0", VA = "0x187DDE3A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LBBEDEHLLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int EOEIEBOKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GJGCDFFEPNH.JFBGFLJNBKD FFAAHPGIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event KDCCIIAHBJI GJCLICCEPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE7B0", Offset = "0x7DDD9B0", VA = "0x187DDE7B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE4A0", Offset = "0x7DDD6A0", VA = "0x187DDE4A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> DHOJMAMGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<GJGNFGDHFCI> DEOFBNCJHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action FABDANMOEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE540", Offset = "0x7DDD740", VA = "0x187DDE540", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE710", Offset = "0x7DDD910", VA = "0x187DDE710", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xC0E9D0", Offset = "0xC0DBD0", VA = "0x180C0E9D0")]
	public ODMPCCFNAAK(AJKKBOPPAOC HJOEPKDFBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE3F0", Offset = "0x7DDD5F0", VA = "0x187DDE3F0", Slot = "8")]
	public bool EKAACJEFJEO(byte BHACABOKOII, object ACGGGKHNIDL, HCBDIFBPMFO PBMCEFOCHAO, SendOptions FHHPBJNDMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE630", Offset = "0x7DDD830", VA = "0x187DDE630", Slot = "16")]
	public GJGNFGDHFCI HCNKBOPOIKB(int GMGPDOAAFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "19")]
	public void FEAIMFDCHHB(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "20")]
	public void PBFCFEOGFMI(object GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "21")]
	public void FDLPBODEAEF(object GIIKHLJPAKH, bool PPPFFGDDNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE350", Offset = "0x7DDD550", VA = "0x187DDE350", Slot = "22")]
	public IDisposable CKDAHHLHNAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "23")]
	private bool ONHHDICEKBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "24")]
	public void FFOCFFBDILO(StringBuilder INAHACHGGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xE371A0", Offset = "0xE363A0", VA = "0x180E371A0", Slot = "25")]
	public bool ABMOIMKFILJ(bool BDGAFKJDIND, [Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0xDC0500", Offset = "0xDBF700", VA = "0x180DC0500", Slot = "28")]
	public void NJBLODBELBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct CIIEBPEGBGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> ELLEMLBGHOH;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	public CIIEBPEGBGH(IDictionary<object, object> ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9F40", Offset = "0x7DC9140", VA = "0x187DC9F40")]
	public bool AGKPLDIBJJH([Out] AHCJONDEEIE DCEACFEGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA210", Offset = "0x7DC9410", VA = "0x187DCA210")]
	public Guid OBELBOPAGLK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9FF0", Offset = "0x7DC91F0", VA = "0x187DC9FF0")]
	public KLKDBEPMPLI DIJADAAOPBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA120", Offset = "0x7DC9320", VA = "0x187DCA120")]
	public static ExitGames.Client.Photon.Hashtable JENMMFKNHKF(AHCJONDEEIE DCEACFEGBDC, KLKDBEPMPLI KOPLFBCPDKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class GBNCIFOEMFC
{
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF100", Offset = "0x7DCE300", VA = "0x187DCF100")]
	public static bool AKIFIBFDANL(this DCEEACKECED EGGCEGONBOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct GJOMKKMGMFJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct BBHHGNBBKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public GJOMKKMGMFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6640", Offset = "0x7DC5840", VA = "0x187DC6640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6820", Offset = "0x7DC5A20", VA = "0x187DC6820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource IFEDHDENNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task JJCLBODJJAC;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool IEIFJCLJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF460", Offset = "0x7DCE660", VA = "0x187DCF460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF490", Offset = "0x7DCE690", VA = "0x187DCF490")]
	public GJOMKKMGMFJ(CancellationToken KPIINMODKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF350", Offset = "0x7DCE550", VA = "0x187DCF350")]
	[AsyncStateMachine(typeof(BBHHGNBBKKK))]
	public Task FCFMGECONJJ(Func<CancellationToken, List<Task>> OGIEIDIOPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7DCF300", Offset = "0x7DCE500", VA = "0x187DCF300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct KAHLHCJAPFH<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct JCMNAOPAIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<KPOLCABDGNG<TData>, ILEHMOEGHGD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public KAHLHCJAPFH<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<CPEANPEHCAG<KPOLCABDGNG<TData>, ILEHMOEGHGD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x495D150", Offset = "0x495C350", VA = "0x18495D150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x495DD00", Offset = "0x495CF00", VA = "0x18495DD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly GCEJENCOLBB<TGetDataArg, TData> PHEPOEOOCBF;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	internal KAHLHCJAPFH(GCEJENCOLBB<TGetDataArg, TData> LAJMFENCBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4A513D0", Offset = "0x4A505D0", VA = "0x184A513D0")]
	[AsyncStateMachine(typeof(KAHLHCJAPFH<, >.JCMNAOPAIED))]
	public Task<CPEANPEHCAG<KPOLCABDGNG<TData>, ILEHMOEGHGD>> OEDGFPKDBHF(TGetDataArg DLGGINKGFFM, string EAJAFOHNDOF, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class KHIBJDDNING
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x32C94D0", Offset = "0x32C86D0", VA = "0x1832C94D0")]
	public static KAHLHCJAPFH<TGetDataArg, TData> PEFMILKIAFF<TGetDataArg, TData>(GCEJENCOLBB<TGetDataArg, TData> LAJMFENCBAB)
	{
		return default(KAHLHCJAPFH<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct MPMBFLBDMHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int OPBMIJGNKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? FOLMAABENJP;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1BEB0", Offset = "0x4B1B0B0", VA = "0x184B1BEB0")]
	public MPMBFLBDMHG(int GEDIIGIDHKB, [Optional] int? JKHNAPMMECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB8F0", Offset = "0x7DDAAF0", VA = "0x187DDB8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface BDMALFBCEIP<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHFEKKGFKMJ();

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BDMALFBCEIP<T> COPLLFEELHO(string NGDINNOFNDP);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BDMALFBCEIP<T> LBILJJBGGLN(HAJDMPLPABI<T> LIBJPLBCAGK);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BDMALFBCEIP<T> GGIPDIALDJO(int CAPIHDDNOAD);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BDMALFBCEIP<T> DCFONIOIPIE(int CAPIHDDNOAD, KOHDICFAJKO<T> EJLDAHBACJD);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface POMBJKBIJBC
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BDMALFBCEIP<T> PNIEGLNPHDD<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKBOHLGCPKA LDBMICBMAFL(Exception GMEDNHNLLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPMBFLBDMHG DGHGPMOGELP(Exception GMEDNHNLLCJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string HAJDMPLPABI<in T>(T GMEDNHNLLCJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int KOHDICFAJKO<in T>(T GMEDNHNLLCJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class OLMBDKODHKF : POMBJKBIJBC
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string NKMMHFKNDIK(Exception GMEDNHNLLCJ);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int DDKALGHIOEF(Exception GMEDNHNLLCJ);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class EJGFAKCOFBB<T> : BDMALFBCEIP<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class BPNPPACKLFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public BPNPPACKLFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			internal string MGFBIJDONMA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class IAFECHLMBPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public HAJDMPLPABI<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public IAFECHLMBPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x475C5E0", Offset = "0x475B7E0", VA = "0x18475C5E0")]
			internal string MAPALMCOBLG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class KGJBOPIOHGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public KOHDICFAJKO<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public KGJBOPIOHGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x475C5E0", Offset = "0x475B7E0", VA = "0x18475C5E0")]
			internal int NPFFIELJODO(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly OLMBDKODHKF IDBCFACOCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type FJHMFEPLFLG;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x4102540", Offset = "0x4101740", VA = "0x184102540")]
		internal EJGFAKCOFBB(OLMBDKODHKF IDBCFACOCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x41023F0", Offset = "0x41015F0", VA = "0x1841023F0", Slot = "4")]
		public void JHFEKKGFKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x4102160", Offset = "0x4101360", VA = "0x184102160", Slot = "5")]
		public BDMALFBCEIP<T> COPLLFEELHO(string NGDINNOFNDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x4102420", Offset = "0x4101620", VA = "0x184102420", Slot = "6")]
		public BDMALFBCEIP<T> LBILJJBGGLN(HAJDMPLPABI<T> LIBJPLBCAGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x41023B0", Offset = "0x41015B0", VA = "0x1841023B0", Slot = "7")]
		public BDMALFBCEIP<T> GGIPDIALDJO(int CAPIHDDNOAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x4102280", Offset = "0x4101480", VA = "0x184102280", Slot = "8")]
		public BDMALFBCEIP<T> DCFONIOIPIE(int CAPIHDDNOAD, KOHDICFAJKO<T> EJLDAHBACJD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class FODPBHMHIAA<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool EMEJPBKLLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> IAAPHFLEJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> MFDELAICIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> ADOGOPMNFPB;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> PHEBFIPMNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x455F780", Offset = "0x455E980", VA = "0x18455F780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x455FA90", Offset = "0x455EC90", VA = "0x18455FA90")]
		public FODPBHMHIAA(Dictionary<Type, int> ADOGOPMNFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x455F9E0", Offset = "0x455EBE0", VA = "0x18455F9E0")]
		public void OFEFHMDJLMD(Type MBDBONINAPC, TVal HBMPJOCKNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x455F690", Offset = "0x455E890", VA = "0x18455F690")]
		public bool BODAINJJNMD(Type FJHMFEPLFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x455F6E0", Offset = "0x455E8E0", VA = "0x18455F6E0")]
		public bool MOKPABAEOMC(TVal OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x455F8E0", Offset = "0x455EAE0", VA = "0x18455F8E0")]
		public TVal NKAAMPBENGI(Type NNILCBOLNDI)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x455F5F0", Offset = "0x455E7F0", VA = "0x18455F5F0")]
		[CompilerGenerated]
		private int AJLFENEAFKC(Type AHHOMGNEHGE, Type CCMKCEJDOCM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class MDJCLHHIDNL : IEnumerable<MPMBFLBDMHG>, IEnumerable, IEnumerator<MPMBFLBDMHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private MPMBFLBDMHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public OLMBDKODHKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private IEnumerator<MPMBFLBDMHG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private MPMBFLBDMHG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x417E200", Offset = "0x417D400", VA = "0x18417E200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MPMBFLBDMHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x7DDA200", Offset = "0x7DD9400", VA = "0x187DDA200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public MDJCLHHIDNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA250", Offset = "0x7DD9450", VA = "0x187DDA250", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9BF0", Offset = "0x7DD8DF0", VA = "0x187DD9BF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA0A0", Offset = "0x7DD92A0", VA = "0x187DDA0A0")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9BA0", Offset = "0x7DD8DA0", VA = "0x187DD9BA0")]
		private void HEIMKCGCNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA1B0", Offset = "0x7DD93B0", VA = "0x187DDA1B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA0F0", Offset = "0x7DD92F0", VA = "0x187DDA0F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MPMBFLBDMHG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DDA0F0", Offset = "0x7DD92F0", VA = "0x187DDA0F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly MPMBFLBDMHG NBFDOCNPNKI;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> MGGLKDALAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> PKAOHHCEBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly FODPBHMHIAA<int> GAAIHMBIDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly FODPBHMHIAA<DDKALGHIOEF> EKJKGLEECKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly FODPBHMHIAA<NKMMHFKNDIK> FIPEPJFJAEC;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF2A0", Offset = "0x7DDE4A0", VA = "0x187DDF2A0")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	internal static void JHIKJAALCJE(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC80", Offset = "0x7DDEE80", VA = "0x187DDFC80")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLMBDKODHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x32C8ED0", Offset = "0x32C80D0", VA = "0x1832C8ED0", Slot = "4")]
	public BDMALFBCEIP<T> PNIEGLNPHDD<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF5E0", Offset = "0x7DDE7E0", VA = "0x187DDF5E0", Slot = "5")]
	public NKBOHLGCPKA LDBMICBMAFL(Exception GMEDNHNLLCJ)
	{
		return default(NKBOHLGCPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEF20", Offset = "0x7DDE120", VA = "0x187DDEF20", Slot = "6")]
	public MPMBFLBDMHG DGHGPMOGELP(Exception? GMEDNHNLLCJ)
	{
		return default(MPMBFLBDMHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF200", Offset = "0x7DDE400", VA = "0x187DDF200", Slot = "7")]
	[IteratorStateMachine(typeof(MDJCLHHIDNL))]
	public IEnumerable<MPMBFLBDMHG> JHAGGCDECKK(Exception GMEDNHNLLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE8A0", Offset = "0x7DDDAA0", VA = "0x187DDE8A0", Slot = "8")]
	public string CBBHIIADCED(Exception? GMEDNHNLLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF670", Offset = "0x7DDE870", VA = "0x187DDF670")]
	private string MOJCLCMOPMA(AggregateException HLKMFJMHGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE9F0", Offset = "0x7DDDBF0", VA = "0x187DDE9F0")]
	private void CGGEFIMMCHI(Type FJHMFEPLFLG, int CAPIHDDNOAD, DDKALGHIOEF? DMCAHKDCNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF970", Offset = "0x7DDEB70", VA = "0x187DDF970")]
	private void NHHHKIADOFD(Type FJHMFEPLFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF310", Offset = "0x7DDE510", VA = "0x187DDF310")]
	private void KHDLLFMGLLN(Type FJHMFEPLFLG, NKMMHFKNDIK CMJDCPCFCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEDA0", Offset = "0x7DDDFA0", VA = "0x187DDEDA0")]
	private static int DDCENJJDGNH(Type FJHMFEPLFLG, Dictionary<Type, int> ADOGOPMNFPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x365CE20", Offset = "0x365C020", VA = "0x18365CE20")]
	private static bool GIEJHPABKGF<TVal>(FODPBHMHIAA<TVal> ALKPNNHBNLO, Type FJHMFEPLFLG, [Out] TVal OMFJNFBDJCA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF120", Offset = "0x7DDE320", VA = "0x187DDF120")]
	[CompilerGenerated]
	internal static int GLBDMEGOKMN(Type PAMBAHMBELO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct NKBOHLGCPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly MPMBFLBDMHG EFMPLGMOIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string PNKIBBIDGAP;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD0A0", Offset = "0x7DDC2A0", VA = "0x187DDD0A0")]
	public NKBOHLGCPKA(string DPOLLFKGKPO, MPMBFLBDMHG CAPIHDDNOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDD000", Offset = "0x7DDC200", VA = "0x187DDD000")]
	public string KOLCOAKOFKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class IBKCJDIIGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly ECHOGNCJJEK HAENPLMOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string ILJMPLLKBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? NOAFJFFAMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? DAOIFCACIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? CPDJHDJBDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string CGLDLJPHCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private DEMHAFNOBAG JKMMJHBAMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? KFMNNMBPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool GHGJDAEAMOE;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string JMGAOMBKGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long FPDOAGMGLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2690", Offset = "0x7DD1890", VA = "0x187DD2690")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long NJIMIDJJHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1D90", Offset = "0x7DD0F90", VA = "0x187DD1D90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long MNLDNFCIIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2340", Offset = "0x7DD1540", VA = "0x187DD2340")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string ELPBMJDOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1DF0", Offset = "0x7DD0FF0", VA = "0x187DD1DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public DEMHAFNOBAG NICJLFLCMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xC58EB0", Offset = "0xC580B0", VA = "0x180C58EB0")]
		get
		{
			return default(DEMHAFNOBAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD26F0", Offset = "0x7DD18F0", VA = "0x187DD26F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long BIHKIODOANP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1D30", Offset = "0x7DD0F30", VA = "0x187DD1D30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2B60", Offset = "0x7DD1D60", VA = "0x187DD2B60")]
	[UnityEngine.Scripting.Preserve]
	public IBKCJDIIGLE([KMMHIEIDBEA(null)] ECHOGNCJJEK HAENPLMOPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2440", Offset = "0x7DD1640", VA = "0x187DD2440")]
	private void JLLBIAIIGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1EB0", Offset = "0x7DD10B0", VA = "0x187DD1EB0")]
	public void IFAOKCOGJJJ(long KCAAOMDKNIH, long HPHKCHODKPD, [Optional] long? AKDHEFBHHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DD23A0", Offset = "0x7DD15A0", VA = "0x187DD23A0")]
	public void JJFEHDNELDB(long AKDHEFBHHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1E30", Offset = "0x7DD1030", VA = "0x187DD1E30")]
	public void GBOGIIIECHL(string EHKIAOOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD27E0", Offset = "0x7DD19E0", VA = "0x187DD27E0")]
	public void OLPHFDAONLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class FCDEPCDPKFP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct LOEMLIKJBDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public AHCJONDEEIE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public FCDEPCDPKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<LNAMJHHEPDO.AKNHCECKMNA<AHCJONDEEIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD85C0", Offset = "0x7DD77C0", VA = "0x187DD85C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8B00", Offset = "0x7DD7D00", VA = "0x187DD8B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct CJACFILGEGE<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class JPDJDLLHANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public AHCJONDEEIE roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JPDJDLLHANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5630", Offset = "0x7DD4830", VA = "0x187DD5630")]
		internal AHCJONDEEIE DJHMMGJONIH(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct DAPFIMDHMAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<LNAMJHHEPDO.AKNHCECKMNA<AHCJONDEEIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public AHCJONDEEIE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public FCDEPCDPKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private HLMOGNAOHJD <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<LNAMJHHEPDO.AKNHCECKMNA<AHCJONDEEIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB100", Offset = "0x7DCA300", VA = "0x187DCB100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB710", Offset = "0x7DCA910", VA = "0x187DCB710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct HKFFMOEAKHB<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public FCDEPCDPKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x46B3710", Offset = "0x46B2910", VA = "0x1846B3710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D73880", Offset = "0x3D72A80", VA = "0x183D73880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct OOFGMLFFCDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public FCDEPCDPKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE00A0", Offset = "0x7DDF2A0", VA = "0x187DE00A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0260", Offset = "0x7DDF460", VA = "0x187DE0260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class GJJODFMDMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GJJODFMDMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF1E0", Offset = "0x7DCE3E0", VA = "0x187DCF1E0")]
		internal object CDDOLPKGMJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF240", Offset = "0x7DCE440", VA = "0x187DCF240")]
		internal bool CEGGJKOOJMD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class DHAHOLFGGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DHAHOLFGGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DCC430", Offset = "0x7DCB630", VA = "0x187DCC430")]
		internal object MFKOGFNMHHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class JEMJMDFHAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JEMJMDFHAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD53C0", Offset = "0x7DD45C0", VA = "0x187DD53C0")]
		internal object KODFPLEPIPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class ODEJIPJPNLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ODEJIPJPNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE2E0", Offset = "0x7DDD4E0", VA = "0x187DDE2E0")]
		internal object JGABHCADJPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class BCJBCKCMEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public FCDEPCDPKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BCJBCKCMEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6880", Offset = "0x7DC5A80", VA = "0x187DC6880")]
		internal object PJGBABKJLIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid PMCJIAJPGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly MBCPBGIAHHB CHLNKEOONOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly LNAMJHHEPDO KLJLALFKHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly HKNLHLGNMIC IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly CNLDJBNEPAF GBLKJABLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool BGJLKFBAPNP;

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEE10", Offset = "0x7DCE010", VA = "0x187DCEE10")]
	public FCDEPCDPKFP(MBCPBGIAHHB BHEFDPAMAKP, LNAMJHHEPDO KLJLALFKHDI, HKNLHLGNMIC IMAAHCGDBEG, CNLDJBNEPAF GBLKJABLPAA, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DCDF60", Offset = "0x7DCD160", VA = "0x187DCDF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE710", Offset = "0x7DCD910", VA = "0x187DCE710")]
	public void JNIKGNAMMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DCDEA0", Offset = "0x7DCD0A0", VA = "0x187DCDEA0")]
	public void BBIFOAMGPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE830", Offset = "0x7DCDA30", VA = "0x187DCE830")]
	public void KHELLKFEDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE230", Offset = "0x7DCD430", VA = "0x187DCE230")]
	[AsyncStateMachine(typeof(LOEMLIKJBDH))]
	internal Task<AHCJONDEEIE> HDPNDMFPDNM(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, AHCJONDEEIE AGMJBICPPII, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x34395D0", Offset = "0x34387D0", VA = "0x1834395D0")]
	private static byte[] AHEKCPIINBJ<T>(T DCEACFEGBDC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x34396D0", Offset = "0x34388D0", VA = "0x1834396D0")]
	private static T OGLFCLHPCOH<T>(MessageParser<T> CLIOLFNEHDD, byte[] DCEACFEGBDC, T ABLBOLEBNHP) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE390", Offset = "0x7DCD590", VA = "0x187DCE390")]
	[AsyncStateMachine(typeof(DAPFIMDHMAP))]
	private Task<LNAMJHHEPDO.AKNHCECKMNA<AHCJONDEEIE>> HFPCNKANFEA(AHCJONDEEIE AGMJBICPPII, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x3439820", Offset = "0x3438A20", VA = "0x183439820")]
	[AsyncStateMachine(typeof(HKFFMOEAKHB<>))]
	internal Task<T> PPINNAANACD<T>(CancellationToken BAIPNBEOGFG, Func<CancellationToken, Task<T>> ONBCLBMOMCG, int FGNGBBEHMMH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEC80", Offset = "0x7DCDE80", VA = "0x187DCEC80")]
	[AsyncStateMachine(typeof(OOFGMLFFCDG))]
	internal Task PPINNAANACD(CancellationToken BAIPNBEOGFG, Func<CancellationToken, Task> ONBCLBMOMCG, int FGNGBBEHMMH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEC00", Offset = "0x7DCDE00", VA = "0x187DCEC00")]
	public AHAFMGCJPCC OJLINGCGPLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEB80", Offset = "0x7DCDD80", VA = "0x187DCEB80")]
	public BFBIJABPJEA OEOBMABENNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DCDFC0", Offset = "0x7DCD1C0", VA = "0x187DCDFC0")]
	public BCJBOEOHOBE GHBFGLNHFCI([Optional] PBBCGFNIILA? NPAEAIAJLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DCDD40", Offset = "0x7DCCF40", VA = "0x187DCDD40")]
	public void AMGELOMDDJE(Func<Guid, bool> FNDNKBLGJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DCDC30", Offset = "0x7DCCE30", VA = "0x187DCDC30")]
	public void AALEEAIEOJK(Func<Guid, bool> AMCPDGPOAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE8F0", Offset = "0x7DCDAF0", VA = "0x187DCE8F0")]
	public Guid LAALFNOGJED()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEA70", Offset = "0x7DCDC70", VA = "0x187DCEA70")]
	public void NILCLFEPFLO(Guid DBLHHEHIAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE4D0", Offset = "0x7DCD6D0", VA = "0x187DCE4D0")]
	public void INPOGOLNCAJ(AHCJONDEEIE LDPEFFBAMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE600", Offset = "0x7DCD800", VA = "0x187DCE600")]
	public void IPKFDHIOJFD(string EBGFLBAEMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x34395E0", Offset = "0x34387E0", VA = "0x1834395E0")]
	private T BEGHJFILIJD<T>(T OMFJNFBDJCA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7DCDF70", Offset = "0x7DCD170", VA = "0x187DCDF70")]
	public void FONFKLLLLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3439330", Offset = "0x3438530", VA = "0x183439330")]
	[CompilerGenerated]
	internal static string ABFFLLBIEJE<T>(byte[] GJKPEEJCIPN, int FLFNGMJEBAD, CJACFILGEGE<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal sealed class MELHMEBMPMJ : MBCPBGIAHHB
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class KBBAGDCCNPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KBBAGDCCNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5710", Offset = "0x7DD4910", VA = "0x187DD5710")]
		internal object GGGHCEFPACF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct KOHILOOPFKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public MELHMEBMPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private BAIODOPPBMJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private BFBIJABPJEA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6CD0", Offset = "0x7DD5ED0", VA = "0x187DD6CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7620", Offset = "0x7DD6820", VA = "0x187DD7620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct EIEJGPCJCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public MELHMEBMPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter<AELLMCLLHFN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7DCD270", Offset = "0x7DCC470", VA = "0x187DCD270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DCD9A0", Offset = "0x7DCCBA0", VA = "0x187DCD9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct MBPNLJEBNEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MELHMEBMPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<DFMNJLHLEJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9820", Offset = "0x7DD8A20", VA = "0x187DD9820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9B30", Offset = "0x7DD8D30", VA = "0x187DD9B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class IMEBIMBEJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public BAIODOPPBMJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IMEBIMBEJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3540", Offset = "0x7DD2740", VA = "0x187DD3540")]
		internal object BFHKNEHCLIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private static readonly PBBCGFNIILA CFBMFDKKNKK;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private static readonly PBBCGFNIILA DIFAGHEJLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly FNACBPJKCJM EPGKJGLOHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly DCEEACKECED OKFJDEOMCHD;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA990", Offset = "0x7DD9B90", VA = "0x187DDA990")]
	public MELHMEBMPMJ(FNACBPJKCJM EPGKJGLOHMG, DCEEACKECED OKFJDEOMCHD, Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, LDKHAKHICKG JOJNOJMPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA3A0", Offset = "0x7DD95A0", VA = "0x187DDA3A0", Slot = "7")]
	[AsyncStateMachine(typeof(KOHILOOPFKF))]
	protected override Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA4E0", Offset = "0x7DD96E0", VA = "0x187DDA4E0")]
	[AsyncStateMachine(typeof(EIEJGPCJCIM))]
	private Task BHBFAKOKBPL(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA5E0", Offset = "0x7DD97E0", VA = "0x187DDA5E0")]
	[AsyncStateMachine(typeof(MBPNLJEBNEP))]
	private Task<int> IAJBNGBHKPO(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7DDA6F0", Offset = "0x7DD98F0", VA = "0x187DDA6F0")]
	private BAIODOPPBMJ MEMGHLBMBOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class GMEMBNLFIDN : MBCPBGIAHHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct DFMGKPDPICE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public GMEMBNLFIDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter<FCICKLINDLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB780", Offset = "0x7DCA980", VA = "0x187DCB780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7DCC130", Offset = "0x7DCB330", VA = "0x187DCC130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly int NKCHBAAKGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly FLDEFDNOGMD KJOBADLNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public readonly long CBKFHOJDEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public readonly long FGDHLLAOEEE;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public FCICKLINDLO LFIMHINBBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x970710", Offset = "0x96F910", VA = "0x180970710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x970670", Offset = "0x96F870", VA = "0x180970670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFF90", Offset = "0x7DCF190", VA = "0x187DCFF90")]
	public GMEMBNLFIDN(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, LDKHAKHICKG JOJNOJMPKPM, int NKCHBAAKGDO, FLDEFDNOGMD KJOBADLNJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x7DCFE70", Offset = "0x7DCF070", VA = "0x187DCFE70", Slot = "7")]
	[AsyncStateMachine(typeof(DFMGKPDPICE))]
	protected override Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal abstract class CCBONOFFMLH : MBCPBGIAHHB
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class AMJLCLOEGIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public CCBONOFFMLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public GHKAOHBFGHI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AMJLCLOEGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6570", Offset = "0x7DC5770", VA = "0x187DC6570")]
		internal Task NOGJGACJAFB(AGOOCHPPHOP<string>.ABBPACGFNKJ postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7DC65B0", Offset = "0x7DC57B0", VA = "0x187DC65B0")]
		internal object PHLLPHKMCCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct CLAFDENPPPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CCBONOFFMLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private AMJLCLOEGIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7DCA8D0", Offset = "0x7DC9AD0", VA = "0x187DCA8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB0A0", Offset = "0x7DCA2A0", VA = "0x187DCB0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct CJBEFCAINNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public GHKAOHBFGHI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CCBONOFFMLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7DCA2C0", Offset = "0x7DC94C0", VA = "0x187DCA2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7DCA870", Offset = "0x7DC9A70", VA = "0x187DCA870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9D70", Offset = "0x7DC8F70", VA = "0x187DC9D70")]
	public CCBONOFFMLH(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, LDKHAKHICKG JOJNOJMPKPM, string JFOEJHFHBCJ, KEKDHGAJBOE BFCANANPGGJ, bool FCEOINGECPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9AF0", Offset = "0x7DC8CF0", VA = "0x187DC9AF0", Slot = "7")]
	[AsyncStateMachine(typeof(CLAFDENPPPO))]
	protected override Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task JHBNFCLOJFG(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9C30", Offset = "0x7DC8E30", VA = "0x187DC9C30")]
	[AsyncStateMachine(typeof(CJBEFCAINNE))]
	private Task JDLOJPPCDCK(IDisposable IJKFALHGFKO, GHKAOHBFGHI ONGPMGJKBDC, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class DFOFLNIMLOI : MBCPBGIAHHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct INGFMGJLNOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public DFOFLNIMLOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<OACJBLAPPIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x7DD38D0", Offset = "0x7DD2AD0", VA = "0x187DD38D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3E60", Offset = "0x7DD3060", VA = "0x187DD3E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly NCDJJBLPPNH KMONDJFBELJ;

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC390", Offset = "0x7DCB590", VA = "0x187DCC390")]
	public DFOFLNIMLOI(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, LDKHAKHICKG JOJNOJMPKPM, NCDJJBLPPNH KMONDJFBELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC2B0", Offset = "0x7DCB4B0", VA = "0x187DCC2B0", Slot = "6")]
	protected override string FODKBFDKOJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC190", Offset = "0x7DCB390", VA = "0x187DCC190", Slot = "7")]
	[AsyncStateMachine(typeof(INGFMGJLNOB))]
	protected override Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal abstract class MBCPBGIAHHB : FMLIAHBLCPL
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	public delegate Task PFHOBDKMPOA(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class EPBFHFOOMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public MBCPBGIAHHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EPBFHFOOMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDB00", Offset = "0x7DCCD00", VA = "0x187DCDB00")]
		internal Task POKMOEKPEDG(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class GBJGCADBFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public EPBFHFOOMHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GBJGCADBFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF040", Offset = "0x7DCE240", VA = "0x187DCF040")]
		internal object HKHAEPDCDOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct NKEFDCKGEEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public MBCPBGIAHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public Func<MBCPBGIAHHB, AGOOCHPPHOP<string>.ABBPACGFNKJ, FCDEPCDPKFP> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private EPBFHFOOMHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private FCDEPCDPKFP <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<AHCJONDEEIE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7DDD0C0", Offset = "0x7DDC2C0", VA = "0x187DDD0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7DDE280", Offset = "0x7DDD480", VA = "0x187DDE280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct HADLONOCLCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x7DD00C0", Offset = "0x7DCF2C0", VA = "0x187DD00C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0B60", Offset = "0x7DCFD60", VA = "0x187DD0B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct MHCKGOFKFOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public MBCPBGIAHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAB20", Offset = "0x7DD9D20", VA = "0x187DDAB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAE80", Offset = "0x7DDA080", VA = "0x187DDAE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public readonly Guid LGGPFCEDJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public readonly ByteString GGEAMGALDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public readonly LDKHAKHICKG IOGAFEBDIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	protected readonly string CGBGEOAIHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private readonly OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private readonly bool FCEOINGECPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private readonly Queue<PFHOBDKMPOA> JEGKGGPEDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly MLLBPDODABK HIBKDOOGMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly KEKDHGAJBOE BFCANANPGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private bool NNHCNMNOLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public DEMHAFNOBAG POENPCKKNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public DEMHAFNOBAG KOMCLEJEIJE;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public OKOJPAHMDCL MENPKFFINBO
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD9170", Offset = "0x7DD8370", VA = "0x187DD9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HLHIINNPBJD BEEJCKPCDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8EA0", Offset = "0x7DD80A0", VA = "0x187DD8EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD91E0", Offset = "0x7DD83E0", VA = "0x187DD91E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CKOAIHNFKKN IPPLKGHMBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD91C0", Offset = "0x7DD83C0", VA = "0x187DD91C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8F50", Offset = "0x7DD8150", VA = "0x187DD8F50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x7DD96C0", Offset = "0x7DD88C0", VA = "0x187DD96C0")]
	protected MBCPBGIAHHB(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, LDKHAKHICKG JOJNOJMPKPM, string JFOEJHFHBCJ, KEKDHGAJBOE BFCANANPGGJ, bool FCEOINGECPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8C90", Offset = "0x7DD7E90", VA = "0x187DD8C90", Slot = "6")]
	protected virtual string FODKBFDKOJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8EF0", Offset = "0x7DD80F0", VA = "0x187DD8EF0")]
	public void IOIPBKLOMMI(PFHOBDKMPOA BDBLHJDLOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9390", Offset = "0x7DD8590", VA = "0x187DD9390")]
	protected void OMJNHBHBGAP(float FGNDNDOCBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8D50", Offset = "0x7DD7F50", VA = "0x187DD8D50")]
	[AsyncStateMachine(typeof(NKEFDCKGEEL))]
	public Task IDKCINHHAJH(CancellationToken KPIINMODKFJ, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, [Optional] Func<MBCPBGIAHHB, AGOOCHPPHOP<string>.ABBPACGFNKJ, FCDEPCDPKFP> IGHFLOLLLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x7DD9260", Offset = "0x7DD8460", VA = "0x187DD9260")]
	[AsyncStateMachine(typeof(HADLONOCLCL))]
	private static Task OMJAJLKJLGG(Func<CancellationToken, Task> MOIJLANDIDH, Func<CancellationToken, Task> IGDOGCOLHHG, CancellationToken BAIPNBEOGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8FF0", Offset = "0x7DD81F0", VA = "0x187DD8FF0")]
	private void MAFLCNMEFJJ(bool GDICEIEOEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x7DD93B0", Offset = "0x7DD85B0", VA = "0x187DD93B0")]
	private void PGGBKPANOLC(FCDEPCDPKFP FHKOAHJMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8B70", Offset = "0x7DD7D70", VA = "0x187DD8B70")]
	[AsyncStateMachine(typeof(MHCKGOFKFOF))]
	private Task AIHLJDGHLBK(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8CD0", Offset = "0x7DD7ED0", VA = "0x187DD8CD0")]
	public AHCJONDEEIE ICHGDAOJOON(HLMOGNAOHJD KFAHNGLAJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD95D0", Offset = "0x7DD87D0", VA = "0x187DD95D0")]
	[CompilerGenerated]
	private Task PKHMKLMAMKB(CancellationToken FDDEDLKEPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8F70", Offset = "0x7DD8170", VA = "0x187DD8F70")]
	[CompilerGenerated]
	private object LPLMOPKLOFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal sealed class BHHALBODNKP : CCBONOFFMLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct JEHIHGBECML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public BHHALBODNKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private GMLPEAHICBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private BFBIJABPJEA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4C00", Offset = "0x7DD3E00", VA = "0x187DD4C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5360", Offset = "0x7DD4560", VA = "0x187DD5360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private readonly FNACBPJKCJM OONPLECBLKN;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9920", Offset = "0x7DC8B20", VA = "0x187DC9920")]
	public BHHALBODNKP(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, FNACBPJKCJM OONPLECBLKN, LDKHAKHICKG JOJNOJMPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC97D0", Offset = "0x7DC89D0", VA = "0x187DC97D0", Slot = "8")]
	[AsyncStateMachine(typeof(JEHIHGBECML))]
	protected override Task JHBNFCLOJFG(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal class KKFLAFCIEON : MBCPBGIAHHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct JCGOJPKEONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public KKFLAFCIEON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter<OACJBLAPPIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD47F0", Offset = "0x7DD39F0", VA = "0x187DD47F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4BA0", Offset = "0x7DD3DA0", VA = "0x187DD4BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private readonly string AKNCKLDHMKD;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5E70", Offset = "0x7DD5070", VA = "0x187DD5E70")]
	public KKFLAFCIEON(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, LDKHAKHICKG JOJNOJMPKPM, string AKNCKLDHMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D60", Offset = "0x7DD4F60", VA = "0x187DD5D60", Slot = "7")]
	[AsyncStateMachine(typeof(JCGOJPKEONO))]
	protected override Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class IDPLDEBAJFD : CCBONOFFMLH
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class CEBEOMBFMJH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public CEBEOMBFMJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			private TaskAwaiter<OACJBLAPPIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private TaskAwaiter<AHCJONDEEIE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x7DE1970", Offset = "0x7DE0B70", VA = "0x187DE1970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x7DE1E60", Offset = "0x7DE1060", VA = "0x187DE1E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public IDPLDEBAJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public BCJBOEOHOBE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public LBFHGLMDMIM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public AHAFMGCJPCC uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public PFFHBCJMHCN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CEBEOMBFMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x7DC9DC0", Offset = "0x7DC8FC0", VA = "0x187DC9DC0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<AHCJONDEEIE> BFGKJIKOHEM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct LLAJAGJLLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public IDPLDEBAJFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private CEBEOMBFMJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private GMLPEAHICBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private BFBIJABPJEA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private AHCJONDEEIE <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7680", Offset = "0x7DD6880", VA = "0x187DD7680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8560", Offset = "0x7DD7760", VA = "0x187DD8560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private static readonly PBBCGFNIILA CFBMFDKKNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private readonly int BLIGPFACMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	[CanBeNull]
	private readonly JKFKKPNMGNI KPFKBHEJGDG;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3060", Offset = "0x7DD2260", VA = "0x187DD3060")]
	public IDPLDEBAJFD(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, int BLIGPFACMIG, JKFKKPNMGNI KPFKBHEJGDG, LDKHAKHICKG JOJNOJMPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2D70", Offset = "0x7DD1F70", VA = "0x187DD2D70", Slot = "8")]
	[AsyncStateMachine(typeof(LLAJAGJLLOM))]
	protected override Task JHBNFCLOJFG(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2EB0", Offset = "0x7DD20B0", VA = "0x187DD2EB0")]
	private void NCOPJDBNMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2BA0", Offset = "0x7DD1DA0", VA = "0x187DD2BA0")]
	private void AOOOJCMHFDB(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, GMLPEAHICBN LBBDJNJENGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class JHJBDAMJBJJ : MBCPBGIAHHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct NDDBCJNLDKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public JHJBDAMJBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private GMLPEAHICBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private CAFFOJNOKAH<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<FCICKLINDLO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB9D0", Offset = "0x7DDABD0", VA = "0x187DDB9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCB00", Offset = "0x7DDBD00", VA = "0x187DDCB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int BLIGPFACMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private readonly JKFKKPNMGNI KPFKBHEJGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private Func<OACJBLAPPIE, OACJBLAPPIE> APAIGGIABEH;

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5570", Offset = "0x7DD4770", VA = "0x187DD5570")]
	public JHJBDAMJBJJ(Guid LDHEJEOPGBF, OKOJPAHMDCL FAFBKMPEOID, int BLIGPFACMIG, JKFKKPNMGNI KPFKBHEJGDG, Func<OACJBLAPPIE, OACJBLAPPIE> APAIGGIABEH, LDKHAKHICKG JOJNOJMPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5430", Offset = "0x7DD4630", VA = "0x187DD5430", Slot = "7")]
	[AsyncStateMachine(typeof(NDDBCJNLDKJ))]
	protected override Task AOGGCNPKGJE(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal abstract class IMPIMBOILPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public readonly MBCPBGIAHHB CHLNKEOONOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public readonly FCDEPCDPKFP OGBECHGFBOE;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3790", Offset = "0x7DD2990", VA = "0x187DD3790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7DD37E0", Offset = "0x7DD29E0", VA = "0x187DD37E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3870", Offset = "0x7DD2A70", VA = "0x187DD3870")]
	protected IMPIMBOILPN(FCDEPCDPKFP FHKOAHJMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3680", Offset = "0x7DD2880", VA = "0x187DD3680")]
	protected void IPKFDHIOJFD(string EBGFLBAEMHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct BFNOMMLALIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Dictionary<Guid, List<DIINLENPKHL>> IIJIMJAIPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Dictionary<Guid, List<DIINLENPKHL>> BDDBCCAHAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public Dictionary<Guid, List<DIINLENPKHL>> MOEHNNKALLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public List<Guid> ELNFKNBFIHI;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x7DC91D0", Offset = "0x7DC83D0", VA = "0x187DC91D0")]
	public static BFNOMMLALIO NKAAMPBENGI(MGJHPJBBLPE EKJOCLHFECK, DEMHAFNOBAG AIPFAFCAAFC, JCDLFPMDPEJ BFCCKAKKEGJ)
	{
		return default(BFNOMMLALIO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct IANKLONGDHB
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	public static IANKLONGDHB JENMMFKNHKF()
	{
		return default(IANKLONGDHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct NGBKEMJECHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public readonly AELLMCLLHFN ADEJBLKPJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public readonly BJLNPLMLHJE PFBFPPDKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public readonly Guid? BKFAPPIPDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly IReadOnlyCollection<KLOJHPLIIPH> NKAKEDIAPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly IReadOnlyCollection<KLOJHPLIIPH> MBPADGIAHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly MMBNINEADFK EMKKMOEAANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly MMBNINEADFK HEELDKPGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly NLGNBINCOCE MJFAKOIHEGF;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool OLLKJCFPEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x7DDCB60", Offset = "0x7DDBD60", VA = "0x187DDCB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDCBF0", Offset = "0x7DDBDF0", VA = "0x187DDCBF0")]
	public NGBKEMJECHJ(AELLMCLLHFN ADEJBLKPJCF, BJLNPLMLHJE PFBFPPDKFBK, Guid? BKFAPPIPDIN, IReadOnlyList<KLOJHPLIIPH> NKAKEDIAPHJ, IReadOnlyCollection<KLOJHPLIIPH> MBPADGIAHMB, MMBNINEADFK EMKKMOEAANC, MMBNINEADFK HEELDKPGNPB, NLGNBINCOCE MJFAKOIHEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct MMGMDPOKDHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly FCDEPCDPKFP FHKOAHJMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Guid DBLHHEHIAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private bool GDICEIEOEJN;

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAEF0", Offset = "0x7DDA0F0", VA = "0x187DDAEF0")]
	public static MMGMDPOKDHL LAALFNOGJED(FCDEPCDPKFP FHKOAHJMJDD)
	{
		return default(MMGMDPOKDHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x105E560", Offset = "0x105D760", VA = "0x18105E560")]
	public void BBPAOANMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAEE0", Offset = "0x7DDA0E0", VA = "0x187DDAEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7DDB1F0", Offset = "0x7DDA3F0", VA = "0x187DDB1F0")]
	private MMGMDPOKDHL(FCDEPCDPKFP FHKOAHJMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAFC0", Offset = "0x7DDA1C0", VA = "0x187DDAFC0")]
	private void NILCLFEPFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7DDAF20", Offset = "0x7DDA120", VA = "0x187DDAF20")]
	private Func<Guid, bool> MBPAHDBGAAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal class BFBIJABPJEA : IMPIMBOILPN, FMLIAHBLCPL
{
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public delegate Task<DEMHAFNOBAG> EKPEFHHBKCA(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD JKFGCANIKDB, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct INHDPCDLJAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public FNACBPJKCJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private MMGMDPOKDHL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3EC0", Offset = "0x7DD30C0", VA = "0x187DD3EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD4790", Offset = "0x7DD3990", VA = "0x187DD4790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct KFCBEDCDING : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public FNACBPJKCJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5780", Offset = "0x7DD4980", VA = "0x187DD5780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5BB0", Offset = "0x7DD4DB0", VA = "0x187DD5BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct EDLPLPLIFCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public FNACBPJKCJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7DCCAC0", Offset = "0x7DCBCC0", VA = "0x187DCCAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7DCD100", Offset = "0x7DCC300", VA = "0x187DCD100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class MOKBFHHBMJG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public AsyncTaskMethodBuilder<NGBKEMJECHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public MOKBFHHBMJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private NGBKEMJECHJ <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter<DEMHAFNOBAG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			private TaskAwaiter<NGBKEMJECHJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x7DE0A20", Offset = "0x7DDFC20", VA = "0x187DE0A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x7DE1210", Offset = "0x7DE0410", VA = "0x187DE1210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000141")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public AsyncTaskMethodBuilder<JCDLFPMDPEJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public MOKBFHHBMJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			private JCDLFPMDPEJ <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			private TaskAwaiter<DEMHAFNOBAG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			private TaskAwaiter<JCDLFPMDPEJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x7DE1280", Offset = "0x7DE0480", VA = "0x187DE1280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x7DE1900", Offset = "0x7DE0B00", VA = "0x187DE1900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public FNACBPJKCJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public MLLBPDODABK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public MLLBPDODABK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public NGBKEMJECHJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public MLLBPDODABK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public JCDLFPMDPEJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public AJLCGOBAEIE.DLKLBEFPKOI <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MOKBFHHBMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB7A0", Offset = "0x7DDA9A0", VA = "0x187DDB7A0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<NGBKEMJECHJ> PEHFCIHPDGH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB380", Offset = "0x7DDA580", VA = "0x187DDB380")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<JCDLFPMDPEJ> FAKEJHFCAMA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB600", Offset = "0x7DDA800", VA = "0x187DDB600")]
		internal void PDDIPDBLAFH(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB4A0", Offset = "0x7DDA6A0", VA = "0x187DDB4A0")]
		internal Task GKECLCGLMIC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB640", Offset = "0x7DDA840", VA = "0x187DDB640")]
		internal Task PEEEKGCELHJ(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct KNIJAMIACIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public FNACBPJKCJM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private MOKBFHHBMJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter<NGBKEMJECHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<JCDLFPMDPEJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5F20", Offset = "0x7DD5120", VA = "0x187DD5F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6C70", Offset = "0x7DD5E70", VA = "0x187DD6C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct HOAJFNEINLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public JCDLFPMDPEJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public MLLBPDODABK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private IOCODLMNLCD <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DD0BC0", Offset = "0x7DCFDC0", VA = "0x187DD0BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DD1CD0", Offset = "0x7DD0ED0", VA = "0x187DD1CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct LJKBPOFMJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF25E0", Offset = "0x7DF17E0", VA = "0x187DF25E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2DC0", Offset = "0x7DF1FC0", VA = "0x187DF2DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct DJAHONBAANL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5840", Offset = "0x7DE4A40", VA = "0x187DE5840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6080", Offset = "0x7DE5280", VA = "0x187DE6080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct PJDPEDCIICO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7580", Offset = "0x7DF6780", VA = "0x187DF7580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8540", Offset = "0x7DF7740", VA = "0x187DF8540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct PLOHACKMLEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public IOCODLMNLCD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7DF85B0", Offset = "0x7DF77B0", VA = "0x187DF85B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF96C0", Offset = "0x7DF88C0", VA = "0x187DF96C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct GLIPIMJJJJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public DEMHAFNOBAG operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public JCDLFPMDPEJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB790", Offset = "0x7DEA990", VA = "0x187DEB790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB9E0", Offset = "0x7DEABE0", VA = "0x187DEB9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class HGFBNKADENM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public HGFBNKADENM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private IFOOKNGMDBJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter<DEMHAFNOBAG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x7DFA140", Offset = "0x7DF9340", VA = "0x187DFA140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x7DFA760", Offset = "0x7DF9960", VA = "0x187DFA760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public EKPEFHHBKCA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public IOCODLMNLCD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public DEMHAFNOBAG originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HGFBNKADENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC590", Offset = "0x7DEB790", VA = "0x187DEC590")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DEMHAFNOBAG> BPDPLMHBPED(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct HLHFKKMKGCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public EKPEFHHBKCA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public IOCODLMNLCD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DED7C0", Offset = "0x7DEC9C0", VA = "0x187DED7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDCE0", Offset = "0x7DECEE0", VA = "0x187DEDCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct CFNECLLDEJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private DEMHAFNOBAG <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private IEnumerator<DEMHAFNOBAG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE41F0", Offset = "0x7DE33F0", VA = "0x187DE41F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4740", Offset = "0x7DE3940", VA = "0x187DE4740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct PJCJBLLEABM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7230", Offset = "0x7DF6430", VA = "0x187DF7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7520", Offset = "0x7DF6720", VA = "0x187DF7520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct LAGIOGCFOKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1E70", Offset = "0x7DF1070", VA = "0x187DF1E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2090", Offset = "0x7DF1290", VA = "0x187DF2090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class NLIKANPIOAP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public NLIKANPIOAP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public JCDLFPMDPEJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public MLLBPDODABK progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter<DEMHAFNOBAG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			private TaskAwaiter<CIDHBPNLJAH> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7DFA7D0", Offset = "0x7DF99D0", VA = "0x187DFA7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x7DFB290", Offset = "0x7DFA490", VA = "0x187DFB290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public MPEPKMBGHPK mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NLIKANPIOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF49E0", Offset = "0x7DF3BE0", VA = "0x187DF49E0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<DEMHAFNOBAG> HGIDIDCGNAF(JCDLFPMDPEJ data, IOCODLMNLCD _, MLLBPDODABK progressTracker, AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct GFLFDDKDGJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public JCDLFPMDPEJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public MLLBPDODABK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private NLIKANPIOAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private IOCODLMNLCD <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9DC0", Offset = "0x7DE8FC0", VA = "0x187DE9DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEAC90", Offset = "0x7DE9E90", VA = "0x187DEAC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct DNFHAIJAMNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6200", Offset = "0x7DE5400", VA = "0x187DE6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6600", Offset = "0x7DE5800", VA = "0x187DE6600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct NPLJJPELHCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public BFBIJABPJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public MLLBPDODABK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5CA0", Offset = "0x7DF4EA0", VA = "0x187DF5CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DF62C0", Offset = "0x7DF54C0", VA = "0x187DF62C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly NIMCCIBCNBA CCKCNBBOEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly NIMCCIBCNBA MBPCCLLOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly IBKCJDIIGLE GDKELIHNJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly FBEOLNFJCBK KGCPCICFPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly AIKDHCLNJEL EMACCNOBMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private ProfilerCounterValue<int> FENCEGCONOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly OKGFHNJKKJH LCGGNPFLIEI;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private OKOJPAHMDCL MENPKFFINBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8A80", Offset = "0x7DC7C80", VA = "0x187DC8A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CKOAIHNFKKN IPPLKGHMBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x7DC83D0", Offset = "0x7DC75D0", VA = "0x187DC83D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8260", Offset = "0x7DC7460", VA = "0x187DC8260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8F10", Offset = "0x7DC8110", VA = "0x187DC8F10")]
	public BFBIJABPJEA(FCDEPCDPKFP FHKOAHJMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8B10", Offset = "0x7DC7D10", VA = "0x187DC8B10")]
	[AsyncStateMachine(typeof(INHDPCDLJAA))]
	public Task OMGEDMDLPLF(FNACBPJKCJM NKJDMJIDCOG, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7EF0", Offset = "0x7DC70F0", VA = "0x187DC7EF0")]
	[AsyncStateMachine(typeof(KFCBEDCDING))]
	private Task<AHCJONDEEIE> IGDMFHIAMPN(FNACBPJKCJM NKJDMJIDCOG, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7A50", Offset = "0x7DC6C50", VA = "0x187DC7A50")]
	[AsyncStateMachine(typeof(EDLPLPLIFCB))]
	private Task GECJGCECPBA(FNACBPJKCJM NKJDMJIDCOG, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7DB0", Offset = "0x7DC6FB0", VA = "0x187DC7DB0")]
	[AsyncStateMachine(typeof(KNIJAMIACIM))]
	private Task IBHKNGCLICP(FNACBPJKCJM NKJDMJIDCOG, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken JIAENKIFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7600", Offset = "0x7DC6800", VA = "0x187DC7600")]
	[AsyncStateMachine(typeof(HOAJFNEINLN))]
	private Task COGIKOKDEDH(JCDLFPMDPEJ KICEIMPLAOD, MLLBPDODABK HMHINPDLFIF, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken EDHLNBFHJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC73A0", Offset = "0x7DC65A0", VA = "0x187DC73A0")]
	[AsyncStateMachine(typeof(LJKBPOFMJPI))]
	private Task AJKFBIEAEKD(AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7900", Offset = "0x7DC6B00", VA = "0x187DC7900")]
	[AsyncStateMachine(typeof(DJAHONBAANL))]
	private Task EJFJFLBMICC(JCDLFPMDPEJ LJELDKAOCJM, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7780", Offset = "0x7DC6980", VA = "0x187DC7780")]
	[AsyncStateMachine(typeof(PJDPEDCIICO))]
	private Task<DEMHAFNOBAG> DJLHEOOAPIG(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC80A0", Offset = "0x7DC72A0", VA = "0x187DC80A0")]
	[AsyncStateMachine(typeof(PLOHACKMLEE))]
	private Task<DEMHAFNOBAG> LAMBLJICNFB(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC84E0", Offset = "0x7DC76E0", VA = "0x187DC84E0")]
	[AsyncStateMachine(typeof(GLIPIMJJJJF))]
	private Task<DEMHAFNOBAG> MMOHMMNJNNI(DEMHAFNOBAG AIPFAFCAAFC, JCDLFPMDPEJ BFCCKAKKEGJ, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ, bool CIAMINEGGBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7DC86F0", Offset = "0x7DC78F0", VA = "0x187DC86F0")]
	private bool OAFPADNGDLJ(JCDLFPMDPEJ KICEIMPLAOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8D80", Offset = "0x7DC7F80", VA = "0x187DC8D80")]
	[AsyncStateMachine(typeof(HLHFKKMKGCN))]
	protected Task<DEMHAFNOBAG> PILAGIGHOME(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ, EKPEFHHBKCA OIFBNBOODOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7DC74B0", Offset = "0x7DC66B0", VA = "0x187DC74B0")]
	[AsyncStateMachine(typeof(CFNECLLDEJK))]
	private Task APMAPPGHBGK(JCDLFPMDPEJ LJELDKAOCJM, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7350", Offset = "0x7DC6550", VA = "0x187DC7350")]
	private void AFJGFIBAFJE(DEMHAFNOBAG JNIABMKEGDF, MLLBPDODABK AJMKPOADDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8660", Offset = "0x7DC7860", VA = "0x187DC8660")]
	private void NGELLOLOKOJ(DEMHAFNOBAG PKHGALAFKAB, [Out] DEMHAFNOBAG AAPEMAMGJKI, [Out] DEMHAFNOBAG LAMBOCKBHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8AB0", Offset = "0x7DC7CB0", VA = "0x187DC8AB0")]
	private Task<NGBKEMJECHJ> OJHLJLEEPAN(FNACBPJKCJM NKJDMJIDCOG, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8220", Offset = "0x7DC7420", VA = "0x187DC8220")]
	private Task<JCDLFPMDPEJ> LHOKFFMODCK(NGBKEMJECHJ LJELDKAOCJM, AJLCGOBAEIE.DLKLBEFPKOI HIMBCBBDNEJ, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7BB0", Offset = "0x7DC6DB0", VA = "0x187DC7BB0")]
	[AsyncStateMachine(typeof(PJCJBLLEABM))]
	private Task HCPDNPMBIIC(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ, bool CIMHBMDOHKB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7DC83F0", Offset = "0x7DC75F0", VA = "0x187DC83F0")]
	[AsyncStateMachine(typeof(LAGIOGCFOKN))]
	private Task MKJCINONMHJ(JCDLFPMDPEJ LJELDKAOCJM, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7750", Offset = "0x7DC6950", VA = "0x187DC7750")]
	private Task DFHINCENAFK(JCDLFPMDPEJ LJELDKAOCJM, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8080", Offset = "0x7DC7280", VA = "0x187DC8080")]
	private Task KOFCBBMCPKC(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC78E0", Offset = "0x7DC6AE0", VA = "0x187DC78E0")]
	private Task DOLJNHNDNIO(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8060", Offset = "0x7DC7260", VA = "0x187DC8060")]
	private Task KNDCONOFAHA(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8050", Offset = "0x7DC7250", VA = "0x187DC8050")]
	private static Task JPGGKBFAHNP(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8AF0", Offset = "0x7DC7CF0", VA = "0x187DC8AF0")]
	private Task OLPJAJAJJON(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7B90", Offset = "0x7DC6D90", VA = "0x187DC7B90")]
	private Task HBOJEPHODLK(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x7DC86A0", Offset = "0x7DC78A0", VA = "0x187DC86A0")]
	private void NIKLLENDNAI(FNACBPJKCJM NKJDMJIDCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7D00", Offset = "0x7DC6F00", VA = "0x187DC7D00")]
	public void HHHFJFIHCKM(long AKDHEFBHHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private static void CFLDKCDMCJB(AELLMCLLHFN ADEJBLKPJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8280", Offset = "0x7DC7480", VA = "0x187DC8280")]
	[AsyncStateMachine(typeof(GFLFDDKDGJC))]
	private Task MABOCJNEOGH(JCDLFPMDPEJ KICEIMPLAOD, MLLBPDODABK HMHINPDLFIF, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken EDHLNBFHJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8940", Offset = "0x7DC7B40", VA = "0x187DC8940")]
	[AsyncStateMachine(typeof(DNFHAIJAMNK))]
	private Task OEPJLACJKBI(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8C60", Offset = "0x7DC7E60", VA = "0x187DC8C60")]
	private static MLMGHINDMEL OPFIMDCGAMB(JCDLFPMDPEJ BFCCKAKKEGJ)
	{
		return default(MLMGHINDMEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x7DC87E0", Offset = "0x7DC79E0", VA = "0x187DC87E0")]
	[AsyncStateMachine(typeof(NPLJJPELHCG))]
	private Task<DEMHAFNOBAG> OBMHOAJMPJG(JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, MLLBPDODABK AJMKPOADDFB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private void KCFAEBHHBIK(DEMHAFNOBAG IAPPDNMMNOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct KHBIFPPAMAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private JCDLFPMDPEJ LJELDKAOCJM;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1E20", Offset = "0x7DF1020", VA = "0x187DF1E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1B30", Offset = "0x7DF0D30", VA = "0x187DF1B30")]
	public static Task IDKCINHHAJH(OKOJPAHMDCL FAFBKMPEOID, JCDLFPMDPEJ LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1C10", Offset = "0x7DF0E10", VA = "0x187DF1C10")]
	private void IDKCINHHAJH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct DOFCFFDBMJA
{
	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6660", Offset = "0x7DE5860", VA = "0x187DE6660")]
	public static Task IDKCINHHAJH(CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct AHEHKMLHNKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct EGKDJJCLBKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6740", Offset = "0x7DE5940", VA = "0x187DE6740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE6C70", Offset = "0x7DE5E70", VA = "0x187DE6C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2480", Offset = "0x7DE1680", VA = "0x187DE2480")]
	[AsyncStateMachine(typeof(EGKDJJCLBKO))]
	public static Task IDKCINHHAJH(FCDEPCDPKFP FHKOAHJMJDD, JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct EGPIPHBAOMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct OAIAKMKJBEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public IOCODLMNLCD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private OKOJPAHMDCL <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private MGJHPJBBLPE <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private DEMHAFNOBAG <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private IFOOKNGMDBJ <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private List<(PersistenceView, KAGCABDCBHB)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private KAGCABDCBHB <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6470", Offset = "0x7DF5670", VA = "0x187DF6470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7140", Offset = "0x7DF6340", VA = "0x187DF7140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6CD0", Offset = "0x7DE5ED0", VA = "0x187DE6CD0")]
	[AsyncStateMachine(typeof(OAIAKMKJBEP))]
	public static Task IDKCINHHAJH(FCDEPCDPKFP FHKOAHJMJDD, JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7DE6E20", Offset = "0x7DE6020", VA = "0x187DE6E20")]
	private static void LFKMAOMNENE(PersistenceView JEEIAMNAPAO, KAGCABDCBHB CPOBHMMPOAL, JCDLFPMDPEJ LJELDKAOCJM, DEMHAFNOBAG AIPFAFCAAFC, bool NLFDACGFLLF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct EKMJNDHIGOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct CHJJLLJJOAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public OKOJPAHMDCL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private IFOOKNGMDBJ <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DE47A0", Offset = "0x7DE39A0", VA = "0x187DE47A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4DC0", Offset = "0x7DE3FC0", VA = "0x187DE4DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7010", Offset = "0x7DE6210", VA = "0x187DE7010")]
	[AsyncStateMachine(typeof(CHJJLLJJOAK))]
	public static Task IDKCINHHAJH(OKOJPAHMDCL FAFBKMPEOID, JCDLFPMDPEJ LJELDKAOCJM, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct MCIDHCBKNOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct MFJNNOLIDPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public OKOJPAHMDCL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3A30", Offset = "0x7DF2C30", VA = "0x187DF3A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3C40", Offset = "0x7DF2E40", VA = "0x187DF3C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class DJNBKDGJPEF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000161")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public DJNBKDGJPEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x7DFB620", Offset = "0x7DFA820", VA = "0x187DFB620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x7DFB9B0", Offset = "0x7DFABB0", VA = "0x187DFB9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DJNBKDGJPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DE60E0", Offset = "0x7DE52E0", VA = "0x187DE60E0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task OLJPJPPNMBJ(AGOOCHPPHOP<string>.ABBPACGFNKJ timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct ICOEOKLEPEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public MCIDHCBKNOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private IFOOKNGMDBJ <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDE90", Offset = "0x7DED090", VA = "0x187DEDE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEA90", Offset = "0x7DEDC90", VA = "0x187DEEA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class JMMMPFNAJLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public EGINAFIELCE version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JMMMPFNAJLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0A40", Offset = "0x7DEFC40", VA = "0x187DF0A40")]
		internal object LMJKGEBLNHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0990", Offset = "0x7DEFB90", VA = "0x187DF0990")]
		internal object JNPFACGJJAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private JCDLFPMDPEJ LJELDKAOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private FCDEPCDPKFP FHKOAHJMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool CIMHBMDOHKB;

	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private static readonly ByteString LKGLMANDPEK;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3870", Offset = "0x7DF2A70", VA = "0x187DF3870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private IHCEMGMGPLM LOHOBHBGIED
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF38C0", Offset = "0x7DF2AC0", VA = "0x187DF38C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3720", Offset = "0x7DF2920", VA = "0x187DF3720")]
	[AsyncStateMachine(typeof(MFJNNOLIDPO))]
	public static Task IDKCINHHAJH(OKOJPAHMDCL FAFBKMPEOID, JCDLFPMDPEJ LJELDKAOCJM, FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ, bool CIMHBMDOHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF35F0", Offset = "0x7DF27F0", VA = "0x187DF35F0")]
	[AsyncStateMachine(typeof(ICOEOKLEPEN))]
	private Task IDKCINHHAJH(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2E20", Offset = "0x7DF2020", VA = "0x187DF2E20")]
	private void EAMMFHEENGP([NotNull] HKFACLJBOKN IGEGFGAAILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DF3960", Offset = "0x7DF2B60", VA = "0x187DF3960")]
	private bool NHIAEOBLMDL(EGINAFIELCE LCLBPLEFKON, HKFACLJBOKN IGEGFGAAILO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct NNBLAFMKDDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct BJFANDOKDNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<JCDLFPMDPEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public NNBLAFMKDDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public AJLCGOBAEIE.DLKLBEFPKOI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<IReadOnlyCollection<KLOJHPLIIPH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter<(CPEANPEHCAG<EPLJHAOMIIN, ILEHMOEGHGD>, CPEANPEHCAG<KPOLCABDGNG<HKFACLJBOKN>, ILEHMOEGHGD>, CPEANPEHCAG<KPOLCABDGNG<LAJHLLHOHBL>, ILEHMOEGHGD>, CPEANPEHCAG<KPOLCABDGNG<IEnumerable<LBDMABPMNIA>>, ILEHMOEGHGD>, CPEANPEHCAG<KPOLCABDGNG<FKCHFKNPPJJ>, ILEHMOEGHGD>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3010", Offset = "0x7DE2210", VA = "0x187DE3010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3DF0", Offset = "0x7DE2FF0", VA = "0x187DE3DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct BFJEKKHKBIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<EPLJHAOMIIN, ILEHMOEGHGD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public NNBLAFMKDDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public IReadOnlyCollection<KLOJHPLIIPH> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public IReadOnlyCollection<KLOJHPLIIPH> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AJLCGOBAEIE.DLKLBEFPKOI downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter<CPEANPEHCAG<EPLJHAOMIIN, ILEHMOEGHGD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2950", Offset = "0x7DE1B50", VA = "0x187DE2950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2FA0", Offset = "0x7DE21A0", VA = "0x187DE2FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private KAHLHCJAPFH<MMBNINEADFK, LAJHLLHOHBL> OCDHINLBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private KAHLHCJAPFH<MMBNINEADFK, HKFACLJBOKN> KFJKFKMAJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private KAHLHCJAPFH<NLGNBINCOCE, IEnumerable<LBDMABPMNIA>> NGCBGAIMJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private KAHLHCJAPFH<long, FKCHFKNPPJJ> GEDMNNIGFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private DPDPBNNNMLI CKAEBGIDNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private AELLMCLLHFN ADEJBLKPJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private BJLNPLMLHJE PFBFPPDKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private Guid? BKFAPPIPDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private IReadOnlyCollection<KLOJHPLIIPH> NKAKEDIAPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private Task<IReadOnlyCollection<KLOJHPLIIPH>> FNDOCPOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private MMBNINEADFK EMKKMOEAANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private MMBNINEADFK HEELDKPGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private MMBNINEADFK? IPPCJMDJAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private NLGNBINCOCE MJFAKOIHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI;

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF55F0", Offset = "0x7DF47F0", VA = "0x187DF55F0")]
	public static Task<JCDLFPMDPEJ> FOOKAEEAJOK(OKOJPAHMDCL FAFBKMPEOID, [In] NGBKEMJECHJ LJELDKAOCJM, AJLCGOBAEIE.DLKLBEFPKOI HIMBCBBDNEJ, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x7DF5AF0", Offset = "0x7DF4CF0", VA = "0x187DF5AF0")]
	[AsyncStateMachine(typeof(BJFANDOKDNB))]
	private Task<JCDLFPMDPEJ> IDKCINHHAJH(AJLCGOBAEIE.DLKLBEFPKOI HIMBCBBDNEJ, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DF53C0", Offset = "0x7DF45C0", VA = "0x187DF53C0")]
	[AsyncStateMachine(typeof(BFJEKKHKBIF))]
	private Task<CPEANPEHCAG<EPLJHAOMIIN, ILEHMOEGHGD>> EAHKPLEMHNF(Guid? BKFAPPIPDIN, IReadOnlyCollection<KLOJHPLIIPH> NKAKEDIAPHJ, IReadOnlyCollection<KLOJHPLIIPH> MBPADGIAHMB, long? KCAAOMDKNIH, long? NFFPLNPCCNI, AJLCGOBAEIE.DLKLBEFPKOI HIMBCBBDNEJ, AGOOCHPPHOP<string>.ABBPACGFNKJ JLHGKEBFDPN, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct CPJNPKAAKAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct JBHNMHEHPPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AsyncTaskMethodBuilder<NGBKEMJECHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CPJNPKAAKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<NGBKEMJECHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEDE0", Offset = "0x7DEDFE0", VA = "0x187DEEDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DEF230", Offset = "0x7DEE430", VA = "0x187DEF230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct GJGJLOPBBDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<NGBKEMJECHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public CPJNPKAAKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<NGBKEMJECHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB2A0", Offset = "0x7DEA4A0", VA = "0x187DEB2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB720", Offset = "0x7DEA920", VA = "0x187DEB720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class CLHHJAONCHG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			public CLHHJAONCHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			private TaskAwaiter<KPKMHPKPMHN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			private TaskAwaiter<DFMNJLHLEJJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x7DF9730", Offset = "0x7DF8930", VA = "0x187DF9730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x7DFA0E0", Offset = "0x7DF92E0", VA = "0x187DFA0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public EKPCAHHLKFA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public MGJHPJBBLPE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public MMBNINEADFK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public MMBNINEADFK subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public IReadOnlyList<KLOJHPLIIPH> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public IReadOnlyList<KLOJHPLIIPH> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public AELLMCLLHFN roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CLHHJAONCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xD632F0", Offset = "0xD624F0", VA = "0x180D632F0")]
		internal bool GPPNKLMFKNF(BJLNPLMLHJE sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4EA0", Offset = "0x7DE40A0", VA = "0x187DE4EA0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task GCDEOEEMEPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4F70", Offset = "0x7DE4170", VA = "0x187DE4F70")]
		internal Task<NLGNBINCOCE> HMFJIJLMOHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct FEEDKHAADBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public AsyncTaskMethodBuilder<NGBKEMJECHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public EKPCAHHLKFA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public MGJHPJBBLPE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public MMBNINEADFK superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private CLHHJAONCHG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private BJLNPLMLHJE <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private Task<NLGNBINCOCE> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private TaskAwaiter<AELLMCLLHFN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private TaskAwaiter<NLGNBINCOCE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8750", Offset = "0x7DE7950", VA = "0x187DE8750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9870", Offset = "0x7DE8A70", VA = "0x187DE9870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IBKCJDIIGLE GDKELIHNJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private EKPCAHHLKFA DIJGKECAJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private long KCAAOMDKNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private long HPHKCHODKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private long KABHILPEPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private string GKPPNHGGCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private MMBNINEADFK BEGHDJAEPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private Guid BLNHDBDBKAN;

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DE50E0", Offset = "0x7DE42E0", VA = "0x187DE50E0")]
	public static Task<NGBKEMJECHJ> FOOKAEEAJOK(OKOJPAHMDCL FAFBKMPEOID, FNACBPJKCJM NKJDMJIDCOG, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5330", Offset = "0x7DE4530", VA = "0x187DE5330")]
	[AsyncStateMachine(typeof(JBHNMHEHPPM))]
	private Task<NGBKEMJECHJ> IDKCINHHAJH(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x7DE54B0", Offset = "0x7DE46B0", VA = "0x187DE54B0")]
	[AsyncStateMachine(typeof(GJGJLOPBBDG))]
	private Task<NGBKEMJECHJ> OJHLJLEEPAN(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5620", Offset = "0x7DE4820", VA = "0x187DE5620")]
	[AsyncStateMachine(typeof(FEEDKHAADBC))]
	private static Task<NGBKEMJECHJ> OJHLJLEEPAN(MGJHPJBBLPE EKJOCLHFECK, EKPCAHHLKFA DIJGKECAJAJ, long KCAAOMDKNIH, long HPHKCHODKPD, long KABHILPEPNB, string GKPPNHGGCHI, MMBNINEADFK BEGHDJAEPLN, Guid BLNHDBDBKAN, CancellationToken KPIINMODKFJ, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5480", Offset = "0x7DE4680", VA = "0x187DE5480")]
	private void OAIEEJILOAC(AELLMCLLHFN ADEJBLKPJCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal struct JJKBIADGCLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct HKNCOPMDLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public JJKBIADGCLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x7DED1D0", Offset = "0x7DEC3D0", VA = "0x187DED1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7DED760", Offset = "0x7DEC960", VA = "0x187DED760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private JCDLFPMDPEJ LJELDKAOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private float HACPLFFGEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private float ODECHHNLIMC;

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF5B0", Offset = "0x7DEE7B0", VA = "0x187DEF5B0")]
	public static Task IGHGANHCNNH(OKOJPAHMDCL FAFBKMPEOID, JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF490", Offset = "0x7DEE690", VA = "0x187DEF490")]
	[AsyncStateMachine(typeof(HKNCOPMDLIG))]
	public Task IDKCINHHAJH(CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF360", Offset = "0x7DEE560", VA = "0x187DEF360")]
	private static void DLBGEAGKIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF770", Offset = "0x7DEE970", VA = "0x187DEF770")]
	private void LNEEMAJNJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF2A0", Offset = "0x7DEE4A0", VA = "0x187DEF2A0")]
	private static float CMGFDMMIMJC(MGJHPJBBLPE EKJOCLHFECK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF750", Offset = "0x7DEE950", VA = "0x187DEF750")]
	private static float KHKCOIGOIEC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct IHPIDPNMKKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct NLLCPDLLHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public FCDEPCDPKFP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private MBCPBGIAHHB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private OKOJPAHMDCL <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private JKPCLMJDCII.CMOKHODPJED <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4B40", Offset = "0x7DF3D40", VA = "0x187DF4B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5360", Offset = "0x7DF4560", VA = "0x187DF5360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct CFLBFFLHOIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3E60", Offset = "0x7DE3060", VA = "0x187DE3E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4190", Offset = "0x7DE3390", VA = "0x187DE4190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x7DEEBE0", Offset = "0x7DEDDE0", VA = "0x187DEEBE0")]
	[AsyncStateMachine(typeof(NLLCPDLLHNG))]
	public static Task IDKCINHHAJH(FCDEPCDPKFP FHKOAHJMJDD, JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x7DEEB70", Offset = "0x7DEDD70", VA = "0x187DEEB70")]
	private static Task<AHCJONDEEIE> FEOIPIPJJKB(FCDEPCDPKFP FHKOAHJMJDD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEED20", Offset = "0x7DEDF20", VA = "0x187DEED20")]
	[AsyncStateMachine(typeof(CFLBFFLHOIB))]
	private static Task MEGHDCDHKHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct NJFKHIFDGKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct FDFPNNJIMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public NJFKHIFDGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7DE8040", Offset = "0x7DE7240", VA = "0x187DE8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7DE86F0", Offset = "0x7DE78F0", VA = "0x187DE86F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class CKDNDPIPGJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CKDNDPIPGJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x7DE4E20", Offset = "0x7DE4020", VA = "0x187DE4E20")]
		internal object DAJOKDNEEBG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct FMINAFHDGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public NJFKHIFDGKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7DE98E0", Offset = "0x7DE8AE0", VA = "0x187DE98E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE9D60", Offset = "0x7DE8F60", VA = "0x187DE9D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private bool FLLAPJJHLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private CancellationToken KPIINMODKFJ;

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x7DF4970", Offset = "0x7DF3B70", VA = "0x187DF4970")]
	public static Task PIGOKJKJJAF(OKOJPAHMDCL FAFBKMPEOID, bool FLLAPJJHLPM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken ALDCJBEHBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x7DF4750", Offset = "0x7DF3950", VA = "0x187DF4750")]
	[AsyncStateMachine(typeof(FDFPNNJIMLI))]
	private Task IDKCINHHAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x7DF4840", Offset = "0x7DF3A40", VA = "0x187DF4840")]
	[AsyncStateMachine(typeof(FMINAFHDGIJ))]
	private Task JGKKFLMKHMD(bool MJALFHIMEFL, string KHFLPBDLHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
	private bool BPDIFNOENML(bool FLLAPJJHLPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct NFNPEAHIDFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct JPGHAPBNDIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public NFNPEAHIDFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0B20", Offset = "0x7DEFD20", VA = "0x187DF0B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1090", Offset = "0x7DF0290", VA = "0x187DF1090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class DHMECAPMHJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DHMECAPMHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x7DE57F0", Offset = "0x7DE49F0", VA = "0x187DE57F0")]
		internal object DAJOKDNEEBG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct LDFHGMJILAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public NFNPEAHIDFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x7DF20F0", Offset = "0x7DF12F0", VA = "0x187DF20F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2570", Offset = "0x7DF1770", VA = "0x187DF2570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private PACOPEIJNCH KBNABDLEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private bool HONMEJJIONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private JCDLFPMDPEJ LJELDKAOCJM;

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x7DF43F0", Offset = "0x7DF35F0", VA = "0x187DF43F0")]
	public static Task<Scene> FCKIGBFBHEN(OKOJPAHMDCL FAFBKMPEOID, PACOPEIJNCH HJJDNPAJBJA, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x7DF4470", Offset = "0x7DF3670", VA = "0x187DF4470")]
	[AsyncStateMachine(typeof(JPGHAPBNDIL))]
	private Task<Scene> IDKCINHHAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF43C0", Offset = "0x7DF35C0", VA = "0x187DF43C0")]
	private bool ELHFIHPBKPD(JCDLFPMDPEJ LJELDKAOCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF46E0", Offset = "0x7DF38E0", VA = "0x187DF46E0")]
	private void OGIPGOBLKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x7DF4590", Offset = "0x7DF3790", VA = "0x187DF4590")]
	[AsyncStateMachine(typeof(LDFHGMJILAI))]
	private Task<Scene> JGKKFLMKHMD(string KHFLPBDLHLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct AIKDHCLNJEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct HFMPGKLKBLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public AIKDHCLNJEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public DEMHAFNOBAG nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public JCDLFPMDPEJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<DEMHAFNOBAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7DEBA50", Offset = "0x7DEAC50", VA = "0x187DEBA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC520", Offset = "0x7DEB720", VA = "0x187DEC520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct HHDDGHOPDHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public AsyncTaskMethodBuilder<DEMHAFNOBAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public AIKDHCLNJEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public DEMHAFNOBAG state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC6B0", Offset = "0x7DEB8B0", VA = "0x187DEC6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC990", Offset = "0x7DEBB90", VA = "0x187DEC990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private readonly FCDEPCDPKFP FHKOAHJMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private readonly IBKCJDIIGLE GDKELIHNJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private readonly FBEOLNFJCBK KGCPCICFPMF;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private MBCPBGIAHHB CHLNKEOONOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6316180", Offset = "0x6315380", VA = "0x186316180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7DE28F0", Offset = "0x7DE1AF0", VA = "0x187DE28F0")]
	public AIKDHCLNJEL(FCDEPCDPKFP FHKOAHJMJDD, IBKCJDIIGLE GDKELIHNJLK, FBEOLNFJCBK KGCPCICFPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7DE25F0", Offset = "0x7DE17F0", VA = "0x187DE25F0")]
	[AsyncStateMachine(typeof(HFMPGKLKBLG))]
	public Task<DEMHAFNOBAG> GJLBNIONOMM(DEMHAFNOBAG ENENANMFNHF, JCDLFPMDPEJ BFCCKAKKEGJ, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ, bool CIAMINEGGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2790", Offset = "0x7DE1990", VA = "0x187DE2790")]
	[AsyncStateMachine(typeof(HHDDGHOPDHP))]
	private Task<DEMHAFNOBAG> MEIHKIBENMK(AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, DEMHAFNOBAG LEOMHHEDCFC, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE25C0", Offset = "0x7DE17C0", VA = "0x187DE25C0")]
	private bool CGNCKDNGOLL(DEMHAFNOBAG DDDFJBHDIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2770", Offset = "0x7DE1970", VA = "0x187DE2770")]
	private void IPKFDHIOJFD(string MMKAMPGMPIO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct HLNMGPGMFMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct NCCAIGFHAII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public MBCPBGIAHHB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public IOCODLMNLCD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private IFOOKNGMDBJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private List<(PersistenceView, KAGCABDCBHB)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private (PersistenceView, KAGCABDCBHB) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3CA0", Offset = "0x7DF2EA0", VA = "0x187DF3CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4360", Offset = "0x7DF3560", VA = "0x187DF4360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x7DEDD50", Offset = "0x7DECF50", VA = "0x187DEDD50")]
	[AsyncStateMachine(typeof(NCCAIGFHAII))]
	public static Task IDKCINHHAJH(MBCPBGIAHHB BHEFDPAMAKP, JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct OAGECPLCHEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct KBKICJKKMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public MBCPBGIAHHB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public IOCODLMNLCD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private EGINAFIELCE <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private IFOOKNGMDBJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private List<(PersistenceView, KAGCABDCBHB)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private KAGCABDCBHB <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1100", Offset = "0x7DF0300", VA = "0x187DF1100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x7DF19E0", Offset = "0x7DF0BE0", VA = "0x187DF19E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6330", Offset = "0x7DF5530", VA = "0x187DF6330")]
	[AsyncStateMachine(typeof(KBKICJKKMGB))]
	public static Task IDKCINHHAJH(MBCPBGIAHHB BHEFDPAMAKP, JCDLFPMDPEJ LJELDKAOCJM, IOCODLMNLCD ABCBNJCHKAB, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct JKPCLMJDCII
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public struct CMOKHODPJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public List<LFFBJMMABAE> JOCPMDJEIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public List<KAGCABDCBHB> BANEDCAILHJ;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
		public CMOKHODPJED(List<LFFBJMMABAE> JOCPMDJEIMC, List<KAGCABDCBHB> BANEDCAILHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class IFLIBPMDABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public IEnumerable<LFFBJMMABAE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IFLIBPMDABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEAF0", Offset = "0x7DEDCF0", VA = "0x187DEEAF0")]
		internal object FHDKJOGBDLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private OKOJPAHMDCL FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private JCDLFPMDPEJ LJELDKAOCJM;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private MGJHPJBBLPE GMCBKFOCPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0300", Offset = "0x7DEF500", VA = "0x187DF0300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7DF00D0", Offset = "0x7DEF2D0", VA = "0x187DF00D0")]
	public static CMOKHODPJED IDKCINHHAJH(OKOJPAHMDCL FAFBKMPEOID, JCDLFPMDPEJ LJELDKAOCJM)
	{
		return default(CMOKHODPJED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7DEFE80", Offset = "0x7DEF080", VA = "0x187DEFE80")]
	private CMOKHODPJED IDKCINHHAJH()
	{
		return default(CMOKHODPJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x7DEF8D0", Offset = "0x7DEEAD0", VA = "0x187DEF8D0")]
	private CMOKHODPJED APIKIPLLEIM(HKFACLJBOKN IGEGFGAAILO, EGINAFIELCE GHLNCENHFDM)
	{
		return default(CMOKHODPJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0130", Offset = "0x7DEF330", VA = "0x187DF0130")]
	private bool LHNFGLKOBJD(IEnumerable<LFFBJMMABAE> JOCPMDJEIMC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal struct GJFLDCAGMIB
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class JLOJHEFNJJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public JKPCLMJDCII.CMOKHODPJED instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JLOJHEFNJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7DF08E0", Offset = "0x7DEFAE0", VA = "0x187DF08E0")]
		internal object OLJPJPPNMBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class PHCPNHBEDJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PHCPNHBEDJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7DF71A0", Offset = "0x7DF63A0", VA = "0x187DF71A0")]
		internal object POKMOEKPEDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7DEACF0", Offset = "0x7DE9EF0", VA = "0x187DEACF0")]
	public static void IDKCINHHAJH(MBCPBGIAHHB BHEFDPAMAKP, JCDLFPMDPEJ LJELDKAOCJM, JKPCLMJDCII.CMOKHODPJED JODHLJBLOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal class FBEOLNFJCBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct HJFEIDELICI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public DEMHAFNOBAG operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public JCDLFPMDPEJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7DECA00", Offset = "0x7DEBC00", VA = "0x187DECA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7DED170", Offset = "0x7DEC370", VA = "0x187DED170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class KBMHAPNFKPO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018B")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D6")]
			public KBMHAPNFKPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x7DFB300", Offset = "0x7DFA500", VA = "0x187DFB300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x7DFB5C0", Offset = "0x7DFA7C0", VA = "0x187DFB5C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KBMHAPNFKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1A40", Offset = "0x7DF0C40", VA = "0x187DF1A40")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task EGDFHJJJMKD(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private struct JLFIGIKECPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private KBMHAPNFKPO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0350", Offset = "0x7DEF550", VA = "0x187DF0350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0880", Offset = "0x7DEFA80", VA = "0x187DF0880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct AGLIJJDCKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<Guid, List<DIINLENPKHL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFBCB0", Offset = "0x7DFAEB0", VA = "0x187DFBCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC2C0", Offset = "0x7DFB4C0", VA = "0x187DFC2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct NDCLGJDDOFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private Dictionary<Guid, List<DIINLENPKHL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7E08540", Offset = "0x7E07740", VA = "0x187E08540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x7E08BD0", Offset = "0x7E07DD0", VA = "0x187E08BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class AKNPIDHEMGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public DIINLENPKHL handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public AKNPIDHEMGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			private IFOOKNGMDBJ <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x7E0A7B0", Offset = "0x7E099B0", VA = "0x187E0A7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AC10", Offset = "0x7E09E10", VA = "0x187E0AC10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public ABHLCNLMEJH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public List<DIINLENPKHL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AKNPIDHEMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD100", Offset = "0x7DFC300", VA = "0x187DFD100")]
		internal object MMBIDHIOBKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF10", Offset = "0x7DFC110", VA = "0x187DFCF10")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task ACGJDJAOOAH(DIINLENPKHL handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD010", Offset = "0x7DFC210", VA = "0x187DFD010")]
		internal object ICIGLIICEDB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct LGFGCKAMCMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public ABHLCNLMEJH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public List<DIINLENPKHL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private AKNPIDHEMGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x7E07220", Offset = "0x7E06420", VA = "0x187E07220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x7E076F0", Offset = "0x7E068F0", VA = "0x187E076F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct HDKMLNFEJCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x7E00970", Offset = "0x7DFFB70", VA = "0x187E00970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x7E00C60", Offset = "0x7DFFE60", VA = "0x187E00C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class HBCIHFFPMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HBCIHFFPMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x7E00900", Offset = "0x7DFFB00", VA = "0x187E00900")]
		internal object NCCEAKEMNFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private struct FLOOGDHNCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public JCDLFPMDPEJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x7E00370", Offset = "0x7DFF570", VA = "0x187E00370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x7E00820", Offset = "0x7DFFA20", VA = "0x187E00820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class KLKJLBDPBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KLKJLBDPBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7E05880", Offset = "0x7E04A80", VA = "0x187E05880")]
		internal object BAPKOHCECIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct ICNAJOGINLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public FBEOLNFJCBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private IFOOKNGMDBJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x7E01890", Offset = "0x7E00A90", VA = "0x187E01890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7E01EC0", Offset = "0x7E010C0", VA = "0x187E01EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class CIPOKEIAAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CIPOKEIAAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEC80", Offset = "0x7DFDE80", VA = "0x187DFEC80")]
		internal object IGEMFMNBJAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private readonly FCDEPCDPKFP FHKOAHJMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private BFNOMMLALIO KGCPCICFPMF;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private MBCPBGIAHHB CHLNKEOONOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xF61290", Offset = "0xF60490", VA = "0x180F61290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public FBEOLNFJCBK(FCDEPCDPKFP FHKOAHJMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x7DE76E0", Offset = "0x7DE68E0", VA = "0x187DE76E0")]
	[AsyncStateMachine(typeof(HJFEIDELICI))]
	public Task IDKCINHHAJH(DEMHAFNOBAG AIPFAFCAAFC, JCDLFPMDPEJ BFCCKAKKEGJ, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x7DE75A0", Offset = "0x7DE67A0", VA = "0x187DE75A0")]
	[AsyncStateMachine(typeof(JLFIGIKECPE))]
	private Task FNEFDGJGCJD(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x7DE73B0", Offset = "0x7DE65B0", VA = "0x187DE73B0")]
	[AsyncStateMachine(typeof(AGLIJJDCKEA))]
	private Task CMDJODNPOIP(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7990", Offset = "0x7DE6B90", VA = "0x187DE7990")]
	[AsyncStateMachine(typeof(NDCLGJDDOFE))]
	private Task KGFAEFMFCEC(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7EF0", Offset = "0x7DE70F0", VA = "0x187DE7EF0")]
	[AsyncStateMachine(typeof(LGFGCKAMCMJ))]
	private Task PHANFBBNCGC(Guid GDDKDBKLGFN, List<DIINLENPKHL> NBEGIEHJKJO, ABHLCNLMEJH BEFICMOHJIJ, JCDLFPMDPEJ LJELDKAOCJM, CancellationToken GIIKHLJPAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7130", Offset = "0x7DE6330", VA = "0x187DE7130")]
	[AsyncStateMachine(typeof(HDKMLNFEJCN))]
	private Task BGOJHDPJLNE(JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7AD0", Offset = "0x7DE6CD0", VA = "0x187DE7AD0")]
	[AsyncStateMachine(typeof(FLOOGDHNCIL))]
	private Task MKJGFNLAKNA(Guid HLOPMGJDCBD, JCDLFPMDPEJ LJELDKAOCJM, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7270", Offset = "0x7DE6470", VA = "0x187DE7270")]
	[AsyncStateMachine(typeof(ICNAJOGINLJ))]
	private Task BJFCAIGJDJJ(Guid HLOPMGJDCBD, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7C10", Offset = "0x7DE6E10", VA = "0x187DE7C10")]
	private void MKPGCJEOLLN(Guid HLOPMGJDCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE74F0", Offset = "0x7DE66F0", VA = "0x187DE74F0")]
	private void EPAAJPMNMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7830", Offset = "0x7DE6A30", VA = "0x187DE7830")]
	public Guid JGEIDFJCKOO(DEMHAFNOBAG JNIABMKEGDF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7DE7D20", Offset = "0x7DE6F20", VA = "0x187DE7D20")]
	[CompilerGenerated]
	private object PAOKJIMHDON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal struct HFFGDIFCIMO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct HJFANBMBACE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public HFFGDIFCIMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private IEnumerator<AIKOBDJNFOG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x7E01190", Offset = "0x7E00390", VA = "0x187E01190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7E01830", Offset = "0x7E00A30", VA = "0x187E01830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private MGJHPJBBLPE EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private CancellationToken KPIINMODKFJ;

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7E00CC0", Offset = "0x7DFFEC0", VA = "0x187E00CC0")]
	public static Task FCFMGECONJJ(MGJHPJBBLPE EKJOCLHFECK, AGOOCHPPHOP<string>.ABBPACGFNKJ MLINJELIMFI, CancellationToken ALDCJBEHBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7E00D30", Offset = "0x7DFFF30", VA = "0x187E00D30")]
	[AsyncStateMachine(typeof(HJFANBMBACE))]
	private Task IDKCINHHAJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public readonly struct PFFHBCJMHCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly bool KFGCBGHEFMO;

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x27C0C30", Offset = "0x27BFE30", VA = "0x1827C0C30")]
	public PFFHBCJMHCN(bool HGOGLJCAJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public readonly struct OACJBLAPPIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly HKFACLJBOKN? KOMIBGEHILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	public readonly DOLMOJEFJCO GKBPFJALAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly Guid? EIGKBGFLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly IReadOnlyList<Guid> CEAMCDGHICP;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> NACLFILKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7E096F0", Offset = "0x7E088F0", VA = "0x187E096F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> LOFODBGGMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7E09710", Offset = "0x7E08910", VA = "0x187E09710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7E09730", Offset = "0x7E08930", VA = "0x187E09730")]
	public OACJBLAPPIE(HKFACLJBOKN? JEICPGHJIDH, DOLMOJEFJCO JANHNHJFJJD, Guid? BKFAPPIPDIN, [Optional] IReadOnlyList<Guid>? DKOBGPLAAAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class BCJBOEOHOBE : IMPIMBOILPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct LDLPCHGDNFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public AsyncTaskMethodBuilder<OACJBLAPPIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public BCJBOEOHOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public AAOJKBBEPMH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public LBFHGLMDMIM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private IFOOKNGMDBJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x7E06B10", Offset = "0x7E05D10", VA = "0x187E06B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x7E071B0", Offset = "0x7E063B0", VA = "0x187E071B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class KEBHIOBEFNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KEBHIOBEFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x7E03D40", Offset = "0x7E02F40", VA = "0x187E03D40")]
		internal object EBEDLOBBNHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct KKIBLKMLPEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public BCJBOEOHOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public AAOJKBBEPMH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private KEBHIOBEFNL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private IFOOKNGMDBJ <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private HKOOMBBGJCN<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x7E04D60", Offset = "0x7E03F60", VA = "0x187E04D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x7E05820", Offset = "0x7E04A20", VA = "0x187E05820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	private readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000735")]
	private static readonly TimeSpan FDJMGJPCGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private readonly EHFIJBJHBMC GFIGAMNDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private readonly FNIIDKGGCNI BLJDHIGCADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private readonly FGGJAJBLNFC JAFAFMOLKKI;

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE3A0", Offset = "0x7DFD5A0", VA = "0x187DFE3A0")]
	public BCJBOEOHOBE(FCDEPCDPKFP FHKOAHJMJDD, EHFIJBJHBMC GFIGAMNDHEJ, FNIIDKGGCNI DEOMNICEILN, FGGJAJBLNFC JAFAFMOLKKI, PBBCGFNIILA NPAEAIAJLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD440", Offset = "0x7DFC640", VA = "0x187DFD440")]
	[AsyncStateMachine(typeof(LDLPCHGDNFI))]
	public Task<OACJBLAPPIE> JEAAONFOJJH(long HPHKCHODKPD, LBFHGLMDMIM CKICEELPJDM, AAOJKBBEPMH NHLCNELBIHF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD750", Offset = "0x7DFC950", VA = "0x187DFD750")]
	[AsyncStateMachine(typeof(KKIBLKMLPEC))]
	private Task KBBOJJMPLID(AAOJKBBEPMH NHLCNELBIHF, PersistenceView[] ALAMLDPHMGI, StringBuilder COGAJIHPPKM, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDD20", Offset = "0x7DFCF20", VA = "0x187DFDD20")]
	private OACJBLAPPIE ODKOLFEKHAD(long HPHKCHODKPD, LBFHGLMDMIM CKICEELPJDM, AAOJKBBEPMH NHLCNELBIHF, IEnumerable<PersistenceView> ALAMLDPHMGI, StringBuilder COGAJIHPPKM)
	{
		return default(OACJBLAPPIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD590", Offset = "0x7DFC790", VA = "0x187DFD590")]
	private HKFACLJBOKN JOJEBBNCFHI(long HPHKCHODKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD1F0", Offset = "0x7DFC3F0", VA = "0x187DFD1F0")]
	private void HMLOOHPGBFN(HKFACLJBOKN IAHPDEBNPIK, StringBuilder COGAJIHPPKM, IEnumerable<PersistenceView> ALAMLDPHMGI, [In] BADNMFAKOPK FPNMJGKPFDH, HMDAMBJBOKL EFGLGCACOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD890", Offset = "0x7DFCA90", VA = "0x187DFD890")]
	private void LIKHHCAENOF(HKFACLJBOKN IAHPDEBNPIK, StringBuilder COGAJIHPPKM, PersistenceView JEEIAMNAPAO, HMDAMBJBOKL EFGLGCACOME, [In] BADNMFAKOPK FPNMJGKPFDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class AHAFMGCJPCC : IMPIMBOILPN
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class HGMNBHFOGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public JLLIDOHIODH.JKPAPCBAMGJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HGMNBHFOGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7E01140", Offset = "0x7E00340", VA = "0x187E01140")]
		internal object ABDKBLIIKBI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct DNPNIKKLBLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public AsyncTaskMethodBuilder<(JLLIDOHIODH.JKPAPCBAMGJ roomDataUpload, JLLIDOHIODH.JKPAPCBAMGJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public OACJBLAPPIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public MGJHPJBBLPE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private HGMNBHFOGJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		private TaskAwaiter<JLLIDOHIODH.JKPAPCBAMGJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEE20", Offset = "0x7DFE020", VA = "0x187DFEE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF670", Offset = "0x7DFE870", VA = "0x187DFF670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct CAGOBEJALLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public AsyncTaskMethodBuilder<FCICKLINDLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public AHAFMGCJPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public JKFKKPNMGNI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public OACJBLAPPIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private TaskAwaiter<FCICKLINDLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE8D0", Offset = "0x7DFDAD0", VA = "0x187DFE8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEB70", Offset = "0x7DFDD70", VA = "0x187DFEB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct KKDGJMIGBNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AsyncTaskMethodBuilder<FCICKLINDLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public MGJHPJBBLPE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public OACJBLAPPIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public HDLLJJHKEEK ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public JKFKKPNMGNI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private TaskAwaiter<(JLLIDOHIODH.JKPAPCBAMGJ roomDataUpload, JLLIDOHIODH.JKPAPCBAMGJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private TaskAwaiter<FCICKLINDLO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x7E04690", Offset = "0x7E03890", VA = "0x187E04690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x7E04CF0", Offset = "0x7E03EF0", VA = "0x187E04CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct EBGEJHOCKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public AsyncTaskMethodBuilder<KPKMHPKPMHN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public AHAFMGCJPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public OACJBLAPPIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private TaskAwaiter<(JLLIDOHIODH.JKPAPCBAMGJ roomDataUpload, JLLIDOHIODH.JKPAPCBAMGJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private TaskAwaiter<KPKMHPKPMHN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF6E0", Offset = "0x7DFE8E0", VA = "0x187DFF6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFB90", Offset = "0x7DFED90", VA = "0x187DFFB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class CNNGEGJHEGG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			public CNNGEGJHEGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			private AHCJONDEEIE <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			private TaskAwaiter<KPKMHPKPMHN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			private TaskAwaiter<FCICKLINDLO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			private TaskAwaiter<AHCJONDEEIE> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x7E0AC70", Offset = "0x7E09E70", VA = "0x187E0AC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x7E0BE70", Offset = "0x7E0B070", VA = "0x187E0BE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public AHAFMGCJPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public OACJBLAPPIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public JKFKKPNMGNI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public PFFHBCJMHCN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CNNGEGJHEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DFECF0", Offset = "0x7DFDEF0", VA = "0x187DFECF0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<AHCJONDEEIE> LOHJPPFCNKH(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct JBGFEHAELFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public AsyncTaskMethodBuilder<AHCJONDEEIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public AHAFMGCJPCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public OACJBLAPPIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public JKFKKPNMGNI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public PFFHBCJMHCN roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private TaskAwaiter<AHCJONDEEIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E03590", Offset = "0x7E02790", VA = "0x187E03590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E038C0", Offset = "0x7E02AC0", VA = "0x187E038C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private static readonly PBBCGFNIILA CFBMFDKKNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000754")]
	private readonly LFJJMFMMIKG DHGADAOGBND;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private OKOJPAHMDCL MENPKFFINBO
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8A80", Offset = "0x7DC7C80", VA = "0x187DC8A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCE80", Offset = "0x7DFC080", VA = "0x187DFCE80")]
	public AHAFMGCJPCC(FCDEPCDPKFP FHKOAHJMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCAF0", Offset = "0x7DFBCF0", VA = "0x187DFCAF0")]
	[AsyncStateMachine(typeof(DNPNIKKLBLI))]
	private static Task<(JLLIDOHIODH.JKPAPCBAMGJ, JLLIDOHIODH.JKPAPCBAMGJ)> BNDGDKALFOG(MGJHPJBBLPE EKJOCLHFECK, OACJBLAPPIE HAJPGAGBAGC, long KCAAOMDKNIH, long NFFPLNPCCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC630", Offset = "0x7DFB830", VA = "0x187DFC630")]
	[AsyncStateMachine(typeof(CAGOBEJALLC))]
	public Task<FCICKLINDLO> BEIJDMDEACM(int BLIGPFACMIG, [CanBeNull] JKFKKPNMGNI KPFKBHEJGDG, OACJBLAPPIE HAJPGAGBAGC, long KCAAOMDKNIH, long NFFPLNPCCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC7A0", Offset = "0x7DFB9A0", VA = "0x187DFC7A0")]
	public static Task<FCICKLINDLO> BEIJDMDEACM(MGJHPJBBLPE EKJOCLHFECK, int BLIGPFACMIG, [CanBeNull] JKFKKPNMGNI KPFKBHEJGDG, OACJBLAPPIE HAJPGAGBAGC, long KCAAOMDKNIH, long NFFPLNPCCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC4A0", Offset = "0x7DFB6A0", VA = "0x187DFC4A0")]
	[AsyncStateMachine(typeof(KKDGJMIGBNK))]
	public static Task<FCICKLINDLO> BEIJDMDEACM(MGJHPJBBLPE EKJOCLHFECK, int BLIGPFACMIG, [CanBeNull] JKFKKPNMGNI KPFKBHEJGDG, OACJBLAPPIE HAJPGAGBAGC, long KCAAOMDKNIH, long NFFPLNPCCNI, HDLLJJHKEEK KJPOOFOIDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC320", Offset = "0x7DFB520", VA = "0x187DFC320")]
	[AsyncStateMachine(typeof(EBGEJHOCKBG))]
	private Task<KPKMHPKPMHN> AJPBKEOBBAN(string GKPPNHGGCHI, int BLIGPFACMIG, OACJBLAPPIE HAJPGAGBAGC, long KCAAOMDKNIH, long NFFPLNPCCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCC40", Offset = "0x7DFBE40", VA = "0x187DFCC40")]
	[AsyncStateMachine(typeof(JBGFEHAELFD))]
	public Task<AHCJONDEEIE> OPFMOGOLEKI(int BLIGPFACMIG, JKFKKPNMGNI? KPFKBHEJGDG, OACJBLAPPIE HAJPGAGBAGC, long KCAAOMDKNIH, long NFFPLNPCCNI, PFFHBCJMHCN IDGCPBDFJAF, AGOOCHPPHOP<string>.ABBPACGFNKJ EOPDKBMKECF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public abstract class HLMAGHKOBKG<T> where T : HLMAGHKOBKG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079A")]
	internal readonly OKOJPAHMDCL ECGFKIOAKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079B")]
	private int? BLBKBDJAAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079C")]
	protected readonly Guid LGGPFCEDJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	protected readonly BKELAGLEEBH BFPAFBIPDBL;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T CIMMEKBPDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x46B6100", Offset = "0x46B5300", VA = "0x1846B6100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x46B6410", Offset = "0x46B5610", VA = "0x1846B6410")]
	internal HLMAGHKOBKG(OKOJPAHMDCL PFLPNLLKION, BKELAGLEEBH BGIMNFJPNPG, [Optional] Guid? LDHEJEOPGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x46B6200", Offset = "0x46B5400", VA = "0x1846B6200")]
	private AHCJONDEEIE KIHOCOJMJHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	protected virtual void NPJCHFPBLGP(AHCJONDEEIE DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x46B6160", Offset = "0x46B5360", VA = "0x1846B6160")]
	public T KBOBCGMHHLP(GJGNFGDHFCI CIGHHJOJKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x46B6060", Offset = "0x46B5260", VA = "0x1846B6060")]
	public T CGODJGHGFBJ(int JKKPAMKCALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x46B62E0", Offset = "0x46B54E0", VA = "0x1846B62E0", Slot = "5")]
	public virtual Task<KLKDBEPMPLI> KJPCPLNBPCM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public class ILGGHPDIBFD : HLMAGHKOBKG<ILGGHPDIBFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private FNACBPJKCJM FKKLLADNDBA;

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E021C0", Offset = "0x7E013C0", VA = "0x187E021C0")]
	internal ILGGHPDIBFD(OKOJPAHMDCL PFLPNLLKION, BKELAGLEEBH BGIMNFJPNPG, [Optional] Guid? LDHEJEOPGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x713B270", Offset = "0x713A470", VA = "0x18713B270")]
	public ILGGHPDIBFD NDJEJBKNDDO(FNACBPJKCJM FKKLLADNDBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E020F0", Offset = "0x7E012F0", VA = "0x187E020F0", Slot = "4")]
	protected override void NPJCHFPBLGP(AHCJONDEEIE DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class LKPENNDKMMF : HLMAGHKOBKG<LKPENNDKMMF>
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	internal enum HKPMFNDEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct JFFNOCDNJJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public AsyncTaskMethodBuilder<KLKDBEPMPLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public LKPENNDKMMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private TaskAwaiter<KLKDBEPMPLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E03930", Offset = "0x7E02B30", VA = "0x187E03930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E03CD0", Offset = "0x7E02ED0", VA = "0x187E03CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	private HKPMFNDEKPA CNIKHGDOMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	private string BNMKIGPPDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private JKFKKPNMGNI FKKLLADNDBA;

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E07A90", Offset = "0x7E06C90", VA = "0x187E07A90")]
	internal LKPENNDKMMF(OKOJPAHMDCL PFLPNLLKION, BKELAGLEEBH BGIMNFJPNPG, [Optional] Guid? LDHEJEOPGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E078A0", Offset = "0x7E06AA0", VA = "0x187E078A0")]
	public LKPENNDKMMF KNEKALCANPO(string BIGHOOCGPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E07790", Offset = "0x7E06990", VA = "0x187E07790")]
	public LKPENNDKMMF HAKHDJMGALG(bool BNELJMIBBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E078D0", Offset = "0x7E06AD0", VA = "0x187E078D0")]
	public LKPENNDKMMF LHHBJINDEDD(bool MILJCDJLBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E078F0", Offset = "0x7E06AF0", VA = "0x187E078F0")]
	public LKPENNDKMMF NMNGBPBOONE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E07920", Offset = "0x7E06B20", VA = "0x187E07920", Slot = "4")]
	protected override void NPJCHFPBLGP(AHCJONDEEIE DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E077B0", Offset = "0x7E069B0", VA = "0x187E077B0", Slot = "5")]
	[AsyncStateMachine(typeof(JFFNOCDNJJN))]
	public override Task<KLKDBEPMPLI> KJPCPLNBPCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E07750", Offset = "0x7E06950", VA = "0x187E07750")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<KLKDBEPMPLI> GGEGDDPGGPH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal static class ILCJNDAPKNM
{
	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F20", Offset = "0x7E01120", VA = "0x187E01F20")]
	public static void BMLLIMNJBGK(this BAIODOPPBMJ MMIHAHJDPNO, DCEEACKECED OKFJDEOMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E02070", Offset = "0x7E01270", VA = "0x187E02070")]
	public static void CMGEBHMOHLN(this DCEEACKECED EGGCEGONBOC, [Optional] string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public static class KNNOMKLDAAE
{
	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E05EB0", Offset = "0x7E050B0", VA = "0x187E05EB0")]
	public static MMBNINEADFK MEIMAIOKNIC(this LMBGLMOJANF ALDBPIGGABO)
	{
		return default(MMBNINEADFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E05E00", Offset = "0x7E05000", VA = "0x187E05E00")]
	public static LMBGLMOJANF KKFPKKPIBLK(this MMBNINEADFK IPJIKABJIIH)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public HJMEGJOFMMJ ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public HJMEGJOFMMJ HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		private static HJMEGJOFMMJ[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private Dictionary<HJMEGJOFMMJ, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C430", Offset = "0x7E0B630", VA = "0x187E0C430")]
		public bool EKHMNEGJOEI(HJMEGJOFMMJ CBIFFECGLCL, [Out] ResultConfig PEFAADKBJGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C4A0", Offset = "0x7E0B6A0", VA = "0x187E0C4A0")]
		public ResultConfig IELECANDKFH(HJMEGJOFMMJ HIIOCAFDBNN, [Optional] HashSet<HJMEGJOFMMJ> OKGHAIDGJNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CB80", Offset = "0x7E0BD80", VA = "0x187E0CB80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C5E0", Offset = "0x7E0B7E0", VA = "0x187E0C5E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public class MEIFPNCPHNJ : IKPNPMMECHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[CompilerGenerated]
	private struct EHHADELFKON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public MEIFPNCPHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x7E00010", Offset = "0x7DFF210", VA = "0x187E00010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E002A0", Offset = "0x7DFF4A0", VA = "0x187E002A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[CompilerGenerated]
	private struct KNFHIFGEHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public AGOOCHPPHOP<string>.ABBPACGFNKJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public IKPNPMMECHH preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private AGOOCHPPHOP<string>.ABBPACGFNKJ <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E058F0", Offset = "0x7E04AF0", VA = "0x187E058F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E05DA0", Offset = "0x7E04FA0", VA = "0x187E05DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	private readonly NNFIFGCLLNO EJMFDHMFBPM;

	[Cpp2IlInjected.Token(Token = "0x40007BA")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string FNDBIEAGFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x7E08270", Offset = "0x7E07470", VA = "0x187E08270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E08200", Offset = "0x7E07400", VA = "0x187E08200")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	internal static void BBACBJKIIBA(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	[RecRoom.NoEngine.Common.Preserve]
	public MEIFPNCPHNJ([KMMHIEIDBEA(null)] NNFIFGCLLNO EJMFDHMFBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E082A0", Offset = "0x7E074A0", VA = "0x187E082A0", Slot = "5")]
	[AsyncStateMachine(typeof(EHHADELFKON))]
	public Task IDKCINHHAJH(AGOOCHPPHOP<string>.ABBPACGFNKJ HAAAAGLKPNK, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E083B0", Offset = "0x7E075B0", VA = "0x187E083B0")]
	[AsyncStateMachine(typeof(KNFHIFGEHKH))]
	private Task IMKJBDMGAKI(IKPNPMMECHH CKHELNMFCAK, AGOOCHPPHOP<string>.ABBPACGFNKJ HAAAAGLKPNK, CancellationToken KPIINMODKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public interface NNFIFGCLLNO : IKPNPMMECHH
{
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public interface IKPNPMMECHH
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string FNDBIEAGFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IDKCINHHAJH(AGOOCHPPHOP<string>.ABBPACGFNKJ HAAAAGLKPNK, CancellationToken KPIINMODKFJ);
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public static class EEANBJFCHMF
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFC00", Offset = "0x7DFEE00", VA = "0x187DFFC00")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	internal static void JHDFHEGIBHJ(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public interface FLDEFDNOGMD : IEquatable<FLDEFDNOGMD>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime MNLIFBFEFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGLNALHILNE();

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFDEHHKKNBM(long KCAAOMDKNIH, long HPHKCHODKPD, [Out] OACJBLAPPIE HAJPGAGBAGC);
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal class KPJKCHOOJAP : GEIMDBFEJML
{
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private sealed class FKDBBAKMNEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public NCDJJBLPPNH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FKDBBAKMNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x7E00300", Offset = "0x7DFF500", VA = "0x187E00300")]
		internal object NPMLDEKDNMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private readonly GCNMENCJIDK OJEJIKJGFMP;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<FLDEFDNOGMD> HLLHDEMOIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E06120", Offset = "0x7E05320", VA = "0x187E06120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E05F50", Offset = "0x7E05150", VA = "0x187E05F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	[UnityEngine.Scripting.Preserve]
	public KPJKCHOOJAP([KMMHIEIDBEA(null)] GCNMENCJIDK OJEJIKJGFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E06810", Offset = "0x7E05A10", VA = "0x187E06810", Slot = "6")]
	public bool ODONGMBIAPH(long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC, NCDJJBLPPNH KMONDJFBELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0xCB8F60", Offset = "0xCB8160", VA = "0x180CB8F60")]
	private void FFLHBMBJCLB(FLDEFDNOGMD KJOBADLNJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E061D0", Offset = "0x7E053D0", VA = "0x187E061D0", Slot = "7")]
	public bool LNJBKKGDECP(long KCAAOMDKNIH, long HPHKCHODKPD, [Out] FLDEFDNOGMD GFNOBBEDINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E06340", Offset = "0x7E05540", VA = "0x187E06340", Slot = "8")]
	public bool MAGAKEPBMCF(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, [Out] FLDEFDNOGMD GFNOBBEDINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E063F0", Offset = "0x7E055F0", VA = "0x187E063F0")]
	private void NMDNHJLJDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E06000", Offset = "0x7E05200", VA = "0x187E06000", Slot = "9")]
	public void GEFIKKIJPIF(long KCAAOMDKNIH, long HPHKCHODKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
internal abstract class NPACHEGMJAK : GCNMENCJIDK
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	protected enum KKHFKFBNGEJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[CompilerGenerated]
	private sealed class OCENLAKKFOH : IEnumerable<FLDEFDNOGMD>, IEnumerable, IEnumerator<FLDEFDNOGMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private FLDEFDNOGMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public NPACHEGMJAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private NCDJJBLPPNH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public NCDJJBLPPNH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private FLDEFDNOGMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public OCENLAKKFOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E09830", Offset = "0x7E08A30", VA = "0x187E09830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E09B10", Offset = "0x7E08D10", VA = "0x187E09B10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E09A60", Offset = "0x7E08C60", VA = "0x187E09A60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLDEFDNOGMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E09A60", Offset = "0x7E08C60", VA = "0x187E09A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class CDAFIPEKKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public NCDJJBLPPNH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CDAFIPEKKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEBE0", Offset = "0x7DFDDE0", VA = "0x187DFEBE0")]
		internal object PFICJDHOKFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class HADMMEJHFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public NPACHEGMJAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HADMMEJHFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x7E00880", Offset = "0x7DFFA80", VA = "0x187E00880")]
		internal void CACIAPELHCD(OPCELKAIIFM.OKHHKNFCEFM ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private readonly object DDPNPMCNDOP;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string LAHPEAGBOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E09470", Offset = "0x7E08670", VA = "0x187E09470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract FPBJGEHLANL MOGBNGPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E09670", Offset = "0x7E08870", VA = "0x187E09670")]
	protected NPACHEGMJAK([CanBeNull] string PPJBMFNLEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E09480", Offset = "0x7E08680", VA = "0x187E09480", Slot = "5")]
	public bool MMDJILJALPP(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, [Out] FLDEFDNOGMD KJOBADLNJGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E08FF0", Offset = "0x7E081F0", VA = "0x187E08FF0", Slot = "6")]
	[IteratorStateMachine(typeof(OCENLAKKFOH))]
	public IEnumerable<FLDEFDNOGMD> AJAODCDEPNJ(NCDJJBLPPNH KMONDJFBELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MMBECMDJCJK(Stream FPAGJPKCIPD, long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC);

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool DEGIOIPKHHJ(Stream DINEPMIEPOL, long KCAAOMDKNIH, long HPHKCHODKPD, KIGNGIGFEEA BDNPKJBBBDK, [Out] OACJBLAPPIE HAJPGAGBAGC);

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x7E090F0", Offset = "0x7E082F0", VA = "0x187E090F0", Slot = "7")]
	public FLDEFDNOGMD HLHMIBFJDLN(long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC, NCDJJBLPPNH KMONDJFBELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo MMKCPABBKMM(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, KKHFKFBNGEJ LEPEDHGDPFJ);

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo KMIMOCNHONC(NCDJJBLPPNH KMONDJFBELJ, KKHFKFBNGEJ LEPEDHGDPFJ);

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x7E09080", Offset = "0x7E08280", VA = "0x187E09080")]
	protected void COJIPGBKKGL(OPCELKAIIFM.OKHHKNFCEFM NGJCGOPCEPE, string MMKAMPGMPIO, FileInfo KIDIECGIGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x7E08C30", Offset = "0x7E07E30", VA = "0x187E08C30")]
	internal bool AICGFNMPEOO(FileInfo HDFEBNEOBBD, long KCAAOMDKNIH, long HPHKCHODKPD, [Out] OACJBLAPPIE HAJPGAGBAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	private void FNEKANIJEKI(Exception MEOLMCJHMNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal class PPJNGPHJNMM : NPACHEGMJAK
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override FPBJGEHLANL MOGBNGPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x1BCAC50", Offset = "0x1BC9E50", VA = "0x181BCAC50", Slot = "8")]
		get
		{
			return default(FPBJGEHLANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A770", Offset = "0x7E09970", VA = "0x187E0A770")]
	public PPJNGPHJNMM([Optional] string PPJBMFNLEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A250", Offset = "0x7E09450", VA = "0x187E0A250")]
	private void ECCAKOFOPGN(NCDJJBLPPNH KMONDJFBELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A3D0", Offset = "0x7E095D0", VA = "0x187E0A3D0", Slot = "9")]
	internal override void MMBECMDJCJK(Stream FPAGJPKCIPD, long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x7E09B60", Offset = "0x7E08D60", VA = "0x187E09B60", Slot = "10")]
	internal override bool DEGIOIPKHHJ(Stream DINEPMIEPOL, long KCAAOMDKNIH, long HPHKCHODKPD, KIGNGIGFEEA BDNPKJBBBDK, [Out] OACJBLAPPIE HAJPGAGBAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A680", Offset = "0x7E09880", VA = "0x187E0A680", Slot = "11")]
	protected override FileInfo MMKCPABBKMM(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, KKHFKFBNGEJ LEPEDHGDPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A2D0", Offset = "0x7E094D0", VA = "0x187E0A2D0", Slot = "12")]
	protected override DirectoryInfo KMIMOCNHONC(NCDJJBLPPNH KMONDJFBELJ, KKHFKFBNGEJ LEPEDHGDPFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal sealed class IMFONMEIDFK : NPACHEGMJAK
{
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private static readonly byte[] MBDBONINAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private readonly byte[] KOFDDNAIEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E0")]
	private readonly byte[] JFJBLALKCKE;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override FPBJGEHLANL MOGBNGPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x698ECD0", Offset = "0x698DED0", VA = "0x18698ECD0", Slot = "8")]
		get
		{
			return default(FPBJGEHLANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x7E034A0", Offset = "0x7E026A0", VA = "0x187E034A0")]
	public IMFONMEIDFK([Optional] string PPJBMFNLEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x7E02E10", Offset = "0x7E02010", VA = "0x187E02E10", Slot = "9")]
	internal override void MMBECMDJCJK(Stream FPAGJPKCIPD, long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x7E02290", Offset = "0x7E01490", VA = "0x187E02290", Slot = "10")]
	internal override bool DEGIOIPKHHJ(Stream DINEPMIEPOL, long KCAAOMDKNIH, long HPHKCHODKPD, KIGNGIGFEEA BDNPKJBBBDK, [Out] OACJBLAPPIE HAJPGAGBAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x7E03350", Offset = "0x7E02550", VA = "0x187E03350")]
	private void NFDLAEEGGIL(byte[] GJKPEEJCIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x7E03220", Offset = "0x7E02420", VA = "0x187E03220", Slot = "11")]
	protected override FileInfo MMKCPABBKMM(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, KKHFKFBNGEJ LEPEDHGDPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x7E02D00", Offset = "0x7E01F00", VA = "0x187E02D00", Slot = "12")]
	protected override DirectoryInfo KMIMOCNHONC(NCDJJBLPPNH KMONDJFBELJ, KKHFKFBNGEJ LEPEDHGDPFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
public enum FPBJGEHLANL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007E6")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class KEMKCHGELBM : GCNMENCJIDK
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	private sealed class BJHPIHJBOCJ : IEnumerable<FLDEFDNOGMD>, IEnumerable, IEnumerator<FLDEFDNOGMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private FLDEFDNOGMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public KEMKCHGELBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private NCDJJBLPPNH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		public NCDJJBLPPNH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private FPBJGEHLANL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private IEnumerator<FLDEFDNOGMD> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private FLDEFDNOGMD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public BJHPIHJBOCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE840", Offset = "0x7DFDA40", VA = "0x187DFE840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE410", Offset = "0x7DFD610", VA = "0x187DFE410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE6F0", Offset = "0x7DFD8F0", VA = "0x187DFE6F0")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE7F0", Offset = "0x7DFD9F0", VA = "0x187DFE7F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE740", Offset = "0x7DFD940", VA = "0x187DFE740", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FLDEFDNOGMD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE740", Offset = "0x7DFD940", VA = "0x187DFE740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	private readonly FPBJGEHLANL[] KMCEHEBLPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private readonly Dictionary<FPBJGEHLANL, GCNMENCJIDK> OLGMLBCMOEG;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public FPBJGEHLANL MOGBNGPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x7E04330", Offset = "0x7E03530", VA = "0x187E04330", Slot = "4")]
		get
		{
			return default(FPBJGEHLANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x7E04360", Offset = "0x7E03560", VA = "0x187E04360")]
	[UnityEngine.Scripting.Preserve]
	public KEMKCHGELBM(params GCNMENCJIDK[] LCBGBOOPDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x7E041E0", Offset = "0x7E033E0", VA = "0x187E041E0", Slot = "5")]
	public bool MMDJILJALPP(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, [Out] FLDEFDNOGMD KJOBADLNJGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x7E03E40", Offset = "0x7E03040", VA = "0x187E03E40")]
	private void BGPKNHEGIFH(int MOJJOGLPNPE, long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x7E03DB0", Offset = "0x7E02FB0", VA = "0x187E03DB0", Slot = "6")]
	[IteratorStateMachine(typeof(BJHPIHJBOCJ))]
	public IEnumerable<FLDEFDNOGMD> AJAODCDEPNJ(NCDJJBLPPNH KMONDJFBELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x7E04080", Offset = "0x7E03280", VA = "0x187E04080", Slot = "7")]
	public FLDEFDNOGMD HLHMIBFJDLN(long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC, NCDJJBLPPNH KMONDJFBELJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal static class HGHNAHHHGMO
{
	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x7E00EA0", Offset = "0x7E000A0", VA = "0x187E00EA0")]
	internal static byte[] NIDMDKOAHFE(byte[] GJKPEEJCIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x7E00E20", Offset = "0x7E00020", VA = "0x187E00E20")]
	public static void EDHEJOIJFPO(Stream HENNMDJFPAB, byte[] JLMELOIGLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x7E00F60", Offset = "0x7E00160", VA = "0x187E00F60")]
	public static bool PEHKPHDAKON(Stream HENNMDJFPAB, long MNDOMELBMNI, KIGNGIGFEEA ALCNBFOMGFC, [Out] byte[] HCGFBHDOKPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal sealed class LODONBJEPPE : FLDEFDNOGMD, IEquatable<FLDEFDNOGMD>, IEquatable<LODONBJEPPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly NPACHEGMJAK ABMCKHKHHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	public readonly FileInfo OCJEHHINBEE;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public FPBJGEHLANL MOGBNGPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x76FD6E0", Offset = "0x76FC8E0", VA = "0x1876FD6E0", Slot = "9")]
		get
		{
			return default(FPBJGEHLANL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime MNLIFBFEFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x7E07C00", Offset = "0x7E06E00", VA = "0x187E07C00", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7E080F0", Offset = "0x7E072F0", VA = "0x187E080F0")]
	public LODONBJEPPE(NPACHEGMJAK FHGNAIAMFMI, FileInfo HDFEBNEOBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x7E08040", Offset = "0x7E07240", VA = "0x187E08040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x7E07F80", Offset = "0x7E07180", VA = "0x187E07F80", Slot = "5")]
	public void JGLNALHILNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x7E07F40", Offset = "0x7E07140", VA = "0x187E07F40", Slot = "6")]
	public bool HFDEHHKKNBM(long KCAAOMDKNIH, long HPHKCHODKPD, [Out] OACJBLAPPIE HAJPGAGBAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x7E07E40", Offset = "0x7E07040", VA = "0x187E07E40", Slot = "7")]
	public bool Equals(FLDEFDNOGMD LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x7E07D80", Offset = "0x7E06F80", VA = "0x187E07D80", Slot = "8")]
	public bool Equals(LODONBJEPPE LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x7E07C90", Offset = "0x7E06E90", VA = "0x187E07C90", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x7E07EB0", Offset = "0x7E070B0", VA = "0x187E07EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public delegate void KIGNGIGFEEA(OPCELKAIIFM.OKHHKNFCEFM JDBKOJIBGMJ, string DCEACFEGBDC);
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal interface GCNMENCJIDK
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	FPBJGEHLANL MOGBNGPKCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MMDJILJALPP(long KCAAOMDKNIH, long HPHKCHODKPD, NCDJJBLPPNH KMONDJFBELJ, [Out] FLDEFDNOGMD KJOBADLNJGB);

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<FLDEFDNOGMD> AJAODCDEPNJ(NCDJJBLPPNH KMONDJFBELJ);

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FLDEFDNOGMD HLHMIBFJDLN(long KCAAOMDKNIH, long HPHKCHODKPD, OACJBLAPPIE HAJPGAGBAGC, NCDJJBLPPNH KMONDJFBELJ);
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
