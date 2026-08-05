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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F9B70", Offset = "0x64F8F70", VA = "0x1864F9B70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
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
	public class LogRegistrationIndex : PKEBHBDMEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64F8270", Offset = "0x64F7670", VA = "0x1864F8270", Slot = "4")]
		public override void LIBHGHNAKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HHOAEPDMFFJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64F2B90", Offset = "0x64F1F90", VA = "0x1864F2B90")]
	public HHOAEPDMFFJ(string DCKDMGKGDFN, Exception OKBFLPKGAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class DLBGGBLAHDC : JANPOJDCHIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IACPFIDKLAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<FIJFPBAMPLD>> <>t__builder;

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
		private TaskAwaiter<PHFNOODDLHF<FIJFPBAMPLD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64F36F0", Offset = "0x64F2AF0", VA = "0x1864F36F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64F3930", Offset = "0x64F2D30", VA = "0x1864F3930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FCKMIKCOIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NIHFGOHKMIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<NIHFGOHKMIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64EB850", Offset = "0x64EAC50", VA = "0x1864EB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64EBA60", Offset = "0x64EAE60", VA = "0x1864EBA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	[UnityEngine.Scripting.Preserve]
	public DLBGGBLAHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64E9D60", Offset = "0x64E9160", VA = "0x1864E9D60", Slot = "4")]
	[AsyncStateMachine(typeof(IACPFIDKLAA))]
	public Task<IReadOnlyList<FIJFPBAMPLD>> IOAAIFJGMIN(long MAONELICPNP, long PHJIFAMIALG, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64E9C50", Offset = "0x64E9050", VA = "0x1864E9C50", Slot = "5")]
	[AsyncStateMachine(typeof(FCKMIKCOIDK))]
	public Task<IReadOnlyList<NIHFGOHKMIL>> HNAPNCPNIGP(IReadOnlyList<int> LAKAILDGPCP, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HHIOJINEDEC : IEquatable<HHIOJINEDEC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MCCHIKIEKME
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NIHFGOHKMIL KIHFJNHPEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime FCPKODBNDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MMEENBMCJPD? OMANPECLMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ECHGFGIBDIM? GHEAPLKCBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	EFODBGIGEDB FNCKDMMOBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BMKDPKMMAEO> OIEOJLBLONA();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum EFODBGIGEDB
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JANPOJDCHIO
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<FIJFPBAMPLD>> IOAAIFJGMIN(long MAONELICPNP, long PHJIFAMIALG, [Optional] CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<NIHFGOHKMIL>> HNAPNCPNIGP(IReadOnlyList<int> LAKAILDGPCP, [Optional] CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class COGDEEIFKDI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class LPDLPMOKNAG : HHIOJINEDEC, IEquatable<HHIOJINEDEC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct GLMFOMEDHFK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public LPDLPMOKNAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HGEAMHPGBOF <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<KLIMJDPIFED> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BMKDPKMMAEO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x64F0A80", Offset = "0x64EFE80", VA = "0x1864F0A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x64F0F20", Offset = "0x64F0320", VA = "0x1864F0F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly FIJFPBAMPLD CLJEPIJNIHE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int MCCHIKIEKME
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NIHFGOHKMIL KIHFJNHPEHK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime PIIKMLBGHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x522D6C0", Offset = "0x522CAC0", VA = "0x18522D6C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MMEENBMCJPD? OMANPECLMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x18E24E0", Offset = "0x18E18E0", VA = "0x1818E24E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ECHGFGIBDIM? GHEAPLKCBBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x522D7A0", Offset = "0x522CBA0", VA = "0x18522D7A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EFODBGIGEDB FNCKDMMOBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0", Slot = "10")]
			get
			{
				return default(EFODBGIGEDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64F8110", Offset = "0x64F7510", VA = "0x1864F8110", Slot = "9")]
		[AsyncStateMachine(typeof(GLMFOMEDHFK))]
		public Task<BMKDPKMMAEO> OIEOJLBLONA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x64F8210", Offset = "0x64F7610", VA = "0x1864F8210")]
		public LPDLPMOKNAG(int NLACDMOPFGG, NIHFGOHKMIL MOFBGBGILHN, FIJFPBAMPLD CLJEPIJNIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x64F7FC0", Offset = "0x64F73C0", VA = "0x1864F7FC0", Slot = "11")]
		public bool Equals(HHIOJINEDEC AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64F7F20", Offset = "0x64F7320", VA = "0x1864F7F20", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x64F80D0", Offset = "0x64F74D0", VA = "0x1864F80D0")]
		private bool HFKHLBHAFDL(LPDLPMOKNAG AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x64F8050", Offset = "0x64F7450", VA = "0x1864F8050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class AAOACKBIHHF : HHIOJINEDEC, IEquatable<HHIOJINEDEC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct EELBEOCFOFB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AAOACKBIHHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BMKDPKMMAEO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x64EA6A0", Offset = "0x64E9AA0", VA = "0x1864EA6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x64EA8D0", Offset = "0x64E9CD0", VA = "0x1864EA8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly KNCFAMOEPME POHGMCJNKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MMEENBMCJPD NFHMLNMEEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly ECHGFGIBDIM OCKAJEAPHJI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MCCHIKIEKME
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x64E52A0", Offset = "0x64E46A0", VA = "0x1864E52A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NIHFGOHKMIL KIHFJNHPEHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x64E4FF0", Offset = "0x64E43F0", VA = "0x1864E4FF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime PIIKMLBGHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x64E4E00", Offset = "0x64E4200", VA = "0x1864E4E00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MMEENBMCJPD? OMANPECLMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x64E4E50", Offset = "0x64E4250", VA = "0x1864E4E50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ECHGFGIBDIM? GHEAPLKCBBK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x64E5160", Offset = "0x64E4560", VA = "0x1864E5160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EFODBGIGEDB FNCKDMMOBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x882E30", Offset = "0x882230", VA = "0x180882E30", Slot = "10")]
			get
			{
				return default(EFODBGIGEDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xD64FD0", Offset = "0xD643D0", VA = "0x180D64FD0")]
		public AAOACKBIHHF(KNCFAMOEPME DBLMIDLIKMI, MMEENBMCJPD JHCBABHKJBC, ECHGFGIBDIM BCPOKPHAOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x64E51B0", Offset = "0x64E45B0", VA = "0x1864E51B0", Slot = "9")]
		[AsyncStateMachine(typeof(EELBEOCFOFB))]
		public Task<BMKDPKMMAEO> OIEOJLBLONA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x64E4F50", Offset = "0x64E4350", VA = "0x1864E4F50", Slot = "11")]
		public bool Equals(HHIOJINEDEC AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64E4EA0", Offset = "0x64E42A0", VA = "0x1864E4EA0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64E5100", Offset = "0x64E4500", VA = "0x1864E5100")]
		private bool HFKHLBHAFDL(AAOACKBIHHF AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64E5080", Offset = "0x64E4480", VA = "0x1864E5080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PLMMINLKCOL : HHIOJINEDEC, IEquatable<HHIOJINEDEC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct FLJMODJODHP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BMKDPKMMAEO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x64EBAD0", Offset = "0x64EAED0", VA = "0x1864EBAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x64EBD10", Offset = "0x64EB110", VA = "0x1864EBD10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly NIHFGOHKMIL BKOMNANAJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MMEENBMCJPD NFHMLNMEEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly ECHGFGIBDIM OCKAJEAPHJI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int MCCHIKIEKME
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x64FD2C0", Offset = "0x64FC6C0", VA = "0x1864FD2C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public NIHFGOHKMIL KIHFJNHPEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime PIIKMLBGHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MMEENBMCJPD? OMANPECLMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x64FCDB0", Offset = "0x64FC1B0", VA = "0x1864FCDB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ECHGFGIBDIM? GHEAPLKCBBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x64FD1A0", Offset = "0x64FC5A0", VA = "0x1864FD1A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EFODBGIGEDB FNCKDMMOBAL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "10")]
			get
			{
				return default(EFODBGIGEDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD64FD0", Offset = "0xD643D0", VA = "0x180D64FD0")]
		public PLMMINLKCOL(NIHFGOHKMIL MOFBGBGILHN, MMEENBMCJPD JHCBABHKJBC, ECHGFGIBDIM BCPOKPHAOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x64FD1F0", Offset = "0x64FC5F0", VA = "0x1864FD1F0", Slot = "9")]
		[AsyncStateMachine(typeof(FLJMODJODHP))]
		public Task<BMKDPKMMAEO> OIEOJLBLONA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x64FCE00", Offset = "0x64FC200", VA = "0x1864FCE00", Slot = "11")]
		public bool Equals(HHIOJINEDEC AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x64FCF10", Offset = "0x64FC310", VA = "0x1864FCF10", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64FD030", Offset = "0x64FC430", VA = "0x1864FD030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64FD0C0", Offset = "0x64FC4C0", VA = "0x1864FD0C0")]
		private bool HFKHLBHAFDL(PLMMINLKCOL AAMIMDAKFMC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct DKAJPLCPDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<HHIOJINEDEC>> <>t__builder;

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
		public COGDEEIFKDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<FIJFPBAMPLD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<FIJFPBAMPLD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, NIHFGOHKMIL account, FIJFPBAMPLD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64E8E00", Offset = "0x64E8200", VA = "0x1864E8E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64E9BE0", Offset = "0x64E8FE0", VA = "0x1864E9BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PCIHCLDKIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, NIHFGOHKMIL account, FIJFPBAMPLD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<FIJFPBAMPLD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public COGDEEIFKDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<NIHFGOHKMIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64FB240", Offset = "0x64FA640", VA = "0x1864FB240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x64FBC30", Offset = "0x64FB030", VA = "0x1864FBC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EHNFMDFHNFA FAGIILDEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JANPOJDCHIO IEIKFAEOJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HDLCEECDIBP KJFNDEPPBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MJLLEPHHJHI<(long, long), IReadOnlyList<FIJFPBAMPLD>> LAFFALILAFM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64E8820", Offset = "0x64E7C20", VA = "0x1864E8820")]
	[UnityEngine.Scripting.Preserve]
	public COGDEEIFKDI([CNGDHLLDFHE(null)] JANPOJDCHIO JBDOJLDGPLF, [CNGDHLLDFHE(null)] HDLCEECDIBP HKAODJBLIEO, [CNGDHLLDFHE(null)] EHNFMDFHNFA NKKGNDGEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64E85C0", Offset = "0x64E79C0", VA = "0x1864E85C0")]
	[AsyncStateMachine(typeof(DKAJPLCPDMM))]
	public Task<IList<HHIOJINEDEC>> GEKLHLFCFLD(long MAONELICPNP, long JNIJNNCDCAA, bool PPGIDIFFBHE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64E8420", Offset = "0x64E7820", VA = "0x1864E8420")]
	private bool AJKJCKDDNHN(DateTime? FLFKAGBGMCI, long MAONELICPNP, long JNIJNNCDCAA, [Out] KNCFAMOEPME JLHNEGAACPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64E8710", Offset = "0x64E7B10", VA = "0x1864E8710")]
	[AsyncStateMachine(typeof(PCIHCLDKIGF))]
	private Task<IReadOnlyList<(int, NIHFGOHKMIL, FIJFPBAMPLD)>> JGBJPKODECE(IReadOnlyList<FIJFPBAMPLD> DNMFLFGCCIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HDLCEECDIBP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KNCFAMOEPME> FMLBJIEKIEK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEHIJNNBBNK(long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM, AMIIJBBMGIJ NHAAHCFFLBH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIECNIHILIM(long MAONELICPNP, long JNIJNNCDCAA, [Out] KNCFAMOEPME JLHNEGAACPO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BBPHPLDIPAB(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, [Out] KNCFAMOEPME JLHNEGAACPO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHHDELHIAAI(long MAONELICPNP, long JNIJNNCDCAA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface PIHFPLMIMEJ : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool COLAKKFKICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task EJENLEPNKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBHPOBFMNAB(Task CKAKCFLCDJK, string MMNPMCFMJDE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface KLHLLMBIODH : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMKDPKMMAEO> INLMGFBECLN(KNCFAMOEPME JLHNEGAACPO);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CLOKDOMOJNP(CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface IEKBMIEDBGH : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JMENELMHCNB ACOAJDKOPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACNADNPMECC();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMLAAPAEOPN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface PCEOOIMJOPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface PPBNKAOBJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan MJABBJNDOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan BPFBOAENLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan MMMFCJJEDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan MMBMAJHEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ENGOEOPFNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MJLLKKBFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LOOCCOIIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FOGAPLEFFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OBFFKLKINLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool CGGDNOCNPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum KAFOHOGNMGP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum DKJJMEFGPAB
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
public struct AFCNFJBPLGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long MPHILAOLKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long PHJIFAMIALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly KAFOHOGNMGP ADAMDPHPFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception ECICOFGBGGP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x64E5330", Offset = "0x64E4730", VA = "0x1864E5330")]
	public AFCNFJBPLGM(long MPHILAOLKCL, long PHJIFAMIALG, KAFOHOGNMGP ADAMDPHPFAA, [CanBeNull] Exception ECICOFGBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x64E52E0", Offset = "0x64E46E0", VA = "0x1864E52E0")]
	public static AFCNFJBPLGM OGHELNAPKFG(JGNOMFHEEPM NDJFPJFNBDA, KAFOHOGNMGP ADAMDPHPFAA, [Optional] Exception ECICOFGBGGP)
	{
		return default(AFCNFJBPLGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void LHJBFGEAELJ(AFCNFJBPLGM HAKHJEMJHPL);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface LNDMKHCBDOO : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PECGBLJOPBE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LHJBFGEAELJ CJIBDEOLLNB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LHJBFGEAELJ FCMPIMIHAIP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LHJBFGEAELJ KHEAIOCHIIO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<DKJJMEFGPAB, bool> JLPHFIMIBHD;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELMNCGBPIKL();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LJJKHHKAGHM(AFCNFJBPLGM HAKHJEMJHPL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HKAOFNDHJKI(AFCNFJBPLGM HAKHJEMJHPL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CGJJOMHBMDK(AFCNFJBPLGM HAKHJEMJHPL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CJNENCCEKGF(DKJJMEFGPAB CMJHHBGCABN, bool OHANFNIJEEA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CHLDIKJAHMF : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FBGJBNHIPID();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJDNBBLBOII();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PDNOLCFPIDI : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus NPJEGNJJEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DEMIHOBAHHM(JGNOMFHEEPM HEFPGKMBKEC, CDPPOHKMOJI EHCNHMCCJLE, CancellationToken LBFDCKKMBFP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class DDMBEBALMIG
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64E8B40", Offset = "0x64E7F40", VA = "0x1864E8B40")]
	public static bool ENDFMHFBEMJ(this PDNOLCFPIDI JJFLHNONCLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task BFKPENOOMGM(DCOJCHOOLIN ILKGBPMJIJM, CancellationToken FACMOGNGACN);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface HPGHAPKGCLE : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABNCNBGBJLM(BFKPENOOMGM BHEFGLINIJI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DGDKDOCHPEF : HGEAMHPGBOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken PIAOGFDJEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BHJKECHLECD KDFDFOMHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CPGICIMPCNG IJLBMNOCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FODOAKFANLM POOBAPNIADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	LGFOLLJEPJB GPGMBFALKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HCICBFGHMPB BMBFOJCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NEPMMMPOKOK HKLKFKMAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	POFEKCBIEJO BHAALGHHFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PIHFPLMIMEJ GEDEAEKIONI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	KLHLLMBIODH NEKBPJCHDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	LNDMKHCBDOO FPGNCBJDJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CHLDIKJAHMF FFGJMPIHFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	PDNOLCFPIDI IMMBMMKPAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HPGHAPKGCLE IKLEPCNNACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DLIBIAHGMJD GHKKPHLELJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CCBLPCLCEIE PKCKKBBDNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JCKLHJNBJGM BECDFKMIIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BHKAGBPEGBB ELHICFLFBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LMFMLKBIFFO CILKLBLDNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KJJCNAFJBJL PECMEIENIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BCAPBKOMKNJ CHCMCJBOCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LJKCNOFNJHN INKNFGCJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CMGGJCGPGMA BGEAFGCNMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AGDBEEDABKA JLKABLMFAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IEKBMIEDBGH HKFIMDBECOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	PPBNKAOBJNC JCHENDLLKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HEOGHGPPAKP GEEINOFPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	HDLCEECDIBP NAIADGJHJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LJOHAFJGHGF BGFHNPHAHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	FGHINJIDHMN KOKBNNBKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EKDOLLAFFBP(CDPPOHKMOJI AAKADMGLNLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DLIBIAHGMJD : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPEKGGOEKMM FLOHBAGDPJC(Guid BMPBDIBKAJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJHEJNEGCKN(Guid BMPBDIBKAJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NOOLMLDCPNF(Guid BMPBDIBKAJJ, Task ODJKFHPAFPO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KIPGDHHEMOI(Guid BMPBDIBKAJJ, BMKDPKMMAEO MMAGMCJCDGB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(BMKDPKMMAEO, Task)> EIAJDBDAKGC(Guid BMPBDIBKAJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MAFICDMKOFH : PCEOOIMJOPC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface CCBLPCLCEIE : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIFGEKFJEMO(FABBKACGCKD DCKDMGKGDFN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGGIFCEANNI(FABBKACGCKD DCKDMGKGDFN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EAMJNAFBIOM> IOFCCCAEPIB(CancellationToken JEPJDLKNMKC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface JCKLHJNBJGM : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPEKGGOEKMM OIOKIKIOMCC(FABBKACGCKD ILMOKKBCFDB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFDPIPKHOMF(Guid BMPBDIBKAJJ, Task ODJKFHPAFPO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface BHKAGBPEGBB : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMKDPKMMAEO> ELHICFLFBHL(FABBKACGCKD HGNDFIBADEI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface LMFMLKBIFFO : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNPPEJGLHLI> BABJCJJDBEH(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, JGNOMFHEEPM HEFPGKMBKEC, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface BCAPBKOMKNJ : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMKDPKMMAEO ILHFGAICEKC(PFJNLKLKGNM JCCGLLCNOMF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ODBIALOBEMN(string KGIHKOADMFC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KJJCNAFJBJL : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FABBKACGCKD> LLPOAMIAKNE(FABBKACGCKD NCCHHGAPAOP, IKLJEDJKANM AOGCBHMFIGD, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FABBKACGCKD> AEDONFBFAID(CancellationToken HNLFPBLPOKJ, IKLJEDJKANM AOGCBHMFIGD);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENAELKBIJPI GCNEFEHAGMH(MDFBCIKEPAJ LAEANMKOMEC, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ENAELKBIJPI HEIMJEPNLCC(MDFBCIKEPAJ LAEANMKOMEC, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface LJKCNOFNJHN : PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMKDPKMMAEO GGCCGKPIEHE(PFJNLKLKGNM JCCGLLCNOMF, EAMJNAFBIOM PDAIHKFBCFA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMKDPKMMAEO AJBBPEJHHLJ(PFJNLKLKGNM BHAADNJFDOM);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CMGGJCGPGMA
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHJBIADAOEM(PLDEFLGGGLC AJONGDOEGCC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPJEMHHNENI(PLDEFLGGGLC AJONGDOEGCC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGJODONEEFO(PLDEFLGGGLC AJONGDOEGCC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNPJDOMKOAL(PLDEFLGGGLC AJONGDOEGCC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class PLDEFLGGGLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JGNOMFHEEPM NEKMENMNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> AFCEELILOGN;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NKOLFLIKMKN<string> MEPNGHMNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C60", Offset = "0x7A0060", VA = "0x1807A0C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public PLDEFLGGGLC(JGNOMFHEEPM BIAPCBFJHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x64FCC50", Offset = "0x64FC050", VA = "0x1864FCC50")]
	public PLDEFLGGGLC GGMBDCNDGMB(string KCGLPAPOILB, string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x64FCD20", Offset = "0x64FC120", VA = "0x1864FCD20")]
	public bool MIDJHCLDJDP([Out] IEnumerable<KeyValuePair<string, string>> NBIFNMIBKNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x58A3C90", Offset = "0x58A3090", VA = "0x1858A3C90")]
	public PLDEFLGGGLC OCDOGPMLGDE(NKOLFLIKMKN<string> CBPCKBLKEKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HEOGHGPPAKP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OKFPCGPJLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string ONEOMLEJFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LMEKJDNPAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKNOHHJAPNK();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMGEAALKNAM DAKCNLAMCCM(long JIHPABAMAKF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BELAJFDOOBL<IODJBGDFNFE, ODLEKMGFHLE> ADKFCHLPOHC(long JIHPABAMAKF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BELAJFDOOBL<IODJBGDFNFE, JFMKOBKPDPB> IIKKAGBJEFA(long JIHPABAMAKF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BELAJFDOOBL<long, BCPGLEEKCAN> OPCDIKFIEMH();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NMFGNPHLALI(long JIHPABAMAKF, [Out] bool OGHBLEOFGJA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> FLIDHJJOEJM(byte[] JAMOLIKGFAA, byte[] MDKKFDHBGPI, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface HGEAMHPGBOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool ENDFMHFBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GJOMHELKKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	CDPPOHKMOJI JJCBFGOPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PECGBLJOPBE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LHJBFGEAELJ CJIBDEOLLNB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LHJBFGEAELJ FCMPIMIHAIP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event LHJBFGEAELJ KHEAIOCHIIO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DKJJMEFGPAB, bool> JLPHFIMIBHD;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DJDNBBLBOII();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JMLHNPPHBLO LCBKJDODAIC();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OKIPFHEPFHJ GHOELMOEFKN();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<BMKDPKMMAEO> INLMGFBECLN(KNCFAMOEPME DBLMIDLIKMI);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task CLOKDOMOJNP(CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LGFOLLJEPJB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ILKAIKFLJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string KFDKFELJGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEHIMIDEKLH(Scene GHIPJAEPLLF);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DGFNPCOBKPF(HACDKHOAAEM NGDMAJICPGG, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CINCFOACKDN();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface JJABELEOGOG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KPNKHPAHPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NNPKAIPONND
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool ABKFAFMIAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LNDAIHOCKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EKALFCCIIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OHCKCCFOBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LJDCOJEKKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float IKECMHDLOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> KADHGFGAJFP;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BHJKECHLECD HCIOANHLDHJ(BHJKECHLECD FAHHHGHBKDP);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJDGFJNDMKK(BHJKECHLECD CHBOBHMMJGK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMBGBCJHEFJ();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task EGGCODKKFBC(NKOLFLIKMKN<string>.JNCJJIKLGBC AHAGCKDCCFM, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBGCELGMLLG(float GFGPAAAJMHA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHOKLIANEFC(string BBEJDLOJLLM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<BDJOBCBDAGC> JDDKEBJGECC();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable KNKPHPOGAMN(object PEHINKLIDNC, BDJOBCBDAGC JAJFIPMCBCE);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ODLEKMGFHLE FNAMCHMFMBB(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CCIOLOAGPGI(int MCOOOFLFPHN);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task MPECKFIGKLD();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JHODLOLPBCK();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KIDAAGIEGHH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task GMFOKPGGPPL(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task MAIEMBCIDFJ(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<CDACCFLNIFI> CJNEOJCEENG(DateTime KKHIOCMKCKL, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> CKNCDBMPINI(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FJPANIMCCKJ(string EFBABOCJKJF = "", float DAMPBKHPLCH = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	OLENPIFNGNM BFMKFMBGAAH(HBOGCGCACNI NNCPDPEMMHA, NKMLLCBDLBB HJLJOGJJHDA, JFMKOBKPDPB CIFHGECIFMC, IEnumerable<PersistenceView> LONHAOCNGLL, KFMFDOKOAMN JPEMHCLCCFI);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IGNLDHCFCMB(JFMKOBKPDPB CIFHGECIFMC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void OFODBGBJDAC(NEEDBNPPDKD GKOAKJGNMLA, [In] OLENPIFNGNM LJLGHMIMKMO);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task EEMINDIPDON(JFMKOBKPDPB CKKGBMAMDIC, bool IMOPLNILDHP, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task AKIFNGLDJGO(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IPOKDPPLOOO(long MAONELICPNP, long PHJIFAMIALG, KLIMJDPIFED IHDIFNFCKLF, FIJFPBAMPLD HDGDAJMEKKC, DODBLFCGAMM BALEBDNJLEM, NHNEEALDKAA? AHAIOEKHGEF, IGEACEPBJLE? IEGPEDOLAKH);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HECFGKHGFKP(long MAONELICPNP, long PHJIFAMIALG, IGEACEPBJLE? IEGPEDOLAKH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KJNCOBFENNH(PersistenceView FCKEECMPPCH);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool OOJMNAFHKKB(PersistenceView MPAMJPPMOAI);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool GNKHOCDMMJJ(NEEDBNPPDKD GKOAKJGNMLA, KHNJGFFJIHB AKFDDOIJBOM, [Out] HLFIAPIKAIE CBAFLEIOJGE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task EEBIGPHBIFK(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void IDLCLBLPDGE();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable DDMHMJKHCIE();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GDFEKLDKAAI(JFMKOBKPDPB CKKGBMAMDIC, KHNJGFFJIHB AKFDDOIJBOM);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> JMODOMGKLFA(CPGICIMPCNG EEMFDHBKBKN, CancellationToken HNLFPBLPOKJ, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void IBKNAMPFOIE(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<OGFMKNMGFDL> PJEPNNMKDOD(PCIOPIHJCFH NCCHHGAPAOP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<KLIMJDPIFED> GAIPBBCHBMF(long MAONELICPNP, bool FJANIJOACDN, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<FIJFPBAMPLD> JMMAFNGIAGA(long MAONELICPNP, long PHJIFAMIALG, long PFBFKOLLAFL, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NEKAJBGAFOL> AFJCNCFOAHF(string NIJJKNDDJLJ, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<NEKAJBGAFOL> HOJDBPONFII(string NIJJKNDDJLJ, long MAONELICPNP, long PHJIFAMIALG, string AIMMPKDBJBI, OFJCNAOGFJB.IJKCDLBJPNN ILKGBPMJIJM, OFJCNAOGFJB.IJKCDLBJPNN MDKKFDHBGPI, int GMOKELEHOGA);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool LJOJOLNNOGO();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool DMKOHIODLLN();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DGECPKDCAAI(IEnumerable<HLFIAPIKAIE> PKLALHMLKMH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EALJFNHDJKF(List<GameObject> EKEBMHLMCDB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float DGDNNIANHPC();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> AIGPJKDEJCN(string DNOMIJHONBC, LoadSceneMode EPHCOCADLOM, bool OAOJJHJJHNM, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LFMBMCDLCDA();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void MNHCNDJKMBK(bool PPMNKMLMNBB);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CGOOBFNBHBG(JGNOMFHEEPM BNPHIKGCHLM);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task NBDBAGFNMNN(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task IEOFFHAKCME(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task PMKNEAOKEOA(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable PBICGJCOIJJ();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "63")]
	PDLBOMJFAGF FEIOKPFBGAL();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task GCFLFGDEEGF(CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PDLBOMJFAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LLNFAAMEBPK(CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MEBPDGHHDGM(CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct OLENPIFNGNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> LLPNJCEIBAM;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum CDACCFLNIFI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HBOGCGCACNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string HADICCHNEPB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ONOFAHGAHLG
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	JGNOMFHEEPM HEIEHBINHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	KLIMJDPIFED KBDLGJIMNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	KFLDBIMKFED FGJNELKCDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool PNAGLANLLKI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool JEDJDEPJPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	int HLOOILHMHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action OFNBLFFBLFD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> AEDBEFDFPGE;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MDPALCFBPCO();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.BFCCNOHJOEE> ANJEJFMAGOK(long JIHPABAMAKF, [Optional] CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CHDJJLPCNAE> BEDCMEJCJJK();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task CODOOCEBFNF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(JGNOMFHEEPM, CDPPOHKMOJI) LGAKAPAJDKA();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NFLIPHOFKMG DGJHHIIOINP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JCLLKIOMPJA(long JIHPABAMAKF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AGDBEEDABKA
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBGJLIBBGDI([Out] IEnumerable<int> OIOBKGFAIGP);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFDMBBDPKIB(ICDJEGFNKHF FACMOGNGACN);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MCGDBAJBIEH(ICDJEGFNKHF FACMOGNGACN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EHOAEHBDIAI
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LBFPDGEFHFM(BMKDPKMMAEO DLLPBDKAPOD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DAJAPKCADJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPGCGNMHNJM(DGMAHNELBPO.CMLJNCHJJAD NJIFKEMHNJH);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJEJDLODGOC(DGMAHNELBPO.CMLJNCHJJAD NJIFKEMHNJH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HCICBFGHMPB : DAJAPKCADJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMKDPKMMAEO CEEMDHOOPID(PFJNLKLKGNM BHAADNJFDOM);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NEPMMMPOKOK : DAJAPKCADJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMKDPKMMAEO ILHFGAICEKC(PFJNLKLKGNM MGJLCIFAFPP);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MMGEAALKNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKHLNMGODKL<HACDKHOAAEM, NOJMEPFJKIM>> IANDDPGMBMC(string AIMMPKDBJBI, long JIHPABAMAKF, DGOIDAAGJMM.GBBIGAJCJHD LDBENHHHMBE, CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface BELAJFDOOBL<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKHLNMGODKL<byte[], NOJMEPFJKIM>> FOKMHLPHHOO(TGetDataArg OEJAGOPNKOK, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KKHLNMGODKL<MKCMBBHNGLH<TData>, NOJMEPFJKIM> EPGMCPDMPAB(byte[] MFNOAEFOKBK);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class JGHMECKKGKJ : DGDKDOCHPEF, HGEAMHPGBOF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HJBALOHHEMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JGHMECKKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KNCFAMOEPME autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<BMKDPKMMAEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x64F2C00", Offset = "0x64F2000", VA = "0x1864F2C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x64F2E80", Offset = "0x64F2280", VA = "0x1864F2E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PMHMDHGAIIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public JGHMECKKGKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x64FD2E0", Offset = "0x64FC6E0", VA = "0x1864FD2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x64FD510", Offset = "0x64FC910", VA = "0x1864FD510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GPFFAMMDNOC : IEnumerable<PCEOOIMJOPC>, IEnumerable, IEnumerator<PCEOOIMJOPC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private PCEOOIMJOPC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JGHMECKKGKJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private PCEOOIMJOPC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public GPFFAMMDNOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x64F1BC0", Offset = "0x64F0FC0", VA = "0x1864F1BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x64F2020", Offset = "0x64F1420", VA = "0x1864F2020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x64F1F70", Offset = "0x64F1370", VA = "0x1864F1F70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PCEOOIMJOPC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x64F1F70", Offset = "0x64F1370", VA = "0x1864F1F70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource LFLJNFBCMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BHJKECHLECD CHBOBHMMJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IEFOKJIIPOM FIOLDKLHFEH;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public CPGICIMPCNG IJLBMNOCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x79F220", Offset = "0x79E620", VA = "0x18079F220", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x79F240", Offset = "0x79E640", VA = "0x18079F240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public FODOAKFANLM POOBAPNIADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x79F1A0", Offset = "0x79E5A0", VA = "0x18079F1A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x79F190", Offset = "0x79E590", VA = "0x18079F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x79F160", Offset = "0x79E560", VA = "0x18079F160", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x79F0F0", Offset = "0x79E4F0", VA = "0x18079F0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LGFOLLJEPJB GPGMBFALKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D20", Offset = "0x7A2120", VA = "0x1807A2D20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D30", Offset = "0x7A2130", VA = "0x1807A2D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HCICBFGHMPB BMBFOJCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x79F310", Offset = "0x79E710", VA = "0x18079F310", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x79F400", Offset = "0x79E800", VA = "0x18079F400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public NEPMMMPOKOK HKLKFKMAEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x79F130", Offset = "0x79E530", VA = "0x18079F130", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x79F1C0", Offset = "0x79E5C0", VA = "0x18079F1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public POFEKCBIEJO BHAALGHHFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9590", Offset = "0x7A8990", VA = "0x1807A9590", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7A9550", Offset = "0x7A8950", VA = "0x1807A9550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public PIHFPLMIMEJ GEDEAEKIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7A9500", Offset = "0x7A8900", VA = "0x1807A9500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KLHLLMBIODH NEKBPJCHDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7A9460", Offset = "0x7A8860", VA = "0x1807A9460", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7A94D0", Offset = "0x7A88D0", VA = "0x1807A94D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LNDMKHCBDOO FPGNCBJDJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2B0", Offset = "0x8DA6B0", VA = "0x1808DB2B0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8DB390", Offset = "0x8DA790", VA = "0x1808DB390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CHLDIKJAHMF FFGJMPIHFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A8840", VA = "0x1807A9440", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7A9470", Offset = "0x7A8870", VA = "0x1807A9470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PDNOLCFPIDI IMMBMMKPAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85D990", Offset = "0x85CD90", VA = "0x18085D990", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85D950", Offset = "0x85CD50", VA = "0x18085D950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HPGHAPKGCLE IKLEPCNNACO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x79C9A0", Offset = "0x79BDA0", VA = "0x18079C9A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x79C9C0", Offset = "0x79BDC0", VA = "0x18079C9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DLIBIAHGMJD GHKKPHLELJB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98F170", Offset = "0x98E570", VA = "0x18098F170", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x99D290", Offset = "0x99C690", VA = "0x18099D290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public MAFICDMKOFH IOMAGPLBKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x99D120", Offset = "0x99C520", VA = "0x18099D120", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x99D2D0", Offset = "0x99C6D0", VA = "0x18099D2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public CCBLPCLCEIE PKCKKBBDNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x876430", Offset = "0x875830", VA = "0x180876430", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x99D1F0", Offset = "0x99C5F0", VA = "0x18099D1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public JCKLHJNBJGM BECDFKMIIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BC0", Offset = "0x7F1FC0", VA = "0x1807F2BC0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7F1040", Offset = "0x7F0440", VA = "0x1807F1040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public BHKAGBPEGBB ELHICFLFBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B90", Offset = "0x7F1F90", VA = "0x1807F2B90", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7F0610", Offset = "0x7EFA10", VA = "0x1807F0610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LMFMLKBIFFO CILKLBLDNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x79C9B0", Offset = "0x79BDB0", VA = "0x18079C9B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x79CA00", Offset = "0x79BE00", VA = "0x18079CA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KJJCNAFJBJL PECMEIENIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8A6FE0", Offset = "0x8A63E0", VA = "0x1808A6FE0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6FF0", Offset = "0x8A63F0", VA = "0x1808A6FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BCAPBKOMKNJ CHCMCJBOCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x853F60", Offset = "0x853360", VA = "0x180853F60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x853B10", Offset = "0x852F10", VA = "0x180853B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LJKCNOFNJHN INKNFGCJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x90A1E0", Offset = "0x9095E0", VA = "0x18090A1E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x99D2B0", Offset = "0x99C6B0", VA = "0x18099D2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public CMGGJCGPGMA BGEAFGCNMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x908FE0", Offset = "0x9083E0", VA = "0x180908FE0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x99D270", Offset = "0x99C670", VA = "0x18099D270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public AGDBEEDABKA JLKABLMFAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x909130", Offset = "0x908530", VA = "0x180909130", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x99D250", Offset = "0x99C650", VA = "0x18099D250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public IEKBMIEDBGH HKFIMDBECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x909140", Offset = "0x908540", VA = "0x180909140", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x99D450", Offset = "0x99C850", VA = "0x18099D450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PPBNKAOBJNC JCHENDLLKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x908E80", Offset = "0x908280", VA = "0x180908E80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x99D410", Offset = "0x99C810", VA = "0x18099D410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HEOGHGPPAKP GEEINOFPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE30", Offset = "0x7FB230", VA = "0x1807FBE30", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x99D370", Offset = "0x99C770", VA = "0x18099D370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HDLCEECDIBP NAIADGJHJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x86D440", Offset = "0x86C840", VA = "0x18086D440", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LJOHAFJGHGF BGFHNPHAHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x87FAF0", Offset = "0x87EEF0", VA = "0x18087FAF0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FGHINJIDHMN KOKBNNBKNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x86D460", Offset = "0x86C860", VA = "0x18086D460", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public CDPPOHKMOJI JJCBFGOPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x86D450", Offset = "0x86C850", VA = "0x18086D450", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C920", VA = "0x18086D520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool PDOPIELCIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x64F57E0", Offset = "0x64F4BE0", VA = "0x1864F57E0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private bool PJFKMACCEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x64F5C90", Offset = "0x64F5090", VA = "0x1864F5C90", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private CancellationToken EBEDKJKMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x64F58C0", Offset = "0x64F4CC0", VA = "0x1864F58C0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private BHJKECHLECD BPEPFEKBFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GOOOMFKOPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x64F5A90", Offset = "0x64F4E90", VA = "0x1864F5A90", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x64F5D10", Offset = "0x64F5110", VA = "0x1864F5D10", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event LHJBFGEAELJ OKLMLLJJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x64F5720", Offset = "0x64F4B20", VA = "0x1864F5720", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x64F58E0", Offset = "0x64F4CE0", VA = "0x1864F58E0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event LHJBFGEAELJ APIDLHLKABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x64F5780", Offset = "0x64F4B80", VA = "0x1864F5780", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x64F5660", Offset = "0x64F4A60", VA = "0x1864F5660", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event LHJBFGEAELJ DECMHGKIAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x64F53D0", Offset = "0x64F47D0", VA = "0x1864F53D0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x64F5A30", Offset = "0x64F4E30", VA = "0x1864F5A30", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<DKJJMEFGPAB, bool> KBLHHIFEIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x64F5BA0", Offset = "0x64F4FA0", VA = "0x1864F5BA0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x64F56C0", Offset = "0x64F4AC0", VA = "0x1864F56C0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C920", VA = "0x18086D520", Slot = "35")]
	public void EKDOLLAFFBP(CDPPOHKMOJI AAKADMGLNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x64F5D70", Offset = "0x64F5170", VA = "0x1864F5D70")]
	[UnityEngine.Scripting.Preserve]
	internal JGHMECKKGKJ([CNGDHLLDFHE(null)] BHJKECHLECD CHBOBHMMJGK, [CNGDHLLDFHE(null)] CPGICIMPCNG EEMFDHBKBKN, [CNGDHLLDFHE(null)] FODOAKFANLM PPDPJNGKPDI, [CNGDHLLDFHE(null)] JJABELEOGOG CBKELGPMNJD, [CNGDHLLDFHE(null)] LGFOLLJEPJB CDNHGIJKMBK, [CNGDHLLDFHE(null)] HCICBFGHMPB MNFKJAIKCEK, [CNGDHLLDFHE(null)] NEPMMMPOKOK LEBHIAFBMDE, [CNGDHLLDFHE(null)] POFEKCBIEJO KJKMOLPCOFM, [CNGDHLLDFHE(null)] PIHFPLMIMEJ PHKDJCBLPHI, [CNGDHLLDFHE(null)] KLHLLMBIODH KNDNFFKPJPD, [CNGDHLLDFHE(null)] LNDMKHCBDOO GIPJNFBJAIL, [CNGDHLLDFHE(null)] CHLDIKJAHMF AFCMMENFPCD, [CNGDHLLDFHE(null)] PDNOLCFPIDI JJFLHNONCLD, [CNGDHLLDFHE(null)] HPGHAPKGCLE MJJNIEOODNN, [CNGDHLLDFHE(null)] DLIBIAHGMJD APCFMHOFDCH, [CNGDHLLDFHE(null)] MAFICDMKOFH EICKGKEBICF, [CNGDHLLDFHE(null)] CCBLPCLCEIE IAJBCBKDLKK, [CNGDHLLDFHE(null)] JCKLHJNBJGM DKMEDHIHGMK, [CNGDHLLDFHE(null)] BHKAGBPEGBB MPCJAGLDLFN, [CNGDHLLDFHE(null)] LMFMLKBIFFO JIIHIOFMNOA, [CNGDHLLDFHE(null)] BCAPBKOMKNJ OKMJHGDBCIN, [CNGDHLLDFHE(null)] KJJCNAFJBJL AJGCBIEKBJJ, [CNGDHLLDFHE(null)] LJKCNOFNJHN MDNDGOJLCNG, [CNGDHLLDFHE(null)] CMGGJCGPGMA INDOODBDNHK, [CNGDHLLDFHE(null)] AGDBEEDABKA MBIIIDCAPGC, [CNGDHLLDFHE(null)] PPBNKAOBJNC IEOEELMKLEO, [CNGDHLLDFHE(null)] HEOGHGPPAKP OLOFJAKDEHF, [CNGDHLLDFHE(null)] HDLCEECDIBP HJODMHENKGB, [CNGDHLLDFHE(null)] LJOHAFJGHGF CEHLEAGFNCG, [CNGDHLLDFHE(null)] FGHINJIDHMN KBCNMLIHOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x64F5AF0", Offset = "0x64F4EF0", VA = "0x1864F5AF0")]
	private void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x64F5430", Offset = "0x64F4830", VA = "0x1864F5430", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x64F5380", Offset = "0x64F4780", VA = "0x1864F5380", Slot = "48")]
	private void DJHNFKMDCAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x64F5C00", Offset = "0x64F5000", VA = "0x1864F5C00", Slot = "49")]
	private JMLHNPPHBLO OGMBLFEGMGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x64F55D0", Offset = "0x64F49D0", VA = "0x1864F55D0", Slot = "50")]
	private OKIPFHEPFHJ EDNPLJNBNJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x64F5270", Offset = "0x64F4670", VA = "0x1864F5270", Slot = "51")]
	[AsyncStateMachine(typeof(HJBALOHHEMD))]
	private Task<BMKDPKMMAEO> DIBDBINBFFJ(KNCFAMOEPME JLHNEGAACPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x64F5940", Offset = "0x64F4D40", VA = "0x1864F5940", Slot = "52")]
	[AsyncStateMachine(typeof(PMHMDHGAIIB))]
	private Task KHFPPLINDJG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x64F5840", Offset = "0x64F4C40", VA = "0x1864F5840")]
	[IteratorStateMachine(typeof(GPFFAMMDNOC))]
	private IEnumerable<PCEOOIMJOPC> IFBDCAGBGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x64F5210", Offset = "0x64F4610", VA = "0x1864F5210")]
	[CompilerGenerated]
	private void AOHIPJMIDHJ(PCEOOIMJOPC EGDKIFALJBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ANHDMMPBFDJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xCEF250", Offset = "0xCEE650", VA = "0x180CEF250")]
	public ANHDMMPBFDJ(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class FAHMCGMKHIC : LLALOLCHPLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct EHEDGCFDJHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FAHMCGMKHIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x64EAB40", Offset = "0x64E9F40", VA = "0x1864EAB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x64EAE80", Offset = "0x64EA280", VA = "0x1864EAE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
	public FAHMCGMKHIC(DGDKDOCHPEF HMDOIKIDPEL, JJABELEOGOG CBKELGPMNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x64EAEF0", Offset = "0x64EA2F0", VA = "0x1864EAEF0", Slot = "4")]
	[AsyncStateMachine(typeof(EHEDGCFDJHL))]
	public Task<bool> LHNOOJBECLG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x64EAFE0", Offset = "0x64EA3E0", VA = "0x1864EAFE0")]
	[CompilerGenerated]
	private object LPIOPKOHPGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class CJKBHEHHAFL : LLALOLCHPLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct HKKDBMNBKLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CJKBHEHHAFL <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x64F2EF0", Offset = "0x64F22F0", VA = "0x1864F2EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64F3600", Offset = "0x64F2A00", VA = "0x1864F3600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x64E7B90", Offset = "0x64E6F90", VA = "0x1864E7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
	public CJKBHEHHAFL(DGDKDOCHPEF HMDOIKIDPEL, JJABELEOGOG CBKELGPMNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x64E7A60", Offset = "0x64E6E60", VA = "0x1864E7A60", Slot = "4")]
	[AsyncStateMachine(typeof(HKKDBMNBKLC))]
	public Task<bool> LHNOOJBECLG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x64E7BE0", Offset = "0x64E6FE0", VA = "0x1864E7BE0")]
	[CompilerGenerated]
	private object OAKFEMJINHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class JEJLJLJCGCG : LLALOLCHPLF
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EFLJMFEAGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public JEJLJLJCGCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CHDJJLPCNAE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JGNOMFHEEPM newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public EFLJMFEAGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x64EA9E0", Offset = "0x64E9DE0", VA = "0x1864EA9E0")]
		internal object FFFMDIKLMAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x64EAAD0", Offset = "0x64E9ED0", VA = "0x1864EAAD0")]
		internal object PKLAJIDGPDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x64EA940", Offset = "0x64E9D40", VA = "0x1864EA940")]
		internal object BDHLPFCEDDB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct OIKHJGJMEBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JEJLJLJCGCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EFLJMFEAGFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<CHDJJLPCNAE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x64F9BF0", Offset = "0x64F8FF0", VA = "0x1864F9BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x64FA520", Offset = "0x64F9920", VA = "0x1864FA520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x64F51C0", Offset = "0x64F45C0", VA = "0x1864F51C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
	public JEJLJLJCGCG(DGDKDOCHPEF HMDOIKIDPEL, JJABELEOGOG CBKELGPMNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x64F50A0", Offset = "0x64F44A0", VA = "0x1864F50A0", Slot = "4")]
	[AsyncStateMachine(typeof(OIKHJGJMEBJ))]
	public Task<bool> LHNOOJBECLG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface LLALOLCHPLF
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LHNOOJBECLG(CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct OLNNLDEJNGC
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NCMNEBJBHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DGDKDOCHPEF manager;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NCMNEBJBHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x64F8450", Offset = "0x64F7850", VA = "0x1864F8450")]
		internal Task DNKPIGDDLFN(DCOJCHOOLIN data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct BFIPIELOJHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public OLNNLDEJNGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private KNCFAMOEPME <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<CDACCFLNIFI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<BMKDPKMMAEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x64E6B40", Offset = "0x64E5F40", VA = "0x1864E6B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x64E70D0", Offset = "0x64E64D0", VA = "0x1864E70D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct FOBAIDKNDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public OLNNLDEJNGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x64EBD80", Offset = "0x64EB180", VA = "0x1864EBD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x64EC0A0", Offset = "0x64EB4A0", VA = "0x1864EC0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken HNLFPBLPOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DGDKDOCHPEF FKFIJGNHDJN;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private CPGICIMPCNG IJLBMNOCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x64FA840", Offset = "0x64F9C40", VA = "0x1864FA840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x64FA590", Offset = "0x64F9990", VA = "0x1864FA590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x64FAA10", Offset = "0x64F9E10", VA = "0x1864FAA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private KLHLLMBIODH NEKBPJCHDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x64FA7F0", Offset = "0x64F9BF0", VA = "0x1864FA7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D565C0", Offset = "0x1D559C0", VA = "0x181D565C0")]
	public OLNNLDEJNGC(CancellationToken HNLFPBLPOKJ, DGDKDOCHPEF FKFIJGNHDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x64FA960", Offset = "0x64F9D60", VA = "0x1864FA960")]
	public static BFKPENOOMGM KPBCOEADFPG(DGDKDOCHPEF FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x64FABC0", Offset = "0x64F9FC0", VA = "0x1864FABC0")]
	[AsyncStateMachine(typeof(BFIPIELOJHL))]
	public Task<bool> OLPPMELFJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x64FA5E0", Offset = "0x64F99E0", VA = "0x1864FA5E0")]
	private bool BFILJACGNGL([Out] KNCFAMOEPME JLHNEGAACPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x64FA890", Offset = "0x64F9C90", VA = "0x1864FA890")]
	[AsyncStateMachine(typeof(FOBAIDKNDJF))]
	private Task FMCPHPPLNEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x64FAA90", Offset = "0x64F9E90", VA = "0x1864FAA90")]
	private Task<CDACCFLNIFI> MAMGLOCFODG(KNCFAMOEPME GEEFDNBLEJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct CPEKGGOEKMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly DLIBIAHGMJD APCFMHOFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid BMPBDIBKAJJ;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private Task<(BMKDPKMMAEO, Task)> BMDBBMOAMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x64E8950", Offset = "0x64E7D50", VA = "0x1864E8950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A600", Offset = "0x3B09A00", VA = "0x183B0A600")]
	public CPEKGGOEKMM(DLIBIAHGMJD APCFMHOFDCH, Guid BMPBDIBKAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64E8AF0", Offset = "0x64E7EF0", VA = "0x1864E8AF0")]
	public TaskAwaiter<(BMKDPKMMAEO, Task)> LPPDDHLPDIP()
	{
		return default(TaskAwaiter<(BMKDPKMMAEO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x64E8A20", Offset = "0x64E7E20", VA = "0x1864E8A20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct BJOBKFAIHNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(BMKDPKMMAEO, Task)> ICCBMJNOACJ;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Task<(BMKDPKMMAEO, Task)> BMDBBMOAMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x64E7140", Offset = "0x64E6540", VA = "0x1864E7140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x64E7390", Offset = "0x64E6790", VA = "0x1864E7390")]
	public BJOBKFAIHNF(TimeSpan ILFNCCAINDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x64E72F0", Offset = "0x64E66F0", VA = "0x1864E72F0")]
	public void MGONBHJHFGF(Task ODJKFHPAFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x64E7180", Offset = "0x64E6580", VA = "0x1864E7180")]
	public void CCEHPLBJLNC(BMKDPKMMAEO DLLPBDKAPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x64E7210", Offset = "0x64E6610", VA = "0x1864E7210")]
	public void CFEKFNGLJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x64E7260", Offset = "0x64E6660", VA = "0x1864E7260")]
	internal void IDIDIBEBCNB(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FAKFFDJJPGL
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NJAOACDOBDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public FIJFPBAMPLD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NJAOACDOBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x64F9B40", Offset = "0x64F8F40", VA = "0x1864F9B40")]
		internal bool BBPAOOPDJMM(KFLDBIMKFED s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x64EB630", Offset = "0x64EAA30", VA = "0x1864EB630")]
	public static DNPPEJGLHLI NDFPICIGPEG(long MPHILAOLKCL, long PHJIFAMIALG, string NIJJKNDDJLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x64EB340", Offset = "0x64EA740", VA = "0x1864EB340")]
	public static DNPPEJGLHLI NDFPICIGPEG(long MPHILAOLKCL, long PHJIFAMIALG, IODJBGDFNFE JAMOLIKGFAA, long PFBFKOLLAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x64EB1B0", Offset = "0x64EA5B0", VA = "0x1864EB1B0")]
	public static DNPPEJGLHLI NDFPICIGPEG(OGFMKNMGFDL CFFMGCOFALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x64EB400", Offset = "0x64EA800", VA = "0x1864EB400")]
	public static DNPPEJGLHLI NDFPICIGPEG(KLIMJDPIFED FAAFCIEEBBJ, FIJFPBAMPLD GAJCPEMOAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x64EB0C0", Offset = "0x64EA4C0", VA = "0x1864EB0C0")]
	public static DNPPEJGLHLI EIGIELPCIFM(this DNPPEJGLHLI MBIDFLHPHHK, KLIMJDPIFED FIMFMIKBONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x64EB6C0", Offset = "0x64EAAC0", VA = "0x1864EB6C0")]
	public static DNPPEJGLHLI OIGBNHJBGHK(this DNPPEJGLHLI MBIDFLHPHHK, FIJFPBAMPLD IBEAODGFNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class IHLJNJACBLB : PIHFPLMIMEJ, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct BCKFDJBNKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public IHLJNJACBLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x64E5F70", Offset = "0x64E5370", VA = "0x1864E5F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x64E6600", Offset = "0x64E5A00", VA = "0x1864E6600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly ICDJEGFNKHF FNAGPJPMCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string OFMBOCMCLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task CJLILKALFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool COLAKKFKICH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x64F3A30", Offset = "0x64F2E30", VA = "0x1864F3A30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task EJENLEPNKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x64F39A0", Offset = "0x64F2DA0", VA = "0x1864F39A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260", Slot = "7")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x64F3B80", Offset = "0x64F2F80", VA = "0x1864F3B80", Slot = "6")]
	public void OBHPOBFMNAB(Task CKAKCFLCDJK, string MMNPMCFMJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x64F3A60", Offset = "0x64F2E60", VA = "0x1864F3A60")]
	[AsyncStateMachine(typeof(BCKFDJBNKIJ))]
	private Task MJPACPMNCNL(Task FMDPLNFDDAA, string MMNPMCFMJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x64F3CE0", Offset = "0x64F30E0", VA = "0x1864F3CE0")]
	public IHLJNJACBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class JIEMLCGPMPG : IEKBMIEDBGH, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool MCNEJPDDAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private JMENELMHCNB JGHPADHDHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private PPBNKAOBJNC IEOEELMKLEO;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public JMENELMHCNB ACOAJDKOPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x64F63A0", Offset = "0x64F57A0", VA = "0x1864F63A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x64F64D0", Offset = "0x64F58D0", VA = "0x1864F64D0", Slot = "7")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x64F61B0", Offset = "0x64F55B0", VA = "0x1864F61B0", Slot = "5")]
	public void ACNADNPMECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x64F6360", Offset = "0x64F5760", VA = "0x1864F6360", Slot = "6")]
	public void AMLAAPAEOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x64F6410", Offset = "0x64F5810", VA = "0x1864F6410")]
	private Task DNLGHBOGDHP(OEDOIKAGHHI JHEMNDMHNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x64F6360", Offset = "0x64F5760", VA = "0x1864F6360", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public JIEMLCGPMPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class LGBOFIJHKHI : PPBNKAOBJNC
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class LEJEPLLOIKJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly HNKCKJJOABH MPBINOPBHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string KCGLPAPOILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T EOMOMDHMMPP;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x7EA420", Offset = "0x7E9820", VA = "0x1807EA420")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98CAC0", VA = "0x18098D6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3B4BBE0", Offset = "0x3B4AFE0", VA = "0x183B4BBE0")]
		public LEJEPLLOIKJ(HNKCKJJOABH MPBINOPBHMM, string KCGLPAPOILB, T EOMOMDHMMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B770", Offset = "0x3B4AB70", VA = "0x183B4B770")]
		private void HPAOEECJDAL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly HNKCKJJOABH MPBINOPBHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly LEJEPLLOIKJ<TimeSpan> BBDLFLDEKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LEJEPLLOIKJ<TimeSpan> BOPMBGPOHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly LEJEPLLOIKJ<TimeSpan> NADKOABFOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LEJEPLLOIKJ<TimeSpan> EOAIGHCKHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly LEJEPLLOIKJ<bool> EOHPCIIDODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly LEJEPLLOIKJ<bool> MFGMHKGHEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly LEJEPLLOIKJ<bool> LMKAKCOMEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LEJEPLLOIKJ<int> KHDECNNHJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly LEJEPLLOIKJ<bool> PJDCHENJLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly LEJEPLLOIKJ<bool> GKKBPMFIEIK;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan MJABBJNDOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x64F6A10", Offset = "0x64F5E10", VA = "0x1864F6A10", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan BPFBOAENLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x64F6A90", Offset = "0x64F5E90", VA = "0x1864F6A90", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan MMMFCJJEDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x64F6B10", Offset = "0x64F5F10", VA = "0x1864F6B10", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan MMBMAJHEKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x64F6A50", Offset = "0x64F5E50", VA = "0x1864F6A50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool ENGOEOPFNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x64F69D0", Offset = "0x64F5DD0", VA = "0x1864F69D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool MJLLKKBFKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x64F6910", Offset = "0x64F5D10", VA = "0x1864F6910", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LOOCCOIIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x64F68D0", Offset = "0x64F5CD0", VA = "0x1864F68D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int FOGAPLEFFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x64F6AD0", Offset = "0x64F5ED0", VA = "0x1864F6AD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OBFFKLKINLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x64F6950", Offset = "0x64F5D50", VA = "0x1864F6950", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CGGDNOCNPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x64F6990", Offset = "0x64F5D90", VA = "0x1864F6990", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x64F6B50", Offset = "0x64F5F50", VA = "0x1864F6B50")]
	[UnityEngine.Scripting.Preserve]
	public LGBOFIJHKHI([CNGDHLLDFHE(null)] HNKCKJJOABH MPBINOPBHMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class PNDHAPMJMEF : LNDMKHCBDOO, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class JPCPANKEFMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AFCNFJBPLGM roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JPCPANKEFMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x64F6650", Offset = "0x64F5A50", VA = "0x1864F6650")]
		internal object EOIBDNAFAEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action PECGBLJOPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x64FD5F0", Offset = "0x64FC9F0", VA = "0x1864FD5F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x64FD690", Offset = "0x64FCA90", VA = "0x1864FD690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event LHJBFGEAELJ CJIBDEOLLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x64FD730", Offset = "0x64FCB30", VA = "0x1864FD730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x64FDDC0", Offset = "0x64FD1C0", VA = "0x1864FDDC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event LHJBFGEAELJ FCMPIMIHAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x64FDF30", Offset = "0x64FD330", VA = "0x1864FDF30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x64FDE90", Offset = "0x64FD290", VA = "0x1864FDE90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LHJBFGEAELJ KHEAIOCHIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x64FDA70", Offset = "0x64FCE70", VA = "0x1864FDA70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x64FD9D0", Offset = "0x64FCDD0", VA = "0x1864FD9D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<DKJJMEFGPAB, bool> JLPHFIMIBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x64FDFD0", Offset = "0x64FD3D0", VA = "0x1864FDFD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x64FDB10", Offset = "0x64FCF10", VA = "0x1864FDB10", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "19")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x64FD7D0", Offset = "0x64FCBD0", VA = "0x1864FD7D0", Slot = "14")]
	public void ELMNCGBPIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x64FDE60", Offset = "0x64FD260", VA = "0x1864FDE60", Slot = "15")]
	public void LJJKHHKAGHM(AFCNFJBPLGM HAKHJEMJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x64FDD90", Offset = "0x64FD190", VA = "0x1864FDD90", Slot = "16")]
	public void HKAOFNDHJKI(AFCNFJBPLGM HAKHJEMJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x64FD570", Offset = "0x64FC970", VA = "0x1864FD570", Slot = "17")]
	public void CGJJOMHBMDK(AFCNFJBPLGM HAKHJEMJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x64FD5A0", Offset = "0x64FC9A0", VA = "0x1864FD5A0", Slot = "18")]
	public void CJNENCCEKGF(DKJJMEFGPAB CMJHHBGCABN, bool OHANFNIJEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x64FDBC0", Offset = "0x64FCFC0", VA = "0x1864FDBC0")]
	private void HEMLICAMOIG(LHJBFGEAELJ JAJFIPMCBCE, AFCNFJBPLGM HAKHJEMJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PNDHAPMJMEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class PIJGCBPOAPJ : CHLDIKJAHMF, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BMAFNGGMMCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PIJGCBPOAPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x64E7520", Offset = "0x64E6920", VA = "0x1864E7520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x64E7A00", Offset = "0x64E6E00", VA = "0x1864E7A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct GKJBLCJCBPE : IAsyncStateMachine
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
		public PIJGCBPOAPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x64EC8C0", Offset = "0x64EBCC0", VA = "0x1864EC8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x64ECF20", Offset = "0x64EC320", VA = "0x1864ECF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class DIGFDLIIIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public DIGFDLIIIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x64E8D90", Offset = "0x64E8190", VA = "0x1864E8D90")]
		internal object PFICACDCNPA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct GELJJBOOCGC : IAsyncStateMachine
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
		public PIJGCBPOAPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private DIGFDLIIIGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x64EC100", Offset = "0x64EB500", VA = "0x1864EC100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x64EC850", Offset = "0x64EBC50", VA = "0x1864EC850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class HHMJHKCOMFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HHMJHKCOMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x64F2B20", Offset = "0x64F1F20", VA = "0x1864F2B20")]
		internal object JDJPPJCBENM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private LLALOLCHPLF[] NLKPOKONAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource MFNNECHIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int EGKNAHAPPHN;

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x64FCA90", Offset = "0x64FBE90", VA = "0x1864FCA90", Slot = "6")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x64FBF40", Offset = "0x64FB340", VA = "0x1864FBF40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x64FC100", Offset = "0x64FB500", VA = "0x1864FC100", Slot = "8")]
	public void GFHNNFNCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x64FBE70", Offset = "0x64FB270", VA = "0x1864FBE70", Slot = "5")]
	public void DJDNBBLBOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x64FC030", Offset = "0x64FB430", VA = "0x1864FC030", Slot = "4")]
	[AsyncStateMachine(typeof(BMAFNGGMMCI))]
	public Task FBGJBNHIPID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x64FC200", Offset = "0x64FB600", VA = "0x1864FC200")]
	private void IBPJLMADOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x64FC510", Offset = "0x64FB910", VA = "0x1864FC510")]
	[AsyncStateMachine(typeof(GKJBLCJCBPE))]
	private Task IIIHIFIEOFK(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x64FC870", Offset = "0x64FBC70", VA = "0x1864FC870")]
	[AsyncStateMachine(typeof(GELJJBOOCGC))]
	private Task<bool> JPIHKFMKAPA(int OJANCMLFDOJ, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x64FC9B0", Offset = "0x64FBDB0", VA = "0x1864FC9B0")]
	private void NEFHHHEPNKG(int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x64FBF50", Offset = "0x64FB350", VA = "0x1864FBF50")]
	private void EKMCCOALKHF(int OJANCMLFDOJ, bool OHANFNIJEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x64FC740", Offset = "0x64FBB40", VA = "0x1864FC740")]
	private void JNOFMIGCHPJ(int OJANCMLFDOJ, Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x64FC610", Offset = "0x64FBA10", VA = "0x1864FC610")]
	private void IJIJKFPBJNM(CancellationToken HNLFPBLPOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PIJGCBPOAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class GKNECBCGJIA : PDNOLCFPIDI, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct ILNJFHNKPOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CDPPOHKMOJI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x64F3D70", Offset = "0x64F3170", VA = "0x1864F3D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x64F46D0", Offset = "0x64F3AD0", VA = "0x1864F46D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct AGEFCPIOENF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CDPPOHKMOJI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private NKOLFLIKMKN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private LLMJNNBAAIC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IKLJEDJKANM <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private PLDEFLGGGLC <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x64E5350", Offset = "0x64E4750", VA = "0x1864E5350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x64E5F10", Offset = "0x64E5310", VA = "0x1864E5F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class PJGGOPLHGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.KPBBCLKOGGJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HMBAFJINLBC errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PJGGOPLHGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x64FCBA0", Offset = "0x64FBFA0", VA = "0x1864FCBA0")]
		internal object BINHMMGDCII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class LJLDAGBFIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<DNPPEJGLHLI> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LJLDAGBFIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		internal Task<DNPPEJGLHLI> JMJPJFLJLIK(NKOLFLIKMKN<string>.JNCJJIKLGBC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct PPEPBNBNDMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CDPPOHKMOJI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IKLJEDJKANM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private LJLDAGBFIFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private MAADCOBIKJK <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private LLMJNNBAAIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private INCDONFPCLI <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.BFCCNOHJOEE> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private EGJODLHOIKF <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.BFCCNOHJOEE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<DNPPEJGLHLI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x64FE080", Offset = "0x64FD480", VA = "0x1864FE080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6503190", Offset = "0x6502590", VA = "0x186503190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HBCJDDENGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <disconnectTimerScope>5__3;

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
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x64F2070", Offset = "0x64F1470", VA = "0x1864F2070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x64F2AC0", Offset = "0x64F1EC0", VA = "0x1864F2AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct BDPJCGOHOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private BHJKECHLECD <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x64E6660", Offset = "0x64E5A60", VA = "0x1864E6660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x64E6AE0", Offset = "0x64E5EE0", VA = "0x1864E6AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ONIOKDBIJKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.BFCCNOHJOEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.BFCCNOHJOEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x64FACD0", Offset = "0x64FA0D0", VA = "0x1864FACD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x64FB1D0", Offset = "0x64FA5D0", VA = "0x1864FB1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CKKJHFBNMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.BFCCNOHJOEE serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public IKLJEDJKANM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<OHKFMKBEFOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x64E7CC0", Offset = "0x64E70C0", VA = "0x1864E7CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x64E83C0", Offset = "0x64E77C0", VA = "0x1864E83C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class DFHKIMADEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public DFHKIMADEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x64E8C90", Offset = "0x64E8090", VA = "0x1864E8C90")]
		internal object CHGJJJBJDGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x64E8B90", Offset = "0x64E7F90", VA = "0x1864E8B90")]
		internal string BBGBEINLPNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct GOEDDJCGLEN : IAsyncStateMachine
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
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private DFHKIMADEBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private LLMJNNBAAIC <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x64F0F90", Offset = "0x64F0390", VA = "0x1864F0F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x64F1B60", Offset = "0x64F0F60", VA = "0x1864F1B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct IPHFLCLCHPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public IKLJEDJKANM joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public DNPPEJGLHLI initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public JGNOMFHEEPM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MAADCOBIKJK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x64F4730", Offset = "0x64F3B30", VA = "0x1864F4730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x64F5040", Offset = "0x64F4440", VA = "0x1864F5040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct NFNCCEDLPMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private LLMJNNBAAIC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x64F84A0", Offset = "0x64F78A0", VA = "0x1864F84A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x64F9AE0", Offset = "0x64F8EE0", VA = "0x1864F9AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct EDDEIOLFODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GKNECBCGJIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<BMKDPKMMAEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x64E9E80", Offset = "0x64E9280", VA = "0x1864E9E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x64EA640", Offset = "0x64E9A40", VA = "0x1864EA640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class PDPAAJKBECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PDPAAJKBECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x64FBCA0", Offset = "0x64FB0A0", VA = "0x1864FBCA0")]
		internal object OMCPOPEAJAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class KIHHKCOMOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KIHHKCOMOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x64F6830", Offset = "0x64F5C30", VA = "0x1864F6830")]
		internal void DHPCIPGOKCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HPFGJGKFNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HPFGJGKFNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x64F3670", Offset = "0x64F2A70", VA = "0x1864F3670")]
		internal object BFKKMEKMLEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class KBKIPGIGMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KBKIPGIGMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x64F6730", Offset = "0x64F5B30", VA = "0x1864F6730")]
		internal string AKPEAOFCFIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly AMCJMMGFCLE AGOIFJGOBIL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly AMCJMMGFCLE KDGHIEBJDGH;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly AMCJMMGFCLE LPKLKJBOLCI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string GDDCPPIJCBE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string OALPMBNEMLM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string GPCJDOAMDDA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid HPIKAIHDDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private POFEKCBIEJO KJKMOLPCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FODOAKFANLM PPDPJNGKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private CHLDIKJAHMF AFCMMENFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private PIHFPLMIMEJ PHKDJCBLPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LNDMKHCBDOO GIPJNFBJAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private FGHINJIDHMN KBCNMLIHOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private LJOHAFJGHGF CEHLEAGFNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable EDLPADOLIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly ICDJEGFNKHF KODAFNIIOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly ICDJEGFNKHF AGKFHKEAHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private EGJODLHOIKF NLJOFPDGAAE;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TaskStatus NPJEGNJJEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA1E920", Offset = "0xA1DD20", VA = "0x180A1E920", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA671C0", Offset = "0xA665C0", VA = "0x180A671C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x64EFBA0", Offset = "0x64EEFA0", VA = "0x1864EFBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x64EFD30", Offset = "0x64EF130", VA = "0x1864EFD30", Slot = "6")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x64EDAB0", Offset = "0x64ECEB0", VA = "0x1864EDAB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x64ED770", Offset = "0x64ECB70", VA = "0x1864ED770", Slot = "5")]
	[AsyncStateMachine(typeof(ILNJFHNKPOO))]
	public Task DEMIHOBAHHM(JGNOMFHEEPM HEFPGKMBKEC, CDPPOHKMOJI EHCNHMCCJLE, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x64ED010", Offset = "0x64EC410", VA = "0x1864ED010")]
	[AsyncStateMachine(typeof(AGEFCPIOENF))]
	private Task AMAMKGBFPHO(JGNOMFHEEPM HEFPGKMBKEC, CDPPOHKMOJI EHCNHMCCJLE, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x64ED320", Offset = "0x64EC720", VA = "0x1864ED320")]
	private static void CJPLOAFMHJF(FGHINJIDHMN KBCNMLIHOAH, JGNOMFHEEPM HEFPGKMBKEC, Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x64EDB00", Offset = "0x64ECF00", VA = "0x1864EDB00")]
	private static void EHHDCNGBLIH(PLDEFLGGGLC CBMPEPGONJJ, Exception MEIELCKPCNE, [Optional] List<int> ANIKJAPDHEJ, int EGKNAHAPPHN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x64EF2C0", Offset = "0x64EE6C0", VA = "0x1864EF2C0")]
	[AsyncStateMachine(typeof(PPEPBNBNDMD))]
	private Task JCCAJKGAKHG(NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, JGNOMFHEEPM HEFPGKMBKEC, CDPPOHKMOJI EHCNHMCCJLE, IKLJEDJKANM AMOFHAEJHHA, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x64F0640", Offset = "0x64EFA40", VA = "0x1864F0640")]
	private void OOPMIJKCMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x64ED980", Offset = "0x64ECD80", VA = "0x1864ED980")]
	[AsyncStateMachine(typeof(HBCJDDENGHB))]
	private Task DPAAKGAFNEC(NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x64F01F0", Offset = "0x64EF5F0", VA = "0x1864F01F0")]
	private void OAILIHOKPKC(JGNOMFHEEPM HEFPGKMBKEC, CancellationToken LBFDCKKMBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x64EECF0", Offset = "0x64EE0F0", VA = "0x1864EECF0")]
	private void HCKLPBOIFDD(JGNOMFHEEPM HEFPGKMBKEC, IKLJEDJKANM AMOFHAEJHHA, OperationCanceledException FKKCIAPJJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x64EF090", Offset = "0x64EE490", VA = "0x1864EF090")]
	private void IIOAJGLABPN(JGNOMFHEEPM HEFPGKMBKEC, IKLJEDJKANM AMOFHAEJHHA, Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x64EF670", Offset = "0x64EEA70", VA = "0x1864EF670")]
	private void KCKGOOLOGJO(JGNOMFHEEPM HEFPGKMBKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x64EEF20", Offset = "0x64EE320", VA = "0x1864EEF20")]
	private static AFCNFJBPLGM HGGKHKKINKG(JGNOMFHEEPM HEFPGKMBKEC)
	{
		return default(AFCNFJBPLGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x64ED8B0", Offset = "0x64ECCB0", VA = "0x1864ED8B0")]
	[AsyncStateMachine(typeof(BDPJCGOHOED))]
	private Task DLDNDOKCKIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x64ED160", Offset = "0x64EC560", VA = "0x1864ED160")]
	[AsyncStateMachine(typeof(ONIOKDBIJKD))]
	private Task<Matchmaking.BFCCNOHJOEE> ANJEJFMAGOK(JGNOMFHEEPM HEFPGKMBKEC, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x64EEF80", Offset = "0x64EE380", VA = "0x1864EEF80")]
	private static OHKFMKBEFOI IHICACBPJAE(Matchmaking.BFCCNOHJOEE DIDLGBCHBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x64EEBA0", Offset = "0x64EDFA0", VA = "0x1864EEBA0")]
	[AsyncStateMachine(typeof(CKKJHFBNMKA))]
	private Task HAMPILJCFEJ(Matchmaking.BFCCNOHJOEE DIDLGBCHBMH, IKLJEDJKANM AMOFHAEJHHA, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken FFFPEBPPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x64EFBF0", Offset = "0x64EEFF0", VA = "0x1864EFBF0")]
	[AsyncStateMachine(typeof(GOEDDJCGLEN))]
	private Task MMEPGEEGAIA(JGNOMFHEEPM HEFPGKMBKEC, CancellationTokenSource DCPJAKBALLI, Task OLLBFIJLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x64EFA30", Offset = "0x64EEE30", VA = "0x1864EFA30")]
	[AsyncStateMachine(typeof(IPHFLCLCHPJ))]
	private Task LLKHBCBKMMJ(DNPPEJGLHLI GLIEHNPLIJL, MAADCOBIKJK CJLIGMBBAMO, JGNOMFHEEPM PPLNGIECAAE, IKLJEDJKANM ILMMEFEBALA, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken LNKPLPAKPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x64EF480", Offset = "0x64EE880", VA = "0x1864EF480")]
	private IKLJEDJKANM JPNICBJNBBL(IKLJEDJKANM ILMMEFEBALA, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x64EE390", Offset = "0x64ED790", VA = "0x1864EE390")]
	[AsyncStateMachine(typeof(NFNCCEDLPMH))]
	private Task EIIHAOEKNLD(NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x64F0520", Offset = "0x64EF920", VA = "0x1864F0520")]
	[AsyncStateMachine(typeof(EDDEIOLFODP))]
	private Task ODCGJJAGGMM(DCOJCHOOLIN MFNOAEFOKBK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x64EE4C0", Offset = "0x64ED8C0", VA = "0x1864EE4C0")]
	private static void EIPPHKNHAJI(JGNOMFHEEPM HEFPGKMBKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x64EE6D0", Offset = "0x64EDAD0", VA = "0x1864EE6D0")]
	private void FEOJLJFIAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x64EE640", Offset = "0x64EDA40", VA = "0x1864EE640")]
	private void ENJAHCAMHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x64ECF80", Offset = "0x64EC380", VA = "0x1864ECF80")]
	private void ADEHPMLDKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x64ED6E0", Offset = "0x64ECAE0", VA = "0x1864ED6E0")]
	private void DCJCKLDMCJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x64EE8A0", Offset = "0x64EDCA0", VA = "0x1864EE8A0")]
	private static void GEBFFEBKODD(JGNOMFHEEPM HEFPGKMBKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x64EEA90", Offset = "0x64EDE90", VA = "0x1864EEA90")]
	private static CancellationTokenRegistration GJPOPMDHAPO(JGNOMFHEEPM HEFPGKMBKEC, CancellationToken FFFPEBPPIIK)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x64EE990", Offset = "0x64EDD90", VA = "0x1864EE990")]
	private static void GIPAMGBINNC(JGNOMFHEEPM HEFPGKMBKEC, Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x64EF880", Offset = "0x64EEC80", VA = "0x1864EF880")]
	private void LFPOPMODNBD(JGNOMFHEEPM HEFPGKMBKEC, Task OLLBFIJLMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x64ED2C0", Offset = "0x64EC6C0", VA = "0x1864ED2C0")]
	private static void BDAJDFAFKKC(Func<string> NIKIKIFBAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x64F09B0", Offset = "0x64EFDB0", VA = "0x1864F09B0")]
	public GKNECBCGJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x64EF420", Offset = "0x64EE820", VA = "0x1864EF420")]
	[CompilerGenerated]
	internal static (int, int?) JDKEMFEEPPB(HMBAFJINLBC FBHHDJPJBFB)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class LNICAEALGJA : HPGHAPKGCLE, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct AOEIFBDHPLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public LNICAEALGJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public DCOJCHOOLIN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x65056C0", Offset = "0x6504AC0", VA = "0x1865056C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6505A80", Offset = "0x6504E80", VA = "0x186505A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class NAPNLEGPKLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public LNICAEALGJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public DCOJCHOOLIN roomData;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NAPNLEGPKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x651AE70", Offset = "0x651A270", VA = "0x18651AE70")]
		internal List<Task> IDDLAMHNKMN(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct DLFJGCNDKOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public BFKPENOOMGM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x65099D0", Offset = "0x6508DD0", VA = "0x1865099D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6509D60", Offset = "0x6509160", VA = "0x186509D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct JIBOHPOOKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public LNICAEALGJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6512AD0", Offset = "0x6511ED0", VA = "0x186512AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6512D90", Offset = "0x6512190", VA = "0x186512D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<BFKPENOOMGM> NEMIAGHHAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private FODOAKFANLM PPDPJNGKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private BDJOBCBDAGC JACBOHBLJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private CLFAIEHFMNB LFPMAHICINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable EDLPADOLIJF;

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x64F7C10", Offset = "0x64F7010", VA = "0x1864F7C10", Slot = "5")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x64F7560", Offset = "0x64F6960", VA = "0x1864F7560", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x64F6FC0", Offset = "0x64F63C0", VA = "0x1864F6FC0", Slot = "4")]
	public bool ABNCNBGBJLM(BFKPENOOMGM BHEFGLINIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x64F75C0", Offset = "0x64F69C0", VA = "0x1864F75C0")]
	private void FEMBLNFCPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x64F7910", Offset = "0x64F6D10", VA = "0x1864F7910")]
	private void IANDPCHHLJG(DCOJCHOOLIN ILKGBPMJIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x64F7020", Offset = "0x64F6420", VA = "0x1864F7020")]
	[AsyncStateMachine(typeof(AOEIFBDHPLI))]
	private Task BELIAHKLGNE(DCOJCHOOLIN ILKGBPMJIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x64F77C0", Offset = "0x64F6BC0", VA = "0x1864F77C0")]
	private Func<CancellationToken, List<Task>> FGHJIFACEGO(DCOJCHOOLIN ILKGBPMJIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x64F7110", Offset = "0x64F6510", VA = "0x1864F7110")]
	private List<Task> BJEEMEPHCHD(DCOJCHOOLIN ILKGBPMJIJM, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x64F7AF0", Offset = "0x64F6EF0", VA = "0x1864F7AF0")]
	[AsyncStateMachine(typeof(DLFJGCNDKOF))]
	private Task ILIPAMOGINM(BFKPENOOMGM KONGNKHADNA, DCOJCHOOLIN MFNOAEFOKBK, CancellationToken FACMOGNGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x64F76F0", Offset = "0x64F6AF0", VA = "0x1864F76F0")]
	[AsyncStateMachine(typeof(JIBOHPOOKFL))]
	private Task FFGKFAAFLCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x64F7890", Offset = "0x64F6C90", VA = "0x1864F7890")]
	private void GFHNNFNCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x64F7E90", Offset = "0x64F7290", VA = "0x1864F7E90")]
	public LNICAEALGJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class JOGABKMFLJK : DLIBIAHGMJD, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class IDONGALAHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public IDONGALAHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x65124F0", Offset = "0x65118F0", VA = "0x1865124F0")]
		internal object FCKIJCFEDBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class APEHDGNNDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public APEHDGNNDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6505AE0", Offset = "0x6504EE0", VA = "0x186505AE0")]
		internal object PIJLEHBIJDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class PBBMEOFEEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PBBMEOFEEEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class KAJGELMLCDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KAJGELMLCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6514550", Offset = "0x6513950", VA = "0x186514550")]
		internal object MPBDGCFPLOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class ABEHDHAACNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ABEHDHAACNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6503D00", Offset = "0x6503100", VA = "0x186503D00")]
		internal object IOABAJIAJMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, BJOBKFAIHNF> APCFMHOFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan INIGKKCEELP;

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "9")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x65137E0", Offset = "0x6512BE0", VA = "0x1865137E0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6513860", Offset = "0x6512C60", VA = "0x186513860", Slot = "4")]
	public CPEKGGOEKMM FLOHBAGDPJC(Guid BMPBDIBKAJJ)
	{
		return default(CPEKGGOEKMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6513E90", Offset = "0x6513290", VA = "0x186513E90", Slot = "5")]
	public bool NJHEJNEGCKN(Guid BMPBDIBKAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x65140A0", Offset = "0x65134A0", VA = "0x1865140A0", Slot = "6")]
	public bool NOOLMLDCPNF(Guid BMPBDIBKAJJ, Task ODJKFHPAFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6513CB0", Offset = "0x65130B0", VA = "0x186513CB0", Slot = "7")]
	public bool KIPGDHHEMOI(Guid BMPBDIBKAJJ, BMKDPKMMAEO DLLPBDKAPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x65137F0", Offset = "0x6512BF0", VA = "0x1865137F0", Slot = "8")]
	public Task<(BMKDPKMMAEO, Task)> EIAJDBDAKGC(Guid BMPBDIBKAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6513A80", Offset = "0x6512E80", VA = "0x186513A80")]
	private void IFACABPCDKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x65143D0", Offset = "0x65137D0", VA = "0x1865143D0")]
	public JOGABKMFLJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class PJOHMNNNMKG : MAFICDMKOFH, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class DLFHEFECNAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly JGNOMFHEEPM BNPHIKGCHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource MFNNECHIHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken DNFKPHMCMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool NKJJJFOFHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool APMGFBPMLGF;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6509920", Offset = "0x6508D20", VA = "0x186509920")]
		public DLFHEFECNAB(JGNOMFHEEPM BNPHIKGCHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x65097D0", Offset = "0x6508BD0", VA = "0x1865097D0")]
		public void GFHNNFNCFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x65097A0", Offset = "0x6508BA0", VA = "0x1865097A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class HCCDOCAAPIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public OEDOIKAGHHI disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HCCDOCAAPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6511760", Offset = "0x6510B60", VA = "0x186511760")]
		internal object JAGLHENLMOK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct IMPDKELOMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public OEDOIKAGHHI disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public PJOHMNNNMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x65125C0", Offset = "0x65119C0", VA = "0x1865125C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6512970", Offset = "0x6511D70", VA = "0x186512970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class KAMGBLJJBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KAMGBLJJBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x65145B0", Offset = "0x65139B0", VA = "0x1865145B0")]
		internal object ALNDKPAEMHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct HAMAHDCLNEA : IAsyncStateMachine
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
		public PJOHMNNNMKG <>4__this;

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
		private LLMJNNBAAIC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6510010", Offset = "0x650F410", VA = "0x186510010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x90BA80", Offset = "0x90AE80", VA = "0x18090BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class BGMBDGFBFFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public JGNOMFHEEPM newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BGMBDGFBFFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6506190", Offset = "0x6505590", VA = "0x186506190")]
		internal object CKHNJCGADHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6506230", Offset = "0x6505630", VA = "0x186506230")]
		internal object JFHDNKPEGEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6506270", Offset = "0x6505670", VA = "0x186506270")]
		internal object OBNKHIPOFBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class IOBFNHNBLFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public IOBFNHNBLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x65129D0", Offset = "0x6511DD0", VA = "0x1865129D0")]
		internal void OHEEIGOLCLD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct AMKJOGFMGII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public JGNOMFHEEPM newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public PJOHMNNNMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public CDPPOHKMOJI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private BGMBDGFBFFM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LLMJNNBAAIC <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x65046E0", Offset = "0x6503AE0", VA = "0x1865046E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6505660", Offset = "0x6504A60", VA = "0x186505660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ANPAEEIEHHB.EKAENHLECFB LAMPHKEGOGN;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly JDBIDOOACAJ FIEIMAFBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private FODOAKFANLM PPDPJNGKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private CHLDIKJAHMF AFCMMENFPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private PPBNKAOBJNC IEOEELMKLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private PDNOLCFPIDI JJFLHNONCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long BMIAAJBJFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private DLFHEFECNAB CEDHJNAJHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool LIICPOHLOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task ILMKLPGOMAJ;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6520F70", Offset = "0x6520370", VA = "0x186520F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool GMFCJBDFLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xCD30A0", Offset = "0xCD24A0", VA = "0x180CD30A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6520830", Offset = "0x651FC30", VA = "0x186520830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6520FC0", Offset = "0x65203C0", VA = "0x186520FC0", Slot = "4")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6520840", Offset = "0x651FC40", VA = "0x186520840", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6520E80", Offset = "0x6520280", VA = "0x186520E80")]
	[AsyncStateMachine(typeof(IMPDKELOMCB))]
	private Task KAELDJGLENF(OEDOIKAGHHI GEAHGOFOLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6521260", Offset = "0x6520660", VA = "0x186521260")]
	private void OFNBLFFBLFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6520B30", Offset = "0x651FF30", VA = "0x186520B30")]
	private void EOBMLBKCAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x65209B0", Offset = "0x651FDB0", VA = "0x1865209B0")]
	private void EKDBEGNKMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6520E10", Offset = "0x6520210", VA = "0x186520E10")]
	private bool IEMOLJBHFEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6520630", Offset = "0x651FA30", VA = "0x186520630")]
	[AsyncStateMachine(typeof(HAMAHDCLNEA))]
	private void AEDBEFDFPGE(int DKPDOFNCECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6521400", Offset = "0x6520800", VA = "0x186521400")]
	private void OIDBOELCCBE([Out] IDisposable CEHFBALKFJB, [Out] IDisposable AJDPEJAOONN, [Out] IDisposable BMDNKLPOBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6520CC0", Offset = "0x65200C0", VA = "0x186520CC0")]
	private bool FAIIEGPHGJO(JGNOMFHEEPM BNPHIKGCHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6520DC0", Offset = "0x65201C0", VA = "0x186520DC0")]
	private void HCOCEAKCONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6520700", Offset = "0x651FB00", VA = "0x186520700")]
	[AsyncStateMachine(typeof(AMKJOGFMGII))]
	private Task AMAMKGBFPHO(JGNOMFHEEPM BNPHIKGCHLM, CDPPOHKMOJI EHCNHMCCJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6521A60", Offset = "0x6520E60", VA = "0x186521A60")]
	public PJOHMNNNMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class EBBLGCNLHJM : CCBLPCLCEIE, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct COFGCLOHEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<EAMJNAFBIOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public EBBLGCNLHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<EAMJNAFBIOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x65083E0", Offset = "0x65077E0", VA = "0x1865083E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6508670", Offset = "0x6507A70", VA = "0x186508670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MOBPBDMOBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public FABBKACGCKD message;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MOBPBDMOBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6519E70", Offset = "0x6519270", VA = "0x186519E70")]
		internal object NJJFBHFLEDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class PMLAFKFIFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public FABBKACGCKD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PMLAFKFIFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6521AD0", Offset = "0x6520ED0", VA = "0x186521AD0")]
		internal object PLAEDOBMMJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class JPBAKKKEECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JPBAKKKEECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x65144F0", Offset = "0x65138F0", VA = "0x1865144F0")]
		internal object EFAOJNECKPK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct DGPOFFJMEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public EBBLGCNLHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<MDFBCIKEPAJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6508D20", Offset = "0x6508120", VA = "0x186508D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x65095E0", Offset = "0x65089E0", VA = "0x1865095E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class NCKMGEKALCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public FABBKACGCKD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NCKMGEKALCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x651AEA0", Offset = "0x651A2A0", VA = "0x18651AEA0")]
		internal object KOIKDGFNHGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct MEDNJCBHFLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public FABBKACGCKD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public EBBLGCNLHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private IKLJEDJKANM <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6517DD0", Offset = "0x65171D0", VA = "0x186517DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6518940", Offset = "0x6517D40", VA = "0x186518940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct ONIKOCCANAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<MDFBCIKEPAJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public EBBLGCNLHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private PIJLMPCONDK.NFMBFNIOEFD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IKLJEDJKANM <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x651E3B0", Offset = "0x651D7B0", VA = "0x18651E3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x651E8D0", Offset = "0x651DCD0", VA = "0x18651E8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class BOLHEEGPKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public MDFBCIKEPAJ operation;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BOLHEEGPKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6506600", Offset = "0x6505A00", VA = "0x186506600")]
		internal object DEJOLHOKHJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct KGBOKGDBEJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public MDFBCIKEPAJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public EBBLGCNLHJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private NKOLFLIKMKN<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6514620", Offset = "0x6513A20", VA = "0x186514620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6514C60", Offset = "0x6514060", VA = "0x186514C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class JOLLAMHGDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JOLLAMHGDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6514490", Offset = "0x6513890", VA = "0x186514490")]
		internal object OLGFMHHHPGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class JJNKGHBHDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JJNKGHBHDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6513670", Offset = "0x6512A70", VA = "0x186513670")]
		internal object LCPKBPDFMPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private PIHFPLMIMEJ PHKDJCBLPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private JCKLHJNBJGM DKMEDHIHGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private KJJCNAFJBJL AJGCBIEKBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<EAMJNAFBIOM> LFAKLIKLLBG;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x650ACF0", Offset = "0x650A0F0", VA = "0x18650ACF0", Slot = "7")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x650A730", Offset = "0x6509B30", VA = "0x18650A730", Slot = "6")]
	[AsyncStateMachine(typeof(COFGCLOHEDJ))]
	public Task<EAMJNAFBIOM> IOFCCCAEPIB(CancellationToken JEPJDLKNMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x650ADE0", Offset = "0x650A1E0", VA = "0x18650ADE0", Slot = "4")]
	public void PIFGEKFJEMO(FABBKACGCKD DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6509ED0", Offset = "0x65092D0", VA = "0x186509ED0", Slot = "5")]
	public void DGGIFCEANNI(FABBKACGCKD KFCKONKMFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6509DC0", Offset = "0x65091C0", VA = "0x186509DC0")]
	[AsyncStateMachine(typeof(DGPOFFJMEGO))]
	private Task CGPHFGJOLDP(FABBKACGCKD NCCHHGAPAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x650A410", Offset = "0x6509810", VA = "0x18650A410")]
	[AsyncStateMachine(typeof(MEDNJCBHFLC))]
	private Task GHBBPJCAKPN(FABBKACGCKD GNEFLJBEFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x650A230", Offset = "0x6509630", VA = "0x18650A230")]
	[AsyncStateMachine(typeof(ONIKOCCANAE))]
	private Task<MDFBCIKEPAJ> EPDAKCBLCFA(FABBKACGCKD NCCHHGAPAOP, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x650A380", Offset = "0x6509780", VA = "0x18650A380")]
	private IKLJEDJKANM FEGCHEFOHGA(FABBKACGCKD HGNDFIBADEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x650A840", Offset = "0x6509C40", VA = "0x18650A840")]
	[AsyncStateMachine(typeof(KGBOKGDBEJP))]
	private Task KBKLOMIHJLJ(MDFBCIKEPAJ EHEFAPJMEBE, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x650A520", Offset = "0x6509920", VA = "0x18650A520")]
	private MDFBCIKEPAJ HGNPFPMCEEL(FABBKACGCKD NCCHHGAPAOP, IKLJEDJKANM AOGCBHMFIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2501C70", Offset = "0x2501070", VA = "0x182501C70")]
	private T MPKONLDIMJB<T>(T FDFHGIHHGHO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x650A960", Offset = "0x6509D60", VA = "0x18650A960")]
	private MDFBCIKEPAJ KPJJDLILGDI(FABBKACGCKD NCCHHGAPAOP, IKLJEDJKANM AOGCBHMFIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EBBLGCNLHJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class LANEPOLHHGC : JCKLHJNBJGM, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class CELBPANBNKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CELBPANBNKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6507610", Offset = "0x6506A10", VA = "0x186507610")]
		internal object MJPGEEELCAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class HNPAPIMPEHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HNPAPIMPEHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6511FB0", Offset = "0x65113B0", VA = "0x186511FB0")]
		internal object DHNBAIEIEEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private LJKCNOFNJHN MDNDGOJLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private CCBLPCLCEIE IAJBCBKDLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private DLIBIAHGMJD APCFMHOFDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private AGDBEEDABKA MBIIIDCAPGC;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6516B30", Offset = "0x6515F30", VA = "0x186516B30", Slot = "6")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6515E10", Offset = "0x6515210", VA = "0x186515E10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6517020", Offset = "0x6516420", VA = "0x186517020", Slot = "4")]
	public CPEKGGOEKMM OIOKIKIOMCC(FABBKACGCKD ILMOKKBCFDB)
	{
		return default(CPEKGGOEKMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6515660", Offset = "0x6514A60", VA = "0x186515660", Slot = "5")]
	public void DFDPIPKHOMF(Guid BMPBDIBKAJJ, Task ODJKFHPAFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6516CA0", Offset = "0x65160A0", VA = "0x186516CA0")]
	private void NKCEEFLHMGC(byte ENGLJHKCIBM, int CLELCJOIPLD, object KIHLKAFECCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6515870", Offset = "0x6514C70", VA = "0x186515870")]
	private void DFFFOJNFJED(CBEMNAGLAEC IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6516310", Offset = "0x6515710", VA = "0x186516310")]
	private void JNEONCIBMKE(CBEMNAGLAEC IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6515EC0", Offset = "0x65152C0", VA = "0x186515EC0")]
	private void FFAMKDIBKPO(CBEMNAGLAEC IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6515420", Offset = "0x6514820", VA = "0x186515420")]
	private BMKDPKMMAEO CGOFHDOGPPE(FABBKACGCKD HGNDFIBADEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6516100", Offset = "0x6515500", VA = "0x186516100")]
	private void IABEEAHJGAO(FABBKACGCKD GNEFLJBEFMB, BMKDPKMMAEO DLLPBDKAPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6516D70", Offset = "0x6516170", VA = "0x186516D70")]
	private bool NNMHILEMFBH(FABBKACGCKD GNEFLJBEFMB, BMKDPKMMAEO DLLPBDKAPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6516620", Offset = "0x6515A20", VA = "0x186516620")]
	private bool KICJLDNJFMG(FABBKACGCKD NEEKHNHMIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65168A0", Offset = "0x6515CA0", VA = "0x1865168A0")]
	private bool KPKONLBFDKC(byte ENGLJHKCIBM, ExitGames.Client.Photon.Hashtable IPMJBCBKLKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LANEPOLHHGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class CJECPEEPKJA : BHKAGBPEGBB, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class FLIACFDAAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public EAMJNAFBIOM operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public CJECPEEPKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public FABBKACGCKD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public FLIACFDAAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x650D9E0", Offset = "0x650CDE0", VA = "0x18650D9E0")]
		internal object BLOGKMLIEDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x650D8B0", Offset = "0x650CCB0", VA = "0x18650D8B0")]
		internal object AFJNOOPDBEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct EEOHEGMBEOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public CJECPEEPKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public FABBKACGCKD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<BMKDPKMMAEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x650B170", Offset = "0x650A570", VA = "0x18650B170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x650B800", Offset = "0x650AC00", VA = "0x18650B800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class ILMPCCCDIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public EAMJNAFBIOM operationType;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ILMPCCCDIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6512550", Offset = "0x6511950", VA = "0x186512550")]
		internal object IHAHJFFCAGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class KLJIMLILNGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KLJIMLILNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6514DF0", Offset = "0x65141F0", VA = "0x186514DF0")]
		internal object AINNEMMJMGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6514E60", Offset = "0x6514260", VA = "0x186514E60")]
		internal object GEOIJPHAJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6514ED0", Offset = "0x65142D0", VA = "0x186514ED0")]
		internal object NMPCPALAHPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct PFDAHDHEMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public CJECPEEPKJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private KLJIMLILNGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private CPEKGGOEKMM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private BMKDPKMMAEO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(BMKDPKMMAEO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x651F270", Offset = "0x651E670", VA = "0x18651F270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x651FB20", Offset = "0x651EF20", VA = "0x18651FB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private LJKCNOFNJHN MDNDGOJLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private JCKLHJNBJGM DKMEDHIHGMK;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65079B0", Offset = "0x6506DB0", VA = "0x1865079B0", Slot = "5")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6507A60", Offset = "0x6506E60", VA = "0x186507A60", Slot = "4")]
	[AsyncStateMachine(typeof(EEOHEGMBEOC))]
	private Task<BMKDPKMMAEO> PJMHAKBKIKP(FABBKACGCKD HGNDFIBADEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6507680", Offset = "0x6506A80", VA = "0x186507680")]
	private bool LADODOHNPHP(EAMJNAFBIOM CMJHHBGCABN, [Out] BMKDPKMMAEO MNKBHKEBOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6507870", Offset = "0x6506C70", VA = "0x186507870")]
	[AsyncStateMachine(typeof(PFDAHDHEMKO))]
	private Task<BMKDPKMMAEO> NECNPIEEHOC(FABBKACGCKD NCCHHGAPAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public CJECPEEPKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class MIBEANDCPKL : LMFMLKBIFFO, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct PHCEMJEGGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<DNPPEJGLHLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public MIBEANDCPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<KLIMJDPIFED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6520110", Offset = "0x651F510", VA = "0x186520110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x65205C0", Offset = "0x651F9C0", VA = "0x1865205C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class KGIOINEHJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KGIOINEHJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6514CC0", Offset = "0x65140C0", VA = "0x186514CC0")]
		internal object LKDOCBCABIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct EMLACGLFDBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<KLIMJDPIFED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public MIBEANDCPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JGNOMFHEEPM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private KGIOINEHJMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<KLIMJDPIFED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x650B870", Offset = "0x650AC70", VA = "0x18650B870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x650BE60", Offset = "0x650B260", VA = "0x18650BE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class KKOOEBOPEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KKOOEBOPEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1408020", Offset = "0x1407420", VA = "0x181408020")]
		internal bool ENPGJMGAHHL(KFLDBIMKFED sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (IODJBGDFNFE superRoomData, long subRoomDataSaveId) DKGPMLNHPIG;

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6519650", Offset = "0x6518A50", VA = "0x186519650", Slot = "5")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6519390", Offset = "0x6518790", VA = "0x186519390", Slot = "4")]
	[AsyncStateMachine(typeof(PHCEMJEGGMA))]
	public Task<DNPPEJGLHLI> BABJCJJDBEH(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, JGNOMFHEEPM HEFPGKMBKEC, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x65194F0", Offset = "0x65188F0", VA = "0x1865194F0")]
	[AsyncStateMachine(typeof(EMLACGLFDBM))]
	private Task<KLIMJDPIFED> GAOPKFAHEOO(JGNOMFHEEPM HEFPGKMBKEC, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6519A00", Offset = "0x6518E00", VA = "0x186519A00")]
	private DNPPEJGLHLI PJFELEEPCCN(JGNOMFHEEPM HEFPGKMBKEC, KLIMJDPIFED APNFAAKEKHN, long JNIJNNCDCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x65196C0", Offset = "0x6518AC0", VA = "0x1865196C0")]
	private (IODJBGDFNFE, long) OPFAIIJENOD(JGNOMFHEEPM HEFPGKMBKEC, KLIMJDPIFED APNFAAKEKHN, long JNIJNNCDCAA)
	{
		return default((IODJBGDFNFE, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MIBEANDCPKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class GCCHDIMMMFH : KJJCNAFJBJL, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class JCPJLAFNAPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JCPJLAFNAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6512A70", Offset = "0x6511E70", VA = "0x186512A70")]
		internal object LCOIOLNILCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct HFIBJBADGMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public GCCHDIMMMFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public IKLJEDJKANM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6511850", Offset = "0x6510C50", VA = "0x186511850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6511E60", Offset = "0x6511260", VA = "0x186511E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct FGKEGCEDIGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public GCCHDIMMMFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public IKLJEDJKANM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<OJJNPODKOJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x650D240", Offset = "0x650C640", VA = "0x18650D240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x650D840", Offset = "0x650CC40", VA = "0x18650D840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class OBMIKAGKJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public OBMIKAGKJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x651D3B0", Offset = "0x651C7B0", VA = "0x18651D3B0")]
		internal object JDLGNFMKOEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct FONACKBCEEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public FABBKACGCKD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public GCCHDIMMMFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public IKLJEDJKANM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private AAPBFAPMONC <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private DCHPHELDGHI <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<OJJNPODKOJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x650DA50", Offset = "0x650CE50", VA = "0x18650DA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x650E640", Offset = "0x650DA40", VA = "0x18650E640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private IEKBMIEDBGH EAEMBPNMENA;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private JMENELMHCNB ACOAJDKOPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x650E960", Offset = "0x650DD60", VA = "0x18650E960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x650EFC0", Offset = "0x650E3C0", VA = "0x18650EFC0", Slot = "8")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x650EE60", Offset = "0x650E260", VA = "0x18650EE60", Slot = "4")]
	[AsyncStateMachine(typeof(HFIBJBADGMI))]
	public Task<FABBKACGCKD> LLPOAMIAKNE(FABBKACGCKD NCCHHGAPAOP, IKLJEDJKANM AOGCBHMFIGD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x650E6B0", Offset = "0x650DAB0", VA = "0x18650E6B0", Slot = "5")]
	[AsyncStateMachine(typeof(FGKEGCEDIGD))]
	public Task<FABBKACGCKD> AEDONFBFAID(CancellationToken HNLFPBLPOKJ, IKLJEDJKANM AOGCBHMFIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x650EA20", Offset = "0x650DE20", VA = "0x18650EA20", Slot = "6")]
	public ENAELKBIJPI GCNEFEHAGMH(MDFBCIKEPAJ LAEANMKOMEC, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x650EC30", Offset = "0x650E030", VA = "0x18650EC30", Slot = "7")]
	public ENAELKBIJPI HEIMJEPNLCC(MDFBCIKEPAJ LAEANMKOMEC, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x650E800", Offset = "0x650DC00", VA = "0x18650E800")]
	[AsyncStateMachine(typeof(FONACKBCEEE))]
	private Task<FABBKACGCKD> BPKCHFLLBGD(FABBKACGCKD NCCHHGAPAOP, IKLJEDJKANM AOGCBHMFIGD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x25103E0", Offset = "0x250F7E0", VA = "0x1825103E0")]
	private static byte[] FMDCJJLHLCK(FABBKACGCKD DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GCCHDIMMMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class GNBMHJHPAFI : LJKCNOFNJHN, PCEOOIMJOPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private HCICBFGHMPB MNFKJAIKCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private PIHFPLMIMEJ PHKDJCBLPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private BCAPBKOMKNJ OKMJHGDBCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private PDNOLCFPIDI JJFLHNONCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private HPGHAPKGCLE MJJNIEOODNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private PPBNKAOBJNC IEOEELMKLEO;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x650FDF0", Offset = "0x650F1F0", VA = "0x18650FDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private static BMKDPKMMAEO JGPFJIGBAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x650FFB0", Offset = "0x650F3B0", VA = "0x18650FFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x650FE40", Offset = "0x650F240", VA = "0x18650FE40", Slot = "6")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x650FC80", Offset = "0x650F080", VA = "0x18650FC80", Slot = "4")]
	public BMKDPKMMAEO GGCCGKPIEHE(PFJNLKLKGNM JCCGLLCNOMF, EAMJNAFBIOM PDAIHKFBCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x650F920", Offset = "0x650ED20", VA = "0x18650F920", Slot = "5")]
	public BMKDPKMMAEO AJBBPEJHHLJ(PFJNLKLKGNM BHAADNJFDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x650FC20", Offset = "0x650F020", VA = "0x18650FC20")]
	private static BMKDPKMMAEO GDCEFEHKHCN(ONILDAPJMOO LCAIGDLPJAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GNBMHJHPAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class DKHBGIMDNIC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6509760", Offset = "0x6508B60", VA = "0x186509760")]
	public DKHBGIMDNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5ADEAC0", Offset = "0x5ADDEC0", VA = "0x185ADEAC0")]
	public DKHBGIMDNIC(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class NANKBIOKEBO : KLHLLMBIODH, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct CBFCOENLIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public NANKBIOKEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public KNCFAMOEPME autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private NKOLFLIKMKN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private PMNEPKMEAHO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<BMKDPKMMAEO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6506A10", Offset = "0x6505E10", VA = "0x186506A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x65075A0", Offset = "0x65069A0", VA = "0x1865075A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct MFGMFMMADIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public NANKBIOKEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x65189A0", Offset = "0x6517DA0", VA = "0x1865189A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x65190F0", Offset = "0x65184F0", VA = "0x1865190F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct BCAKOMAANBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public NANKBIOKEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6505B40", Offset = "0x6504F40", VA = "0x186505B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6506050", Offset = "0x6505450", VA = "0x186506050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct GDIMOBIPIND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public NANKBIOKEBO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x650F170", Offset = "0x650E570", VA = "0x18650F170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x650F8C0", Offset = "0x650ECC0", VA = "0x18650F8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct DDNAHNJJGDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public NANKBIOKEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x65086E0", Offset = "0x6507AE0", VA = "0x1865086E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6508880", Offset = "0x6507C80", VA = "0x186508880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct NGIOKEEFOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public NANKBIOKEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x651AF00", Offset = "0x651A300", VA = "0x18651AF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x651B620", Offset = "0x651AA20", VA = "0x18651B620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct ICNJEBPDMEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NANKBIOKEBO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6512020", Offset = "0x6511420", VA = "0x186512020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6512490", Offset = "0x6511890", VA = "0x186512490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct LJBBEHAIMHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NANKBIOKEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AMIIJBBMGIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NKOLFLIKMKN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6517680", Offset = "0x6516A80", VA = "0x186517680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6517BC0", Offset = "0x6516FC0", VA = "0x186517BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private CPGICIMPCNG EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private KJJCNAFJBJL AJGCBIEKBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private PIHFPLMIMEJ PHKDJCBLPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private HPGHAPKGCLE MJJNIEOODNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource CHNIKGGOJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task MBFLPNMBFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> JOFLIJOMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int CCMABAIMCMN;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x651ACC0", Offset = "0x651A0C0", VA = "0x18651ACC0", Slot = "6")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x889180", Offset = "0x888580", VA = "0x180889180", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x651A0B0", Offset = "0x65194B0", VA = "0x18651A0B0")]
	private void CFOFDCAIEAB(float PHEMHABEGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x651A600", Offset = "0x6519A00", VA = "0x18651A600", Slot = "4")]
	[AsyncStateMachine(typeof(CBFCOENLIMM))]
	public Task<BMKDPKMMAEO> INLMGFBECLN(KNCFAMOEPME JLHNEGAACPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x651A190", Offset = "0x6519590", VA = "0x18651A190", Slot = "5")]
	[AsyncStateMachine(typeof(MFGMFMMADIL))]
	public Task CLOKDOMOJNP([Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x889180", Offset = "0x888580", VA = "0x180889180")]
	public void FMFBPMICLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x651A280", Offset = "0x6519680", VA = "0x18651A280")]
	private PMNEPKMEAHO GBOLCLPBCMD(KNCFAMOEPME JLHNEGAACPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6519ED0", Offset = "0x65192D0", VA = "0x186519ED0")]
	[AsyncStateMachine(typeof(BCAKOMAANBC))]
	private Task AGFFKNBKBOE(DCOJCHOOLIN JHEMNDMHNOB, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x651A3F0", Offset = "0x65197F0", VA = "0x18651A3F0")]
	[AsyncStateMachine(typeof(GDIMOBIPIND))]
	private Task IDNAMJEBDDA(CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6519FC0", Offset = "0x65193C0", VA = "0x186519FC0")]
	[AsyncStateMachine(typeof(DDNAHNJJGDO))]
	private Task AOEDJBFCCCD([Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x651ABD0", Offset = "0x6519FD0", VA = "0x18651ABD0")]
	[AsyncStateMachine(typeof(NGIOKEEFOIL))]
	private Task NDJBEJODJKF(CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x651A840", Offset = "0x6519C40", VA = "0x18651A840")]
	[AsyncStateMachine(typeof(ICNJEBPDMEB))]
	private Task KBOEGEBKNKI(CancellationToken ADHLGLPKLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x651A940", Offset = "0x6519D40", VA = "0x18651A940")]
	private Task LJEADBDFLKM(AMIIJBBMGIJ NHAAHCFFLBH, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x651A730", Offset = "0x6519B30", VA = "0x18651A730")]
	[AsyncStateMachine(typeof(LJBBEHAIMHK))]
	private Task IPOGADBGKIM(AMIIJBBMGIJ NHAAHCFFLBH, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x651A4F0", Offset = "0x65198F0", VA = "0x18651A4F0")]
	private bool ILHFGAICEKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public NANKBIOKEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class PGMPHHMAMED : BCAPBKOMKNJ, PCEOOIMJOPC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct HCANNJKFCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public PGMPHHMAMED <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private NKOLFLIKMKN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x65111A0", Offset = "0x65105A0", VA = "0x1865111A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6511700", Offset = "0x6510B00", VA = "0x186511700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private NEPMMMPOKOK LEBHIAFBMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private LJKCNOFNJHN MDNDGOJLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private KJJCNAFJBJL AJGCBIEKBJJ;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x651FD30", Offset = "0x651F130", VA = "0x18651FD30", Slot = "6")]
	public void NGFHLNOOHDK(DGDKDOCHPEF HMDOIKIDPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x651FB90", Offset = "0x651EF90", VA = "0x18651FB90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6520010", Offset = "0x651F410", VA = "0x186520010", Slot = "5")]
	[AsyncStateMachine(typeof(HCANNJKFCEP))]
	public Task ODBIALOBEMN(string KGIHKOADMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x651FCD0", Offset = "0x651F0D0", VA = "0x18651FCD0", Slot = "4")]
	public BMKDPKMMAEO ILHFGAICEKC(PFJNLKLKGNM JCCGLLCNOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x651FBE0", Offset = "0x651EFE0", VA = "0x18651FBE0")]
	private PIPKGCEEODP FEOCMHMJMEO(string KGIHKOADMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PGMPHHMAMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class PDKKEGCCJIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x651F030", Offset = "0x651E430", VA = "0x18651F030")]
	public static void PJLJDKJAJDP(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x651EDF0", Offset = "0x651E1F0", VA = "0x18651EDF0")]
	internal static void NIDDNFGKPLG(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x651EF50", Offset = "0x651E350", VA = "0x18651EF50")]
	internal static void NNMPGOGMEAE(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x651E9A0", Offset = "0x651DDA0", VA = "0x18651E9A0")]
	internal static void DHNPEMNBOBN(BHJKECHLECD CHBOBHMMJGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class JIEOGLCCPGM : FKNAJJLKKBL<FABBKACGCKD>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class BJJCJBCOJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public FABBKACGCKD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BJJCJBCOJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x65062B0", Offset = "0x65056B0", VA = "0x1865062B0")]
		internal object ACALOJOOEKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly JIEOGLCCPGM MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6513260", Offset = "0x6512660", VA = "0x186513260")]
	public ExitGames.Client.Photon.Hashtable LENOCDGJGPN(FABBKACGCKD DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6513130", Offset = "0x6512530", VA = "0x186513130", Slot = "5")]
	protected override void BNDNEJKHLJM(FABBKACGCKD DCKDMGKGDFN, IDictionary<object, object> MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6512DF0", Offset = "0x65121F0", VA = "0x186512DF0", Slot = "6")]
	public override FABBKACGCKD AFFCBAMFOKP(IDictionary<object, object> MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6513020", Offset = "0x6512420", VA = "0x186513020")]
	private static void BDAJDFAFKKC(string MCNEHMIONKA, FABBKACGCKD DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6513630", Offset = "0x6512A30", VA = "0x186513630")]
	public JIEOGLCCPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x65132F0", Offset = "0x65126F0", VA = "0x1865132F0")]
	[CompilerGenerated]
	internal static string MGFCFAIEJLO(DNPPEJGLHLI MBIDFLHPHHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class KPJMGJJLCOL
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public static BMKDPKMMAEO JGPFJIGBAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x650FFB0", Offset = "0x650F3B0", VA = "0x18650FFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6515400", Offset = "0x6514800", VA = "0x186515400")]
	public static bool GJNFFCNNCCH(this BMKDPKMMAEO DLLPBDKAPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x650FC20", Offset = "0x650F020", VA = "0x18650FC20")]
	public static BMKDPKMMAEO GDCEFEHKHCN(ONILDAPJMOO AKLAEAPABKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6515200", Offset = "0x6514600", VA = "0x186515200")]
	public static BMKDPKMMAEO FPCGJFFGCBB(IEnumerable<BMKDPKMMAEO> MFOPJHBLLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6514FA0", Offset = "0x65143A0", VA = "0x186514FA0")]
	public static string FDDFBOGGDAD(this BMKDPKMMAEO MNKBHKEBOPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class DGMAHNELBPO : DAJAPKCADJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate BMKDPKMMAEO CMLJNCHJJAD([NotNull] PFJNLKLKGNM EIAHOOJKLKL);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class AAJPFIKEPPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public PFJNLKLKGNM photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AAJPFIKEPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC35C0", Offset = "0x5CC29C0", VA = "0x185CC35C0")]
		internal BMKDPKMMAEO EHPDINIEEAA(CMLJNCHJJAD v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<CMLJNCHJJAD> DMGADHDDCMB;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65088E0", Offset = "0x6507CE0", VA = "0x1865088E0", Slot = "4")]
	public void DPGCGNMHNJM(CMLJNCHJJAD NJIFKEMHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6508990", Offset = "0x6507D90", VA = "0x186508990", Slot = "5")]
	public void NJEJDLODGOC(CMLJNCHJJAD NJIFKEMHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6508940", Offset = "0x6507D40", VA = "0x186508940", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x65089F0", Offset = "0x6507DF0", VA = "0x1865089F0")]
	protected BMKDPKMMAEO OJAFKEGANJO(PFJNLKLKGNM BHAADNJFDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6508C90", Offset = "0x6508090", VA = "0x186508C90")]
	protected DGMAHNELBPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class JMEHEMAMCEO : DGMAHNELBPO, HCICBFGHMPB, DAJAPKCADJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class KOGAGEDJPAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public BMKDPKMMAEO result;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KOGAGEDJPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x6514F40", Offset = "0x6514340", VA = "0x186514F40")]
		internal object ENIABKDFNOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x650F160", Offset = "0x650E560", VA = "0x18650F160")]
	[UnityEngine.Scripting.Preserve]
	public JMEHEMAMCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x65136D0", Offset = "0x6512AD0", VA = "0x1865136D0", Slot = "8")]
	public BMKDPKMMAEO CEEMDHOOPID(PFJNLKLKGNM BHAADNJFDOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class GDIJBFGHGEA : DGMAHNELBPO, NEPMMMPOKOK, DAJAPKCADJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class PBNGCNKMKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public BMKDPKMMAEO result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PBNGCNKMKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x651E940", Offset = "0x651DD40", VA = "0x18651E940")]
		internal object MDBFPEINDBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x650F160", Offset = "0x650E560", VA = "0x18650F160")]
	[UnityEngine.Scripting.Preserve]
	public GDIJBFGHGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x650F050", Offset = "0x650E450", VA = "0x18650F050", Slot = "8")]
	public BMKDPKMMAEO ILHFGAICEKC(PFJNLKLKGNM MGJLCIFAFPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class MNLIGOBGFFK
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class KILFCJFEOMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public NKOLFLIKMKN<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KILFCJFEOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6514D70", Offset = "0x6514170", VA = "0x186514D70")]
		internal object EBODILFNPMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6519C10", Offset = "0x6519010", VA = "0x186519C10")]
	public static NKOLFLIKMKN<string> AIKEPPCCMFF(AMCJMMGFCLE HILPECKCPNP, [Optional] string EAHDAFDPDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6519CF0", Offset = "0x65190F0", VA = "0x186519CF0")]
	public static void MDGGMBJDJCK(NKOLFLIKMKN<string> CBPCKBLKEKD, AMCJMMGFCLE HILPECKCPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6519DB0", Offset = "0x65191B0", VA = "0x186519DB0")]
	public static string MKLOHHGHNPE(FABBKACGCKD HGNDFIBADEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class MEDGABAHBBP
{
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6517DC0", Offset = "0x65171C0", VA = "0x186517DC0")]
	public static void PJMAPNAFBOF(this CPGICIMPCNG EEMFDHBKBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6517DB0", Offset = "0x65171B0", VA = "0x186517DB0")]
	public static void OJIKHIFCIFN(this CPGICIMPCNG EEMFDHBKBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6517C90", Offset = "0x6517090", VA = "0x186517C90")]
	private static void LKHFDDKBOBC(this CPGICIMPCNG EEMFDHBKBKN, bool HCILFGPINMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class NMDJAMDALKB : KNFNDFFCOHE, KDMFJHLLNIE, OKOADGKOHLH, CIPCPHCNNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly KDMFJHLLNIE GHCBPPLLINL;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PFJNLKLKGNM FBGNALHLIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x651D190", Offset = "0x651C590", VA = "0x18651D190", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int IOCNBFNKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x651D0F0", Offset = "0x651C4F0", VA = "0x18651D0F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int OIGHKGINDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x651D140", Offset = "0x651C540", VA = "0x18651D140", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool ALPDAJOBFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int EEGIDFALGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event AHLGJACBMIN.MJEBHMLIHKA NCOGEBDLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FLEKJGBAIPK BEKGEMCOGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x651CF00", Offset = "0x651C300", VA = "0x18651CF00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x651CE60", Offset = "0x651C260", VA = "0x18651CE60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> CFFGGJAACLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<PFJNLKLKGNM> IMCIKNMPIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action ELBKOAALIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x651D2C0", Offset = "0x651C6C0", VA = "0x18651D2C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x651D050", Offset = "0x651C450", VA = "0x18651D050", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xCC6B00", Offset = "0xCC5F00", VA = "0x180CC6B00")]
	public NMDJAMDALKB(KDMFJHLLNIE GHCBPPLLINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x651CFA0", Offset = "0x651C3A0", VA = "0x18651CFA0", Slot = "8")]
	public bool IFBGMJDMFNF(byte ENGLJHKCIBM, ExitGames.Client.Photon.Hashtable LLFOEJOBLCC, LNGOGAAGNEM ANJAFKLAGGO, SendOptions KNLEOMHELJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x651D1E0", Offset = "0x651C5E0", VA = "0x18651D1E0", Slot = "16")]
	public PFJNLKLKGNM NHFMOFAEEHH(int BLJINDOMGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "19")]
	public void BIHIONLCAHF(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "20")]
	public void BBDKLJGEBBK(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "21")]
	public void FHEJDOJLPAM(object FACMOGNGACN, bool FEMNBAGCEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x651D360", Offset = "0x651C760", VA = "0x18651D360", Slot = "22")]
	public IDisposable PHANNBIJCHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "23")]
	private bool MNPBGJIBCEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "24")]
	public void OIIPCAPKAOK(StringBuilder MDFHKACLOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x651CE40", Offset = "0x651C240", VA = "0x18651CE40", Slot = "25")]
	public bool AOBMMJKIBAG(bool JKHMCBJJGAG, [Out] string JKDHCOHJJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xB8DEA0", Offset = "0xB8D2A0", VA = "0x180B8DEA0", Slot = "28")]
	public void ELFCPPNJBHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct CBEMNAGLAEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> IPMJBCBKLKO;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	public CBEMNAGLAEC(IDictionary<object, object> IPMJBCBKLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6506680", Offset = "0x6505A80", VA = "0x186506680")]
	public bool BEIFCBOEIMD([Out] FABBKACGCKD DCKDMGKGDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6506730", Offset = "0x6505B30", VA = "0x186506730")]
	public Guid MGABDGLAMCK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65067E0", Offset = "0x6505BE0", VA = "0x1865067E0")]
	public BMKDPKMMAEO MHHJPFJPOMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6506920", Offset = "0x6505D20", VA = "0x186506920")]
	public static ExitGames.Client.Photon.Hashtable NDFPICIGPEG(FABBKACGCKD DCKDMGKGDFN, BMKDPKMMAEO DLLPBDKAPOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class NKCNMHHJCLA
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x651CDC0", Offset = "0x651C1C0", VA = "0x18651CDC0")]
	public static bool NINAPFELNBJ(this JGNOMFHEEPM BIAPCBFJHDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct CLFAIEHFMNB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct MGBKMLEBIGC : IAsyncStateMachine
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
		public CLFAIEHFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6519150", Offset = "0x6518550", VA = "0x186519150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6519330", Offset = "0x6518730", VA = "0x186519330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource MFNNECHIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task CKAKCFLCDJK;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LIEFAHOJBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6507BD0", Offset = "0x6506FD0", VA = "0x186507BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6507D10", Offset = "0x6507110", VA = "0x186507D10")]
	public CLFAIEHFMNB(CancellationToken HNLFPBLPOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6507C00", Offset = "0x6507000", VA = "0x186507C00")]
	[AsyncStateMachine(typeof(MGBKMLEBIGC))]
	public Task OPMJFHKPDLA(Func<CancellationToken, List<Task>> IEBCOABNEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6507B80", Offset = "0x6506F80", VA = "0x186507B80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct LMFGFFJLHFK<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct BOANDAKOLPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<MKCMBBHNGLH<TData>, NOJMEPFJKIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public LMFGFFJLHFK<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<KKHLNMGODKL<byte[], NOJMEPFJKIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x4627BC0", Offset = "0x4626FC0", VA = "0x184627BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x4628C80", Offset = "0x4628080", VA = "0x184628C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly BELAJFDOOBL<TGetDataArg, TData> KAIABCGDPPN;

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	internal LMFGFFJLHFK(BELAJFDOOBL<TGetDataArg, TData> NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B6ED60", Offset = "0x3B6E160", VA = "0x183B6ED60")]
	[AsyncStateMachine(typeof(LMFGFFJLHFK<, >.BOANDAKOLPI))]
	public Task<KKHLNMGODKL<MKCMBBHNGLH<TData>, NOJMEPFJKIM>> JDJCJDPIDPC(TGetDataArg OEJAGOPNKOK, string DIKKFKPFOLG, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class BPGGMJICIOG
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x243E560", Offset = "0x243D960", VA = "0x18243E560")]
	public static LMFGFFJLHFK<TGetDataArg, TData> JKJFENIAMEL<TGetDataArg, TData>(BELAJFDOOBL<TGetDataArg, TData> NFFMMJBNJIB)
	{
		return default(LMFGFFJLHFK<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct HMBAFJINLBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int KMEJNHEPKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int? NJAHFOAJOKE;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A820", Offset = "0x3B09C20", VA = "0x183B0A820")]
	public HMBAFJINLBC(int MCOOOFLFPHN, [Optional] int? BKPKFNGFMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6511ED0", Offset = "0x65112D0", VA = "0x186511ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface NHFDKMLFECA<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMBDFPAMNPE();

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHFDKMLFECA<T> JHNAMNAHHCO(string LLJAEKEFAFD);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NHFDKMLFECA<T> PFOMGJCGJJN(FPIEMDDFDHN<T> FGGPEOOMMHD);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHFDKMLFECA<T> HHDNDJEMCNA(int FBHHDJPJBFB);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NHFDKMLFECA<T> PANPFBHDEBC(int FBHHDJPJBFB, DGALJLBPGOM<T> BLNFGHOPKJB);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface FGHINJIDHMN
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHFDKMLFECA<T> CKHLAENFHKP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACLDOIHMKEA GIFJMKIKHOL(Exception MEIELCKPCNE);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HMBAFJINLBC CBGGJHDIBPJ(Exception MEIELCKPCNE);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string FPIEMDDFDHN<in T>(T MEIELCKPCNE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int DGALJLBPGOM<in T>(T MEIELCKPCNE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class NHIHOLECAPG : FGHINJIDHMN
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string IPJIJPFNJNO(Exception MEIELCKPCNE);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int IGMHMMFPGBB(Exception MEIELCKPCNE);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class FEEOPDIJMPK<T> : NHFDKMLFECA<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class MGFMJNLGELP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public MGFMJNLGELP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
			internal string OJCELHFJAJE(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class MHNEMFCNFKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public FPIEMDDFDHN<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public MHNEMFCNFKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x3698D20", Offset = "0x3698120", VA = "0x183698D20")]
			internal string CFOHFFLAGJA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class GKNNBLCFNMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public DGALJLBPGOM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public GKNNBLCFNMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3698D20", Offset = "0x3698120", VA = "0x183698D20")]
			internal int OOBENFPIBNB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly NHIHOLECAPG KBCNMLIHOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly Type FKLKKFKOPCL;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3578970", Offset = "0x3577D70", VA = "0x183578970")]
		internal FEEOPDIJMPK(NHIHOLECAPG KBCNMLIHOAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x35785C0", Offset = "0x35779C0", VA = "0x1835785C0", Slot = "4")]
		public void GMBDFPAMNPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3578630", Offset = "0x3577A30", VA = "0x183578630", Slot = "5")]
		public NHFDKMLFECA<T> JHNAMNAHHCO(string LLJAEKEFAFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3578860", Offset = "0x3577C60", VA = "0x183578860", Slot = "6")]
		public NHFDKMLFECA<T> PFOMGJCGJJN(FPIEMDDFDHN<T> FGGPEOOMMHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x35785F0", Offset = "0x35779F0", VA = "0x1835785F0", Slot = "7")]
		public NHFDKMLFECA<T> HHDNDJEMCNA(int FBHHDJPJBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3578740", Offset = "0x3577B40", VA = "0x183578740", Slot = "8")]
		public NHFDKMLFECA<T> PANPFBHDEBC(int FBHHDJPJBFB, DGALJLBPGOM<T> BLNFGHOPKJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class IIAHFKIENDL<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private bool JIKJMNJMMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly List<Type> ACEFIPBIBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, TVal> ILDBCNKLHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, int> CMACJHCFFAE;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public IReadOnlyList<Type> JPJJCNOLDNL
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x37A5750", Offset = "0x37A4B50", VA = "0x1837A5750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x37A5C60", Offset = "0x37A5060", VA = "0x1837A5C60")]
		public IIAHFKIENDL(Dictionary<Type, int> CMACJHCFFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x37A58F0", Offset = "0x37A4CF0", VA = "0x1837A58F0")]
		public void FLOHBAGDPJC(Type KCGLPAPOILB, TVal HHFKHHNHDLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x37A5810", Offset = "0x37A4C10", VA = "0x1837A5810")]
		public bool DNLKEDHOFMC(Type FKLKKFKOPCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x37A5990", Offset = "0x37A4D90", VA = "0x1837A5990")]
		public bool HDJGLIAEGFK(TVal FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x37A5B10", Offset = "0x37A4F10", VA = "0x1837A5B10")]
		public TVal JNDPLHMHPON(Type ADAMDPHPFAA)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x37A5A70", Offset = "0x37A4E70", VA = "0x1837A5A70")]
		[CompilerGenerated]
		private int JKPJGFIOCMO(Type LPDEDONMPNE, Type ENKGJGKIMBJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class OJEPKKFHGNA : IEnumerable<HMBAFJINLBC>, IEnumerable, IEnumerator<HMBAFJINLBC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private HMBAFJINLBC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public NHIHOLECAPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private IEnumerator<HMBAFJINLBC> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private HMBAFJINLBC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x3288BC0", Offset = "0x3287FC0", VA = "0x183288BC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HMBAFJINLBC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x651E210", Offset = "0x651D610", VA = "0x18651E210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public OJEPKKFHGNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x651E260", Offset = "0x651D660", VA = "0x18651E260", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x651DC50", Offset = "0x651D050", VA = "0x18651DC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x651DBB0", Offset = "0x651CFB0", VA = "0x18651DBB0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x651DC00", Offset = "0x651D000", VA = "0x18651DC00")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x651E1C0", Offset = "0x651D5C0", VA = "0x18651E1C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x651E100", Offset = "0x651D500", VA = "0x18651E100", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HMBAFJINLBC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x651E100", Offset = "0x651D500", VA = "0x18651E100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly HMBAFJINLBC DCHEFMOIAGF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Dictionary<Type, int> CMCKOOFINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly HashSet<Type> KJDIJDHHKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly IIAHFKIENDL<int> NCPLFFBDPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly IIAHFKIENDL<IGMHMMFPGBB> JMDMPKFCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly IIAHFKIENDL<IPJIJPFNJNO> PALFHODFCMK;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x651BE50", Offset = "0x651B250", VA = "0x18651BE50")]
	[NEHHKLCIMGL(OJLOCLENGNC.GameOnly)]
	private static void FBKBONBGGCH(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x651CA80", Offset = "0x651BE80", VA = "0x18651CA80")]
	[RecRoom.NoEngine.Common.Preserve]
	public NHIHOLECAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x26D9450", Offset = "0x26D8850", VA = "0x1826D9450", Slot = "4")]
	public NHFDKMLFECA<T> CKHLAENFHKP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x651C110", Offset = "0x651B510", VA = "0x18651C110", Slot = "5")]
	public ACLDOIHMKEA GIFJMKIKHOL(Exception MEIELCKPCNE)
	{
		return default(ACLDOIHMKEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x651B800", Offset = "0x651AC00", VA = "0x18651B800", Slot = "6")]
	public HMBAFJINLBC CBGGJHDIBPJ(Exception? MEIELCKPCNE)
	{
		return default(HMBAFJINLBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x651BA00", Offset = "0x651AE00", VA = "0x18651BA00", Slot = "7")]
	[IteratorStateMachine(typeof(OJEPKKFHGNA))]
	public IEnumerable<HMBAFJINLBC> EBKMOMCILFA(Exception MEIELCKPCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x651C4B0", Offset = "0x651B8B0", VA = "0x18651C4B0", Slot = "8")]
	public string KLPDNIFNIDE(Exception? MEIELCKPCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x651C1A0", Offset = "0x651B5A0", VA = "0x18651C1A0")]
	private string KJMIMJEBKKC(AggregateException NMPHLLIPPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x651BAA0", Offset = "0x651AEA0", VA = "0x18651BAA0")]
	private void EBPFIEFALOD(Type FKLKKFKOPCL, int FBHHDJPJBFB, IGMHMMFPGBB? MHHALEJKNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x651BEC0", Offset = "0x651B2C0", VA = "0x18651BEC0")]
	private void FEMOLMBAIJN(Type FKLKKFKOPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x651C6E0", Offset = "0x651BAE0", VA = "0x18651C6E0")]
	private void LLPIHLOCIII(Type FKLKKFKOPCL, IPJIJPFNJNO LIEHMNAEJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x651B680", Offset = "0x651AA80", VA = "0x18651B680")]
	private static int BMFACGFBDIM(Type FKLKKFKOPCL, Dictionary<Type, int> CMACJHCFFAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x276CD20", Offset = "0x276C120", VA = "0x18276CD20")]
	private static bool EOGPKBGAFNP<TVal>(IIAHFKIENDL<TVal> FNPMCCBNOOB, Type FKLKKFKOPCL, [Out] TVal FDFHGIHHGHO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x651C600", Offset = "0x651BA00", VA = "0x18651C600")]
	[CompilerGenerated]
	internal static int KPPKMFMFEGA(Type CFACBNOMCGJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct ACLDOIHMKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly HMBAFJINLBC HGDINIPMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly string CEIFHEFOOED;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6503E00", Offset = "0x6503200", VA = "0x186503E00")]
	public ACLDOIHMKEA(string ABEHFPJFMOK, HMBAFJINLBC FBHHDJPJBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6503D60", Offset = "0x6503160", VA = "0x186503D60")]
	public string OEBNIMBDJAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class POFEKCBIEJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly BCENPLIMBOF JANNCCFLMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string ABNPFMKKOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? OOPIKGPPLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? LAPNPKFGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? PGBDPLMCEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private string AKPHEEMHGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private FBEGICLPDIH LGPFLOIDACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private long? IDEICPIONHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private bool FAHOMFEEPOE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string HMINFHIHPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long DOJLLDLAMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x65220F0", Offset = "0x65214F0", VA = "0x1865220F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long HONHDPHDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6522090", Offset = "0x6521490", VA = "0x186522090")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public long MLKLNOIICMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6522030", Offset = "0x6521430", VA = "0x186522030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string KOGOBIIHMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6522150", Offset = "0x6521550", VA = "0x186522150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FBEGICLPDIH NCIIGGPACGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD073E0", Offset = "0xD067E0", VA = "0x180D073E0")]
		get
		{
			return default(FBEGICLPDIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6522870", Offset = "0x6521C70", VA = "0x186522870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long KPPALKJMDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x6521FD0", Offset = "0x65213D0", VA = "0x186521FD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6522960", Offset = "0x6521D60", VA = "0x186522960")]
	[UnityEngine.Scripting.Preserve]
	public POFEKCBIEJO([CNGDHLLDFHE(null)] BCENPLIMBOF JANNCCFLMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6522190", Offset = "0x6521590", VA = "0x186522190")]
	private void JJHPLNFDMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65223E0", Offset = "0x65217E0", VA = "0x1865223E0")]
	public void LHFFIAFEAIN(long MAONELICPNP, long JNIJNNCDCAA, [Optional] long? JIHPABAMAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6521F30", Offset = "0x6521330", VA = "0x186521F30")]
	public void DKLCFMCIONB(long JIHPABAMAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6521EB0", Offset = "0x65212B0", VA = "0x186521EB0")]
	public void BMEBCHJECFN(string CCCHLNBMNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6521B30", Offset = "0x6520F30", VA = "0x186521B30")]
	public void BHHBGALPBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class ENAELKBIJPI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CMLCMMJJFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public FABBKACGCKD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public ENAELKBIJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter<JMENELMHCNB.CKDAFHDLEOL<FABBKACGCKD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6507E40", Offset = "0x6507240", VA = "0x186507E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6508370", Offset = "0x6507770", VA = "0x186508370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct AINKOMHJAJG<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class BGDFPJMHEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public FABBKACGCKD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BGDFPJMHEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x65060B0", Offset = "0x65054B0", VA = "0x1865060B0")]
		internal FABBKACGCKD BJPHHGAPJEA(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct AGLHPJOBMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<JMENELMHCNB.CKDAFHDLEOL<FABBKACGCKD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public FABBKACGCKD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public ENAELKBIJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private AAPBFAPMONC <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<JMENELMHCNB.CKDAFHDLEOL<FABBKACGCKD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x6503E20", Offset = "0x6503220", VA = "0x186503E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6504430", Offset = "0x6503830", VA = "0x186504430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct IFDFELHMODC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public ENAELKBIJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x3799300", Offset = "0x3798700", VA = "0x183799300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x31E12D0", Offset = "0x31E06D0", VA = "0x1831E12D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct LGAKOBKOOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public ENAELKBIJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6517460", Offset = "0x6516860", VA = "0x186517460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6517620", Offset = "0x6516A20", VA = "0x186517620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class DJEDHEGMDEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public DJEDHEGMDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6509700", Offset = "0x6508B00", VA = "0x186509700")]
		internal object IGJENMENDIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x6509640", Offset = "0x6508A40", VA = "0x186509640")]
		internal bool FKJJEDHFOPH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class HEIJFKDKCBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HEIJFKDKCBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x65117F0", Offset = "0x6510BF0", VA = "0x1865117F0")]
		internal object MKBKPCBKLAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class FGFOLMNIIMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public FGFOLMNIIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x650D1D0", Offset = "0x650C5D0", VA = "0x18650D1D0")]
		internal object FHBOMNLOLEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class MCJAGAPBCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MCJAGAPBCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x6517C20", Offset = "0x6517020", VA = "0x186517C20")]
		internal object AIBDCMLEPDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class AICIPNDAEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public ENAELKBIJPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AICIPNDAEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x65044A0", Offset = "0x65038A0", VA = "0x1865044A0")]
		internal object ACALOJOOEKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly Guid PLDKPKAHJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly MDFBCIKEPAJ INJCMILHDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly JMENELMHCNB HPJGAMOBADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly OKOADGKOHLH EEMFDHBKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly CIPCPHCNNNK GMKKBLMIIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private bool POCBHGFHNJC;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x650CFA0", Offset = "0x650C3A0", VA = "0x18650CFA0")]
	public ENAELKBIJPI(MDFBCIKEPAJ EHEFAPJMEBE, JMENELMHCNB HPJGAMOBADO, OKOADGKOHLH EEMFDHBKBKN, CIPCPHCNNNK GMKKBLMIIKN, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x650C4D0", Offset = "0x650B8D0", VA = "0x18650C4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x650C4D0", Offset = "0x650B8D0", VA = "0x18650C4D0")]
	public void LIBCAPLKJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x650CA20", Offset = "0x650BE20", VA = "0x18650CA20")]
	public void KHFOLHNIAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x650C030", Offset = "0x650B430", VA = "0x18650C030")]
	public void BBKBHDIPIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x650CD50", Offset = "0x650C150", VA = "0x18650CD50")]
	[AsyncStateMachine(typeof(CMLCMMJJFPF))]
	internal Task<FABBKACGCKD> MEKIAHNLKOM(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, FABBKACGCKD HGNDFIBADEI, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x25103E0", Offset = "0x250F7E0", VA = "0x1825103E0")]
	private static byte[] LMDFIJCABGP<T>(T DCKDMGKGDFN) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x250FFE0", Offset = "0x250F3E0", VA = "0x18250FFE0")]
	private static T DFHJCJOCHBA<T>(MessageParser<T> BABNNGBPKHO, byte[] DCKDMGKGDFN, T CFHBMAENKKB) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x650CAE0", Offset = "0x650BEE0", VA = "0x18650CAE0")]
	[AsyncStateMachine(typeof(AGLHPJOBMJO))]
	private Task<JMENELMHCNB.CKDAFHDLEOL<FABBKACGCKD>> KKMLAKJMKDB(FABBKACGCKD HGNDFIBADEI, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x25103F0", Offset = "0x250F7F0", VA = "0x1825103F0")]
	[AsyncStateMachine(typeof(IFDFELHMODC<>))]
	internal Task<T> MDLHLAPMDJM<T>(CancellationToken LBFDCKKMBFP, Func<CancellationToken, Task<T>> LIJFKFPPBOE, int GCDMBIGMILP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x650CC20", Offset = "0x650C020", VA = "0x18650CC20")]
	[AsyncStateMachine(typeof(LGAKOBKOOCL))]
	internal Task MDLHLAPMDJM(CancellationToken LBFDCKKMBFP, Func<CancellationToken, Task> LIJFKFPPBOE, int GCDMBIGMILP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x650CEB0", Offset = "0x650C2B0", VA = "0x18650CEB0")]
	public HJJABBPFPPK NIOKMHLOPGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x650C700", Offset = "0x650BB00", VA = "0x18650C700")]
	public BPABINDEICK FKCGJPEGALM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x650C380", Offset = "0x650B780", VA = "0x18650C380")]
	public DIDALCDCLBA CANDLPLPPMH([Optional] AMCJMMGFCLE? HILPECKCPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x650BED0", Offset = "0x650B2D0", VA = "0x18650BED0")]
	public void AKEHBFDAMBD(Func<Guid, bool> JLFEOBICMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x650C910", Offset = "0x650BD10", VA = "0x18650C910")]
	public void IOMGKLJLBLN(Func<Guid, bool> BFHDNEJBLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x650C200", Offset = "0x650B600", VA = "0x18650C200")]
	public Guid BKAFEFHCEJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x650C5F0", Offset = "0x650B9F0", VA = "0x18650C5F0")]
	public void ELEMLHLKMKJ(Guid JPLJPABFKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x650C7D0", Offset = "0x650BBD0", VA = "0x18650C7D0")]
	public void IKBGOKDDKKK(FABBKACGCKD KIOPLECHBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x650C0F0", Offset = "0x650B4F0", VA = "0x18650C0F0")]
	public void BDAJDFAFKKC(string HPKJBEFDAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2510670", Offset = "0x250FA70", VA = "0x182510670")]
	private T MPKONLDIMJB<T>(T FDFHGIHHGHO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x650C780", Offset = "0x650BB80", VA = "0x18650C780")]
	public void IEBNENKGHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2510130", Offset = "0x250F530", VA = "0x182510130")]
	[CompilerGenerated]
	internal static string GBPFFKEMCLE<T>(byte[] PEBEDGMMHMC, int HPAEJNPCJHD, AINKOMHJAJG<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class OJDPJDPBBCM : MDFBCIKEPAJ
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class MINCHCNLFMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MINCHCNLFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6534B70", Offset = "0x6533F70", VA = "0x186534B70")]
		internal object GOCEDAKMJLI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct ALCJBIEKKEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public OJDPJDPBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private NFLIPHOFKMG <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private BPABINDEICK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6523C20", Offset = "0x6523020", VA = "0x186523C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6524400", Offset = "0x6523800", VA = "0x186524400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct JPFNIEKMHHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public OJDPJDPBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<KLIMJDPIFED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x652E300", Offset = "0x652D700", VA = "0x18652E300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x652E9B0", Offset = "0x652DDB0", VA = "0x18652E9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct HLDOBABHFDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public OJDPJDPBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter<FIJFPBAMPLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x652CD10", Offset = "0x652C110", VA = "0x18652CD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x652D030", Offset = "0x652C430", VA = "0x18652D030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class NDLLEMEOJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public NFLIPHOFKMG presence;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NDLLEMEOJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x65356E0", Offset = "0x6534AE0", VA = "0x1865356E0")]
		internal object LGEABBMEGHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly AMCJMMGFCLE PJNEEFMCKAA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly AMCJMMGFCLE DGDCBAEPDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly DNPPEJGLHLI GLIEHNPLIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly JGNOMFHEEPM CHBPJGFAMOE;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x651DA20", Offset = "0x651CE20", VA = "0x18651DA20")]
	public OJDPJDPBBCM(DNPPEJGLHLI GLIEHNPLIJL, JGNOMFHEEPM CHBPJGFAMOE, Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, IKLJEDJKANM IEOOIPDJKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x651D800", Offset = "0x651CC00", VA = "0x18651D800", Slot = "7")]
	[AsyncStateMachine(typeof(ALCJBIEKKEN))]
	protected override Task ODBOMOLKLFM(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x651D700", Offset = "0x651CB00", VA = "0x18651D700")]
	[AsyncStateMachine(typeof(JPFNIEKMHHF))]
	private Task MNHCNDJKMBK(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x651D5F0", Offset = "0x651C9F0", VA = "0x18651D5F0")]
	[AsyncStateMachine(typeof(HLDOBABHFDO))]
	private Task<byte> IJCCCAILGAP(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x651D410", Offset = "0x651C810", VA = "0x18651D410")]
	private NFLIPHOFKMG DGJHHIIOINP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class PMNEPKMEAHO : MDFBCIKEPAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct GBDEKFEHJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public PMNEPKMEAHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<OGFMKNMGFDL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x652AA40", Offset = "0x6529E40", VA = "0x18652AA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x652B3C0", Offset = "0x652A7C0", VA = "0x18652B3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly int GJMFIDLJLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly KNCFAMOEPME DBLMIDLIKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long NKPOBKBEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long KGHOMHLLHOI;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public OGFMKNMGFDL CNODPBFCBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7A9460", Offset = "0x7A8860", VA = "0x1807A9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7A94D0", Offset = "0x7A88D0", VA = "0x1807A94D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6539FF0", Offset = "0x65393F0", VA = "0x186539FF0")]
	public PMNEPKMEAHO(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, IKLJEDJKANM IEOOIPDJKJJ, int GJMFIDLJLLM, KNCFAMOEPME DBLMIDLIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6539ED0", Offset = "0x65392D0", VA = "0x186539ED0", Slot = "7")]
	[AsyncStateMachine(typeof(GBDEKFEHJMH))]
	protected override Task ODBOMOLKLFM(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class LMEJGKIGDBI : MDFBCIKEPAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class MKGOPACKJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public LMEJGKIGDBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public PDLBOMJFAGF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MKGOPACKJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6534BE0", Offset = "0x6533FE0", VA = "0x186534BE0")]
		internal Task HMAIIBFLIMH(NKOLFLIKMKN<string>.JNCJJIKLGBC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6534C20", Offset = "0x6534020", VA = "0x186534C20")]
		internal object NPBKCCFPFDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct BLIFEFEGJHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public LMEJGKIGDBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private MKGOPACKJDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6524580", Offset = "0x6523980", VA = "0x186524580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6524D40", Offset = "0x6524140", VA = "0x186524D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct IMIFIIJDOFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public PDLBOMJFAGF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public LMEJGKIGDBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x652D3C0", Offset = "0x652C7C0", VA = "0x18652D3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x652D950", Offset = "0x652CD50", VA = "0x18652D950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6532520", Offset = "0x6531920", VA = "0x186532520")]
	public LMEJGKIGDBI(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, IKLJEDJKANM IEOOIPDJKJJ, string EJMFPEHIABA, DKJJMEFGPAB CMJHHBGCABN, bool JFFLNPNODCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x65323E0", Offset = "0x65317E0", VA = "0x1865323E0", Slot = "7")]
	[AsyncStateMachine(typeof(BLIFEFEGJHC))]
	protected override Task ODBOMOLKLFM(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task AMIIGNECHMN(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65322A0", Offset = "0x65316A0", VA = "0x1865322A0")]
	[AsyncStateMachine(typeof(IMIFIIJDOFK))]
	private Task EDMOGEFJPEO(IDisposable EFDAGECPGPD, PDLBOMJFAGF IEOPFFIMJJJ, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class HMGFHPGGFNN : MDFBCIKEPAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct ACELMOMPMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public HMGFHPGGFNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<DODBLFCGAMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x65233E0", Offset = "0x65227E0", VA = "0x1865233E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6523950", Offset = "0x6522D50", VA = "0x186523950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private readonly AMIIJBBMGIJ NHAAHCFFLBH;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x652D2A0", Offset = "0x652C6A0", VA = "0x18652D2A0")]
	public HMGFHPGGFNN(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, IKLJEDJKANM IEOOIPDJKJJ, AMIIJBBMGIJ NHAAHCFFLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x652D1C0", Offset = "0x652C5C0", VA = "0x18652D1C0", Slot = "6")]
	protected override string OFEKAFKBODF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x652D0A0", Offset = "0x652C4A0", VA = "0x18652D0A0", Slot = "7")]
	[AsyncStateMachine(typeof(ACELMOMPMKL))]
	protected override Task ODBOMOLKLFM(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class MDFBCIKEPAJ : EGKEAENJJOD
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task POGPPCEFELE(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class OPKLNCADHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public MDFBCIKEPAJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public OPKLNCADHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6538170", Offset = "0x6537570", VA = "0x186538170")]
		internal Task CCDECDFKAHP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class JKKKHCOCIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public OPKLNCADHFE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JKKKHCOCIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x652DA70", Offset = "0x652CE70", VA = "0x18652DA70")]
		internal object KEEACDNMCHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x652D9B0", Offset = "0x652CDB0", VA = "0x18652D9B0")]
		internal object HNADAKPDPOF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct KHOIKPCJGGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public MDFBCIKEPAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Func<MDFBCIKEPAJ, NKOLFLIKMKN<string>.JNCJJIKLGBC, ENAELKBIJPI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private OPKLNCADHFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private ENAELKBIJPI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<FABBKACGCKD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6530E40", Offset = "0x6530240", VA = "0x186530E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6532040", Offset = "0x6531440", VA = "0x186532040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct NMNCJJHPDID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6536B80", Offset = "0x6535F80", VA = "0x186536B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6537600", Offset = "0x6536A00", VA = "0x186537600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct PDHGPNKKEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public MDFBCIKEPAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6538810", Offset = "0x6537C10", VA = "0x186538810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6538B70", Offset = "0x6537F70", VA = "0x186538B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly Guid DKNPKOBNLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly ByteString EBIDMDFDDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly IKLJEDJKANM CKCMGFDOPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected readonly string GOJJNGOLKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly bool JFFLNPNODCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Queue<POGPPCEFELE> DOJGOAMHKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly INCDONFPCLI AIJPFIHADFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly DKJJMEFGPAB CMJHHBGCABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool CNCANMMGNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public FBEGICLPDIH NKCEIJNKLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public FBEGICLPDIH NCOHLPOGAMO;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public DGDKDOCHPEF FJLPFGBGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6533F10", Offset = "0x6533310", VA = "0x186533F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LGFOLLJEPJB GPGMBFALKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6534550", Offset = "0x6533950", VA = "0x186534550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x6534470", Offset = "0x6533870", VA = "0x186534470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DCAEKOCLCGM HLOOKCONAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x6534330", Offset = "0x6533730", VA = "0x186534330", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x6533FE0", Offset = "0x65333E0", VA = "0x186533FE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6534880", Offset = "0x6533C80", VA = "0x186534880")]
	protected MDFBCIKEPAJ(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, IKLJEDJKANM IEOOIPDJKJJ, string EJMFPEHIABA, DKJJMEFGPAB CMJHHBGCABN, bool JFFLNPNODCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x65346F0", Offset = "0x6533AF0", VA = "0x1865346F0", Slot = "6")]
	protected virtual string OFEKAFKBODF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x65344F0", Offset = "0x65338F0", VA = "0x1865344F0")]
	public void LPKDIKCBAFN(POGPPCEFELE KONGNKHADNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6534130", Offset = "0x6533530", VA = "0x186534130")]
	protected void FBFDONBMAEH(float BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6534730", Offset = "0x6533B30", VA = "0x186534730")]
	[AsyncStateMachine(typeof(KHOIKPCJGGC))]
	public Task OLPPMELFJKG(CancellationToken HNLFPBLPOKJ, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, [Optional] Func<MDFBCIKEPAJ, NKOLFLIKMKN<string>.JNCJJIKLGBC, ENAELKBIJPI> HHMPIECCGEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6534000", Offset = "0x6533400", VA = "0x186534000")]
	[AsyncStateMachine(typeof(NMNCJJHPDID))]
	private static Task CMEAIBMOIMG(Func<CancellationToken, Task> HPHBOIKPBPL, Func<CancellationToken, Task> KEAFMKAPNPL, CancellationToken LBFDCKKMBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65345A0", Offset = "0x65339A0", VA = "0x1865345A0")]
	private void MMOAKOCLLGJ(bool OHANFNIJEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x6534240", Offset = "0x6533640", VA = "0x186534240")]
	private void IAPKEGFBGGN(ENAELKBIJPI OAMIDHBGBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task ODBOMOLKLFM(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6534350", Offset = "0x6533750", VA = "0x186534350")]
	[AsyncStateMachine(typeof(PDHGPNKKEFC))]
	private Task JLMLGKAFNOK(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6533F60", Offset = "0x6533360", VA = "0x186533F60")]
	public FABBKACGCKD APKPJHPDBLP(AAPBFAPMONC NEPLKJDHIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6534150", Offset = "0x6533550", VA = "0x186534150")]
	[CompilerGenerated]
	private Task FMGCKGDNJHI(CancellationToken FENMDPNPDJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class KLNLDPBHJKI : LMEJGKIGDBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct GIHPBGEKNLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public KLNLDPBHJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private AFCNFJBPLGM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private BPABINDEICK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x652B420", Offset = "0x652A820", VA = "0x18652B420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x652BB90", Offset = "0x652AF90", VA = "0x18652BB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly DNPPEJGLHLI OPIDPKOMHLH;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x65321F0", Offset = "0x65315F0", VA = "0x1865321F0")]
	public KLNLDPBHJKI(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, DNPPEJGLHLI OPIDPKOMHLH, IKLJEDJKANM IEOOIPDJKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65320A0", Offset = "0x65314A0", VA = "0x1865320A0", Slot = "8")]
	[AsyncStateMachine(typeof(GIHPBGEKNLH))]
	protected override Task AMIIGNECHMN(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class PIPKGCEEODP : MDFBCIKEPAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct GKALGFLLOKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public PIPKGCEEODP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<DODBLFCGAMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x652BBF0", Offset = "0x652AFF0", VA = "0x18652BBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x652BFA0", Offset = "0x652B3A0", VA = "0x18652BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private readonly string BHENJOPEDOL;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6539160", Offset = "0x6538560", VA = "0x186539160")]
	public PIPKGCEEODP(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, IKLJEDJKANM IEOOIPDJKJJ, string BHENJOPEDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6539050", Offset = "0x6538450", VA = "0x186539050", Slot = "7")]
	[AsyncStateMachine(typeof(GKALGFLLOKA))]
	protected override Task ODBOMOLKLFM(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class OPNBOIPODOJ : LMEJGKIGDBI
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class BGLGPPJCGDI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public BGLGPPJCGDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<DODBLFCGAMM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<FABBKACGCKD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x653CF50", Offset = "0x653C350", VA = "0x18653CF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x653D410", Offset = "0x653C810", VA = "0x18653D410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public OPNBOIPODOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public DIDALCDCLBA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public HBOGCGCACNI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public HJJABBPFPPK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public IGEACEPBJLE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BGLGPPJCGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x6524460", Offset = "0x6523860", VA = "0x186524460")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FABBKACGCKD> NAKJHLKGPNH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct KCHIIBFKEOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public OPNBOIPODOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private BGLGPPJCGDI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private AFCNFJBPLGM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private BPABINDEICK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x652EA10", Offset = "0x652DE10", VA = "0x18652EA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x652F8B0", Offset = "0x652ECB0", VA = "0x18652F8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly AMCJMMGFCLE PJNEEFMCKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly int GMOKELEHOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	[CanBeNull]
	private readonly NHNEEALDKAA AHAIOEKHGEF;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6538760", Offset = "0x6537B60", VA = "0x186538760")]
	public OPNBOIPODOJ(Guid BMPBDIBKAJJ, DGDKDOCHPEF HMDOIKIDPEL, int GMOKELEHOGA, NHNEEALDKAA AHAIOEKHGEF, IKLJEDJKANM IEOOIPDJKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x65382A0", Offset = "0x65376A0", VA = "0x1865382A0", Slot = "8")]
	[AsyncStateMachine(typeof(KCHIIBFKEOM))]
	protected override Task AMIIGNECHMN(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65385B0", Offset = "0x65379B0", VA = "0x1865385B0")]
	private void LBHHGEDEJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65383E0", Offset = "0x65377E0", VA = "0x1865383E0")]
	private void DNBPONPOOPD(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, AFCNFJBPLGM HAKHJEMJHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class NHBJNBDMONH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly MDFBCIKEPAJ INJCMILHDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly ENAELKBIJPI DDOHJFEEEFL;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6535820", Offset = "0x6534C20", VA = "0x186535820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6535890", Offset = "0x6534C90", VA = "0x186535890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6535920", Offset = "0x6534D20", VA = "0x186535920")]
	protected NHBJNBDMONH(ENAELKBIJPI OAMIDHBGBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6535870", Offset = "0x6534C70", VA = "0x186535870")]
	protected void BDAJDFAFKKC(string HPKJBEFDAFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct DFAFIJBJAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public Dictionary<Guid, List<OBMNMGFPPJO>> DNODJDCLGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<OBMNMGFPPJO>> KMIMOAJJAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<OBMNMGFPPJO>> PJPIJAENMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public List<Guid> KCLIOOHGMHP;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x652A050", Offset = "0x6529450", VA = "0x18652A050")]
	public static DFAFIJBJAFF JNDPLHMHPON(JJABELEOGOG CBKELGPMNJD, FBEGICLPDIH FGGLIDIFHFD, DCOJCHOOLIN BOFKBJADHJK)
	{
		return default(DFAFIJBJAFF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct FCMGNDBGIJH
{
	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	public static FCMGNDBGIJH NDFPICIGPEG()
	{
		return default(FCMGNDBGIJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct ICIFAIJGMOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly KLIMJDPIFED IHDIFNFCKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly KFLDBIMKFED AOBFILOHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly string AIMMPKDBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly IODJBGDFNFE JAMOLIKGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly IODJBGDFNFE MDKKFDHBGPI;

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x652D340", Offset = "0x652C740", VA = "0x18652D340")]
	public ICIFAIJGMOL(KLIMJDPIFED IHDIFNFCKLF, KFLDBIMKFED AOBFILOHALE, string AIMMPKDBJBI, IODJBGDFNFE JAMOLIKGFAA, IODJBGDFNFE MDKKFDHBGPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct EAFIHOJNEBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ENAELKBIJPI OAMIDHBGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly Guid JPLJPABFKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private bool OHANFNIJEEA;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x652A660", Offset = "0x6529A60", VA = "0x18652A660")]
	public static EAFIHOJNEBN BKAFEFHCEJD(ENAELKBIJPI OAMIDHBGBJD)
	{
		return default(EAFIHOJNEBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x8A20E0", Offset = "0x8A14E0", VA = "0x1808A20E0")]
	public void EAGNBCFHOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x652A6C0", Offset = "0x6529AC0", VA = "0x18652A6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x652A7C0", Offset = "0x6529BC0", VA = "0x18652A7C0")]
	private EAFIHOJNEBN(ENAELKBIJPI OAMIDHBGBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x652A6C0", Offset = "0x6529AC0", VA = "0x18652A6C0")]
	private void ELEMLHLKMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x652A720", Offset = "0x6529B20", VA = "0x18652A720")]
	private Func<Guid, bool> NFFBHILELPN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class BPABINDEICK : NHBJNBDMONH, EGKEAENJJOD
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<FBEGICLPDIH> KCLDFEMCDPM(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CFIJIPJABDN, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct JNGCKJHBKCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public DNPPEJGLHLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private EAFIHOJNEBN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x652DB30", Offset = "0x652CF30", VA = "0x18652DB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x652E2A0", Offset = "0x652D6A0", VA = "0x18652E2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct PEOCAJIPDBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public DNPPEJGLHLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6538BD0", Offset = "0x6537FD0", VA = "0x186538BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6538FE0", Offset = "0x65383E0", VA = "0x186538FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct CEDMBHHDAGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public DNPPEJGLHLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x6527960", Offset = "0x6526D60", VA = "0x186527960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6527DF0", Offset = "0x65271F0", VA = "0x186527DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class CCDAIIDLODI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public AsyncTaskMethodBuilder<ICIFAIJGMOL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CCDAIIDLODI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private ICIFAIJGMOL <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<FBEGICLPDIH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<ICIFAIJGMOL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x653B610", Offset = "0x653AA10", VA = "0x18653B610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x653BDA0", Offset = "0x653B1A0", VA = "0x18653BDA0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public AsyncTaskMethodBuilder<DCOJCHOOLIN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public CCDAIIDLODI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private DCOJCHOOLIN <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<FBEGICLPDIH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<DCOJCHOOLIN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x653BE10", Offset = "0x653B210", VA = "0x18653BE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x653C460", Offset = "0x653B860", VA = "0x18653C460", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CCDAIIDLODI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter<FBEGICLPDIH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private POIONMCIPEE <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x653A270", Offset = "0x6539670", VA = "0x18653A270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x653B5B0", Offset = "0x653A9B0", VA = "0x18653B5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public DNPPEJGLHLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public INCDONFPCLI preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public INCDONFPCLI downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public ICIFAIJGMOL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public INCDONFPCLI postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public DCOJCHOOLIN phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DGOIDAAGJMM.GBBIGAJCJHD <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CCDAIIDLODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x6527720", Offset = "0x6526B20", VA = "0x186527720")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<ICIFAIJGMOL> KCPMPGNHMCM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x6527600", Offset = "0x6526A00", VA = "0x186527600")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<DCOJCHOOLIN> IJPCKKJBEFB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x65275C0", Offset = "0x65269C0", VA = "0x1865275C0")]
		internal void IJBOJMOIODF(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6527860", Offset = "0x6526C60", VA = "0x186527860")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task OBCDCHPOHHL(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct NKNDHKENCDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public DNPPEJGLHLI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private CCDAIIDLODI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<ICIFAIJGMOL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<DCOJCHOOLIN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6535980", Offset = "0x6534D80", VA = "0x186535980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6536590", Offset = "0x6535990", VA = "0x186536590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct GOBPDFOPNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x652C570", Offset = "0x652B970", VA = "0x18652C570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x652CCB0", Offset = "0x652C0B0", VA = "0x18652CCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct BNJKJOGBNMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6524DA0", Offset = "0x65241A0", VA = "0x186524DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6525700", Offset = "0x6524B00", VA = "0x186525700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct LMNCELKPLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6532570", Offset = "0x6531970", VA = "0x186532570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x65336F0", Offset = "0x6532AF0", VA = "0x1865336F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct KHAKDKCGKOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public POIONMCIPEE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x652FA10", Offset = "0x652EE10", VA = "0x18652FA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6530DD0", Offset = "0x65301D0", VA = "0x186530DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NPBIFKPFOHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public FBEGICLPDIH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public DCOJCHOOLIN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6537B00", Offset = "0x6536F00", VA = "0x186537B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6537D90", Offset = "0x6537190", VA = "0x186537D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class ELBOKNJLHFG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ELBOKNJLHFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private LLMJNNBAAIC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<FBEGICLPDIH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x653C4D0", Offset = "0x653B8D0", VA = "0x18653C4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x653CAF0", Offset = "0x653BEF0", VA = "0x18653CAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public KCLDFEMCDPM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public POIONMCIPEE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public FBEGICLPDIH originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ELBOKNJLHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x652A810", Offset = "0x6529C10", VA = "0x18652A810")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FBEGICLPDIH> ACFKOKCIPFL(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct GKEEDDGLFKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public KCLDFEMCDPM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public POIONMCIPEE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x652C000", Offset = "0x652B400", VA = "0x18652C000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x652C500", Offset = "0x652B900", VA = "0x18652C500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NMBINBPIAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public INCDONFPCLI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private FBEGICLPDIH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private IEnumerator<FBEGICLPDIH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x65365F0", Offset = "0x65359F0", VA = "0x1865365F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6536B20", Offset = "0x6535F20", VA = "0x186536B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct OBKGCBIPJCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6537E00", Offset = "0x6537200", VA = "0x186537E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6538110", Offset = "0x6537510", VA = "0x186538110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct BNOIJPEOMIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public BPABINDEICK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6525760", Offset = "0x6524B60", VA = "0x186525760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x65259B0", Offset = "0x6524DB0", VA = "0x1865259B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly ICDJEGFNKHF BGFGLGBAIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly ICDJEGFNKHF FGPNNMHFGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly POFEKCBIEJO KJKMOLPCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly BMCIOMLNKLB MCOJOLKEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly IDMJHLBLJEO EKOJDOGBADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly MAADCOBIKJK ELCKHAKHNLK;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private DGDKDOCHPEF FJLPFGBGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x6526DD0", Offset = "0x65261D0", VA = "0x186526DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DCAEKOCLCGM HLOOKCONAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x6526690", Offset = "0x6525A90", VA = "0x186526690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6525D60", Offset = "0x6525160", VA = "0x186525D60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6527310", Offset = "0x6526710", VA = "0x186527310")]
	public BPABINDEICK(ENAELKBIJPI OAMIDHBGBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6526250", Offset = "0x6525650", VA = "0x186526250")]
	[AsyncStateMachine(typeof(JNGCKJHBKCI))]
	public Task HEGNCIIAPPD(DNPPEJGLHLI NCCHHGAPAOP, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6526E00", Offset = "0x6526200", VA = "0x186526E00")]
	[AsyncStateMachine(typeof(PEOCAJIPDBO))]
	private Task<FABBKACGCKD> MHOCNEDBNEC(DNPPEJGLHLI NCCHHGAPAOP, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6526550", Offset = "0x6525950", VA = "0x186526550")]
	[AsyncStateMachine(typeof(CEDMBHHDAGG))]
	private Task IJGGOCEMOJL(DNPPEJGLHLI NCCHHGAPAOP, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6526020", Offset = "0x6525420", VA = "0x186526020")]
	[AsyncStateMachine(typeof(NKNDHKENCDN))]
	private Task FACBOHFDHNG(DNPPEJGLHLI NCCHHGAPAOP, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken DPLMGNFLMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6526F60", Offset = "0x6526360", VA = "0x186526F60")]
	[AsyncStateMachine(typeof(GOBPDFOPNLC))]
	private Task NBDBAGFNMNN(NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6525ED0", Offset = "0x65252D0", VA = "0x186525ED0")]
	[AsyncStateMachine(typeof(BNJKJOGBNMA))]
	private Task DKOINPLADGL(DCOJCHOOLIN MFNOAEFOKBK, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x65267F0", Offset = "0x6525BF0", VA = "0x1865267F0")]
	[AsyncStateMachine(typeof(LMNCELKPLFD))]
	private Task<FBEGICLPDIH> JBMBIPBHMCA(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6527070", Offset = "0x6526470", VA = "0x186527070")]
	[AsyncStateMachine(typeof(KHAKDKCGKOD))]
	private Task<FBEGICLPDIH> NCNOKMEDNGO(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6526950", Offset = "0x6525D50", VA = "0x186526950")]
	[AsyncStateMachine(typeof(NPBIFKPFOHM))]
	private Task<FBEGICLPDIH> JJHHEALMPCA(FBEGICLPDIH FGGLIDIFHFD, DCOJCHOOLIN BOFKBJADHJK, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ, bool PPBKGOKHGJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6526160", Offset = "0x6525560", VA = "0x186526160")]
	private bool HDJMEOHNFOE(DCOJCHOOLIN JBMHCNFHLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6526AD0", Offset = "0x6525ED0", VA = "0x186526AD0")]
	[AsyncStateMachine(typeof(GKEEDDGLFKN))]
	protected Task<FBEGICLPDIH> JNKOEJPBGIB(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ, KCLDFEMCDPM HKJMCGCPHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6525AC0", Offset = "0x6524EC0", VA = "0x186525AC0")]
	[AsyncStateMachine(typeof(NMBINBPIAEF))]
	private Task BHPMMPGCJNO(DCOJCHOOLIN MFNOAEFOKBK, INCDONFPCLI CJLIGMBBAMO, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6525A10", Offset = "0x6524E10", VA = "0x186525A10")]
	private void AKPJOKAOCHG(FBEGICLPDIH FBOCGGGDNLA, INCDONFPCLI CJLIGMBBAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x65271F0", Offset = "0x65265F0", VA = "0x1865271F0")]
	private void OPEPGAOOIGH(FBEGICLPDIH GKMLHCBAEGB, [Out] FBEGICLPDIH BHPLGFHKOGD, [Out] FBEGICLPDIH JLPHAECLCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6525D80", Offset = "0x6525180", VA = "0x186525D80")]
	private Task<ICIFAIJGMOL> CPKGMPMHJAB(DNPPEJGLHLI NCCHHGAPAOP, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6525A60", Offset = "0x6524E60", VA = "0x186525A60")]
	private Task<DCOJCHOOLIN> APLCGLIMBMD(ICIFAIJGMOL MFNOAEFOKBK, DGOIDAAGJMM.GBBIGAJCJHD LDBENHHHMBE, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6525C10", Offset = "0x6525010", VA = "0x186525C10")]
	[AsyncStateMachine(typeof(OBKGCBIPJCG))]
	private Task BMPBNCCLBGC(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ, bool LLOPCDNIEGG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6525DE0", Offset = "0x65251E0", VA = "0x186525DE0")]
	[AsyncStateMachine(typeof(BNOIJPEOMIG))]
	private Task DGOEGOKKDIP(DCOJCHOOLIN MFNOAEFOKBK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x65266B0", Offset = "0x6525AB0", VA = "0x1865266B0")]
	private Task ILGPLANECCI(DCOJCHOOLIN MFNOAEFOKBK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6525DC0", Offset = "0x65251C0", VA = "0x186525DC0")]
	private Task DEFIEBNCPLA(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6525AA0", Offset = "0x6524EA0", VA = "0x186525AA0")]
	private Task BHEEIDHCOLK(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6526C80", Offset = "0x6526080", VA = "0x186526C80")]
	private Task LAMENDOCJHJ(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6527230", Offset = "0x6526630", VA = "0x186527230")]
	private static Task PCAJGIIHDBB(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6526C60", Offset = "0x6526060", VA = "0x186526C60")]
	private Task JPDMGPKHJNH(DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6526410", Offset = "0x6525810", VA = "0x186526410")]
	private Task IBDEAEOBLEA(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x65263A0", Offset = "0x65257A0", VA = "0x1865263A0")]
	private void HLKJAPJMAIN(DNPPEJGLHLI NCCHHGAPAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x65263F0", Offset = "0x65257F0", VA = "0x1865263F0")]
	public void HOIIJNACFAJ(long JIHPABAMAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void NAOBDAIJFBB(KLIMJDPIFED IHDIFNFCKLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct MCEKNJIKMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private DCOJCHOOLIN MFNOAEFOKBK;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6533AB0", Offset = "0x6532EB0", VA = "0x186533AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6533CF0", Offset = "0x65330F0", VA = "0x186533CF0")]
	public static Task OLPPMELFJKG(DGDKDOCHPEF HMDOIKIDPEL, DCOJCHOOLIN MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6533B00", Offset = "0x6532F00", VA = "0x186533B00")]
	private void OLPPMELFJKG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct DDMANDCJDJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6527230", Offset = "0x6526630", VA = "0x186527230")]
	public static Task OLPPMELFJKG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct MDDOPEMAKIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct CPIDCDPJLJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6529AD0", Offset = "0x6528ED0", VA = "0x186529AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6529FF0", Offset = "0x65293F0", VA = "0x186529FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6533DD0", Offset = "0x65331D0", VA = "0x186533DD0")]
	[AsyncStateMachine(typeof(CPIDCDPJLJN))]
	public static Task OLPPMELFJKG(ENAELKBIJPI OAMIDHBGBJD, DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct LPPCPFNELJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct PJAAPCMGKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public POIONMCIPEE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private FBEGICLPDIH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private DGDKDOCHPEF <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private JJABELEOGOG <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private LLMJNNBAAIC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private List<(PersistenceView, NEEDBNPPDKD)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private NEEDBNPPDKD <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6539210", Offset = "0x6538610", VA = "0x186539210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6539E70", Offset = "0x6539270", VA = "0x186539E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6533960", Offset = "0x6532D60", VA = "0x186533960")]
	[AsyncStateMachine(typeof(PJAAPCMGKOO))]
	public static Task OLPPMELFJKG(ENAELKBIJPI OAMIDHBGBJD, DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6533760", Offset = "0x6532B60", VA = "0x186533760")]
	private static void AEEOJEEGFFC(PersistenceView MPAMJPPMOAI, NEEDBNPPDKD GKOAKJGNMLA, DCOJCHOOLIN MFNOAEFOKBK, FBEGICLPDIH FGGLIDIFHFD, bool IMOPLNILDHP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct ENFHFAEOGEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct NOFBPAAJCMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public DGDKDOCHPEF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6537660", Offset = "0x6536A60", VA = "0x186537660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6537AA0", Offset = "0x6536EA0", VA = "0x186537AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x652A930", Offset = "0x6529D30", VA = "0x18652A930")]
	[AsyncStateMachine(typeof(NOFBPAAJCMH))]
	public static Task OLPPMELFJKG(DGDKDOCHPEF HMDOIKIDPEL, DCOJCHOOLIN MFNOAEFOKBK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct CLBJAEDNDMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct ACLDGGEOIMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public DGDKDOCHPEF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x65239B0", Offset = "0x6522DB0", VA = "0x1865239B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x6523BC0", Offset = "0x6522FC0", VA = "0x186523BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class COOHLFGFGHB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public COOHLFGFGHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x653CB60", Offset = "0x653BF60", VA = "0x18653CB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x653CEF0", Offset = "0x653C2F0", VA = "0x18653CEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public COOHLFGFGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x65299B0", Offset = "0x6528DB0", VA = "0x1865299B0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task IAIOIPJGIFP(NKOLFLIKMKN<string>.JNCJJIKLGBC timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct CENMEKFAIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public CLBJAEDNDMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6527E50", Offset = "0x6527250", VA = "0x186527E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x65287B0", Offset = "0x6527BB0", VA = "0x1865287B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class MHPLDBKPOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public KHNJGFFJIHB version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MHPLDBKPOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6534A90", Offset = "0x6533E90", VA = "0x186534A90")]
		internal object KHOAFPPEFAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x65349E0", Offset = "0x6533DE0", VA = "0x1865349E0")]
		internal object EKOFFMBDMGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private DCOJCHOOLIN MFNOAEFOKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private ENAELKBIJPI OAMIDHBGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool LLOPCDNIEGG;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly ByteString IEPPMENNNOM;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6528EC0", Offset = "0x65282C0", VA = "0x186528EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private ONOFAHGAHLG DEGGNNNCMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x65295F0", Offset = "0x65289F0", VA = "0x1865295F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x65297D0", Offset = "0x6528BD0", VA = "0x1865297D0")]
	[AsyncStateMachine(typeof(ACLDGGEOIMO))]
	public static Task OLPPMELFJKG(DGDKDOCHPEF HMDOIKIDPEL, DCOJCHOOLIN MFNOAEFOKBK, ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ, bool LLOPCDNIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6529690", Offset = "0x6528A90", VA = "0x186529690")]
	[AsyncStateMachine(typeof(CENMEKFAIID))]
	private Task OLPPMELFJKG(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6528F50", Offset = "0x6528350", VA = "0x186528F50")]
	private void FDNMOFHPIKJ([NotNull] JFMKOBKPDPB CKKGBMAMDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6528F10", Offset = "0x6528310", VA = "0x186528F10")]
	private bool EMDHJKJCCPM(KHNJGFFJIHB OMDPMMKPCNP, JFMKOBKPDPB CKKGBMAMDIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct CIOLFOFEDEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct NCGFHGGLHLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder<DCOJCHOOLIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public CIOLFOFEDEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public DGOIDAAGJMM.GBBIGAJCJHD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<(KKHLNMGODKL<HACDKHOAAEM, NOJMEPFJKIM>, KKHLNMGODKL<MKCMBBHNGLH<JFMKOBKPDPB>, NOJMEPFJKIM>, KKHLNMGODKL<MKCMBBHNGLH<ODLEKMGFHLE>, NOJMEPFJKIM>, KKHLNMGODKL<MKCMBBHNGLH<BCPGLEEKCAN>, NOJMEPFJKIM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x6534CB0", Offset = "0x65340B0", VA = "0x186534CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6535670", Offset = "0x6534A70", VA = "0x186535670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct DLIKHDFOKGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<HACDKHOAAEM, NOJMEPFJKIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public CIOLFOFEDEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public DGOIDAAGJMM.GBBIGAJCJHD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter<KKHLNMGODKL<HACDKHOAAEM, NOJMEPFJKIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x65444B0", Offset = "0x65438B0", VA = "0x1865444B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6544A70", Offset = "0x6543E70", VA = "0x186544A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private LMFGFFJLHFK<IODJBGDFNFE, ODLEKMGFHLE> KFGMMEABGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private LMFGFFJLHFK<IODJBGDFNFE, JFMKOBKPDPB> DKDIEOPKNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private LMFGFFJLHFK<long, BCPGLEEKCAN> CEAIJMMKDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private MMGEAALKNAM PKLDENFPKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private KLIMJDPIFED IHDIFNFCKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private KFLDBIMKFED AOBFILOHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private string AIMMPKDBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private IODJBGDFNFE JAMOLIKGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private IODJBGDFNFE MDKKFDHBGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private long JIHPABAMAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x65289C0", Offset = "0x6527DC0", VA = "0x1865289C0")]
	public static Task<DCOJCHOOLIN> CMIHGDKEBME(DGDKDOCHPEF HMDOIKIDPEL, [In] ICIFAIJGMOL MFNOAEFOKBK, DGOIDAAGJMM.GBBIGAJCJHD LDBENHHHMBE, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6528D30", Offset = "0x6528130", VA = "0x186528D30")]
	[AsyncStateMachine(typeof(NCGFHGGLHLP))]
	private Task<DCOJCHOOLIN> OLPPMELFJKG(DGOIDAAGJMM.GBBIGAJCJHD LDBENHHHMBE, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6528810", Offset = "0x6527C10", VA = "0x186528810")]
	[AsyncStateMachine(typeof(DLIKHDFOKGN))]
	private Task<KKHLNMGODKL<HACDKHOAAEM, NOJMEPFJKIM>> CBHIHHOPMCP(string AIMMPKDBJBI, long JIHPABAMAKF, DGOIDAAGJMM.GBBIGAJCJHD LDBENHHHMBE, NKOLFLIKMKN<string>.JNCJJIKLGBC NIOBDEFNFLK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct LOEEDCFMBDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct IPFGBCAHION : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<ICIFAIJGMOL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public LOEEDCFMBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private TaskAwaiter<ICIFAIJGMOL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x654BF80", Offset = "0x654B380", VA = "0x18654BF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x654C380", Offset = "0x654B780", VA = "0x18654C380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct POEAMABPELJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AsyncTaskMethodBuilder<ICIFAIJGMOL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public LOEEDCFMBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<ICIFAIJGMOL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6555890", Offset = "0x6554C90", VA = "0x186555890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6555CC0", Offset = "0x65550C0", VA = "0x186555CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class IBMDOFGLBGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public IBMDOFGLBGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x1408020", Offset = "0x1407420", VA = "0x181408020")]
		internal bool LMDKBGBDGDP(KFLDBIMKFED sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct PDGLJCKHPFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder<ICIFAIJGMOL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public IODJBGDFNFE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public JJABELEOGOG callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private IBMDOFGLBGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public HEOGHGPPAKP roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private KLIMJDPIFED <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private KFLDBIMKFED <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private IODJBGDFNFE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private IODJBGDFNFE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter<KLIMJDPIFED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<NEKAJBGAFOL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<FIJFPBAMPLD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x65533F0", Offset = "0x65527F0", VA = "0x1865533F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x6554530", Offset = "0x6553930", VA = "0x186554530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private POFEKCBIEJO KJKMOLPCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private HEOGHGPPAKP OLOFJAKDEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long MAONELICPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private long JNIJNNCDCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private long PFBFKOLLAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private string NIJJKNDDJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private IODJBGDFNFE GHJJHHAPOHD;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x654E8B0", Offset = "0x654DCB0", VA = "0x18654E8B0")]
	public static Task<ICIFAIJGMOL> CMIHGDKEBME(DGDKDOCHPEF HMDOIKIDPEL, DNPPEJGLHLI NCCHHGAPAOP, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x654EE30", Offset = "0x654E230", VA = "0x18654EE30")]
	[AsyncStateMachine(typeof(IPFGBCAHION))]
	private Task<ICIFAIJGMOL> OLPPMELFJKG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x654ECD0", Offset = "0x654E0D0", VA = "0x18654ECD0")]
	[AsyncStateMachine(typeof(POEAMABPELJ))]
	private Task<ICIFAIJGMOL> CPKGMPMHJAB(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x654EB30", Offset = "0x654DF30", VA = "0x18654EB30")]
	[AsyncStateMachine(typeof(PDGLJCKHPFD))]
	private static Task<ICIFAIJGMOL> CPKGMPMHJAB(JJABELEOGOG CBKELGPMNJD, HEOGHGPPAKP OLOFJAKDEHF, long MAONELICPNP, long JNIJNNCDCAA, long PFBFKOLLAFL, string NIJJKNDDJLJ, IODJBGDFNFE GHJJHHAPOHD, CancellationToken HNLFPBLPOKJ, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x654E880", Offset = "0x654DC80", VA = "0x18654E880")]
	private void CECLNIOHJHA(KLIMJDPIFED IHDIFNFCKLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct JBPFHNLJKEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct ENJDIIKPACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JBPFHNLJKEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x6545990", Offset = "0x6544D90", VA = "0x186545990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6545F20", Offset = "0x6545320", VA = "0x186545F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private JJABELEOGOG CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private DCOJCHOOLIN MFNOAEFOKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private float COOAHFFGKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private float FPDDHNBBPKN;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x654C6B0", Offset = "0x654BAB0", VA = "0x18654C6B0")]
	public static Task NPECHHKBPLK(DGDKDOCHPEF HMDOIKIDPEL, DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x654C850", Offset = "0x654BC50", VA = "0x18654C850")]
	[AsyncStateMachine(typeof(ENJDIIKPACK))]
	public Task OLPPMELFJKG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x654C3F0", Offset = "0x654B7F0", VA = "0x18654C3F0")]
	private static void AGMFJNOKCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x654C530", Offset = "0x654B930", VA = "0x18654C530")]
	private void MEEKNCIINKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x654C970", Offset = "0x654BD70", VA = "0x18654C970")]
	private static float PADFKAFEFHH(JJABELEOGOG CBKELGPMNJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x654C690", Offset = "0x654BA90", VA = "0x18654C690")]
	private static float NFCCAJBHAII()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct LOKBLLICFJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct GAKLOLILCPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public ENAELKBIJPI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private MDFBCIKEPAJ <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private DGDKDOCHPEF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private OEODJLLFCFN.NPECFLCNJGE <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6547330", Offset = "0x6546730", VA = "0x186547330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6547CD0", Offset = "0x65470D0", VA = "0x186547CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct HPFFBDLFLGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x654B240", Offset = "0x654A640", VA = "0x18654B240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x654B530", Offset = "0x654A930", VA = "0x18654B530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x654F0C0", Offset = "0x654E4C0", VA = "0x18654F0C0")]
	[AsyncStateMachine(typeof(GAKLOLILCPF))]
	public static Task OLPPMELFJKG(ENAELKBIJPI OAMIDHBGBJD, DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x654F200", Offset = "0x654E600", VA = "0x18654F200")]
	private static Task<FABBKACGCKD> PELHHLGGEHB(ENAELKBIJPI OAMIDHBGBJD, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x654F000", Offset = "0x654E400", VA = "0x18654F000")]
	[AsyncStateMachine(typeof(HPFFBDLFLGD))]
	private static Task IKCENGJBNKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct PCFHEHBLMJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct PHNFBHMPCJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public PCFHEHBLMJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x65545A0", Offset = "0x65539A0", VA = "0x1865545A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6554C50", Offset = "0x6554050", VA = "0x186554C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class LICJFENIAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LICJFENIAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x654E800", Offset = "0x654DC00", VA = "0x18654E800")]
		internal object GBBPKMOBKCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct JLENEKCMONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public PCFHEHBLMJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private BOFEHLDLNAG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x654CD60", Offset = "0x654C160", VA = "0x18654CD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x654D320", Offset = "0x654C720", VA = "0x18654D320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private bool PBKDCJECJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private CancellationToken HNLFPBLPOKJ;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6552CA0", Offset = "0x65520A0", VA = "0x186552CA0")]
	public static Task CKOJJAEDICA(DGDKDOCHPEF HMDOIKIDPEL, bool PBKDCJECJIC, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken FFFPEBPPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6552E40", Offset = "0x6552240", VA = "0x186552E40")]
	[AsyncStateMachine(typeof(PHNFBHMPCJJ))]
	private Task OLPPMELFJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6552D10", Offset = "0x6552110", VA = "0x186552D10")]
	[AsyncStateMachine(typeof(JLENEKCMONB))]
	private Task FJGHECACKAB(bool OAOJJHJJHNM, string DNOMIJHONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	private bool LALGELAMHEN(bool PBKDCJECJIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct GCPJPFADCIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct IPBCJFFGAJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public GCPJPFADCIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x654B9A0", Offset = "0x654ADA0", VA = "0x18654B9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x654BF10", Offset = "0x654B310", VA = "0x18654BF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class MGDCGDOAMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MGDCGDOAMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x654F990", Offset = "0x654ED90", VA = "0x18654F990")]
		internal object GBBPKMOBKCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct OKFLAMKDJBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public GCPJPFADCIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private BOFEHLDLNAG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x65519B0", Offset = "0x6550DB0", VA = "0x1865519B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x6551F70", Offset = "0x6551370", VA = "0x186551F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private OCONMGGEDCG JODNHFEEIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private bool FMGEBECPDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private DCOJCHOOLIN MFNOAEFOKBK;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6547E80", Offset = "0x6547280", VA = "0x186547E80")]
	public static Task<Scene> KIFJFOHCCLJ(DGDKDOCHPEF HMDOIKIDPEL, OCONMGGEDCG IFKAJNFLINM, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6547FA0", Offset = "0x65473A0", VA = "0x186547FA0")]
	[AsyncStateMachine(typeof(IPBCJFFGAJA))]
	private Task<Scene> OLPPMELFJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6547F70", Offset = "0x6547370", VA = "0x186547F70")]
	private bool NLCNEJNDEIO(DCOJCHOOLIN MFNOAEFOKBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6547F00", Offset = "0x6547300", VA = "0x186547F00")]
	private void LFMBMCDLCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6547D30", Offset = "0x6547130", VA = "0x186547D30")]
	[AsyncStateMachine(typeof(OKFLAMKDJBC))]
	private Task<Scene> FJGHECACKAB(string DNOMIJHONBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct IDMJHLBLJEO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct BKALJGKGCBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public IDMJHLBLJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public FBEGICLPDIH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public DCOJCHOOLIN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<FBEGICLPDIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6540BD0", Offset = "0x653FFD0", VA = "0x186540BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x65416B0", Offset = "0x6540AB0", VA = "0x1865416B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct HLMJMJBOENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder<FBEGICLPDIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public IDMJHLBLJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public FBEGICLPDIH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x654A690", Offset = "0x6549A90", VA = "0x18654A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x654A970", Offset = "0x6549D70", VA = "0x18654A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly ENAELKBIJPI OAMIDHBGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly POFEKCBIEJO KJKMOLPCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private readonly BMCIOMLNKLB MCOJOLKEAKD;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private MDFBCIKEPAJ INJCMILHDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x4E25E80", Offset = "0x4E25280", VA = "0x184E25E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x654B8C0", Offset = "0x654ACC0", VA = "0x18654B8C0")]
	public IDMJHLBLJEO(ENAELKBIJPI OAMIDHBGBJD, POFEKCBIEJO KJKMOLPCOFM, BMCIOMLNKLB MCOJOLKEAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x654B5B0", Offset = "0x654A9B0", VA = "0x18654B5B0")]
	[AsyncStateMachine(typeof(BKALJGKGCBP))]
	public Task<FBEGICLPDIH> COOACBIFPHH(FBEGICLPDIH JELIDKMIELG, DCOJCHOOLIN BOFKBJADHJK, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ, bool PPBKGOKHGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x654B730", Offset = "0x654AB30", VA = "0x18654B730")]
	[AsyncStateMachine(typeof(HLMJMJBOENM))]
	private Task<FBEGICLPDIH> HGBJHNKJIIH(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, FBEGICLPDIH ILNNMFPHEJI, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x654B890", Offset = "0x654AC90", VA = "0x18654B890")]
	private bool OOAGLIDBKDO(FBEGICLPDIH APGMPGNADJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x654B590", Offset = "0x654A990", VA = "0x18654B590")]
	private void BDAJDFAFKKC(string NIKIKIFBAIK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct EACIBDAJPKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct LGEKHLDALBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public MDFBCIKEPAJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public POIONMCIPEE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private LLMJNNBAAIC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private List<(PersistenceView, NEEDBNPPDKD)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private (PersistenceView, NEEDBNPPDKD) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x654E190", Offset = "0x654D590", VA = "0x18654E190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x654E7A0", Offset = "0x654DBA0", VA = "0x18654E7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6544C20", Offset = "0x6544020", VA = "0x186544C20")]
	[AsyncStateMachine(typeof(LGEKHLDALBD))]
	public static Task OLPPMELFJKG(MDFBCIKEPAJ EHEFAPJMEBE, DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct PNOADIDONJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct FEKMINBKJJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public MDFBCIKEPAJ operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public POIONMCIPEE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private KHNJGFFJIHB <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private LLMJNNBAAIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private List<(PersistenceView, NEEDBNPPDKD)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private NEEDBNPPDKD <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6545F80", Offset = "0x6545380", VA = "0x186545F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x65467D0", Offset = "0x6545BD0", VA = "0x1865467D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x6555750", Offset = "0x6554B50", VA = "0x186555750")]
	[AsyncStateMachine(typeof(FEKMINBKJJH))]
	public static Task OLPPMELFJKG(MDFBCIKEPAJ EHEFAPJMEBE, DCOJCHOOLIN MFNOAEFOKBK, POIONMCIPEE CKIKKEHMCMK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct OEODJLLFCFN
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct NPECFLCNJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public List<HLFIAPIKAIE> ABKJLFALECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public List<NEEDBNPPDKD> ONHMIKGFAPO;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8833F0", Offset = "0x8827F0", VA = "0x1808833F0")]
		public NPECFLCNJGE(List<HLFIAPIKAIE> ABKJLFALECF, List<NEEDBNPPDKD> ONHMIKGFAPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class LOFGINGACEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public IEnumerable<HLFIAPIKAIE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LOFGINGACEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x654EF80", Offset = "0x654E380", VA = "0x18654EF80")]
		internal object BIPPNKDMCCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private DGDKDOCHPEF HMDOIKIDPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private DCOJCHOOLIN MFNOAEFOKBK;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private JJABELEOGOG GNGCPKKOKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x6550F20", Offset = "0x6550320", VA = "0x186550F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x65516F0", Offset = "0x6550AF0", VA = "0x1865516F0")]
	public static NPECFLCNJGE OLPPMELFJKG(DGDKDOCHPEF HMDOIKIDPEL, DCOJCHOOLIN MFNOAEFOKBK)
	{
		return default(NPECFLCNJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6551750", Offset = "0x6550B50", VA = "0x186551750")]
	private NPECFLCNJGE OLPPMELFJKG()
	{
		return default(NPECFLCNJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6551140", Offset = "0x6550540", VA = "0x186551140")]
	private NPECFLCNJGE NELPLAHLFLP(JFMKOBKPDPB CKKGBMAMDIC, KHNJGFFJIHB AKFDDOIJBOM)
	{
		return default(NPECFLCNJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6550F70", Offset = "0x6550370", VA = "0x186550F70")]
	private bool BFAONBKBGIL(IEnumerable<HLFIAPIKAIE> ABKJLFALECF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct MOPBPBNGHCO
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class GJJCBECHKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public OEODJLLFCFN.NPECFLCNJGE instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GJJCBECHKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x65480C0", Offset = "0x65474C0", VA = "0x1865480C0")]
		internal object IAIOIPJGIFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class LOOMNDPKLII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public LOOMNDPKLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x654F270", Offset = "0x654E670", VA = "0x18654F270")]
		internal object CCDECDFKAHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x6550600", Offset = "0x654FA00", VA = "0x186550600")]
	public static void OLPPMELFJKG(MDFBCIKEPAJ EHEFAPJMEBE, DCOJCHOOLIN MFNOAEFOKBK, OEODJLLFCFN.NPECFLCNJGE APBKIJKNFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class BMCIOMLNKLB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct GOFAJPFGHBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public FBEGICLPDIH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public DCOJCHOOLIN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6548810", Offset = "0x6547C10", VA = "0x186548810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x6548F80", Offset = "0x6548380", VA = "0x186548F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class AGDAFLCFAOE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public AGDAFLCFAOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x6555F30", Offset = "0x6555330", VA = "0x186555F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x65561F0", Offset = "0x65555F0", VA = "0x1865561F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AGDAFLCFAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x653D880", Offset = "0x653CC80", VA = "0x18653D880")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task EAMGPJAKFGC(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct ELBKKBIPHLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private AGDAFLCFAOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x6545400", Offset = "0x6544800", VA = "0x186545400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x6545930", Offset = "0x6544D30", VA = "0x186545930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct HLCMDKHAFCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private Dictionary<Guid, List<OBMNMGFPPJO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x654A080", Offset = "0x6549480", VA = "0x18654A080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x654A630", Offset = "0x6549A30", VA = "0x18654A630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct JMBEEKMJPGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private NKOLFLIKMKN<string>.JNCJJIKLGBC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private Dictionary<Guid, List<OBMNMGFPPJO>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x654D380", Offset = "0x654C780", VA = "0x18654D380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x654DA00", Offset = "0x654CE00", VA = "0x18654DA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class HCALDIGBLEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public OBMNMGFPPJO handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public HCALDIGBLEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x6555D30", Offset = "0x6555130", VA = "0x186555D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x6555ED0", Offset = "0x65552D0", VA = "0x186555ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public MIMLCDFHOBH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public List<OBMNMGFPPJO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HCALDIGBLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x6549650", Offset = "0x6548A50", VA = "0x186549650")]
		internal object AEIAPFPOAOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x6549740", Offset = "0x6548B40", VA = "0x186549740")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task FNBMBPBPJBN(OBMNMGFPPJO handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6549830", Offset = "0x6548C30", VA = "0x186549830")]
		internal object HKNCNFELLGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct CBBCLNCFNDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public MIMLCDFHOBH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public List<OBMNMGFPPJO> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private HCALDIGBLEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x6542680", Offset = "0x6541A80", VA = "0x186542680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6542B50", Offset = "0x6541F50", VA = "0x186542B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct HBENECILJBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x6549030", Offset = "0x6548430", VA = "0x186549030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x65495F0", Offset = "0x65489F0", VA = "0x1865495F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class BHDJOOPEONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BHDJOOPEONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x6540B60", Offset = "0x653FF60", VA = "0x186540B60")]
		internal object IINLDJGIIMC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct KGCIEBEDDMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public DCOJCHOOLIN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x654DC00", Offset = "0x654D000", VA = "0x18654DC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x654E0C0", Offset = "0x654D4C0", VA = "0x18654E0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class AKOOJDPLJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AKOOJDPLJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x653D970", Offset = "0x653CD70", VA = "0x18653D970")]
		internal object IEPCNGDLENO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct EJLCGDLJDMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public BMCIOMLNKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6544D60", Offset = "0x6544160", VA = "0x186544D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x65453A0", Offset = "0x65447A0", VA = "0x1865453A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class KGDPLJNLLKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KGDPLJNLLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x654E120", Offset = "0x654D520", VA = "0x18654E120")]
		internal object AJDHKBKIDEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private readonly ENAELKBIJPI OAMIDHBGBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private DFAFIJBJAFF MCOJOLKEAKD;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private MDFBCIKEPAJ INJCMILHDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xFD6150", Offset = "0xFD5550", VA = "0x180FD6150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public BMCIOMLNKLB(ENAELKBIJPI OAMIDHBGBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x65422B0", Offset = "0x65416B0", VA = "0x1865422B0")]
	[AsyncStateMachine(typeof(GOFAJPFGHBP))]
	public Task OLPPMELFJKG(FBEGICLPDIH FGGLIDIFHFD, DCOJCHOOLIN BOFKBJADHJK, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6542400", Offset = "0x6541800", VA = "0x186542400")]
	[AsyncStateMachine(typeof(ELBKKBIPHLG))]
	private Task PCFBPICNEJD(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6541B60", Offset = "0x6540F60", VA = "0x186541B60")]
	[AsyncStateMachine(typeof(HLCMDKHAFCB))]
	private Task ILJLKLNDLAH(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6541900", Offset = "0x6540D00", VA = "0x186541900")]
	[AsyncStateMachine(typeof(JMBEEKMJPGL))]
	private Task BEOHBGCJKMB(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6542020", Offset = "0x6541420", VA = "0x186542020")]
	[AsyncStateMachine(typeof(CBBCLNCFNDA))]
	private Task NEFEBOIABKA(Guid ADANGHJNEFO, List<OBMNMGFPPJO> MAAOHJPPECC, MIMLCDFHOBH FNGADEEHDAF, DCOJCHOOLIN MFNOAEFOKBK, CancellationToken FACMOGNGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6541E30", Offset = "0x6541230", VA = "0x186541E30")]
	[AsyncStateMachine(typeof(HBENECILJBN))]
	private Task MFDCOJKNIGI(DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6542170", Offset = "0x6541570", VA = "0x186542170")]
	[AsyncStateMachine(typeof(KGCIEBEDDMP))]
	private Task NKEBAFEICML(Guid OLAPCKCHMNG, DCOJCHOOLIN MFNOAEFOKBK, NKOLFLIKMKN<string>.JNCJJIKLGBC CBPCKBLKEKD, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6542540", Offset = "0x6541940", VA = "0x186542540")]
	[AsyncStateMachine(typeof(EJLCGDLJDMJ))]
	private Task PCIGIBFDJEL(Guid OLAPCKCHMNG, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x6541A40", Offset = "0x6540E40", VA = "0x186541A40")]
	private void EOIFOMBMCJK(Guid OLAPCKCHMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x6541F70", Offset = "0x6541370", VA = "0x186541F70")]
	private void NALNMDKGIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6541CA0", Offset = "0x65410A0", VA = "0x186541CA0")]
	public Guid JONENFFNGKP(FBEGICLPDIH FBOCGGGDNLA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6541720", Offset = "0x6540B20", VA = "0x186541720")]
	[CompilerGenerated]
	private object AIIEBICLMAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct IGEACEPBJLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	public readonly bool FJDAHGLFILJ;

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xC46BA0", Offset = "0xC45FA0", VA = "0x180C46BA0")]
	public IGEACEPBJLE(bool CCPDIBHMINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct DODBLFCGAMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public readonly JFMKOBKPDPB? HBEFEJAPAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	public readonly LLJHOMDAIPF GLKFGJOBPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	public readonly string? HADICCHNEPB;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IReadOnlyCollection<string> GABFINDOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x6544AE0", Offset = "0x6543EE0", VA = "0x186544AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IReadOnlyDictionary<long, int> IGLNHLCEABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6544B00", Offset = "0x6543F00", VA = "0x186544B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x6544B20", Offset = "0x6543F20", VA = "0x186544B20")]
	public DODBLFCGAMM(JFMKOBKPDPB? ILKGBPMJIJM, LLJHOMDAIPF FOICNHCBKON, string? AIMMPKDBJBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class DIDALCDCLBA : NHBJNBDMONH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct OLIMAELFANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public AsyncTaskMethodBuilder<DODBLFCGAMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public DIDALCDCLBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public NKMLLCBDLBB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public HBOGCGCACNI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private LLMJNNBAAIC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x6552470", Offset = "0x6551870", VA = "0x186552470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6552AE0", Offset = "0x6551EE0", VA = "0x186552AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class OCODGBKGNMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public NKMLLCBDLBB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public DIDALCDCLBA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public OCODGBKGNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6550D00", Offset = "0x6550100", VA = "0x186550D00")]
		internal Task HEKEMIEIDDC(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x6550C20", Offset = "0x6550020", VA = "0x186550C20")]
		internal Task CLIDLDFNJMD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class MPFJNFEHOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public OCODGBKGNMP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MPFJNFEHOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6550BB0", Offset = "0x654FFB0", VA = "0x186550BB0")]
		internal object AOCBJJLEFJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class ANCLIMJBOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public OCODGBKGNMP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ANCLIMJBOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x653D9E0", Offset = "0x653CDE0", VA = "0x18653D9E0")]
		internal Task LHNMECIEDKP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct BFOIICOHEFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public NKMLLCBDLBB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public DIDALCDCLBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private MPFJNFEHOMP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private LLMJNNBAAIC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x653F9E0", Offset = "0x653EDE0", VA = "0x18653F9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x6540250", Offset = "0x653F650", VA = "0x186540250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private static readonly TimeSpan KFFNGFCHBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private readonly CNDCIGPDHLL ACHICFLFGHJ;

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x6544460", Offset = "0x6543860", VA = "0x186544460")]
	public DIDALCDCLBA(ENAELKBIJPI OAMIDHBGBJD, CNDCIGPDHLL ACHICFLFGHJ, AMCJMMGFCLE HILPECKCPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x65438A0", Offset = "0x6542CA0", VA = "0x1865438A0")]
	[AsyncStateMachine(typeof(OLIMAELFANC))]
	public Task<DODBLFCGAMM> LENOCDGJGPN(long JNIJNNCDCAA, HBOGCGCACNI NNCPDPEMMHA, NKMLLCBDLBB HJLJOGJJHDA, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x6544060", Offset = "0x6543460", VA = "0x186544060")]
	[AsyncStateMachine(typeof(BFOIICOHEFD))]
	private Task OJLOBLCKPLL(NKMLLCBDLBB HJLJOGJJHDA, IEnumerable<PersistenceView> LONHAOCNGLL, StringBuilder FDOKKKIPJME, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x6543410", Offset = "0x6542810", VA = "0x186543410")]
	private DODBLFCGAMM HCNHNKHNLOL(long JNIJNNCDCAA, HBOGCGCACNI NNCPDPEMMHA, NKMLLCBDLBB HJLJOGJJHDA, IEnumerable<PersistenceView> LONHAOCNGLL, StringBuilder FDOKKKIPJME)
	{
		return default(DODBLFCGAMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x6543EA0", Offset = "0x65432A0", VA = "0x186543EA0")]
	private JFMKOBKPDPB NEHOPOGGFKO(long JNIJNNCDCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x65441A0", Offset = "0x65435A0", VA = "0x1865441A0")]
	private void OLIIINKPPGK(JFMKOBKPDPB CIFHGECIFMC, StringBuilder FDOKKKIPJME, IEnumerable<PersistenceView> LONHAOCNGLL, [In] OLENPIFNGNM LJLGHMIMKMO, KFMFDOKOAMN JPEMHCLCCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x6543A00", Offset = "0x6542E00", VA = "0x186543A00")]
	private void LGODJEKFCDB(JFMKOBKPDPB CIFHGECIFMC, StringBuilder FDOKKKIPJME, PersistenceView MPAMJPPMOAI, KFMFDOKOAMN JPEMHCLCCFI, [In] OLENPIFNGNM LJLGHMIMKMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class HJJABBPFPPK : NHBJNBDMONH
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class GPCPJMHOOCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public OFJCNAOGFJB.IJKCDLBJPNN roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public GPCPJMHOOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6548FE0", Offset = "0x65483E0", VA = "0x186548FE0")]
		internal object CPBNMNMEMGO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct BFOJHPECGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder<(OFJCNAOGFJB.IJKCDLBJPNN roomDataUpload, OFJCNAOGFJB.IJKCDLBJPNN subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public DODBLFCGAMM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public HJJABBPFPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private GPCPJMHOOCP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private TaskAwaiter<OFJCNAOGFJB.IJKCDLBJPNN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x65402B0", Offset = "0x653F6B0", VA = "0x1865402B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x6540AF0", Offset = "0x653FEF0", VA = "0x186540AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct MFFGHEGHMMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public AsyncTaskMethodBuilder<OGFMKNMGFDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public HJJABBPFPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public DODBLFCGAMM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public NHNEEALDKAA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<(OFJCNAOGFJB.IJKCDLBJPNN roomDataUpload, OFJCNAOGFJB.IJKCDLBJPNN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter<OGFMKNMGFDL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x654F300", Offset = "0x654E700", VA = "0x18654F300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x654F920", Offset = "0x654ED20", VA = "0x18654F920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct FIFNFHKBDFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder<NEKAJBGAFOL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public HJJABBPFPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public DODBLFCGAMM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private TaskAwaiter<(OFJCNAOGFJB.IJKCDLBJPNN roomDataUpload, OFJCNAOGFJB.IJKCDLBJPNN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter<NEKAJBGAFOL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x6546830", Offset = "0x6545C30", VA = "0x186546830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x6546C50", Offset = "0x6546050", VA = "0x186546C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class CFOMCFJJIPE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			public CFOMCFJJIPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			private FABBKACGCKD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			private TaskAwaiter<NEKAJBGAFOL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private TaskAwaiter<OGFMKNMGFDL> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private TaskAwaiter<FABBKACGCKD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x6556250", Offset = "0x6555650", VA = "0x186556250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x65571E0", Offset = "0x65565E0", VA = "0x1865571E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public HJJABBPFPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public DODBLFCGAMM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public NHNEEALDKAA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public IGEACEPBJLE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CFOMCFJJIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x6542C50", Offset = "0x6542050", VA = "0x186542C50")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FABBKACGCKD> OLGEJCHPIAK(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct GKOBGBIBKHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public AsyncTaskMethodBuilder<FABBKACGCKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public HJJABBPFPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public DODBLFCGAMM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public NHNEEALDKAA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public IGEACEPBJLE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public NKOLFLIKMKN<string>.JNCJJIKLGBC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<FABBKACGCKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x6548170", Offset = "0x6547570", VA = "0x186548170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x6548480", Offset = "0x6547880", VA = "0x186548480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private static readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private static readonly AMCJMMGFCLE PJNEEFMCKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private readonly LMFMLKBIFFO JIIHIOFMNOA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private DGDKDOCHPEF FJLPFGBGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x6526DD0", Offset = "0x65261D0", VA = "0x186526DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x6549FF0", Offset = "0x65493F0", VA = "0x186549FF0")]
	public HJJABBPFPPK(ENAELKBIJPI OAMIDHBGBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6549B30", Offset = "0x6548F30", VA = "0x186549B30")]
	[AsyncStateMachine(typeof(BFOJHPECGPP))]
	private Task<(OFJCNAOGFJB.IJKCDLBJPNN, OFJCNAOGFJB.IJKCDLBJPNN)> JIAGHKAGKME(DODBLFCGAMM BALEBDNJLEM, long MAONELICPNP, long PHJIFAMIALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6549C70", Offset = "0x6549070", VA = "0x186549C70")]
	[AsyncStateMachine(typeof(MFFGHEGHMMM))]
	public Task<OGFMKNMGFDL> LAJLNDMEIKI(int GMOKELEHOGA, [CanBeNull] NHNEEALDKAA AHAIOEKHGEF, DODBLFCGAMM BALEBDNJLEM, long MAONELICPNP, long PHJIFAMIALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6549DE0", Offset = "0x65491E0", VA = "0x186549DE0")]
	[AsyncStateMachine(typeof(FIFNFHKBDFA))]
	private Task<NEKAJBGAFOL> PDJAOJCLBJA(string NIJJKNDDJLJ, int GMOKELEHOGA, DODBLFCGAMM BALEBDNJLEM, long MAONELICPNP, long PHJIFAMIALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6549990", Offset = "0x6548D90", VA = "0x186549990")]
	[AsyncStateMachine(typeof(GKOBGBIBKHE))]
	public Task<FABBKACGCKD> FBLOFIHEHDN(int GMOKELEHOGA, NHNEEALDKAA? AHAIOEKHGEF, DODBLFCGAMM BALEBDNJLEM, long MAONELICPNP, long PHJIFAMIALG, IGEACEPBJLE IEGPEDOLAKH, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class AFKIBOGAOBB<T> where T : AFKIBOGAOBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	internal readonly DGDKDOCHPEF OKHKDMMFIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private int? DDLNDMCKBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	protected readonly Guid DKNPKOBNLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	protected readonly EAMJNAFBIOM ACGLELFGABB;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	protected T DMNHCJPKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x3635120", Offset = "0x3634520", VA = "0x183635120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x36352F0", Offset = "0x36346F0", VA = "0x1836352F0")]
	internal AFKIBOGAOBB(DGDKDOCHPEF ICEDPEJJEFG, EAMJNAFBIOM PDAIHKFBCFA, [Optional] Guid? BMPBDIBKAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3635210", Offset = "0x3634610", VA = "0x183635210")]
	private FABBKACGCKD MACAOBEJONM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
	protected virtual void EDHELNAKGGI(FABBKACGCKD DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3635180", Offset = "0x3634580", VA = "0x183635180")]
	public T EIPJAICOBGP(PFJNLKLKGNM MGJLCIFAFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x3635090", Offset = "0x3634490", VA = "0x183635090")]
	public T BENBDJDDKNB(int AMMPDKFAIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3634F70", Offset = "0x3634370", VA = "0x183634F70", Slot = "5")]
	public virtual Task<BMKDPKMMAEO> AGKAIEOEPGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class JMLHNPPHBLO : AFKIBOGAOBB<JMLHNPPHBLO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private DNPPEJGLHLI MBIDFLHPHHK;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x654DB30", Offset = "0x654CF30", VA = "0x18654DB30")]
	internal JMLHNPPHBLO(DGDKDOCHPEF ICEDPEJJEFG, EAMJNAFBIOM PDAIHKFBCFA, [Optional] Guid? BMPBDIBKAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x5BB5470", Offset = "0x5BB4870", VA = "0x185BB5470")]
	public JMLHNPPHBLO FKNPKKNJCCG(DNPPEJGLHLI MBIDFLHPHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x654DA60", Offset = "0x654CE60", VA = "0x18654DA60", Slot = "4")]
	protected override void EDHELNAKGGI(FABBKACGCKD DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class OKIPFHEPFHJ : AFKIBOGAOBB<OKIPFHEPFHJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum MBEGOIKMFLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct BEDGIMFFHHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<BMKDPKMMAEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public OKIPFHEPFHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private TaskAwaiter<BMKDPKMMAEO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x653F5C0", Offset = "0x653E9C0", VA = "0x18653F5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x653F970", Offset = "0x653ED70", VA = "0x18653F970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private MBEGOIKMFLN HJJOEOCCKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private string FDBKINGLJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private NHNEEALDKAA MBIDFLHPHHK;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6552300", Offset = "0x6551700", VA = "0x186552300")]
	internal OKIPFHEPFHJ(DGDKDOCHPEF ICEDPEJJEFG, EAMJNAFBIOM PDAIHKFBCFA, [Optional] Guid? BMPBDIBKAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x6552240", Offset = "0x6551640", VA = "0x186552240")]
	public OKIPFHEPFHJ GDADPCAHKDE(string NDBGGHMJKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x6552270", Offset = "0x6551670", VA = "0x186552270")]
	public OKIPFHEPFHJ ILPMCBINENL(bool KDLHBGGAKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6552290", Offset = "0x6551690", VA = "0x186552290")]
	public OKIPFHEPFHJ KAJHHPDPOOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x65520D0", Offset = "0x65514D0", VA = "0x1865520D0", Slot = "4")]
	protected override void EDHELNAKGGI(FABBKACGCKD DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6551FE0", Offset = "0x65513E0", VA = "0x186551FE0", Slot = "5")]
	[AsyncStateMachine(typeof(BEDGIMFFHHH))]
	public override Task<BMKDPKMMAEO> AGKAIEOEPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x65522C0", Offset = "0x65516C0", VA = "0x1865522C0")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<BMKDPKMMAEO> MGOBMAGGMDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class DGIMAHOKOFL
{
	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x65432C0", Offset = "0x65426C0", VA = "0x1865432C0")]
	public static void KGFAONBIAAK(this NFLIPHOFKMG FLPPIEBDGEH, JGNOMFHEEPM CHBPJGFAMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x6543240", Offset = "0x6542640", VA = "0x186543240")]
	public static void EIPPHKNHAJI(this JGNOMFHEEPM BIAPCBFJHDG, [Optional] string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class OMDJFBFEPEO
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x6552B50", Offset = "0x6551F50", VA = "0x186552B50")]
	public static IODJBGDFNFE CMJIAHJGBBE(this EAECFMHKNDF DCDKNCLFOJA)
	{
		return default(IODJBGDFNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x6552BF0", Offset = "0x6551FF0", VA = "0x186552BF0")]
	public static EAECFMHKNDF DGHNNHNFEPB(this IODJBGDFNFE IGJIHEHEAPM)
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
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			public ONILDAPJMOO ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public ONILDAPJMOO HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private static ONILDAPJMOO[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private Dictionary<ONILDAPJMOO, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x65578E0", Offset = "0x6556CE0", VA = "0x1865578E0")]
		public bool ANCCEGCGNHJ(ONILDAPJMOO AKLAEAPABKJ, [Out] ResultConfig IEOEELMKLEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x6557950", Offset = "0x6556D50", VA = "0x186557950")]
		public ResultConfig CFGBJLNIFII(ONILDAPJMOO LCAIGDLPJAO, [Optional] HashSet<ONILDAPJMOO> LELJGLFFHGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x6557FF0", Offset = "0x65573F0", VA = "0x186557FF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6557A90", Offset = "0x6556E90", VA = "0x186557A90", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x857600", Offset = "0x856A00", VA = "0x180857600")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class PCOCCJEFCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x6552F30", Offset = "0x6552330", VA = "0x186552F30")]
	[NEHHKLCIMGL(OJLOCLENGNC.GameOnly)]
	private static void EKLFLINKKJI(BHJKECHLECD EAJOHJPGIHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface KNCFAMOEPME : IEquatable<KNCFAMOEPME>
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	DateTime GKIFKKPLLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGMJPGPDPIG();

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHOHDKEAOOD(long MAONELICPNP, long JNIJNNCDCAA, [Out] DODBLFCGAMM BALEBDNJLEM);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class BCECDBDGJMF : HDLCEECDIBP
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class HHGGNPOAEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AMIIJBBMGIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HHGGNPOAEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x6549920", Offset = "0x6548D20", VA = "0x186549920")]
		internal object JDEGHHJJGEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly BNAHHIILFAL PDDFODHOPGE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<KNCFAMOEPME> FMLBJIEKIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x653EEE0", Offset = "0x653E2E0", VA = "0x18653EEE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x653EF90", Offset = "0x653E390", VA = "0x18653EF90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	[UnityEngine.Scripting.Preserve]
	public BCECDBDGJMF([CNGDHLLDFHE(null)] BNAHHIILFAL PDDFODHOPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x653F1B0", Offset = "0x653E5B0", VA = "0x18653F1B0", Slot = "6")]
	public bool NEHIJNNBBNK(long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM, AMIIJBBMGIJ NHAAHCFFLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x1930E00", Offset = "0x1930200", VA = "0x181930E00")]
	private void AFKEIGAMNJM(KNCFAMOEPME DBLMIDLIKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x653F040", Offset = "0x653E440", VA = "0x18653F040", Slot = "7")]
	public bool IIECNIHILIM(long MAONELICPNP, long JNIJNNCDCAA, [Out] KNCFAMOEPME JLHNEGAACPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x653EE30", Offset = "0x653E230", VA = "0x18653EE30", Slot = "8")]
	public bool BBPHPLDIPAB(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, [Out] KNCFAMOEPME JLHNEGAACPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x653EA00", Offset = "0x653DE00", VA = "0x18653EA00")]
	private void AADBBICHCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x653F490", Offset = "0x653E890", VA = "0x18653F490", Slot = "9")]
	public void OHHDELHIAAI(long MAONELICPNP, long JNIJNNCDCAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class PNNEDKKHOEE : BNAHHIILFAL
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum JEPHGHIENBB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class JFBFOEKBDKH : IEnumerable<KNCFAMOEPME>, IEnumerable, IEnumerator<KNCFAMOEPME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private KNCFAMOEPME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public PNNEDKKHOEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private AMIIJBBMGIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public AMIIJBBMGIJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private KNCFAMOEPME System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public JFBFOEKBDKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x654CA30", Offset = "0x654BE30", VA = "0x18654CA30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x654CD10", Offset = "0x654C110", VA = "0x18654CD10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x654CC60", Offset = "0x654C060", VA = "0x18654CC60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KNCFAMOEPME> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x654CC60", Offset = "0x654C060", VA = "0x18654CC60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class CCIEDIHJFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public AMIIJBBMGIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CCIEDIHJFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6542BB0", Offset = "0x6541FB0", VA = "0x186542BB0")]
		internal object LJBJCPJNDPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class IFIIJAFFNMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public PNNEDKKHOEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public IFIIJAFFNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x654B920", Offset = "0x654AD20", VA = "0x18654B920")]
		internal void GEFGGOGJNEI(LLKDDOCFBKA.PKNMNGHACJJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	protected readonly string KBEBFFEDJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private readonly object FBIPDJDIPPJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract DOONEMIFOAF GJNELADOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x65556B0", Offset = "0x6554AB0", VA = "0x1865556B0")]
	protected PNNEDKKHOEE([CanBeNull] string IMMFEEFHNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6554CB0", Offset = "0x65540B0", VA = "0x186554CB0", Slot = "5")]
	public bool ANCLFMPFLCP(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, [Out] KNCFAMOEPME DBLMIDLIKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6555290", Offset = "0x6554690", VA = "0x186555290", Slot = "6")]
	[IteratorStateMachine(typeof(JFBFOEKBDKH))]
	public IEnumerable<KNCFAMOEPME> IDBKEPOAGNM(AMIIJBBMGIJ NHAAHCFFLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DOGLLOAANPL(Stream GMMDNBPGCAN, long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool ALKODJOFJAA(Stream GNFFHFIFOGL, long MAONELICPNP, long JNIJNNCDCAA, MGKCFFGFHKH HMPHDBOHEKN, [Out] DODBLFCGAMM BALEBDNJLEM);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x6554F10", Offset = "0x6554310", VA = "0x186554F10", Slot = "7")]
	public KNCFAMOEPME HLHDIAOILGD(long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM, AMIIJBBMGIJ NHAAHCFFLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LBEAKFBPPHK(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, JEPHGHIENBB BDEFFCAPJNC);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ACBOJPJPHIE(AMIIJBBMGIJ NHAAHCFFLBH, JEPHGHIENBB BDEFFCAPJNC);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x6554EA0", Offset = "0x65542A0", VA = "0x186554EA0")]
	protected void FMGPPAMPNJN(LLKDDOCFBKA.PKNMNGHACJJ CMCPAKJLGJC, string NIKIKIFBAIK, FileInfo CEEJEFLOGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x6555320", Offset = "0x6554720", VA = "0x186555320")]
	internal bool JOEPBIMOCBA(FileInfo COPBOGHOODE, long MAONELICPNP, long JNIJNNCDCAA, [Out] DODBLFCGAMM BALEBDNJLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private void NEODDCLLLNP(Exception NGHCMOPLFIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class MKOPBALDGBK : PNNEDKKHOEE
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override DOONEMIFOAF GJNELADOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA95230", Offset = "0xA94630", VA = "0x180A95230", Slot = "8")]
		get
		{
			return default(DOONEMIFOAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x6550540", Offset = "0x654F940", VA = "0x186550540")]
	public MKOPBALDGBK([Optional] string IMMFEEFHNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6550140", Offset = "0x654F540", VA = "0x186550140")]
	private void BBDGABHMFEI(AMIIJBBMGIJ NHAAHCFFLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x65501C0", Offset = "0x654F5C0", VA = "0x1865501C0", Slot = "9")]
	internal override void DOGLLOAANPL(Stream GMMDNBPGCAN, long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x654FAF0", Offset = "0x654EEF0", VA = "0x18654FAF0", Slot = "10")]
	internal override bool ALKODJOFJAA(Stream GNFFHFIFOGL, long MAONELICPNP, long JNIJNNCDCAA, MGKCFFGFHKH HMPHDBOHEKN, [Out] DODBLFCGAMM BALEBDNJLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6550450", Offset = "0x654F850", VA = "0x186550450", Slot = "11")]
	protected override FileInfo LBEAKFBPPHK(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, JEPHGHIENBB BDEFFCAPJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x654F9E0", Offset = "0x654EDE0", VA = "0x18654F9E0", Slot = "12")]
	protected override DirectoryInfo ACBOJPJPHIE(AMIIJBBMGIJ NHAAHCFFLBH, JEPHGHIENBB BDEFFCAPJNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class APJNHFDPPDP : PNNEDKKHOEE
{
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private static readonly byte[] KCGLPAPOILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private readonly byte[] DNBDINCCPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private readonly byte[] PBNKKPBLCCM;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override DOONEMIFOAF GJNELADOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x54802F0", Offset = "0x547F6F0", VA = "0x1854802F0", Slot = "8")]
		get
		{
			return default(DOONEMIFOAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x653E8A0", Offset = "0x653DCA0", VA = "0x18653E8A0")]
	public APJNHFDPPDP([Optional] string IMMFEEFHNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x653E360", Offset = "0x653D760", VA = "0x18653E360", Slot = "9")]
	internal override void DOGLLOAANPL(Stream GMMDNBPGCAN, long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x653DB30", Offset = "0x653CF30", VA = "0x18653DB30", Slot = "10")]
	internal override bool ALKODJOFJAA(Stream GNFFHFIFOGL, long MAONELICPNP, long JNIJNNCDCAA, MGKCFFGFHKH HMPHDBOHEKN, [Out] DODBLFCGAMM BALEBDNJLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x653E750", Offset = "0x653DB50", VA = "0x18653E750")]
	private void LNEPKEAILIO(byte[] PEBEDGMMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x653E620", Offset = "0x653DA20", VA = "0x18653E620", Slot = "11")]
	protected override FileInfo LBEAKFBPPHK(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, JEPHGHIENBB BDEFFCAPJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x653DA20", Offset = "0x653CE20", VA = "0x18653DA20", Slot = "12")]
	protected override DirectoryInfo ACBOJPJPHIE(AMIIJBBMGIJ NHAAHCFFLBH, JEPHGHIENBB BDEFFCAPJNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum DOONEMIFOAF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class HMMEBDGIPDF : BNAHHIILFAL
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class DBKHCBIAFBK : IEnumerable<KNCFAMOEPME>, IEnumerable, IEnumerator<KNCFAMOEPME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private KNCFAMOEPME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public HMMEBDGIPDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private AMIIJBBMGIJ autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public AMIIJBBMGIJ <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private DOONEMIFOAF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private IEnumerator<KNCFAMOEPME> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		private KNCFAMOEPME System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public DBKHCBIAFBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x65431B0", Offset = "0x65425B0", VA = "0x1865431B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6542DD0", Offset = "0x65421D0", VA = "0x186542DD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6542D80", Offset = "0x6542180", VA = "0x186542D80")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x6543160", Offset = "0x6542560", VA = "0x186543160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x65430B0", Offset = "0x65424B0", VA = "0x1865430B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KNCFAMOEPME> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x65430B0", Offset = "0x65424B0", VA = "0x1865430B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly DOONEMIFOAF[] INBBBBHLAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private readonly Dictionary<DOONEMIFOAF, BNAHHIILFAL> MJNBPFGJGCM;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DOONEMIFOAF GJNELADOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x654AB30", Offset = "0x6549F30", VA = "0x18654AB30", Slot = "4")]
		get
		{
			return default(DOONEMIFOAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x654AEF0", Offset = "0x654A2F0", VA = "0x18654AEF0")]
	[UnityEngine.Scripting.Preserve]
	public HMMEBDGIPDF(params BNAHHIILFAL[] CFFIFPHMELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x654A9E0", Offset = "0x6549DE0", VA = "0x18654A9E0", Slot = "5")]
	public bool ANCLFMPFLCP(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, [Out] KNCFAMOEPME DBLMIDLIKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x654AC40", Offset = "0x654A040", VA = "0x18654AC40")]
	private void HMCAELDLHNC(int JIECBFAHJDD, long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x654AE60", Offset = "0x654A260", VA = "0x18654AE60", Slot = "6")]
	[IteratorStateMachine(typeof(DBKHCBIAFBK))]
	public IEnumerable<KNCFAMOEPME> IDBKEPOAGNM(AMIIJBBMGIJ NHAAHCFFLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x654AB60", Offset = "0x6549F60", VA = "0x18654AB60", Slot = "7")]
	public KNCFAMOEPME HLHDIAOILGD(long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM, AMIIJBBMGIJ NHAAHCFFLBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class GLJPMANPHGH
{
	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x65486D0", Offset = "0x6547AD0", VA = "0x1865486D0")]
	internal static byte[] MMLMPFALIGM(byte[] PEBEDGMMHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6548790", Offset = "0x6547B90", VA = "0x186548790")]
	public static void PIEFOELNHDO(Stream FOBHMMKPKFP, byte[] NMHCCNFFGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x65484F0", Offset = "0x65478F0", VA = "0x1865484F0")]
	public static bool DBAMEBBDAGE(Stream FOBHMMKPKFP, long JJBKAEOPIKA, MGKCFFGFHKH EHPDMCAMOCD, [Out] byte[] CJMNKIPPLLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class FMMJFDGDFIP : KNCFAMOEPME, IEquatable<KNCFAMOEPME>, IEquatable<FMMJFDGDFIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private readonly PNNEDKKHOEE GFINBOIPBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	public readonly FileInfo HJEBBFCMHOO;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public DOONEMIFOAF GJNELADOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1EC4260", Offset = "0x1EC3660", VA = "0x181EC4260", Slot = "9")]
		get
		{
			return default(DOONEMIFOAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public DateTime GKIFKKPLLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x6546CC0", Offset = "0x65460C0", VA = "0x186546CC0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x6547220", Offset = "0x6546620", VA = "0x186547220")]
	public FMMJFDGDFIP(PNNEDKKHOEE IPJJFPOCAGP, FileInfo COPBOGHOODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6547170", Offset = "0x6546570", VA = "0x186547170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6546D50", Offset = "0x6546150", VA = "0x186546D50", Slot = "5")]
	public void BGMJPGPDPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6546E10", Offset = "0x6546210", VA = "0x186546E10", Slot = "6")]
	public bool DHOHDKEAOOD(long MAONELICPNP, long JNIJNNCDCAA, [Out] DODBLFCGAMM BALEBDNJLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6547000", Offset = "0x6546400", VA = "0x186547000", Slot = "7")]
	public bool Equals(KNCFAMOEPME AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x6546E50", Offset = "0x6546250", VA = "0x186546E50", Slot = "8")]
	public bool Equals(FMMJFDGDFIP AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6546F10", Offset = "0x6546310", VA = "0x186546F10", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x65470E0", Offset = "0x65464E0", VA = "0x1865470E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void MGKCFFGFHKH(LLKDDOCFBKA.PKNMNGHACJJ KOKCKEKAJAD, string DCKDMGKGDFN);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface BNAHHIILFAL
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DOONEMIFOAF GJNELADOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANCLFMPFLCP(long MAONELICPNP, long JNIJNNCDCAA, AMIIJBBMGIJ NHAAHCFFLBH, [Out] KNCFAMOEPME DBLMIDLIKMI);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KNCFAMOEPME> IDBKEPOAGNM(AMIIJBBMGIJ NHAAHCFFLBH);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KNCFAMOEPME HLHDIAOILGD(long MAONELICPNP, long JNIJNNCDCAA, DODBLFCGAMM BALEBDNJLEM, AMIIJBBMGIJ NHAAHCFFLBH);
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
