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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B4CA0", Offset = "0x67B40A0", VA = "0x1867B4CA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
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
	public class LogRegistrationIndex : AHNNEHLOHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67B10C0", Offset = "0x67B04C0", VA = "0x1867B10C0", Slot = "4")]
		public override void GPKLHHLKJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NJPEGKDELGP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67B4930", Offset = "0x67B3D30", VA = "0x1867B4930")]
	public NJPEGKDELGP(string JEBCFBFPEMG, Exception ANBJHAGKAMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class JAKINKHBHCE : GJIKPBAFACG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NPEAFHEIDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ICJANOLCGFM>> <>t__builder;

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
		private TaskAwaiter<CENAKIOKOHD<ICJANOLCGFM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67B49F0", Offset = "0x67B3DF0", VA = "0x1867B49F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67B4C30", Offset = "0x67B4030", VA = "0x1867B4C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DOEGOGCCBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BLAMCACKDDF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<BLAMCACKDDF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67A6400", Offset = "0x67A5800", VA = "0x1867A6400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67A6610", Offset = "0x67A5A10", VA = "0x1867A6610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	[UnityEngine.Scripting.Preserve]
	public JAKINKHBHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67AC4B0", Offset = "0x67AB8B0", VA = "0x1867AC4B0", Slot = "4")]
	[AsyncStateMachine(typeof(NPEAFHEIDCK))]
	public Task<IReadOnlyList<ICJANOLCGFM>> MJGGFAPHFEA(long NIJFNKBIOIC, long LFGAFDMLOJL, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67AC5D0", Offset = "0x67AB9D0", VA = "0x1867AC5D0", Slot = "5")]
	[AsyncStateMachine(typeof(DOEGOGCCBCG))]
	public Task<IReadOnlyList<BLAMCACKDDF>> MLHONBKJJMF(IReadOnlyList<int> KHONGDDPFOI, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GKDOOJKOLFH : IEquatable<GKDOOJKOLFH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GLGDLANLJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BLAMCACKDDF BEBFAIBGDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KMPPEMKEJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LBGOELBFLNP? KBNMIJEKNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HICPCKDGJKN? HKBLNLAGILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JDPMNOANFNO LHKCLOMPJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OAHKKLBHOHO> ANAOJBHEFAL();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JDPMNOANFNO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GJIKPBAFACG
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ICJANOLCGFM>> MJGGFAPHFEA(long NIJFNKBIOIC, long LFGAFDMLOJL, [Optional] CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<BLAMCACKDDF>> MLHONBKJJMF(IReadOnlyList<int> KHONGDDPFOI, [Optional] CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KAOHKJLGAGO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HDCIGNMOJAB : GKDOOJKOLFH, IEquatable<GKDOOJKOLFH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct IDDHDKDOOHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HDCIGNMOJAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private JDLIDNHDMAF <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<DAFHOICEHFC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OAHKKLBHOHO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67AB130", Offset = "0x67AA530", VA = "0x1867AB130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67AB5D0", Offset = "0x67AA9D0", VA = "0x1867AB5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ICJANOLCGFM ABNLLALJBEN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int GLGDLANLJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BLAMCACKDDF BEBFAIBGDKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime LIKHGHCBJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5466C50", Offset = "0x5466050", VA = "0x185466C50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LBGOELBFLNP? KBNMIJEKNMO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x19E2620", Offset = "0x19E1A20", VA = "0x1819E2620", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HICPCKDGJKN? HKBLNLAGILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5466D30", Offset = "0x5466130", VA = "0x185466D30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JDPMNOANFNO LHKCLOMPJHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "10")]
			get
			{
				return default(JDPMNOANFNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67A9510", Offset = "0x67A8910", VA = "0x1867A9510", Slot = "9")]
		[AsyncStateMachine(typeof(IDDHDKDOOHN))]
		public Task<OAHKKLBHOHO> ANAOJBHEFAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67A9800", Offset = "0x67A8C00", VA = "0x1867A9800")]
		public HDCIGNMOJAB(int KAFACOELBAI, BLAMCACKDDF AALMKFIAKCF, ICJANOLCGFM ABNLLALJBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67A9610", Offset = "0x67A8A10", VA = "0x1867A9610", Slot = "11")]
		public bool Equals(GKDOOJKOLFH MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67A96A0", Offset = "0x67A8AA0", VA = "0x1867A96A0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67A9740", Offset = "0x67A8B40", VA = "0x1867A9740")]
		private bool GKMFJCFPHGL(HDCIGNMOJAB MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67A9780", Offset = "0x67A8B80", VA = "0x1867A9780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class NFMIMMPABNB : GKDOOJKOLFH, IEquatable<GKDOOJKOLFH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct MJFIBJCOPFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NFMIMMPABNB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<OAHKKLBHOHO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67B25B0", Offset = "0x67B19B0", VA = "0x1867B25B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67B27E0", Offset = "0x67B1BE0", VA = "0x1867B27E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly AFFLFHNACKH JJLHALIAHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly LBGOELBFLNP LEOHJLMICKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly HICPCKDGJKN KMEAHKICEME;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int GLGDLANLJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67B4850", Offset = "0x67B3C50", VA = "0x1867B4850", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BLAMCACKDDF BEBFAIBGDKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x67B4690", Offset = "0x67B3A90", VA = "0x1867B4690", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime LIKHGHCBJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x67B4800", Offset = "0x67B3C00", VA = "0x1867B4800", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LBGOELBFLNP? KBNMIJEKNMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x67B48E0", Offset = "0x67B3CE0", VA = "0x1867B48E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HICPCKDGJKN? HKBLNLAGILK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x67B4890", Offset = "0x67B3C90", VA = "0x1867B4890", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JDPMNOANFNO LHKCLOMPJHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x90CAC0", Offset = "0x90BEC0", VA = "0x18090CAC0", Slot = "10")]
			get
			{
				return default(JDPMNOANFNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF076B0", Offset = "0xF06AB0", VA = "0x180F076B0")]
		public NFMIMMPABNB(AFFLFHNACKH MLAICGADNKB, LBGOELBFLNP DFBLDLKDJHJ, HICPCKDGJKN FPABJCAOAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67B4450", Offset = "0x67B3850", VA = "0x1867B4450", Slot = "9")]
		[AsyncStateMachine(typeof(MJFIBJCOPFJ))]
		public Task<OAHKKLBHOHO> ANAOJBHEFAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67B4540", Offset = "0x67B3940", VA = "0x1867B4540", Slot = "11")]
		public bool Equals(GKDOOJKOLFH MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67B45E0", Offset = "0x67B39E0", VA = "0x1867B45E0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67B4720", Offset = "0x67B3B20", VA = "0x1867B4720")]
		private bool GKMFJCFPHGL(NFMIMMPABNB MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67B4780", Offset = "0x67B3B80", VA = "0x1867B4780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HEDJHEDANAN : GKDOOJKOLFH, IEquatable<GKDOOJKOLFH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct KNENHPKECNG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<OAHKKLBHOHO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x67AF020", Offset = "0x67AE420", VA = "0x1867AF020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x67AF260", Offset = "0x67AE660", VA = "0x1867AF260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly BLAMCACKDDF IOGJFMJOGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly LBGOELBFLNP LEOHJLMICKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HICPCKDGJKN KMEAHKICEME;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int GLGDLANLJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x67AA5C0", Offset = "0x67A99C0", VA = "0x1867AA5C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public BLAMCACKDDF BEBFAIBGDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime LIKHGHCBJDL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LBGOELBFLNP? KBNMIJEKNMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x67AA630", Offset = "0x67A9A30", VA = "0x1867AA630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HICPCKDGJKN? HKBLNLAGILK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x67AA5E0", Offset = "0x67A99E0", VA = "0x1867AA5E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JDPMNOANFNO LHKCLOMPJHP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "10")]
			get
			{
				return default(JDPMNOANFNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xF076B0", Offset = "0xF06AB0", VA = "0x180F076B0")]
		public HEDJHEDANAN(BLAMCACKDDF AALMKFIAKCF, LBGOELBFLNP DFBLDLKDJHJ, HICPCKDGJKN FPABJCAOAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67AA150", Offset = "0x67A9550", VA = "0x1867AA150", Slot = "9")]
		[AsyncStateMachine(typeof(KNENHPKECNG))]
		public Task<OAHKKLBHOHO> ANAOJBHEFAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67AA340", Offset = "0x67A9740", VA = "0x1867AA340", Slot = "11")]
		public bool Equals(GKDOOJKOLFH MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67AA220", Offset = "0x67A9620", VA = "0x1867AA220", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67AA530", Offset = "0x67A9930", VA = "0x1867AA530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67AA450", Offset = "0x67A9850", VA = "0x1867AA450")]
		private bool GKMFJCFPHGL(HEDJHEDANAN MGDPHHCBMMP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct EKINOBMMOOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<GKDOOJKOLFH>> <>t__builder;

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
		public KAOHKJLGAGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<ICJANOLCGFM> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<ICJANOLCGFM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, BLAMCACKDDF account, ICJANOLCGFM roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67A79F0", Offset = "0x67A6DF0", VA = "0x1867A79F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67A87D0", Offset = "0x67A7BD0", VA = "0x1867A87D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LEBOOGGGPAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, BLAMCACKDDF account, ICJANOLCGFM roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<ICJANOLCGFM> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KAOHKJLGAGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<BLAMCACKDDF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67AFC40", Offset = "0x67AF040", VA = "0x1867AFC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67B0630", Offset = "0x67AFA30", VA = "0x1867B0630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly APAPHKNOCEG LNNKMPOFJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GJIKPBAFACG ICGLOGIPLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AFOBECLHLDG HDBKHKHKABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NCDJKCDGAPJ<(long, long), IReadOnlyList<ICJANOLCGFM>> NJKLGHBFOHI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67AEC60", Offset = "0x67AE060", VA = "0x1867AEC60")]
	[UnityEngine.Scripting.Preserve]
	public KAOHKJLGAGO([AKGMOFMFNCG(null)] GJIKPBAFACG HECJIFOMOJA, [AKGMOFMFNCG(null)] AFOBECLHLDG FDADJCANLEH, [AKGMOFMFNCG(null)] APAPHKNOCEG EEHAPABMDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67AEB10", Offset = "0x67ADF10", VA = "0x1867AEB10")]
	[AsyncStateMachine(typeof(EKINOBMMOOL))]
	public Task<IList<GKDOOJKOLFH>> OHBCIGEFHHH(long NIJFNKBIOIC, long MCHADGEKOOE, bool PGMFECGGLKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x67AE970", Offset = "0x67ADD70", VA = "0x1867AE970")]
	private bool MCOLNFNLGEE(DateTime? NPKIKDPNAEF, long NIJFNKBIOIC, long MCHADGEKOOE, [Out] AFFLFHNACKH DONGLMJPIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67AE860", Offset = "0x67ADC60", VA = "0x1867AE860")]
	[AsyncStateMachine(typeof(LEBOOGGGPAL))]
	private Task<IReadOnlyList<(int, BLAMCACKDDF, ICJANOLCGFM)>> HKBMGHHDCPP(IReadOnlyList<ICJANOLCGFM> BAHOCKMBKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AFOBECLHLDG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AFFLFHNACKH> CMHGHKHFAAG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDHHCNMJNBC(long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI, PKLFHHDPKAE NBONEADNIAK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDLMCAJNEAB(long NIJFNKBIOIC, long MCHADGEKOOE, [Out] AFFLFHNACKH DONGLMJPIGL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ENODKNBBCAL(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, [Out] AFFLFHNACKH DONGLMJPIGL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEIOLGIMALG(long NIJFNKBIOIC, long MCHADGEKOOE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface EKMIMGLAEBJ : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BONEJHJHINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task LJKNILBANKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHGJFAPHMGF(Task JKFKBCIOAGB, string FMEHHEPBNKB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface JAMAFABDHEE : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAHKKLBHOHO> FAECMIOILAE(AFFLFHNACKH DONGLMJPIGL);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JPDKGIFCIEI(CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface EIGDPGKBIAC : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JDKDAIBAAAF ICFFCPHINCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNDCNNLBIED();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBGEHLGPJMF();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface KNMNJBFGHDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface DCMBPKDFJJA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan IEEDGHHKLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan PJPJHBPCKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan JOCFIKGMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan FOLEAMKCKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PIGJOBEKDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FPCAANALNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MNBBFMEOLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NNAIGHCBNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BCNCBCMAFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool IAOMLPCMDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CPCNOBIIIGC
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FHHLMPEEIFB
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
public struct BHGHCLPFMEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LFFKCEKPFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long LFGAFDMLOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly CPCNOBIIIGC NBMJAHOKHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception CIKNDPIJIJK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x679CD90", Offset = "0x679C190", VA = "0x18679CD90")]
	public BHGHCLPFMEJ(long LFFKCEKPFCD, long LFGAFDMLOJL, CPCNOBIIIGC NBMJAHOKHAI, [CanBeNull] Exception CIKNDPIJIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x679CD40", Offset = "0x679C140", VA = "0x18679CD40")]
	public static BHGHCLPFMEJ LIODGANGHEE(DHOCBLKANBD BMLEJPHJEJI, CPCNOBIIIGC NBMJAHOKHAI, [Optional] Exception CIKNDPIJIJK)
	{
		return default(BHGHCLPFMEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void AJGMDLCNHGO(BHGHCLPFMEJ IIBBCMNHPFI);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface HLKBINDKIBL : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HFIMMOFJGKH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event AJGMDLCNHGO OBMPGHECADM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AJGMDLCNHGO ADPPGFBLFKM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event AJGMDLCNHGO DLOEDJGBJEK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FHHLMPEEIFB, bool> IDHEFGEJHLM;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void APFHGEIKBEL();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ABGCLMJHAJA(BHGHCLPFMEJ IIBBCMNHPFI);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IIDIBEFJALG(BHGHCLPFMEJ IIBBCMNHPFI);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AICIIAOKGNI(BHGHCLPFMEJ IIBBCMNHPFI);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BINPOGHLCED(FHHLMPEEIFB MMIJGFOKHGO, bool DLEFFDAKKCK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface FFHFEGGDIAA : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KDPHAILLALK();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBBFHMEPLBJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface GNHCHIOFANA : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus KBLDNFKOPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NOGMIEBINPH(DHOCBLKANBD AOBLKOJAFBL, EKJMLCAAKLM OMDLIBLMABJ, CancellationToken JKLIJNDGKKN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class NMOOICNCDAP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67B49A0", Offset = "0x67B3DA0", VA = "0x1867B49A0")]
	public static bool OCDPHBLHOAP(this GNHCHIOFANA GLLEIFJDLNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task MPOBLIBLGKJ(FCICHBFPKKL HADHNEGDEKF, CancellationToken ICNJFMMNIKL);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface OPBJHLIBNLE : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMAPHJGLODD(MPOBLIBLGKJ MBADCNKMPJF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface HDAJFOAIBMP : JDLIDNHDMAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken KJHEGEKGAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BNDLKDEPBDF LHCAJBKLMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	EBJMBPHPLIM DANKFOHDBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DGBDMKLJLHC MHOBFBECGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KCNOANFPABD LABLPNOJIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ODAAIDPHJOD LDCLAKGFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MJJHMPIDDJJ KEGGFCNLOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JFOMGCGOIAJ EEEKOHLAAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EKMIMGLAEBJ MBILELLJLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JAMAFABDHEE POACNAAOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HLKBINDKIBL FPEJIPKJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FFHFEGGDIAA DFKCCNCFCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GNHCHIOFANA GOLAPMBFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OPBJHLIBNLE AEOPPPPPLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	APNCNBJOMLO MFEPCAEAOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FDNEAGGHJFD OBEGJPLHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NOEOBKPFBPE POEIDFBCANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JKGELICFIJG ILFGOPNKNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ADKCECMHKHB GLHKDDKEDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MHAGEMEKKFD DOBABEHFFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CINMBNEIKFH CFCKEIOCLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FAOBGMFPLCB GAIACBMBICE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CCCNIAKPJNE JMFKLDIMLHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GLBCDAELEGO JEHPEIFEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	EIGDPGKBIAC LPOGCMGFNMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DCMBPKDFJJA AIGFFHALHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	PCNOPEBAMLP CGBEMIEDHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AFOBECLHLDG PFOBIBOBMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FHPDKEAIEPM OKOHEPPOMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IJHGMFGBKAE FPNIAGFEMIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MOHOFPPIBJK ELAHMBCCBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ICIJHDPLJOD(EKJMLCAAKLM LLOHDMNJMOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface APNCNBJOMLO : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNPOCOFJDMD FFIECPFJEFG(Guid FHLPBMFOONK);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PIABDNKCBCD(Guid FHLPBMFOONK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCLOMJKPPMF(Guid FHLPBMFOONK, Task HPDFLBHLELK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JFFFFAOCHFC(Guid FHLPBMFOONK, OAHKKLBHOHO ONJFKJCMKHA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(OAHKKLBHOHO, Task)> BJHFGMPALDJ(Guid FHLPBMFOONK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FIPCMLIBHDE : KNMNJBFGHDK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FDNEAGGHJFD : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLIFMHNPMED(ELOCCADIICN JEBCFBFPEMG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEOOBBJGPEP(ELOCCADIICN JEBCFBFPEMG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EEPIJJHADBF> CJHCIBCMPAJ(CancellationToken CPNBGHHNKIA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NOEOBKPFBPE : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNPOCOFJDMD AHMOCMKPIEI(ELOCCADIICN EFOLDILOFHB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOOOGBDGFGP(Guid FHLPBMFOONK, Task HPDFLBHLELK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface JKGELICFIJG : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAHKKLBHOHO> ILFGOPNKNCI(ELOCCADIICN CPBCMKCCHDB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface ADKCECMHKHB : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MAIDGDACGFA> DPNAPEHDNDM(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, DHOCBLKANBD AOBLKOJAFBL, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface CINMBNEIKFH : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OAHKKLBHOHO FMNPEKIJKDD(MKFCBDEMMMH IOPMPBPKFOL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GECFAICIDPJ(string GBHBCPBCKNM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface MHAGEMEKKFD : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ELOCCADIICN> EMHLHDMDPIM(ELOCCADIICN BDAAOBFBLIB, BIMKIOLAEHO BELDBGPLNII, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ELOCCADIICN> OALPOEBHICP(CancellationToken KNKAEBKAEBM, BIMKIOLAEHO BELDBGPLNII);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IKKONDAGOHO INIBJFCHDDD(HKIJMCIKIMC DOEIBLLDHDB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IKKONDAGOHO LMOMKPGHIMM(HKIJMCIKIMC DOEIBLLDHDB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface FAOBGMFPLCB : KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OAHKKLBHOHO BDICADKHPPD(MKFCBDEMMMH IOPMPBPKFOL, EEPIJJHADBF PGJAEKOINFD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OAHKKLBHOHO BJGGJNFCLHH(MKFCBDEMMMH NEIABIHHBBB);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CCCNIAKPJNE
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHMHHFHANMA(HDDMLHPPBAE DPDFFOGAIJL);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFMGDOFDLHH(HDDMLHPPBAE DPDFFOGAIJL);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JINEBFGPOEK(HDDMLHPPBAE DPDFFOGAIJL);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHKPFJLOMHG(HDDMLHPPBAE DPDFFOGAIJL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HDDMLHPPBAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DHOCBLKANBD LJOACIHJAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> CAIBBGBOHIL;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OHKLINEMLLN<string> NGBMDCFLHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public HDDMLHPPBAE(DHOCBLKANBD MJFKEABMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67A98F0", Offset = "0x67A8CF0", VA = "0x1867A98F0")]
	public HDDMLHPPBAE MJPGFBDPILC(string NIOPCMHKLMB, string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67A9860", Offset = "0x67A8C60", VA = "0x1867A9860")]
	public bool KEIHKKOLBNB([Out] IEnumerable<KeyValuePair<string, string>> DHCINIFAFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5AFE430", Offset = "0x5AFD830", VA = "0x185AFE430")]
	public HDDMLHPPBAE AIBDDMIFMCH(OHKLINEMLLN<string> CBCAJLKKHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PCNOPEBAMLP
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FCKAKGPHMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string IDPEDBAHFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool OFHCKNJIMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPFDEFGBOJM();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BALNAPGPFIP FNHNNGLAHIE(long LEGFKICMEKA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LGPIMCFBECM<LOEJPFELMNK, CKDDLMNONFM> AKCJPLGAJOM(long LEGFKICMEKA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LGPIMCFBECM<LOEJPFELMNK, DFCHLNBLLMO> IOCKLMHJIOD(long LEGFKICMEKA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LGPIMCFBECM<long, KLCPJFMKFLG> ILCHHFPEBAP();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDHNMHLEBDB(long LEGFKICMEKA, [Out] bool OBOLFHCMCEJ);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> KHECKCEGKLB(byte[] AIFELOLJMOB, byte[] DMKAHHMFABC, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JDLIDNHDMAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool OCDPHBLHOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool GMLJMHMIDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	EKJMLCAAKLM LLDFJIMEIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HFIMMOFJGKH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event AJGMDLCNHGO OBMPGHECADM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event AJGMDLCNHGO ADPPGFBLFKM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event AJGMDLCNHGO DLOEDJGBJEK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FHHLMPEEIFB, bool> IDHEFGEJHLM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LBBFHMEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KKOIEOKNBDO JBEIOAAKGHC();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CNEDJPIGEAE EGAHKKIAOEO();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OAHKKLBHOHO> FAECMIOILAE(AFFLFHNACKH MLAICGADNKB);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JPDKGIFCIEI(CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KCNOANFPABD
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool HKBJKCNHILO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string GJJJJBHIMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLCFCCJLHKM(Scene IAIKLHKIBDI);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BHOIFHDIPIH(NJKKMIOMNHA KNBEMFFMGJO, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NDCIMPMHGLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface LJHJLDLGJAI
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool JDBKIKDPLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NKDOOCHPOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EEOEDLJDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FLBJHDLJOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool EHFLLHBCAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NICPPHDCJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool BGKHJBBFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float KNOLLIDBMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> HNKIMPPJFBJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNDLKDEPBDF LOLHHGLLOMA(BNDLKDEPBDF PGBANCNKIFL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHJOFGHPNGI(BNDLKDEPBDF CGBKOFIJCLK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNMOAPILHLE();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PLPDAKAEABI(OHKLINEMLLN<string>.IECBLACBOCC MBAFAEKOPNN, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELNNJGCHCHI(float PDIKPHBHNBE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PGKACPLBIFM(string BPMLHPFKFKM);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<OOHNHIIBEBE> KBBGPLDCCID();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable LOKBIHMPKOF(object APOKKKDAFKO, OOHNHIIBEBE PLEAEFJJBBO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CKDDLMNONFM GKGFENCBBLO(IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NGBLCIFDAMC(int ILHEFLOIBFO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task ONNLFKLENKH();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FHOEFDOFCEH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FCELJOJOBOF();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task GAMFEJNNBND(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task NGDDMEJAAHE(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<NFDPDDHAFKK> EIDFCDIFGHF(DateTime OAFHBICHBAG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> IJDKPIEEGEL(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NHPFHJNLHAJ(string IJCKLABABEF = "", float NBODOCDJMJC = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	IICOAABLFHH JJLHKBPNKGA(DLGKDAMPLFB ICKIDDAKBIJ, FPPCIOMIKDM LBHJIFABJPL, DFCHLNBLLMO FBIGDMFDBBA, IEnumerable<PersistenceView> OIAKODKFAFN, LJPIAMHJCPP LGHBEFJDOKO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AAELMIBIMFP(DFCHLNBLLMO FBIGDMFDBBA);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EECBAPOPIKB(BIGDCOAAKFF IMAEGLAPIGI, [In] IICOAABLFHH BFEHAALLCJO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task FLFAEHEAJCA(DFCHLNBLLMO IOPAFECKJPC, bool NJKHGEJHHOM, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task CGKCPEBBPFK(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BHEFHBNALCF(long NIJFNKBIOIC, long LFGAFDMLOJL, DAFHOICEHFC OPPMEGJIOLD, ICJANOLCGFM PEHNNDIPLJO, HIIJCKKCKNI KNIDFNGMNCI, DJFGIDMDALL? JIKFJKFOCPO, OKNMINIJBMC? OOPNPHJKGEA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KOBGGAFLMNN(long NIJFNKBIOIC, long LFGAFDMLOJL, OKNMINIJBMC? OOPNPHJKGEA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GLNGOGONPLH(PersistenceView INKGJJEHPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool KAGIMLDIEBH(PersistenceView GLNMJKHJCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool PECJLEOMNPB(BIGDCOAAKFF IMAEGLAPIGI, MGKNMOMBPMH LJGEOPNMHCA, [Out] BLBNOEFPBFI HMANOJGEEBK);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task KJEAANACKLJ(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ABICHCKAHLL();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable JFGHFNJNDFE();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JHMPHDBPCNO(DFCHLNBLLMO IOPAFECKJPC, MGKNMOMBPMH LJGEOPNMHCA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> PLCPOBNANPG(EBJMBPHPLIM HFIBHDFMJDD, CancellationToken KNKAEBKAEBM, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void OPODCOJMLHM(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<GDPFOGKLBJD> JBFCLNALKKO(GILJMCPBNKH BDAAOBFBLIB);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<DAFHOICEHFC> FMCDBHAAIML(long NIJFNKBIOIC, bool MOJDKEAJFKF, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ICJANOLCGFM> PPODCFFOKCG(long NIJFNKBIOIC, long LFGAFDMLOJL, long PNLPKLPODDC, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<JKFEJAMDBHK> PIBKHNNHKJE(string PDFKPGNALBH, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<JKFEJAMDBHK> EJEONPDFNOC(string PDFKPGNALBH, long NIJFNKBIOIC, long LFGAFDMLOJL, string NDBHALICMDP, EDCNEGNOIKF.NAJJHGMOFOL HADHNEGDEKF, EDCNEGNOIKF.NAJJHGMOFOL DMKAHHMFABC, int CNFILGPEFON);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool BDMKOGDBOGH();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LOHIJLFLHJM();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool BJHLABILEPM(IEnumerable<BLBNOEFPBFI> GBNHBGGEADE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void APAKIDDJPAE(List<GameObject> OCNHPCNGOME);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float DFIGNPBGJBM();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> GAIAMNNKLEN(string DDFEOCNDAEA, LoadSceneMode MIDMDPAPCAP, bool CPBOEODCEGK, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void OKLGGNLLGFD();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AAIMBGOJODA(bool IAGGBJHFOBI);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CGOMEOHJBON(DHOCBLKANBD HGGOBOECGFH);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task MNGHGDFAIEA(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task JBDGCEHDOCE(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task GDNPICHOLJM(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable EFBFMBIGOHE();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "63")]
	MKNHHMBPNCA BBKBOOCPMDE();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task DGLANPLDMOC(CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MKNHHMBPNCA
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IDAHBMEODOL(CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IHAPDDBBMEH(CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct IICOAABLFHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> CPKDOEGINFA;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum NFDPDDHAFKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct DLGKDAMPLFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string FNJMHBMMMCC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CGKPHOFKCHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	DHOCBLKANBD MFFCBMCMILI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	DAFHOICEHFC NKCMOMDLDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	EFJPDNIEGLO GLMCCGHENIP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool LKDOFJCBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool BJHHIDNHMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int MKHDINPKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EHDKIPCJNPG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GEOIHPJAFLC;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EJHACLNMDGI();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.EGDLHLJICEN> OABAPAKKLPG(long LEGFKICMEKA, [Optional] CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<IBIFNJFFMJI> FLMNJNGJIIH();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task AGLMMGFDEGM();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(DHOCBLKANBD, EKJMLCAAKLM) KCEGGLKMDFM();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "15")]
	APKMLFOLCPD DNNJHBLDDPL();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LBPOANMCECD(long LEGFKICMEKA);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GLBCDAELEGO
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFFCPKANNCC([Out] IEnumerable<int> ENLOFKFHJDK);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMMHFKKBOKP(HMKEPMLABHI ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMEBADHABEL(HMKEPMLABHI ICNJFMMNIKL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface AKJGMPFJMPK
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JBNDGONHMJC(OAHKKLBHOHO GEFKDGHDAKK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EEIFGCIDCKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLBLNJAJIBF(JPAMBLLCIEL.IJDEEGDIDGA OPOGOKKGFEK);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNCLALOKIEN(JPAMBLLCIEL.IJDEEGDIDGA OPOGOKKGFEK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface ODAAIDPHJOD : EEIFGCIDCKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OAHKKLBHOHO GHODEKKHGAK(MKFCBDEMMMH NEIABIHHBBB);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MJJHMPIDDJJ : EEIFGCIDCKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OAHKKLBHOHO FMNPEKIJKDD(MKFCBDEMMMH PFIBGBIOJOF);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BALNAPGPFIP
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OJIJNKCPBAD<NJKKMIOMNHA, FEBGENKADMF>> LNJNLCONCLG(string NDBHALICMDP, long LEGFKICMEKA, long? NIJFNKBIOIC, long? LFGAFDMLOJL, FOPIIAIPCJM.NJCPJMGBHJJ EOBBCEADDII, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface LGPIMCFBECM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OJIJNKCPBAD<CAFJOBNFGAD<TData>, FEBGENKADMF>> KFHOKIIGPGA(TGetDataArg PBBNOGAMKJE, CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class JIDFBJGDDIP : HDAJFOAIBMP, JDLIDNHDMAF, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BOLILOKLAND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JIDFBJGDDIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AFFLFHNACKH autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<OAHKKLBHOHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x679DAE0", Offset = "0x679CEE0", VA = "0x18679DAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x679DD60", Offset = "0x679D160", VA = "0x18679DD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KHPIPNLEGEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JIDFBJGDDIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x67AED90", Offset = "0x67AE190", VA = "0x1867AED90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x67AEFC0", Offset = "0x67AE3C0", VA = "0x1867AEFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PDMNGCMPLKF : IEnumerable<KNMNJBFGHDK>, IEnumerable, IEnumerator<KNMNJBFGHDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private KNMNJBFGHDK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JIDFBJGDDIP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private KNMNJBFGHDK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x818520", Offset = "0x817920", VA = "0x180818520")]
		[DebuggerHidden]
		public PDMNGCMPLKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x67B5D50", Offset = "0x67B5150", VA = "0x1867B5D50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x67B61B0", Offset = "0x67B55B0", VA = "0x1867B61B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x67B6100", Offset = "0x67B5500", VA = "0x1867B6100", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KNMNJBFGHDK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x67B6100", Offset = "0x67B5500", VA = "0x1867B6100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource MKLIGFMCHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BNDLKDEPBDF CGBKOFIJCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private JKFJDOKJKCB PLGFPNHLBHF;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EBJMBPHPLIM DANKFOHDBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C4470", Offset = "0x7C3870", VA = "0x1807C4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public DGBDMKLJLHC MHOBFBECGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public KCNOANFPABD LABLPNOJIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C1DC0", VA = "0x1807C29C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ODAAIDPHJOD LDCLAKGFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C1DD0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MJJHMPIDDJJ KEGGFCNLOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB0", Offset = "0x7C30B0", VA = "0x1807C3CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JFOMGCGOIAJ EEEKOHLAAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5640", Offset = "0x7C4A40", VA = "0x1807C5640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C5540", Offset = "0x7C4940", VA = "0x1807C5540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EKMIMGLAEBJ MBILELLJLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C5650", Offset = "0x7C4A50", VA = "0x1807C5650", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C5600", Offset = "0x7C4A00", VA = "0x1807C5600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JAMAFABDHEE POACNAAOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C5660", Offset = "0x7C4A60", VA = "0x1807C5660", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C5580", Offset = "0x7C4980", VA = "0x1807C5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HLKBINDKIBL FPEJIPKJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x98C4E0", Offset = "0x98B8E0", VA = "0x18098C4E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x98AA10", Offset = "0x989E10", VA = "0x18098AA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public FFHFEGGDIAA DFKCCNCFCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C5510", Offset = "0x7C4910", VA = "0x1807C5510", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C55A0", Offset = "0x7C49A0", VA = "0x1807C55A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public GNHCHIOFANA GOLAPMBFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8841D0", Offset = "0x8835D0", VA = "0x1808841D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8842F0", Offset = "0x8836F0", VA = "0x1808842F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OPBJHLIBNLE AEOPPPPPLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7BECF0", Offset = "0x7BE0F0", VA = "0x1807BECF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7BED00", Offset = "0x7BE100", VA = "0x1807BED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public APNCNBJOMLO MFEPCAEAOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA21C10", Offset = "0xA21010", VA = "0x180A21C10", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA2AAF0", Offset = "0xA29EF0", VA = "0x180A2AAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public FIPCMLIBHDE HOEMFBFCPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x96C8E0", Offset = "0x96BCE0", VA = "0x18096C8E0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x96C8F0", Offset = "0x96BCF0", VA = "0x18096C8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public FDNEAGGHJFD OBEGJPLHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9B12B0", Offset = "0x9B06B0", VA = "0x1809B12B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA2AA70", Offset = "0xA29E70", VA = "0x180A2AA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public NOEOBKPFBPE POEIDFBCANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA80", Offset = "0x8FCE80", VA = "0x1808FDA80", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x97DAC0", Offset = "0x97CEC0", VA = "0x18097DAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public JKGELICFIJG ILFGOPNKNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x97FF50", Offset = "0x97F350", VA = "0x18097FF50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x97F350", Offset = "0x97E750", VA = "0x18097F350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public ADKCECMHKHB GLHKDDKEDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7BED40", Offset = "0x7BE140", VA = "0x1807BED40", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7BECD0", Offset = "0x7BE0D0", VA = "0x1807BECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MHAGEMEKKFD DOBABEHFFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x88B610", Offset = "0x88AA10", VA = "0x18088B610", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x887CF0", Offset = "0x8870F0", VA = "0x180887CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CINMBNEIKFH CFCKEIOCLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1790", Offset = "0x8E0B90", VA = "0x1808E1790", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1760", Offset = "0x8E0B60", VA = "0x1808E1760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FAOBGMFPLCB GAIACBMBICE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x907D80", Offset = "0x907180", VA = "0x180907D80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA2AB10", Offset = "0xA29F10", VA = "0x180A2AB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public CCCNIAKPJNE JMFKLDIMLHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x88B6C0", Offset = "0x88AAC0", VA = "0x18088B6C0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x888CA0", Offset = "0x8880A0", VA = "0x180888CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public GLBCDAELEGO JEHPEIFEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x907C50", Offset = "0x907050", VA = "0x180907C50", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA2AAD0", Offset = "0xA29ED0", VA = "0x180A2AAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EIGDPGKBIAC LPOGCMGFNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x907D20", Offset = "0x907120", VA = "0x180907D20", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA2AC90", Offset = "0xA2A090", VA = "0x180A2AC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DCMBPKDFJJA AIGFFHALHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9B0180", Offset = "0x9AF580", VA = "0x1809B0180", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA2AC50", Offset = "0xA2A050", VA = "0x180A2AC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public PCNOPEBAMLP CGBEMIEDHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x86ABF0", Offset = "0x869FF0", VA = "0x18086ABF0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA2ABB0", Offset = "0xA29FB0", VA = "0x180A2ABB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public AFOBECLHLDG PFOBIBOBMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8F7830", Offset = "0x8F6C30", VA = "0x1808F7830", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FHPDKEAIEPM OKOHEPPOMAP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9B02E0", Offset = "0x9AF6E0", VA = "0x1809B02E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IJHGMFGBKAE FPNIAGFEMIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8F7850", Offset = "0x8F6C50", VA = "0x1808F7850", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MOHOFPPIBJK ELAHMBCCBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7840", Offset = "0x8F6C40", VA = "0x1808F7840", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EKJMLCAAKLM LLDFJIMEIFP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B0520", Offset = "0x9AF920", VA = "0x1809B0520", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1300", Offset = "0x9A0700", VA = "0x1809A1300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private bool HGIJACMEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x67AD440", Offset = "0x67AC840", VA = "0x1867AD440", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private bool PHBIGIBFKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x67AD090", Offset = "0x67AC490", VA = "0x1867AD090", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private CancellationToken PJFBFLFOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x67ACF80", Offset = "0x67AC380", VA = "0x1867ACF80", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private BNDLKDEPBDF PHIAOKDBEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GGDPEKJHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x67AD200", Offset = "0x67AC600", VA = "0x1867AD200", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67AD3E0", Offset = "0x67AC7E0", VA = "0x1867AD3E0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event AJGMDLCNHGO KJOPIPBNJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67ACE90", Offset = "0x67AC290", VA = "0x1867ACE90", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67AD1A0", Offset = "0x67AC5A0", VA = "0x1867AD1A0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event AJGMDLCNHGO DOBCNDOCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67AD2C0", Offset = "0x67AC6C0", VA = "0x1867AD2C0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x67AC9C0", Offset = "0x67ABDC0", VA = "0x1867AC9C0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event AJGMDLCNHGO MMMEDEBKJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67AD260", Offset = "0x67AC660", VA = "0x1867AD260", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x67ACB90", Offset = "0x67ABF90", VA = "0x1867ACB90", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<FHHLMPEEIFB, bool> NJLDDCFPFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x67AD320", Offset = "0x67AC720", VA = "0x1867AD320", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD380", Offset = "0x67AC780", VA = "0x1867AD380", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x9A1300", Offset = "0x9A0700", VA = "0x1809A1300", Slot = "36")]
	public void ICIJHDPLJOD(EKJMLCAAKLM LLOHDMNJMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x67AD4A0", Offset = "0x67AC8A0", VA = "0x1867AD4A0")]
	[UnityEngine.Scripting.Preserve]
	internal JIDFBJGDDIP([AKGMOFMFNCG(null)] BNDLKDEPBDF CGBKOFIJCLK, [AKGMOFMFNCG(null)] EBJMBPHPLIM HFIBHDFMJDD, [AKGMOFMFNCG(null)] DGBDMKLJLHC MNLKGNAKHCO, [AKGMOFMFNCG(null)] LJHJLDLGJAI ACAIKIGINDM, [AKGMOFMFNCG(null)] KCNOANFPABD OOANCGBMDJP, [AKGMOFMFNCG(null)] ODAAIDPHJOD BLAPEECPJCP, [AKGMOFMFNCG(null)] MJJHMPIDDJJ APFAAMAKOAJ, [AKGMOFMFNCG(null)] JFOMGCGOIAJ DBBLKPDBEBN, [AKGMOFMFNCG(null)] EKMIMGLAEBJ HEOMPBLFEHD, [AKGMOFMFNCG(null)] JAMAFABDHEE JAMOHHALJKO, [AKGMOFMFNCG(null)] HLKBINDKIBL PPBCLHOGJFL, [AKGMOFMFNCG(null)] FFHFEGGDIAA MPOLMEODBLP, [AKGMOFMFNCG(null)] GNHCHIOFANA GLLEIFJDLNP, [AKGMOFMFNCG(null)] OPBJHLIBNLE FDKNEPDHPPD, [AKGMOFMFNCG(null)] APNCNBJOMLO EPODIEHPGPN, [AKGMOFMFNCG(null)] FIPCMLIBHDE IBIMOIOMJKA, [AKGMOFMFNCG(null)] FDNEAGGHJFD ECNOGDMNNAB, [AKGMOFMFNCG(null)] NOEOBKPFBPE LLGNFOBBADE, [AKGMOFMFNCG(null)] JKGELICFIJG DEODMMEPAJH, [AKGMOFMFNCG(null)] ADKCECMHKHB EDFMCFIHBIF, [AKGMOFMFNCG(null)] CINMBNEIKFH NBBAFHLGBNN, [AKGMOFMFNCG(null)] MHAGEMEKKFD CFMFPPMJCCN, [AKGMOFMFNCG(null)] FAOBGMFPLCB HBEDOEBNKIO, [AKGMOFMFNCG(null)] CCCNIAKPJNE EOGFFMGEPKF, [AKGMOFMFNCG(null)] GLBCDAELEGO CHIIFCAMOMA, [AKGMOFMFNCG(null)] DCMBPKDFJJA GLPHPNDFKED, [AKGMOFMFNCG(null)] PCNOPEBAMLP PPNPDLKMNDP, [AKGMOFMFNCG(null)] AFOBECLHLDG OOPNNHKOOJF, [AKGMOFMFNCG(null)] FHPDKEAIEPM JBDIHNFLMNF, [AKGMOFMFNCG(null)] IJHGMFGBKAE ICAIDOIOJIK, [AKGMOFMFNCG(null)] MOHOFPPIBJK JOPAOLEHJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x67ACDE0", Offset = "0x67AC1E0", VA = "0x1867ACDE0")]
	private void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x67ACBF0", Offset = "0x67ABFF0", VA = "0x1867ACBF0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x67ACD90", Offset = "0x67AC190", VA = "0x1867ACD90", Slot = "49")]
	private void EONKKPCANCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x67ACEF0", Offset = "0x67AC2F0", VA = "0x1867ACEF0", Slot = "50")]
	private KKOIEOKNBDO GECDMPNMKGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67AD110", Offset = "0x67AC510", VA = "0x1867AD110", Slot = "51")]
	private CNEDJPIGEAE JOCNHNPGJAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67ACA20", Offset = "0x67ABE20", VA = "0x1867ACA20", Slot = "52")]
	[AsyncStateMachine(typeof(BOLILOKLAND))]
	private Task<OAHKKLBHOHO> BLKKFPFPIDH(AFFLFHNACKH DONGLMJPIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x67ACFA0", Offset = "0x67AC3A0", VA = "0x1867ACFA0", Slot = "53")]
	[AsyncStateMachine(typeof(KHPIPNLEGEG))]
	private Task IINEGFHGIFH(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67AC940", Offset = "0x67ABD40", VA = "0x1867AC940")]
	[IteratorStateMachine(typeof(PDMNGCMPLKF))]
	private IEnumerable<KNMNJBFGHDK> BBHMOIAEHFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67ACB30", Offset = "0x67ABF30", VA = "0x1867ACB30")]
	[CompilerGenerated]
	private void CKFCDDIIPPF(KNMNJBFGHDK MGFEBOILECI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class NOKHHKFOEMJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xD69820", Offset = "0xD68C20", VA = "0x180D69820")]
	public NOKHHKFOEMJ(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class FPNFKINHEBP : OJJEGIAACKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct FFPAEEFKCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public FPNFKINHEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x67A8A40", Offset = "0x67A7E40", VA = "0x1867A8A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x67A8D80", Offset = "0x67A8180", VA = "0x1867A8D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	public FPNFKINHEBP(HDAJFOAIBMP DPKDAIDNMNC, LJHJLDLGJAI ACAIKIGINDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x67A93B0", Offset = "0x67A87B0", VA = "0x1867A93B0", Slot = "4")]
	[AsyncStateMachine(typeof(FFPAEEFKCIL))]
	public Task<bool> LKLDPCCKPAL(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x67A92D0", Offset = "0x67A86D0", VA = "0x1867A92D0")]
	[CompilerGenerated]
	private object CFCLBALPHEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class JHOGLLPMHNH : OJJEGIAACKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct OEDEFDEAHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public JHOGLLPMHNH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67B5320", Offset = "0x67B4720", VA = "0x1867B5320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x67B5A30", Offset = "0x67B4E30", VA = "0x1867B5A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x67AC6E0", Offset = "0x67ABAE0", VA = "0x1867AC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	public JHOGLLPMHNH(HDAJFOAIBMP DPKDAIDNMNC, LJHJLDLGJAI ACAIKIGINDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x67AC730", Offset = "0x67ABB30", VA = "0x1867AC730", Slot = "4")]
	[AsyncStateMachine(typeof(OEDEFDEAHKJ))]
	public Task<bool> LKLDPCCKPAL(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x67AC860", Offset = "0x67ABC60", VA = "0x1867AC860")]
	[CompilerGenerated]
	private object OGOAACDMHHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class EDECNOEKHLF : OJJEGIAACKE
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class AGJFMCEBJFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public EDECNOEKHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IBIFNJFFMJI result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public DHOCBLKANBD newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public AGJFMCEBJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x67986B0", Offset = "0x6797AB0", VA = "0x1867986B0")]
		internal object AMOMGDEJHLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x67987A0", Offset = "0x6797BA0", VA = "0x1867987A0")]
		internal object FIDPFCECKOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6798810", Offset = "0x6797C10", VA = "0x186798810")]
		internal object HAFMKGGEEGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct ILBINKJIPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public EDECNOEKHLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private AGJFMCEBJFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<IBIFNJFFMJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x67ABB10", Offset = "0x67AAF10", VA = "0x1867ABB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x67AC440", Offset = "0x67AB840", VA = "0x1867AC440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x67A7880", Offset = "0x67A6C80", VA = "0x1867A7880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	public EDECNOEKHLF(HDAJFOAIBMP DPKDAIDNMNC, LJHJLDLGJAI ACAIKIGINDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x67A78D0", Offset = "0x67A6CD0", VA = "0x1867A78D0", Slot = "4")]
	[AsyncStateMachine(typeof(ILBINKJIPJK))]
	public Task<bool> LKLDPCCKPAL(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface OJJEGIAACKE
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LKLDPCCKPAL(CancellationToken KNKAEBKAEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct DFENCLADOGG
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LNBMMNBCJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HDAJFOAIBMP manager;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LNBMMNBCJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67B0720", Offset = "0x67AFB20", VA = "0x1867B0720")]
		internal Task BKMGDENMKHI(FCICHBFPKKL data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OCCLEFOODMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public DFENCLADOGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private AFFLFHNACKH <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<NFDPDDHAFKK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<OAHKKLBHOHO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67B4D20", Offset = "0x67B4120", VA = "0x1867B4D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x67B52B0", Offset = "0x67B46B0", VA = "0x1867B52B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct PHHKJLHIMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public DFENCLADOGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x67B6200", Offset = "0x67B5600", VA = "0x1867B6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x67B6520", Offset = "0x67B5920", VA = "0x1867B6520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken KNKAEBKAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly HDAJFOAIBMP BJMBJJIMGHO;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private EBJMBPHPLIM DANKFOHDBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x679E970", Offset = "0x679DD70", VA = "0x18679E970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x679EA40", Offset = "0x679DE40", VA = "0x18679EA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x679E9C0", Offset = "0x679DDC0", VA = "0x18679E9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private JAMAFABDHEE POACNAAOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x679EE50", Offset = "0x679E250", VA = "0x18679EE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DE46A0", Offset = "0x1DE3AA0", VA = "0x181DE46A0")]
	public DFENCLADOGG(CancellationToken KNKAEBKAEBM, HDAJFOAIBMP BJMBJJIMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x679ECD0", Offset = "0x679E0D0", VA = "0x18679ECD0")]
	public static MPOBLIBLGKJ NPPPGDMFEIL(HDAJFOAIBMP BJMBJJIMGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x679EA90", Offset = "0x679DE90", VA = "0x18679EA90")]
	[AsyncStateMachine(typeof(OCCLEFOODMI))]
	public Task<bool> KFNIOKHILDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x679EEA0", Offset = "0x679E2A0", VA = "0x18679EEA0")]
	private bool PEIFLMAHBEM([Out] AFFLFHNACKH DONGLMJPIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x679ED80", Offset = "0x679E180", VA = "0x18679ED80")]
	[AsyncStateMachine(typeof(PHHKJLHIMLP))]
	private Task OIELMKGKLPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x679EBA0", Offset = "0x679DFA0", VA = "0x18679EBA0")]
	private Task<NFDPDDHAFKK> NBFFJMHIFNG(AFFLFHNACKH FIJBMGENNBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct LNPOCOFJDMD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly APNCNBJOMLO EPODIEHPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid FHLPBMFOONK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private Task<(OAHKKLBHOHO, Task)> IAKHHEALCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x67B0770", Offset = "0x67AFB70", VA = "0x1867B0770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC9B0", Offset = "0x3CFBDB0", VA = "0x183CFC9B0")]
	public LNPOCOFJDMD(APNCNBJOMLO EPODIEHPGPN, Guid FHLPBMFOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x67B0910", Offset = "0x67AFD10", VA = "0x1867B0910")]
	public TaskAwaiter<(OAHKKLBHOHO, Task)> IFJFKNHNFJJ()
	{
		return default(TaskAwaiter<(OAHKKLBHOHO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x67B0840", Offset = "0x67AFC40", VA = "0x1867B0840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct CPLIFBJDPIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(OAHKKLBHOHO, Task)> CKKNBEILMIF;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task<(OAHKKLBHOHO, Task)> IAKHHEALCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x679E5E0", Offset = "0x679D9E0", VA = "0x18679E5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x679E7E0", Offset = "0x679DBE0", VA = "0x18679E7E0")]
	public CPLIFBJDPIG(TimeSpan KCLHELHGLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x679E620", Offset = "0x679DA20", VA = "0x18679E620")]
	public void HMKPLAHPLNB(Task HPDFLBHLELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x679E6C0", Offset = "0x679DAC0", VA = "0x18679E6C0")]
	public void MNLFHMPBAAJ(OAHKKLBHOHO GEFKDGHDAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x679E590", Offset = "0x679D990", VA = "0x18679E590")]
	public void CECIGDNOPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x679E750", Offset = "0x679DB50", VA = "0x18679E750")]
	internal void OJCBLKBBLCH(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class HDFBIOJGFIG
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class IKKECKALJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ICJANOLCGFM subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IKKECKALJFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x67ABAE0", Offset = "0x67AAEE0", VA = "0x1867ABAE0")]
		internal bool AENAIJPBPPK(EFJPDNIEGLO s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x67A9AB0", Offset = "0x67A8EB0", VA = "0x1867A9AB0")]
	public static MAIDGDACGFA HEJOOLMEDMH(long LFFKCEKPFCD, long LFGAFDMLOJL, string PDFKPGNALBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x67A9B40", Offset = "0x67A8F40", VA = "0x1867A9B40")]
	public static MAIDGDACGFA HEJOOLMEDMH(long LFFKCEKPFCD, long LFGAFDMLOJL, LOEJPFELMNK AIFELOLJMOB, long PNLPKLPODDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x67A9E30", Offset = "0x67A9230", VA = "0x1867A9E30")]
	public static MAIDGDACGFA HEJOOLMEDMH(GDPFOGKLBJD BJOPOKHNEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x67A9C00", Offset = "0x67A9000", VA = "0x1867A9C00")]
	public static MAIDGDACGFA HEJOOLMEDMH(DAFHOICEHFC AEBLHFCFPIJ, ICJANOLCGFM IPLFONECMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x67A99C0", Offset = "0x67A8DC0", VA = "0x1867A99C0")]
	public static MAIDGDACGFA DJJLKNOGMFM(this MAIDGDACGFA KJOCNIDJGCN, DAFHOICEHFC NDLGGMDICMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x67A9FC0", Offset = "0x67A93C0", VA = "0x1867A9FC0")]
	public static MAIDGDACGFA LNFPDBCJCNP(this MAIDGDACGFA KJOCNIDJGCN, ICJANOLCGFM CMCNPFMNJOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class DGNJHGCDMMH : EKMIMGLAEBJ, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct EANLOGAIIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public DGNJHGCDMMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x67A6680", Offset = "0x67A5A80", VA = "0x1867A6680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x67A6D10", Offset = "0x67A6110", VA = "0x1867A6D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly HMKEPMLABHI NJAAHLFFBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string JADCEMALLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task BIILJKIJPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BONEJHJHINB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x679F3C0", Offset = "0x679E7C0", VA = "0x18679F3C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Task LJKNILBANKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x679F330", Offset = "0x679E730", VA = "0x18679F330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80", Slot = "7")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x679F1D0", Offset = "0x679E5D0", VA = "0x18679F1D0", Slot = "6")]
	public void IHGJFAPHMGF(Task JKFKBCIOAGB, string FMEHHEPBNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x679F0B0", Offset = "0x679E4B0", VA = "0x18679F0B0")]
	[AsyncStateMachine(typeof(EANLOGAIIJE))]
	private Task DLAAIOJPLIA(Task KCHMFIOPAGA, string FMEHHEPBNKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x679F3F0", Offset = "0x679E7F0", VA = "0x18679F3F0")]
	public DGNJHGCDMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class IEIKHGCFPAL : EIGDPGKBIAC, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool PBEFAGNFAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private JDKDAIBAAAF AHHOJMKPIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private DCMBPKDFJJA GLPHPNDFKED;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JDKDAIBAAAF ICFFCPHINCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x67AB680", Offset = "0x67AAA80", VA = "0x1867AB680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x67AB6F0", Offset = "0x67AAAF0", VA = "0x1867AB6F0", Slot = "7")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67AB870", Offset = "0x67AAC70", VA = "0x1867AB870", Slot = "5")]
	public void HNDCNNLBIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x67AB640", Offset = "0x67AAA40", VA = "0x1867AB640", Slot = "6")]
	public void FBGEHLGPJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67ABA20", Offset = "0x67AAE20", VA = "0x1867ABA20")]
	private Task LEDAOOIMMOK(FBCNPHCLFCP OBMKPHNOIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x67AB640", Offset = "0x67AAA40", VA = "0x1867AB640", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public IEIKHGCFPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class MAIIGGFGHNP : DCMBPKDFJJA
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class GBKOLLLGDFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly PFCFBJFKCHM HKIMMHDFNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string NIOPCMHKLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T DADBDDPBLHB;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public T EIHNEEOMIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x811020", Offset = "0x810420", VA = "0x180811020")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x878EA0", Offset = "0x8782A0", VA = "0x180878EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x37B7740", Offset = "0x37B6B40", VA = "0x1837B7740")]
		public GBKOLLLGDFL(PFCFBJFKCHM HKIMMHDFNPL, string NIOPCMHKLMB, T DADBDDPBLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x37B7420", Offset = "0x37B6820", VA = "0x1837B7420")]
		private void POPJDHIGFOP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly PFCFBJFKCHM HKIMMHDFNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly GBKOLLLGDFL<TimeSpan> GOELAIMBMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly GBKOLLLGDFL<TimeSpan> APNEFIFECCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly GBKOLLLGDFL<TimeSpan> EFKCBNANIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly GBKOLLLGDFL<TimeSpan> ELOCJAGJKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly GBKOLLLGDFL<bool> KCKOIMBPBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly GBKOLLLGDFL<bool> HLDNBECOLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly GBKOLLLGDFL<bool> JDHHIPJDHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly GBKOLLLGDFL<int> POFHEMAKKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly GBKOLLLGDFL<bool> OGLEHBANBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly GBKOLLLGDFL<bool> DDPJJBBHLDB;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan IEEDGHHKLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x67B1460", Offset = "0x67B0860", VA = "0x1867B1460", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan PJPJHBPCKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x67B13E0", Offset = "0x67B07E0", VA = "0x1867B13E0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan JOCFIKGMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x67B1320", Offset = "0x67B0720", VA = "0x1867B1320", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TimeSpan FOLEAMKCKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x67B12A0", Offset = "0x67B06A0", VA = "0x1867B12A0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool PIGJOBEKDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x67B14E0", Offset = "0x67B08E0", VA = "0x1867B14E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FPCAANALNIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x67B14A0", Offset = "0x67B08A0", VA = "0x1867B14A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool MNBBFMEOLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x67B13A0", Offset = "0x67B07A0", VA = "0x1867B13A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int NNAIGHCBNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x67B12E0", Offset = "0x67B06E0", VA = "0x1867B12E0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool BCNCBCMAFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x67B1360", Offset = "0x67B0760", VA = "0x1867B1360", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool IAOMLPCMDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x67B1420", Offset = "0x67B0820", VA = "0x1867B1420", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x67B1520", Offset = "0x67B0920", VA = "0x1867B1520")]
	[UnityEngine.Scripting.Preserve]
	public MAIIGGFGHNP([AKGMOFMFNCG(null)] PFCFBJFKCHM HKIMMHDFNPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class EBCBDNDGGAL : HLKBINDKIBL, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PCIHMHNEBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public BHGHCLPFMEJ roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PCIHMHNEBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x67B5AA0", Offset = "0x67B4EA0", VA = "0x1867B5AA0")]
		internal object DEOGICJNEHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action HFIMMOFJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x67A7510", Offset = "0x67A6910", VA = "0x1867A7510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x67A7290", Offset = "0x67A6690", VA = "0x1867A7290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event AJGMDLCNHGO OBMPGHECADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x67A75B0", Offset = "0x67A69B0", VA = "0x1867A75B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x67A7330", Offset = "0x67A6730", VA = "0x1867A7330", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event AJGMDLCNHGO ADPPGFBLFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x67A73D0", Offset = "0x67A67D0", VA = "0x1867A73D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x67A7470", Offset = "0x67A6870", VA = "0x1867A7470", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event AJGMDLCNHGO DLOEDJGBJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x67A7020", Offset = "0x67A6420", VA = "0x1867A7020", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x67A7680", Offset = "0x67A6A80", VA = "0x1867A7680", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FHHLMPEEIFB, bool> IDHEFGEJHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x67A7720", Offset = "0x67A6B20", VA = "0x1867A7720", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x67A77D0", Offset = "0x67A6BD0", VA = "0x1867A77D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "19")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x67A6DD0", Offset = "0x67A61D0", VA = "0x1867A6DD0", Slot = "14")]
	public void APFHGEIKBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x67A6D70", Offset = "0x67A6170", VA = "0x1867A6D70", Slot = "15")]
	public void ABGCLMJHAJA(BHGHCLPFMEJ IIBBCMNHPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x67A7650", Offset = "0x67A6A50", VA = "0x1867A7650", Slot = "16")]
	public void IIDIBEFJALG(BHGHCLPFMEJ IIBBCMNHPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x67A6DA0", Offset = "0x67A61A0", VA = "0x1867A6DA0", Slot = "17")]
	public void AICIIAOKGNI(BHGHCLPFMEJ IIBBCMNHPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x67A6FD0", Offset = "0x67A63D0", VA = "0x1867A6FD0", Slot = "18")]
	public void BINPOGHLCED(FHHLMPEEIFB MMIJGFOKHGO, bool DLEFFDAKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x67A70C0", Offset = "0x67A64C0", VA = "0x1867A70C0")]
	private void CAFHCMPOKLC(AJGMDLCNHGO PLEAEFJJBBO, BHGHCLPFMEJ IIBBCMNHPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public EBCBDNDGGAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class BMGIKKJKPOB : FFHFEGGDIAA, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct ACFNAJOEMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public BMGIKKJKPOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6798170", Offset = "0x6797570", VA = "0x186798170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6798650", Offset = "0x6797A50", VA = "0x186798650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct DLIJMHHMKAA : IAsyncStateMachine
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
		public BMGIKKJKPOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x67A0B20", Offset = "0x679FF20", VA = "0x1867A0B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x67A1180", Offset = "0x67A0580", VA = "0x1867A1180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class AOHLHPBHPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public AOHLHPBHPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x67990D0", Offset = "0x67984D0", VA = "0x1867990D0")]
		internal object FJGEEHKADIP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct CIJKDJNHFCK : IAsyncStateMachine
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
		public BMGIKKJKPOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private AOHLHPBHPAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x679DDD0", Offset = "0x679D1D0", VA = "0x18679DDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x679E520", Offset = "0x679D920", VA = "0x18679E520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GHIFKMDKLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GHIFKMDKLLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x67A94A0", Offset = "0x67A88A0", VA = "0x1867A94A0")]
		internal object DABGCADCCEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private OJJEGIAACKE[] OOHCOCMMOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource MCEEHGKCGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int EDNIBIBHOFP;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x679CFF0", Offset = "0x679C3F0", VA = "0x18679CFF0", Slot = "6")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x679CEB0", Offset = "0x679C2B0", VA = "0x18679CEB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x679CDB0", Offset = "0x679C1B0", VA = "0x18679CDB0", Slot = "8")]
	public void BFKHLHMCMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x679D540", Offset = "0x679C940", VA = "0x18679D540", Slot = "5")]
	public void LBBFHMEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x679D470", Offset = "0x679C870", VA = "0x18679D470", Slot = "4")]
	[AsyncStateMachine(typeof(ACFNAJOEMDI))]
	public Task KDPHAILLALK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x679D610", Offset = "0x679CA10", VA = "0x18679D610")]
	private void LFINNKGCFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x679D150", Offset = "0x679C550", VA = "0x18679D150")]
	[AsyncStateMachine(typeof(DLIJMHHMKAA))]
	private Task IGGHJHMLFKL(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x679D330", Offset = "0x679C730", VA = "0x18679D330")]
	[AsyncStateMachine(typeof(CIJKDJNHFCK))]
	private Task<bool> JNBMPAGFMBI(int PMLKPJNGBAD, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x679D250", Offset = "0x679C650", VA = "0x18679D250")]
	private void JEFCOGGONMD(int PMLKPJNGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x679D070", Offset = "0x679C470", VA = "0x18679D070")]
	private void HPFPDHNBHJF(int PMLKPJNGBAD, bool DLEFFDAKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x679CEC0", Offset = "0x679C2C0", VA = "0x18679CEC0")]
	private void ECBKHMPFKBA(int PMLKPJNGBAD, Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x679D920", Offset = "0x679CD20", VA = "0x18679D920")]
	private void MCELIDCEDKF(CancellationToken KNKAEBKAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BMGIKKJKPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class BBEOCKDDFEM : GNHCHIOFANA, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct MJKCKKHPHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public EKJMLCAAKLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x67B2850", Offset = "0x67B1C50", VA = "0x1867B2850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x67B31B0", Offset = "0x67B25B0", VA = "0x1867B31B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct MHFLEKADGGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public EKJMLCAAKLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private OHKLINEMLLN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KHPKPEKMPBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private BIMKIOLAEHO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private HDDMLHPPBAE <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x67B1990", Offset = "0x67B0D90", VA = "0x1867B1990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x67B2550", Offset = "0x67B1950", VA = "0x1867B2550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class PLGKFLPPACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.HMGKIDIEPNP result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MHLADHKBCOD errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PLGKFLPPACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x67B6580", Offset = "0x67B5980", VA = "0x1867B6580")]
		internal object IOLKDCJBKPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class MOFDCGFIBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<MAIDGDACGFA> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MOFDCGFIBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		internal Task<MAIDGDACGFA> JAFICNCHOAP(OHKLINEMLLN<string>.IECBLACBOCC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct DNHAEEPIFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EKJMLCAAKLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BIMKIOLAEHO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private MOFDCGFIBCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private HKMFNMHKCNF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private KHPKPEKMPBB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private OHKLINEMLLN<string>.IECBLACBOCC <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private BMIHPPNPOPO <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.EGDLHLJICEN> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private FHBGBICDHKJ <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.EGDLHLJICEN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<MAIDGDACGFA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x67A11E0", Offset = "0x67A05E0", VA = "0x1867A11E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x67A63A0", Offset = "0x67A57A0", VA = "0x1867A63A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HOABCNLHJFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private OHKLINEMLLN<string>.IECBLACBOCC <disconnectTimerScope>5__3;

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
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x67AA680", Offset = "0x67A9A80", VA = "0x1867AA680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x67AB0D0", Offset = "0x67AA4D0", VA = "0x1867AB0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct FLGHFNFMMJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private BNDLKDEPBDF <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x67A8DF0", Offset = "0x67A81F0", VA = "0x1867A8DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x67A9270", Offset = "0x67A8670", VA = "0x1867A9270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MOMFPNNNFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.EGDLHLJICEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.EGDLHLJICEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x67B32B0", Offset = "0x67B26B0", VA = "0x1867B32B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x67B37B0", Offset = "0x67B2BB0", VA = "0x1867B37B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct LOGOBFMBHEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.EGDLHLJICEN serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public BIMKIOLAEHO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<FGOEEHDGNPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x67B0960", Offset = "0x67AFD60", VA = "0x1867B0960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x67B1060", Offset = "0x67B0460", VA = "0x1867B1060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class ENJLJDOPNAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public DHOCBLKANBD targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ENJLJDOPNAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x67A8840", Offset = "0x67A7C40", VA = "0x1867A8840")]
		internal object GDBCNIMOCNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x67A8940", Offset = "0x67A7D40", VA = "0x1867A8940")]
		internal string IDBGNDJKCLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct NEONGPEIOJO : IAsyncStateMachine
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
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private ENJLJDOPNAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private KHPKPEKMPBB <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x67B3820", Offset = "0x67B2C20", VA = "0x1867B3820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x67B43F0", Offset = "0x67B37F0", VA = "0x1867B43F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct LDPIFKHJGGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public BIMKIOLAEHO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public MAIDGDACGFA initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public DHOCBLKANBD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HKMFNMHKCNF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private OHKLINEMLLN<string>.IECBLACBOCC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x67AF2D0", Offset = "0x67AE6D0", VA = "0x1867AF2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x67AFBE0", Offset = "0x67AEFE0", VA = "0x1867AFBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct DKJGFJAAOMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private OHKLINEMLLN<string>.IECBLACBOCC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private KHPKPEKMPBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap3;

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
		[Cpp2IlInjected.Address(RVA = "0x679F480", Offset = "0x679E880", VA = "0x18679F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x67A0AC0", Offset = "0x679FEC0", VA = "0x1867A0AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct AODAOLACEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public BBEOCKDDFEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<OAHKKLBHOHO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x67988B0", Offset = "0x6797CB0", VA = "0x1867988B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6799070", Offset = "0x6798470", VA = "0x186799070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class PCPEGCIFBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PCPEGCIFBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x67B5B80", Offset = "0x67B4F80", VA = "0x1867B5B80")]
		internal object LIEAEHMLGAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class MOCLGEIDEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MOCLGEIDEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x67B3210", Offset = "0x67B2610", VA = "0x1867B3210")]
		internal void KBLICKKGOFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class LKJMPHHJOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LKJMPHHJOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x67B06A0", Offset = "0x67AFAA0", VA = "0x1867B06A0")]
		internal object FLJCFNPHMDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class BCMIKCLCJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BCMIKCLCJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x679CC40", Offset = "0x679C040", VA = "0x18679CC40")]
		internal string ICDIMLMDDJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly GFLOJPOFOAD ILNKPGOKIEP;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly GFLOJPOFOAD NCCMADBBAPM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly GFLOJPOFOAD LODCCLCECCB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string PAKJMIKELHM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string GKEBLNCEOIO;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string DBCLFPGEPIN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid MEHPKIEFEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private JFOMGCGOIAJ DBBLKPDBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private DGBDMKLJLHC MNLKGNAKHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private FFHFEGGDIAA MPOLMEODBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private EKMIMGLAEBJ HEOMPBLFEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private HLKBINDKIBL PPBCLHOGJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IJHGMFGBKAE ICAIDOIOJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private FHPDKEAIEPM JBDIHNFLMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable AIDDDKPJGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly HMKEPMLABHI JOMIEODGNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly HMKEPMLABHI NJBDOIKGCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private FHBGBICDHKJ LMJOBPMBCFN;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TaskStatus KBLDNFKOPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x884460", Offset = "0x883860", VA = "0x180884460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB2F190", Offset = "0xB2E590", VA = "0x180B2F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6799EC0", Offset = "0x67992C0", VA = "0x186799EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x679A130", Offset = "0x6799530", VA = "0x18679A130", Slot = "6")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x679A0E0", Offset = "0x67994E0", VA = "0x18679A0E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x679C310", Offset = "0x679B710", VA = "0x18679C310", Slot = "5")]
	[AsyncStateMachine(typeof(MJKCKKHPHJG))]
	public Task NOGMIEBINPH(DHOCBLKANBD AOBLKOJAFBL, EKJMLCAAKLM OMDLIBLMABJ, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x679BC50", Offset = "0x679B050", VA = "0x18679BC50")]
	[AsyncStateMachine(typeof(MHFLEKADGGG))]
	private Task MLJHNNGJJOL(DHOCBLKANBD AOBLKOJAFBL, EKJMLCAAKLM OMDLIBLMABJ, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x679B890", Offset = "0x679AC90", VA = "0x18679B890")]
	private static void LNIOMNBNMIE(IJHGMFGBKAE ICAIDOIOJIK, DHOCBLKANBD AOBLKOJAFBL, Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6799370", Offset = "0x6798770", VA = "0x186799370")]
	private static void AHAOLHBMPCJ(HDDMLHPPBAE LFOGDCOHCJJ, Exception DAAIKNOAPFE, [Optional] List<int> EJHNKCCIIAL, int EDNIBIBHOFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x679B490", Offset = "0x679A890", VA = "0x18679B490")]
	[AsyncStateMachine(typeof(DNHAEEPIFMG))]
	private Task KMKCJJOJFJL(OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, DHOCBLKANBD AOBLKOJAFBL, EKJMLCAAKLM OMDLIBLMABJ, BIMKIOLAEHO PABONNKHDHD, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x679A5F0", Offset = "0x67999F0", VA = "0x18679A5F0")]
	private void FFENBDKOMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x679BEB0", Offset = "0x679B2B0", VA = "0x18679BEB0")]
	[AsyncStateMachine(typeof(HOABCNLHJFO))]
	private Task NBKEHHKBBFL(OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x679BFE0", Offset = "0x679B3E0", VA = "0x18679BFE0")]
	private void NJKEGILCMFH(DHOCBLKANBD AOBLKOJAFBL, CancellationToken JKLIJNDGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x679C610", Offset = "0x679BA10", VA = "0x18679C610")]
	private void PCAGPGJCIIK(DHOCBLKANBD AOBLKOJAFBL, BIMKIOLAEHO PABONNKHDHD, OperationCanceledException FFJMPPLOIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6799140", Offset = "0x6798540", VA = "0x186799140")]
	private void ADIKLPFLGLC(DHOCBLKANBD AOBLKOJAFBL, BIMKIOLAEHO PABONNKHDHD, Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x679A990", Offset = "0x6799D90", VA = "0x18679A990")]
	private void GDFCCOJGDBP(DHOCBLKANBD AOBLKOJAFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x679A080", Offset = "0x6799480", VA = "0x18679A080")]
	private static BHGHCLPFMEJ DMLNBKMBCDL(DHOCBLKANBD AOBLKOJAFBL)
	{
		return default(BHGHCLPFMEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x679AFE0", Offset = "0x679A3E0", VA = "0x18679AFE0")]
	[AsyncStateMachine(typeof(FLGHFNFMMJC))]
	private Task IHKLIHPHGHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x679C450", Offset = "0x679B850", VA = "0x18679C450")]
	[AsyncStateMachine(typeof(MOMFPNNNFEC))]
	private Task<Matchmaking.EGDLHLJICEN> OABAPAKKLPG(DHOCBLKANBD AOBLKOJAFBL, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x679BDA0", Offset = "0x679B1A0", VA = "0x18679BDA0")]
	private static FGOEEHDGNPD MPNIIKOFEIK(Matchmaking.EGDLHLJICEN ODOINLAFJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x679ABA0", Offset = "0x6799FA0", VA = "0x18679ABA0")]
	[AsyncStateMachine(typeof(LOGOBFMBHEC))]
	private Task GFHEALMMFMN(Matchmaking.EGDLHLJICEN ODOINLAFJKE, BIMKIOLAEHO PABONNKHDHD, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken NFFLDFKMADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6799D80", Offset = "0x6799180", VA = "0x186799D80")]
	[AsyncStateMachine(typeof(NEONGPEIOJO))]
	private Task CMECMMOJLBC(DHOCBLKANBD AOBLKOJAFBL, CancellationTokenSource CIONGEIKOGN, Task HAAEOOJNBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6799F10", Offset = "0x6799310", VA = "0x186799F10")]
	[AsyncStateMachine(typeof(LDPIFKHJGGC))]
	private Task DJCMBIFKHNO(MAIDGDACGFA IFCFJDMMIJG, HKMFNMHKCNF IFLHKNNILKF, DHOCBLKANBD JLPLEBFHBPI, BIMKIOLAEHO HEEBEICCIGL, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken APHBFDIIJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x679B0B0", Offset = "0x679A4B0", VA = "0x18679B0B0")]
	private BIMKIOLAEHO ILMDKKJGJII(BIMKIOLAEHO HEEBEICCIGL, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x679A740", Offset = "0x6799B40", VA = "0x18679A740")]
	[AsyncStateMachine(typeof(DKJGFJAAOMB))]
	private Task FNJAFKKGBPL(OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x679A870", Offset = "0x6799C70", VA = "0x18679A870")]
	[AsyncStateMachine(typeof(AODAOLACEAH))]
	private Task GCBFJBKEDNA(FCICHBFPKKL FLKOGFDGJDF, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6799C00", Offset = "0x6799000", VA = "0x186799C00")]
	private static void AONPMHNJAEC(DHOCBLKANBD AOBLKOJAFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x679AD80", Offset = "0x679A180", VA = "0x18679AD80")]
	private void HLEMLHFAKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x679ACF0", Offset = "0x679A0F0", VA = "0x18679ACF0")]
	private void HDMENAJELDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x679B2A0", Offset = "0x679A6A0", VA = "0x18679B2A0")]
	private void IOCINCOINAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x679AF50", Offset = "0x679A350", VA = "0x18679AF50")]
	private void IDLFJLLNHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x679B5F0", Offset = "0x679A9F0", VA = "0x18679B5F0")]
	private static void LIOKLHNHJDP(DHOCBLKANBD AOBLKOJAFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x679C840", Offset = "0x679BC40", VA = "0x18679C840")]
	private static CancellationTokenRegistration PJNAJFCLMKE(DHOCBLKANBD AOBLKOJAFBL, CancellationToken NFFLDFKMADA)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x679B330", Offset = "0x679A730", VA = "0x18679B330")]
	private static void JODJPNDNNAL(DHOCBLKANBD AOBLKOJAFBL, Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x679B6E0", Offset = "0x679AAE0", VA = "0x18679B6E0")]
	private void LLHHJNIBJFO(DHOCBLKANBD AOBLKOJAFBL, Task HAAEOOJNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x679C5B0", Offset = "0x679B9B0", VA = "0x18679C5B0")]
	private static void OMAIFAPDBID(Func<string> MJDNKBBGCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x679CB70", Offset = "0x679BF70", VA = "0x18679CB70")]
	public BBEOCKDDFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x679B430", Offset = "0x679A830", VA = "0x18679B430")]
	[CompilerGenerated]
	internal static (int, int?) KDBGNIGFHCL(MHLADHKBCOD MNEGDIGLFLH)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class JOBAEBGNJII : OPBJHLIBNLE, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct DPFIOFEFGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public JOBAEBGNJII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public FCICHBFPKKL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x67BE9F0", Offset = "0x67BDDF0", VA = "0x1867BE9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x67BEDB0", Offset = "0x67BE1B0", VA = "0x1867BEDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class KNDLKFLBIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public JOBAEBGNJII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public FCICHBFPKKL roomData;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KNDLKFLBIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x67CCC40", Offset = "0x67CC040", VA = "0x1867CCC40")]
		internal List<Task> PELLJCDHECN(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct JCOIHIDIEFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public MPOBLIBLGKJ taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x67C8920", Offset = "0x67C7D20", VA = "0x1867C8920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x67C8CB0", Offset = "0x67C80B0", VA = "0x1867C8CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct LNOLIKFDAKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public JOBAEBGNJII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x67CEFC0", Offset = "0x67CE3C0", VA = "0x1867CEFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x67CF280", Offset = "0x67CE680", VA = "0x1867CF280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<MPOBLIBLGKJ> NNMLDKGHDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private DGBDMKLJLHC MNLKGNAKHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private OOHNHIIBEBE NODACGAIJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private OCGHBLOGJFN GKOJDENOHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable AIDDDKPJGJC;

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x67ADB00", Offset = "0x67ACF00", VA = "0x1867ADB00", Slot = "5")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x67ADAA0", Offset = "0x67ACEA0", VA = "0x1867ADAA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x67AE5B0", Offset = "0x67AD9B0", VA = "0x1867AE5B0", Slot = "4")]
	public bool JMAPHJGLODD(MPOBLIBLGKJ MBADCNKMPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x67ADD80", Offset = "0x67AD180", VA = "0x1867ADD80")]
	private void FGJGHONCGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x67ADF80", Offset = "0x67AD380", VA = "0x1867ADF80")]
	private void IHNCDIFGEDG(FCICHBFPKKL HADHNEGDEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x67AE610", Offset = "0x67ADA10", VA = "0x1867AE610")]
	[AsyncStateMachine(typeof(DPFIOFEFGBG))]
	private Task KLEFGNLCMED(FCICHBFPKKL HADHNEGDEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x67AE700", Offset = "0x67ADB00", VA = "0x1867AE700")]
	private Func<CancellationToken, List<Task>> NKDDMGKFBJA(FCICHBFPKKL HADHNEGDEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x67AE160", Offset = "0x67AD560", VA = "0x1867AE160")]
	private List<Task> JIHNDMBCBNP(FCICHBFPKKL HADHNEGDEKF, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x67AD980", Offset = "0x67ACD80", VA = "0x1867AD980")]
	[AsyncStateMachine(typeof(JCOIHIDIEFM))]
	private Task CIFHKCPNCBI(MPOBLIBLGKJ EDAAAJMFDFC, FCICHBFPKKL FLKOGFDGJDF, CancellationToken ICNJFMMNIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x67ADEB0", Offset = "0x67AD2B0", VA = "0x1867ADEB0")]
	[AsyncStateMachine(typeof(LNOLIKFDAKN))]
	private Task IEKBAKCGJKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x67AD900", Offset = "0x67ACD00", VA = "0x1867AD900")]
	private void BFKHLHMCMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x67AE7D0", Offset = "0x67ADBD0", VA = "0x1867AE7D0")]
	public JOBAEBGNJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class DACNGNLCJMC : APNCNBJOMLO, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MMIGABOLKHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MMIGABOLKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x67CFB60", Offset = "0x67CEF60", VA = "0x1867CFB60")]
		internal object CCLMHPFGOGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class DKEICCIIMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DKEICCIIMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x67BDFD0", Offset = "0x67BD3D0", VA = "0x1867BDFD0")]
		internal object EEFNKGDJHHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CAPPECCLCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public CAPPECCLCMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class DEMAAPFJKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DEMAAPFJKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x67BD140", Offset = "0x67BC540", VA = "0x1867BD140")]
		internal object IFBACMIPNDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class JECPKIECHLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public JECPKIECHLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x67C8D10", Offset = "0x67C8110", VA = "0x1867C8D10")]
		internal object DHIAGMLMGCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, CPLIFBJDPIG> EPODIEHPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan LPHJGCGIIJK;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "9")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x67BA930", Offset = "0x67B9D30", VA = "0x1867BA930", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x67BA940", Offset = "0x67B9D40", VA = "0x1867BA940", Slot = "4")]
	public LNPOCOFJDMD FFIECPFJEFG(Guid FHLPBMFOONK)
	{
		return default(LNPOCOFJDMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x67BB2A0", Offset = "0x67BA6A0", VA = "0x1867BB2A0", Slot = "5")]
	public bool PIABDNKCBCD(Guid FHLPBMFOONK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x67BAD40", Offset = "0x67BA140", VA = "0x1867BAD40", Slot = "6")]
	public bool MCLOMJKPPMF(Guid FHLPBMFOONK, Task HPDFLBHLELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x67BAB60", Offset = "0x67B9F60", VA = "0x1867BAB60", Slot = "7")]
	public bool JFFFFAOCHFC(Guid FHLPBMFOONK, OAHKKLBHOHO GEFKDGHDAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x67BA8C0", Offset = "0x67B9CC0", VA = "0x1867BA8C0", Slot = "8")]
	public Task<(OAHKKLBHOHO, Task)> BJHFGMPALDJ(Guid FHLPBMFOONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x67BB070", Offset = "0x67BA470", VA = "0x1867BB070")]
	private void OJIKMJMCNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x67BB4B0", Offset = "0x67BA8B0", VA = "0x1867BB4B0")]
	public DACNGNLCJMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class IALKDNKKKDC : FIPCMLIBHDE, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class DILNMBAIFML : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly DHOCBLKANBD HGGOBOECGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource MCEEHGKCGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken IEBLPLMIONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool ACKBFCKDNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool KFEECCNBOJI;

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x67BD320", Offset = "0x67BC720", VA = "0x1867BD320")]
		public DILNMBAIFML(DHOCBLKANBD HGGOBOECGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x67BD1A0", Offset = "0x67BC5A0", VA = "0x1867BD1A0")]
		public void BFKHLHMCMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x67BD2F0", Offset = "0x67BC6F0", VA = "0x1867BD2F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MENAFPMJGFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public FBCNPHCLFCP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MENAFPMJGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x67CF5E0", Offset = "0x67CE9E0", VA = "0x1867CF5E0")]
		internal object BBOLKPIDDOD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct MIMLDBCFLDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public FBCNPHCLFCP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public IALKDNKKKDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x67CF750", Offset = "0x67CEB50", VA = "0x1867CF750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x67CFB00", Offset = "0x67CEF00", VA = "0x1867CFB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class OIHGBGBPABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OIHGBGBPABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x67D4400", Offset = "0x67D3800", VA = "0x1867D4400")]
		internal object BJGDKACJEAM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct DAMIIFKJBKO : IAsyncStateMachine
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
		public IALKDNKKKDC <>4__this;

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
		private KHPKPEKMPBB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x67BBD20", Offset = "0x67BB120", VA = "0x1867BBD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class HILHICGNEEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public DHOCBLKANBD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HILHICGNEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x67C1FA0", Offset = "0x67C13A0", VA = "0x1867C1FA0")]
		internal object EFHBOBDOPMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x67C2080", Offset = "0x67C1480", VA = "0x1867C2080")]
		internal object HDNJJKOMHHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x67C2040", Offset = "0x67C1440", VA = "0x1867C2040")]
		internal object FMFNIGCFDMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class PPNMIJIHGKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PPNMIJIHGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x67D5D10", Offset = "0x67D5110", VA = "0x1867D5D10")]
		internal void JIOHALBDKDP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct OGHPHAOBIOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public DHOCBLKANBD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public IALKDNKKKDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public EKJMLCAAKLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private HILHICGNEEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private KHPKPEKMPBB <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x67D3420", Offset = "0x67D2820", VA = "0x1867D3420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x67D43A0", Offset = "0x67D37A0", VA = "0x1867D43A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly BKNDKGNJJHF.EPBCKNMDFJE JKLKHOJHKIH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly IIKDMCIPNEF NOEINLGMKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private DGBDMKLJLHC MNLKGNAKHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private FFHFEGGDIAA MPOLMEODBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private DCMBPKDFJJA GLPHPNDFKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private GNHCHIOFANA GLLEIFJDLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long EENGNBELIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private DILNMBAIFML BEEAOANHPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool FHBAAJEDPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task GMDIFBGBOPI;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x67C4A80", Offset = "0x67C3E80", VA = "0x1867C4A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool CHKMFGPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1064620", Offset = "0x1063A20", VA = "0x181064620")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x67C4A70", Offset = "0x67C3E70", VA = "0x1867C4A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x67C5060", Offset = "0x67C4460", VA = "0x1867C5060", Slot = "4")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x67C4C50", Offset = "0x67C4050", VA = "0x1867C4C50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x67C4980", Offset = "0x67C3D80", VA = "0x1867C4980")]
	[AsyncStateMachine(typeof(MIMLDBCFLDH))]
	private Task AJLGLFBADKA(FBCNPHCLFCP GICGNINJKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x67C4EC0", Offset = "0x67C42C0", VA = "0x1867C4EC0")]
	private void EHDKIPCJNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x67C5590", Offset = "0x67C4990", VA = "0x1867C5590")]
	private void FOIEIEMIPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x67C4AD0", Offset = "0x67C3ED0", VA = "0x1867C4AD0")]
	private void DKPKMDBIJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x67C5970", Offset = "0x67C4D70", VA = "0x1867C5970")]
	private bool ODAKGAFLLGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x67C5720", Offset = "0x67C4B20", VA = "0x1867C5720")]
	[AsyncStateMachine(typeof(DAMIIFKJBKO))]
	private void GEOIHPJAFLC(int HCJFBLNDIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x67C5300", Offset = "0x67C4700", VA = "0x1867C5300")]
	private void FMIGLOBFJOC([Out] IDisposable NBCBPBBFICO, [Out] IDisposable ANOBOOJKGEI, [Out] IDisposable EFCDBFFFFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x67C4DC0", Offset = "0x67C41C0", VA = "0x1867C4DC0")]
	private bool EFMJBOLBAPO(DHOCBLKANBD HGGOBOECGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x67C5920", Offset = "0x67C4D20", VA = "0x1867C5920")]
	private void NKGMCMJFEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x67C57F0", Offset = "0x67C4BF0", VA = "0x1867C57F0")]
	[AsyncStateMachine(typeof(OGHPHAOBIOG))]
	private Task MLJHNNGJJOL(DHOCBLKANBD HGGOBOECGFH, EKJMLCAAKLM OMDLIBLMABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x67C5DB0", Offset = "0x67C51B0", VA = "0x1867C5DB0")]
	public IALKDNKKKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class HGEHMOBPLHO : FDNEAGGHJFD, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct MAIHNPLMKFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<EEPIJJHADBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public HGEHMOBPLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<EEPIJJHADBF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x67CF2E0", Offset = "0x67CE6E0", VA = "0x1867CF2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x67CF570", Offset = "0x67CE970", VA = "0x1867CF570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class GJMNNLHNJLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public ELOCCADIICN message;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GJMNNLHNJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x67BFF90", Offset = "0x67BF390", VA = "0x1867BFF90")]
		internal object KNCLGIIFGGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class AJMMHKJOLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public ELOCCADIICN messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public AJMMHKJOLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x67B71B0", Offset = "0x67B65B0", VA = "0x1867B71B0")]
		internal object CBFMAENMCBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class ODNNNEONCIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ODNNNEONCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x67D3180", Offset = "0x67D2580", VA = "0x1867D3180")]
		internal object KHKFJMGIMPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct KKLOJMCMCFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public HGEHMOBPLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<HKIJMCIKIMC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x67CC320", Offset = "0x67CB720", VA = "0x1867CC320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x67CCBE0", Offset = "0x67CBFE0", VA = "0x1867CCBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class INEPBJGGHOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public ELOCCADIICN operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public INEPBJGGHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x67C88C0", Offset = "0x67C7CC0", VA = "0x1867C88C0")]
		internal object GOGCHLKIIGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct CKOMDAAKFKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public ELOCCADIICN operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public HGEHMOBPLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private BIMKIOLAEHO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x67B9C90", Offset = "0x67B9090", VA = "0x1867B9C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x67BA800", Offset = "0x67B9C00", VA = "0x1867BA800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct BGFMOGDKFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<HKIJMCIKIMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public HGEHMOBPLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DMLHIJEBFFM.CCABHADEFJA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private BIMKIOLAEHO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x67B8610", Offset = "0x67B7A10", VA = "0x1867B8610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x67B8B30", Offset = "0x67B7F30", VA = "0x1867B8B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class GEJOCFDNEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public HKIJMCIKIMC operation;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GEJOCFDNEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x67BFCB0", Offset = "0x67BF0B0", VA = "0x1867BFCB0")]
		internal object GDJHKCOFGEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct KOMHPGLHILH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public HKIJMCIKIMC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public HGEHMOBPLHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private OHKLINEMLLN<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x67CCC70", Offset = "0x67CC070", VA = "0x1867CCC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x67CD2B0", Offset = "0x67CC6B0", VA = "0x1867CD2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class HLJMBJNHONO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HLJMBJNHONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x67C2870", Offset = "0x67C1C70", VA = "0x1867C2870")]
		internal object OPBIKFGDLCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class CCKGMBHILAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public CCKGMBHILAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x67B9C30", Offset = "0x67B9030", VA = "0x1867B9C30")]
		internal object ALDMPGDCJFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private EKMIMGLAEBJ HEOMPBLFEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private NOEOBKPFBPE LLGNFOBBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private MHAGEMEKKFD CFMFPPMJCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<EEPIJJHADBF> NODIABEELGG;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x67C0870", Offset = "0x67BFC70", VA = "0x1867C0870", Slot = "7")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x67C0760", Offset = "0x67BFB60", VA = "0x1867C0760", Slot = "6")]
	[AsyncStateMachine(typeof(MAIHNPLMKFO))]
	public Task<EEPIJJHADBF> CJHCIBCMPAJ(CancellationToken CPNBGHHNKIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x67C1260", Offset = "0x67C0660", VA = "0x1867C1260", Slot = "4")]
	public void LLIFMHNPMED(ELOCCADIICN JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x67C0F00", Offset = "0x67C0300", VA = "0x1867C0F00", Slot = "5")]
	public void LEOOBBJGPEP(ELOCCADIICN IAMIDAOFKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x67C15F0", Offset = "0x67C09F0", VA = "0x1867C15F0")]
	[AsyncStateMachine(typeof(KKLOJMCMCFM))]
	private Task LMCLPKMEBKD(ELOCCADIICN BDAAOBFBLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x67C0650", Offset = "0x67BFA50", VA = "0x1867C0650")]
	[AsyncStateMachine(typeof(CKOMDAAKFKE))]
	private Task CBPPPFKFNJO(ELOCCADIICN ECLLJDIHBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x67C18B0", Offset = "0x67C0CB0", VA = "0x1867C18B0")]
	[AsyncStateMachine(typeof(BGFMOGDKFNL))]
	private Task<HKIJMCIKIMC> PHGLFDONNNP(ELOCCADIICN BDAAOBFBLIB, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x67C1820", Offset = "0x67C0C20", VA = "0x1867C1820")]
	private BIMKIOLAEHO MIAGGBNFAIC(ELOCCADIICN CPBCMKCCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x67C1700", Offset = "0x67C0B00", VA = "0x1867C1700")]
	[AsyncStateMachine(typeof(KOMHPGLHILH))]
	private Task LNFOFMFJHED(HKIJMCIKIMC HOPLFLJKCIJ, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x67C0960", Offset = "0x67BFD60", VA = "0x1867C0960")]
	private HKIJMCIKIMC FGHPMFOLCCO(ELOCCADIICN BDAAOBFBLIB, BIMKIOLAEHO BELDBGPLNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x27FC290", Offset = "0x27FB690", VA = "0x1827FC290")]
	private T NGOCNFPMHHN<T>(T PCGOHCLJAPN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x67C0B70", Offset = "0x67BFF70", VA = "0x1867C0B70")]
	private HKIJMCIKIMC HFMMFNLLAIB(ELOCCADIICN BDAAOBFBLIB, BIMKIOLAEHO BELDBGPLNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HGEHMOBPLHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class HLLEHNMGABF : NOEOBKPFBPE, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class KPEICENOJOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KPEICENOJOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x67CD370", Offset = "0x67CC770", VA = "0x1867CD370")]
		internal object CBEPCBCNDOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class OPPHOKLECAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OPPHOKLECAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x67D5980", Offset = "0x67D4D80", VA = "0x1867D5980")]
		internal object DLJCFNDIMAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private FAOBGMFPLCB HBEDOEBNKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private FDNEAGGHJFD ECNOGDMNNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private APNCNBJOMLO EPODIEHPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private GLBCDAELEGO CHIIFCAMOMA;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x67C36D0", Offset = "0x67C2AD0", VA = "0x1867C36D0", Slot = "6")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x67C3160", Offset = "0x67C2560", VA = "0x1867C3160", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x67C28D0", Offset = "0x67C1CD0", VA = "0x1867C28D0", Slot = "4")]
	public LNPOCOFJDMD AHMOCMKPIEI(ELOCCADIICN EFOLDILOFHB)
	{
		return default(LNPOCOFJDMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x67C34C0", Offset = "0x67C28C0", VA = "0x1867C34C0", Slot = "5")]
	public void EOOOGBDGFGP(Guid FHLPBMFOONK, Task HPDFLBHLELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x67C3840", Offset = "0x67C2C40", VA = "0x1867C3840")]
	private void FBHNPALFGOL(byte AOKJGDOHJKF, int OJFHGENBFGL, object INDHICHJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x67C4370", Offset = "0x67C3770", VA = "0x1867C4370")]
	private void LNFLKFJLCHE(KHKCGIAJJMM LMBNCDMECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x67C4060", Offset = "0x67C3460", VA = "0x1867C4060")]
	private void IJNODBAMLGE(KHKCGIAJJMM LMBNCDMECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x67C3910", Offset = "0x67C2D10", VA = "0x1867C3910")]
	private void FJBMIKGIJGK(KHKCGIAJJMM LMBNCDMECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x67C2F20", Offset = "0x67C2320", VA = "0x1867C2F20")]
	private OAHKKLBHOHO CJABEIKKEDO(ELOCCADIICN CPBCMKCCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x67C2D10", Offset = "0x67C2110", VA = "0x1867C2D10")]
	private void BFMIIHHMLLK(ELOCCADIICN ECLLJDIHBHK, OAHKKLBHOHO GEFKDGHDAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x67C3210", Offset = "0x67C2610", VA = "0x1867C3210")]
	private bool EEADGAOLOCB(ELOCCADIICN ECLLJDIHBHK, OAHKKLBHOHO GEFKDGHDAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x67C3B50", Offset = "0x67C2F50", VA = "0x1867C3B50")]
	private bool GGBJGDMOFBK(ELOCCADIICN AJAFOOOJMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x67C3DD0", Offset = "0x67C31D0", VA = "0x1867C3DD0")]
	private bool IDIJJFCDFBA(byte AOKJGDOHJKF, ExitGames.Client.Photon.Hashtable LMBNCDMECGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HLLEHNMGABF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class NJFPAKEFBHC : JKGELICFIJG, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BGAAIEMAPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public EEPIJJHADBF operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public NJFPAKEFBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public ELOCCADIICN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BGAAIEMAPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x67B7F20", Offset = "0x67B7320", VA = "0x1867B7F20")]
		internal object GMFMCDHDKBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x67B7DF0", Offset = "0x67B71F0", VA = "0x1867B7DF0")]
		internal object EPMLJBOPCBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct LLIIICIIPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NJFPAKEFBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public ELOCCADIICN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<OAHKKLBHOHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x67CE8C0", Offset = "0x67CDCC0", VA = "0x1867CE8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x67CEF50", Offset = "0x67CE350", VA = "0x1867CEF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class HLPIKECPNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public EEPIJJHADBF operationType;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HLPIKECPNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x67C4910", Offset = "0x67C3D10", VA = "0x1867C4910")]
		internal object AAKPLAEDHKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class DBMBPDJHAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DBMBPDJHAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x67BCF20", Offset = "0x67BC320", VA = "0x1867BCF20")]
		internal object GPMPIJMMKKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x67BCF90", Offset = "0x67BC390", VA = "0x1867BCF90")]
		internal object JHLCAJCNCCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x67BCEB0", Offset = "0x67BC2B0", VA = "0x1867BCEB0")]
		internal object AEOPLFOOECP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct NFDBPJBOMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public NJFPAKEFBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private DBMBPDJHAGC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private LNPOCOFJDMD <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private OAHKKLBHOHO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(OAHKKLBHOHO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x67D08C0", Offset = "0x67CFCC0", VA = "0x1867D08C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x67D1170", Offset = "0x67D0570", VA = "0x1867D1170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private FAOBGMFPLCB HBEDOEBNKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private NOEOBKPFBPE LLGNFOBBADE;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x67D22F0", Offset = "0x67D16F0", VA = "0x1867D22F0", Slot = "5")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x67D26D0", Offset = "0x67D1AD0", VA = "0x1867D26D0", Slot = "4")]
	[AsyncStateMachine(typeof(LLIIICIIPFF))]
	private Task<OAHKKLBHOHO> NHDACCLJMJH(ELOCCADIICN CPBCMKCCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x67D23A0", Offset = "0x67D17A0", VA = "0x1867D23A0")]
	private bool IFBPOABBEFO(EEPIJJHADBF MMIJGFOKHGO, [Out] OAHKKLBHOHO FEADNEEPDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x67D2590", Offset = "0x67D1990", VA = "0x1867D2590")]
	[AsyncStateMachine(typeof(NFDBPJBOMLP))]
	private Task<OAHKKLBHOHO> JLPOOEMEGIN(ELOCCADIICN BDAAOBFBLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public NJFPAKEFBHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class ALPDNGIODDI : ADKCECMHKHB, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct NGHOLMIILGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<MAIDGDACGFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public ALPDNGIODDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<DAFHOICEHFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x67D11E0", Offset = "0x67D05E0", VA = "0x1867D11E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x67D1690", Offset = "0x67D0A90", VA = "0x1867D1690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class BCPGGGIANIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BCPGGGIANIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x67B7CC0", Offset = "0x67B70C0", VA = "0x1867B7CC0")]
		internal object AJKGBNDKONP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct HBKNBOFFMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<DAFHOICEHFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public ALPDNGIODDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public DHOCBLKANBD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private BCPGGGIANIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<DAFHOICEHFC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x67BFFF0", Offset = "0x67BF3F0", VA = "0x1867BFFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x67C05E0", Offset = "0x67BF9E0", VA = "0x1867C05E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class AEMGGOEHIGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public AEMGGOEHIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x14D8210", Offset = "0x14D7610", VA = "0x1814D8210")]
		internal bool KFOKNEGENNC(EFJPDNIEGLO sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private MOHOFPPIBJK JOPAOLEHJFG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (LOEJPFELMNK superRoomData, long subRoomDataSaveId) NHBFBPBHDLJ;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x67B74B0", Offset = "0x67B68B0", VA = "0x1867B74B0", Slot = "5")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x67B7350", Offset = "0x67B6750", VA = "0x1867B7350", Slot = "4")]
	[AsyncStateMachine(typeof(NGHOLMIILGL))]
	public Task<MAIDGDACGFA> DPNAPEHDNDM(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, DHOCBLKANBD AOBLKOJAFBL, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x67B7830", Offset = "0x67B6C30", VA = "0x1867B7830")]
	[AsyncStateMachine(typeof(HBKNBOFFMPM))]
	private Task<DAFHOICEHFC> NDMHOEAKDEF(DHOCBLKANBD AOBLKOJAFBL, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x67B7210", Offset = "0x67B6610", VA = "0x1867B7210")]
	private MAIDGDACGFA AKHGNKHDJMJ(DHOCBLKANBD AOBLKOJAFBL, DAFHOICEHFC MBNPDJACMNH, long MCHADGEKOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x67B7540", Offset = "0x67B6940", VA = "0x1867B7540")]
	private (LOEJPFELMNK, long) FMDCCCBJALB(DHOCBLKANBD AOBLKOJAFBL, DAFHOICEHFC MBNPDJACMNH, long MCHADGEKOOE)
	{
		return default((LOEJPFELMNK, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public ALPDNGIODDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class BHKFFDHJCBP : MHAGEMEKKFD, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class DBPHHKONIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DBPHHKONIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x67BD000", Offset = "0x67BC400", VA = "0x1867BD000")]
		internal object AGMBILOFFLH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct BGEDLHDIABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public BHKFFDHJCBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public BIMKIOLAEHO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x67B7F90", Offset = "0x67B7390", VA = "0x1867B7F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x67B85A0", Offset = "0x67B79A0", VA = "0x1867B85A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct KCKELKMHJLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public BHKFFDHJCBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public BIMKIOLAEHO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<CANEMJELEMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x67CB4B0", Offset = "0x67CA8B0", VA = "0x1867CB4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x67CBAB0", Offset = "0x67CAEB0", VA = "0x1867CBAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class COHJMCIEHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public COHJMCIEHFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x67BA860", Offset = "0x67B9C60", VA = "0x1867BA860")]
		internal object LKIBKNFGECI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct LJHHGKCIOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public ELOCCADIICN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public BHKFFDHJCBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public BIMKIOLAEHO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private COIAFENBOPJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private NMBLKNDLOCL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<CANEMJELEMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x67CD3E0", Offset = "0x67CC7E0", VA = "0x1867CD3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x67CDFD0", Offset = "0x67CD3D0", VA = "0x1867CDFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private EIGDPGKBIAC NEJFBLPGPBP;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private JDKDAIBAAAF ICFFCPHINCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x67B8D00", Offset = "0x67B8100", VA = "0x1867B8D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x67B8F20", Offset = "0x67B8320", VA = "0x1867B8F20", Slot = "8")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x67B8DC0", Offset = "0x67B81C0", VA = "0x1867B8DC0", Slot = "4")]
	[AsyncStateMachine(typeof(BGEDLHDIABO))]
	public Task<ELOCCADIICN> EMHLHDMDPIM(ELOCCADIICN BDAAOBFBLIB, BIMKIOLAEHO BELDBGPLNII, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x67B93F0", Offset = "0x67B87F0", VA = "0x1867B93F0", Slot = "5")]
	[AsyncStateMachine(typeof(KCKELKMHJLP))]
	public Task<ELOCCADIICN> OALPOEBHICP(CancellationToken KNKAEBKAEBM, BIMKIOLAEHO BELDBGPLNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x67B8FB0", Offset = "0x67B83B0", VA = "0x1867B8FB0", Slot = "6")]
	public IKKONDAGOHO INIBJFCHDDD(HKIJMCIKIMC DOEIBLLDHDB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x67B91C0", Offset = "0x67B85C0", VA = "0x1867B91C0", Slot = "7")]
	public IKKONDAGOHO LMOMKPGHIMM(HKIJMCIKIMC DOEIBLLDHDB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x67B8BA0", Offset = "0x67B7FA0", VA = "0x1867B8BA0")]
	[AsyncStateMachine(typeof(LJHHGKCIOLM))]
	private Task<ELOCCADIICN> DLKIIEDHIIO(ELOCCADIICN BDAAOBFBLIB, BIMKIOLAEHO BELDBGPLNII, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x282EA00", Offset = "0x282DE00", VA = "0x18282EA00")]
	private static byte[] NHLGMHOMEDD(ELOCCADIICN JEBCFBFPEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BHKFFDHJCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class BNAHMCMHGKF : FAOBGMFPLCB, KNMNJBFGHDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private ODAAIDPHJOD BLAPEECPJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private EKMIMGLAEBJ HEOMPBLFEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private CINMBNEIKFH NBBAFHLGBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private GNHCHIOFANA GLLEIFJDLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private OPBJHLIBNLE FDKNEPDHPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private DCMBPKDFJJA GLPHPNDFKED;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x67B99B0", Offset = "0x67B8DB0", VA = "0x1867B99B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private static OAHKKLBHOHO NGBCFCFLOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x67B9B70", Offset = "0x67B8F70", VA = "0x1867B9B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x67B9A00", Offset = "0x67B8E00", VA = "0x1867B9A00", Slot = "6")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x67B9540", Offset = "0x67B8940", VA = "0x1867B9540", Slot = "4")]
	public OAHKKLBHOHO BDICADKHPPD(MKFCBDEMMMH IOPMPBPKFOL, EEPIJJHADBF PGJAEKOINFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x67B96B0", Offset = "0x67B8AB0", VA = "0x1867B96B0", Slot = "5")]
	public OAHKKLBHOHO BJGGJNFCLHH(MKFCBDEMMMH NEIABIHHBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x67B9BD0", Offset = "0x67B8FD0", VA = "0x1867B9BD0")]
	private static OAHKKLBHOHO MCBEBFAMFJK(DCLBCJCFNBK HOKIEGJILGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BNAHMCMHGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class EEBPAGCHAFA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x67BEE10", Offset = "0x67BE210", VA = "0x1867BEE10")]
	public EEBPAGCHAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5D489B0", Offset = "0x5D47DB0", VA = "0x185D489B0")]
	public EEBPAGCHAFA(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class OKBKDJFNAPF : JAMAFABDHEE, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct DJKKGNCKENF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public OKBKDJFNAPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AFFLFHNACKH autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private OHKLINEMLLN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private OHKLINEMLLN<string>.IECBLACBOCC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private KLBABJLJKCA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<OAHKKLBHOHO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x67BD3D0", Offset = "0x67BC7D0", VA = "0x1867BD3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x67BDF60", Offset = "0x67BD360", VA = "0x1867BDF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct HKJFDKGJJIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public OKBKDJFNAPF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67C20C0", Offset = "0x67C14C0", VA = "0x1867C20C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x67C2810", Offset = "0x67C1C10", VA = "0x1867C2810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct NHFFIANMBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public OKBKDJFNAPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x67D1700", Offset = "0x67D0B00", VA = "0x1867D1700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x67D1C10", Offset = "0x67D1010", VA = "0x1867D1C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct DAGPDKKLBBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public OKBKDJFNAPF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67BB570", Offset = "0x67BA970", VA = "0x1867BB570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x67BBCC0", Offset = "0x67BB0C0", VA = "0x1867BBCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct OAIEBKFNHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public OKBKDJFNAPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x67D2CC0", Offset = "0x67D20C0", VA = "0x1867D2CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x67D2E60", Offset = "0x67D2260", VA = "0x1867D2E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MOEALBIEBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public OKBKDJFNAPF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67CFBC0", Offset = "0x67CEFC0", VA = "0x1867CFBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x67D02E0", Offset = "0x67CF6E0", VA = "0x1867D02E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NMBOHNFKLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public OKBKDJFNAPF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67D27F0", Offset = "0x67D1BF0", VA = "0x1867D27F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x67D2C60", Offset = "0x67D2060", VA = "0x1867D2C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct JKEMJFHANID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public OKBKDJFNAPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public PKLFHHDPKAE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private OHKLINEMLLN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x67CA1A0", Offset = "0x67C95A0", VA = "0x1867CA1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x67CA6E0", Offset = "0x67C9AE0", VA = "0x1867CA6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private EBJMBPHPLIM HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private MHAGEMEKKFD CFMFPPMJCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EKMIMGLAEBJ HEOMPBLFEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private OPBJHLIBNLE FDKNEPDHPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource POEMIIBJGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task PGAPBFLJINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> FKGANHLBGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int GAKOBDFOGFI;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x67D49E0", Offset = "0x67D3DE0", VA = "0x1867D49E0", Slot = "6")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x913330", Offset = "0x912730", VA = "0x180913330", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x67D4EC0", Offset = "0x67D42C0", VA = "0x1867D4EC0")]
	private void FNIMPPHKHAM(float MCJFFFFAMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x67D4B90", Offset = "0x67D3F90", VA = "0x1867D4B90", Slot = "4")]
	[AsyncStateMachine(typeof(DJKKGNCKENF))]
	public Task<OAHKKLBHOHO> FAECMIOILAE(AFFLFHNACKH DONGLMJPIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x67D50A0", Offset = "0x67D44A0", VA = "0x1867D50A0", Slot = "5")]
	[AsyncStateMachine(typeof(HKJFDKGJJIP))]
	public Task JPDKGIFCIEI([Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x913330", Offset = "0x912730", VA = "0x180913330")]
	public void EEMMBAGNHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x67D52A0", Offset = "0x67D46A0", VA = "0x1867D52A0")]
	private KLBABJLJKCA PJBMFACEFAF(AFFLFHNACKH DONGLMJPIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x67D48F0", Offset = "0x67D3CF0", VA = "0x1867D48F0")]
	[AsyncStateMachine(typeof(NHFFIANMBNE))]
	private Task EHEPLGLJKMA(FCICHBFPKKL OBMKPHNOIOK, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x67D4FA0", Offset = "0x67D43A0", VA = "0x1867D4FA0")]
	[AsyncStateMachine(typeof(DAGPDKKLBBD))]
	private Task JLBFEBCKHCA(CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x67D4CC0", Offset = "0x67D40C0", VA = "0x1867D4CC0")]
	[AsyncStateMachine(typeof(OAIEBKFNHLI))]
	private Task FBDFDKGFHCH([Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x67D4800", Offset = "0x67D3C00", VA = "0x1867D4800")]
	[AsyncStateMachine(typeof(MOEALBIEBBC))]
	private Task CLBIFDJENGO(CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x67D4470", Offset = "0x67D3870", VA = "0x1867D4470")]
	[AsyncStateMachine(typeof(NMBOHNFKLHG))]
	private Task ANFCGHBOKKK(CancellationToken HHEICFDPDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x67D4570", Offset = "0x67D3970", VA = "0x1867D4570")]
	private Task CILLFMFPGGD(PKLFHHDPKAE NBONEADNIAK, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x67D5190", Offset = "0x67D4590", VA = "0x1867D5190")]
	[AsyncStateMachine(typeof(JKEMJFHANID))]
	private Task LGBDEPLPEID(PKLFHHDPKAE NBONEADNIAK, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x67D4DB0", Offset = "0x67D41B0", VA = "0x1867D4DB0")]
	private bool FMNPEKIJKDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public OKBKDJFNAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class MOOGCEFKLFB : CINMBNEIKFH, KNMNJBFGHDK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct JEICPCFMJFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public MOOGCEFKLFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private OHKLINEMLLN<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x67C8D70", Offset = "0x67C8170", VA = "0x1867C8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x67C92D0", Offset = "0x67C86D0", VA = "0x1867C92D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private MJJHMPIDDJJ APFAAMAKOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private FAOBGMFPLCB HBEDOEBNKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private MHAGEMEKKFD CFMFPPMJCCN;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x67D0390", Offset = "0x67CF790", VA = "0x1867D0390", Slot = "6")]
	public void EOPEJCOCBHD(HDAJFOAIBMP DPKDAIDNMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x67D0340", Offset = "0x67CF740", VA = "0x1867D0340", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x67D06D0", Offset = "0x67CFAD0", VA = "0x1867D06D0", Slot = "5")]
	[AsyncStateMachine(typeof(JEICPCFMJFF))]
	public Task GECFAICIDPJ(string GBHBCPBCKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x67D0670", Offset = "0x67CFA70", VA = "0x1867D0670", Slot = "4")]
	public OAHKKLBHOHO FMNPEKIJKDD(MKFCBDEMMMH IOPMPBPKFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x67D07D0", Offset = "0x67CFBD0", VA = "0x1867D07D0")]
	private GIPNANOPPEB KLELBJADJBA(string GBHBCPBCKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public MOOGCEFKLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class EOIMHBABGLO
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x67BF960", Offset = "0x67BED60", VA = "0x1867BF960")]
	public static void PLHNBJOHPPF(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x67BF3B0", Offset = "0x67BE7B0", VA = "0x1867BF3B0")]
	internal static void KJNDBFGOAPC(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x67BF2D0", Offset = "0x67BE6D0", VA = "0x1867BF2D0")]
	internal static void ENKLBHGBGJM(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x67BF510", Offset = "0x67BE910", VA = "0x1867BF510")]
	internal static void PEEEMANKFEG(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class LJKPKMACPDL : ALLLLJPBEEG<ELOCCADIICN>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class KJBKBNOBDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public ELOCCADIICN message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KJBKBNOBDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x67CBFD0", Offset = "0x67CB3D0", VA = "0x1867CBFD0")]
		internal object ACFNLHNHIEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly LJKPKMACPDL GDCHCCJBKDM;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x67CE3A0", Offset = "0x67CD7A0", VA = "0x1867CE3A0")]
	public ExitGames.Client.Photon.Hashtable HBIMCCJEPGN(ELOCCADIICN JEBCFBFPEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x67CE040", Offset = "0x67CD440", VA = "0x1867CE040", Slot = "5")]
	protected override void BAFCEFAGPGB(ELOCCADIICN JEBCFBFPEMG, IDictionary<object, object> FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x67CE170", Offset = "0x67CD570", VA = "0x1867CE170", Slot = "6")]
	public override ELOCCADIICN CMCHCKHHIFC(IDictionary<object, object> FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x67CE6D0", Offset = "0x67CDAD0", VA = "0x1867CE6D0")]
	private static void OMAIFAPDBID(string IAIHIOAMBHE, ELOCCADIICN JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x67CE880", Offset = "0x67CDC80", VA = "0x1867CE880")]
	public LJKPKMACPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x67CE430", Offset = "0x67CD830", VA = "0x1867CE430")]
	[CompilerGenerated]
	internal static string MPNHALGHOBP(MAIDGDACGFA KJOCNIDJGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class ELGIMOHOOJK
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public static OAHKKLBHOHO NGBCFCFLOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x67B9B70", Offset = "0x67B8F70", VA = "0x1867B9B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x67BF0B0", Offset = "0x67BE4B0", VA = "0x1867BF0B0")]
	public static bool JHCFJDAOEHM(this OAHKKLBHOHO GEFKDGHDAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x67B9BD0", Offset = "0x67B8FD0", VA = "0x1867B9BD0")]
	public static OAHKKLBHOHO MCBEBFAMFJK(DCLBCJCFNBK LNDLANKAKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x67BF0D0", Offset = "0x67BE4D0", VA = "0x1867BF0D0")]
	public static OAHKKLBHOHO OIAFNLJHJKG(IEnumerable<OAHKKLBHOHO> IPIFACINNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x67BEE50", Offset = "0x67BE250", VA = "0x1867BEE50")]
	public static string DPMAAMGHPHJ(this OAHKKLBHOHO FEADNEEPDLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class JPAMBLLCIEL : EEIFGCIDCKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate OAHKKLBHOHO IJDEEGDIDGA([NotNull] MKFCBDEMMMH HKDDJMNGJHO);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class LOGOPJMJIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public MKFCBDEMMMH photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LOGOPJMJIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F5D0", Offset = "0x5F2E9D0", VA = "0x185F2F5D0")]
		internal OAHKKLBHOHO BOIDDBENFOB(IJDEEGDIDGA v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	protected readonly HashSet<IJDEEGDIDGA> NELJBNDDOIG;

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x67CB300", Offset = "0x67CA700", VA = "0x1867CB300", Slot = "4")]
	public void GLBLNJAJIBF(IJDEEGDIDGA OPOGOKKGFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x67CB250", Offset = "0x67CA650", VA = "0x1867CB250", Slot = "5")]
	public void BNCLALOKIEN(IJDEEGDIDGA OPOGOKKGFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x67CB2B0", Offset = "0x67CA6B0", VA = "0x1867CB2B0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x67CAFB0", Offset = "0x67CA3B0", VA = "0x1867CAFB0")]
	protected OAHKKLBHOHO AAOLCNAPHHA(MKFCBDEMMMH NEIABIHHBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x67CB360", Offset = "0x67CA760", VA = "0x1867CB360")]
	protected JPAMBLLCIEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class GAMFBAJOKIA : JPAMBLLCIEL, ODAAIDPHJOD, EEIFGCIDCKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class PGDGNGFFHDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public OAHKKLBHOHO result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PGDGNGFFHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x67D5A70", Offset = "0x67D4E70", VA = "0x1867D5A70")]
		internal object PNGPCKJFPFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x67B7CB0", Offset = "0x67B70B0", VA = "0x1867B7CB0")]
	[UnityEngine.Scripting.Preserve]
	public GAMFBAJOKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x67BFBA0", Offset = "0x67BEFA0", VA = "0x1867BFBA0", Slot = "8")]
	public OAHKKLBHOHO GHODEKKHGAK(MKFCBDEMMMH NEIABIHHBBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class BBPCPFJLMOG : JPAMBLLCIEL, MJJHMPIDDJJ, EEIFGCIDCKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class ILBGCAEOOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public OAHKKLBHOHO result;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ILBGCAEOOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x67C8860", Offset = "0x67C7C60", VA = "0x1867C8860")]
		internal object PMAOPOAHNBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x67B7CB0", Offset = "0x67B70B0", VA = "0x1867B7CB0")]
	[UnityEngine.Scripting.Preserve]
	public BBPCPFJLMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x67B7BA0", Offset = "0x67B6FA0", VA = "0x1867B7BA0", Slot = "8")]
	public OAHKKLBHOHO FMNPEKIJKDD(MKFCBDEMMMH PFIBGBIOJOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class GIPJDLGDINA
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class PDPCGFANNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public OHKLINEMLLN<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PDPCGFANNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x67D59F0", Offset = "0x67D4DF0", VA = "0x1867D59F0")]
		internal object PODDHKJFNPA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x67BFEB0", Offset = "0x67BF2B0", VA = "0x1867BFEB0")]
	public static OHKLINEMLLN<string> LBMAKDKKBHN(GFLOJPOFOAD DFBIKANGICJ, [Optional] string KOBBILELCIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x67BFD30", Offset = "0x67BF130", VA = "0x1867BFD30")]
	public static void BDNNAPDCOBO(OHKLINEMLLN<string> CBCAJLKKHCH, GFLOJPOFOAD DFBIKANGICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x67BFDF0", Offset = "0x67BF1F0", VA = "0x1867BFDF0")]
	public static string DCGJEPEJCCO(ELOCCADIICN CPBCMKCCHDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class BAHKBDBJJAP
{
	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x67B7A60", Offset = "0x67B6E60", VA = "0x1867B7A60")]
	public static void FJFGCINKANO(this EBJMBPHPLIM HFIBHDFMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x67B7B90", Offset = "0x67B6F90", VA = "0x1867B7B90")]
	public static void MKAEMDOJJBE(this EBJMBPHPLIM HFIBHDFMJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x67B7A70", Offset = "0x67B6E70", VA = "0x1867B7A70")]
	private static void HKMACKBOJAP(this EBJMBPHPLIM HFIBHDFMJDD, bool JDJKKKOBPPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class OMFBBOBKGME : NOAEFICHGNF, NAHCCHAGEKA, MIDKGLAMACK, DBJJBGLBHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly NAHCCHAGEKA COOKNBDGGFB;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MKFCBDEMMMH FMIBLLPPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x67D5540", Offset = "0x67D4940", VA = "0x1867D5540", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int PIOLMEPBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x67D5630", Offset = "0x67D4A30", VA = "0x1867D5630", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int NOMLHLNGGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x67D54F0", Offset = "0x67D48F0", VA = "0x1867D54F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool HJDGMNKJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int AKIPPAKADKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NMKDINPJMFI.LHEOJDCMAFI DGMMFJJFLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LINFFCIIKOO GPLGOONPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x67D5750", Offset = "0x67D4B50", VA = "0x1867D5750", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x67D5840", Offset = "0x67D4C40", VA = "0x1867D5840", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> CGGPMLDOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<MKFCBDEMMMH> EDJJIGKHNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action PLLHMPLJGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x67D5590", Offset = "0x67D4990", VA = "0x1867D5590", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x67D58E0", Offset = "0x67D4CE0", VA = "0x1867D58E0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xD64A80", Offset = "0xD63E80", VA = "0x180D64A80")]
	public OMFBBOBKGME(NAHCCHAGEKA COOKNBDGGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x67D5680", Offset = "0x67D4A80", VA = "0x1867D5680", Slot = "8")]
	public bool FMAAIOJGADE(byte AOKJGDOHJKF, ExitGames.Client.Photon.Hashtable PEIJDDPODFJ, KHPGHDNGJCL FKNBJDFLNEI, SendOptions DALOOFKKEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x67D5410", Offset = "0x67D4810", VA = "0x1867D5410", Slot = "16")]
	public MKFCBDEMMMH BAFILHMCLPP(int OLDNHJFKKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "19")]
	public void PCPJPKMDLNJ(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "20")]
	public void DKEADAGLCJJ(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "21")]
	public void HNGPABAPNMC(object ICNJFMMNIKL, bool HFFHJCKPPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x67D57F0", Offset = "0x67D4BF0", VA = "0x1867D57F0", Slot = "22")]
	public IDisposable IJNECMPKKGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "23")]
	private bool JPJFCAPPMGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "24")]
	public void MAHKKGEIHIJ(StringBuilder ABCGDFCFHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x67D5730", Offset = "0x67D4B30", VA = "0x1867D5730", Slot = "25")]
	public bool GLINPBEBBGC(bool HOGCCGJJHID, [Out] string NBDBHDLNPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8343C0", Offset = "0x8337C0", VA = "0x1808343C0", Slot = "28")]
	public void PCMIMBCNALA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct KHKCGIAJJMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly IDictionary<object, object> LMBNCDMECGI;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	public KHKCGIAJJMM(IDictionary<object, object> LMBNCDMECGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x67CBC40", Offset = "0x67CB040", VA = "0x1867CBC40")]
	public bool DMGEMICMDFC([Out] ELOCCADIICN JEBCFBFPEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x67CBF20", Offset = "0x67CB320", VA = "0x1867CBF20")]
	public Guid MIDJKPKGICH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x67CBDE0", Offset = "0x67CB1E0", VA = "0x1867CBDE0")]
	public OAHKKLBHOHO JBBBPNFPBIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x67CBCF0", Offset = "0x67CB0F0", VA = "0x1867CBCF0")]
	public static ExitGames.Client.Photon.Hashtable HEJOOLMEDMH(ELOCCADIICN JEBCFBFPEMG, OAHKKLBHOHO GEFKDGHDAKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class BENIDKHBCAP
{
	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x67B7D70", Offset = "0x67B7170", VA = "0x1867B7D70")]
	public static bool GNKAEGFNGJJ(this DHOCBLKANBD MJFKEABMNNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct OCGHBLOGJFN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct PNGIPOCHNBJ : IAsyncStateMachine
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
		public OCGHBLOGJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x67D5AD0", Offset = "0x67D4ED0", VA = "0x1867D5AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x67D5CB0", Offset = "0x67D50B0", VA = "0x1867D5CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly CancellationTokenSource MCEEHGKCGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private bool HFCDDCNLIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private Task JKFKBCIOAGB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool JOKPAMMGCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x67D3020", Offset = "0x67D2420", VA = "0x1867D3020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x67D3050", Offset = "0x67D2450", VA = "0x1867D3050")]
	public OCGHBLOGJFN(CancellationToken KNKAEBKAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x67D2F10", Offset = "0x67D2310", VA = "0x1867D2F10")]
	[AsyncStateMachine(typeof(PNGIPOCHNBJ))]
	public Task FMCEPGAGCPI(Func<CancellationToken, List<Task>> DJNGPLLMEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x67D2EC0", Offset = "0x67D22C0", VA = "0x1867D2EC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct FBBOFFFNJKG<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct LDFPFJCHJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<CAFJOBNFGAD<TData>, FEBGENKADMF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public FBBOFFFNJKG<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<OJIJNKCPBAD<CAFJOBNFGAD<TData>, FEBGENKADMF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FB40", Offset = "0x3D0EF40", VA = "0x183D0FB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x3848380", Offset = "0x3847780", VA = "0x183848380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly LGPIMCFBECM<TGetDataArg, TData> ECGBFCNDIAL;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	internal FBBOFFFNJKG(LGPIMCFBECM<TGetDataArg, TData> IGMHAFBOHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x36AD340", Offset = "0x36AC740", VA = "0x1836AD340")]
	[AsyncStateMachine(typeof(FBBOFFFNJKG<, >.LDFPFJCHJGC))]
	public Task<OJIJNKCPBAD<CAFJOBNFGAD<TData>, FEBGENKADMF>> IDIPIHONLAK(TGetDataArg PBBNOGAMKJE, string EBLPFIMBBPN, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class BFKIGLBPIJL
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x24AB940", Offset = "0x24AAD40", VA = "0x1824AB940")]
	public static FBBOFFFNJKG<TGetDataArg, TData> HGJFOBLHCKL<TGetDataArg, TData>(LGPIMCFBECM<TGetDataArg, TData> IGMHAFBOHAM)
	{
		return default(FBBOFFFNJKG<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct MHLADHKBCOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int BKEJABFGBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int? LPBNNFMKJBC;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3CFCE40", Offset = "0x3CFC240", VA = "0x183CFCE40")]
	public MHLADHKBCOD(int ILHEFLOIBFO, [Optional] int? LOBDFNNMECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x67CF670", Offset = "0x67CEA70", VA = "0x1867CF670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface OGBOOBPNIEG<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPJLPAJCBEO();

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OGBOOBPNIEG<T> OKPBMMFFBFD(string MPNKHGPLHND);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OGBOOBPNIEG<T> MENBMHLEHIE(FPGKCJKMBPE<T> FALDDIOMNPE);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OGBOOBPNIEG<T> BAKHBKENAHM(int MNEGDIGLFLH);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGBOOBPNIEG<T> LFIMPFFGKCF(int MNEGDIGLFLH, PKPDFKGPGMC<T> HFKGOPIIDCK);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface IJHGMFGBKAE
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGBOOBPNIEG<T> GHOIIALICPN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KAFOHOPKNMJ ECGDEGDJENH(Exception DAAIKNOAPFE);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHLADHKBCOD KBPFHBANCCC(Exception DAAIKNOAPFE);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string FPGKCJKMBPE<in T>(T DAAIKNOAPFE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int PKPDFKGPGMC<in T>(T DAAIKNOAPFE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class IFOBNAONNHP : IJHGMFGBKAE
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string GDCDADDIKKB(Exception DAAIKNOAPFE);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int OJADFOILKNJ(Exception DAAIKNOAPFE);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class CALAKAKDLLO<T> : OGBOOBPNIEG<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class BGHPEHMBEPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public BGHPEHMBEPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			internal string LFMLFIEFHIO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class INJNKFEAOPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public FPGKCJKMBPE<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public INJNKFEAOPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x39C38B0", Offset = "0x39C2CB0", VA = "0x1839C38B0")]
			internal string AKNNGIKPELL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class JHPDGMHHMIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public PKPDFKGPGMC<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public JHPDGMHHMIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x39C38B0", Offset = "0x39C2CB0", VA = "0x1839C38B0")]
			internal int DMLOJINAGFD(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly IFOBNAONNHP ICAIDOIOJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly Type EGJDBHCOCIK;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x49FA300", Offset = "0x49F9700", VA = "0x1849FA300")]
		internal CALAKAKDLLO(IFOBNAONNHP ICAIDOIOJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x49FA0B0", Offset = "0x49F94B0", VA = "0x1849FA0B0", Slot = "4")]
		public void LPJLPAJCBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x49FA1F0", Offset = "0x49F95F0", VA = "0x1849FA1F0", Slot = "5")]
		public OGBOOBPNIEG<T> OKPBMMFFBFD(string MPNKHGPLHND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x49FA0E0", Offset = "0x49F94E0", VA = "0x1849FA0E0", Slot = "6")]
		public OGBOOBPNIEG<T> MENBMHLEHIE(FPGKCJKMBPE<T> FALDDIOMNPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x49F9F50", Offset = "0x49F9350", VA = "0x1849F9F50", Slot = "7")]
		public OGBOOBPNIEG<T> BAKHBKENAHM(int MNEGDIGLFLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x49F9F90", Offset = "0x49F9390", VA = "0x1849F9F90", Slot = "8")]
		public OGBOOBPNIEG<T> LFIMPFFGKCF(int MNEGDIGLFLH, PKPDFKGPGMC<T> HFKGOPIIDCK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class LLDIGBLHCCN<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private bool AIDLGFDMAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly List<Type> ONAEIEMEJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, TVal> GCKEABHOMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, int> AJBOALGNBHN;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<Type> ONOKHCGCMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x3D23B30", Offset = "0x3D22F30", VA = "0x183D23B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3D24100", Offset = "0x3D23500", VA = "0x183D24100")]
		public LLDIGBLHCCN(Dictionary<Type, int> AJBOALGNBHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3D23D90", Offset = "0x3D23190", VA = "0x183D23D90")]
		public void FFIECPFJEFG(Type NIOPCMHKLMB, TVal FNMPHGMIIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3D23F70", Offset = "0x3D23370", VA = "0x183D23F70")]
		public bool MFGNGLANLJO(Type EGJDBHCOCIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3D23FB0", Offset = "0x3D233B0", VA = "0x183D23FB0")]
		public bool MFIKBOJGPMD(TVal PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3D23CB0", Offset = "0x3D230B0", VA = "0x183D23CB0")]
		public TVal EBLDKANKNCA(Type NBMJAHOKHAI)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3D23E30", Offset = "0x3D23230", VA = "0x183D23E30")]
		[CompilerGenerated]
		private int GMGDJILAKHB(Type LAOBGMKDNFG, Type INGFLJPIEAA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class JKNILOLKANG : IEnumerable<MHLADHKBCOD>, IEnumerable, IEnumerator<MHLADHKBCOD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private MHLADHKBCOD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public IFOBNAONNHP <>4__this;

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
		private IEnumerator<MHLADHKBCOD> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		private MHLADHKBCOD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x33CD7C0", Offset = "0x33CCBC0", VA = "0x1833CD7C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MHLADHKBCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x67CADA0", Offset = "0x67CA1A0", VA = "0x1867CADA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x818520", Offset = "0x817920", VA = "0x180818520")]
		[DebuggerHidden]
		public JKNILOLKANG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x67CADF0", Offset = "0x67CA1F0", VA = "0x1867CADF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x67CA790", Offset = "0x67C9B90", VA = "0x1867CA790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x67CA740", Offset = "0x67C9B40", VA = "0x1867CA740")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x67CAC40", Offset = "0x67CA040", VA = "0x1867CAC40")]
		private void ODFILHFIFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x67CAD50", Offset = "0x67CA150", VA = "0x1867CAD50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x67CAC90", Offset = "0x67CA090", VA = "0x1867CAC90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MHLADHKBCOD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x67CAC90", Offset = "0x67CA090", VA = "0x1867CAC90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly MHLADHKBCOD JNIFBBHCNEJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly Dictionary<Type, int> JOOEPAOKEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly HashSet<Type> KHAPAJMDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly LLDIGBLHCCN<int> FEJFMHLKNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly LLDIGBLHCCN<OJADFOILKNJ> GKPCPAFMOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly LLDIGBLHCCN<GDCDADDIKKB> BLOGEAPNNAM;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x67C6C90", Offset = "0x67C6090", VA = "0x1867C6C90")]
	[AMCIKKJLCIB(HENHDGEOMOC.GameOnly)]
	private static void IEDLFPKPNAO(BNDLKDEPBDF PLABOMGPCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x67C7220", Offset = "0x67C6620", VA = "0x1867C7220")]
	[RecRoom.NoEngine.Common.Preserve]
	public IFOBNAONNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2623F10", Offset = "0x2623310", VA = "0x182623F10", Slot = "4")]
	public OGBOOBPNIEG<T> GHOIIALICPN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x67C6210", Offset = "0x67C5610", VA = "0x1867C6210", Slot = "5")]
	public KAFOHOPKNMJ ECGDEGDJENH(Exception DAAIKNOAPFE)
	{
		return default(KAFOHOPKNMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x67C6F50", Offset = "0x67C6350", VA = "0x1867C6F50", Slot = "6")]
	public MHLADHKBCOD KBPFHBANCCC(Exception? DAAIKNOAPFE)
	{
		return default(MHLADHKBCOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x67C6420", Offset = "0x67C5820", VA = "0x1867C6420", Slot = "7")]
	[IteratorStateMachine(typeof(JKNILOLKANG))]
	public IEnumerable<MHLADHKBCOD> HBNIAHJOHKL(Exception DAAIKNOAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x67C64C0", Offset = "0x67C58C0", VA = "0x1867C64C0", Slot = "8")]
	public string HCKPFLGCFMA(Exception? DAAIKNOAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x67C5F00", Offset = "0x67C5300", VA = "0x1867C5F00")]
	private string BNKDFGNGGIP(AggregateException CHLCPEMLNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x67C6610", Offset = "0x67C5A10", VA = "0x1867C6610")]
	private void HCPHDGPMDLL(Type EGJDBHCOCIK, int MNEGDIGLFLH, OJADFOILKNJ? EHKJCMLLJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x67C6D00", Offset = "0x67C6100", VA = "0x1867C6D00")]
	private void IIKENNOLIDG(Type EGJDBHCOCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x67C69C0", Offset = "0x67C5DC0", VA = "0x1867C69C0")]
	private void HOBHDHAIGLE(Type EGJDBHCOCIK, GDCDADDIKKB NLEIIOMMIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x67C62A0", Offset = "0x67C56A0", VA = "0x1867C62A0")]
	private static int FIIKHGLCBOH(Type EGJDBHCOCIK, Dictionary<Type, int> AJBOALGNBHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x282A470", Offset = "0x2829870", VA = "0x18282A470")]
	private static bool DIAHPCAEJAM<TVal>(LLDIGBLHCCN<TVal> JFCBPFNIMNJ, Type EGJDBHCOCIK, [Out] TVal PCGOHCLJAPN) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x67C5E20", Offset = "0x67C5220", VA = "0x1867C5E20")]
	[CompilerGenerated]
	internal static int AOPLLLIDPNK(Type IOMELDLBLEE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct KAFOHOPKNMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly MHLADHKBCOD NHCGBADOIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly string APKPBJIDFPE;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x67CB490", Offset = "0x67CA890", VA = "0x1867CB490")]
	public KAFOHOPKNMJ(string BJPKEHLAMFC, MHLADHKBCOD MNEGDIGLFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x67CB3F0", Offset = "0x67CA7F0", VA = "0x1867CB3F0")]
	public string GFFJGEKBAOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class JFOMGCGOIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private readonly CBMBIENNKDO DGFELBBMCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private string PJEFEJMLMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? ICIFIJNOCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? DIJJHIILPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? IEPJKJCCIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private string MFEALIDPGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private AEJGAEICAEA AMCGHCHBOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private long? CFAFMFGOEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private bool CANFNFCKBBA;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string JMPNGOHLMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public long PBNKAPDNGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x67C9330", Offset = "0x67C8730", VA = "0x1867C9330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long GHDOOCJMPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x67C9900", Offset = "0x67C8D00", VA = "0x1867C9900")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long CAFHPCNDEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x67C9800", Offset = "0x67C8C00", VA = "0x1867C9800")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string PCDCPCEIECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x67C98C0", Offset = "0x67C8CC0", VA = "0x1867C98C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AEJGAEICAEA LOJDBPEADBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xDB7D70", Offset = "0xDB7170", VA = "0x180DB7D70")]
		get
		{
			return default(AEJGAEICAEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x67C9390", Offset = "0x67C8790", VA = "0x1867C9390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public long NOIMJOAALAC
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x67C9860", Offset = "0x67C8C60", VA = "0x1867C9860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x67CA160", Offset = "0x67C9560", VA = "0x1867CA160")]
	[UnityEngine.Scripting.Preserve]
	public JFOMGCGOIAJ([AKGMOFMFNCG(null)] CBMBIENNKDO DGFELBBMCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x67C9A00", Offset = "0x67C8E00", VA = "0x1867C9A00")]
	private void NAPEMEMEJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x67C9C50", Offset = "0x67C9050", VA = "0x1867C9C50")]
	public void PHODNANBOAH(long NIJFNKBIOIC, long MCHADGEKOOE, [Optional] long? LEGFKICMEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x67C9960", Offset = "0x67C8D60", VA = "0x1867C9960")]
	public void MAJLFIDCKBL(long LEGFKICMEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x67CA0E0", Offset = "0x67C94E0", VA = "0x1867CA0E0")]
	public void PMBGFCLKIKH(string OFCHOOMFGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x67C9480", Offset = "0x67C8880", VA = "0x1867C9480")]
	public void CGPPMKFACJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class IKKONDAGOHO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct HGPFOIMNPCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public ELOCCADIICN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public IKKONDAGOHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<JDKDAIBAAAF.KJEBHGKMKJA<ELOCCADIICN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x67C1A00", Offset = "0x67C0E00", VA = "0x1867C1A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x67C1F30", Offset = "0x67C1330", VA = "0x1867C1F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct GOJLKDHJAEA<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class DCEHOOKOLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public ELOCCADIICN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DCEHOOKOLLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x67BD060", Offset = "0x67BC460", VA = "0x1867BD060")]
		internal ELOCCADIICN HPDKHPDKMLG(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct NIEJMKDPBFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public AsyncTaskMethodBuilder<JDKDAIBAAAF.KJEBHGKMKJA<ELOCCADIICN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public ELOCCADIICN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public IKKONDAGOHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private COIAFENBOPJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TaskAwaiter<JDKDAIBAAAF.KJEBHGKMKJA<ELOCCADIICN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x67D1C70", Offset = "0x67D1070", VA = "0x1867D1C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x67D2280", Offset = "0x67D1680", VA = "0x1867D2280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct MOLGANKIMOB<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public IKKONDAGOHO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3F2FCA0", Offset = "0x3F2F0A0", VA = "0x183F2FCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x33143B0", Offset = "0x33137B0", VA = "0x1833143B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct DMLEDPHGAFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public IKKONDAGOHO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67BE7D0", Offset = "0x67BDBD0", VA = "0x1867BE7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x67BE990", Offset = "0x67BDD90", VA = "0x1867BE990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class KFMEDPINGAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KFMEDPINGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x67CBBE0", Offset = "0x67CAFE0", VA = "0x1867CBBE0")]
		internal object GBILDDEEHOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x67CBB20", Offset = "0x67CAF20", VA = "0x1867CBB20")]
		internal bool DLCHGMCIDKM(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class KOPNHIIBIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KOPNHIIBIPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x67CD310", Offset = "0x67CC710", VA = "0x1867CD310")]
		internal object PIIKCEFCOII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class ACMIHCIALOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ACMIHCIALOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x67B7140", Offset = "0x67B6540", VA = "0x1867B7140")]
		internal object ILCGIFFJMPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class JKOCBHKANBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public JKOCBHKANBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x67CAF40", Offset = "0x67CA340", VA = "0x1867CAF40")]
		internal object FPEBJNLCNGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class OFIAPKLBCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public IKKONDAGOHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OFIAPKLBCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x67D31E0", Offset = "0x67D25E0", VA = "0x1867D31E0")]
		internal object ACFNLHNHIEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly Guid KGJHLBMHGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly HKIJMCIKIMC ABHNHNABGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly JDKDAIBAAAF LFGPOHIKCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly MIDKGLAMACK HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly DBJJBGLBHHI LPCLGMHMAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private bool BOIFKALGJEF;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x67C8630", Offset = "0x67C7A30", VA = "0x1867C8630")]
	public IKKONDAGOHO(HKIJMCIKIMC HOPLFLJKCIJ, JDKDAIBAAAF LFGPOHIKCKD, MIDKGLAMACK HFIBHDFMJDD, DBJJBGLBHHI LPCLGMHMAOM, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x67C7AE0", Offset = "0x67C6EE0", VA = "0x1867C7AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x67C7AE0", Offset = "0x67C6EE0", VA = "0x1867C7AE0")]
	public void PHJKCKEDNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x67C7A20", Offset = "0x67C6E20", VA = "0x1867C7A20")]
	public void DIMFAHJJHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x67C7C50", Offset = "0x67C7050", VA = "0x1867C7C50")]
	public void GGHHLCKOAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x67C7D10", Offset = "0x67C7110", VA = "0x1867C7D10")]
	[AsyncStateMachine(typeof(HGPFOIMNPCP))]
	internal Task<ELOCCADIICN> ILAOONKPHJL(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, ELOCCADIICN CPBCMKCCHDB, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x282EA00", Offset = "0x282DE00", VA = "0x18282EA00")]
	private static byte[] EDDIIEIMMLI<T>(T JEBCFBFPEMG) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x282ECC0", Offset = "0x282E0C0", VA = "0x18282ECC0")]
	private static T LPOBKDOCNJA<T>(MessageParser<T> GPNFNEOPNAF, byte[] JEBCFBFPEMG, T DDFBBJMHKLL) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x67C78E0", Offset = "0x67C6CE0", VA = "0x1867C78E0")]
	[AsyncStateMachine(typeof(NIEJMKDPBFO))]
	private Task<JDKDAIBAAAF.KJEBHGKMKJA<ELOCCADIICN>> DIBKNOIFNKP(ELOCCADIICN CPBCMKCCHDB, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x282EF00", Offset = "0x282E300", VA = "0x18282EF00")]
	[AsyncStateMachine(typeof(MOLGANKIMOB<>))]
	internal Task<T> PJKNJBKLJOD<T>(CancellationToken JKLIJNDGKKN, Func<CancellationToken, Task<T>> LIMIDIHOABB, int NBABCLHFBKO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x67C8490", Offset = "0x67C7890", VA = "0x1867C8490")]
	[AsyncStateMachine(typeof(DMLEDPHGAFM))]
	internal Task PJKNJBKLJOD(CancellationToken JKLIJNDGKKN, Func<CancellationToken, Task> LIMIDIHOABB, int NBABCLHFBKO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x67C8300", Offset = "0x67C7700", VA = "0x1867C8300")]
	public ACMCFLCAALH NBAKFEBNFGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x67C7FB0", Offset = "0x67C73B0", VA = "0x1867C7FB0")]
	public IMOOHKMONNP LCBFPEAGOIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x67C81B0", Offset = "0x67C75B0", VA = "0x1867C81B0")]
	public FNNMEELIIFA LLBMJIKNIKE([Optional] GFLOJPOFOAD? DFBIKANGICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x67C7670", Offset = "0x67C6A70", VA = "0x1867C7670")]
	public void AJHIGOICNJI(Func<Guid, bool> OLLGCJKPDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x67C77D0", Offset = "0x67C6BD0", VA = "0x1867C77D0")]
	public void CMHKCBLCEMJ(Func<Guid, bool> DKHKFGMDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x67C8030", Offset = "0x67C7430", VA = "0x1867C8030")]
	public Guid LEHJOLHKFFJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x67C7560", Offset = "0x67C6960", VA = "0x1867C7560")]
	public void AEGFPMPAMMC(Guid KABDGIMEGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x67C7E70", Offset = "0x67C7270", VA = "0x1867C7E70")]
	public void JECOENFCOJP(ELOCCADIICN FAHKFLCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x67C8380", Offset = "0x67C7780", VA = "0x1867C8380")]
	public void OMAIFAPDBID(string MIHHNHNIEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x282EE10", Offset = "0x282E210", VA = "0x18282EE10")]
	private T NGOCNFPMHHN<T>(T PCGOHCLJAPN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x67C7C00", Offset = "0x67C7000", VA = "0x1867C7C00")]
	public void ENJKIGEIHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x282EA10", Offset = "0x282DE10", VA = "0x18282EA10")]
	[CompilerGenerated]
	internal static string FLMKDOMMDJH<T>(byte[] GHDDMAGGOCG, int FKEMEGDKKAF, GOJLKDHJAEA<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class DLLNKONDIDC : HKIJMCIKIMC
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LGLJDNHLBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LGLJDNHLBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x67E8B70", Offset = "0x67E7F70", VA = "0x1867E8B70")]
		internal object LHNBKEHCNOJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct KJJIHEGFIBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public DLLNKONDIDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private APKMLFOLCPD <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private IMOOHKMONNP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x67E3750", Offset = "0x67E2B50", VA = "0x1867E3750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x67E3F30", Offset = "0x67E3330", VA = "0x1867E3F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct JEDLIIAJDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public DLLNKONDIDC <>4__this;

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
		private TaskAwaiter<DAFHOICEHFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x67E1640", Offset = "0x67E0A40", VA = "0x1867E1640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x67E1CF0", Offset = "0x67E10F0", VA = "0x1867E1CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct KFAABGCMKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public DLLNKONDIDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter<ICJANOLCGFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x67E1D50", Offset = "0x67E1150", VA = "0x1867E1D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x67E2070", Offset = "0x67E1470", VA = "0x1867E2070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class MNIKOHEAFFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public APKMLFOLCPD presence;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MNIKOHEAFFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x67E9870", Offset = "0x67E8C70", VA = "0x1867E9870")]
		internal object NCOMLAILDIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly GFLOJPOFOAD HHCNNGLILHJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly GFLOJPOFOAD MIEGPLNCILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly MAIDGDACGFA IFCFJDMMIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly DHOCBLKANBD BGEILFIILNL;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x67BE640", Offset = "0x67BDA40", VA = "0x1867BE640")]
	public DLLNKONDIDC(MAIDGDACGFA IFCFJDMMIJG, DHOCBLKANBD BGEILFIILNL, Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, BIMKIOLAEHO FIMCDCEAEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x67BE130", Offset = "0x67BD530", VA = "0x1867BE130", Slot = "7")]
	[AsyncStateMachine(typeof(KJJIHEGFIBA))]
	protected override Task DAHPLMCFGDD(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x67BE030", Offset = "0x67BD430", VA = "0x1867BE030")]
	[AsyncStateMachine(typeof(JEDLIIAJDAB))]
	private Task AAIMBGOJODA(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x67BE450", Offset = "0x67BD850", VA = "0x1867BE450")]
	[AsyncStateMachine(typeof(KFAABGCMKOH))]
	private Task<byte> FHILDFDCNAI(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x67BE270", Offset = "0x67BD670", VA = "0x1867BE270")]
	private APKMLFOLCPD DNNJHBLDDPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class KLBABJLJKCA : HKIJMCIKIMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct BPKMKDHCBJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KLBABJLJKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private TaskAwaiter<GDPFOGKLBJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x67D8070", Offset = "0x67D7470", VA = "0x1867D8070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x67D89F0", Offset = "0x67D7DF0", VA = "0x1867D89F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly int DALBBHGFJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly AFFLFHNACKH MLAICGADNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long LHIMKHILIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long MBFGNOMNGHF;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GDPFOGKLBJD CADMOJGPADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7C5660", Offset = "0x7C4A60", VA = "0x1807C5660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7C5580", Offset = "0x7C4980", VA = "0x1807C5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x67E4590", Offset = "0x67E3990", VA = "0x1867E4590")]
	public KLBABJLJKCA(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, BIMKIOLAEHO FIMCDCEAEPP, int DALBBHGFJNL, AFFLFHNACKH MLAICGADNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x67E4470", Offset = "0x67E3870", VA = "0x1867E4470", Slot = "7")]
	[AsyncStateMachine(typeof(BPKMKDHCBJI))]
	protected override Task DAHPLMCFGDD(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class PCPBPOJKINF : HKIJMCIKIMC
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class FKCAOFLFJOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public PCPBPOJKINF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public MKNHHMBPNCA playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public FKCAOFLFJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x67DBFC0", Offset = "0x67DB3C0", VA = "0x1867DBFC0")]
		internal Task IGADKOKNKAE(OHKLINEMLLN<string>.IECBLACBOCC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x67DBF30", Offset = "0x67DB330", VA = "0x1867DBF30")]
		internal object HAMOGPMCOKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct OBMCBMGPFCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public PCPBPOJKINF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private FKCAOFLFJOP <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x67E9C50", Offset = "0x67E9050", VA = "0x1867E9C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x67EA410", Offset = "0x67E9810", VA = "0x1867EA410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct FDHOHPFEIDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public MKNHHMBPNCA playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public PCPBPOJKINF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x67DAAF0", Offset = "0x67D9EF0", VA = "0x1867DAAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x67DB080", Offset = "0x67DA480", VA = "0x1867DB080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x67EB240", Offset = "0x67EA640", VA = "0x1867EB240")]
	public PCPBPOJKINF(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, BIMKIOLAEHO FIMCDCEAEPP, string JEFFPGBOIAL, FHHLMPEEIFB MMIJGFOKHGO, bool GNMDEPIDKHF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x67EAFC0", Offset = "0x67EA3C0", VA = "0x1867EAFC0", Slot = "7")]
	[AsyncStateMachine(typeof(OBMCBMGPFCF))]
	protected override Task DAHPLMCFGDD(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task BNCEOAHOOLO(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x67EB100", Offset = "0x67EA500", VA = "0x1867EB100")]
	[AsyncStateMachine(typeof(FDHOHPFEIDJ))]
	private Task FCFMBHHAMNM(IDisposable EAAFFCOLJBF, MKNHHMBPNCA EAFIJHPBKAP, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class NFOBBOGOJBO : HKIJMCIKIMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct PHOIKMLFJGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public NFOBBOGOJBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public IKKONDAGOHO operationContext;

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
		private TaskAwaiter<HIIJCKKCKNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x67EC150", Offset = "0x67EB550", VA = "0x1867EC150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x67EC6C0", Offset = "0x67EBAC0", VA = "0x1867EC6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private readonly PKLFHHDPKAE NBONEADNIAK;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x67E9BB0", Offset = "0x67E8FB0", VA = "0x1867E9BB0")]
	public NFOBBOGOJBO(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, BIMKIOLAEHO FIMCDCEAEPP, PKLFHHDPKAE NBONEADNIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x67E9AD0", Offset = "0x67E8ED0", VA = "0x1867E9AD0", Slot = "6")]
	protected override string MPFNBCAPHNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x67E99B0", Offset = "0x67E8DB0", VA = "0x1867E99B0", Slot = "7")]
	[AsyncStateMachine(typeof(PHOIKMLFJGI))]
	protected override Task DAHPLMCFGDD(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class HKIJMCIKIMC : NJMJHIEGALE
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task HKGPPMMFINF(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class EIKMFMMPCCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public OHKLINEMLLN<string>.IECBLACBOCC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public HKIJMCIKIMC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public EIKMFMMPCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x67DA370", Offset = "0x67D9770", VA = "0x1867DA370")]
		internal Task DJLMCJAFEDN(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class EFPGMDGNIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public EIKMFMMPCCB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public EFPGMDGNIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x67DA0B0", Offset = "0x67D94B0", VA = "0x1867DA0B0")]
		internal object DGPOOCJCJHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x67DA170", Offset = "0x67D9570", VA = "0x1867DA170")]
		internal object GGAMALHGCOA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct KIIBFLGFHMJ : IAsyncStateMachine
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
		public HKIJMCIKIMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public Func<HKIJMCIKIMC, OHKLINEMLLN<string>.IECBLACBOCC, IKKONDAGOHO> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EIKMFMMPCCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private IKKONDAGOHO <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<ELOCCADIICN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x67E24F0", Offset = "0x67E18F0", VA = "0x1867E24F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x67E36F0", Offset = "0x67E2AF0", VA = "0x1867E36F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct FENGCOLPHCO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x67DB0E0", Offset = "0x67DA4E0", VA = "0x1867DB0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x67DBB60", Offset = "0x67DAF60", VA = "0x1867DBB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct KKMOPGOECOC : IAsyncStateMachine
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
		public HKIJMCIKIMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x67E40B0", Offset = "0x67E34B0", VA = "0x1867E40B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x67E4410", Offset = "0x67E3810", VA = "0x1867E4410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly Guid CHLMCJEOFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly ByteString BGFDHDNONDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly BIMKIOLAEHO OEMIFEBHIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	protected readonly string HMJOENAMDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly bool GNMDEPIDKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly Queue<HKGPPMMFINF> LHLNODJOIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly BMIHPPNPOPO JBDIONLNDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly FHHLMPEEIFB MMIJGFOKHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool MGCPGOGBGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public AEJGAEICAEA POPOCOOACCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public AEJGAEICAEA KAABJLFKBLK;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public HDAJFOAIBMP AKNNAABMGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x67DF350", Offset = "0x67DE750", VA = "0x1867DF350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KCNOANFPABD LABLPNOJIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x67DF190", Offset = "0x67DE590", VA = "0x1867DF190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x67DEFF0", Offset = "0x67DE3F0", VA = "0x1867DEFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NFLKAFGJHDI MOFIEMCOENO
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x67DEE80", Offset = "0x67DE280", VA = "0x1867DEE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x67DF330", Offset = "0x67DE730", VA = "0x1867DF330", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x67DF7F0", Offset = "0x67DEBF0", VA = "0x1867DF7F0")]
	protected HKIJMCIKIMC(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, BIMKIOLAEHO FIMCDCEAEPP, string JEFFPGBOIAL, FHHLMPEEIFB MMIJGFOKHGO, bool GNMDEPIDKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x67DF7B0", Offset = "0x67DEBB0", VA = "0x1867DF7B0", Slot = "6")]
	protected virtual string MPFNBCAPHNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x67DEEA0", Offset = "0x67DE2A0", VA = "0x1867DEEA0")]
	public void CHGAMNFLFGI(HKGPPMMFINF EDAAAJMFDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x67DF1E0", Offset = "0x67DE5E0", VA = "0x1867DF1E0")]
	protected void FCHKKAIEMAC(float FBPAJEFFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x67DF570", Offset = "0x67DE970", VA = "0x1867DF570")]
	[AsyncStateMachine(typeof(KIIBFLGFHMJ))]
	public Task KFNIOKHILDK(CancellationToken KNKAEBKAEBM, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, [Optional] Func<HKIJMCIKIMC, OHKLINEMLLN<string>.IECBLACBOCC, IKKONDAGOHO> HINDJJKKBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x67DF200", Offset = "0x67DE600", VA = "0x1867DF200")]
	[AsyncStateMachine(typeof(FENGCOLPHCO))]
	private static Task FNNJMCBPFLP(Func<CancellationToken, Task> LMAPMKBLGHD, Func<CancellationToken, Task> PIHBMFCFIKO, CancellationToken JKLIJNDGKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x67DF3A0", Offset = "0x67DE7A0", VA = "0x1867DF3A0")]
	private void JMPHJFFIAEC(bool DLEFFDAKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x67DF6C0", Offset = "0x67DEAC0", VA = "0x1867DF6C0")]
	private void KLOOPOIIHCA(IKKONDAGOHO CDDFHKFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task DAHPLMCFGDD(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x67DF070", Offset = "0x67DE470", VA = "0x1867DF070")]
	[AsyncStateMachine(typeof(KKMOPGOECOC))]
	private Task DLFMLDMDJJN(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x67DF4F0", Offset = "0x67DE8F0", VA = "0x1867DF4F0")]
	public ELOCCADIICN KAJGHKMKGFI(COIAFENBOPJ ILBFPABOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x67DEF00", Offset = "0x67DE300", VA = "0x1867DEF00")]
	[CompilerGenerated]
	private Task CODINHPNMMH(CancellationToken PLGHLMOEPOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class MFBHHODDIOM : PCPBPOJKINF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct ANNNAKKKMGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public MFBHHODDIOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private BHGHCLPFMEJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private IMOOHKMONNP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x67D76A0", Offset = "0x67D6AA0", VA = "0x1867D76A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x67D7E10", Offset = "0x67D7210", VA = "0x1867D7E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly MAIDGDACGFA OMOJJONANGH;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x67E9470", Offset = "0x67E8870", VA = "0x1867E9470")]
	public MFBHHODDIOM(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, MAIDGDACGFA OMOJJONANGH, BIMKIOLAEHO FIMCDCEAEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x67E9320", Offset = "0x67E8720", VA = "0x1867E9320", Slot = "8")]
	[AsyncStateMachine(typeof(ANNNAKKKMGI))]
	protected override Task BNCEOAHOOLO(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class GIPNANOPPEB : HKIJMCIKIMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct KICBNPPFIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public GIPNANOPPEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private TaskAwaiter<HIIJCKKCKNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x67E20E0", Offset = "0x67E14E0", VA = "0x1867E20E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x67E2490", Offset = "0x67E1890", VA = "0x1867E2490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private readonly string BPHPCMABALK;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x67DCE90", Offset = "0x67DC290", VA = "0x1867DCE90")]
	public GIPNANOPPEB(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, BIMKIOLAEHO FIMCDCEAEPP, string BPHPCMABALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x67DCD80", Offset = "0x67DC180", VA = "0x1867DCD80", Slot = "7")]
	[AsyncStateMachine(typeof(KICBNPPFIGN))]
	protected override Task DAHPLMCFGDD(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class KNEODMPPOEA : PCPBPOJKINF
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class KKLOGEDMJOL
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
			public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public KKLOGEDMJOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<HIIJCKKCKNI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<ELOCCADIICN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x67F0460", Offset = "0x67EF860", VA = "0x1867F0460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x67F0920", Offset = "0x67EFD20", VA = "0x1867F0920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public KNEODMPPOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public FNNMEELIIFA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public DLGKDAMPLFB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public ACMCFLCAALH uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public OKNMINIJBMC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KKLOGEDMJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x67E3F90", Offset = "0x67E3390", VA = "0x1867E3F90")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<ELOCCADIICN> LCMEPGJPJPM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct DBDKGDHFGNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public KNEODMPPOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private KKLOGEDMJOL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private BHGHCLPFMEJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private IMOOHKMONNP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x67D91B0", Offset = "0x67D85B0", VA = "0x1867D91B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x67DA050", Offset = "0x67D9450", VA = "0x1867DA050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly GFLOJPOFOAD HHCNNGLILHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private readonly int CNFILGPEFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	[CanBeNull]
	private readonly DJFGIDMDALL JIKFJKFOCPO;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x67E5840", Offset = "0x67E4C40", VA = "0x1867E5840")]
	public KNEODMPPOEA(Guid FHLPBMFOONK, HDAJFOAIBMP DPKDAIDNMNC, int CNFILGPEFON, DJFGIDMDALL JIKFJKFOCPO, BIMKIOLAEHO FIMCDCEAEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x67E5380", Offset = "0x67E4780", VA = "0x1867E5380", Slot = "8")]
	[AsyncStateMachine(typeof(DBDKGDHFGNL))]
	protected override Task BNCEOAHOOLO(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x67E5690", Offset = "0x67E4A90", VA = "0x1867E5690")]
	private void PKKELJPHMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x67E54C0", Offset = "0x67E48C0", VA = "0x1867E54C0")]
	private void KBJBMDOCDGN(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, BHGHCLPFMEJ IIBBCMNHPFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class FCFMHLOGGLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly HKIJMCIKIMC ABHNHNABGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly IKKONDAGOHO KILHJKOFAHB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x67DAA20", Offset = "0x67D9E20", VA = "0x1867DAA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x67DA990", Offset = "0x67D9D90", VA = "0x1867DA990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x67DAA90", Offset = "0x67D9E90", VA = "0x1867DAA90")]
	protected FCFMHLOGGLC(IKKONDAGOHO CDDFHKFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x67DAA70", Offset = "0x67D9E70", VA = "0x1867DAA70")]
	protected void OMAIFAPDBID(string MIHHNHNIEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct AEMPNJHLIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<OCELGLAPMHM>> EDFKPNDNJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<OCELGLAPMHM>> IODEKPCJOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<OCELGLAPMHM>> JMKMEIJIGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public List<Guid> OAJHAPKEODH;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x67D7090", Offset = "0x67D6490", VA = "0x1867D7090")]
	public static AEMPNJHLIPB EBLDKANKNCA(LJHJLDLGJAI ACAIKIGINDM, AEJGAEICAEA GHKLOINOCNJ, FCICHBFPKKL LNIPINAMGMB)
	{
		return default(AEMPNJHLIPB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct KLOIKNBPEKL
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	public static KLOIKNBPEKL HEJOOLMEDMH()
	{
		return default(KLOIKNBPEKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct LNNAJEICBIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly DAFHOICEHFC OPPMEGJIOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly EFJPDNIEGLO HEMCEIODOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly string NDBHALICMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly LOEJPFELMNK AIFELOLJMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly LOEJPFELMNK DMKAHHMFABC;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x67E8BE0", Offset = "0x67E7FE0", VA = "0x1867E8BE0")]
	public LNNAJEICBIE(DAFHOICEHFC OPPMEGJIOLD, EFJPDNIEGLO HEMCEIODOPM, string NDBHALICMDP, LOEJPFELMNK AIFELOLJMOB, LOEJPFELMNK DMKAHHMFABC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct CALHHJPBAOE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly IKKONDAGOHO CDDFHKFEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly Guid KABDGIMEGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private bool DLEFFDAKKCK;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x67D8B50", Offset = "0x67D7F50", VA = "0x1867D8B50")]
	public static CALHHJPBAOE LEHJOLHKFFJ(IKKONDAGOHO CDDFHKFEAMI)
	{
		return default(CALHHJPBAOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x8299D0", Offset = "0x828DD0", VA = "0x1808299D0")]
	public void FMNJDJKGLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x67D8A50", Offset = "0x67D7E50", VA = "0x1867D8A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x67D8BB0", Offset = "0x67D7FB0", VA = "0x1867D8BB0")]
	private CALHHJPBAOE(IKKONDAGOHO CDDFHKFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x67D8A50", Offset = "0x67D7E50", VA = "0x1867D8A50")]
	private void AEGFPMPAMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x67D8AB0", Offset = "0x67D7EB0", VA = "0x1867D8AB0")]
	private Func<Guid, bool> IPDJJOLICGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class IMOOHKMONNP : FCFMHLOGGLC, NJMJHIEGALE
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<AEJGAEICAEA> IOGENKMOGKC(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD PPGICAHHGFC, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct GBAILCHAJIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public MAIDGDACGFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private CALHHJPBAOE <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x67DC5B0", Offset = "0x67DB9B0", VA = "0x1867DC5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x67DCD20", Offset = "0x67DC120", VA = "0x1867DCD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct KPKBBKDFDNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public MAIDGDACGFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private OHKLINEMLLN<string>.IECBLACBOCC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x67E6560", Offset = "0x67E5960", VA = "0x1867E6560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x67E6970", Offset = "0x67E5D70", VA = "0x1867E6970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct EIMMOCMGBMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public MAIDGDACGFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private OHKLINEMLLN<string>.IECBLACBOCC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x67DA4A0", Offset = "0x67D98A0", VA = "0x1867DA4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x67DA930", Offset = "0x67D9D30", VA = "0x1867DA930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class PEBBBKNMHKD
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
			public AsyncTaskMethodBuilder<LNNAJEICBIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public PEBBBKNMHKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private LNNAJEICBIE <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<AEJGAEICAEA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private TaskAwaiter<LNNAJEICBIE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x67EEB20", Offset = "0x67EDF20", VA = "0x1867EEB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x67EF2B0", Offset = "0x67EE6B0", VA = "0x1867EF2B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FCICHBFPKKL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public PEBBBKNMHKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private FCICHBFPKKL <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<AEJGAEICAEA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private TaskAwaiter<FCICHBFPKKL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x67EF320", Offset = "0x67EE720", VA = "0x1867EF320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x67EF970", Offset = "0x67EED70", VA = "0x1867EF970", Slot = "5")]
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
			public PEBBBKNMHKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private TaskAwaiter<AEJGAEICAEA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private BIDDENPKPDD <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x67ED780", Offset = "0x67ECB80", VA = "0x1867ED780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x67EEAC0", Offset = "0x67EDEC0", VA = "0x1867EEAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public MAIDGDACGFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public BMIHPPNPOPO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BMIHPPNPOPO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public LNNAJEICBIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public BMIHPPNPOPO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public FCICHBFPKKL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public FOPIIAIPCJM.NJCPJMGBHJJ <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public PEBBBKNMHKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x67EB4F0", Offset = "0x67EA8F0", VA = "0x1867EB4F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<LNNAJEICBIE> NACBEAKFECL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x67EB290", Offset = "0x67EA690", VA = "0x1867EB290")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<FCICHBFPKKL> BADKEIDCJGK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x67EB4B0", Offset = "0x67EA8B0", VA = "0x1867EB4B0")]
		internal void FNGEEGLAHPI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x67EB3B0", Offset = "0x67EA7B0", VA = "0x1867EB3B0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task BBOMPNOINBK(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct KOJHNKNCHLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public MAIDGDACGFA request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private PEBBBKNMHKD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<LNNAJEICBIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<FCICHBFPKKL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x67E58F0", Offset = "0x67E4CF0", VA = "0x1867E58F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x67E6500", Offset = "0x67E5900", VA = "0x1867E6500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct KPKDBDHDFCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x67E69E0", Offset = "0x67E5DE0", VA = "0x1867E69E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x67E7120", Offset = "0x67E6520", VA = "0x1867E7120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct PCLOPOFJDIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private OHKLINEMLLN<string>.IECBLACBOCC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x67EA600", Offset = "0x67E9A00", VA = "0x1867EA600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x67EAF60", Offset = "0x67EA360", VA = "0x1867EAF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct LEMFHPIBBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private OHKLINEMLLN<string>.IECBLACBOCC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x67E7980", Offset = "0x67E6D80", VA = "0x1867E7980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x67E8B00", Offset = "0x67E7F00", VA = "0x1867E8B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HIHFOELCOJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public BIDDENPKPDD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private OHKLINEMLLN<string>.IECBLACBOCC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x67DD900", Offset = "0x67DCD00", VA = "0x1867DD900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x67DECC0", Offset = "0x67DE0C0", VA = "0x1867DECC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct CHLBPHIKNEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AEJGAEICAEA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public FCICHBFPKKL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x67D8EB0", Offset = "0x67D82B0", VA = "0x1867D8EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x67D9140", Offset = "0x67D8540", VA = "0x1867D9140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class IBCKJLODBEJ
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
			public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public IBCKJLODBEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private KHPKPEKMPBB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<AEJGAEICAEA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x67EF9E0", Offset = "0x67EEDE0", VA = "0x1867EF9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x67F0000", Offset = "0x67EF400", VA = "0x1867F0000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public IOGENKMOGKC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public BIDDENPKPDD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AEJGAEICAEA originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IBCKJLODBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x67DF950", Offset = "0x67DED50", VA = "0x1867DF950")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<AEJGAEICAEA> HFLAICFMAOE(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct PMIILAEEKDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public IOGENKMOGKC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public BIDDENPKPDD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x67ED210", Offset = "0x67EC610", VA = "0x1867ED210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x67ED710", Offset = "0x67ECB10", VA = "0x1867ED710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct LCPJDMNDGOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public BMIHPPNPOPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private AEJGAEICAEA <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private IEnumerator<AEJGAEICAEA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x67E73F0", Offset = "0x67E67F0", VA = "0x1867E73F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x67E7920", Offset = "0x67E6D20", VA = "0x1867E7920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct FJABIJGBDDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x67DBBC0", Offset = "0x67DAFC0", VA = "0x1867DBBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x67DBED0", Offset = "0x67DB2D0", VA = "0x1867DBED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct CEMAEKFBAIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public IMOOHKMONNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x67D8C00", Offset = "0x67D8000", VA = "0x1867D8C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x67D8E50", Offset = "0x67D8250", VA = "0x1867D8E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly HMKEPMLABHI KMENIFBKPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly HMKEPMLABHI FODPCHOFHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly JFOMGCGOIAJ DBBLKPDBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly DKJMLKFDDJF AFDJPIGHBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly GGIEDKPIMIA CKMJIEOALAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly HKMFNMHKCNF GFDLHPIIIHG;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private HDAJFOAIBMP AKNNAABMGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x67E0890", Offset = "0x67DFC90", VA = "0x1867E0890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NFLKAFGJHDI MOFIEMCOENO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x67DFAB0", Offset = "0x67DEEB0", VA = "0x1867DFAB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x67DFFF0", Offset = "0x67DF3F0", VA = "0x1867DFFF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x67E1290", Offset = "0x67E0690", VA = "0x1867E1290")]
	public IMOOHKMONNP(IKKONDAGOHO CDDFHKFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x67E01B0", Offset = "0x67DF5B0", VA = "0x1867E01B0")]
	[AsyncStateMachine(typeof(GBAILCHAJIB))]
	public Task KBMELCCOBPL(MAIDGDACGFA BDAAOBFBLIB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x67E08C0", Offset = "0x67DFCC0", VA = "0x1867E08C0")]
	[AsyncStateMachine(typeof(KPKBBKDFDNG))]
	private Task<ELOCCADIICN> MKFMNDGBMJF(MAIDGDACGFA BDAAOBFBLIB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x67E0300", Offset = "0x67DF700", VA = "0x1867E0300")]
	[AsyncStateMachine(typeof(EIMMOCMGBMM))]
	private Task KDAMDPDMNGF(MAIDGDACGFA BDAAOBFBLIB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x67E0B30", Offset = "0x67DFF30", VA = "0x1867E0B30")]
	[AsyncStateMachine(typeof(KOJHNKNCHLF))]
	private Task NMDNAOMHMCM(MAIDGDACGFA BDAAOBFBLIB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken GEHHNMNJIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x67E0A20", Offset = "0x67DFE20", VA = "0x1867E0A20")]
	[AsyncStateMachine(typeof(KPKDBDHDFCB))]
	private Task MNGHGDFAIEA(OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x67E0740", Offset = "0x67DFB40", VA = "0x1867E0740")]
	[AsyncStateMachine(typeof(PCLOPOFJDIC))]
	private Task LNKGBNMFDBN(FCICHBFPKKL FLKOGFDGJDF, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x67E0440", Offset = "0x67DF840", VA = "0x1867E0440")]
	[AsyncStateMachine(typeof(LEMFHPIBBKB))]
	private Task<AEJGAEICAEA> KIPEEJALADO(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x67DFE70", Offset = "0x67DF270", VA = "0x1867DFE70")]
	[AsyncStateMachine(typeof(HIHFOELCOJJ))]
	private Task<AEJGAEICAEA> HKMFLOJFLAO(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x67DFC00", Offset = "0x67DF000", VA = "0x1867DFC00")]
	[AsyncStateMachine(typeof(CHLBPHIKNEI))]
	private Task<AEJGAEICAEA> EAFGEDIDCCM(AEJGAEICAEA GHKLOINOCNJ, FCICHBFPKKL LNIPINAMGMB, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM, bool ONGCEEKDIHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x67DFB10", Offset = "0x67DEF10", VA = "0x1867DFB10")]
	private bool CDOLCDFMPOI(FCICHBFPKKL AKDNDLAKBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x67E0F90", Offset = "0x67E0390", VA = "0x1867E0F90")]
	[AsyncStateMachine(typeof(PMIILAEEKDK))]
	protected Task<AEJGAEICAEA> OFKPBDCHAIF(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM, IOGENKMOGKC LHODNOIBPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x67E05A0", Offset = "0x67DF9A0", VA = "0x1867E05A0")]
	[AsyncStateMachine(typeof(LCPJDMNDGOK))]
	private Task KLNEPEFPBCB(FCICHBFPKKL FLKOGFDGJDF, BMIHPPNPOPO IFLHKNNILKF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x67E0F00", Offset = "0x67E0300", VA = "0x1867E0F00")]
	private void OCBDJILJKKO(AEJGAEICAEA BBBPAKDHIHP, BMIHPPNPOPO IFLHKNNILKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x67DFAD0", Offset = "0x67DEED0", VA = "0x1867DFAD0")]
	private void CBKBIHALGLG(AEJGAEICAEA AGLMGKJHJGE, [Out] AEJGAEICAEA HFPEPALIJJE, [Out] AEJGAEICAEA PPJPMBIDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x67E0170", Offset = "0x67DF570", VA = "0x1867E0170")]
	private Task<LNNAJEICBIE> JNCNPGOLDOJ(MAIDGDACGFA BDAAOBFBLIB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x67E0F50", Offset = "0x67E0350", VA = "0x1867E0F50")]
	private Task<FCICHBFPKKL> OENFCGDNKIG(LNNAJEICBIE FLKOGFDGJDF, FOPIIAIPCJM.NJCPJMGBHJJ EOBBCEADDII, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x67E1120", Offset = "0x67E0520", VA = "0x1867E1120")]
	[AsyncStateMachine(typeof(FJABIJGBDDM))]
	private Task OIPENEEGPJL(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM, bool NAHFPFDIMCJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x67DFD80", Offset = "0x67DF180", VA = "0x1867DFD80")]
	[AsyncStateMachine(typeof(CEMAEKFBAIC))]
	private Task HFCILHGDDMI(FCICHBFPKKL FLKOGFDGJDF, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x67E0C70", Offset = "0x67E0070", VA = "0x1867E0C70")]
	private Task NODEDIAMOIA(FCICHBFPKKL FLKOGFDGJDF, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x67E0150", Offset = "0x67DF550", VA = "0x1867E0150")]
	private Task IHFCOPIHNHH(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x67E1270", Offset = "0x67E0670", VA = "0x1867E1270")]
	private Task PPGFDAKAKFF(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x67E0DB0", Offset = "0x67E01B0", VA = "0x1867E0DB0")]
	private Task OAIHDHOMDMA(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x67D7E70", Offset = "0x67D7270", VA = "0x1867D7E70")]
	private static Task CJHJLCDCGAJ(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x67DFA70", Offset = "0x67DEE70", VA = "0x1867DFA70")]
	private Task AJHMFGMIHPJ(FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x67E0010", Offset = "0x67DF410", VA = "0x1867E0010")]
	private Task IDEFDJEGHGK(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x67E06F0", Offset = "0x67DFAF0", VA = "0x1867E06F0")]
	private void LBBBNCCFGHC(MAIDGDACGFA BDAAOBFBLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x67DFA90", Offset = "0x67DEE90", VA = "0x1867DFA90")]
	public void BLJDPLELENA(long LEGFKICMEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void DJAACECGIDI(DAFHOICEHFC OPPMEGJIOLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct AEFGOHFAPCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private FCICHBFPKKL FLKOGFDGJDF;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x67D6D70", Offset = "0x67D6170", VA = "0x1867D6D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x67D6DC0", Offset = "0x67D61C0", VA = "0x1867D6DC0")]
	public static Task KFNIOKHILDK(HDAJFOAIBMP DPKDAIDNMNC, FCICHBFPKKL FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x67D6EA0", Offset = "0x67D62A0", VA = "0x1867D6EA0")]
	private void KFNIOKHILDK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct APCLLACJODF
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x67D7E70", Offset = "0x67D7270", VA = "0x1867D7E70")]
	public static Task KFNIOKHILDK(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct EHODLJCHFAD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct AABOEFELPFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private OHKLINEMLLN<string>.IECBLACBOCC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x67D67F0", Offset = "0x67D5BF0", VA = "0x1867D67F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x67D6D10", Offset = "0x67D6110", VA = "0x1867D6D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x67DA230", Offset = "0x67D9630", VA = "0x1867DA230")]
	[AsyncStateMachine(typeof(AABOEFELPFI))]
	public static Task KFNIOKHILDK(IKKONDAGOHO CDDFHKFEAMI, FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct MKFPMKPEKFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct KNEAFCPLJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public BIDDENPKPDD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private AEJGAEICAEA <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private HDAJFOAIBMP <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private LJHJLDLGJAI <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private KHPKPEKMPBB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private List<(PersistenceView, BIGDCOAAKFF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private BIGDCOAAKFF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x67E46C0", Offset = "0x67E3AC0", VA = "0x1867E46C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x67E5320", Offset = "0x67E4720", VA = "0x1867E5320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x67E9720", Offset = "0x67E8B20", VA = "0x1867E9720")]
	[AsyncStateMachine(typeof(KNEAFCPLJMA))]
	public static Task KFNIOKHILDK(IKKONDAGOHO CDDFHKFEAMI, FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x67E9520", Offset = "0x67E8920", VA = "0x1867E9520")]
	private static void APEIIOKCLAG(PersistenceView GLNMJKHJCBJ, BIGDCOAAKFF IMAEGLAPIGI, FCICHBFPKKL FLKOGFDGJDF, AEJGAEICAEA GHKLOINOCNJ, bool NJKHGEJHHOM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct FLAEMFNNDCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct FKHDNDMLFBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public HDAJFOAIBMP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x67DC000", Offset = "0x67DB400", VA = "0x1867DC000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x67DC440", Offset = "0x67DB840", VA = "0x1867DC440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x67DC4A0", Offset = "0x67DB8A0", VA = "0x1867DC4A0")]
	[AsyncStateMachine(typeof(FKHDNDMLFBM))]
	public static Task KFNIOKHILDK(HDAJFOAIBMP DPKDAIDNMNC, FCICHBFPKKL FLKOGFDGJDF, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct PLLDNCEHNMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct LAELNHGLONA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public HDAJFOAIBMP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x67E7180", Offset = "0x67E6580", VA = "0x1867E7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x67E7390", Offset = "0x67E6790", VA = "0x1867E7390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class BFCNODOEPMM
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
			public OHKLINEMLLN<string>.IECBLACBOCC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public BFCNODOEPMM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x67F0070", Offset = "0x67EF470", VA = "0x1867F0070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x67F0400", Offset = "0x67EF800", VA = "0x1867F0400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BFCNODOEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x67D7F50", Offset = "0x67D7350", VA = "0x1867D7F50")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task IGBKDLLEOEC(OHKLINEMLLN<string>.IECBLACBOCC timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct HHDGGPAMKJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public PLLDNCEHNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x67DCF40", Offset = "0x67DC340", VA = "0x1867DCF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x67DD8A0", Offset = "0x67DCCA0", VA = "0x1867DD8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class OFCJIKJEOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public MGKNMOMBPMH version;

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
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OFCJIKJEOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x67EA470", Offset = "0x67E9870", VA = "0x1867EA470")]
		internal object BCJKCBGNKFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x67EA550", Offset = "0x67E9950", VA = "0x1867EA550")]
		internal object EKEIOHFHNNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private FCICHBFPKKL FLKOGFDGJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private IKKONDAGOHO CDDFHKFEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private bool NAHFPFDIMCJ;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private static readonly ByteString HDEDHHLAHMP;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x67ECEA0", Offset = "0x67EC2A0", VA = "0x1867ECEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CGKPHOFKCHJ FEHHKGJJJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x67EC720", Offset = "0x67EBB20", VA = "0x1867EC720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x67ED030", Offset = "0x67EC430", VA = "0x1867ED030")]
	[AsyncStateMachine(typeof(LAELNHGLONA))]
	public static Task KFNIOKHILDK(HDAJFOAIBMP DPKDAIDNMNC, FCICHBFPKKL FLKOGFDGJDF, IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM, bool NAHFPFDIMCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x67ECEF0", Offset = "0x67EC2F0", VA = "0x1867ECEF0")]
	[AsyncStateMachine(typeof(HHDGGPAMKJB))]
	private Task KFNIOKHILDK(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x67EC7C0", Offset = "0x67EBBC0", VA = "0x1867EC7C0")]
	private void DBIFMCCFBNP([NotNull] DFCHLNBLLMO IOPAFECKJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x67ECE60", Offset = "0x67EC260", VA = "0x1867ECE60")]
	private bool HHDDDJHFAKA(MGKNMOMBPMH PAKIAOEKDPK, DFCHLNBLLMO IOPAFECKJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct MAKPOIAOOAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct PGFBBKLEFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<FCICHBFPKKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public MAKPOIAOOAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public FOPIIAIPCJM.NJCPJMGBHJJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private OHKLINEMLLN<string>.IECBLACBOCC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter<(OJIJNKCPBAD<NJKKMIOMNHA, FEBGENKADMF>, OJIJNKCPBAD<CAFJOBNFGAD<DFCHLNBLLMO>, FEBGENKADMF>, OJIJNKCPBAD<CAFJOBNFGAD<CKDDLMNONFM>, FEBGENKADMF>, OJIJNKCPBAD<CAFJOBNFGAD<KLCPJFMKFLG>, FEBGENKADMF>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x67EB630", Offset = "0x67EAA30", VA = "0x1867EB630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x67EC0E0", Offset = "0x67EB4E0", VA = "0x1867EC0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct NGEFFKOEEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<NJKKMIOMNHA, FEBGENKADMF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public OHKLINEMLLN<string>.IECBLACBOCC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public MAKPOIAOOAO <>4__this;

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
		public FOPIIAIPCJM.NJCPJMGBHJJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<OJIJNKCPBAD<NJKKMIOMNHA, FEBGENKADMF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6805330", Offset = "0x6804730", VA = "0x186805330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x6805940", Offset = "0x6804D40", VA = "0x186805940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private FBBOFFFNJKG<LOEJPFELMNK, CKDDLMNONFM> DCPLCINBJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private FBBOFFFNJKG<LOEJPFELMNK, DFCHLNBLLMO> HOJBHOHOKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private FBBOFFFNJKG<long, KLCPJFMKFLG> DLIACJPIHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private BALNAPGPFIP LFFKBCJABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private DAFHOICEHFC OPPMEGJIOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private EFJPDNIEGLO HEMCEIODOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private string NDBHALICMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private LOEJPFELMNK AIFELOLJMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private LOEJPFELMNK DMKAHHMFABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private long LEGFKICMEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x67E8FB0", Offset = "0x67E83B0", VA = "0x1867E8FB0")]
	public static Task<FCICHBFPKKL> KLJFFPJKOPF(HDAJFOAIBMP DPKDAIDNMNC, [In] LNNAJEICBIE FLKOGFDGJDF, FOPIIAIPCJM.NJCPJMGBHJJ EOBBCEADDII, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x67E8E20", Offset = "0x67E8220", VA = "0x1867E8E20")]
	[AsyncStateMachine(typeof(PGFBBKLEFPF))]
	private Task<FCICHBFPKKL> KFNIOKHILDK(FOPIIAIPCJM.NJCPJMGBHJJ EOBBCEADDII, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x67E8C60", Offset = "0x67E8060", VA = "0x1867E8C60")]
	[AsyncStateMachine(typeof(NGEFFKOEEKE))]
	private Task<OJIJNKCPBAD<NJKKMIOMNHA, FEBGENKADMF>> DNBOBNJPGOI(string NDBHALICMDP, long LEGFKICMEKA, long? NIJFNKBIOIC, long? LFGAFDMLOJL, FOPIIAIPCJM.NJCPJMGBHJJ EOBBCEADDII, OHKLINEMLLN<string>.IECBLACBOCC BPGPNJOLKJO, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct IIPIKOGNEMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct NMDBLEIJKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder<LNNAJEICBIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public IIPIKOGNEMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private OHKLINEMLLN<string>.IECBLACBOCC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<LNNAJEICBIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x6806B60", Offset = "0x6805F60", VA = "0x186806B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6806F60", Offset = "0x6806360", VA = "0x186806F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct CIBKNNPIOPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder<LNNAJEICBIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public IIPIKOGNEMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<LNNAJEICBIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x67F28F0", Offset = "0x67F1CF0", VA = "0x1867F28F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x67F2D20", Offset = "0x67F2120", VA = "0x1867F2D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class IPCONGFHKMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IPCONGFHKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x14D8210", Offset = "0x14D7610", VA = "0x1814D8210")]
		internal bool BCLIGCJOCDI(EFJPDNIEGLO sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct NGMOPFNINJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder<LNNAJEICBIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public LOEJPFELMNK superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public LJHJLDLGJAI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private IPCONGFHKMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public PCNOPEBAMLP roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private DAFHOICEHFC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private EFJPDNIEGLO <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private LOEJPFELMNK <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private LOEJPFELMNK <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter<DAFHOICEHFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter<JKFEJAMDBHK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<ICJANOLCGFM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x68059B0", Offset = "0x6804DB0", VA = "0x1868059B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6806AF0", Offset = "0x6805EF0", VA = "0x186806AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private JFOMGCGOIAJ DBBLKPDBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private PCNOPEBAMLP PPNPDLKMNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private long NIJFNKBIOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private long MCHADGEKOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private long PNLPKLPODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private string PDFKPGNALBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private LOEJPFELMNK HPHCNFDLEPA;

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x67FF060", Offset = "0x67FE460", VA = "0x1867FF060")]
	public static Task<LNNAJEICBIE> KLJFFPJKOPF(HDAJFOAIBMP DPKDAIDNMNC, MAIDGDACGFA BDAAOBFBLIB, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x67FEF10", Offset = "0x67FE310", VA = "0x1867FEF10")]
	[AsyncStateMachine(typeof(NMDBLEIJKHG))]
	private Task<LNNAJEICBIE> KFNIOKHILDK(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x67FEDB0", Offset = "0x67FE1B0", VA = "0x1867FEDB0")]
	[AsyncStateMachine(typeof(CIBKNNPIOPO))]
	private Task<LNNAJEICBIE> JNCNPGOLDOJ(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x67FEC10", Offset = "0x67FE010", VA = "0x1867FEC10")]
	[AsyncStateMachine(typeof(NGMOPFNINJD))]
	private static Task<LNNAJEICBIE> JNCNPGOLDOJ(LJHJLDLGJAI ACAIKIGINDM, PCNOPEBAMLP PPNPDLKMNDP, long NIJFNKBIOIC, long MCHADGEKOOE, long PNLPKLPODDC, string PDFKPGNALBH, LOEJPFELMNK HPHCNFDLEPA, CancellationToken KNKAEBKAEBM, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x67FEBE0", Offset = "0x67FDFE0", VA = "0x1867FEBE0")]
	private void GCNLDOKHNAI(DAFHOICEHFC OPPMEGJIOLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct NFDHOEOPMBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct HILJMLPOEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public NFDHOEOPMBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x67FBF70", Offset = "0x67FB370", VA = "0x1867FBF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x67FC500", Offset = "0x67FB900", VA = "0x1867FC500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private LJHJLDLGJAI ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private FCICHBFPKKL FLKOGFDGJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private float CIAMONDLCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private float PMPAFGIALGI;

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x68040D0", Offset = "0x68034D0", VA = "0x1868040D0")]
	public static Task CCCBALIDMED(HDAJFOAIBMP DPKDAIDNMNC, FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6804470", Offset = "0x6803870", VA = "0x186804470")]
	[AsyncStateMachine(typeof(HILJMLPOEPC))]
	public Task KFNIOKHILDK(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6804270", Offset = "0x6803670", VA = "0x186804270")]
	private static void FNBAFFDHKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x68045B0", Offset = "0x68039B0", VA = "0x1868045B0")]
	private void OFJKGJGHHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x68043B0", Offset = "0x68037B0", VA = "0x1868043B0")]
	private static float ICGPMEBEHFO(LJHJLDLGJAI ACAIKIGINDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6804590", Offset = "0x6803990", VA = "0x186804590")]
	private static float MAGJBMHCEPC()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct GFIGKGPIFPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct HFMKKMJBBEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public IKKONDAGOHO operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private HKIJMCIKIMC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private HDAJFOAIBMP <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private KCJIOPDNHFJ.OPAJNMBALHO <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x67FB430", Offset = "0x67FA830", VA = "0x1867FB430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x67FBDD0", Offset = "0x67FB1D0", VA = "0x1867FBDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct BMHMHBCBDGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x67F24F0", Offset = "0x67F18F0", VA = "0x1867F24F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x67F27E0", Offset = "0x67F1BE0", VA = "0x1867F27E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x67F9260", Offset = "0x67F8660", VA = "0x1867F9260")]
	[AsyncStateMachine(typeof(HFMKKMJBBEJ))]
	public static Task KFNIOKHILDK(IKKONDAGOHO CDDFHKFEAMI, FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x67F93A0", Offset = "0x67F87A0", VA = "0x1867F93A0")]
	private static Task<ELOCCADIICN> KNGDHMOGFGL(IKKONDAGOHO CDDFHKFEAMI, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x67F9410", Offset = "0x67F8810", VA = "0x1867F9410")]
	[AsyncStateMachine(typeof(BMHMHBCBDGE))]
	private static Task PJJLEHMOHKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct AKEJFCNHDJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct EAHPOJLOKPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AKEJFCNHDJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x67F5D60", Offset = "0x67F5160", VA = "0x1867F5D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x67F6410", Offset = "0x67F5810", VA = "0x1867F6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class IIFKKNOGIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IIFKKNOGIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x67FEB60", Offset = "0x67FDF60", VA = "0x1867FEB60")]
		internal object KELGPEHMNOG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct PPCHMANDIGC : IAsyncStateMachine
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
		public AKEJFCNHDJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private BAJMMNDJEJK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x6808C70", Offset = "0x6808070", VA = "0x186808C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6809230", Offset = "0x6808630", VA = "0x186809230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private bool KKPPJFHHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private CancellationToken KNKAEBKAEBM;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x67F2180", Offset = "0x67F1580", VA = "0x1867F2180")]
	public static Task EPFBJHBPHND(HDAJFOAIBMP DPKDAIDNMNC, bool KKPPJFHHJJB, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken NFFLDFKMADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x67F21F0", Offset = "0x67F15F0", VA = "0x1867F21F0")]
	[AsyncStateMachine(typeof(EAHPOJLOKPJ))]
	private Task KFNIOKHILDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x67F22E0", Offset = "0x67F16E0", VA = "0x1867F22E0")]
	[AsyncStateMachine(typeof(PPCHMANDIGC))]
	private Task NMNIKDILOFE(bool CPBOEODCEGK, string DDFEOCNDAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	private bool BBPHCMBBLMA(bool KKPPJFHHJJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct JKDJPBNKJFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct NOHHAIMAEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public JKDJPBNKJFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6806FD0", Offset = "0x68063D0", VA = "0x186806FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6807540", Offset = "0x6806940", VA = "0x186807540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class DHILJDGOHCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DHILJDGOHCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x67F4010", Offset = "0x67F3410", VA = "0x1867F4010")]
		internal object KELGPEHMNOG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct ONKKCLKCCDB : IAsyncStateMachine
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
		public JKDJPBNKJFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private BAJMMNDJEJK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x6807FE0", Offset = "0x68073E0", VA = "0x186807FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x68085A0", Offset = "0x68079A0", VA = "0x1868085A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private EMDGFIJEIOH HAELNCEOKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private bool FALAKIHEDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private FCICHBFPKKL FLKOGFDGJDF;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6801780", Offset = "0x6800B80", VA = "0x186801780")]
	public static Task<Scene> OEAIICBNOOG(HDAJFOAIBMP DPKDAIDNMNC, EMDGFIJEIOH ELEKONCHODJ, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6801510", Offset = "0x6800910", VA = "0x186801510")]
	[AsyncStateMachine(typeof(NOHHAIMAEBA))]
	private Task<Scene> KFNIOKHILDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x68014E0", Offset = "0x68008E0", VA = "0x1868014E0")]
	private bool HKAJGFPIDOD(FCICHBFPKKL FLKOGFDGJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6801800", Offset = "0x6800C00", VA = "0x186801800")]
	private void OKLGGNLLGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6801630", Offset = "0x6800A30", VA = "0x186801630")]
	[AsyncStateMachine(typeof(ONKKCLKCCDB))]
	private Task<Scene> NMNIKDILOFE(string DDFEOCNDAEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct GGIEDKPIMIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct INLDBJDKEJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public GGIEDKPIMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AEJGAEICAEA nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public FCICHBFPKKL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private OHKLINEMLLN<string>.IECBLACBOCC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private TaskAwaiter<AEJGAEICAEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x67FF810", Offset = "0x67FEC10", VA = "0x1867FF810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x68002F0", Offset = "0x67FF6F0", VA = "0x1868002F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct NFDEMAGJAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder<AEJGAEICAEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public GGIEDKPIMIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AEJGAEICAEA state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6803D80", Offset = "0x6803180", VA = "0x186803D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6804060", Offset = "0x6803460", VA = "0x186804060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly IKKONDAGOHO CDDFHKFEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly JFOMGCGOIAJ DBBLKPDBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly DKJMLKFDDJF AFDJPIGHBEM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private HKIJMCIKIMC ABHNHNABGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x509A3F0", Offset = "0x50997F0", VA = "0x18509A3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x67F9EE0", Offset = "0x67F92E0", VA = "0x1867F9EE0")]
	public GGIEDKPIMIA(IKKONDAGOHO CDDFHKFEAMI, JFOMGCGOIAJ DBBLKPDBEBN, DKJMLKFDDJF AFDJPIGHBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x67F9D10", Offset = "0x67F9110", VA = "0x1867F9D10")]
	[AsyncStateMachine(typeof(INLDBJDKEJF))]
	public Task<AEJGAEICAEA> EAAFNIOKJCB(AEJGAEICAEA LIDCONNLJIP, FCICHBFPKKL LNIPINAMGMB, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM, bool ONGCEEKDIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x67F9BB0", Offset = "0x67F8FB0", VA = "0x1867F9BB0")]
	[AsyncStateMachine(typeof(NFDEMAGJAEM))]
	private Task<AEJGAEICAEA> ALFBBKGHPNA(OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, AEJGAEICAEA KDDFGNJPJNG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x67F9E90", Offset = "0x67F9290", VA = "0x1867F9E90")]
	private bool IJEMEPGCFCJ(AEJGAEICAEA OBNIKFOCPEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x67F9EC0", Offset = "0x67F92C0", VA = "0x1867F9EC0")]
	private void OMAIFAPDBID(string MJDNKBBGCEF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct GJONHOAKHIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct KPCCAFNKKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public HKIJMCIKIMC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public BIDDENPKPDD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private KHPKPEKMPBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private List<(PersistenceView, BIGDCOAAKFF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private (PersistenceView, BIGDCOAAKFF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6802CF0", Offset = "0x68020F0", VA = "0x186802CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6803300", Offset = "0x6802700", VA = "0x186803300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x67FA240", Offset = "0x67F9640", VA = "0x1867FA240")]
	[AsyncStateMachine(typeof(KPCCAFNKKNK))]
	public static Task KFNIOKHILDK(HKIJMCIKIMC HOPLFLJKCIJ, FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct DINCKKNLMID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct OIAHIJAAMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public HKIJMCIKIMC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public BIDDENPKPDD timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private MGKNMOMBPMH <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private KHPKPEKMPBB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private List<(PersistenceView, BIGDCOAAKFF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private BIGDCOAAKFF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x68075B0", Offset = "0x68069B0", VA = "0x1868075B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x6807E00", Offset = "0x6807200", VA = "0x186807E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x67F4060", Offset = "0x67F3460", VA = "0x1867F4060")]
	[AsyncStateMachine(typeof(OIAHIJAAMCM))]
	public static Task KFNIOKHILDK(HKIJMCIKIMC HOPLFLJKCIJ, FCICHBFPKKL FLKOGFDGJDF, BIDDENPKPDD NNGOKIBHOPE, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct KCJIOPDNHFJ
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct OPAJNMBALHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public List<BLBNOEFPBFI> LOLIGAALLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public List<BIGDCOAAKFF> LFHNAANDKML;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
		public OPAJNMBALHO(List<BLBNOEFPBFI> LOLIGAALLPO, List<BIGDCOAAKFF> LFHNAANDKML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class FOFKMEDBFNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public IEnumerable<BLBNOEFPBFI> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public FOFKMEDBFNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x67F90F0", Offset = "0x67F84F0", VA = "0x1867F90F0")]
		internal object ECBEOKNBBBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private HDAJFOAIBMP DPKDAIDNMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private FCICHBFPKKL FLKOGFDGJDF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private LJHJLDLGJAI JIHNCEMLFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x6801D30", Offset = "0x6801130", VA = "0x186801D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6802330", Offset = "0x6801730", VA = "0x186802330")]
	public static OPAJNMBALHO KFNIOKHILDK(HDAJFOAIBMP DPKDAIDNMNC, FCICHBFPKKL FLKOGFDGJDF)
	{
		return default(OPAJNMBALHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6802390", Offset = "0x6801790", VA = "0x186802390")]
	private OPAJNMBALHO KFNIOKHILDK()
	{
		return default(OPAJNMBALHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6801D80", Offset = "0x6801180", VA = "0x186801D80")]
	private OPAJNMBALHO JLBHJMGJGNH(DFCHLNBLLMO IOPAFECKJPC, MGKNMOMBPMH LJGEOPNMHCA)
	{
		return default(OPAJNMBALHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x68025F0", Offset = "0x68019F0", VA = "0x1868025F0")]
	private bool MACCIOBGIEL(IEnumerable<BLBNOEFPBFI> LOLIGAALLPO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct JIGLNFJODCP
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class BMJKNGFJHCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public KCJIOPDNHFJ.OPAJNMBALHO instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BMJKNGFJHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x67F2840", Offset = "0x67F1C40", VA = "0x1867F2840")]
		internal object IGBKDLLEOEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class ACOEGKILICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ACOEGKILICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x67F1480", Offset = "0x67F0880", VA = "0x1867F1480")]
		internal object DJLMCJAFEDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x6800F30", Offset = "0x6800330", VA = "0x186800F30")]
	public static void KFNIOKHILDK(HKIJMCIKIMC HOPLFLJKCIJ, FCICHBFPKKL FLKOGFDGJDF, KCJIOPDNHFJ.OPAJNMBALHO FDCMMAANDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class DKJMLKFDDJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct JDPEGCMIGJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AEJGAEICAEA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public FCICHBFPKKL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x68006E0", Offset = "0x67FFAE0", VA = "0x1868006E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6800E50", Offset = "0x6800250", VA = "0x186800E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class GDLNPIGHBGA
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
			public GDLNPIGHBGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x6809490", Offset = "0x6808890", VA = "0x186809490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x6809750", Offset = "0x6808B50", VA = "0x186809750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public OHKLINEMLLN<string>.IECBLACBOCC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GDLNPIGHBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x67F9170", Offset = "0x67F8570", VA = "0x1867F9170")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KMLJCGGNPJG(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct AFGKPPLILNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private GDLNPIGHBGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x67F1510", Offset = "0x67F0910", VA = "0x1867F1510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x67F1A40", Offset = "0x67F0E40", VA = "0x1867F1A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct GLNJLKMGAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private Dictionary<Guid, List<OCELGLAPMHM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x67FA380", Offset = "0x67F9780", VA = "0x1867FA380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x67FA930", Offset = "0x67F9D30", VA = "0x1867FA930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct AKAGGBNIMPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private OHKLINEMLLN<string>.IECBLACBOCC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Dictionary<Guid, List<OCELGLAPMHM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x67F1AA0", Offset = "0x67F0EA0", VA = "0x1867F1AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x67F2120", Offset = "0x67F1520", VA = "0x1867F2120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class MGBHKNPIIMK
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
			public OCELGLAPMHM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public MGBHKNPIIMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x6809290", Offset = "0x6808690", VA = "0x186809290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x6809430", Offset = "0x6808830", VA = "0x186809430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public IBHEPFMNEBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public List<OCELGLAPMHM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MGBHKNPIIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x6803870", Offset = "0x6802C70", VA = "0x186803870")]
		internal object HPKIOJODCIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6803780", Offset = "0x6802B80", VA = "0x186803780")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task HIAALCKPIPJ(OCELGLAPMHM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6803690", Offset = "0x6802A90", VA = "0x186803690")]
		internal object FDHFLOOEFJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct IMBEEDJMOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public IBHEPFMNEBF runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public List<OCELGLAPMHM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private MGBHKNPIIMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x67FF2E0", Offset = "0x67FE6E0", VA = "0x1867FF2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x67FF7B0", Offset = "0x67FEBB0", VA = "0x1867FF7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct EOOLCNKCGMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public OHKLINEMLLN<string>.IECBLACBOCC timer;

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
		[Cpp2IlInjected.Address(RVA = "0x67F6930", Offset = "0x67F5D30", VA = "0x1867F6930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x67F6EF0", Offset = "0x67F62F0", VA = "0x1867F6EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class BJJGDGHNABB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BJJGDGHNABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x67F2480", Offset = "0x67F1880", VA = "0x1867F2480")]
		internal object CMIBKJIFNKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct DFNMILAIFGB : IAsyncStateMachine
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
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public FCICHBFPKKL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x67F3AF0", Offset = "0x67F2EF0", VA = "0x1867F3AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x67F3FB0", Offset = "0x67F33B0", VA = "0x1867F3FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class FACGMNMOHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public FACGMNMOHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x67F6F50", Offset = "0x67F6350", VA = "0x1867F6F50")]
		internal object BFPAAJDJFEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct IFNEMCAKPJL : IAsyncStateMachine
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
		public DKJMLKFDDJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x67FDE30", Offset = "0x67FD230", VA = "0x1867FDE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x67FE470", Offset = "0x67FD870", VA = "0x1867FE470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class BBDDJACODBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public BBDDJACODBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x67F2410", Offset = "0x67F1810", VA = "0x1867F2410")]
		internal object LBEAMOBHLOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private readonly IKKONDAGOHO CDDFHKFEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private AEMPNJHLIPB AFDJPIGHBEM;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HKIJMCIKIMC ABHNHNABGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x1098290", Offset = "0x1097690", VA = "0x181098290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public DKJMLKFDDJF(IKKONDAGOHO CDDFHKFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x67F55F0", Offset = "0x67F49F0", VA = "0x1867F55F0")]
	[AsyncStateMachine(typeof(JDPEGCMIGJB))]
	public Task KFNIOKHILDK(AEJGAEICAEA GHKLOINOCNJ, FCICHBFPKKL LNIPINAMGMB, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x67F54B0", Offset = "0x67F48B0", VA = "0x1867F54B0")]
	[AsyncStateMachine(typeof(AFGKPPLILNL))]
	private Task JPGJMFJLAMP(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x67F4FF0", Offset = "0x67F43F0", VA = "0x1867F4FF0")]
	[AsyncStateMachine(typeof(GLNJLKMGAGI))]
	private Task GOKOMKCCPBF(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x67F5740", Offset = "0x67F4B40", VA = "0x1867F5740")]
	[AsyncStateMachine(typeof(AKAGGBNIMPF))]
	private Task LKDGNOJMKDG(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x67F4D60", Offset = "0x67F4160", VA = "0x1867F4D60")]
	[AsyncStateMachine(typeof(IMBEEDJMOLE))]
	private Task DAOCKAGMGEJ(Guid PMCNCJEIANI, List<OCELGLAPMHM> ONJPPAPEHIB, IBHEPFMNEBF BDPPNPBBCHK, FCICHBFPKKL FLKOGFDGJDF, CancellationToken ICNJFMMNIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x67F4EB0", Offset = "0x67F42B0", VA = "0x1867F4EB0")]
	[AsyncStateMachine(typeof(EOOLCNKCGMH))]
	private Task DEHOOAHKBKF(FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x67F5B80", Offset = "0x67F4F80", VA = "0x1867F5B80")]
	[AsyncStateMachine(typeof(DFNMILAIFGB))]
	private Task PGGHGCKCKNB(Guid PBEOMOBCNEO, FCICHBFPKKL FLKOGFDGJDF, OHKLINEMLLN<string>.IECBLACBOCC CBCAJLKKHCH, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x67F5370", Offset = "0x67F4770", VA = "0x1867F5370")]
	[AsyncStateMachine(typeof(IFNEMCAKPJL))]
	private Task JEFEEMEKJLC(Guid PBEOMOBCNEO, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x67F5A60", Offset = "0x67F4E60", VA = "0x1867F5A60")]
	private void MOKLJCOKJCL(Guid PBEOMOBCNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x67F52C0", Offset = "0x67F46C0", VA = "0x1867F52C0")]
	private void HFEIMMKDGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x67F5130", Offset = "0x67F4530", VA = "0x1867F5130")]
	public Guid HDNFBDHKPGM(AEJGAEICAEA BBBPAKDHIHP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x67F5880", Offset = "0x67F4C80", VA = "0x1867F5880")]
	[CompilerGenerated]
	private object LOEMLJIOGDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct OKNMINIJBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	public readonly bool PCENCAKPOHB;

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xCB3550", Offset = "0xCB2950", VA = "0x180CB3550")]
	public OKNMINIJBMC(bool AAEFGLGOKAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct HIIJCKKCKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	public readonly DFCHLNBLLMO? FPHMEDHFGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly JFEALAHABGJ ONJKEPBAJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly string? FNJMHBMMMCC;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public IReadOnlyCollection<string> PAMFDCDNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x67FBE50", Offset = "0x67FB250", VA = "0x1867FBE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IReadOnlyDictionary<long, int> OGFHCNCJFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x67FBE30", Offset = "0x67FB230", VA = "0x1867FBE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x67FBE70", Offset = "0x67FB270", VA = "0x1867FBE70")]
	public HIIJCKKCKNI(DFCHLNBLLMO? HADHNEGDEKF, JFEALAHABGJ JGJABALFLOA, string? NDBHALICMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class FNNMEELIIFA : FCFMHLOGGLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct GFJBIIMKBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public AsyncTaskMethodBuilder<HIIJCKKCKNI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public FNNMEELIIFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public FPPCIOMIKDM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public DLGKDAMPLFB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private KHPKPEKMPBB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x67F94D0", Offset = "0x67F88D0", VA = "0x1867F94D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x67F9B40", Offset = "0x67F8F40", VA = "0x1867F9B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class GGILCBMHLOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public FPPCIOMIKDM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public FNNMEELIIFA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GGILCBMHLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x67F9F40", Offset = "0x67F9340", VA = "0x1867F9F40")]
		internal Task ECGJOFFJABG(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x67FA160", Offset = "0x67F9560", VA = "0x1867FA160")]
		internal Task KELBMPIOGGL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class FLNCKFNNJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public GGILCBMHLOH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public FLNCKFNNJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x67F7780", Offset = "0x67F6B80", VA = "0x1867F7780")]
		internal object PNIAPCFKNHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class ICOCPJIMNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public GGILCBMHLOH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ICOCPJIMNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x67FDDF0", Offset = "0x67FD1F0", VA = "0x1867FDDF0")]
		internal Task CKKBOFGNEME(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct COPLLKOBEKF : IAsyncStateMachine
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
		public FPPCIOMIKDM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public FNNMEELIIFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private FLNCKFNNJDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private KHPKPEKMPBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x67F3220", Offset = "0x67F2620", VA = "0x1867F3220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x67F3A90", Offset = "0x67F2E90", VA = "0x1867F3A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private static readonly TimeSpan PDLDODELGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private readonly CPPLGLFGHNF MPAPDAOPBJI;

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x67F90A0", Offset = "0x67F84A0", VA = "0x1867F90A0")]
	public FNNMEELIIFA(IKKONDAGOHO CDDFHKFEAMI, CPPLGLFGHNF MPAPDAOPBJI, GFLOJPOFOAD DFBIKANGICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x67F8050", Offset = "0x67F7450", VA = "0x1867F8050")]
	[AsyncStateMachine(typeof(GFJBIIMKBBB))]
	public Task<HIIJCKKCKNI> HBIMCCJEPGN(long MCHADGEKOOE, DLGKDAMPLFB ICKIDDAKBIJ, FPPCIOMIKDM LBHJIFABJPL, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x67F8D30", Offset = "0x67F8130", VA = "0x1867F8D30")]
	[AsyncStateMachine(typeof(COPLLKOBEKF))]
	private Task LPGHONKNJGG(FPPCIOMIKDM LBHJIFABJPL, IEnumerable<PersistenceView> OIAKODKFAFN, StringBuilder JGKODAIFHLM, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x67F8400", Offset = "0x67F7800", VA = "0x1867F8400")]
	private HIIJCKKCKNI JKCNFFAJGJO(long MCHADGEKOOE, DLGKDAMPLFB ICKIDDAKBIJ, FPPCIOMIKDM LBHJIFABJPL, IEnumerable<PersistenceView> OIAKODKFAFN, StringBuilder JGKODAIFHLM)
	{
		return default(HIIJCKKCKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x67F8E70", Offset = "0x67F8270", VA = "0x1867F8E70")]
	private DFCHLNBLLMO MIMBECGJBFP(long MCHADGEKOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x67F81B0", Offset = "0x67F75B0", VA = "0x1867F81B0")]
	private void JDIEPPGMHMD(DFCHLNBLLMO FBIGDMFDBBA, StringBuilder JGKODAIFHLM, IEnumerable<PersistenceView> OIAKODKFAFN, [In] IICOAABLFHH BFEHAALLCJO, LJPIAMHJCPP LGHBEFJDOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x67F8890", Offset = "0x67F7C90", VA = "0x1867F8890")]
	private void KMHNMJBFLOO(DFCHLNBLLMO FBIGDMFDBBA, StringBuilder JGKODAIFHLM, PersistenceView GLNMJKHJCBJ, LJPIAMHJCPP LGHBEFJDOKO, [In] IICOAABLFHH BFEHAALLCJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class ACMCFLCAALH : FCFMHLOGGLC
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class OJENLPDAHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public EDCNEGNOIKF.NAJJHGMOFOL roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OJENLPDAHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6807E60", Offset = "0x6807260", VA = "0x186807E60")]
		internal object KIODHGOKOOD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct IAIHJOCMJCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public AsyncTaskMethodBuilder<(EDCNEGNOIKF.NAJJHGMOFOL roomDataUpload, EDCNEGNOIKF.NAJJHGMOFOL subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public HIIJCKKCKNI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public ACMCFLCAALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private OJENLPDAHDJ <>8__1;

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
		private TaskAwaiter<EDCNEGNOIKF.NAJJHGMOFOL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x67FD540", Offset = "0x67FC940", VA = "0x1867FD540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x67FDD80", Offset = "0x67FD180", VA = "0x1867FDD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct IIBODNMBOMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public AsyncTaskMethodBuilder<GDPFOGKLBJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public ACMCFLCAALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public HIIJCKKCKNI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public DJFGIDMDALL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<(EDCNEGNOIKF.NAJJHGMOFOL roomDataUpload, EDCNEGNOIKF.NAJJHGMOFOL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<GDPFOGKLBJD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x67FE4D0", Offset = "0x67FD8D0", VA = "0x1867FE4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x67FEAF0", Offset = "0x67FDEF0", VA = "0x1867FEAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct PNBGJIHNEGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder<JKFEJAMDBHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public ACMCFLCAALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public HIIJCKKCKNI roomSerializedData;

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
		private TaskAwaiter<(EDCNEGNOIKF.NAJJHGMOFOL roomDataUpload, EDCNEGNOIKF.NAJJHGMOFOL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter<JKFEJAMDBHK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x68087E0", Offset = "0x6807BE0", VA = "0x1868087E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6808C00", Offset = "0x6808000", VA = "0x186808C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class OJOEJJFHIFI
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
			public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public OJOEJJFHIFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private ELOCCADIICN <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private TaskAwaiter<JKFEJAMDBHK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private TaskAwaiter<GDPFOGKLBJD> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<ELOCCADIICN> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x68097B0", Offset = "0x6808BB0", VA = "0x1868097B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x680A740", Offset = "0x6809B40", VA = "0x18680A740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public ACMCFLCAALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public HIIJCKKCKNI roomSerializedData;

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
		public DJFGIDMDALL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public OKNMINIJBMC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public OJOEJJFHIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x6807EB0", Offset = "0x68072B0", VA = "0x186807EB0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<ELOCCADIICN> OLHEHOPICMC(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct JCMHELMOIIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public AsyncTaskMethodBuilder<ELOCCADIICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public ACMCFLCAALH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public HIIJCKKCKNI roomSerializedData;

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
		public DJFGIDMDALL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public OKNMINIJBMC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public OHKLINEMLLN<string>.IECBLACBOCC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter<ELOCCADIICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x6800360", Offset = "0x67FF760", VA = "0x186800360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x6800670", Offset = "0x67FFA70", VA = "0x186800670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly GFLOJPOFOAD HHCNNGLILHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly ADKCECMHKHB EDFMCFIHBIF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private HDAJFOAIBMP AKNNAABMGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x67E0890", Offset = "0x67DFC90", VA = "0x1867E0890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x67F13F0", Offset = "0x67F07F0", VA = "0x1867F13F0")]
	public ACMCFLCAALH(IKKONDAGOHO CDDFHKFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x67F0F00", Offset = "0x67F0300", VA = "0x1867F0F00")]
	[AsyncStateMachine(typeof(IAIHJOCMJCB))]
	private Task<(EDCNEGNOIKF.NAJJHGMOFOL, EDCNEGNOIKF.NAJJHGMOFOL)> CEAJGIFDDCK(HIIJCKKCKNI KNIDFNGMNCI, long NIJFNKBIOIC, long LFGAFDMLOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x67F0D90", Offset = "0x67F0190", VA = "0x1867F0D90")]
	[AsyncStateMachine(typeof(IIBODNMBOMH))]
	public Task<GDPFOGKLBJD> BBDGDJEEOEG(int CNFILGPEFON, [CanBeNull] DJFGIDMDALL JIKFJKFOCPO, HIIJCKKCKNI KNIDFNGMNCI, long NIJFNKBIOIC, long LFGAFDMLOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x67F11E0", Offset = "0x67F05E0", VA = "0x1867F11E0")]
	[AsyncStateMachine(typeof(PNBGJIHNEGD))]
	private Task<JKFEJAMDBHK> JODOHLNBLNH(string PDFKPGNALBH, int CNFILGPEFON, HIIJCKKCKNI KNIDFNGMNCI, long NIJFNKBIOIC, long LFGAFDMLOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x67F1040", Offset = "0x67F0440", VA = "0x1867F1040")]
	[AsyncStateMachine(typeof(JCMHELMOIIF))]
	public Task<ELOCCADIICN> EECCJPGINIP(int CNFILGPEFON, DJFGIDMDALL? JIKFJKFOCPO, HIIJCKKCKNI KNIDFNGMNCI, long NIJFNKBIOIC, long LFGAFDMLOJL, OKNMINIJBMC OOPNPHJKGEA, OHKLINEMLLN<string>.IECBLACBOCC IBNAGADDIBG, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class NGBPBGKKJDH<T> where T : NGBPBGKKJDH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	internal readonly HDAJFOAIBMP DDPAMJJNGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private int? GLDKLLLEMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	protected readonly Guid CHLMCJEOFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	protected readonly EEPIJJHADBF NKFGNGGBPEG;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	protected T OBFPICLCOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x3FACC00", Offset = "0x3FAC000", VA = "0x183FACC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3FACE10", Offset = "0x3FAC210", VA = "0x183FACE10")]
	internal NGBPBGKKJDH(HDAJFOAIBMP CKEGOOFMDOP, EEPIJJHADBF PGJAEKOINFD, [Optional] Guid? FHLPBMFOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x3FACB20", Offset = "0x3FABF20", VA = "0x183FACB20")]
	private ELOCCADIICN JACMPCHMHLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	protected virtual void PGDPDFAKJEA(ELOCCADIICN JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x3FACA30", Offset = "0x3FABE30", VA = "0x183FACA30")]
	public T CEGJACNBFDH(MKFCBDEMMMH PFIBGBIOJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3FACC60", Offset = "0x3FAC060", VA = "0x183FACC60")]
	public T LGDPHPNDIMP(int EICEFAKNDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x3FACCF0", Offset = "0x3FAC0F0", VA = "0x183FACCF0", Slot = "5")]
	public virtual Task<OAHKKLBHOHO> OEKADKGHHEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class KKOIEOKNBDO : NGBPBGKKJDH<KKOIEOKNBDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private MAIDGDACGFA KJOCNIDJGCN;

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x6802C20", Offset = "0x6802020", VA = "0x186802C20")]
	internal KKOIEOKNBDO(HDAJFOAIBMP CKEGOOFMDOP, EEPIJJHADBF PGJAEKOINFD, [Optional] Guid? FHLPBMFOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E490", Offset = "0x5E1D890", VA = "0x185E1E490")]
	public KKOIEOKNBDO HKAIDAPFIPJ(MAIDGDACGFA KJOCNIDJGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6802B50", Offset = "0x6801F50", VA = "0x186802B50", Slot = "4")]
	protected override void PGDPDFAKJEA(ELOCCADIICN JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class CNEDJPIGEAE : NGBPBGKKJDH<CNEDJPIGEAE>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum ABCMJDOPDEF
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
	private struct MPMGJAMDEGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public AsyncTaskMethodBuilder<OAHKKLBHOHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public CNEDJPIGEAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private TaskAwaiter<OAHKKLBHOHO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x6803960", Offset = "0x6802D60", VA = "0x186803960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x6803D10", Offset = "0x6803110", VA = "0x186803D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private ABCMJDOPDEF PCHCGHBPGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private string JMBFNDOFEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private DJFGIDMDALL KJOCNIDJGCN;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x67F30B0", Offset = "0x67F24B0", VA = "0x1867F30B0")]
	internal CNEDJPIGEAE(HDAJFOAIBMP CKEGOOFMDOP, EEPIJJHADBF PGJAEKOINFD, [Optional] Guid? FHLPBMFOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x67F2DC0", Offset = "0x67F21C0", VA = "0x1867F2DC0")]
	public CNEDJPIGEAE JDMJFCBPMJN(string INBGNCKHOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x67F2E30", Offset = "0x67F2230", VA = "0x1867F2E30")]
	public CNEDJPIGEAE NKKMKONOEHJ(bool PNBNFCDLDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2D90", Offset = "0x67F2190", VA = "0x1867F2D90")]
	public CNEDJPIGEAE FEDPLOKOJAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x67F2F40", Offset = "0x67F2340", VA = "0x1867F2F40", Slot = "4")]
	protected override void PGDPDFAKJEA(ELOCCADIICN JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x67F2E50", Offset = "0x67F2250", VA = "0x1867F2E50", Slot = "5")]
	[AsyncStateMachine(typeof(MPMGJAMDEGL))]
	public override Task<OAHKKLBHOHO> OEKADKGHHEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x67F2DF0", Offset = "0x67F21F0", VA = "0x1867F2DF0")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<OAHKKLBHOHO> KPGKPCGFPOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class PFBCFIEKGPF
{
	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x6808690", Offset = "0x6807A90", VA = "0x186808690")]
	public static void EKKCMOHDAPF(this APKMLFOLCPD AKEDMBAOFEH, DHOCBLKANBD BGEILFIILNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x6808610", Offset = "0x6807A10", VA = "0x186808610")]
	public static void AONPMHNJAEC(this DHOCBLKANBD MJFKEABMNNE, [Optional] string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class FGMCDJCFNDC
{
	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x67F7630", Offset = "0x67F6A30", VA = "0x1867F7630")]
	public static LOEJPFELMNK GECOJLFGNAF(this HPJECBAGNGE ONOPFOGHECJ)
	{
		return default(LOEJPFELMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x67F76D0", Offset = "0x67F6AD0", VA = "0x1867F76D0")]
	public static HPJECBAGNGE IMEBFFAGPPF(this LOEJPFELMNK DCNJLGOLOOC)
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
			public DCLBCJCFNBK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public DCLBCJCFNBK HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private static DCLBCJCFNBK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private Dictionary<DCLBCJCFNBK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x680B6D0", Offset = "0x680AAD0", VA = "0x18680B6D0")]
		public bool PAPFOCGKOLA(DCLBCJCFNBK LNDLANKAKCO, [Out] ResultConfig GLPHPNDFKED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x680AE40", Offset = "0x680A240", VA = "0x18680AE40")]
		public ResultConfig KAOBKINJEJH(DCLBCJCFNBK HOKIEGJILGD, [Optional] HashSet<DCLBCJCFNBK> JHJIKHLOPMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x680B4E0", Offset = "0x680A8E0", VA = "0x18680B4E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x680AF80", Offset = "0x680A380", VA = "0x18680AF80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8A68F0", Offset = "0x8A5CF0", VA = "0x1808A68F0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class JLJBAFMDHGN
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x6801870", Offset = "0x6800C70", VA = "0x186801870")]
	[AMCIKKJLCIB(HENHDGEOMOC.GameOnly)]
	private static void ICLFDKDIFAJ(BNDLKDEPBDF PLABOMGPCLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface AFFLFHNACKH : IEquatable<AFFLFHNACKH>
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	DateTime DPMMCKIJPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGMNJDJDPIF();

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AHFLKOJNPGB(long NIJFNKBIOIC, long MCHADGEKOOE, [Out] HIIJCKKCKNI KNIDFNGMNCI);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class DJPOIODOJAP : AFOBECLHLDG
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class KKINJDMIDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public PKLFHHDPKAE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public KKINJDMIDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x6802AE0", Offset = "0x6801EE0", VA = "0x186802AE0")]
		internal object ADLFNEGMMJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private readonly GECIOHDEKNG NEPAGDIAKKD;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<AFFLFHNACKH> CMHGHKHFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x67F4B40", Offset = "0x67F3F40", VA = "0x1867F4B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x67F4A90", Offset = "0x67F3E90", VA = "0x1867F4A90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	[UnityEngine.Scripting.Preserve]
	public DJPOIODOJAP([AKGMOFMFNCG(null)] GECIOHDEKNG NEPAGDIAKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x67F4680", Offset = "0x67F3A80", VA = "0x1867F4680", Slot = "6")]
	public bool HDHHCNMJNBC(long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI, PKLFHHDPKAE NBONEADNIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x1A1F350", Offset = "0x1A1E750", VA = "0x181A1F350")]
	private void JBEIIALJINO(AFFLFHNACKH MLAICGADNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x67F4BF0", Offset = "0x67F3FF0", VA = "0x1867F4BF0", Slot = "7")]
	public bool PDLMCAJNEAB(long NIJFNKBIOIC, long MCHADGEKOOE, [Out] AFFLFHNACKH DONGLMJPIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x67F45D0", Offset = "0x67F39D0", VA = "0x1867F45D0", Slot = "8")]
	public bool ENODKNBBCAL(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, [Out] AFFLFHNACKH DONGLMJPIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x67F41A0", Offset = "0x67F35A0", VA = "0x1867F41A0")]
	private void EDOFJMJMNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x67F4960", Offset = "0x67F3D60", VA = "0x1867F4960", Slot = "9")]
	public void HEIOLGIMALG(long NIJFNKBIOIC, long MCHADGEKOOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class HDEADMNFBHC : GECIOHDEKNG
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum CBPEFJNJDLG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class LKHLBHFLAKM : IEnumerable<AFFLFHNACKH>, IEnumerable, IEnumerator<AFFLFHNACKH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private AFFLFHNACKH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public HDEADMNFBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private PKLFHHDPKAE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public PKLFHHDPKAE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private AFFLFHNACKH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x818520", Offset = "0x817920", VA = "0x180818520")]
		[DebuggerHidden]
		public LKHLBHFLAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6803360", Offset = "0x6802760", VA = "0x186803360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6803640", Offset = "0x6802A40", VA = "0x186803640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6803590", Offset = "0x6802990", VA = "0x186803590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AFFLFHNACKH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6803590", Offset = "0x6802990", VA = "0x186803590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class DNIPLHINPGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public PKLFHHDPKAE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DNIPLHINPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x67F5CC0", Offset = "0x67F50C0", VA = "0x1867F5CC0")]
		internal object APNMOLABFCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class JFFBLNLHDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public HDEADMNFBHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public JFFBLNLHDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6800EB0", Offset = "0x68002B0", VA = "0x186800EB0")]
		internal void IMNKEICPCCK(BNCIMBLGEMF.IGKEKAIIPLL ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	protected readonly string LNBMHKFNMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private readonly object GBPBDHHLLDO;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract IHAMABPNILI LLNHDGFJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x67FB390", Offset = "0x67FA790", VA = "0x1867FB390")]
	protected HDEADMNFBHC([CanBeNull] string JJLFNNOKEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x67FADA0", Offset = "0x67FA1A0", VA = "0x1867FADA0", Slot = "5")]
	public bool DEOOCPDPCFJ(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, [Out] AFFLFHNACKH MLAICGADNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x67FA990", Offset = "0x67F9D90", VA = "0x1867FA990", Slot = "6")]
	[IteratorStateMachine(typeof(LKHLBHFLAKM))]
	public IEnumerable<AFFLFHNACKH> BPMECCGBNEH(PKLFHHDPKAE NBONEADNIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FOLDOGLMNMH(Stream LMNICMHMKHM, long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool PBDLMELFNPN(Stream KAMDBJJOCLN, long NIJFNKBIOIC, long MCHADGEKOOE, GNBFHFKLIIP ALJDLEPMAAC, [Out] HIIJCKKCKNI KNIDFNGMNCI);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x67FAA20", Offset = "0x67F9E20", VA = "0x1867FAA20", Slot = "7")]
	public AFFLFHNACKH DCMKBMDOEFH(long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI, PKLFHHDPKAE NBONEADNIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GINFHDBIOAL(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, CBPEFJNJDLG MHCDKFLJDHF);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LGFKMCCMEAB(PKLFHHDPKAE NBONEADNIAK, CBPEFJNJDLG MHCDKFLJDHF);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x67FB320", Offset = "0x67FA720", VA = "0x1867FB320")]
	protected void IIOGEDDACJP(BNCIMBLGEMF.IGKEKAIIPLL DPACGPCPMJJ, string MJDNKBBGCEF, FileInfo BFBEDPDGOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x67FAF90", Offset = "0x67FA390", VA = "0x1867FAF90")]
	internal bool GPOEOCMFEGN(FileInfo OFNMJIEJNLO, long NIJFNKBIOIC, long MCHADGEKOOE, [Out] HIIJCKKCKNI KNIDFNGMNCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private void BHGCCEGJKHI(Exception IJGEEAMFAPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class NFDIIHDDJME : HDEADMNFBHC
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override IHAMABPNILI LLNHDGFJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xACA0C0", Offset = "0xAC94C0", VA = "0x180ACA0C0", Slot = "8")]
		get
		{
			return default(IHAMABPNILI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6805270", Offset = "0x6804670", VA = "0x186805270")]
	public NFDIIHDDJME([Optional] string JJLFNNOKEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x6804A90", Offset = "0x6803E90", VA = "0x186804A90")]
	private void IBFJFGNPHNM(PKLFHHDPKAE NBONEADNIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x6804710", Offset = "0x6803B10", VA = "0x186804710", Slot = "9")]
	internal override void FOLDOGLMNMH(Stream LMNICMHMKHM, long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6804C20", Offset = "0x6804020", VA = "0x186804C20", Slot = "10")]
	internal override bool PBDLMELFNPN(Stream KAMDBJJOCLN, long NIJFNKBIOIC, long MCHADGEKOOE, GNBFHFKLIIP ALJDLEPMAAC, [Out] HIIJCKKCKNI KNIDFNGMNCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x68049A0", Offset = "0x6803DA0", VA = "0x1868049A0", Slot = "11")]
	protected override FileInfo GINFHDBIOAL(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, CBPEFJNJDLG MHCDKFLJDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x6804B10", Offset = "0x6803F10", VA = "0x186804B10", Slot = "12")]
	protected override DirectoryInfo LGFKMCCMEAB(PKLFHHDPKAE NBONEADNIAK, CBPEFJNJDLG MHCDKFLJDHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class HMKFDCKNPEC : HDEADMNFBHC
{
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private static readonly byte[] NIOPCMHKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private readonly byte[] LCFINFGMPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly byte[] LKJIMJMEJKF;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override IHAMABPNILI LLNHDGFJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x56D82B0", Offset = "0x56D76B0", VA = "0x1856D82B0", Slot = "8")]
		get
		{
			return default(IHAMABPNILI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x67FD3E0", Offset = "0x67FC7E0", VA = "0x1867FD3E0")]
	public HMKFDCKNPEC([Optional] string JJLFNNOKEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x67FC620", Offset = "0x67FBA20", VA = "0x1867FC620", Slot = "9")]
	internal override void FOLDOGLMNMH(Stream LMNICMHMKHM, long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x67FCB20", Offset = "0x67FBF20", VA = "0x1867FCB20", Slot = "10")]
	internal override bool PBDLMELFNPN(Stream KAMDBJJOCLN, long NIJFNKBIOIC, long MCHADGEKOOE, GNBFHFKLIIP ALJDLEPMAAC, [Out] HIIJCKKCKNI KNIDFNGMNCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x67FC560", Offset = "0x67FB960", VA = "0x1867FC560")]
	private void FCAKAFLCLFJ(byte[] GHDDMAGGOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x67FC8E0", Offset = "0x67FBCE0", VA = "0x1867FC8E0", Slot = "11")]
	protected override FileInfo GINFHDBIOAL(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, CBPEFJNJDLG MHCDKFLJDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x67FCA10", Offset = "0x67FBE10", VA = "0x1867FCA10", Slot = "12")]
	protected override DirectoryInfo LGFKMCCMEAB(PKLFHHDPKAE NBONEADNIAK, CBPEFJNJDLG MHCDKFLJDHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum IHAMABPNILI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class FNJFJLPMEHM : GECIOHDEKNG
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class EMHCLFHNHJG : IEnumerable<AFFLFHNACKH>, IEnumerable, IEnumerator<AFFLFHNACKH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private AFFLFHNACKH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public FNJFJLPMEHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private PKLFHHDPKAE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public PKLFHHDPKAE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private IHAMABPNILI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private IEnumerator<AFFLFHNACKH> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private AFFLFHNACKH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x818520", Offset = "0x817920", VA = "0x180818520")]
		[DebuggerHidden]
		public EMHCLFHNHJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x67F68A0", Offset = "0x67F5CA0", VA = "0x1867F68A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x67F64C0", Offset = "0x67F58C0", VA = "0x1867F64C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x67F6470", Offset = "0x67F5870", VA = "0x1867F6470")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x67F6850", Offset = "0x67F5C50", VA = "0x1867F6850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x67F67A0", Offset = "0x67F5BA0", VA = "0x1867F67A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AFFLFHNACKH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x67F67A0", Offset = "0x67F5BA0", VA = "0x1867F67A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private readonly IHAMABPNILI[] KJGOPPOEKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private readonly Dictionary<IHAMABPNILI, GECIOHDEKNG> NEONNFLDOCO;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public IHAMABPNILI LLNHDGFJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x67F7AB0", Offset = "0x67F6EB0", VA = "0x1867F7AB0", Slot = "4")]
		get
		{
			return default(IHAMABPNILI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x67F7D00", Offset = "0x67F7100", VA = "0x1867F7D00")]
	[UnityEngine.Scripting.Preserve]
	public FNJFJLPMEHM(params GECIOHDEKNG[] IHHKDIGEBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x67F7960", Offset = "0x67F6D60", VA = "0x1867F7960", Slot = "5")]
	public bool DEOOCPDPCFJ(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, [Out] AFFLFHNACKH MLAICGADNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x67F7AE0", Offset = "0x67F6EE0", VA = "0x1867F7AE0")]
	private void MDMLKJIKEAM(int JCOJOEFIMLL, long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x67F77F0", Offset = "0x67F6BF0", VA = "0x1867F77F0", Slot = "6")]
	[IteratorStateMachine(typeof(EMHCLFHNHJG))]
	public IEnumerable<AFFLFHNACKH> BPMECCGBNEH(PKLFHHDPKAE NBONEADNIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x67F7880", Offset = "0x67F6C80", VA = "0x1867F7880", Slot = "7")]
	public AFFLFHNACKH DCMKBMDOEFH(long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI, PKLFHHDPKAE NBONEADNIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class KEFMFHHAPCK
{
	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6802A20", Offset = "0x6801E20", VA = "0x186802A20")]
	internal static byte[] PDBMEANDKEK(byte[] GHDDMAGGOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x68027C0", Offset = "0x6801BC0", VA = "0x1868027C0")]
	public static void DDIBMJNEGBL(Stream KOJLMFPHKCH, byte[] KNLFAHCHCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6802840", Offset = "0x6801C40", VA = "0x186802840")]
	public static bool IENKNLNFOKG(Stream KOJLMFPHKCH, long JNGJBPCIAEF, GNBFHFKLIIP EHCDCFMMKIM, [Out] byte[] DHMPLLDMMJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class FDILMGGDMBI : AFFLFHNACKH, IEquatable<AFFLFHNACKH>, IEquatable<FDILMGGDMBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private readonly HDEADMNFBHC LFPLBBIMDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	public readonly FileInfo NGHFKMBILIP;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IHAMABPNILI LLNHDGFJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x1F76980", Offset = "0x1F75D80", VA = "0x181F76980", Slot = "9")]
		get
		{
			return default(IHAMABPNILI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DateTime DPMMCKIJPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x67F73E0", Offset = "0x67F67E0", VA = "0x1867F73E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x67F7520", Offset = "0x67F6920", VA = "0x1867F7520")]
	public FDILMGGDMBI(HDEADMNFBHC HCICELIMAPN, FileInfo OFNMJIEJNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x67F7470", Offset = "0x67F6870", VA = "0x1867F7470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x67F7320", Offset = "0x67F6720", VA = "0x1867F7320", Slot = "5")]
	public void OGMNJDJDPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x67F6FC0", Offset = "0x67F63C0", VA = "0x1867F6FC0", Slot = "6")]
	public bool AHFLKOJNPGB(long NIJFNKBIOIC, long MCHADGEKOOE, [Out] HIIJCKKCKNI KNIDFNGMNCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x67F7000", Offset = "0x67F6400", VA = "0x1867F7000", Slot = "7")]
	public bool Equals(AFFLFHNACKH MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x67F70E0", Offset = "0x67F64E0", VA = "0x1867F70E0", Slot = "8")]
	public bool Equals(FDILMGGDMBI MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x67F71A0", Offset = "0x67F65A0", VA = "0x1867F71A0", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x67F7290", Offset = "0x67F6690", VA = "0x1867F7290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void GNBFHFKLIIP(BNCIMBLGEMF.IGKEKAIIPLL LABPMGAHGPK, string JEBCFBFPEMG);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface GECIOHDEKNG
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	IHAMABPNILI LLNHDGFJJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEOOCPDPCFJ(long NIJFNKBIOIC, long MCHADGEKOOE, PKLFHHDPKAE NBONEADNIAK, [Out] AFFLFHNACKH MLAICGADNKB);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<AFFLFHNACKH> BPMECCGBNEH(PKLFHHDPKAE NBONEADNIAK);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AFFLFHNACKH DCMKBMDOEFH(long NIJFNKBIOIC, long MCHADGEKOOE, HIIJCKKCKNI KNIDFNGMNCI, PKLFHHDPKAE NBONEADNIAK);
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
