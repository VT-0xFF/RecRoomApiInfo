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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x680EB00", Offset = "0x680DD00", VA = "0x18680EB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
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
	public class LogRegistrationIndex : PDIMPOELJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x680AE10", Offset = "0x680A010", VA = "0x18680AE10", Slot = "4")]
		public override void FPMBLPAHIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GEMCAHDJAMI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67FD5A0", Offset = "0x67FC7A0", VA = "0x1867FD5A0")]
	public GEMCAHDJAMI(string JGNAJPMGGNE, Exception EBFLENHEHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class IHOFIGOOBAB : HIHHFAMODEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MHEBCKCKAKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DNGPLKGKBEJ>> <>t__builder;

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
		private TaskAwaiter<OPJLHGFBAJG<DNGPLKGKBEJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x680B520", Offset = "0x680A720", VA = "0x18680B520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x680B760", Offset = "0x680A960", VA = "0x18680B760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NKLLAGHMEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GNMKJNABJNN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<GNMKJNABJNN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x680D920", Offset = "0x680CB20", VA = "0x18680D920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x680DB30", Offset = "0x680CD30", VA = "0x18680DB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	[UnityEngine.Scripting.Preserve]
	public IHOFIGOOBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6802F40", Offset = "0x6802140", VA = "0x186802F40", Slot = "4")]
	[AsyncStateMachine(typeof(MHEBCKCKAKM))]
	public Task<IReadOnlyList<DNGPLKGKBEJ>> KFGBEMHEDAN(long NCFOOPOBBIJ, long DIKKNIGACBL, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6802E30", Offset = "0x6802030", VA = "0x186802E30", Slot = "5")]
	[AsyncStateMachine(typeof(NKLLAGHMEKN))]
	public Task<IReadOnlyList<GNMKJNABJNN>> FODFGCNJCPH(IReadOnlyList<int> ELBPKKFJBBB, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AAPHNHBMHEE : IEquatable<AAPHNHBMHEE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HEFOLCHIGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	GNMKJNABJNN ICFALNBJFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime FIPLMBAJEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CCJLLABHMJD? MIAEGNLIPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BCCEMDPIGNO? NAKPPKNJDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	EENAJGHMLEG DPAGCBKMPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CLBPNGLMFHJ> FBMOBCPJOEL();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum EENAJGHMLEG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HIHHFAMODEB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DNGPLKGKBEJ>> KFGBEMHEDAN(long NCFOOPOBBIJ, long DIKKNIGACBL, [Optional] CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<GNMKJNABJNN>> FODFGCNJCPH(IReadOnlyList<int> ELBPKKFJBBB, [Optional] CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NFBNEDAMIJE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HLMGCOOPLNI : AAPHNHBMHEE, IEquatable<AAPHNHBMHEE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct GAKLCEKJJKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HLMGCOOPLNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private CBNCHNAGNCI <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<NHHLGHBJLHK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CLBPNGLMFHJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67FBDA0", Offset = "0x67FAFA0", VA = "0x1867FBDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x67FC240", Offset = "0x67FB440", VA = "0x1867FC240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DNGPLKGKBEJ NLDAFOJCMAP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HEFOLCHIGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GNMKJNABJNN ICFALNBJFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime KIENCNJMEPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x54959C0", Offset = "0x5494BC0", VA = "0x1854959C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CCJLLABHMJD? MIAEGNLIPHC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D060", Offset = "0x1A5C260", VA = "0x181A5D060", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BCCEMDPIGNO? NAKPPKNJDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5495AA0", Offset = "0x5494CA0", VA = "0x185495AA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EENAJGHMLEG DPAGCBKMPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "10")]
			get
			{
				return default(EENAJGHMLEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67FD9E0", Offset = "0x67FCBE0", VA = "0x1867FD9E0", Slot = "9")]
		[AsyncStateMachine(typeof(GAKLCEKJJKO))]
		public Task<CLBPNGLMFHJ> FBMOBCPJOEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67FDBA0", Offset = "0x67FCDA0", VA = "0x1867FDBA0")]
		public HLMGCOOPLNI(int IADJMNBFLHH, GNMKJNABJNN NKGADIMGPNK, DNGPLKGKBEJ NLDAFOJCMAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67FD8B0", Offset = "0x67FCAB0", VA = "0x1867FD8B0", Slot = "11")]
		public bool Equals(AAPHNHBMHEE NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67FD940", Offset = "0x67FCB40", VA = "0x1867FD940", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67FDB60", Offset = "0x67FCD60", VA = "0x1867FDB60")]
		private bool OBFOLHCPHCD(HLMGCOOPLNI NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67FDAE0", Offset = "0x67FCCE0", VA = "0x1867FDAE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class GEHFJOOAKLA : AAPHNHBMHEE, IEquatable<AAPHNHBMHEE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct HAHCECLMOJP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GEHFJOOAKLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<CLBPNGLMFHJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67FD610", Offset = "0x67FC810", VA = "0x1867FD610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67FD840", Offset = "0x67FCA40", VA = "0x1867FD840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly OBBCDGFHJBJ NEABJMEFIPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly CCJLLABHMJD LKMFCKHILOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly BCCEMDPIGNO CBDHKLJFLPB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HEFOLCHIGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x67FD420", Offset = "0x67FC620", VA = "0x1867FD420", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GNMKJNABJNN ICFALNBJFIM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x67FD460", Offset = "0x67FC660", VA = "0x1867FD460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime KIENCNJMEPA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x67FD0C0", Offset = "0x67FC2C0", VA = "0x1867FD0C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CCJLLABHMJD? MIAEGNLIPHC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x67FD4F0", Offset = "0x67FC6F0", VA = "0x1867FD4F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BCCEMDPIGNO? NAKPPKNJDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x67FD350", Offset = "0x67FC550", VA = "0x1867FD350", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EENAJGHMLEG DPAGCBKMPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9157A0", Offset = "0x9149A0", VA = "0x1809157A0", Slot = "10")]
			get
			{
				return default(EENAJGHMLEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xED5F60", Offset = "0xED5160", VA = "0x180ED5F60")]
		public GEHFJOOAKLA(OBBCDGFHJBJ AMFIFOBJCGP, CCJLLABHMJD KEIKKJOAGJA, BCCEMDPIGNO OFFPJDIOIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67FD260", Offset = "0x67FC460", VA = "0x1867FD260", Slot = "9")]
		[AsyncStateMachine(typeof(HAHCECLMOJP))]
		public Task<CLBPNGLMFHJ> FBMOBCPJOEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67FD1C0", Offset = "0x67FC3C0", VA = "0x1867FD1C0", Slot = "11")]
		public bool Equals(AAPHNHBMHEE NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67FD110", Offset = "0x67FC310", VA = "0x1867FD110", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67FD540", Offset = "0x67FC740", VA = "0x1867FD540")]
		private bool OBFOLHCPHCD(GEHFJOOAKLA NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67FD3A0", Offset = "0x67FC5A0", VA = "0x1867FD3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MEGLICBEOOF : AAPHNHBMHEE, IEquatable<AAPHNHBMHEE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct OELEFOFKGED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<CLBPNGLMFHJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x680EB80", Offset = "0x680DD80", VA = "0x18680EB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x680EDC0", Offset = "0x680DFC0", VA = "0x18680EDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly GNMKJNABJNN GBEMGDEKIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CCJLLABHMJD LKMFCKHILOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly BCCEMDPIGNO CBDHKLJFLPB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HEFOLCHIGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x680B3D0", Offset = "0x680A5D0", VA = "0x18680B3D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public GNMKJNABJNN ICFALNBJFIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime KIENCNJMEPA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public CCJLLABHMJD? MIAEGNLIPHC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x680B3F0", Offset = "0x680A5F0", VA = "0x18680B3F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BCCEMDPIGNO? NAKPPKNJDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x680B2F0", Offset = "0x680A4F0", VA = "0x18680B2F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EENAJGHMLEG DPAGCBKMPOB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "10")]
			get
			{
				return default(EENAJGHMLEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xED5F60", Offset = "0xED5160", VA = "0x180ED5F60")]
		public MEGLICBEOOF(GNMKJNABJNN NKGADIMGPNK, CCJLLABHMJD KEIKKJOAGJA, BCCEMDPIGNO OFFPJDIOIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x680B220", Offset = "0x680A420", VA = "0x18680B220", Slot = "9")]
		[AsyncStateMachine(typeof(OELEFOFKGED))]
		public Task<CLBPNGLMFHJ> FBMOBCPJOEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x680B110", Offset = "0x680A310", VA = "0x18680B110", Slot = "11")]
		public bool Equals(AAPHNHBMHEE NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x680AFF0", Offset = "0x680A1F0", VA = "0x18680AFF0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x680B340", Offset = "0x680A540", VA = "0x18680B340", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x680B440", Offset = "0x680A640", VA = "0x18680B440")]
		private bool OBFOLHCPHCD(MEGLICBEOOF NOBJAPGNDAK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MNBKMEBCHFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<AAPHNHBMHEE>> <>t__builder;

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
		public NFBNEDAMIJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<DNGPLKGKBEJ> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<DNGPLKGKBEJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, GNMKJNABJNN account, DNGPLKGKBEJ roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x680B7D0", Offset = "0x680A9D0", VA = "0x18680B7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x680C670", Offset = "0x680B870", VA = "0x18680C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JEGDBODAHPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, GNMKJNABJNN account, DNGPLKGKBEJ roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<DNGPLKGKBEJ> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NFBNEDAMIJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<GNMKJNABJNN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6804560", Offset = "0x6803760", VA = "0x186804560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6804F20", Offset = "0x6804120", VA = "0x186804F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CLLJHGEAHLJ FJDGAILHHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HIHHFAMODEB ELBPHEMPMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LLKJAJLMJGE LFHHAFLBCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly AHINDIHIDML<(long, long), IReadOnlyList<DNGPLKGKBEJ>> IMLOABBMAFF;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x680D710", Offset = "0x680C910", VA = "0x18680D710")]
	[UnityEngine.Scripting.Preserve]
	public NFBNEDAMIJE([GAGPBLHNPNO(null)] HIHHFAMODEB LMAOEEMGGNM, [GAGPBLHNPNO(null)] LLKJAJLMJGE GIOODPNLOOP, [GAGPBLHNPNO(null)] CLLJHGEAHLJ OBAKBOBOBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x680D5C0", Offset = "0x680C7C0", VA = "0x18680D5C0")]
	[AsyncStateMachine(typeof(MNBKMEBCHFO))]
	public Task<IList<AAPHNHBMHEE>> OHPADLDAKAA(long NCFOOPOBBIJ, long PFDCKFHEHAO, bool JLCBHPMCMAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x680D310", Offset = "0x680C510", VA = "0x18680D310")]
	private bool ALMAIJPEMGH(DateTime? JGBEKBDAHFJ, long NCFOOPOBBIJ, long PFDCKFHEHAO, [Out] OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x680D4B0", Offset = "0x680C6B0", VA = "0x18680D4B0")]
	[AsyncStateMachine(typeof(JEGDBODAHPM))]
	private Task<IReadOnlyList<(int, GNMKJNABJNN, DNGPLKGKBEJ)>> BMNBNNPCBDE(IReadOnlyList<DNGPLKGKBEJ> DJNCMDFLDJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LLKJAJLMJGE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OBBCDGFHJBJ> LJBHAIGIBOG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGNDEPJEIIK(long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ, EDCMFPOJOOL GBMDEGJEOMP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ANHBBBHFLMI(long NCFOOPOBBIJ, long PFDCKFHEHAO, [Out] OBBCDGFHJBJ MAMJPFLGEHH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FPDJHNKFOOF(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, [Out] OBBCDGFHJBJ MAMJPFLGEHH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPLNHNKBBJO(long NCFOOPOBBIJ, long PFDCKFHEHAO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface LKMPHPGNAPE : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HEIKDHIKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task IFLBMLGGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNLCACBDGKD(Task OCAKELEHPCL, string NHGHAKHGEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface AFAAJGFFFEK : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CLBPNGLMFHJ> DNFNDMKOJEP(OBBCDGFHJBJ MAMJPFLGEHH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EAJCJPCJKGC(CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface ICHLIAAGBAC : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NICLHLHNPCI ILFDKCDHKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNDIBFPIMPH();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCLGAGJEEKL();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface LOKHFHAIAGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface PKOGCFGFLLG
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan OCMOFIIJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan HNPHBKJLKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan FEHIJCKHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan BDJEMDOGDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CGKJIOJHBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IIMCGOIPGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool AHPJPMKMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int OEIKJMNJJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LBJBMHMOPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FNKKHIJNCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum OKHGGAMGDEA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PFBGPEMCIEN
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
public struct DENGJMMGKHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long PBEONGBFPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long DIKKNIGACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly OKHGGAMGDEA FLPJMDMACMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception LAFEJAPEAFE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x67FA540", Offset = "0x67F9740", VA = "0x1867FA540")]
	public DENGJMMGKHO(long PBEONGBFPDM, long DIKKNIGACBL, OKHGGAMGDEA FLPJMDMACMC, [CanBeNull] Exception LAFEJAPEAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x67FA4F0", Offset = "0x67F96F0", VA = "0x1867FA4F0")]
	public static DENGJMMGKHO GOFIODGEAFC(NKKGGOEDKKI DGABHPODNJN, OKHGGAMGDEA FLPJMDMACMC, [Optional] Exception LAFEJAPEAFE)
	{
		return default(DENGJMMGKHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void GNBJMIGBBBN(DENGJMMGKHO DJEBFPGKJAM);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface BIGKCCCBLEE : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AHBGJBJJDBE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GNBJMIGBBBN PHHJHIKJKMI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GNBJMIGBBBN EGCPIDLGDCA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event GNBJMIGBBBN DBFEKAKDLPL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PFBGPEMCIEN, bool> KPBOHBEIFMP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IGPEGJIHEGM();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MGGOHEPCLAE(DENGJMMGKHO DJEBFPGKJAM);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HAEAHMNCKCE(DENGJMMGKHO DJEBFPGKJAM);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EEMFMHMMGPN(DENGJMMGKHO DJEBFPGKJAM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MBHDKPCLPOJ(PFBGPEMCIEN BOPJNIDBFBF, bool KFLNBNHABLM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface LDDNAKFOCMM : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JFIFIJLGBCI();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJKOGMBFCHF();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface CNPCBBPHNOI : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus PBNIFAGBBNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HKFGECGEGDO(NKKGGOEDKKI LPFEKEJDECG, CJAOOLMNLGI LDGJAGLJFKJ, CancellationToken OJHIOEGMMDB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class BFGFBNJDLNA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67F8F90", Offset = "0x67F8190", VA = "0x1867F8F90")]
	public static bool GBPPMNEMOJM(this CNPCBBPHNOI KNHOGNCICBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task PNMKMIHGCPK(OHJENCCOGPB JENPAMGBIKD, CancellationToken FCKLPDKGPKE);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface FBOOGLCDAAH : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKJLNKCOGPF(PNMKMIHGCPK FGGBGGPDELN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface CKDPMMHNMPI : CBNCHNAGNCI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken NALJNDABKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	LEHDPNIFNIH DHEGKKCFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	OBJHGLENMNO EJOGDCOEDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NGCIKEEIICP HKMNPPFEFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	INBNEGOCKCD MDILADGECMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	MGPEOOIOMID KBIKPDBABCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HFOFKAHADJK KOGJDFOOMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FPEHBHJFGEH KAPNBILLGML
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LKMPHPGNAPE NCDPLOCKFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AFAAJGFFFEK GOLJJEPFMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BIGKCCCBLEE DAFEKECFMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LDDNAKFOCMM PKCGBGFKCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CNPCBBPHNOI DANKPHELNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FBOOGLCDAAH HDPEHIHBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	OKLELBPPKHI MJABBDAACCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MLJLCPMHFOB GMNAEELCAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KFGEKFLHNGD OPHCCECIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AIPNBMGKCEH JMNDJNMCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EOACLIOLDGJ JPGMFCKDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GCOHNJIAJNE ODNDGLOAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CPLOJIIHHMI LEIGDLDINHI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PDBCIMBKOND JHCFOGJADIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LLIFKHNFLPK EOMMMBFLILC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JMOCIPPEEOG MLFHPEIANJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	ICHLIAAGBAC EBNJHDBEPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	PKOGCFGFLLG BBPODOCIHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FOPDBDLEPNH OLDKGGLFAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LLKJAJLMJGE FJBPOFICPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IHJFPHGKHJF AKFLNCLCFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	FMEGAJMCBII DCGFPHBMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	PKBHMGEALOP OIMCIOGLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LPLJCEPIFAG(CJAOOLMNLGI GNIMGMACLNB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OKLELBPPKHI : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LKDBPCDLEIO OEOPOJPHCNL(Guid FNMGFNFDGKE);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFEEKLGJAPH(Guid FNMGFNFDGKE);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMFEPGIFFGN(Guid FNMGFNFDGKE, Task NIOOIEIKLHG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMMDBKCBAHJ(Guid FNMGFNFDGKE, CLBPNGLMFHJ CGFEHPPNPKL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(CLBPNGLMFHJ, Task)> OPBLMBBAHNL(Guid FNMGFNFDGKE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KDHIIOHAGPN : LOKHFHAIAGB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface MLJLCPMHFOB : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDCPILCNFHL(LCFKPKINCJE JGNAJPMGGNE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPHGMBKBJOP(LCFKPKINCJE JGNAJPMGGNE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ANBJHFCMHDB> NHNLJHGILOJ(CancellationToken OJCKMINAJKB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KFGEKFLHNGD : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LKDBPCDLEIO DKNFDJLGPLF(LCFKPKINCJE KFOLBIKFDLO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFCODNJONPA(Guid FNMGFNFDGKE, Task NIOOIEIKLHG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface AIPNBMGKCEH : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CLBPNGLMFHJ> JMNDJNMCDNP(LCFKPKINCJE BFKFODNNLGE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface EOACLIOLDGJ : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HGFIJEMHMDL> LCNKKOOBEMA(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, NKKGGOEDKKI LPFEKEJDECG, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface CPLOJIIHHMI : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLBPNGLMFHJ MPEDEKGIEMK(EOBANJCDGLI HACPMNFMAID);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NAKEODOMNFL(string INJNFIJDPLP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GCOHNJIAJNE : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LCFKPKINCJE> NKJMNMCFNFO(LCFKPKINCJE AIJPHINHCJO, NPDCGEHACLF NFGPOMNPCEM, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LCFKPKINCJE> JLEOKOMDMMJ(CancellationToken AIHJHMPAHCH, NPDCGEHACLF NFGPOMNPCEM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MABGKFLOIKH CEEHGHPHPOJ(JIEBELBAAKC MKFHDDOCFKJ, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MABGKFLOIKH HHLKNKMIIPP(JIEBELBAAKC MKFHDDOCFKJ, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface PDBCIMBKOND : LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLBPNGLMFHJ AFBGAMNEOBN(EOBANJCDGLI HACPMNFMAID, ANBJHFCMHDB EPNKNGICODC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CLBPNGLMFHJ HKDBNGMOCCL(EOBANJCDGLI OKOCHAOMKHH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LLIFKHNFLPK
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCKDLGNILKI(KFDNIKLJMNJ PKANBLIMKAF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPJKMEAEFGL(KFDNIKLJMNJ PKANBLIMKAF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAMDLLAHDJP(KFDNIKLJMNJ PKANBLIMKAF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFKGOCPMACJ(KFDNIKLJMNJ PKANBLIMKAF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class KFDNIKLJMNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly NKKGGOEDKKI GNDJGIKADGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> HLJAIOAIILP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OPAMPAFNBOH<string> OFIMBADIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public KFDNIKLJMNJ(NKKGGOEDKKI GNBINPCIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6806960", Offset = "0x6805B60", VA = "0x186806960")]
	public KFDNIKLJMNJ MLNJKBNIJDC(string GOBGGNLGONA, string NICEPFIEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x68068D0", Offset = "0x6805AD0", VA = "0x1868068D0")]
	public bool BKLCLJBAOKO([Out] IEnumerable<KeyValuePair<string, string>> EGPEGAHPNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B1D3F0", Offset = "0x5B1C5F0", VA = "0x185B1D3F0")]
	public KFDNIKLJMNJ KJIEKCFILBJ(OPAMPAFNBOH<string> NEKANGAICOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FOPDBDLEPNH
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CIPEJJJNBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string PKFMHEPIIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LLPNDJNCICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEOGGHCMLGK();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DMLONBCHLHA NMHMNEOENMA(long LGMIMPLLMGF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FFKANCAOGGC<CBHGKMFEFBA, CCLNCFGAMPK> GPIEBDJACBH(long LGMIMPLLMGF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FFKANCAOGGC<CBHGKMFEFBA, LJKOKHIIAPB> HGGLHGIGGBN(long LGMIMPLLMGF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FFKANCAOGGC<long, DMKGPPKGBPE> BBCMAEDCHHF();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NMPKAOFLEKB(long LGMIMPLLMGF, [Out] bool OIKEGOAMAIJ);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> JFAEIICMHLL(byte[] JFLFEABOIJJ, byte[] GAGGKMGLOMG, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface CBNCHNAGNCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GBPPMNEMOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EIDKLBGLILO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	CJAOOLMNLGI JPAPJECOGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AHBGJBJJDBE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event GNBJMIGBBBN PHHJHIKJKMI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event GNBJMIGBBBN EGCPIDLGDCA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GNBJMIGBBBN DBFEKAKDLPL;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PFBGPEMCIEN, bool> KPBOHBEIFMP;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BJKOGMBFCHF();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LKFCEJIIHFP OKBJEFIFLCP();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HMPACPFKLNH PLKDPPFCIDJ();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<CLBPNGLMFHJ> DNFNDMKOJEP(OBBCDGFHJBJ AMFIFOBJCGP);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task EAJCJPCJKGC(CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface INBNEGOCKCD
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool KKAAJGADDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string GFALNAOBIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIOCMPCOFDN(Scene ENGDOAILBJC);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task POKDDJOGLKH(HFNHBGDIEDK KJPJIPBJPGL, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MMIJIBKOOCK();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MBGMJCPJKBD
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool KPGJGJKFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LJONHNNAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool GOMANJGNKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool HGGMANNIOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int EAMGNCLKMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool BCPMMAEMFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool IMNJPHENMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool DIMAJDONLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float KFEGOJDLLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> GGFBOEJJGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LEHDPNIFNIH FNBKJAFLBFH(LEHDPNIFNIH MPDCPFFFOEC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNKHJPABLJM(LEHDPNIFNIH BFOBHJGOFNM);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFDJBCACKLJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KEDAPMNBLLB(OPAMPAFNBOH<string>.GMFJCEOBAKO EJCBCNMNFBA, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KHOBLGGMPJP(float KOHKCABDAPB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOOLMCCFFHF(string PICCOCLNMEB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<LBBPIBEMLDF> OHLOMGPIMOJ();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable KMIFAHLNHNG(object KAEEGPAIBEC, LBBPIBEMLDF GGKPDIPJBFA);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CCLNCFGAMPK FPNAMLJAMPL(IEnumerable<EEMANFFCIOG> CIFFMDOJHEO);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MMBCLNMKEEK(int HALDHGGLICI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task CDNKNLIDECH();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KBNPLBBEGHH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JAGGPBIONDI();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task NIICCOPOCOA(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task FHOJBFKBDHF(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<AGKKPLKMHJK> PPNACFPJMCO(DateTime KECLPMDNAMK, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> OMEAFFPOABN(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DCKOINOINMP(string JGNAJPMGGNE = "", float EFGIMEOKMHC = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BJLDLAPONEC NAAEELAMEDD(JLGKMCENPAK PJKGFCALJDN, CPGLEDGDMKI NBKHDDLHNPG, LJKOKHIIAPB CCOIJMNKOCO, IEnumerable<PersistenceView> CCGNFFHECFJ, KDDDHEJGDDM HJEHMBAMFCI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LGDDOGEMACN(LJKOKHIIAPB CCOIJMNKOCO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FKDFKAGPNDG(EEMANFFCIOG BDCBKPHIOMI, [In] BJLDLAPONEC PGALLDBLLLA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task OEEHGEEMIDF(LJKOKHIIAPB JPLMJPEMOMH, bool HONFHPOHNDI, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task KILIPOIFEDK(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FABPBBIBJBG(long NCFOOPOBBIJ, long DIKKNIGACBL, NHHLGHBJLHK OJEMOHOCDCL, DNGPLKGKBEJ MOBIHOGFDPC, OMANNHIFEOF JBHELBFKKCJ, DELDHEKMCNB? JOLPLLJAELN, FHIOLGLBKGD? EOLNHOGDCAM);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void FLFKCGEAPCB(long NCFOOPOBBIJ, long DIKKNIGACBL, FHIOLGLBKGD? EOLNHOGDCAM);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void MNDCBJEGOOC(PersistenceView CFOEGAAGPFG);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DAJGMCEHOJD(PersistenceView LNHHACHOOKF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MODFAAJHEID(EEMANFFCIOG BDCBKPHIOMI, ADGDLBLFAGN NJCGNIJKBND, [Out] GIEEMFPKLNM DIKOLCIFDJG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task DJBOCLEFDHL(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void LFMDBHFFJJO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable EIHFAKKJLGC();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FHEEFFGNDBP(LJKOKHIIAPB JPLMJPEMOMH, ADGDLBLFAGN NJCGNIJKBND);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> FOCBJBGNHCA(OBJHGLENMNO DAHFMHKAMCF, CancellationToken AIHJHMPAHCH, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void BKFMGLDHFNC(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<OEBGDEELFDO> NLDINCCAMJJ(PBFPDNKDNFH AIJPHINHCJO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<NHHLGHBJLHK> DEBOOBIADLE(long NCFOOPOBBIJ, bool MNKDFBINJKD, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<DNGPLKGKBEJ> JDJKMNGLHKL(long NCFOOPOBBIJ, long DIKKNIGACBL, long OOMOPIJFFPD, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<GBAFELGEGBB> OEPPGBJHHFJ(string CNJEKLNGLPI, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<GBAFELGEGBB> EONLOGGMMLJ(string CNJEKLNGLPI, long NCFOOPOBBIJ, long DIKKNIGACBL, string KGLKFKGMHJI, NPBNNGJMDHE.BJLBEDAHNAN JENPAMGBIKD, NPBNNGJMDHE.BJLBEDAHNAN GAGGKMGLOMG, int CPJEKHLMDEN);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool DDPCAPNFKDK();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool NHMCCGAJOKI();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool CCAEMMIDLOC(IEnumerable<GIEEMFPKLNM> GIDCJHNPEAP);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NMBEJGAMAFE(List<GameObject> NAOHDNCGFAJ);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float JEINHLIKPMB();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> DDEANMMJGHB(string CNNHODCJBJD, LoadSceneMode BOPOMNICKGB, bool PKOPMMFHOAA, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void MOJJEPIBDLH();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void PEGPBKFJJLF(bool FFABKOCEGNL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LJKOCIAGOJI(NKKGGOEDKKI AJICINJHHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task OONLDJPPMJF(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task LGMPHPHOPPG(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task MHNNFDJHALI(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "63")]
	IDisposable EAAMHEGBEML();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "64")]
	APMPGHIGAOI DPFCHNOGKDP();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task PNONFPHLCNG(CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface APMPGHIGAOI
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EPBEKNMIFFI(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CDIGAMOKEBJ(CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BJLDLAPONEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> FKKCMBGGMPL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum AGKKPLKMHJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JLGKMCENPAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EINGHOMJKEC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BMPIBBEHNHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	NKKGGOEDKKI LKBHGNMJKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	NHHLGHBJLHK IFJDLBIOCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	JEGONNFCHHM KOKADAPDLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool BLNJELFGLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool BMCIMKJLJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int IGBHLKLKOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KBMFKKKJFCO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> JPLJCIEDIPC;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NANAKDJIBFA();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.JPLIFLHIIHG> JMHGLFOEKOA(long LGMIMPLLMGF, [Optional] CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<JIGDGGDALPH> ICBKBJFCDGF();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task KBBMIMGKKPB();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(NKKGGOEDKKI, CJAOOLMNLGI) NAOHHDEGCPC();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NHDDMMGHJDJ LIIJNAOOPDM();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BHICPCBIIKB(long LGMIMPLLMGF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JMOCIPPEEOG
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHOMGKIKFIC([Out] IEnumerable<int> PHMIMHFLPNA);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMLEAPKFPOL(PMCKCPFJJBP FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIBIIPFPHOC(PMCKCPFJJBP FCKLPDKGPKE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CNJIGNGMPHM
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EPMDNPEJNLI(CLBPNGLMFHJ OHNNPIAHLOL);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface AHDENFDGCLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGIPFFNLIAG(EJJIGDCAKED.NAAELOJPMKP NIDMDMJANBM);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOALAKIAEDF(EJJIGDCAKED.NAAELOJPMKP NIDMDMJANBM);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MGPEOOIOMID : AHDENFDGCLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLBPNGLMFHJ GGABKAOPIEG(EOBANJCDGLI OKOCHAOMKHH);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HFOFKAHADJK : AHDENFDGCLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLBPNGLMFHJ MPEDEKGIEMK(EOBANJCDGLI NEJMNOMAPNA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DMLONBCHLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NFMFLMAOFMP<HFNHBGDIEDK, OMPNGPMCKPG>> KHMCKAJOFPJ(string KGLKFKGMHJI, long LGMIMPLLMGF, long? NCFOOPOBBIJ, long? DIKKNIGACBL, CLILGCJJFAL.JHJBNHNMCGB JMHNCFPFIEH, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FFKANCAOGGC<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NFMFLMAOFMP<IILLLDDOIAK<TData>, OMPNGPMCKPG>> HCKKFDPAHKD(TGetDataArg GFMMLICJDDH, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class BDCELBHKCEB : CKDPMMHNMPI, CBNCHNAGNCI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JDNAOCPDHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BDCELBHKCEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OBBCDGFHJBJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<CLBPNGLMFHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6804270", Offset = "0x6803470", VA = "0x186804270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x68044F0", Offset = "0x68036F0", VA = "0x1868044F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DIBBGKGNDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BDCELBHKCEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x67FA560", Offset = "0x67F9760", VA = "0x1867FA560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x67FA790", Offset = "0x67F9990", VA = "0x1867FA790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class EENHALBPEPO : IEnumerable<LOKHFHAIAGB>, IEnumerable, IEnumerator<LOKHFHAIAGB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private LOKHFHAIAGB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BDCELBHKCEB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private LOKHFHAIAGB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public EENHALBPEPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x67FAA50", Offset = "0x67F9C50", VA = "0x1867FAA50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x67FAEB0", Offset = "0x67FA0B0", VA = "0x1867FAEB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x67FAE00", Offset = "0x67FA000", VA = "0x1867FAE00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LOKHFHAIAGB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x67FAE00", Offset = "0x67FA000", VA = "0x1867FAE00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource PDJFFJBKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LEHDPNIFNIH BFOBHJGOFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool OEJOJKGONDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private LPBJBFKOFBL ICLPLPIPHOC;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public OBJHGLENMNO EJOGDCOEDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NGCIKEEIICP HKMNPPFEFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public INBNEGOCKCD MDILADGECMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CA0", Offset = "0x7B7EA0", VA = "0x1807B8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MGPEOOIOMID KBIKPDBABCK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CE0", Offset = "0x7B7EE0", VA = "0x1807B8CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HFOFKAHADJK KOGJDFOOMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B7ED0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FPEHBHJFGEH KAPNBILLGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7C02A0", VA = "0x1807C10A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0250", VA = "0x1807C1050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LKMPHPGNAPE NCDPLOCKFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FB0", Offset = "0x7C01B0", VA = "0x1807C0FB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F80", Offset = "0x7C0180", VA = "0x1807C0F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public AFAAJGFFFEK GOLJJEPFMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F60", Offset = "0x7C0160", VA = "0x1807C0F60", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FD0", Offset = "0x7C01D0", VA = "0x1807C0FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BIGKCCCBLEE DAFEKECFMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x99FAF0", Offset = "0x99ECF0", VA = "0x18099FAF0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x99FBD0", Offset = "0x99EDD0", VA = "0x18099FBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public LDDNAKFOCMM PKCGBGFKCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0240", VA = "0x1807C1040", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F10", Offset = "0x7C0110", VA = "0x1807C0F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public CNPCBBPHNOI DANKPHELNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x89EB50", Offset = "0x89DD50", VA = "0x18089EB50", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x87BCE0", Offset = "0x87AEE0", VA = "0x18087BCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public FBOOGLCDAAH HDPEHIHBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0A0", Offset = "0x7BB2A0", VA = "0x1807BC0A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC080", Offset = "0x7BB280", VA = "0x1807BC080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public OKLELBPPKHI MJABBDAACCG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA29870", Offset = "0xA28A70", VA = "0x180A29870", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA32190", Offset = "0xA31390", VA = "0x180A32190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KDHIIOHAGPN CAJGJOPDKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98F100", Offset = "0x98E300", VA = "0x18098F100", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98F110", Offset = "0x98E310", VA = "0x18098F110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public MLJLCPMHFOB GMNAEELCAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9BA570", Offset = "0x9B9770", VA = "0x1809BA570", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA32130", Offset = "0xA31330", VA = "0x180A32130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KFGEKFLHNGD OPHCCECIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8E2090", Offset = "0x8E1290", VA = "0x1808E2090", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA321D0", Offset = "0xA313D0", VA = "0x180A321D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AIPNBMGKCEH JMNDJNMCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x913850", Offset = "0x912A50", VA = "0x180913850", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9763E0", Offset = "0x9755E0", VA = "0x1809763E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EOACLIOLDGJ JPGMFCKDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7BC070", Offset = "0x7BB270", VA = "0x1807BC070", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0F0", Offset = "0x7BB2F0", VA = "0x1807BC0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GCOHNJIAJNE ODNDGLOAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87C470", VA = "0x18087D270", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x87B880", Offset = "0x87AA80", VA = "0x18087B880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public CPLOJIIHHMI LEIGDLDINHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8EA500", Offset = "0x8E9700", VA = "0x1808EA500", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8EA520", Offset = "0x8E9720", VA = "0x1808EA520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public PDBCIMBKOND JHCFOGJADIO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9136E0", Offset = "0x9128E0", VA = "0x1809136E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA321B0", Offset = "0xA313B0", VA = "0x180A321B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public LLIFKHNFLPK EOMMMBFLILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87D320", Offset = "0x87C520", VA = "0x18087D320", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x87A0F0", Offset = "0x8792F0", VA = "0x18087A0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public JMOCIPPEEOG MLFHPEIANJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x913680", Offset = "0x912880", VA = "0x180913680", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA32170", Offset = "0xA31370", VA = "0x180A32170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public ICHLIAAGBAC EBNJHDBEPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B96A0", Offset = "0x9B88A0", VA = "0x1809B96A0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA32350", Offset = "0xA31550", VA = "0x180A32350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public PKOGCFGFLLG BBPODOCIHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8FD820", Offset = "0x8FCA20", VA = "0x1808FD820", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA32330", Offset = "0xA31530", VA = "0x180A32330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FOPDBDLEPNH OLDKGGLFAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8800F0", Offset = "0x87F2F0", VA = "0x1808800F0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA32290", Offset = "0xA31490", VA = "0x180A32290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public LLKJAJLMJGE FJBPOFICPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9762C0", Offset = "0x9754C0", VA = "0x1809762C0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IHJFPHGKHJF AKFLNCLCFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8FD840", Offset = "0x8FCA40", VA = "0x1808FD840", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FMEGAJMCBII DCGFPHBMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8FD830", Offset = "0x8FCA30", VA = "0x1808FD830", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public PKBHMGEALOP OIMCIOGLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B92B0", Offset = "0x9B84B0", VA = "0x1809B92B0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public CJAOOLMNLGI JPAPJECOGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B97B0", Offset = "0x9B89B0", VA = "0x1809B97B0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA70", Offset = "0x9ABC70", VA = "0x1809ACA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private bool HIEDHFFHNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x67F8A30", Offset = "0x67F7C30", VA = "0x1867F8A30", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private bool OKKNJLEMCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x67F80F0", Offset = "0x67F72F0", VA = "0x1867F80F0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private CancellationToken OHOOFNLIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x67F8A10", Offset = "0x67F7C10", VA = "0x1867F8A10", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private LEHDPNIFNIH MNAKHBDHMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action IIPGFNGKFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67F8170", Offset = "0x67F7370", VA = "0x1867F8170", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67F86E0", Offset = "0x67F78E0", VA = "0x1867F86E0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event GNBJMIGBBBN GCKALMKBAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x67F8420", Offset = "0x67F7620", VA = "0x1867F8420", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x67F8360", Offset = "0x67F7560", VA = "0x1867F8360", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event GNBJMIGBBBN MKOIAFHGKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x67F7FA0", Offset = "0x67F71A0", VA = "0x1867F7FA0", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67F8590", Offset = "0x67F7790", VA = "0x1867F8590", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event GNBJMIGBBBN FOFHAFGCHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x67F8090", Offset = "0x67F7290", VA = "0x1867F8090", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x67F7F40", Offset = "0x67F7140", VA = "0x1867F7F40", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<PFBGPEMCIEN, bool> AGGMPAILKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x67F8480", Offset = "0x67F7680", VA = "0x1867F8480", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x67F8740", Offset = "0x67F7940", VA = "0x1867F8740", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA70", Offset = "0x9ABC70", VA = "0x1809ACA70", Slot = "36")]
	public void LPLJCEPIFAG(CJAOOLMNLGI GNIMGMACLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x67F8A90", Offset = "0x67F7C90", VA = "0x1867F8A90")]
	[UnityEngine.Scripting.Preserve]
	internal BDCELBHKCEB([GAGPBLHNPNO(null)] LEHDPNIFNIH BFOBHJGOFNM, [GAGPBLHNPNO(null)] OBJHGLENMNO DAHFMHKAMCF, [GAGPBLHNPNO(null)] NGCIKEEIICP ONMEPIPCIGG, [GAGPBLHNPNO(null)] MBGMJCPJKBD KIGDILPPPPG, [GAGPBLHNPNO(null)] INBNEGOCKCD BIOLADFNNDK, [GAGPBLHNPNO(null)] MGPEOOIOMID PCNAPNOPGEF, [GAGPBLHNPNO(null)] HFOFKAHADJK JKDOMIKLCDK, [GAGPBLHNPNO(null)] FPEHBHJFGEH CNPBCMHLBFB, [GAGPBLHNPNO(null)] LKMPHPGNAPE IMNGHAMHPED, [GAGPBLHNPNO(null)] AFAAJGFFFEK CBECMHHMLBN, [GAGPBLHNPNO(null)] BIGKCCCBLEE JDLJBPJMMCK, [GAGPBLHNPNO(null)] LDDNAKFOCMM DDEFIHJHPND, [GAGPBLHNPNO(null)] CNPCBBPHNOI KNHOGNCICBD, [GAGPBLHNPNO(null)] FBOOGLCDAAH EMLEOAEKBMH, [GAGPBLHNPNO(null)] OKLELBPPKHI NFFCNGAENAO, [GAGPBLHNPNO(null)] KDHIIOHAGPN HMBEECIHMFI, [GAGPBLHNPNO(null)] MLJLCPMHFOB IPCNOGHNPPN, [GAGPBLHNPNO(null)] KFGEKFLHNGD HLOOBBBKHEB, [GAGPBLHNPNO(null)] AIPNBMGKCEH KJKNPPDEAPH, [GAGPBLHNPNO(null)] EOACLIOLDGJ FHKEINDEILC, [GAGPBLHNPNO(null)] CPLOJIIHHMI HHNKGOBMDEA, [GAGPBLHNPNO(null)] GCOHNJIAJNE OGOGDPCHLDI, [GAGPBLHNPNO(null)] PDBCIMBKOND NDOPPCBGHAA, [GAGPBLHNPNO(null)] LLIFKHNFLPK PECIICDFEGM, [GAGPBLHNPNO(null)] JMOCIPPEEOG AAMLKLJEDOF, [GAGPBLHNPNO(null)] PKOGCFGFLLG GPNOOFEABCC, [GAGPBLHNPNO(null)] FOPDBDLEPNH ANFLJBEFOEL, [GAGPBLHNPNO(null)] LLKJAJLMJGE NIBBJEGGOOP, [GAGPBLHNPNO(null)] IHJFPHGKHJF ELKLGACGLCL, [GAGPBLHNPNO(null)] FMEGAJMCBII IEDLNEDDMPH, [GAGPBLHNPNO(null)] PKBHMGEALOP PJCBMHHGNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x67F84E0", Offset = "0x67F76E0", VA = "0x1867F84E0")]
	private void GEJAFFIMNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x67F81D0", Offset = "0x67F73D0", VA = "0x1867F81D0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x67F89C0", Offset = "0x67F7BC0", VA = "0x1867F89C0", Slot = "49")]
	private void OOPLKNNHIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67F8000", Offset = "0x67F7200", VA = "0x1867F8000", Slot = "50")]
	private LKFCEJIIHFP ANNHLPFKNIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67F8930", Offset = "0x67F7B30", VA = "0x1867F8930", Slot = "51")]
	private HMPACPFKLNH OHFBJPEBEAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x67F87A0", Offset = "0x67F79A0", VA = "0x1867F87A0", Slot = "52")]
	[AsyncStateMachine(typeof(JDNAOCPDHBD))]
	private Task<CLBPNGLMFHJ> KPJLBNMMANA(OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x67F85F0", Offset = "0x67F77F0", VA = "0x1867F85F0", Slot = "53")]
	[AsyncStateMachine(typeof(DIBBGKGNDPJ))]
	private Task HOJKGDLFOHE(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67F88B0", Offset = "0x67F7AB0", VA = "0x1867F88B0")]
	[IteratorStateMachine(typeof(EENHALBPEPO))]
	private IEnumerable<LOKHFHAIAGB> MNGNENAFCIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67F83C0", Offset = "0x67F75C0", VA = "0x1867F83C0")]
	[CompilerGenerated]
	private void FKOPFEILLPL(LOKHFHAIAGB EFNFBPDAPGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KJCGCOJAENH : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xDB4B30", Offset = "0xDB3D30", VA = "0x180DB4B30")]
	public KJCGCOJAENH(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class DCIHBGILBFF : OAIHENIOGLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DDHLCDKBJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public DCIHBGILBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x67FA140", Offset = "0x67F9340", VA = "0x1867FA140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x67FA480", Offset = "0x67F9680", VA = "0x1867FA480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public DCIHBGILBFF(CKDPMMHNMPI GLFBENAFDIE, MBGMJCPJKBD KIGDILPPPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x67F9F70", Offset = "0x67F9170", VA = "0x1867F9F70", Slot = "4")]
	[AsyncStateMachine(typeof(DDHLCDKBJEH))]
	public Task<bool> EBECEAINDJC(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x67FA060", Offset = "0x67F9260", VA = "0x1867FA060")]
	[CompilerGenerated]
	private object FOEMKGDJKAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class DNMELAMPBJI : OAIHENIOGLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LFPKNKCFOPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DNMELAMPBJI <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6808D50", Offset = "0x6807F50", VA = "0x186808D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6809460", Offset = "0x6808660", VA = "0x186809460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x67FA920", Offset = "0x67F9B20", VA = "0x1867FA920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public DNMELAMPBJI(CKDPMMHNMPI GLFBENAFDIE, MBGMJCPJKBD KIGDILPPPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x67FA7F0", Offset = "0x67F99F0", VA = "0x1867FA7F0", Slot = "4")]
	[AsyncStateMachine(typeof(LFPKNKCFOPB))]
	public Task<bool> EBECEAINDJC(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x67FA970", Offset = "0x67F9B70", VA = "0x1867FA970")]
	[CompilerGenerated]
	private object LOGILBAGBEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class ALLAOINMPGK : OAIHENIOGLF
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DCDLOLHNDFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ALLAOINMPGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JIGDGGDALPH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public NKKGGOEDKKI newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DCDLOLHNDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x67F9E80", Offset = "0x67F9080", VA = "0x1867F9E80")]
		internal object OFJIMFOOFJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67F9D70", Offset = "0x67F8F70", VA = "0x1867F9D70")]
		internal object BHHEEBBOINH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x67F9DE0", Offset = "0x67F8FE0", VA = "0x1867F9DE0")]
		internal object JLLJPGFLECE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct CGLGOHDFCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public ALLAOINMPGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private DCDLOLHNDFA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<JIGDGGDALPH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x67F93E0", Offset = "0x67F85E0", VA = "0x1867F93E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x67F9D00", Offset = "0x67F8F00", VA = "0x1867F9D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x67F7EF0", Offset = "0x67F70F0", VA = "0x1867F7EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public ALLAOINMPGK(CKDPMMHNMPI GLFBENAFDIE, MBGMJCPJKBD KIGDILPPPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x67F7DD0", Offset = "0x67F6FD0", VA = "0x1867F7DD0", Slot = "4")]
	[AsyncStateMachine(typeof(CGLGOHDFCJI))]
	public Task<bool> EBECEAINDJC(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface OAIHENIOGLF
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> EBECEAINDJC(CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct JIJPMHKPEJK
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PEACKGDOAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CKDPMMHNMPI manager;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PEACKGDOAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x680F4A0", Offset = "0x680E6A0", VA = "0x18680F4A0")]
		internal Task GHOIBBOFFNN(OHJENCCOGPB data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OHIOACOMBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public JIJPMHKPEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private OBBCDGFHJBJ <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<AGKKPLKMHJK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<CLBPNGLMFHJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x680EE30", Offset = "0x680E030", VA = "0x18680EE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x680F3C0", Offset = "0x680E5C0", VA = "0x18680F3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LEOCKICCLAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JIJPMHKPEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x68089D0", Offset = "0x6807BD0", VA = "0x1868089D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6808CF0", Offset = "0x6807EF0", VA = "0x186808CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken AIHJHMPAHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CKDPMMHNMPI ANAEOGBFNHN;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private OBJHGLENMNO EJOGDCOEDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6805680", Offset = "0x6804880", VA = "0x186805680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6805060", Offset = "0x6804260", VA = "0x186805060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x68050B0", Offset = "0x68042B0", VA = "0x1868050B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private AFAAJGFFFEK GOLJJEPFMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6805240", Offset = "0x6804440", VA = "0x186805240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E433E0", Offset = "0x1E425E0", VA = "0x181E433E0")]
	public JIJPMHKPEJK(CancellationToken AIHJHMPAHCH, CKDPMMHNMPI ANAEOGBFNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6805290", Offset = "0x6804490", VA = "0x186805290")]
	public static PNMKMIHGCPK JIOJFLFJFNE(CKDPMMHNMPI ANAEOGBFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6805130", Offset = "0x6804330", VA = "0x186805130")]
	[AsyncStateMachine(typeof(OHIOACOMBNA))]
	public Task<bool> FPBPNKPIOLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6805340", Offset = "0x6804540", VA = "0x186805340")]
	private bool JPAFIJCBONH([Out] OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6804F90", Offset = "0x6804190", VA = "0x186804F90")]
	[AsyncStateMachine(typeof(LEOCKICCLAL))]
	private Task BJDGNKEMEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6805550", Offset = "0x6804750", VA = "0x186805550")]
	private Task<AGKKPLKMHJK> KBMMLFOLFIF(OBBCDGFHJBJ GGKJAPLJFDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct LKDBPCDLEIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly OKLELBPPKHI NFFCNGAENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid FNMGFNFDGKE;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private Task<(CLBPNGLMFHJ, Task)> CLIFNBHGGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x68095A0", Offset = "0x68087A0", VA = "0x1868095A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FB30", Offset = "0x3D0ED30", VA = "0x183D0FB30")]
	public LKDBPCDLEIO(OKLELBPPKHI NFFCNGAENAO, Guid FNMGFNFDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6809670", Offset = "0x6808870", VA = "0x186809670")]
	public TaskAwaiter<(CLBPNGLMFHJ, Task)> LMNDHIIMHIN()
	{
		return default(TaskAwaiter<(CLBPNGLMFHJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x68094D0", Offset = "0x68086D0", VA = "0x1868094D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct KPKMIAGENIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(CLBPNGLMFHJ, Task)> MCGLDEDONCH;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Task<(CLBPNGLMFHJ, Task)> CLIFNBHGGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6807000", Offset = "0x6806200", VA = "0x186807000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x68071C0", Offset = "0x68063C0", VA = "0x1868071C0")]
	public KPKMIAGENIE(TimeSpan JGOFHIIJIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6807040", Offset = "0x6806240", VA = "0x186807040")]
	public void HNPKNFOJEDH(Task NIOOIEIKLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6807130", Offset = "0x6806330", VA = "0x186807130")]
	public void PCKJFKPIMFL(CLBPNGLMFHJ OHNNPIAHLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x68070E0", Offset = "0x68062E0", VA = "0x1868070E0")]
	public void KFPIEJFHGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6806F70", Offset = "0x6806170", VA = "0x186806F70")]
	internal void CDNBEFGNEOJ(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IEOOLOKEBKK
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BMDKLCODNEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public DNGPLKGKBEJ subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BMDKLCODNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x67F91E0", Offset = "0x67F83E0", VA = "0x1867F91E0")]
		internal bool BAMBABOFDCE(JEGONNFCHHM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6801F30", Offset = "0x6801130", VA = "0x186801F30")]
	public static HGFIJEMHMDL LAFNMEJJDLL(long PBEONGBFPDM, long DIKKNIGACBL, string CNJEKLNGLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6801FC0", Offset = "0x68011C0", VA = "0x186801FC0")]
	public static HGFIJEMHMDL LAFNMEJJDLL(long PBEONGBFPDM, long DIKKNIGACBL, CBHGKMFEFBA JFLFEABOIJJ, long OOMOPIJFFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6801DA0", Offset = "0x6800FA0", VA = "0x186801DA0")]
	public static HGFIJEMHMDL LAFNMEJJDLL(OEBGDEELFDO OMEGIGKLADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6801B70", Offset = "0x6800D70", VA = "0x186801B70")]
	public static HGFIJEMHMDL LAFNMEJJDLL(NHHLGHBJLHK NDCBLIJALNC, DNGPLKGKBEJ DMILFEPDKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6801A80", Offset = "0x6800C80", VA = "0x186801A80")]
	public static HGFIJEMHMDL HGIPAAGKADK(this HGFIJEMHMDL AENCBMJJMMB, NHHLGHBJLHK OHOILICPBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6802080", Offset = "0x6801280", VA = "0x186802080")]
	public static HGFIJEMHMDL NGJIFAEPBBD(this HGFIJEMHMDL AENCBMJJMMB, DNGPLKGKBEJ KGPLNJAGEOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class IADJHKCMJII : LKMPHPGNAPE, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct NOJHPFMNLJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IADJHKCMJII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x680E3B0", Offset = "0x680D5B0", VA = "0x18680E3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x680EA30", Offset = "0x680DC30", VA = "0x18680EA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PMCKCPFJJBP IMOHDIADJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string GEFPEONOFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task IJLOHCBDNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool HEIKDHIKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68019C0", Offset = "0x6800BC0", VA = "0x1868019C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task IFLBMLGGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6801930", Offset = "0x6800B30", VA = "0x186801930", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0", Slot = "7")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x68017D0", Offset = "0x68009D0", VA = "0x1868017D0", Slot = "6")]
	public void CNLCACBDGKD(Task OCAKELEHPCL, string NHGHAKHGEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x68016B0", Offset = "0x68008B0", VA = "0x1868016B0")]
	[AsyncStateMachine(typeof(NOJHPFMNLJH))]
	private Task CDGDAHKMCIN(Task KKCBGGNHPDP, string NHGHAKHGEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x68019F0", Offset = "0x6800BF0", VA = "0x1868019F0")]
	public IADJHKCMJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class GBFOAEFJJPK : ICHLIAAGBAC, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool IPADDICFJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NICLHLHNPCI DGDNPIIHANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PKOGCFGFLLG GPNOOFEABCC;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public NICLHLHNPCI ILFDKCDHKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x67FC2B0", Offset = "0x67FB4B0", VA = "0x1867FC2B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67FC420", Offset = "0x67FB620", VA = "0x1867FC420", Slot = "7")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x67FC5A0", Offset = "0x67FB7A0", VA = "0x1867FC5A0", Slot = "5")]
	public void KNDIBFPIMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67FC320", Offset = "0x67FB520", VA = "0x1867FC320", Slot = "6")]
	public void HCLGAGJEEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x67FC360", Offset = "0x67FB560", VA = "0x1867FC360")]
	private Task EDPGOANNDDA(IAEBKAMOAOG PMBMOONGPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x67FC320", Offset = "0x67FB520", VA = "0x1867FC320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GBFOAEFJJPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EIFAFHLOBAK : PKOGCFGFLLG
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class BPONNKIAJDJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly COFOAKELILD CFGHIMEJAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string GOBGGNLGONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T FJPKGOAOIBJ;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public T FJJHODHBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x827680", Offset = "0x826880", VA = "0x180827680")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x88CAB0", Offset = "0x88BCB0", VA = "0x18088CAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x48BB410", Offset = "0x48BA610", VA = "0x1848BB410")]
		public BPONNKIAJDJ(COFOAKELILD CFGHIMEJAKN, string GOBGGNLGONA, T FJPKGOAOIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x48BAED0", Offset = "0x48BA0D0", VA = "0x1848BAED0")]
		private void BNEAICEOOJB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly COFOAKELILD CFGHIMEJAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly BPONNKIAJDJ<TimeSpan> GEDCCNAENFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly BPONNKIAJDJ<TimeSpan> APENIECHKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly BPONNKIAJDJ<TimeSpan> IGDFMMGICOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly BPONNKIAJDJ<TimeSpan> ACKLIGLNIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly BPONNKIAJDJ<bool> EDDGIFDHBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly BPONNKIAJDJ<bool> DHLGLEKLOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly BPONNKIAJDJ<bool> NEHBNBHKNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly BPONNKIAJDJ<int> CPFDAKKCIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly BPONNKIAJDJ<bool> JMJCJPLKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly BPONNKIAJDJ<bool> KMDDAGHNFKN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan OCMOFIIJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x67FB080", Offset = "0x67FA280", VA = "0x1867FB080", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan HNPHBKJLKBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x67FAF00", Offset = "0x67FA100", VA = "0x1867FAF00", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TimeSpan FEHIJCKHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x67FB000", Offset = "0x67FA200", VA = "0x1867FB000", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TimeSpan BDJEMDOGDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB040", Offset = "0x67FA240", VA = "0x1867FB040", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool CGKJIOJHBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x67FAF40", Offset = "0x67FA140", VA = "0x1867FAF40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool IIMCGOIPGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x67FB100", Offset = "0x67FA300", VA = "0x1867FB100", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool AHPJPMKMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x67FAF80", Offset = "0x67FA180", VA = "0x1867FAF80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int OEIKJMNJJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x67FAFC0", Offset = "0x67FA1C0", VA = "0x1867FAFC0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LBJBMHMOPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x67FB140", Offset = "0x67FA340", VA = "0x1867FB140", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool FNKKHIJNCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x67FB0C0", Offset = "0x67FA2C0", VA = "0x1867FB0C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x67FB180", Offset = "0x67FA380", VA = "0x1867FB180")]
	[UnityEngine.Scripting.Preserve]
	public EIFAFHLOBAK([GAGPBLHNPNO(null)] COFOAKELILD CFGHIMEJAKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class AIHGCCBKKJE : BIGKCCCBLEE, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class NFECMDCHGBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public DENGJMMGKHO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NFECMDCHGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x680D840", Offset = "0x680CA40", VA = "0x18680D840")]
		internal object PLEPHNALPPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action AHBGJBJJDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x67F2170", Offset = "0x67F1370", VA = "0x1867F2170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x67F29F0", Offset = "0x67F1BF0", VA = "0x1867F29F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GNBJMIGBBBN PHHJHIKJKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x67F2510", Offset = "0x67F1710", VA = "0x1867F2510", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x67F2210", Offset = "0x67F1410", VA = "0x1867F2210", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event GNBJMIGBBBN EGCPIDLGDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x67F2760", Offset = "0x67F1960", VA = "0x1867F2760", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x67F26C0", Offset = "0x67F18C0", VA = "0x1867F26C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GNBJMIGBBBN DBFEKAKDLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x67F22B0", Offset = "0x67F14B0", VA = "0x1867F22B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x67F2020", Offset = "0x67F1220", VA = "0x1867F2020", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<PFBGPEMCIEN, bool> KPBOHBEIFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x67F20C0", Offset = "0x67F12C0", VA = "0x1867F20C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x67F25E0", Offset = "0x67F17E0", VA = "0x1867F25E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "19")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x67F2800", Offset = "0x67F1A00", VA = "0x1867F2800", Slot = "14")]
	public void IGPEGJIHEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x67F2AE0", Offset = "0x67F1CE0", VA = "0x1867F2AE0", Slot = "15")]
	public void MGGOHEPCLAE(DENGJMMGKHO DJEBFPGKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x67F2690", Offset = "0x67F1890", VA = "0x1867F2690", Slot = "16")]
	public void HAEAHMNCKCE(DENGJMMGKHO DJEBFPGKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x67F25B0", Offset = "0x67F17B0", VA = "0x1867F25B0", Slot = "17")]
	public void EEMFMHMMGPN(DENGJMMGKHO DJEBFPGKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x67F2A90", Offset = "0x67F1C90", VA = "0x1867F2A90", Slot = "18")]
	public void MBHDKPCLPOJ(PFBGPEMCIEN BOPJNIDBFBF, bool KFLNBNHABLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x67F2350", Offset = "0x67F1550", VA = "0x1867F2350")]
	private void DPCEAIGMMMP(GNBJMIGBBBN GGKPDIPJBFA, DENGJMMGKHO DJEBFPGKJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public AIHGCCBKKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class LOOLPFFFDIM : LDDNAKFOCMM, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct KJFDLHAOKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public LOOLPFFFDIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6806A30", Offset = "0x6805C30", VA = "0x186806A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6806F10", Offset = "0x6806110", VA = "0x186806F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct MONLOMHKNOK : IAsyncStateMachine
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
		public LOOLPFFFDIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x680C6E0", Offset = "0x680B8E0", VA = "0x18680C6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x680CD40", Offset = "0x680BF40", VA = "0x18680CD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NPKDKANIINH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NPKDKANIINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x680EA90", Offset = "0x680DC90", VA = "0x18680EA90")]
		internal object AJAELFKGKHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct FCPCFBOKJIN : IAsyncStateMachine
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
		public LOOLPFFFDIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private NPKDKANIINH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x67FB5F0", Offset = "0x67FA7F0", VA = "0x1867FB5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD30", Offset = "0x67FAF30", VA = "0x1867FBD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PBPNAJDMCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PBPNAJDMCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x680F430", Offset = "0x680E630", VA = "0x18680F430")]
		internal object NKDOEIBDPKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private OAIHENIOGLF[] DIJMLBIBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource MODHBCLCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int IIMPDLNIALN;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x680A570", Offset = "0x6809770", VA = "0x18680A570", Slot = "6")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x680A560", Offset = "0x6809760", VA = "0x18680A560", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x680A980", Offset = "0x6809B80", VA = "0x18680A980", Slot = "8")]
	public void MEKDPGGMKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x680A0F0", Offset = "0x68092F0", VA = "0x18680A0F0", Slot = "5")]
	public void BJKOGMBFCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x680A5F0", Offset = "0x68097F0", VA = "0x18680A5F0", Slot = "4")]
	[AsyncStateMachine(typeof(KJFDLHAOKJK))]
	public Task JFIFIJLGBCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x680AA80", Offset = "0x6809C80", VA = "0x18680AA80")]
	private void OPHNJKIDALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x680A7A0", Offset = "0x68099A0", VA = "0x18680A7A0")]
	[AsyncStateMachine(typeof(MONLOMHKNOK))]
	private Task JMMFFFFMIBE(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x680A1C0", Offset = "0x68093C0", VA = "0x18680A1C0")]
	[AsyncStateMachine(typeof(FCPCFBOKJIN))]
	private Task<bool> BOLPPPPHIEK(int HMFNCGHECPG, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x680A8A0", Offset = "0x6809AA0", VA = "0x18680A8A0")]
	private void KMNCBLADAIE(int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x680A6C0", Offset = "0x68098C0", VA = "0x18680A6C0")]
	private void JGMFCMDCJKJ(int HMFNCGHECPG, bool KFLNBNHABLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x680A430", Offset = "0x6809630", VA = "0x18680A430")]
	private void DGJNKAHJACP(int HMFNCGHECPG, Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x680A300", Offset = "0x6809500", VA = "0x18680A300")]
	private void CPOHMPMLFFG(CancellationToken AIHJHMPAHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LOOLPFFFDIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class HOPGMOHMGAB : CNPCBBPHNOI, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct LNDEPEHHFAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CJAOOLMNLGI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6809740", Offset = "0x6808940", VA = "0x186809740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x680A090", Offset = "0x6809290", VA = "0x18680A090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct IFODDNKJEKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CJAOOLMNLGI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private OPAMPAFNBOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GBPKPFGCFHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NPDCGEHACLF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private KFDNIKLJMNJ <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6802210", Offset = "0x6801410", VA = "0x186802210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6802DD0", Offset = "0x6801FD0", VA = "0x186802DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class AJGGMOPMGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.NHJMJMDMNPH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ICHAIDJLLCH errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AJGGMOPMGBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x67F7D20", Offset = "0x67F6F20", VA = "0x1867F7D20")]
		internal object FKCJJKIBAKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class OECBNMKBLHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<HGFIJEMHMDL> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OECBNMKBLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		internal Task<HGFIJEMHMDL> MONACNJMGFF(OPAMPAFNBOH<string>.GMFJCEOBAKO _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct AJAJHMMOBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CJAOOLMNLGI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NPDCGEHACLF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private OECBNMKBLHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private GLHEFCHDPOC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private GBPKPFGCFHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private FAJOLONPKDC <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.JPLIFLHIIHG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private BCPKOIALBKF <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.JPLIFLHIIHG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<HGFIJEMHMDL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x67F2B10", Offset = "0x67F1D10", VA = "0x1867F2B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x67F7CC0", Offset = "0x67F6EC0", VA = "0x1867F7CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct KDBEIJNKCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <disconnectTimerScope>5__3;

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
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6805E20", Offset = "0x6805020", VA = "0x186805E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6806870", Offset = "0x6805A70", VA = "0x186806870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct JBOIINLNNIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private LEHDPNIFNIH <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6803D90", Offset = "0x6802F90", VA = "0x186803D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6804210", Offset = "0x6803410", VA = "0x186804210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NECEGDEGFEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.JPLIFLHIIHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.JPLIFLHIIHG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x680CDA0", Offset = "0x680BFA0", VA = "0x18680CDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x680D2A0", Offset = "0x680C4A0", VA = "0x18680D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct JPOACLPHJHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.JPLIFLHIIHG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public NPDCGEHACLF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<GKDLJNAGODA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x68056D0", Offset = "0x68048D0", VA = "0x1868056D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6805DC0", Offset = "0x6804FC0", VA = "0x186805DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class BLMCCAGNGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BLMCCAGNGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x67F8FE0", Offset = "0x67F81E0", VA = "0x1867F8FE0")]
		internal object AEAKOMCCEEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x67F90E0", Offset = "0x67F82E0", VA = "0x1867F90E0")]
		internal string ENFDKLMODBA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct IPADMAIODMD : IAsyncStateMachine
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
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private BLMCCAGNGEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private GBPKPFGCFHL <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6803160", Offset = "0x6802360", VA = "0x186803160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6803D30", Offset = "0x6802F30", VA = "0x186803D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct GEGILJEIMDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public NPDCGEHACLF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public HGFIJEMHMDL initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public NKKGGOEDKKI targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public GLHEFCHDPOC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x67FC750", Offset = "0x67FB950", VA = "0x1867FC750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x67FD060", Offset = "0x67FC260", VA = "0x1867FD060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct LCKMFJOHECN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private GBPKPFGCFHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6807340", Offset = "0x6806540", VA = "0x186807340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6808970", Offset = "0x6807B70", VA = "0x186808970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct NLNLAOBALDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public HOPGMOHMGAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<CLBPNGLMFHJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x680DBA0", Offset = "0x680CDA0", VA = "0x18680DBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x680E350", Offset = "0x680D550", VA = "0x18680E350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class CEJMJCOFCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CEJMJCOFCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x67F9210", Offset = "0x67F8410", VA = "0x1867F9210")]
		internal object CMBGJCENJNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BECDPDEIPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BECDPDEIPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x67F8EF0", Offset = "0x67F80F0", VA = "0x1867F8EF0")]
		internal void ADBOCPHDFKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class LNDCEJOIBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LNDCEJOIBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x68096C0", Offset = "0x68088C0", VA = "0x1868096C0")]
		internal object BMOHGONOGJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class IOLFGJAMCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IOLFGJAMCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6803060", Offset = "0x6802260", VA = "0x186803060")]
		internal string MLPECFNPELN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly JJNHGMIGPBK CGOBHKOIGMK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly JJNHGMIGPBK AKKIIIFLFAA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly JJNHGMIGPBK JLNICHKBLOF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string DMFCNFADANK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string JKFJOPCHEPD;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string IKBKPAPPNKE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid EHPEHNHMOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FPEHBHJFGEH CNPBCMHLBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NGCIKEEIICP ONMEPIPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private LDDNAKFOCMM DDEFIHJHPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private LKMPHPGNAPE IMNGHAMHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BIGKCCCBLEE JDLJBPJMMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private FMEGAJMCBII IEDLNEDDMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IHJFPHGKHJF ELKLGACGLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable DJNMOMCEDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly PMCKCPFJJBP HFLNFLKLCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PMCKCPFJJBP JDIBHKPOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BCPKOIALBKF KEJCGDKJELB;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TaskStatus PBNIFAGBBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAEBD70", Offset = "0xAEAF70", VA = "0x180AEBD70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB3A210", Offset = "0xB39410", VA = "0x180B3A210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x67FF1A0", Offset = "0x67FE3A0", VA = "0x1867FF1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x67FF280", Offset = "0x67FE480", VA = "0x1867FF280", Slot = "6")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x67FEAE0", Offset = "0x67FDCE0", VA = "0x1867FEAE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x67FF930", Offset = "0x67FEB30", VA = "0x1867FF930", Slot = "5")]
	[AsyncStateMachine(typeof(LNDEPEHHFAF))]
	public Task HKFGECGEGDO(NKKGGOEDKKI LPFEKEJDECG, CJAOOLMNLGI LDGJAGLJFKJ, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6800220", Offset = "0x67FF420", VA = "0x186800220")]
	[AsyncStateMachine(typeof(IFODDNKJEKH))]
	private Task KHFMKNKKAPK(NKKGGOEDKKI LPFEKEJDECG, CJAOOLMNLGI LDGJAGLJFKJ, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x67FDC00", Offset = "0x67FCE00", VA = "0x1867FDC00")]
	private static void ABANPGNJNAD(FMEGAJMCBII IEDLNEDDMPH, NKKGGOEDKKI LPFEKEJDECG, Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6800580", Offset = "0x67FF780", VA = "0x186800580")]
	private static void MBPOPGOLAHK(KFDNIKLJMNJ OPBICAKNAKL, Exception PGAHDJGBLJL, [Optional] List<int> BDPIBPJCJIJ, int IIMPDLNIALN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x67FE800", Offset = "0x67FDA00", VA = "0x1867FE800")]
	[AsyncStateMachine(typeof(AJAJHMMOBJG))]
	private Task DGDBPINDMFJ(OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, NKKGGOEDKKI LPFEKEJDECG, CJAOOLMNLGI LDGJAGLJFKJ, NPDCGEHACLF OPOPNDAENEP, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x68011A0", Offset = "0x68003A0", VA = "0x1868011A0")]
	private void ODBAGBDOOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x67FE6D0", Offset = "0x67FD8D0", VA = "0x1867FE6D0")]
	[AsyncStateMachine(typeof(KDBEIJNKCFC))]
	private Task COIAJGMLLEI(OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x67FFA70", Offset = "0x67FEC70", VA = "0x1867FFA70")]
	private void HMJHEAIBOGG(NKKGGOEDKKI LPFEKEJDECG, CancellationToken OJHIOEGMMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x67FE3B0", Offset = "0x67FD5B0", VA = "0x1867FE3B0")]
	private void CMANJPGMCGC(NKKGGOEDKKI LPFEKEJDECG, NPDCGEHACLF OPOPNDAENEP, OperationCanceledException MECNBIPOBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x67FED00", Offset = "0x67FDF00", VA = "0x1867FED00")]
	private void EOGANBOEKNG(NKKGGOEDKKI LPFEKEJDECG, NPDCGEHACLF OPOPNDAENEP, Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6800370", Offset = "0x67FF570", VA = "0x186800370")]
	private void KLGDGGAFDBG(NKKGGOEDKKI LPFEKEJDECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x67FE220", Offset = "0x67FD420", VA = "0x1867FE220")]
	private static DENGJMMGKHO CAPGMPLINCJ(NKKGGOEDKKI LPFEKEJDECG)
	{
		return default(DENGJMMGKHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x67FEF20", Offset = "0x67FE120", VA = "0x1867FEF20")]
	[AsyncStateMachine(typeof(JBOIINLNNIO))]
	private Task FBMIFOOIEJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x68000C0", Offset = "0x67FF2C0", VA = "0x1868000C0")]
	[AsyncStateMachine(typeof(NECEGDEGFEG))]
	private Task<Matchmaking.JPLIFLHIIHG> JMHGLFOEKOA(NKKGGOEDKKI LPFEKEJDECG, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x67FFEC0", Offset = "0x67FF0C0", VA = "0x1867FFEC0")]
	private static GKDLJNAGODA IJBCNNMPALK(Matchmaking.JPLIFLHIIHG EIFGJJBHDMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x67FDFC0", Offset = "0x67FD1C0", VA = "0x1867FDFC0")]
	[AsyncStateMachine(typeof(JPOACLPHJHL))]
	private Task AONKOGDHKCB(Matchmaking.JPLIFLHIIHG EIFGJJBHDMF, NPDCGEHACLF OPOPNDAENEP, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken HDPEDMBJAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6800F70", Offset = "0x6800170", VA = "0x186800F70")]
	[AsyncStateMachine(typeof(IPADMAIODMD))]
	private Task NLLGCNJMCHK(NKKGGOEDKKI LPFEKEJDECG, CancellationTokenSource BJNKPJDEBAJ, Task JHACKBDHDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6800E00", Offset = "0x6800000", VA = "0x186800E00")]
	[AsyncStateMachine(typeof(GEGILJEIMDO))]
	private Task MLMMAPGOPHE(HGFIJEMHMDL OEPECDELIMH, GLHEFCHDPOC BINBMEKFIGM, NKKGGOEDKKI EAIJFIPJOPH, NPDCGEHACLF DDOALLDGEKK, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken GENFOHDGNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x67FF740", Offset = "0x67FE940", VA = "0x1867FF740")]
	private NPDCGEHACLF HJHACNBFBBJ(NPDCGEHACLF DDOALLDGEKK, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x67FE280", Offset = "0x67FD480", VA = "0x1867FE280")]
	[AsyncStateMachine(typeof(LCKMFJOHECN))]
	private Task CGAOMBKEOJD(OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x67FFDA0", Offset = "0x67FEFA0", VA = "0x1867FFDA0")]
	[AsyncStateMachine(typeof(NLNLAOBALDI))]
	private Task ICINEIHGKOF(OHJENCCOGPB FODGEDCJIDC, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x67FE960", Offset = "0x67FDB60", VA = "0x1867FE960")]
	private static void DJJPMLLDLGJ(NKKGGOEDKKI LPFEKEJDECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x67FEB30", Offset = "0x67FDD30", VA = "0x1867FEB30")]
	private void EJNKEMHACGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6800030", Offset = "0x67FF230", VA = "0x186800030")]
	private void JJIMMHLIIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x67FF1F0", Offset = "0x67FE3F0", VA = "0x1867FF1F0")]
	private void FJPKPFJONBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x68012F0", Offset = "0x68004F0", VA = "0x1868012F0")]
	private void OFAKOPFKAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x68010B0", Offset = "0x68002B0", VA = "0x1868010B0")]
	private static void OAPEDMBKMDI(NKKGGOEDKKI LPFEKEJDECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67FE110", Offset = "0x67FD310", VA = "0x1867FE110")]
	private static CancellationTokenRegistration BOEANCNGFGG(NKKGGOEDKKI LPFEKEJDECG, CancellationToken HDPEDMBJAHE)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x67FE5D0", Offset = "0x67FD7D0", VA = "0x1867FE5D0")]
	private static void COFBLHGEJBP(NKKGGOEDKKI LPFEKEJDECG, Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x67FEFF0", Offset = "0x67FE1F0", VA = "0x1867FEFF0")]
	private void FHDMMLOLENM(NKKGGOEDKKI LPFEKEJDECG, Task JHACKBDHDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6801380", Offset = "0x6800580", VA = "0x186801380")]
	private static void PHDBFKGPBFI(Func<string> BNFCMKEEELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x68015E0", Offset = "0x68007E0", VA = "0x1868015E0")]
	public HOPGMOHMGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x67FFFD0", Offset = "0x67FF1D0", VA = "0x1867FFFD0")]
	[CompilerGenerated]
	internal static (int, int?) ILOMIPCJEIC(ICHAIDJLLCH PIMNPCCLOAF)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class PLPPCIADMEN : FBOOGLCDAAH, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct FEDEGBFKBHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public PLPPCIADMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OHJENCCOGPB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6818AA0", Offset = "0x6817CA0", VA = "0x186818AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6818E60", Offset = "0x6818060", VA = "0x186818E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class OMNCMLPCOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public PLPPCIADMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public OHJENCCOGPB roomData;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OMNCMLPCOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x682C890", Offset = "0x682BA90", VA = "0x18682C890")]
		internal List<Task> EAKGPJLGIML(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MNIIFCMAHCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public PNMKMIHGCPK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6829600", Offset = "0x6828800", VA = "0x186829600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6829980", Offset = "0x6828B80", VA = "0x186829980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct OKHKNFHPHAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public PLPPCIADMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x682C510", Offset = "0x682B710", VA = "0x18682C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x682C7D0", Offset = "0x682B9D0", VA = "0x18682C7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<PNMKMIHGCPK> OEGLAJJMHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NGCIKEEIICP ONMEPIPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private LBBPIBEMLDF CBPGDBANHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IBFHGCCAHAJ LBIFJOOBHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable DJNMOMCEDHA;

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x680FF00", Offset = "0x680F100", VA = "0x18680FF00", Slot = "5")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x680F7F0", Offset = "0x680E9F0", VA = "0x18680F7F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x680F850", Offset = "0x680EA50", VA = "0x18680F850", Slot = "4")]
	public bool EKJLNKCOGPF(PNMKMIHGCPK FGGBGGPDELN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x680FDD0", Offset = "0x680EFD0", VA = "0x18680FDD0")]
	private void GCMCBIGACIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x680F4F0", Offset = "0x680E6F0", VA = "0x18680F4F0")]
	private void BMHDGLOPIFK(OHJENCCOGPB JENPAMGBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6810180", Offset = "0x680F380", VA = "0x186810180")]
	[AsyncStateMachine(typeof(FEDEGBFKBHM))]
	private Task HJEINBNACJK(OHJENCCOGPB JENPAMGBIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6810270", Offset = "0x680F470", VA = "0x186810270")]
	private Func<CancellationToken, List<Task>> LCDKMGNMPOB(OHJENCCOGPB JENPAMGBIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x680F8B0", Offset = "0x680EAB0", VA = "0x18680F8B0")]
	private List<Task> FFKBKCKGPGD(OHJENCCOGPB JENPAMGBIKD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x680F6D0", Offset = "0x680E8D0", VA = "0x18680F6D0")]
	[AsyncStateMachine(typeof(MNIIFCMAHCG))]
	private Task CAJLOKPBHAG(PNMKMIHGCPK GEHIKDCONBI, OHJENCCOGPB FODGEDCJIDC, CancellationToken FCKLPDKGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x68103C0", Offset = "0x680F5C0", VA = "0x1868103C0")]
	[AsyncStateMachine(typeof(OKHKNFHPHAM))]
	private Task OHLCDNMBLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6810340", Offset = "0x680F540", VA = "0x186810340")]
	private void MEKDPGGMKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6810490", Offset = "0x680F690", VA = "0x186810490")]
	public PLPPCIADMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class MEGBJHEJCIJ : OKLELBPPKHI, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class PKKHOGHAEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PKKHOGHAEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x682F240", Offset = "0x682E440", VA = "0x18682F240")]
		internal object GFKAGHGJKOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class JAAHAGOABKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JAAHAGOABKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x681FEB0", Offset = "0x681F0B0", VA = "0x18681FEB0")]
		internal object PHFNOPNLLBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NJEFGMHFEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NJEFGMHFEFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class ODOCIJJLACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ODOCIJJLACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x682BFA0", Offset = "0x682B1A0", VA = "0x18682BFA0")]
		internal object CJDLLEHJMKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class GFPBOKKPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GFPBOKKPHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x681B600", Offset = "0x681A800", VA = "0x18681B600")]
		internal object LLGKMBJHDIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, KPKMIAGENIE> NFFCNGAENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan LIEEKNMJDCC;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "9")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x68274A0", Offset = "0x68266A0", VA = "0x1868274A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6827C20", Offset = "0x6826E20", VA = "0x186827C20", Slot = "4")]
	public LKDBPCDLEIO OEOPOJPHCNL(Guid FNMGFNFDGKE)
	{
		return default(LKDBPCDLEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x68274B0", Offset = "0x68266B0", VA = "0x1868274B0", Slot = "5")]
	public bool MFEEKLGJAPH(Guid FNMGFNFDGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x68278F0", Offset = "0x6826AF0", VA = "0x1868278F0", Slot = "6")]
	public bool MMFEPGIFFGN(Guid FNMGFNFDGKE, Task NIOOIEIKLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x68272C0", Offset = "0x68264C0", VA = "0x1868272C0", Slot = "7")]
	public bool CMMDBKCBAHJ(Guid FNMGFNFDGKE, CLBPNGLMFHJ OHNNPIAHLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6827E40", Offset = "0x6827040", VA = "0x186827E40", Slot = "8")]
	public Task<(CLBPNGLMFHJ, Task)> OPBLMBBAHNL(Guid FNMGFNFDGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x68276C0", Offset = "0x68268C0", VA = "0x1868276C0")]
	private void MFLGHAFJOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6827EB0", Offset = "0x68270B0", VA = "0x186827EB0")]
	public MEGBJHEJCIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class CHAHOGNLOBK : KDHIIOHAGPN, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class MEHEBJLKDIA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly NKKGGOEDKKI AJICINJHHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource MODHBCLCLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken MHFGINAPALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool FNALCOBNMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool HBNMNOFGLDE;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x68280F0", Offset = "0x68272F0", VA = "0x1868280F0")]
		public MEHEBJLKDIA(NKKGGOEDKKI AJICINJHHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6827FA0", Offset = "0x68271A0", VA = "0x186827FA0")]
		public void MEKDPGGMKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x6827F70", Offset = "0x6827170", VA = "0x186827F70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class KBJCIMEEBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IAEBKAMOAOG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KBJCIMEEBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6822500", Offset = "0x6821700", VA = "0x186822500")]
		internal object OLHDBFGAMEC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct BJJDNBECAMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public IAEBKAMOAOG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public CHAHOGNLOBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x68131D0", Offset = "0x68123D0", VA = "0x1868131D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6813580", Offset = "0x6812780", VA = "0x186813580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class FNKBKLGDJCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FNKBKLGDJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6818F40", Offset = "0x6818140", VA = "0x186818F40")]
		internal object FIOHJGMBEEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct AFJAGGAGJJC : IAsyncStateMachine
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
		public CHAHOGNLOBK <>4__this;

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
		private GBPKPFGCFHL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x68118B0", Offset = "0x6810AB0", VA = "0x1868118B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class NCDOFOIDAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public NKKGGOEDKKI newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NCDOFOIDAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x682A3A0", Offset = "0x68295A0", VA = "0x18682A3A0")]
		internal object OLNEMNEEPEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x682A320", Offset = "0x6829520", VA = "0x18682A320")]
		internal object AOEGOOEINNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x682A360", Offset = "0x6829560", VA = "0x18682A360")]
		internal object DKHAFPIOPKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class HEEOOAKKHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HEEOOAKKHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x681EA70", Offset = "0x681DC70", VA = "0x18681EA70")]
		internal void FDGFKGMFHNN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct FPMBEACGEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public NKKGGOEDKKI newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public CHAHOGNLOBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public CJAOOLMNLGI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private NCDOFOIDAPO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private GBPKPFGCFHL <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6819E20", Offset = "0x6819020", VA = "0x186819E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x681ADA0", Offset = "0x6819FA0", VA = "0x18681ADA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly JKOOADOFMPI.JGEEFOMKIEK BCGCNLHBEEG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly OEGDLJADJON DANKIGGDCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NGCIKEEIICP ONMEPIPCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private LDDNAKFOCMM DDEFIHJHPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private PKOGCFGFLLG GPNOOFEABCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private CNPCBBPHNOI KNHOGNCICBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long BDIJMJLCFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private MEHEBJLKDIA DGJAKNMBJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool FFDJMFGCCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task ANJIKKELOHM;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6815190", Offset = "0x6814390", VA = "0x186815190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool DBOPFJOHBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x109E2B0", Offset = "0x109D4B0", VA = "0x18109E2B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6815A00", Offset = "0x6814C00", VA = "0x186815A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x68151E0", Offset = "0x68143E0", VA = "0x1868151E0", Slot = "4")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6814CB0", Offset = "0x6813EB0", VA = "0x186814CB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6814E20", Offset = "0x6814020", VA = "0x186814E20")]
	[AsyncStateMachine(typeof(BJJDNBECAMH))]
	private Task EMEEOKLLAOP(IAEBKAMOAOG NKLMNLCANGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6815550", Offset = "0x6814750", VA = "0x186815550")]
	private void KBMFKKKJFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6815A60", Offset = "0x6814C60", VA = "0x186815A60")]
	private void PAJHCNCCFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6815810", Offset = "0x6814A10", VA = "0x186815810")]
	private void KHOMDJOMDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6815990", Offset = "0x6814B90", VA = "0x186815990")]
	private bool MNIEJMGBJIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6815480", Offset = "0x6814680", VA = "0x186815480")]
	[AsyncStateMachine(typeof(AFJAGGAGJJC))]
	private void JPLJCIEDIPC(int FNJDHDECLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6814F10", Offset = "0x6814110", VA = "0x186814F10")]
	private void FDFIJGIOFOJ([Out] IDisposable NFBPKOAOKIL, [Out] IDisposable HHJPEGCNEPN, [Out] IDisposable KDGCADDPBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6815BF0", Offset = "0x6814DF0", VA = "0x186815BF0")]
	private bool PJPGLHDLIAC(NKKGGOEDKKI AJICINJHHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6815A10", Offset = "0x6814C10", VA = "0x186815A10")]
	private void NMCFGACJJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x68156E0", Offset = "0x68148E0", VA = "0x1868156E0")]
	[AsyncStateMachine(typeof(FPMBEACGEMG))]
	private Task KHFMKNKKAPK(NKKGGOEDKKI AJICINJHHEJ, CJAOOLMNLGI LDGJAGLJFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6816090", Offset = "0x6815290", VA = "0x186816090")]
	public CHAHOGNLOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class LKGJEBBLJEI : MLJLCPMHFOB, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct NEEBHAIBHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<ANBJHFCMHDB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public LKGJEBBLJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<ANBJHFCMHDB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x682A680", Offset = "0x6829880", VA = "0x18682A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x682A910", Offset = "0x6829B10", VA = "0x18682A910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class OLFLPOPOAPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public LCFKPKINCJE message;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OLFLPOPOAPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x682C830", Offset = "0x682BA30", VA = "0x18682C830")]
		internal object POPENJFKBJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class JHFFFPGBJOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public LCFKPKINCJE messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JHFFFPGBJOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x681FF10", Offset = "0x681F110", VA = "0x18681FF10")]
		internal object LCEHANGBFPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class MHFMOBGPACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public MHFMOBGPACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6828AC0", Offset = "0x6827CC0", VA = "0x186828AC0")]
		internal object KNMHMFGOBHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct AFCPLMLPJAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public LKGJEBBLJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<JIEBELBAAKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6810F90", Offset = "0x6810190", VA = "0x186810F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6811850", Offset = "0x6810A50", VA = "0x186811850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class APBCABOGPAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public LCFKPKINCJE operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public APBCABOGPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6813070", Offset = "0x6812270", VA = "0x186813070")]
		internal object FGOOPNDKHKK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct PBHIJGEOBCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public LCFKPKINCJE operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public LKGJEBBLJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private NPDCGEHACLF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x682DB90", Offset = "0x682CD90", VA = "0x18682DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x682E6F0", Offset = "0x682D8F0", VA = "0x18682E6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct JKILKOFPHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<JIEBELBAAKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public LKGJEBBLJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private KNDNAHHNKOA.HJBNFLBFMGM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private NPDCGEHACLF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6821F70", Offset = "0x6821170", VA = "0x186821F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6822490", Offset = "0x6821690", VA = "0x186822490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class BGAEILLFLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public JIEBELBAAKC operation;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BGAEILLFLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x68130D0", Offset = "0x68122D0", VA = "0x1868130D0")]
		internal object KAFIJFCOEFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct KOFGOOEPHAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public JIEBELBAAKC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public LKGJEBBLJEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private OPAMPAFNBOH<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x68227E0", Offset = "0x68219E0", VA = "0x1868227E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6822E20", Offset = "0x6822020", VA = "0x186822E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class GNCNDKEFOGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GNCNDKEFOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x681B880", Offset = "0x681AA80", VA = "0x18681B880")]
		internal object JMFHPLJDCLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class ODLDPIGGNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ODLDPIGGNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x682BF40", Offset = "0x682B140", VA = "0x18682BF40")]
		internal object BPEADCLLKDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private LKMPHPGNAPE IMNGHAMHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private KFGEKFLHNGD HLOOBBBKHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private GCOHNJIAJNE OGOGDPCHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<ANBJHFCMHDB> IPIAFFIBPJK;

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6824550", Offset = "0x6823750", VA = "0x186824550", Slot = "7")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6824C60", Offset = "0x6823E60", VA = "0x186824C60", Slot = "6")]
	[AsyncStateMachine(typeof(NEEBHAIBHDJ))]
	public Task<ANBJHFCMHDB> NHNLJHGILOJ(CancellationToken OJCKMINAJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x68240B0", Offset = "0x68232B0", VA = "0x1868240B0", Slot = "4")]
	public void CDCPILCNFHL(LCFKPKINCJE JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6824D70", Offset = "0x6823F70", VA = "0x186824D70", Slot = "5")]
	public void NPHGMBKBJOP(LCFKPKINCJE OIFANAKLHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6824440", Offset = "0x6823640", VA = "0x186824440")]
	[AsyncStateMachine(typeof(AFCPLMLPJAC))]
	private Task FIIGINCMLGG(LCFKPKINCJE AIJPHINHCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6824640", Offset = "0x6823840", VA = "0x186824640")]
	[AsyncStateMachine(typeof(PBHIJGEOBCA))]
	private Task IELCLKDFKLL(LCFKPKINCJE EPFOHBHKBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6824B10", Offset = "0x6823D10", VA = "0x186824B10")]
	[AsyncStateMachine(typeof(JKILKOFPHLB))]
	private Task<JIEBELBAAKC> LMCABFFHHIL(LCFKPKINCJE AIJPHINHCJO, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6824750", Offset = "0x6823950", VA = "0x186824750")]
	private NPDCGEHACLF IIKMKNOKKJI(LCFKPKINCJE BFKFODNNLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x68249F0", Offset = "0x6823BF0", VA = "0x1868249F0")]
	[AsyncStateMachine(typeof(KOFGOOEPHAD))]
	private Task JLCNCOMGBCJ(JIEBELBAAKC CNMFPFIJBEO, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x68247E0", Offset = "0x68239E0", VA = "0x1868247E0")]
	private JIEBELBAAKC JBLHMGNMGDA(LCFKPKINCJE AIJPHINHCJO, NPDCGEHACLF NFGPOMNPCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x298AD40", Offset = "0x2989F40", VA = "0x18298AD40")]
	private T CFFICNEPJLL<T>(T NICEPFIEJED) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x68250D0", Offset = "0x68242D0", VA = "0x1868250D0")]
	private JIEBELBAAKC PCAKEEMNJOL(LCFKPKINCJE AIJPHINHCJO, NPDCGEHACLF NFGPOMNPCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LKGJEBBLJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class JJOMMHGMOCM : KFGEKFLHNGD, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class LGINMDIOLNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LGINMDIOLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6824040", Offset = "0x6823240", VA = "0x186824040")]
		internal object GDGEIAJODKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JJHJECEHDHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JJHJECEHDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x681FF70", Offset = "0x681F170", VA = "0x18681FF70")]
		internal object LOKFDHLCOCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private PDBCIMBKOND NDOPPCBGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private MLJLCPMHFOB IPCNOGHNPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private OKLELBPPKHI NFFCNGAENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private JMOCIPPEEOG AAMLKLJEDOF;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6820BD0", Offset = "0x681FDD0", VA = "0x186820BD0", Slot = "6")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x68208B0", Offset = "0x681FAB0", VA = "0x1868208B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6820210", Offset = "0x681F410", VA = "0x186820210", Slot = "4")]
	public LKDBPCDLEIO DKNFDJLGPLF(LCFKPKINCJE KFOLBIKFDLO)
	{
		return default(LKDBPCDLEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x68217C0", Offset = "0x68209C0", VA = "0x1868217C0", Slot = "5")]
	public void OFCODNJONPA(Guid FNMGFNFDGKE, Task NIOOIEIKLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6820D40", Offset = "0x681FF40", VA = "0x186820D40")]
	private void IHJGDBCAOLB(byte FPJBJPLKLEK, int BELDNHKAMHL, object HNGEEAPPKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6821250", Offset = "0x6820450", VA = "0x186821250")]
	private void OFBEMEPIJNM(ODPGELEJKHO HDJHHNJLPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x68219D0", Offset = "0x6820BD0", VA = "0x1868219D0")]
	private void PDJAPLOMLMI(ODPGELEJKHO HDJHHNJLPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6820E10", Offset = "0x6820010", VA = "0x186820E10")]
	private void LFECDEENBAK(ODPGELEJKHO HDJHHNJLPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x681FFE0", Offset = "0x681F1E0", VA = "0x18681FFE0")]
	private CLBPNGLMFHJ CIPJIJIPFOG(LCFKPKINCJE BFKFODNNLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6821050", Offset = "0x6820250", VA = "0x186821050")]
	private void LKOHMNBBOJK(LCFKPKINCJE EPFOHBHKBLC, CLBPNGLMFHJ OHNNPIAHLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6821CD0", Offset = "0x6820ED0", VA = "0x186821CD0")]
	private bool PPLCMCOMKPL(LCFKPKINCJE EPFOHBHKBLC, CLBPNGLMFHJ OHNNPIAHLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6820960", Offset = "0x681FB60", VA = "0x186820960")]
	private bool ENKDPEKLBHN(LCFKPKINCJE BIEFMMJBOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6820630", Offset = "0x681F830", VA = "0x186820630")]
	private bool DPLHKODGAKJ(byte FPJBJPLKLEK, ExitGames.Client.Photon.Hashtable HDJHHNJLPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public JJOMMHGMOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class LCAAPLMBDHO : AIPNBMGKCEH, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class PHBCOGCNNOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public ANBJHFCMHDB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public LCAAPLMBDHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public LCFKPKINCJE roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PHBCOGCNNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x682F1D0", Offset = "0x682E3D0", VA = "0x18682F1D0")]
		internal object DJFAKIIJHJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x682F0A0", Offset = "0x682E2A0", VA = "0x18682F0A0")]
		internal object AGHBAGNEPEM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct OPCOALJKGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public LCAAPLMBDHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public LCFKPKINCJE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<CLBPNGLMFHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x682D260", Offset = "0x682C460", VA = "0x18682D260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x682D8E0", Offset = "0x682CAE0", VA = "0x18682D8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class OJIBKLGHNJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public ANBJHFCMHDB operationType;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OJIBKLGHNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x682C4A0", Offset = "0x682B6A0", VA = "0x18682C4A0")]
		internal object NDCPBNBEKOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class ODKFJPLMEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ODKFJPLMEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x682BDF0", Offset = "0x682AFF0", VA = "0x18682BDF0")]
		internal object ADLFLOIEHGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x682BE60", Offset = "0x682B060", VA = "0x18682BE60")]
		internal object KEBHNNMMHPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x682BED0", Offset = "0x682B0D0", VA = "0x18682BED0")]
		internal object ONNKJNACBLG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct MEKFEBBJDKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public LCAAPLMBDHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private ODKFJPLMEBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private LKDBPCDLEIO <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private CLBPNGLMFHJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(CLBPNGLMFHJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x68281A0", Offset = "0x68273A0", VA = "0x1868281A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6828A50", Offset = "0x6827C50", VA = "0x186828A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private PDBCIMBKOND NDOPPCBGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private KFGEKFLHNGD HLOOBBBKHEB;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6823E50", Offset = "0x6823050", VA = "0x186823E50", Slot = "5")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6823D30", Offset = "0x6822F30", VA = "0x186823D30", Slot = "4")]
	[AsyncStateMachine(typeof(OPCOALJKGAP))]
	private Task<CLBPNGLMFHJ> AMJOMMFNCFJ(LCFKPKINCJE BFKFODNNLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6823B40", Offset = "0x6822D40", VA = "0x186823B40")]
	private bool AKPLMGJMOIO(ANBJHFCMHDB BOPJNIDBFBF, [Out] CLBPNGLMFHJ HCIDHCBMOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6823F00", Offset = "0x6823100", VA = "0x186823F00")]
	[AsyncStateMachine(typeof(MEKFEBBJDKP))]
	private Task<CLBPNGLMFHJ> HBECHGHGFCO(LCFKPKINCJE AIJPHINHCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LCAAPLMBDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class PEJGOHIPOFN : EOACLIOLDGJ, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct LNIGLPJFAJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<HGFIJEMHMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public PEJGOHIPOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<NHHLGHBJLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6825460", Offset = "0x6824660", VA = "0x186825460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6825910", Offset = "0x6824B10", VA = "0x186825910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class KLBODCECHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KLBODCECHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x68225F0", Offset = "0x68217F0", VA = "0x1868225F0")]
		internal object DLNLJDLMKJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct CIBPHFPJJPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<NHHLGHBJLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public PEJGOHIPOFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public NKKGGOEDKKI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private KLBODCECHAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<NHHLGHBJLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6816100", Offset = "0x6815300", VA = "0x186816100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x68166F0", Offset = "0x68158F0", VA = "0x1868166F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class NFPHPDKIABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NFPHPDKIABN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x15121E0", Offset = "0x15113E0", VA = "0x1815121E0")]
		internal bool EIHFEGHMPIB(JEGONNFCHHM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private PKBHMGEALOP PJCBMHHGNIN;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (CBHGKMFEFBA superRoomData, long subRoomDataSaveId) KMDJCADCBFE;

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x682EB00", Offset = "0x682DD00", VA = "0x18682EB00", Slot = "5")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x682EE70", Offset = "0x682E070", VA = "0x18682EE70", Slot = "4")]
	[AsyncStateMachine(typeof(LNIGLPJFAJP))]
	public Task<HGFIJEMHMDL> LCNKKOOBEMA(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, NKKGGOEDKKI LPFEKEJDECG, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x682E860", Offset = "0x682DA60", VA = "0x18682E860")]
	[AsyncStateMachine(typeof(CIBPHFPJJPB))]
	private Task<NHHLGHBJLHK> BPECANFBCIN(NKKGGOEDKKI LPFEKEJDECG, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x682E9C0", Offset = "0x682DBC0", VA = "0x18682E9C0")]
	private HGFIJEMHMDL EOKIMILILDK(NKKGGOEDKKI LPFEKEJDECG, NHHLGHBJLHK BOJALOCECAH, long PFDCKFHEHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x682EB90", Offset = "0x682DD90", VA = "0x18682EB90")]
	private (CBHGKMFEFBA, long) IPHAPBFLPCH(NKKGGOEDKKI LPFEKEJDECG, NHHLGHBJLHK BOJALOCECAH, long PFDCKFHEHAO)
	{
		return default((CBHGKMFEFBA, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public PEJGOHIPOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class OODDKFAGPEC : GCOHNJIAJNE, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class IPABMHJKKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IPABMHJKKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x681FE50", Offset = "0x681F050", VA = "0x18681FE50")]
		internal object PMDOLLIMBAL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct HDFLHONCKEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public OODDKFAGPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public NPDCGEHACLF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x681E3F0", Offset = "0x681D5F0", VA = "0x18681E3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x681EA00", Offset = "0x681DC00", VA = "0x18681EA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct LPHAANBFCLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public OODDKFAGPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public NPDCGEHACLF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<GEDHCDCGALC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6825980", Offset = "0x6824B80", VA = "0x186825980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6825F70", Offset = "0x6825170", VA = "0x186825F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class DHLFAJEDJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DHLFAJEDJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x68177B0", Offset = "0x68169B0", VA = "0x1868177B0")]
		internal object HDOKFAPONPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct NEMEKMPMMII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public LCFKPKINCJE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public OODDKFAGPEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public NPDCGEHACLF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private GGJDEFLOIPM <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private PAJECFLOFKB <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<GEDHCDCGALC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x682A980", Offset = "0x6829B80", VA = "0x18682A980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x682B570", Offset = "0x682A770", VA = "0x18682B570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private ICHLIAAGBAC FPJIKJONOGO;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private NICLHLHNPCI ILFDKCDHKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x682CAD0", Offset = "0x682BCD0", VA = "0x18682CAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x682CB90", Offset = "0x682BD90", VA = "0x18682CB90", Slot = "8")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x682D100", Offset = "0x682C300", VA = "0x18682D100", Slot = "4")]
	[AsyncStateMachine(typeof(HDFLHONCKEJ))]
	public Task<LCFKPKINCJE> NKJMNMCFNFO(LCFKPKINCJE AIJPHINHCJO, NPDCGEHACLF NFGPOMNPCEM, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x682CFB0", Offset = "0x682C1B0", VA = "0x18682CFB0", Slot = "5")]
	[AsyncStateMachine(typeof(LPHAANBFCLC))]
	public Task<LCFKPKINCJE> JLEOKOMDMMJ(CancellationToken AIHJHMPAHCH, NPDCGEHACLF NFGPOMNPCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x682C8C0", Offset = "0x682BAC0", VA = "0x18682C8C0", Slot = "6")]
	public MABGKFLOIKH CEEHGHPHPOJ(JIEBELBAAKC MKFHDDOCFKJ, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x682CD80", Offset = "0x682BF80", VA = "0x18682CD80", Slot = "7")]
	public MABGKFLOIKH HHLKNKMIIPP(JIEBELBAAKC MKFHDDOCFKJ, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x682CC20", Offset = "0x682BE20", VA = "0x18682CC20")]
	[AsyncStateMachine(typeof(NEMEKMPMMII))]
	private Task<LCFKPKINCJE> HGLGHGDCOCO(LCFKPKINCJE AIJPHINHCJO, NPDCGEHACLF NFGPOMNPCEM, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2999B10", Offset = "0x2998D10", VA = "0x182999B10")]
	private static byte[] GOLKAHPFGEP(LCFKPKINCJE JGNAJPMGGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OODDKFAGPEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class CDHIADCPDPD : PDBCIMBKOND, LOKHFHAIAGB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private MGPEOOIOMID PCNAPNOPGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private LKMPHPGNAPE IMNGHAMHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private CPLOJIIHHMI HHNKGOBMDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private CNPCBBPHNOI KNHOGNCICBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private FBOOGLCDAAH EMLEOAEKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private PKOGCFGFLLG GPNOOFEABCC;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6813CC0", Offset = "0x6812EC0", VA = "0x186813CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private static CLBPNGLMFHJ EOHHBNNCKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6812CE0", Offset = "0x6811EE0", VA = "0x186812CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6813D10", Offset = "0x6812F10", VA = "0x186813D10", Slot = "6")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6813B50", Offset = "0x6812D50", VA = "0x186813B50", Slot = "4")]
	public CLBPNGLMFHJ AFBGAMNEOBN(EOBANJCDGLI HACPMNFMAID, ANBJHFCMHDB EPNKNGICODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6813E80", Offset = "0x6813080", VA = "0x186813E80", Slot = "5")]
	public CLBPNGLMFHJ HKDBNGMOCCL(EOBANJCDGLI OKOCHAOMKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6812C80", Offset = "0x6811E80", VA = "0x186812C80")]
	private static CLBPNGLMFHJ HBOANOEFADM(JLHOFAIKPIE LGGFDGCPFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CDHIADCPDPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class HLLIBMHEODN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x681F0B0", Offset = "0x681E2B0", VA = "0x18681F0B0")]
	public HLLIBMHEODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5D64C10", Offset = "0x5D63E10", VA = "0x185D64C10")]
	public HLLIBMHEODN(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class CJMIAHJGJFK : AFAAJGFFFEK, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct LBGEBLCKKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public CJMIAHJGJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public OBBCDGFHJBJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private OPAMPAFNBOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private HCBNECMDJDN <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<CLBPNGLMFHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6822F40", Offset = "0x6822140", VA = "0x186822F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6823AD0", Offset = "0x6822CD0", VA = "0x186823AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct MMKDMPFCNEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CJMIAHJGJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6828E70", Offset = "0x6828070", VA = "0x186828E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x68295A0", Offset = "0x68287A0", VA = "0x1868295A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct BJLNAINKMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public CJMIAHJGJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x68135E0", Offset = "0x68127E0", VA = "0x1868135E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6813AF0", Offset = "0x6812CF0", VA = "0x186813AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NNGAOBLIIOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public CJMIAHJGJFK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x682B640", Offset = "0x682A840", VA = "0x18682B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x682BD90", Offset = "0x682AF90", VA = "0x18682BD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct HBGIJCGBKOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public CJMIAHJGJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x681CAE0", Offset = "0x681BCE0", VA = "0x18681CAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x681CC80", Offset = "0x681BE80", VA = "0x18681CC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GOBBAHOBFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CJMIAHJGJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x681BDB0", Offset = "0x681AFB0", VA = "0x18681BDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x681C4C0", Offset = "0x681B6C0", VA = "0x18681C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct GNNOJAHFLOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public CJMIAHJGJFK <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x681B8E0", Offset = "0x681AAE0", VA = "0x18681B8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x681BD50", Offset = "0x681AF50", VA = "0x18681BD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct GOLKOAONKMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CJMIAHJGJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public EDCMFPOJOOL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private OPAMPAFNBOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x681C520", Offset = "0x681B720", VA = "0x18681C520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x681CA80", Offset = "0x681BC80", VA = "0x18681CA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private OBJHGLENMNO DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private GCOHNJIAJNE OGOGDPCHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private LKMPHPGNAPE IMNGHAMHPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private FBOOGLCDAAH EMLEOAEKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource PLPGODDOFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task GLINMENHKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> LCPAKGMBHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int POKNDHBKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private int PLMBNFGBOCP;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6816DF0", Offset = "0x6815FF0", VA = "0x186816DF0", Slot = "6")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x920FF0", Offset = "0x9201F0", VA = "0x180920FF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6817580", Offset = "0x6816780", VA = "0x186817580")]
	private void NFDKPCBCHJL(float MADHCJOKCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6816BD0", Offset = "0x6815DD0", VA = "0x186816BD0", Slot = "4")]
	[AsyncStateMachine(typeof(LBGEBLCKKHC))]
	public Task<CLBPNGLMFHJ> DNFNDMKOJEP(OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6816D00", Offset = "0x6815F00", VA = "0x186816D00", Slot = "5")]
	[AsyncStateMachine(typeof(MMKDMPFCNEC))]
	public Task EAJCJPCJKGC([Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x920FF0", Offset = "0x9201F0", VA = "0x180920FF0")]
	public void KHPNGABOEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x68170B0", Offset = "0x68162B0", VA = "0x1868170B0")]
	private HCBNECMDJDN IMHLIIIKOML(OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6816760", Offset = "0x6815960", VA = "0x186816760")]
	[AsyncStateMachine(typeof(BJLNAINKMMA))]
	private Task BJICBBDPAGK(OHJENCCOGPB PMBMOONGPPJ, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x68169E0", Offset = "0x6815BE0", VA = "0x1868169E0")]
	[AsyncStateMachine(typeof(NNGAOBLIIOC))]
	private Task CNOKIKELJPB(CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6816AE0", Offset = "0x6815CE0", VA = "0x186816AE0")]
	[AsyncStateMachine(typeof(HBGIJCGBKOO))]
	private Task DMADPOBMOLA([Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6817660", Offset = "0x6816860", VA = "0x186817660")]
	[AsyncStateMachine(typeof(GOBBAHOBFIK))]
	private Task NGCMKLFBAAH(CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6817220", Offset = "0x6816420", VA = "0x186817220")]
	[AsyncStateMachine(typeof(GNNOJAHFLOM))]
	private Task MDFEADPKPGN(CancellationToken FHFDMEEJLAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6816850", Offset = "0x6815A50", VA = "0x186816850")]
	private Task CNCKAHIOHAH(EDCMFPOJOOL GBMDEGJEOMP, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6816FA0", Offset = "0x68161A0", VA = "0x186816FA0")]
	[AsyncStateMachine(typeof(GOLKOAONKMA))]
	private Task GHOLEPEEGCE(EDCMFPOJOOL GBMDEGJEOMP, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6817320", Offset = "0x6816520", VA = "0x186817320")]
	private bool MPEDEKGIEMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CJMIAHJGJFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class FECHPCPPDCL : CPLOJIIHHMI, LOKHFHAIAGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct CECBNDIHAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public FECHPCPPDCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private OPAMPAFNBOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6814180", Offset = "0x6813380", VA = "0x186814180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x68146E0", Offset = "0x68138E0", VA = "0x1868146E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private HFOFKAHADJK JKDOMIKLCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private PDBCIMBKOND NDOPPCBGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private GCOHNJIAJNE OGOGDPCHLDI;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6818570", Offset = "0x6817770", VA = "0x186818570", Slot = "6")]
	public void GEJAFFIMNGM(CKDPMMHNMPI GLFBENAFDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6818520", Offset = "0x6817720", VA = "0x186818520", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x68188B0", Offset = "0x6817AB0", VA = "0x1868188B0", Slot = "5")]
	[AsyncStateMachine(typeof(CECBNDIHAAF))]
	public Task NAKEODOMNFL(string INJNFIJDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6818850", Offset = "0x6817A50", VA = "0x186818850", Slot = "4")]
	public CLBPNGLMFHJ MPEDEKGIEMK(EOBANJCDGLI HACPMNFMAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x68189B0", Offset = "0x6817BB0", VA = "0x1868189B0")]
	private EIBKFPBBABI PHGAKMLHJBN(string INJNFIJDPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public FECHPCPPDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class MODFFDEIFIF
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6829B40", Offset = "0x6828D40", VA = "0x186829B40")]
	public static void KNLEKDEJHEN(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x68299E0", Offset = "0x6828BE0", VA = "0x1868299E0")]
	internal static void IGNDFKNHABE(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6829D80", Offset = "0x6828F80", VA = "0x186829D80")]
	internal static void LCGJHNMAIHB(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6829E60", Offset = "0x6829060", VA = "0x186829E60")]
	internal static void NEMAGJFJDIB(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class HOOIEOEPJLK : HEEEMAOLPMJ<LCFKPKINCJE>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class MKIPJGCMDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public LCFKPKINCJE message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public MKIPJGCMDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6828B20", Offset = "0x6827D20", VA = "0x186828B20")]
		internal object KMOIOJLJGEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly HOOIEOEPJLK KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x681F760", Offset = "0x681E960", VA = "0x18681F760")]
	public ExitGames.Client.Photon.Hashtable OHDBDPJBHPM(LCFKPKINCJE JGNAJPMGGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x681F630", Offset = "0x681E830", VA = "0x18681F630", Slot = "5")]
	protected override void MFMKLNPOGJK(LCFKPKINCJE JGNAJPMGGNE, IDictionary<object, object> FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x681F400", Offset = "0x681E600", VA = "0x18681F400", Slot = "6")]
	public override LCFKPKINCJE LKMADFBDLGL(IDictionary<object, object> FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x681F7F0", Offset = "0x681E9F0", VA = "0x18681F7F0")]
	private static void PHDBFKGPBFI(string PCECLFKEFEM, LCFKPKINCJE JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x681F990", Offset = "0x681EB90", VA = "0x18681F990")]
	public HOOIEOEPJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x681F160", Offset = "0x681E360", VA = "0x18681F160")]
	[CompilerGenerated]
	internal static string IOFOEBADNPC(HGFIJEMHMDL AENCBMJJMMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class AGJMPFECGLI
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public static CLBPNGLMFHJ EOHHBNNCKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6812CE0", Offset = "0x6811EE0", VA = "0x186812CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6812F30", Offset = "0x6812130", VA = "0x186812F30")]
	public static bool NALLKPDDINJ(this CLBPNGLMFHJ OHNNPIAHLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6812C80", Offset = "0x6811E80", VA = "0x186812C80")]
	public static CLBPNGLMFHJ HBOANOEFADM(JLHOFAIKPIE LMKMEAKIJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6812D40", Offset = "0x6811F40", VA = "0x186812D40")]
	public static CLBPNGLMFHJ MFDFNMPLIBP(IEnumerable<CLBPNGLMFHJ> FOIFCALCOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6812A30", Offset = "0x6811C30", VA = "0x186812A30")]
	public static string CHMCDMGBIDG(this CLBPNGLMFHJ HCIDHCBMOPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class EJJIGDCAKED : AHDENFDGCLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate CLBPNGLMFHJ NAAELOJPMKP([NotNull] EOBANJCDGLI LIJBEKJMDCD);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class HCGIBBMKAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public EOBANJCDGLI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HCGIBBMKAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5F4A3C0", Offset = "0x5F495C0", VA = "0x185F4A3C0")]
		internal CLBPNGLMFHJ MJKFGACAJIN(NAAELOJPMKP v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool OEJOJKGONDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	protected readonly HashSet<NAAELOJPMKP> JGDCIOPKACD;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6817810", Offset = "0x6816A10", VA = "0x186817810", Slot = "4")]
	public void AGIPFFNLIAG(NAAELOJPMKP NIDMDMJANBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x68178C0", Offset = "0x6816AC0", VA = "0x1868178C0", Slot = "5")]
	public void LOALAKIAEDF(NAAELOJPMKP NIDMDMJANBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6817870", Offset = "0x6816A70", VA = "0x186817870", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6817920", Offset = "0x6816B20", VA = "0x186817920")]
	protected CLBPNGLMFHJ NENMNFMECKB(EOBANJCDGLI OKOCHAOMKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6817BB0", Offset = "0x6816DB0", VA = "0x186817BB0")]
	protected EJJIGDCAKED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class OGNOKFGHMHF : EJJIGDCAKED, MGPEOOIOMID, AHDENFDGCLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class KCDODFFCABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public CLBPNGLMFHJ result;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KCDODFFCABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6822590", Offset = "0x6821790", VA = "0x186822590")]
		internal object IAEGIPDPGLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x682C490", Offset = "0x682B690", VA = "0x18682C490")]
	[UnityEngine.Scripting.Preserve]
	public OGNOKFGHMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x682C380", Offset = "0x682B580", VA = "0x18682C380", Slot = "8")]
	public CLBPNGLMFHJ GGABKAOPIEG(EOBANJCDGLI OKOCHAOMKHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PBIGOPEONEI : EJJIGDCAKED, HFOFKAHADJK, AHDENFDGCLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class CLLFHIDBAKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public CLBPNGLMFHJ result;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CLLFHIDBAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6817750", Offset = "0x6816950", VA = "0x186817750")]
		internal object NOPNLFKHINP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x682C490", Offset = "0x682B690", VA = "0x18682C490")]
	[UnityEngine.Scripting.Preserve]
	public PBIGOPEONEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x682E750", Offset = "0x682D950", VA = "0x18682E750", Slot = "8")]
	public CLBPNGLMFHJ MPEDEKGIEMK(EOBANJCDGLI NEJMNOMAPNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class ELIKKNALILK
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class BIOODOJEDLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public OPAMPAFNBOH<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BIOODOJEDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6813150", Offset = "0x6812350", VA = "0x186813150")]
		internal object KKHDBMEKKEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6817D00", Offset = "0x6816F00", VA = "0x186817D00")]
	public static OPAMPAFNBOH<string> KOGBBNACDCP(JJNHGMIGPBK OMJOPGOBIEL, [Optional] string ICMGFDLIOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6817C40", Offset = "0x6816E40", VA = "0x186817C40")]
	public static void IFMCEGCPMOO(OPAMPAFNBOH<string> NEKANGAICOD, JJNHGMIGPBK OMJOPGOBIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6817DE0", Offset = "0x6816FE0", VA = "0x186817DE0")]
	public static string NMMLKMJAHDH(LCFKPKINCJE BFKFODNNLGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class KMBKHDOIMFD
{
	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x68227D0", Offset = "0x68219D0", VA = "0x1868227D0")]
	public static void PCBLABFJHLB(this OBJHGLENMNO DAHFMHKAMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x68227C0", Offset = "0x68219C0", VA = "0x1868227C0")]
	public static void FPCCCONJMJH(this OBJHGLENMNO DAHFMHKAMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x68226A0", Offset = "0x68218A0", VA = "0x1868226A0")]
	private static void CBIPKCGALDP(this OBJHGLENMNO DAHFMHKAMCF, bool HFGICHMIAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class CFAAIGOHNHO : IDFKNJPLPNF, OCKCFEKJNDD, JEMAMLJMOAJ, ECIHHGBBJLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly OCKCFEKJNDD AMKNDJKEGHO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public EOBANJCDGLI ABNGLKMDABA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6814C10", Offset = "0x6813E10", VA = "0x186814C10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int GGBMHFPPAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x68147E0", Offset = "0x68139E0", VA = "0x1868147E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int MFDBFBCAPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6814C60", Offset = "0x6813E60", VA = "0x186814C60", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool KCAKKPDCFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int POHBPPHOEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GKGHBAGEHCP.JBPNPHOKAGD CPNCONGOADC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event BOGMAMPFFJH PDABJIAGBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x6814830", Offset = "0x6813A30", VA = "0x186814830", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x6814B70", Offset = "0x6813D70", VA = "0x186814B70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> DCBNPHHNLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<EOBANJCDGLI> OIKBBKJCEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action EMFFHDCFPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6814740", Offset = "0x6813940", VA = "0x186814740", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x68148D0", Offset = "0x6813AD0", VA = "0x1868148D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xDB3350", Offset = "0xDB2550", VA = "0x180DB3350")]
	public CFAAIGOHNHO(OCKCFEKJNDD AMKNDJKEGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6814990", Offset = "0x6813B90", VA = "0x186814990", Slot = "8")]
	public bool HDHLMKMEOJN(byte FPJBJPLKLEK, ExitGames.Client.Photon.Hashtable APMJANJEBHL, KCNGHENMIOJ BNOEFLCKBCJ, SendOptions HGJJEEMHIIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6814A90", Offset = "0x6813C90", VA = "0x186814A90", Slot = "16")]
	public EOBANJCDGLI JIPOPEACJAD(int KEDKJAFJCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "19")]
	public void HFBKEGJGGJD(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "20")]
	public void DNPJMCPHGCO(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "21")]
	public void FEALGGBMPNH(object FCKLPDKGPKE, bool GKNNBHKDIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6814A40", Offset = "0x6813C40", VA = "0x186814A40", Slot = "22")]
	public IDisposable IPAMNOKLOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "23")]
	private bool LONBCNHCLON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "24")]
	public void LPNFILDEBNO(StringBuilder HPPPECOCDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6814970", Offset = "0x6813B70", VA = "0x186814970", Slot = "25")]
	public bool GLHAMKNKDJC(bool HCDAEKNAEDA, [Out] string BKDLFDLOKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x820AF0", Offset = "0x81FCF0", VA = "0x180820AF0", Slot = "28")]
	public void FGCCPDLOLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct ODPGELEJKHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly IDictionary<object, object> HDJHHNJLPKL;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	public ODPGELEJKHO(IDictionary<object, object> HDJHHNJLPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x682C1E0", Offset = "0x682B3E0", VA = "0x18682C1E0")]
	public bool JENEJDGHKOL([Out] LCFKPKINCJE JGNAJPMGGNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x682C000", Offset = "0x682B200", VA = "0x18682C000")]
	public Guid CFHJLLMADDH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x682C0B0", Offset = "0x682B2B0", VA = "0x18682C0B0")]
	public CLBPNGLMFHJ EJKMIJKNFLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x682C290", Offset = "0x682B490", VA = "0x18682C290")]
	public static ExitGames.Client.Photon.Hashtable LAFNMEJJDLL(LCFKPKINCJE JGNAJPMGGNE, CLBPNGLMFHJ OHNNPIAHLOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class FMMCDKCEEGN
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6818EC0", Offset = "0x68180C0", VA = "0x186818EC0")]
	public static bool BHFKIHDBFAM(this NKKGGOEDKKI GNBINPCIBGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct IBFHGCCAHAJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct PAIEPLEFOIC : IAsyncStateMachine
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
		public IBFHGCCAHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x682D950", Offset = "0x682CB50", VA = "0x18682D950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x682DB30", Offset = "0x682CD30", VA = "0x18682DB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CancellationTokenSource MODHBCLCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private bool OEJOJKGONDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private Task OCAKELEHPCL;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool KMIBCIBKNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x681FB30", Offset = "0x681ED30", VA = "0x18681FB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x681FB60", Offset = "0x681ED60", VA = "0x18681FB60")]
	public IBFHGCCAHAJ(CancellationToken AIHJHMPAHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x681F9D0", Offset = "0x681EBD0", VA = "0x18681F9D0")]
	[AsyncStateMachine(typeof(PAIEPLEFOIC))]
	public Task ALILLFLEAGL(Func<CancellationToken, List<Task>> FKPIBJMKCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x681FAE0", Offset = "0x681ECE0", VA = "0x18681FAE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct CHFMDHGNPGN<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct AKIACHCJFPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<IILLLDDOIAK<TData>, OMPNGPMCKPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public CHFMDHGNPGN<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<NFMFLMAOFMP<IILLLDDOIAK<TData>, OMPNGPMCKPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A0E190", Offset = "0x3A0D390", VA = "0x183A0E190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A0ED20", Offset = "0x3A0DF20", VA = "0x183A0ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly FFKANCAOGGC<TGetDataArg, TData> KDDFIFIFPAP;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	internal CHFMDHGNPGN(FFKANCAOGGC<TGetDataArg, TData> NMAKCOKENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B64F50", Offset = "0x4B64150", VA = "0x184B64F50")]
	[AsyncStateMachine(typeof(CHFMDHGNPGN<, >.AKIACHCJFPG))]
	public Task<NFMFLMAOFMP<IILLLDDOIAK<TData>, OMPNGPMCKPG>> ILFFMCEIAEC(TGetDataArg GFMMLICJDDH, string GGJPPILLMCD, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class LOGJONMMPAA
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x257C0D0", Offset = "0x257B2D0", VA = "0x18257C0D0")]
	public static CHFMDHGNPGN<TGetDataArg, TData> MIJABIECKKD<TGetDataArg, TData>(FFKANCAOGGC<TGetDataArg, TData> NMAKCOKENKA)
	{
		return default(CHFMDHGNPGN<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct ICHAIDJLLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int DAFCJBAAEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public readonly int? FCBOEPJGFDP;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FF70", Offset = "0x3D0F170", VA = "0x183D0FF70")]
	public ICHAIDJLLCH(int HALDHGGLICI, [Optional] int? PBFEJNMBMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x681FC90", Offset = "0x681EE90", VA = "0x18681FC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface LLLMPFICIKB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIPOAKAACPJ();

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLLMPFICIKB<T> FNICFGCFDIP(string NHPIJCGMDPF);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LLLMPFICIKB<T> GGJBJEBBCFG(LHOFOBKAKGE<T> GEODDKFLJDL);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LLLMPFICIKB<T> MLBPILJAAAK(int PIMNPCCLOAF);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LLLMPFICIKB<T> JKEIHBHABFC(int PIMNPCCLOAF, KIAOKCHABOI<T> LIPGKHCIJPL);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface FMEGAJMCBII
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLLMPFICIKB<T> FKBHEIGHGNN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPMCLLCGLOM AFMMIKDGDNP(Exception PGAHDJGBLJL);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICHAIDJLLCH BDIGDOIOPPB(Exception PGAHDJGBLJL);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string LHOFOBKAKGE<in T>(T PGAHDJGBLJL) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int KIAOKCHABOI<in T>(T PGAHDJGBLJL) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class HCHPEFIBKDM : FMEGAJMCBII
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string BKOJOEABOBE(Exception PGAHDJGBLJL);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int ONILACGILGM(Exception PGAHDJGBLJL);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class DLJFDLJNBDN<T> : LLLMPFICIKB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class AFCKAKJKNLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public AFCKAKJKNLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			internal string PGEFFALIEOL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class KEJJLCCLMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public LHOFOBKAKGE<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public KEJJLCCLMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x38CA520", Offset = "0x38C9720", VA = "0x1838CA520")]
			internal string PAKFAJJPMNI(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class GPHLHAGMMKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public KIAOKCHABOI<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public GPHLHAGMMKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x38CA520", Offset = "0x38C9720", VA = "0x1838CA520")]
			internal int HLLGHGKIOMA(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly HCHPEFIBKDM IEDLNEDDMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Type OIGIFMODPAC;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x51300E0", Offset = "0x512F2E0", VA = "0x1851300E0")]
		internal DLJFDLJNBDN(HCHPEFIBKDM IEDLNEDDMPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5130070", Offset = "0x512F270", VA = "0x185130070", Slot = "4")]
		public void LIPOAKAACPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x512FD50", Offset = "0x512EF50", VA = "0x18512FD50", Slot = "5")]
		public LLLMPFICIKB<T> FNICFGCFDIP(string NHPIJCGMDPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x512FE50", Offset = "0x512F050", VA = "0x18512FE50", Slot = "6")]
		public LLLMPFICIKB<T> GGJBJEBBCFG(LHOFOBKAKGE<T> GEODDKFLJDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x51300A0", Offset = "0x512F2A0", VA = "0x1851300A0", Slot = "7")]
		public LLLMPFICIKB<T> MLBPILJAAAK(int PIMNPCCLOAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x512FF50", Offset = "0x512F150", VA = "0x18512FF50", Slot = "8")]
		public LLLMPFICIKB<T> JKEIHBHABFC(int PIMNPCCLOAF, KIAOKCHABOI<T> LIPGKHCIJPL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class NGLHEHHDJFK<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool GBNLNPGNKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly List<Type> KLOAAPHNOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, TVal> KDCPCPDICPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Dictionary<Type, int> GOFBFOIKCOP;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public IReadOnlyList<Type> JMBMGGCOGFL
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x40402D0", Offset = "0x403F4D0", VA = "0x1840402D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4040870", Offset = "0x403FA70", VA = "0x184040870")]
		public NGLHEHHDJFK(Dictionary<Type, int> GOFBFOIKCOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x40405F0", Offset = "0x403F7F0", VA = "0x1840405F0")]
		public void OEOPOJPHCNL(Type GOBGGNLGONA, TVal LJPPKNAEGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x40406E0", Offset = "0x403F8E0", VA = "0x1840406E0")]
		public bool OJLKBFPPAGH(Type OIGIFMODPAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x4040380", Offset = "0x403F580", VA = "0x184040380")]
		public bool KHCBIMCENPA(TVal NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4040720", Offset = "0x403F920", VA = "0x184040720")]
		public TVal OLBNKGLEPPK(Type FLPJMDMACMC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x40403C0", Offset = "0x403F5C0", VA = "0x1840403C0")]
		[CompilerGenerated]
		private int NJPDEOJCHGM(Type EBGFCCMKGOM, Type GMKKNPOPCJP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class GFJLBFNOLGB : IEnumerable<ICHAIDJLLCH>, IEnumerable, IEnumerator<ICHAIDJLLCH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private ICHAIDJLLCH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public HCHPEFIBKDM <>4__this;

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
		private IEnumerator<ICHAIDJLLCH> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		private ICHAIDJLLCH System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x34FEC90", Offset = "0x34FDE90", VA = "0x1834FEC90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ICHAIDJLLCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x681B460", Offset = "0x681A660", VA = "0x18681B460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public GFJLBFNOLGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x681B4B0", Offset = "0x681A6B0", VA = "0x18681B4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x681AE50", Offset = "0x681A050", VA = "0x18681AE50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x681AE00", Offset = "0x681A000", VA = "0x18681AE00")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x681B300", Offset = "0x681A500", VA = "0x18681B300")]
		private void OFANLJKOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x681B410", Offset = "0x681A610", VA = "0x18681B410", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x681B350", Offset = "0x681A550", VA = "0x18681B350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ICHAIDJLLCH> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x681B350", Offset = "0x681A550", VA = "0x18681B350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly ICHAIDJLLCH CAHJMNBJPCK;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private static readonly Dictionary<Type, int> JCJEFEMHAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly HashSet<Type> MFEPKNIBPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly NGLHEHHDJFK<int> HAEDNJOOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly NGLHEHHDJFK<ONILACGILGM> MLMLBHBJLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly NGLHEHHDJFK<BKOJOEABOBE> JPKPLHOJFKF;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x681DE10", Offset = "0x681D010", VA = "0x18681DE10")]
	[KEFCCLBEAOJ(CMEECPGEPNF.GameOnly)]
	private static void MOJFLBKELFO(LEHDPNIFNIH AJCCGGFMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x681E0C0", Offset = "0x681D2C0", VA = "0x18681E0C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HCHPEFIBKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0", Slot = "4")]
	public LLLMPFICIKB<T> FKBHEIGHGNN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x681CCE0", Offset = "0x681BEE0", VA = "0x18681CCE0", Slot = "5")]
	public KPMCLLCGLOM AFMMIKDGDNP(Exception PGAHDJGBLJL)
	{
		return default(KPMCLLCGLOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x681CD70", Offset = "0x681BF70", VA = "0x18681CD70", Slot = "6")]
	public ICHAIDJLLCH BDIGDOIOPPB(Exception? PGAHDJGBLJL)
	{
		return default(ICHAIDJLLCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x681D540", Offset = "0x681C740", VA = "0x18681D540", Slot = "7")]
	[IteratorStateMachine(typeof(GFJLBFNOLGB))]
	public IEnumerable<ICHAIDJLLCH> DGPEBENOBLD(Exception PGAHDJGBLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x681DCC0", Offset = "0x681CEC0", VA = "0x18681DCC0", Slot = "8")]
	public string MJOIMNJOBHJ(Exception? PGAHDJGBLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x681D240", Offset = "0x681C440", VA = "0x18681D240")]
	private string CDAKOKGJMME(AggregateException HDCBFHINFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x681D5E0", Offset = "0x681C7E0", VA = "0x18681D5E0")]
	private void EMLOOPLJEDE(Type OIGIFMODPAC, int PIMNPCCLOAF, ONILACGILGM? KPPOFHHLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x681DA70", Offset = "0x681CC70", VA = "0x18681DA70")]
	private void MDGOMDNHMIE(Type OIGIFMODPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x681CF70", Offset = "0x681C170", VA = "0x18681CF70")]
	private void BEFELJAFPMD(Type OIGIFMODPAC, BKOJOEABOBE GNMCPHKIPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x681DE80", Offset = "0x681D080", VA = "0x18681DE80")]
	private static int PBACKNGLGNF(Type OIGIFMODPAC, Dictionary<Type, int> GOFBFOIKCOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2904520", Offset = "0x2903720", VA = "0x182904520")]
	private static bool JHJICNFDEND<TVal>(NGLHEHHDJFK<TVal> NGOGJHGFHFE, Type OIGIFMODPAC, [Out] TVal NICEPFIEJED) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x681D990", Offset = "0x681CB90", VA = "0x18681D990")]
	[CompilerGenerated]
	internal static int FIKMFFFGCFP(Type CJEHDJDOKEG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct KPMCLLCGLOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly ICHAIDJLLCH JDDINAIHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public readonly string NDBEDAMFDDL;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6822F20", Offset = "0x6822120", VA = "0x186822F20")]
	public KPMCLLCGLOM(string AACGBHJKFMC, ICHAIDJLLCH PIMNPCCLOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6822E80", Offset = "0x6822080", VA = "0x186822E80")]
	public string OPKJJOEAIHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class FPEHBHJFGEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly DCHOBEMLODE EAODOAACOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private string NONDEKFIHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? JIJKJBADODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? FAHIMBOIIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? LKMIAPBMKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private string NBNLOOMDPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private PHAOMCMINAH MEKNNMFJFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private long? ENDPLLPLGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool DLOLJLGMNBA;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string CLNFLLMDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long CKPCFIGIBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6819300", Offset = "0x6818500", VA = "0x186819300")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long OHDGICOCCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6819050", Offset = "0x6818250", VA = "0x186819050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long PEJCAAFHKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x68193A0", Offset = "0x68185A0", VA = "0x1868193A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string EBEIMEJBOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6819360", Offset = "0x6818560", VA = "0x186819360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public PHAOMCMINAH FIFCJAAIJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDCF750", Offset = "0xDCE950", VA = "0x180DCF750")]
		get
		{
			return default(PHAOMCMINAH);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6819400", Offset = "0x6818600", VA = "0x186819400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public long DPLOHKGPDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6819D80", Offset = "0x6818F80", VA = "0x186819D80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6819DE0", Offset = "0x6818FE0", VA = "0x186819DE0")]
	[UnityEngine.Scripting.Preserve]
	public FPEHBHJFGEH([GAGPBLHNPNO(null)] DCHOBEMLODE EAODOAACOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x68190B0", Offset = "0x68182B0", VA = "0x1868190B0")]
	private void BLGKDMKFNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6819570", Offset = "0x6818770", VA = "0x186819570")]
	public void MKFCMKIDOOI(long NCFOOPOBBIJ, long PFDCKFHEHAO, [Optional] long? LGMIMPLLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6818FB0", Offset = "0x68181B0", VA = "0x186818FB0")]
	public void AFPFIHEFKBP(long LGMIMPLLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x68194F0", Offset = "0x68186F0", VA = "0x1868194F0")]
	public void KLIDDGPHNBN(string EENAJONDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6819A00", Offset = "0x6818C00", VA = "0x186819A00")]
	public void OJAPDIDOBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class MABGKFLOIKH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct HFPFCBHJKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public LCFKPKINCJE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public MABGKFLOIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<NICLHLHNPCI.IMDMDKAJFGO<LCFKPKINCJE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x681EB10", Offset = "0x681DD10", VA = "0x18681EB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x681F040", Offset = "0x681E240", VA = "0x18681F040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct MPKNOJEGIKB<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class ILCCHPFGGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public LCFKPKINCJE roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ILCCHPFGGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x681FD70", Offset = "0x681EF70", VA = "0x18681FD70")]
		internal LCFKPKINCJE FBFKGKABGAA(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct FCIPCGLLGHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder<NICLHLHNPCI.IMDMDKAJFGO<LCFKPKINCJE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public LCFKPKINCJE roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public MABGKFLOIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private GGJDEFLOIPM <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<NICLHLHNPCI.IMDMDKAJFGO<LCFKPKINCJE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6817EA0", Offset = "0x68170A0", VA = "0x186817EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x68184B0", Offset = "0x68176B0", VA = "0x1868184B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct DLAGAFKLECA<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public MABGKFLOIKH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x512E480", Offset = "0x512D680", VA = "0x18512E480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x38A7C20", Offset = "0x38A6E20", VA = "0x1838A7C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct GMAPIECEFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public MABGKFLOIKH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x681B660", Offset = "0x681A860", VA = "0x18681B660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x681B820", Offset = "0x681AA20", VA = "0x18681B820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class AINHAHAFMPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AINHAHAFMPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6812F50", Offset = "0x6812150", VA = "0x186812F50")]
		internal object JAKILBNGOJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x6812FB0", Offset = "0x68121B0", VA = "0x186812FB0")]
		internal bool KGJFCBLOMNP(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class NKOJBCLPOAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NKOJBCLPOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x682B5E0", Offset = "0x682A7E0", VA = "0x18682B5E0")]
		internal object KOAELGJKFCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class HNJPLNKHJAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HNJPLNKHJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x681F0F0", Offset = "0x681E2F0", VA = "0x18681F0F0")]
		internal object BAFOFBCPLIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class NADAPFODGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NADAPFODGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x682A2B0", Offset = "0x68294B0", VA = "0x18682A2B0")]
		internal object JDNLLBGPLBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class NDMDHONOEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public MABGKFLOIKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NDMDHONOEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x682A440", Offset = "0x6829640", VA = "0x18682A440")]
		internal object KMOIOJLJGEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Guid MEOKEMIHGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly JIEBELBAAKC JMKNKBLEADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly NICLHLHNPCI KIMKADOOFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly JEMAMLJMOAJ DAHFMHKAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly ECIHHGBBJLE FGKGMOMKDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private bool JPIMEAOLJII;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6827090", Offset = "0x6826290", VA = "0x186827090")]
	public MABGKFLOIKH(JIEBELBAAKC CNMFPFIJBEO, NICLHLHNPCI KIMKADOOFFI, JEMAMLJMOAJ DAHFMHKAMCF, ECIHHGBBJLE FGKGMOMKDMN, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x68263B0", Offset = "0x68255B0", VA = "0x1868263B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x68263B0", Offset = "0x68255B0", VA = "0x1868263B0")]
	public void MEBKMFNMEFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6826620", Offset = "0x6825820", VA = "0x186826620")]
	public void FGMHKCMBOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6826160", Offset = "0x6825360", VA = "0x186826160")]
	public void CMDLKNENNMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x68268A0", Offset = "0x6825AA0", VA = "0x1868268A0")]
	[AsyncStateMachine(typeof(HFPFCBHJKLF))]
	internal Task<LCFKPKINCJE> KHPAIOHIOBL(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, LCFKPKINCJE BFKFODNNLGE, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2999B10", Offset = "0x2998D10", VA = "0x182999B10")]
	private static byte[] KKEOLFCIPIG<T>(T JGNAJPMGGNE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x29999C0", Offset = "0x2998BC0", VA = "0x1829999C0")]
	private static T GDDHIONKFAC<T>(MessageParser<T> AICHONBHAKO, byte[] JGNAJPMGGNE, T AHDCPLGCKKM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6826760", Offset = "0x6825960", VA = "0x186826760")]
	[AsyncStateMachine(typeof(FCIPCGLLGHK))]
	private Task<NICLHLHNPCI.IMDMDKAJFGO<LCFKPKINCJE>> HKOHJMCJMKM(LCFKPKINCJE BFKFODNNLGE, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2999B20", Offset = "0x2998D20", VA = "0x182999B20")]
	[AsyncStateMachine(typeof(DLAGAFKLECA<>))]
	internal Task<T> ODBAEDHBMHH<T>(CancellationToken OJHIOEGMMDB, Func<CancellationToken, Task<T>> AEBOJFLPBCH, int LILGHMDCJOI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6826DA0", Offset = "0x6825FA0", VA = "0x186826DA0")]
	[AsyncStateMachine(typeof(GMAPIECEFNL))]
	internal Task ODBAEDHBMHH(CancellationToken OJHIOEGMMDB, Func<CancellationToken, Task> AEBOJFLPBCH, int LILGHMDCJOI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6826220", Offset = "0x6825420", VA = "0x186826220")]
	public GJHHNFFFKEI DEEMEGNBIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x68266E0", Offset = "0x68258E0", VA = "0x1868266E0")]
	public AIPHJDNNPJH HGNJGEDCHMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x68264D0", Offset = "0x68256D0", VA = "0x1868264D0")]
	public JLINNMPIBDH EOIOGBKOBAA([Optional] JJNHGMIGPBK? OMJOPGOBIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6826A00", Offset = "0x6825C00", VA = "0x186826A00")]
	public void KLBOGBONMJO(Func<Guid, bool> AOIOJDCHHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6826B60", Offset = "0x6825D60", VA = "0x186826B60")]
	public void KPLELNHBNOH(Func<Guid, bool> NEMAALEECME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6825FE0", Offset = "0x68251E0", VA = "0x186825FE0")]
	public Guid BPAAPNODFFL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x68262A0", Offset = "0x68254A0", VA = "0x1868262A0")]
	public void DKIEBGNIJPC(Guid KCFANFEJDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6826C70", Offset = "0x6825E70", VA = "0x186826C70")]
	public void NJDPPFHOEJN(LCFKPKINCJE DBJMGOGLLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6826F20", Offset = "0x6826120", VA = "0x186826F20")]
	public void PHDBFKGPBFI(string BDOLMACJJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x29996A0", Offset = "0x29988A0", VA = "0x1829996A0")]
	private T CFFICNEPJLL<T>(T NICEPFIEJED) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6826ED0", Offset = "0x68260D0", VA = "0x186826ED0")]
	public void OGKOOPJNEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2999720", Offset = "0x2998920", VA = "0x182999720")]
	[CompilerGenerated]
	internal static string DOHCFMPGBOE<T>(byte[] CGAHJPHALBC, int EPLLLIOIBOE, MPKNOJEGIKB<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class IIJOBAPBILE : JIEBELBAAKC
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GHKACIJMMLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GHKACIJMMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x683AB40", Offset = "0x6839D40", VA = "0x18683AB40")]
		internal object FNOIMPLHEIM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct KFIKMENFGAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public IIJOBAPBILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private NHDDMMGHJDJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private AIPHJDNNPJH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x683F540", Offset = "0x683E740", VA = "0x18683F540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x683FE10", Offset = "0x683F010", VA = "0x18683FE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct AJOIGLOFBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public IIJOBAPBILE <>4__this;

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
		private TaskAwaiter<NHHLGHBJLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6831940", Offset = "0x6830B40", VA = "0x186831940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x68320F0", Offset = "0x68312F0", VA = "0x1868320F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct NDHCOLJGIIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public IIJOBAPBILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<DNGPLKGKBEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6842A70", Offset = "0x6841C70", VA = "0x186842A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6842D90", Offset = "0x6841F90", VA = "0x186842D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class KEEGLLFBJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public NHDDMMGHJDJ presence;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KEEGLLFBJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x683F400", Offset = "0x683E600", VA = "0x18683F400")]
		internal object JIMPIIGDLHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly JJNHGMIGPBK KLMGKIJGMJK;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly JJNHGMIGPBK MMLMGCACPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly HGFIJEMHMDL OEPECDELIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly NKKGGOEDKKI FPCPKGOIGMJ;

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x683C380", Offset = "0x683B580", VA = "0x18683C380")]
	public IIJOBAPBILE(HGFIJEMHMDL OEPECDELIMH, NKKGGOEDKKI FPCPKGOIGMJ, Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, NPDCGEHACLF HFBEHMPOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x683C170", Offset = "0x683B370", VA = "0x18683C170", Slot = "7")]
	[AsyncStateMachine(typeof(KFIKMENFGAO))]
	protected override Task PFKLMCLICAN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x683C070", Offset = "0x683B270", VA = "0x18683C070")]
	[AsyncStateMachine(typeof(AJOIGLOFBKC))]
	private Task PEGPBKFJJLF(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x683BF60", Offset = "0x683B160", VA = "0x18683BF60")]
	[AsyncStateMachine(typeof(NDHCOLJGIIH))]
	private Task<byte> LIIKCBMBJJK(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x683BD80", Offset = "0x683AF80", VA = "0x18683BD80")]
	private NHDDMMGHJDJ LIIJNAOOPDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class HCBNECMDJDN : JIEBELBAAKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct MEPACBMBKDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public HCBNECMDJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter<OEBGDEELFDO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6840930", Offset = "0x683FB30", VA = "0x186840930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x68412A0", Offset = "0x68404A0", VA = "0x1868412A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly int MNKDJAEBEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly OBBCDGFHJBJ AMFIFOBJCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long GPFDOHKPFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public readonly long KEGCKPNDODB;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OEBGDEELFDO IHHBFMDOKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F60", Offset = "0x7C0160", VA = "0x1807C0F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FD0", Offset = "0x7C01D0", VA = "0x1807C0FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x683B240", Offset = "0x683A440", VA = "0x18683B240")]
	public HCBNECMDJDN(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, NPDCGEHACLF HFBEHMPOHLO, int MNKDJAEBEHH, OBBCDGFHJBJ AMFIFOBJCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x683B120", Offset = "0x683A320", VA = "0x18683B120", Slot = "7")]
	[AsyncStateMachine(typeof(MEPACBMBKDO))]
	protected override Task PFKLMCLICAN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class EDJHEHMMGGI : JIEBELBAAKC
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class CILMHEKLJGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public EDJHEHMMGGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public APMPGHIGAOI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CILMHEKLJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6836DC0", Offset = "0x6835FC0", VA = "0x186836DC0")]
		internal Task AGCPNCEMACH(OPAMPAFNBOH<string>.GMFJCEOBAKO postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6836E00", Offset = "0x6836000", VA = "0x186836E00")]
		internal object DKFJNNDMKAB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct OLBNHMHFKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public EDJHEHMMGGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private CILMHEKLJGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x68439B0", Offset = "0x6842BB0", VA = "0x1868439B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6844170", Offset = "0x6843370", VA = "0x186844170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct KDGCIHAHKKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public APMPGHIGAOI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public EDJHEHMMGGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x683EE10", Offset = "0x683E010", VA = "0x18683EE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x683F3A0", Offset = "0x683E5A0", VA = "0x18683F3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6838560", Offset = "0x6837760", VA = "0x186838560")]
	public EDJHEHMMGGI(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, NPDCGEHACLF HFBEHMPOHLO, string PNHEAHKAAKE, PFBGPEMCIEN BOPJNIDBFBF, bool LDFDAFEMABD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6838420", Offset = "0x6837620", VA = "0x186838420", Slot = "7")]
	[AsyncStateMachine(typeof(OLBNHMHFKAJ))]
	protected override Task PFKLMCLICAN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task IHMOHNOKLKL(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x68382E0", Offset = "0x68374E0", VA = "0x1868382E0")]
	[AsyncStateMachine(typeof(KDGCIHAHKKL))]
	private Task MBEIKLKJMDE(IDisposable FOFBHHGAALH, APMPGHIGAOI JNAMLAOHFOD, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class OMAAOLEBFOO : JIEBELBAAKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct PMBCCCJMDGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public OMAAOLEBFOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public MABGKFLOIKH operationContext;

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
		private TaskAwaiter<OMANNHIFEOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6845E00", Offset = "0x6845000", VA = "0x186845E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6846360", Offset = "0x6845560", VA = "0x186846360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly EDCMFPOJOOL GBMDEGJEOMP;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x68443D0", Offset = "0x68435D0", VA = "0x1868443D0")]
	public OMAAOLEBFOO(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, NPDCGEHACLF HFBEHMPOHLO, EDCMFPOJOOL GBMDEGJEOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x68441D0", Offset = "0x68433D0", VA = "0x1868441D0", Slot = "6")]
	protected override string ANLLCOADBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x68442B0", Offset = "0x68434B0", VA = "0x1868442B0", Slot = "7")]
	[AsyncStateMachine(typeof(PMBCCCJMDGK))]
	protected override Task PFKLMCLICAN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class JIEBELBAAKC : MAENGEFPLDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task ANEMNLKCCOA(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class BDCJCIIFAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public JIEBELBAAKC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BDCJCIIFAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x68341B0", Offset = "0x68333B0", VA = "0x1868341B0")]
		internal Task DLNIIKBJDKH(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class CDNKLBGEHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public BDCJCIIFAPE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CDNKLBGEHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6835090", Offset = "0x6834290", VA = "0x186835090")]
		internal object MADLJJHEADG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6834FD0", Offset = "0x68341D0", VA = "0x186834FD0")]
		internal object FMANCMCOIPA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct EMPBBEKGNOJ : IAsyncStateMachine
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
		public JIEBELBAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Func<JIEBELBAAKC, OPAMPAFNBOH<string>.GMFJCEOBAKO, MABGKFLOIKH> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private BDCJCIIFAPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private MABGKFLOIKH <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<LCFKPKINCJE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6838CF0", Offset = "0x6837EF0", VA = "0x186838CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6839EF0", Offset = "0x68390F0", VA = "0x186839EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct APHALBDIOBG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x68322A0", Offset = "0x68314A0", VA = "0x1868322A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6832D20", Offset = "0x6831F20", VA = "0x186832D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct BKBHDOICHPL : IAsyncStateMachine
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
		public JIEBELBAAKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6834A80", Offset = "0x6833C80", VA = "0x186834A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6834DE0", Offset = "0x6833FE0", VA = "0x186834DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly Guid BLNCNJHFIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly ByteString PMLDHOBFMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly NPDCGEHACLF KAIDFEGICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected readonly string NEEPCNOMEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly bool LDFDAFEMABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly Queue<ANEMNLKCCOA> ABPBGCMJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly FAJOLONPKDC HEAOFOFLHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly PFBGPEMCIEN BOPJNIDBFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private bool AKEPKLAKBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public PHAOMCMINAH OODAPLCPKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public PHAOMCMINAH PNILEMDFBOP;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public CKDPMMHNMPI NLMNGKBNDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x683DDF0", Offset = "0x683CFF0", VA = "0x18683DDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public INBNEGOCKCD MDILADGECMB
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x683E430", Offset = "0x683D630", VA = "0x18683E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x683DF30", Offset = "0x683D130", VA = "0x18683DF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NCKGFKCCKNN NKEHBGEOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x683E5B0", Offset = "0x683D7B0", VA = "0x18683E5B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x683E240", Offset = "0x683D440", VA = "0x18683E240", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x683E720", Offset = "0x683D920", VA = "0x18683E720")]
	protected JIEBELBAAKC(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, NPDCGEHACLF HFBEHMPOHLO, string PNHEAHKAAKE, PFBGPEMCIEN BOPJNIDBFBF, bool LDFDAFEMABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x683DDB0", Offset = "0x683CFB0", VA = "0x18683DDB0", Slot = "6")]
	protected virtual string ANLLCOADBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x683E260", Offset = "0x683D460", VA = "0x18683E260")]
	public void KPDNBGILPPA(ANEMNLKCCOA GEHIKDCONBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x683E220", Offset = "0x683D420", VA = "0x18683E220")]
	protected void IKDIFDIABFM(float MBFPHKFMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x683DFB0", Offset = "0x683D1B0", VA = "0x18683DFB0")]
	[AsyncStateMachine(typeof(EMPBBEKGNOJ))]
	public Task FPBPNKPIOLJ(CancellationToken AIHJHMPAHCH, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, [Optional] Func<JIEBELBAAKC, OPAMPAFNBOH<string>.GMFJCEOBAKO, MABGKFLOIKH> CPPOMOJAOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x683E480", Offset = "0x683D680", VA = "0x18683E480")]
	[AsyncStateMachine(typeof(APHALBDIOBG))]
	private static Task OJHHABNIMDP(Func<CancellationToken, Task> IIODNCNCFJF, Func<CancellationToken, Task> BKFMMCOPPJC, CancellationToken OJHIOEGMMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x683E5D0", Offset = "0x683D7D0", VA = "0x18683E5D0")]
	private void OPOCIHNAEIF(bool KFLNBNHABLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x683DE40", Offset = "0x683D040", VA = "0x18683DE40")]
	private void FDEMLLNAGIL(MABGKFLOIKH PEKFMMFJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task PFKLMCLICAN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x683E100", Offset = "0x683D300", VA = "0x18683E100")]
	[AsyncStateMachine(typeof(BKBHDOICHPL))]
	private Task GNHGMLKDHED(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x683E3B0", Offset = "0x683D5B0", VA = "0x18683E3B0")]
	public LCFKPKINCJE MDPPOADMHAF(GGJDEFLOIPM LGJACLDONJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x683E2C0", Offset = "0x683D4C0", VA = "0x18683E2C0")]
	[CompilerGenerated]
	private Task MDPAADOGLFG(CancellationToken MOAGOANMCEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class LPOFBJEAJAE : EDJHEHMMGGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct JGMCKJMGOOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public LPOFBJEAJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private DENGJMMGKHO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private AIPHJDNNPJH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x683D5E0", Offset = "0x683C7E0", VA = "0x18683D5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x683DD50", Offset = "0x683CF50", VA = "0x18683DD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly HGFIJEMHMDL LLOOHEMBENA;

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6840880", Offset = "0x683FA80", VA = "0x186840880")]
	public LPOFBJEAJAE(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, HGFIJEMHMDL LLOOHEMBENA, NPDCGEHACLF HFBEHMPOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x6840730", Offset = "0x683F930", VA = "0x186840730", Slot = "8")]
	[AsyncStateMachine(typeof(JGMCKJMGOOD))]
	protected override Task IHMOHNOKLKL(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class EIBKFPBBABI : JIEBELBAAKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct JEMOJJIJCDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public EIBKFPBBABI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<OMANNHIFEOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x683D1D0", Offset = "0x683C3D0", VA = "0x18683D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x683D580", Offset = "0x683C780", VA = "0x18683D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly string AHMPHCADCIA;

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6838C40", Offset = "0x6837E40", VA = "0x186838C40")]
	public EIBKFPBBABI(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, NPDCGEHACLF HFBEHMPOHLO, string AHMPHCADCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6838B30", Offset = "0x6837D30", VA = "0x186838B30", Slot = "7")]
	[AsyncStateMachine(typeof(JEMOJJIJCDG))]
	protected override Task PFKLMCLICAN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class GMNFKOOHPID : EDJHEHMMGGI
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class AGMIBHGCLMO
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
			public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public AGMIBHGCLMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<OMANNHIFEOF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<LCFKPKINCJE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x6849090", Offset = "0x6848290", VA = "0x186849090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x6849550", Offset = "0x6848750", VA = "0x186849550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GMNFKOOHPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public JLINNMPIBDH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public JLGKMCENPAK roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public GJHHNFFFKEI uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public FHIOLGLBKGD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AGMIBHGCLMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x682FC70", Offset = "0x682EE70", VA = "0x18682FC70")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<LCFKPKINCJE> DPFPHPHDKBH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct CEGCAAKAIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GMNFKOOHPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private AGMIBHGCLMO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private DENGJMMGKHO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private AIPHJDNNPJH <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private LCFKPKINCJE <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6835150", Offset = "0x6834350", VA = "0x186835150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x68360B0", Offset = "0x68352B0", VA = "0x1868360B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly JJNHGMIGPBK KLMGKIJGMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private readonly int CPJEKHLMDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	[CanBeNull]
	private readonly DELDHEKMCNB JOLPLLJAELN;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x683B070", Offset = "0x683A270", VA = "0x18683B070")]
	public GMNFKOOHPID(Guid FNMGFNFDGKE, CKDPMMHNMPI GLFBENAFDIE, int CPJEKHLMDEN, DELDHEKMCNB JOLPLLJAELN, NPDCGEHACLF HFBEHMPOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x683AD80", Offset = "0x6839F80", VA = "0x18683AD80", Slot = "8")]
	[AsyncStateMachine(typeof(CEGCAAKAIGE))]
	protected override Task IHMOHNOKLKL(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x683AEC0", Offset = "0x683A0C0", VA = "0x18683AEC0")]
	private void LCLBNEKFJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x683ABB0", Offset = "0x6839DB0", VA = "0x18683ABB0")]
	private void BJONIEFBMPP(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, DENGJMMGKHO DJEBFPGKJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class HCDDBDMEOJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly JIEBELBAAKC JMKNKBLEADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly MABGKFLOIKH OMKDBJBMKMM;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x683B370", Offset = "0x683A570", VA = "0x18683B370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x683B3C0", Offset = "0x683A5C0", VA = "0x18683B3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x683B470", Offset = "0x683A670", VA = "0x18683B470")]
	protected HCDDBDMEOJD(MABGKFLOIKH PEKFMMFJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x683B450", Offset = "0x683A650", VA = "0x18683B450")]
	protected void PHDBFKGPBFI(string BDOLMACJJEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct DCKPKHOJIBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<EDLKGMCFPID>> MMMNDDLGOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public Dictionary<Guid, List<EDLKGMCFPID>> AIHPDIPMOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public Dictionary<Guid, List<EDLKGMCFPID>> NNGBCOLIFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public List<Guid> CDJOEKMBOEI;

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6837BC0", Offset = "0x6836DC0", VA = "0x186837BC0")]
	public static DCKPKHOJIBL OLBNKGLEPPK(MBGMJCPJKBD KIGDILPPPPG, PHAOMCMINAH EEBEFOOAFIG, OHJENCCOGPB GLDPHLIODOD)
	{
		return default(DCKPKHOJIBL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct LDIOOHCDAHG
{
	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	public static LDIOOHCDAHG LAFNMEJJDLL()
	{
		return default(LDIOOHCDAHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct NNDMJLAIMDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly NHHLGHBJLHK OJEMOHOCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly JEGONNFCHHM CFBIIIPPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly string KGLKFKGMHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly CBHGKMFEFBA JFLFEABOIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly CBHGKMFEFBA GAGGKMGLOMG;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6843100", Offset = "0x6842300", VA = "0x186843100")]
	public NNDMJLAIMDD(NHHLGHBJLHK OJEMOHOCDCL, JEGONNFCHHM CFBIIIPPBJK, string KGLKFKGMHJI, CBHGKMFEFBA JFLFEABOIJJ, CBHGKMFEFBA GAGGKMGLOMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IBKFECKJGCG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly MABGKFLOIKH PEKFMMFJMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly Guid KCFANFEJDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private bool KFLNBNHABLM;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x683BBD0", Offset = "0x683ADD0", VA = "0x18683BBD0")]
	public static IBKFECKJGCG BPAAPNODFFL(MABGKFLOIKH PEKFMMFJMHO)
	{
		return default(IBKFECKJGCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x850590", Offset = "0x84F790", VA = "0x180850590")]
	public void MEDDMNDGBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x683BC30", Offset = "0x683AE30", VA = "0x18683BC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x683BD30", Offset = "0x683AF30", VA = "0x18683BD30")]
	private IBKFECKJGCG(MABGKFLOIKH PEKFMMFJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x683BC30", Offset = "0x683AE30", VA = "0x18683BC30")]
	private void DKIEBGNIJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x683BC90", Offset = "0x683AE90", VA = "0x18683BC90")]
	private Func<Guid, bool> JNEGJKMNCBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class AIPHJDNNPJH : HCDDBDMEOJD, MAENGEFPLDJ
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<PHAOMCMINAH> FIALIAKHEIF(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB MEINDMPJBAJ, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct JEIOEJHHBHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public HGFIJEMHMDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private IBKFECKJGCG <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x683CA00", Offset = "0x683BC00", VA = "0x18683CA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x683D170", Offset = "0x683C370", VA = "0x18683D170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct JOLBNHDDEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public HGFIJEMHMDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x683E880", Offset = "0x683DA80", VA = "0x18683E880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x683EC90", Offset = "0x683DE90", VA = "0x18683EC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct IMEKKGOFFBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public HGFIJEMHMDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x683C510", Offset = "0x683B710", VA = "0x18683C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x683C9A0", Offset = "0x683BBA0", VA = "0x18683C9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class OEDFMJKMJNE
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
			public AsyncTaskMethodBuilder<NNDMJLAIMDD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public OEDFMJKMJNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private NNDMJLAIMDD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<PHAOMCMINAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private TaskAwaiter<NNDMJLAIMDD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x6847760", Offset = "0x6846960", VA = "0x186847760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x6847EF0", Offset = "0x68470F0", VA = "0x186847EF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<OHJENCCOGPB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public OEDFMJKMJNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private OHJENCCOGPB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter<PHAOMCMINAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<OHJENCCOGPB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x6847F60", Offset = "0x6847160", VA = "0x186847F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x68485B0", Offset = "0x68477B0", VA = "0x1868485B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public OEDFMJKMJNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private TaskAwaiter<PHAOMCMINAH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private FOPAINLEJPB <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x68463C0", Offset = "0x68455C0", VA = "0x1868463C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x6847700", Offset = "0x6846900", VA = "0x186847700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public HGFIJEMHMDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public FAJOLONPKDC preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public FAJOLONPKDC downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public NNDMJLAIMDD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public FAJOLONPKDC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public OHJENCCOGPB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public CLILGCJJFAL.JHJBNHNMCGB <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OEDFMJKMJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x68433A0", Offset = "0x68425A0", VA = "0x1868433A0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<NNDMJLAIMDD> JMOLAHMOIBH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6843280", Offset = "0x6842480", VA = "0x186843280")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OHJENCCOGPB> FGIEODOEANA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x68434E0", Offset = "0x68426E0", VA = "0x1868434E0")]
		internal void LMEMBMMKPOB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6843180", Offset = "0x6842380", VA = "0x186843180")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task ABEHMKGOFMF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct OMGIJIJDPFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public HGFIJEMHMDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private OEDFMJKMJNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<NNDMJLAIMDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private TaskAwaiter<OHJENCCOGPB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x6844F40", Offset = "0x6844140", VA = "0x186844F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6845B30", Offset = "0x6844D30", VA = "0x186845B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct BHMHEJGPPHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x68342E0", Offset = "0x68334E0", VA = "0x1868342E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6834A20", Offset = "0x6833C20", VA = "0x186834A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct COPAFIAJDKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6836E90", Offset = "0x6836090", VA = "0x186836E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x68377F0", Offset = "0x68369F0", VA = "0x1868377F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct MKJNJPLHECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6841300", Offset = "0x6840500", VA = "0x186841300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6842480", Offset = "0x6841680", VA = "0x186842480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct BCAECGGFMFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public FOPAINLEJPB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6832D80", Offset = "0x6831F80", VA = "0x186832D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6834140", Offset = "0x6833340", VA = "0x186834140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NJDMIHCGLOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public PHAOMCMINAH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public OHJENCCOGPB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6842E00", Offset = "0x6842000", VA = "0x186842E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6843090", Offset = "0x6842290", VA = "0x186843090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class HCDPGDOLNGA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public HCDPGDOLNGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private GBPKPFGCFHL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			private TaskAwaiter<PHAOMCMINAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x6848620", Offset = "0x6847820", VA = "0x186848620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6848C30", Offset = "0x6847E30", VA = "0x186848C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public FIALIAKHEIF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public FOPAINLEJPB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public PHAOMCMINAH originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HCDPGDOLNGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x683B4D0", Offset = "0x683A6D0", VA = "0x18683B4D0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<PHAOMCMINAH> PFLLOGLCDME(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct LJIFBANALCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public FIALIAKHEIF masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public FOPAINLEJPB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x68401C0", Offset = "0x683F3C0", VA = "0x1868401C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x68406C0", Offset = "0x683F8C0", VA = "0x1868406C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct EFGPELCCGAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public FAJOLONPKDC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private PHAOMCMINAH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private IEnumerator<PHAOMCMINAH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x68385B0", Offset = "0x68377B0", VA = "0x1868385B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6838AD0", Offset = "0x6837CD0", VA = "0x186838AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct DBBCNEADBPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6837850", Offset = "0x6836A50", VA = "0x186837850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6837B60", Offset = "0x6836D60", VA = "0x186837B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct HIEKFDCPLJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AIPHJDNNPJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x683B930", Offset = "0x683AB30", VA = "0x18683B930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x683BB70", Offset = "0x683AD70", VA = "0x18683BB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly PMCKCPFJJBP JCGMNLPCHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly PMCKCPFJJBP NCELBDOPFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly FPEHBHJFGEH CNPBCMHLBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly GOKNNBMHMCI JNMKKPHJPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly AHMOPLFGDNH LMGFCKHGMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly GLHEFCHDPOC GLNPAGGGIPK;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private CKDPMMHNMPI NLMNGKBNDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x6830200", Offset = "0x682F400", VA = "0x186830200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NCKGFKCCKNN NKEHBGEOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x6831180", Offset = "0x6830380", VA = "0x186831180", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6830AE0", Offset = "0x682FCE0", VA = "0x186830AE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6831690", Offset = "0x6830890", VA = "0x186831690")]
	public AIPHJDNNPJH(MABGKFLOIKH PEKFMMFJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x682FF50", Offset = "0x682F150", VA = "0x18682FF50")]
	[AsyncStateMachine(typeof(JEIOEJHHBHJ))]
	public Task BPHNKJFFOMA(HGFIJEMHMDL AIJPHINHCJO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x68300A0", Offset = "0x682F2A0", VA = "0x1868300A0")]
	[AsyncStateMachine(typeof(JOLBNHDDEKE))]
	private Task<LCFKPKINCJE> DBAODAMJKBM(HGFIJEMHMDL AIJPHINHCJO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x68309A0", Offset = "0x682FBA0", VA = "0x1868309A0")]
	[AsyncStateMachine(typeof(IMEKKGOFFBK))]
	private Task IJFOHAKMBBO(HGFIJEMHMDL AIJPHINHCJO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6830540", Offset = "0x682F740", VA = "0x186830540")]
	[AsyncStateMachine(typeof(OMGIJIJDPFP))]
	private Task FIDOPOHGLED(HGFIJEMHMDL AIJPHINHCJO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken GBIAAJCMPJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6831340", Offset = "0x6830540", VA = "0x186831340")]
	[AsyncStateMachine(typeof(BHMHEJGPPHG))]
	private Task OONLDJPPMJF(OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6830CB0", Offset = "0x682FEB0", VA = "0x186830CB0")]
	[AsyncStateMachine(typeof(COPAFIAJDKK))]
	private Task KIBIAOLBABK(OHJENCCOGPB FODGEDCJIDC, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x68311A0", Offset = "0x68303A0", VA = "0x1868311A0")]
	[AsyncStateMachine(typeof(MKJNJPLHECB))]
	private Task<PHAOMCMINAH> OMBGPDCOOHO(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6830EC0", Offset = "0x68300C0", VA = "0x186830EC0")]
	[AsyncStateMachine(typeof(BCAECGGFMFP))]
	private Task<PHAOMCMINAH> OAPDLPOAANN(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x682FDD0", Offset = "0x682EFD0", VA = "0x18682FDD0")]
	[AsyncStateMachine(typeof(NJDMIHCGLOO))]
	private Task<PHAOMCMINAH> APBELJFKBKJ(PHAOMCMINAH EEBEFOOAFIG, OHJENCCOGPB GLDPHLIODOD, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH, bool GILFIAFHGNM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6831450", Offset = "0x6830650", VA = "0x186831450")]
	private bool PACBOLMEDAD(OHJENCCOGPB IGBJFNKIDCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6830B00", Offset = "0x682FD00", VA = "0x186830B00")]
	[AsyncStateMachine(typeof(LJIFBANALCI))]
	protected Task<PHAOMCMINAH> JGLOPJIGAGF(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH, FIALIAKHEIF HHGFAMMNIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x68306A0", Offset = "0x682F8A0", VA = "0x1868306A0")]
	[AsyncStateMachine(typeof(EFGPELCCGAO))]
	private Task GAEHAOHAMCE(OHJENCCOGPB FODGEDCJIDC, FAJOLONPKDC BINBMEKFIGM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6830E00", Offset = "0x6830000", VA = "0x186830E00")]
	private void LAJKCNIBBDN(PHAOMCMINAH GBCDHKFIPMO, FAJOLONPKDC BINBMEKFIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6830940", Offset = "0x682FB40", VA = "0x186830940")]
	private void HICPIKHOGAG(PHAOMCMINAH OHEMBKGFOAF, [Out] PHAOMCMINAH NLEAGCAKHBB, [Out] PHAOMCMINAH BCKEFNOPBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x682FD90", Offset = "0x682EF90", VA = "0x18682FD90")]
	private Task<NNDMJLAIMDD> AKAONMAKAOJ(HGFIJEMHMDL AIJPHINHCJO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6831300", Offset = "0x6830500", VA = "0x186831300")]
	private Task<OHJENCCOGPB> OOHKPAENKJM(NNDMJLAIMDD FODGEDCJIDC, CLILGCJJFAL.JHJBNHNMCGB JMHNCFPFIEH, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x68307F0", Offset = "0x682F9F0", VA = "0x1868307F0")]
	[AsyncStateMachine(typeof(DBBCNEADBPD))]
	private Task GFJAGODHHCI(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH, bool LOPBPCAAOPN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6830450", Offset = "0x682F650", VA = "0x186830450")]
	[AsyncStateMachine(typeof(HIEKFDCPLJA))]
	private Task ENDCMICMOCJ(OHJENCCOGPB FODGEDCJIDC, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6830310", Offset = "0x682F510", VA = "0x186830310")]
	private Task EFKDNKPEKEO(OHJENCCOGPB FODGEDCJIDC, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6830C90", Offset = "0x682FE90", VA = "0x186830C90")]
	private Task JLCKPPMNFEA(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6830E50", Offset = "0x6830050", VA = "0x186830E50")]
	private Task LLBKCOPMACK(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6831540", Offset = "0x6830740", VA = "0x186831540")]
	private Task PJNCDCICOIO(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6830230", Offset = "0x682F430", VA = "0x186830230")]
	private static Task DOBFNMKIAID(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6830980", Offset = "0x682FB80", VA = "0x186830980")]
	private Task HLNIIEBEEFI(OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6831040", Offset = "0x6830240", VA = "0x186831040")]
	private Task OGGPILMPGCP(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6830E70", Offset = "0x6830070", VA = "0x186830E70")]
	private void MPJBCHIPFJF(HGFIJEMHMDL AIJPHINHCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6830680", Offset = "0x682F880", VA = "0x186830680")]
	public void FLCNCIEKAFF(long LGMIMPLLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void BBDCGEKAGAL(NHHLGHBJLHK OJEMOHOCDCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct LEBICBJNGEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private OHJENCCOGPB FODGEDCJIDC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x683FE70", Offset = "0x683F070", VA = "0x18683FE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x683FEC0", Offset = "0x683F0C0", VA = "0x18683FEC0")]
	public static Task FPBPNKPIOLJ(CKDPMMHNMPI GLFBENAFDIE, OHJENCCOGPB FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x683FFA0", Offset = "0x683F1A0", VA = "0x18683FFA0")]
	private void FPBPNKPIOLJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct DBKNOHHJNKP
{
	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6830230", Offset = "0x682F430", VA = "0x186830230")]
	public static Task FPBPNKPIOLJ(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct FHHKFOHMKKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct MOAHKKCPMHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x68424F0", Offset = "0x68416F0", VA = "0x1868424F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6842A10", Offset = "0x6841C10", VA = "0x186842A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x683A900", Offset = "0x6839B00", VA = "0x18683A900")]
	[AsyncStateMachine(typeof(MOAHKKCPMHB))]
	public static Task FPBPNKPIOLJ(MABGKFLOIKH PEKFMMFJMHO, OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct HDHPAPMHBME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct CEHFEFFECOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public FOPAINLEJPB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private PHAOMCMINAH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private CKDPMMHNMPI <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private MBGMJCPJKBD <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private GBPKPFGCFHL <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private List<(PersistenceView, EEMANFFCIOG)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EEMANFFCIOG <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6836110", Offset = "0x6835310", VA = "0x186836110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6836D60", Offset = "0x6835F60", VA = "0x186836D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x683B5F0", Offset = "0x683A7F0", VA = "0x18683B5F0")]
	[AsyncStateMachine(typeof(CEHFEFFECOG))]
	public static Task FPBPNKPIOLJ(MABGKFLOIKH PEKFMMFJMHO, OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x683B740", Offset = "0x683A940", VA = "0x18683B740")]
	private static void GJKBBJFNGOA(PersistenceView LNHHACHOOKF, EEMANFFCIOG BDCBKPHIOMI, OHJENCCOGPB FODGEDCJIDC, PHAOMCMINAH EEBEFOOAFIG, bool HONFHPOHNDI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct KCEPIEOFDCH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct OEHOHNINOPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CKDPMMHNMPI roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6843520", Offset = "0x6842720", VA = "0x186843520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6843950", Offset = "0x6842B50", VA = "0x186843950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x683ED00", Offset = "0x683DF00", VA = "0x18683ED00")]
	[AsyncStateMachine(typeof(OEHOHNINOPC))]
	public static Task FPBPNKPIOLJ(CKDPMMHNMPI GLFBENAFDIE, OHJENCCOGPB FODGEDCJIDC, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct OMAMMLKAODA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct PJEAKLBLGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CKDPMMHNMPI roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6845B90", Offset = "0x6844D90", VA = "0x186845B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6845DA0", Offset = "0x6844FA0", VA = "0x186845DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class DMPEIMKBBKG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public DMPEIMKBBKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x6848CA0", Offset = "0x6847EA0", VA = "0x186848CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x6849030", Offset = "0x6848230", VA = "0x186849030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DMPEIMKBBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x68381C0", Offset = "0x68373C0", VA = "0x1868381C0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NHBDNCOBOKF(OPAMPAFNBOH<string>.GMFJCEOBAKO timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct FAJOEJNJGHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public OMAMMLKAODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6839F50", Offset = "0x6839150", VA = "0x186839F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x683A8A0", Offset = "0x6839AA0", VA = "0x18683A8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class BOEPLGIKJCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public ADGDLBLFAGN version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BOEPLGIKJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6834E40", Offset = "0x6834040", VA = "0x186834E40")]
		internal object BPJDNGPGCKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6834F20", Offset = "0x6834120", VA = "0x186834F20")]
		internal object CMHPBKCOLFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private OHJENCCOGPB FODGEDCJIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private MABGKFLOIKH PEKFMMFJMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private bool LOPBPCAAOPN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private static readonly ByteString KBIJKIOHNCC;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x68444B0", Offset = "0x68436B0", VA = "0x1868444B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private BMPIBBEHNHJ IAMIOCCHNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6844500", Offset = "0x6843700", VA = "0x186844500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x68445A0", Offset = "0x68437A0", VA = "0x1868445A0")]
	[AsyncStateMachine(typeof(PJEAKLBLGBI))]
	public static Task FPBPNKPIOLJ(CKDPMMHNMPI GLFBENAFDIE, OHJENCCOGPB FODGEDCJIDC, MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH, bool LOPBPCAAOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x68446F0", Offset = "0x68438F0", VA = "0x1868446F0")]
	[AsyncStateMachine(typeof(FAJOEJNJGHG))]
	private Task FPBPNKPIOLJ(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6844830", Offset = "0x6843A30", VA = "0x186844830")]
	private void IGJDONIOPMP([NotNull] LJKOKHIIAPB JPLMJPEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6844470", Offset = "0x6843670", VA = "0x186844470")]
	private bool AAAGLFJGOHD(ADGDLBLFAGN LOGOABBJBAN, LJKOKHIIAPB JPLMJPEMOMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct NFBMCICPLMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct EIBCIDBJHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder<OHJENCCOGPB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public NFBMCICPLMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CLILGCJJFAL.JHJBNHNMCGB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<(NFMFLMAOFMP<HFNHBGDIEDK, OMPNGPMCKPG>, NFMFLMAOFMP<IILLLDDOIAK<LJKOKHIIAPB>, OMPNGPMCKPG>, NFMFLMAOFMP<IILLLDDOIAK<CCLNCFGAMPK>, OMPNGPMCKPG>, NFMFLMAOFMP<IILLLDDOIAK<DMKGPPKGBPE>, OMPNGPMCKPG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x684F4E0", Offset = "0x684E6E0", VA = "0x18684F4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x684FF90", Offset = "0x684F190", VA = "0x18684FF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct BIMIAHOAFKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<HFNHBGDIEDK, OMPNGPMCKPG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public NFBMCICPLMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CLILGCJJFAL.JHJBNHNMCGB downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<NFMFLMAOFMP<HFNHBGDIEDK, OMPNGPMCKPG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x684B5D0", Offset = "0x684A7D0", VA = "0x18684B5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x684BBE0", Offset = "0x684ADE0", VA = "0x18684BBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private CHFMDHGNPGN<CBHGKMFEFBA, CCLNCFGAMPK> BGDGPOOBMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private CHFMDHGNPGN<CBHGKMFEFBA, LJKOKHIIAPB> CANNCMFHGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private CHFMDHGNPGN<long, DMKGPPKGBPE> GEKDADMGAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private DMLONBCHLHA JGBOFPDKHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private NHHLGHBJLHK OJEMOHOCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private JEGONNFCHHM CFBIIIPPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private string KGLKFKGMHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private CBHGKMFEFBA JFLFEABOIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private CBHGKMFEFBA GAGGKMGLOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private long LGMIMPLLMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6860A30", Offset = "0x685FC30", VA = "0x186860A30")]
	public static Task<OHJENCCOGPB> GGEGCBJGPOL(CKDPMMHNMPI GLFBENAFDIE, [In] NNDMJLAIMDD FODGEDCJIDC, CLILGCJJFAL.JHJBNHNMCGB JMHNCFPFIEH, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x68608A0", Offset = "0x685FAA0", VA = "0x1868608A0")]
	[AsyncStateMachine(typeof(EIBCIDBJHHG))]
	private Task<OHJENCCOGPB> FPBPNKPIOLJ(CLILGCJJFAL.JHJBNHNMCGB JMHNCFPFIEH, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6860DA0", Offset = "0x685FFA0", VA = "0x186860DA0")]
	[AsyncStateMachine(typeof(BIMIAHOAFKL))]
	private Task<NFMFLMAOFMP<HFNHBGDIEDK, OMPNGPMCKPG>> GINGINGNJGP(string KGLKFKGMHJI, long LGMIMPLLMGF, long? NCFOOPOBBIJ, long? DIKKNIGACBL, CLILGCJJFAL.JHJBNHNMCGB JMHNCFPFIEH, OPAMPAFNBOH<string>.GMFJCEOBAKO ANCMNPJBCIH, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct MHEBKFMBAHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct GNOPBFHGIHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<NNDMJLAIMDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public MHEBKFMBAHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<NNDMJLAIMDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6854170", Offset = "0x6853370", VA = "0x186854170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6854570", Offset = "0x6853770", VA = "0x186854570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct FIPFMPNPKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public AsyncTaskMethodBuilder<NNDMJLAIMDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public MHEBKFMBAHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<NNDMJLAIMDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x68514F0", Offset = "0x68506F0", VA = "0x1868514F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x6851920", Offset = "0x6850B20", VA = "0x186851920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class GIDKNMBDAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public GIDKNMBDAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x15121E0", Offset = "0x15113E0", VA = "0x1815121E0")]
		internal bool OMIKPHAICCG(JEGONNFCHHM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct PMMAAEDDNGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder<NNDMJLAIMDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CBHGKMFEFBA superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public MBGMJCPJKBD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private GIDKNMBDAJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public FOPDBDLEPNH roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private NHHLGHBJLHK <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private JEGONNFCHHM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private CBHGKMFEFBA <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private CBHGKMFEFBA <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<NHHLGHBJLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<GBAFELGEGBB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<DNGPLKGKBEJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6861EB0", Offset = "0x68610B0", VA = "0x186861EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6862FF0", Offset = "0x68621F0", VA = "0x186862FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private FPEHBHJFGEH CNPBCMHLBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private FOPDBDLEPNH ANFLJBEFOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private long NCFOOPOBBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private long PFDCKFHEHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private long OOMOPIJFFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private string CNJEKLNGLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private CBHGKMFEFBA DNCOJOENINN;

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x685EA50", Offset = "0x685DC50", VA = "0x18685EA50")]
	public static Task<NNDMJLAIMDD> GGEGCBJGPOL(CKDPMMHNMPI GLFBENAFDIE, HGFIJEMHMDL AIJPHINHCJO, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x685E900", Offset = "0x685DB00", VA = "0x18685E900")]
	[AsyncStateMachine(typeof(GNOPBFHGIHE))]
	private Task<NNDMJLAIMDD> FPBPNKPIOLJ(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x685E600", Offset = "0x685D800", VA = "0x18685E600")]
	[AsyncStateMachine(typeof(FIPFMPNPKOM))]
	private Task<NNDMJLAIMDD> AKAONMAKAOJ(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x685E760", Offset = "0x685D960", VA = "0x18685E760")]
	[AsyncStateMachine(typeof(PMMAAEDDNGO))]
	private static Task<NNDMJLAIMDD> AKAONMAKAOJ(MBGMJCPJKBD KIGDILPPPPG, FOPDBDLEPNH ANFLJBEFOEL, long NCFOOPOBBIJ, long PFDCKFHEHAO, long OOMOPIJFFPD, string CNJEKLNGLPI, CBHGKMFEFBA DNCOJOENINN, CancellationToken AIHJHMPAHCH, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x685ECD0", Offset = "0x685DED0", VA = "0x18685ECD0")]
	private void LJJCIDOFCON(NHHLGHBJLHK OJEMOHOCDCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct BPCOLLLEMFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct GLDDBPBGIMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public BPCOLLLEMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6853B80", Offset = "0x6852D80", VA = "0x186853B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6854110", Offset = "0x6853310", VA = "0x186854110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private MBGMJCPJKBD KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private OHJENCCOGPB FODGEDCJIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private float HGJMNCOACEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private float MHJBDGAKJIM;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x684C420", Offset = "0x684B620", VA = "0x18684C420")]
	public static Task FFJFIEBMJFO(CKDPMMHNMPI GLFBENAFDIE, OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x684C5C0", Offset = "0x684B7C0", VA = "0x18684C5C0")]
	[AsyncStateMachine(typeof(GLDDBPBGIMK))]
	public Task FPBPNKPIOLJ(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x684C7A0", Offset = "0x684B9A0", VA = "0x18684C7A0")]
	private static void ONHNIDGIDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x684C2C0", Offset = "0x684B4C0", VA = "0x18684C2C0")]
	private void EELDFOAIDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x684C6E0", Offset = "0x684B8E0", VA = "0x18684C6E0")]
	private static float ILPNENENOGH(MBGMJCPJKBD KIGDILPPPPG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x684C2A0", Offset = "0x684B4A0", VA = "0x18684C2A0")]
	private static float AMJJAOEMCFM()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct ANHGGEEBADN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct IIKBDJPJOKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public MABGKFLOIKH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private JIEBELBAAKC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private CKDPMMHNMPI <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private LKMHAEFMODF.IMKHOMEPFHJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6857400", Offset = "0x6856600", VA = "0x186857400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x6857DA0", Offset = "0x6856FA0", VA = "0x186857DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct HAPECFDPANO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x6855520", Offset = "0x6854720", VA = "0x186855520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6855810", Offset = "0x6854A10", VA = "0x186855810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x684AB70", Offset = "0x6849D70", VA = "0x18684AB70")]
	[AsyncStateMachine(typeof(IIKBDJPJOKB))]
	public static Task FPBPNKPIOLJ(MABGKFLOIKH PEKFMMFJMHO, OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x684ACB0", Offset = "0x6849EB0", VA = "0x18684ACB0")]
	private static Task<LCFKPKINCJE> IIGKFNMLBMN(MABGKFLOIKH PEKFMMFJMHO, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x684AAB0", Offset = "0x6849CB0", VA = "0x18684AAB0")]
	[AsyncStateMachine(typeof(HAPECFDPANO))]
	private static Task BIHFGNMMJHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct JIHDNFBAKPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct LBGNHNGMIJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public JIHDNFBAKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x685BCC0", Offset = "0x685AEC0", VA = "0x18685BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x685C370", Offset = "0x685B570", VA = "0x18685C370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class AGNGJICCPPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AGNGJICCPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x684A6A0", Offset = "0x68498A0", VA = "0x18684A6A0")]
		internal object IHGJPDANHFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct HMJBBPDCIOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public JIHDNFBAKPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private BPLFMIOPEKK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6855870", Offset = "0x6854A70", VA = "0x186855870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x6855E30", Offset = "0x6855030", VA = "0x186855E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private bool MNENKEIIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private CancellationToken AIHJHMPAHCH;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x68592C0", Offset = "0x68584C0", VA = "0x1868592C0")]
	public static Task HBPABNKGACH(CKDPMMHNMPI GLFBENAFDIE, bool MNENKEIIHFC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken HDPEDMBJAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x68591D0", Offset = "0x68583D0", VA = "0x1868591D0")]
	[AsyncStateMachine(typeof(LBGNHNGMIJD))]
	private Task FPBPNKPIOLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x68590A0", Offset = "0x68582A0", VA = "0x1868590A0")]
	[AsyncStateMachine(typeof(HMJBBPDCIOL))]
	private Task FEGFDNIOIFA(bool PKOPMMFHOAA, string CNNHODCJBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	private bool OOINFKILBAA(bool MNENKEIIHFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct LECLBPKGNMO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct FOMBICBAHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public LECLBPKGNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6852020", Offset = "0x6851220", VA = "0x186852020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6852590", Offset = "0x6851790", VA = "0x186852590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class JGEPMGAGJKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JGEPMGAGJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x6859050", Offset = "0x6858250", VA = "0x186859050")]
		internal object IHGJPDANHFE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct ABFMDBEJIEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public LECLBPKGNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private BPLFMIOPEKK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6849990", Offset = "0x6848B90", VA = "0x186849990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6849F50", Offset = "0x6849150", VA = "0x186849F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private DDOFFGCDLMJ EBFNDFLNOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private bool LOKBGFBDONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private OHJENCCOGPB FODGEDCJIDC;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x685D330", Offset = "0x685C530", VA = "0x18685D330")]
	public static Task<Scene> MBAFFDFNDCM(CKDPMMHNMPI GLFBENAFDIE, DDOFFGCDLMJ PLGEBLLDIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x685D210", Offset = "0x685C410", VA = "0x18685D210")]
	[AsyncStateMachine(typeof(FOMBICBAHLE))]
	private Task<Scene> FPBPNKPIOLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x685D420", Offset = "0x685C620", VA = "0x18685D420")]
	private bool OPKBKDEMGGL(OHJENCCOGPB FODGEDCJIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x685D3B0", Offset = "0x685C5B0", VA = "0x18685D3B0")]
	private void MOJJEPIBDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x685D0C0", Offset = "0x685C2C0", VA = "0x18685D0C0")]
	[AsyncStateMachine(typeof(ABFMDBEJIEF))]
	private Task<Scene> FEGFDNIOIFA(string CNNHODCJBJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct AHMOPLFGDNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct GABGJJPECBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AHMOPLFGDNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public PHAOMCMINAH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public OHJENCCOGPB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<PHAOMCMINAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6852950", Offset = "0x6851B50", VA = "0x186852950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6853430", Offset = "0x6852630", VA = "0x186853430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct FPDPLHNBMIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder<PHAOMCMINAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public AHMOPLFGDNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public PHAOMCMINAH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6852600", Offset = "0x6851800", VA = "0x186852600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x68528E0", Offset = "0x6851AE0", VA = "0x1868528E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly MABGKFLOIKH PEKFMMFJMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly FPEHBHJFGEH CNPBCMHLBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private readonly GOKNNBMHMCI JNMKKPHJPAE;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private JIEBELBAAKC JMKNKBLEADE
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x50C12C0", Offset = "0x50C04C0", VA = "0x1850C12C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x684AA50", Offset = "0x6849C50", VA = "0x18684AA50")]
	public AHMOPLFGDNH(MABGKFLOIKH PEKFMMFJMHO, FPEHBHJFGEH CNPBCMHLBFB, GOKNNBMHMCI JNMKKPHJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x684A720", Offset = "0x6849920", VA = "0x18684A720")]
	[AsyncStateMachine(typeof(GABGJJPECBK))]
	public Task<PHAOMCMINAH> EJCBMECOEMJ(PHAOMCMINAH AEALFHLFGJC, OHJENCCOGPB GLDPHLIODOD, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH, bool GILFIAFHGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x684A8D0", Offset = "0x6849AD0", VA = "0x18684A8D0")]
	[AsyncStateMachine(typeof(FPDPLHNBMIP))]
	private Task<PHAOMCMINAH> FEEEJBHGHLO(OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, PHAOMCMINAH OAODOPKGJBP, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x684A8A0", Offset = "0x6849AA0", VA = "0x18684A8A0")]
	private bool ELJGFJJPFIE(PHAOMCMINAH OGHAHCINNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x684AA30", Offset = "0x6849C30", VA = "0x18684AA30")]
	private void PHDBFKGPBFI(string BNFCMKEEELL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct FCADEMPIBGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct KCCODJAAMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public JIEBELBAAKC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public FOPAINLEJPB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private GBPKPFGCFHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private List<(PersistenceView, EEMANFFCIOG)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private (PersistenceView, EEMANFFCIOG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x685AA90", Offset = "0x6859C90", VA = "0x18685AA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x685B0A0", Offset = "0x685A2A0", VA = "0x18685B0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x68508C0", Offset = "0x684FAC0", VA = "0x1868508C0")]
	[AsyncStateMachine(typeof(KCCODJAAMGM))]
	public static Task FPBPNKPIOLJ(JIEBELBAAKC CNMFPFIJBEO, OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct OMHOMNOGGED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct BAEBMPKBPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public JIEBELBAAKC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public FOPAINLEJPB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private ADGDLBLFAGN <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private GBPKPFGCFHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private List<(PersistenceView, EEMANFFCIOG)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private EEMANFFCIOG <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x684AD20", Offset = "0x6849F20", VA = "0x18684AD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x684B570", Offset = "0x684A770", VA = "0x18684B570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6861810", Offset = "0x6860A10", VA = "0x186861810")]
	[AsyncStateMachine(typeof(BAEBMPKBPMA))]
	public static Task FPBPNKPIOLJ(JIEBELBAAKC CNMFPFIJBEO, OHJENCCOGPB FODGEDCJIDC, FOPAINLEJPB EFOOAHKCGNF, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct LKMHAEFMODF
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct IMKHOMEPFHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public List<GIEEMFPKLNM> JPKKEODJLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public List<EEMANFFCIOG> EGJHBEENMAN;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
		public IMKHOMEPFHJ(List<GIEEMFPKLNM> JPKKEODJLHE, List<EEMANFFCIOG> EGJHBEENMAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class KPBPGKJDLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public IEnumerable<GIEEMFPKLNM> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KPBPGKJDLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x685BC40", Offset = "0x685AE40", VA = "0x18685BC40")]
		internal object GCIGNDFFHEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private CKDPMMHNMPI GLFBENAFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private OHJENCCOGPB FODGEDCJIDC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private MBGMJCPJKBD JIBKPHHGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x685D660", Offset = "0x685C860", VA = "0x18685D660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x685D6B0", Offset = "0x685C8B0", VA = "0x18685D6B0")]
	public static IMKHOMEPFHJ FPBPNKPIOLJ(CKDPMMHNMPI GLFBENAFDIE, OHJENCCOGPB FODGEDCJIDC)
	{
		return default(IMKHOMEPFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x685D710", Offset = "0x685C910", VA = "0x18685D710")]
	private IMKHOMEPFHJ FPBPNKPIOLJ()
	{
		return default(IMKHOMEPFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x685DB30", Offset = "0x685CD30", VA = "0x18685DB30")]
	private IMKHOMEPFHJ NCOPMPFEOFA(LJKOKHIIAPB JPLMJPEMOMH, ADGDLBLFAGN NJCGNIJKBND)
	{
		return default(IMKHOMEPFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x685D960", Offset = "0x685CB60", VA = "0x18685D960")]
	private bool HCIHAMLKLHF(IEnumerable<GIEEMFPKLNM> JPKKEODJLHE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct JOMALJKCLMF
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class IGOMBNHDDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public LKMHAEFMODF.IMKHOMEPFHJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IGOMBNHDDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x6857350", Offset = "0x6856550", VA = "0x186857350")]
		internal object NHBDNCOBOKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class COKBGIIHPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public COKBGIIHPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x684E850", Offset = "0x684DA50", VA = "0x18684E850")]
		internal object DLNIIKBJDKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x685A4E0", Offset = "0x68596E0", VA = "0x18685A4E0")]
	public static void FPBPNKPIOLJ(JIEBELBAAKC CNMFPFIJBEO, OHJENCCOGPB FODGEDCJIDC, LKMHAEFMODF.IMKHOMEPFHJ LHDIEDCHDAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class GOKNNBMHMCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct FEMOJMHGJBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public PHAOMCMINAH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public OHJENCCOGPB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6850D20", Offset = "0x684FF20", VA = "0x186850D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6851490", Offset = "0x6850690", VA = "0x186851490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class OJKEAJCFHHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public OJKEAJCFHHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x6863260", Offset = "0x6862460", VA = "0x186863260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x6863520", Offset = "0x6862720", VA = "0x186863520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OJKEAJCFHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x68615E0", Offset = "0x68607E0", VA = "0x1868615E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task FCNEJFFKOIN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct OCLNIBPJBNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private OJKEAJCFHHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6860FE0", Offset = "0x68601E0", VA = "0x186860FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x6861510", Offset = "0x6860710", VA = "0x186861510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct MMIBIGAIGAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private Dictionary<Guid, List<EDLKGMCFPID>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x685ED00", Offset = "0x685DF00", VA = "0x18685ED00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x685F2B0", Offset = "0x685E4B0", VA = "0x18685F2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct ACLLAICGBFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private OPAMPAFNBOH<string>.GMFJCEOBAKO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private Dictionary<Guid, List<EDLKGMCFPID>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x6849FC0", Offset = "0x68491C0", VA = "0x186849FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x684A640", Offset = "0x6849840", VA = "0x18684A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class BLNJFMGFPEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public EDLKGMCFPID handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public BLNJFMGFPEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x6863060", Offset = "0x6862260", VA = "0x186863060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x6863200", Offset = "0x6862400", VA = "0x186863200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public EIGCBNAPHHB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public List<EDLKGMCFPID> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BLNJFMGFPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x684C1B0", Offset = "0x684B3B0", VA = "0x18684C1B0")]
		internal object MAFHPODCPHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x684C0C0", Offset = "0x684B2C0", VA = "0x18684C0C0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KAJJGOHAHOA(EDLKGMCFPID handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x684BFD0", Offset = "0x684B1D0", VA = "0x18684BFD0")]
		internal object JPHFKLJLHGP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct MEJNINLLFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public EIGCBNAPHHB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public List<EDLKGMCFPID> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private BLNJFMGFPEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x685E0E0", Offset = "0x685D2E0", VA = "0x18685E0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x685E5A0", Offset = "0x685D7A0", VA = "0x18685E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct FLFBHGKEELJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x6851990", Offset = "0x6850B90", VA = "0x186851990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x6851F50", Offset = "0x6851150", VA = "0x186851F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class JIHNBNDJBEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JIHNBNDJBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x6859330", Offset = "0x6858530", VA = "0x186859330")]
		internal object LIEJCNNJOME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct CGCIPJFLMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public OHJENCCOGPB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x684DE70", Offset = "0x684D070", VA = "0x18684DE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x684E330", Offset = "0x684D530", VA = "0x18684E330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class OCPIIMNCJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OCPIIMNCJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x6861570", Offset = "0x6860770", VA = "0x186861570")]
		internal object CDEGKLBECGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct CEANDMBPDBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public GOKNNBMHMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x684CBC0", Offset = "0x684BDC0", VA = "0x18684CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x684D1F0", Offset = "0x684C3F0", VA = "0x18684D1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class FNEIKPAMHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FNEIKPAMHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6851FB0", Offset = "0x68511B0", VA = "0x186851FB0")]
		internal object AODHHLCEGAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly MABGKFLOIKH PEKFMMFJMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private DCKPKHOJIBL JNMKKPHJPAE;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private JIEBELBAAKC JMKNKBLEADE
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10C7330", Offset = "0x10C6530", VA = "0x1810C7330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public GOKNNBMHMCI(MABGKFLOIKH PEKFMMFJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6854B70", Offset = "0x6853D70", VA = "0x186854B70")]
	[AsyncStateMachine(typeof(FEMOJMHGJBG))]
	public Task FPBPNKPIOLJ(PHAOMCMINAH EEBEFOOAFIG, OHJENCCOGPB GLDPHLIODOD, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x68553E0", Offset = "0x68545E0", VA = "0x1868553E0")]
	[AsyncStateMachine(typeof(OCLNIBPJBNB))]
	private Task NIDJPHAJBME(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x68547D0", Offset = "0x68539D0", VA = "0x1868547D0")]
	[AsyncStateMachine(typeof(MMIBIGAIGAC))]
	private Task FHDFLAFLICK(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6855110", Offset = "0x6854310", VA = "0x186855110")]
	[AsyncStateMachine(typeof(ACLLAICGBFI))]
	private Task JCCMJMHEJLD(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6854910", Offset = "0x6853B10", VA = "0x186854910")]
	[AsyncStateMachine(typeof(MEJNINLLFJL))]
	private Task FIKJJMALLIO(Guid DOONBHNMLIM, List<EDLKGMCFPID> JBEPFKHOHAH, EIGCBNAPHHB BNILOKBODJP, OHJENCCOGPB FODGEDCJIDC, CancellationToken FCKLPDKGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6854E00", Offset = "0x6854000", VA = "0x186854E00")]
	[AsyncStateMachine(typeof(FLFBHGKEELJ))]
	private Task GLEOOCJDIFJ(OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x6854CC0", Offset = "0x6853EC0", VA = "0x186854CC0")]
	[AsyncStateMachine(typeof(CGCIPJFLMCF))]
	private Task GJMDKJNLHAI(Guid BPEOOJOLHBP, OHJENCCOGPB FODGEDCJIDC, OPAMPAFNBOH<string>.GMFJCEOBAKO NEKANGAICOD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x6854690", Offset = "0x6853890", VA = "0x186854690")]
	[AsyncStateMachine(typeof(CEANDMBPDBP))]
	private Task DLOHJJGGBAA(Guid BPEOOJOLHBP, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6854A60", Offset = "0x6853C60", VA = "0x186854A60")]
	private void FOKJPLNGCNE(Guid BPEOOJOLHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x68545E0", Offset = "0x68537E0", VA = "0x1868545E0")]
	private void CFMCKMHMAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x6855250", Offset = "0x6854450", VA = "0x186855250")]
	public Guid MLDJCHMKHDF(PHAOMCMINAH GBCDHKFIPMO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6854F40", Offset = "0x6854140", VA = "0x186854F40")]
	[CompilerGenerated]
	private object JANGOCGBMNC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct FHIOLGLBKGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly bool CLGOCOCLFDN;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0xCCE730", Offset = "0xCCD930", VA = "0x180CCE730")]
	public FHIOLGLBKGD(bool GIBIMKIJKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct OMANNHIFEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly LJKOKHIIAPB? NINOCIJEGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	public readonly BMLAADAJJOP MHBMFJKGLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	public readonly string? EINGHOMJKEC;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IReadOnlyCollection<string> OIIMLLENOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x68616F0", Offset = "0x68608F0", VA = "0x1868616F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IReadOnlyDictionary<long, int> HCBHOKHLIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x68616D0", Offset = "0x68608D0", VA = "0x1868616D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x6861710", Offset = "0x6860910", VA = "0x186861710")]
	public OMANNHIFEOF(LJKOKHIIAPB? JENPAMGBIKD, BMLAADAJJOP HHNCEDLNOBD, string? KGLKFKGMHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class JLINNMPIBDH : HCDDBDMEOJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct KKOKIFCHHAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<OMANNHIFEOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public JLINNMPIBDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CPGLEDGDMKI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public JLGKMCENPAK roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private GBPKPFGCFHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x685B560", Offset = "0x685A760", VA = "0x18685B560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x685BBD0", Offset = "0x685ADD0", VA = "0x18685BBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class CBINJNPHGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public CPGLEDGDMKI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public JLINNMPIBDH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CBINJNPHGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x684C8D0", Offset = "0x684BAD0", VA = "0x18684C8D0")]
		internal Task AEINNMHFBML(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x684CAE0", Offset = "0x684BCE0", VA = "0x18684CAE0")]
		internal Task KFAMHJFKEOJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class DJNNLOJKKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CBINJNPHGLG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DJNNLOJKKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x684EDE0", Offset = "0x684DFE0", VA = "0x18684EDE0")]
		internal object KIBCLBMIAGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class KKEOOCPKEBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public CBINJNPHGLG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KKEOOCPKEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x685B520", Offset = "0x685A720", VA = "0x18685B520")]
		internal Task EDHKMJOCFJO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct NCNINOIJBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public CPGLEDGDMKI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public JLINNMPIBDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private DJNNLOJKKDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private GBPKPFGCFHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x685FFE0", Offset = "0x685F1E0", VA = "0x18685FFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6860840", Offset = "0x685FA40", VA = "0x186860840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private static readonly TimeSpan JAOINOAOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private readonly ILPKLFNNNNP FPHLGGGCJIH;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x685A490", Offset = "0x6859690", VA = "0x18685A490")]
	public JLINNMPIBDH(MABGKFLOIKH PEKFMMFJMHO, ILPKLFNNNNP FPHLGGGCJIH, JJNHGMIGPBK OMJOPGOBIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x685A2C0", Offset = "0x68594C0", VA = "0x18685A2C0")]
	[AsyncStateMachine(typeof(KKOKIFCHHAH))]
	public Task<OMANNHIFEOF> OHDBDPJBHPM(long PFDCKFHEHAO, JLGKMCENPAK PJKGFCALJDN, CPGLEDGDMKI NBKHDDLHNPG, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x68593A0", Offset = "0x68585A0", VA = "0x1868593A0")]
	[AsyncStateMachine(typeof(NCNINOIJBCN))]
	private Task BNGDDJPLEJE(CPGLEDGDMKI NBKHDDLHNPG, IEnumerable<PersistenceView> CCGNFFHECFJ, StringBuilder AKJDJEPFAKO, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x6859730", Offset = "0x6858930", VA = "0x186859730")]
	private OMANNHIFEOF EHEJPNDNIEL(long PFDCKFHEHAO, JLGKMCENPAK PJKGFCALJDN, CPGLEDGDMKI NBKHDDLHNPG, IEnumerable<PersistenceView> CCGNFFHECFJ, StringBuilder AKJDJEPFAKO)
	{
		return default(OMANNHIFEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x685A170", Offset = "0x6859370", VA = "0x18685A170")]
	private LJKOKHIIAPB GNAAHIOPEAH(long PFDCKFHEHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x68594E0", Offset = "0x68586E0", VA = "0x1868594E0")]
	private void DALMLKPKDKL(LJKOKHIIAPB CCOIJMNKOCO, StringBuilder AKJDJEPFAKO, IEnumerable<PersistenceView> CCGNFFHECFJ, [In] BJLDLAPONEC PGALLDBLLLA, KDDDHEJGDDM HJEHMBAMFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x6859CE0", Offset = "0x6858EE0", VA = "0x186859CE0")]
	private void GIIKCIEDMDM(LJKOKHIIAPB CCOIJMNKOCO, StringBuilder AKJDJEPFAKO, PersistenceView LNHHACHOOKF, KDDDHEJGDDM HJEHMBAMFCI, [In] BJLDLAPONEC PGALLDBLLLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class GJHHNFFFKEI : HCDDBDMEOJD
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class IGCOKAIEIOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public NPBNNGJMDHE.BJLBEDAHNAN roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IGCOKAIEIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x6857300", Offset = "0x6856500", VA = "0x186857300")]
		internal object FLPJIKONHJC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct FBAIEADMGOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder<(NPBNNGJMDHE.BJLBEDAHNAN roomDataUpload, NPBNNGJMDHE.BJLBEDAHNAN subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public OMANNHIFEOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public GJHHNFFFKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private IGCOKAIEIOF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<NPBNNGJMDHE.BJLBEDAHNAN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x6850000", Offset = "0x684F200", VA = "0x186850000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6850850", Offset = "0x684FA50", VA = "0x186850850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct EAIPLHGHKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder<OEBGDEELFDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public GJHHNFFFKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public OMANNHIFEOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public DELDHEKMCNB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<(NPBNNGJMDHE.BJLBEDAHNAN roomDataUpload, NPBNNGJMDHE.BJLBEDAHNAN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter<OEBGDEELFDO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x684EE50", Offset = "0x684E050", VA = "0x18684EE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x684F470", Offset = "0x684E670", VA = "0x18684F470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct MPILALHILFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public AsyncTaskMethodBuilder<GBAFELGEGBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public GJHHNFFFKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public OMANNHIFEOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private TaskAwaiter<(NPBNNGJMDHE.BJLBEDAHNAN roomDataUpload, NPBNNGJMDHE.BJLBEDAHNAN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private TaskAwaiter<GBAFELGEGBB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x685F310", Offset = "0x685E510", VA = "0x18685F310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x685F730", Offset = "0x685E930", VA = "0x18685F730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class LCLBJOGPCLG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			public LCLBJOGPCLG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private LCFKPKINCJE <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<GBAFELGEGBB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter<OEBGDEELFDO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			private TaskAwaiter<LCFKPKINCJE> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x6863580", Offset = "0x6862780", VA = "0x186863580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x6864510", Offset = "0x6863710", VA = "0x186864510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public GJHHNFFFKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public OMANNHIFEOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public DELDHEKMCNB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public FHIOLGLBKGD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LCLBJOGPCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x685CF90", Offset = "0x685C190", VA = "0x18685CF90")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<LCFKPKINCJE> LDFHLCEBHIM(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct BKEGKFLJKKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public AsyncTaskMethodBuilder<LCFKPKINCJE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public GJHHNFFFKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public OMANNHIFEOF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public DELDHEKMCNB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public FHIOLGLBKGD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public OPAMPAFNBOH<string>.GMFJCEOBAKO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter<LCFKPKINCJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x684BC50", Offset = "0x684AE50", VA = "0x18684BC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x684BF60", Offset = "0x684B160", VA = "0x18684BF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private static readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly JJNHGMIGPBK KLMGKIJGMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly EOACLIOLDGJ FHKEINDEILC;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private CKDPMMHNMPI NLMNGKBNDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x6830200", Offset = "0x682F400", VA = "0x186830200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6853AF0", Offset = "0x6852CF0", VA = "0x186853AF0")]
	public GJHHNFFFKEI(MABGKFLOIKH PEKFMMFJMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6853780", Offset = "0x6852980", VA = "0x186853780")]
	[AsyncStateMachine(typeof(FBAIEADMGOL))]
	private Task<(NPBNNGJMDHE.BJLBEDAHNAN, NPBNNGJMDHE.BJLBEDAHNAN)> FOLBCLBJIIJ(OMANNHIFEOF JBHELBFKKCJ, long NCFOOPOBBIJ, long DIKKNIGACBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6853610", Offset = "0x6852810", VA = "0x186853610")]
	[AsyncStateMachine(typeof(EAIPLHGHKIP))]
	public Task<OEBGDEELFDO> CLDLFFJHGNK(int CPJEKHLMDEN, [CanBeNull] DELDHEKMCNB JOLPLLJAELN, OMANNHIFEOF JBHELBFKKCJ, long NCFOOPOBBIJ, long DIKKNIGACBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x68534A0", Offset = "0x68526A0", VA = "0x1868534A0")]
	[AsyncStateMachine(typeof(MPILALHILFP))]
	private Task<GBAFELGEGBB> CFPHDCIELJP(string CNJEKLNGLPI, int CPJEKHLMDEN, OMANNHIFEOF JBHELBFKKCJ, long NCFOOPOBBIJ, long DIKKNIGACBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x68538C0", Offset = "0x6852AC0", VA = "0x1868538C0")]
	[AsyncStateMachine(typeof(BKEGKFLJKKN))]
	public Task<LCFKPKINCJE> GNEBMAAOFPH(int CPJEKHLMDEN, DELDHEKMCNB? JOLPLLJAELN, OMANNHIFEOF JBHELBFKKCJ, long NCFOOPOBBIJ, long DIKKNIGACBL, FHIOLGLBKGD EOLNHOGDCAM, OPAMPAFNBOH<string>.GMFJCEOBAKO PDLDHPLCOMN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class JAJFGFPHINK<T> where T : JAJFGFPHINK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	internal readonly CKDPMMHNMPI PLBDPOJDJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private int? ACNFJOIGINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	protected readonly Guid BLNCNJHFIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	protected readonly ANBJHFCMHDB NCELCGAAHDH;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	protected T AJBFIOPONFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5F50", Offset = "0x3BE5150", VA = "0x183BE5F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6330", Offset = "0x3BE5530", VA = "0x183BE6330")]
	internal JAJFGFPHINK(CKDPMMHNMPI AHNNJPNPLPO, ANBJHFCMHDB EPNKNGICODC, [Optional] Guid? FNMGFNFDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6130", Offset = "0x3BE5330", VA = "0x183BE6130")]
	private LCFKPKINCJE EABHIBOAIMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
	protected virtual void EOGEBNFKLCK(LCFKPKINCJE JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6040", Offset = "0x3BE5240", VA = "0x183BE6040")]
	public T DGCOPIGNKKK(EOBANJCDGLI NEJMNOMAPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5FB0", Offset = "0x3BE51B0", VA = "0x183BE5FB0")]
	public T BMAFNLNDLBO(int MIGKAIDIGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3BE6210", Offset = "0x3BE5410", VA = "0x183BE6210", Slot = "5")]
	public virtual Task<CLBPNGLMFHJ> MNGHPKGCDFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class LKFCEJIIHFP : JAJFGFPHINK<LKFCEJIIHFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private HGFIJEMHMDL AENCBMJJMMB;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x685D590", Offset = "0x685C790", VA = "0x18685D590")]
	internal LKFCEJIIHFP(CKDPMMHNMPI AHNNJPNPLPO, ANBJHFCMHDB EPNKNGICODC, [Optional] Guid? FNMGFNFDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x5E37E70", Offset = "0x5E37070", VA = "0x185E37E70")]
	public LKFCEJIIHFP PPFLKLBJEFP(HGFIJEMHMDL AENCBMJJMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x685D4C0", Offset = "0x685C6C0", VA = "0x18685D4C0", Slot = "4")]
	protected override void EOGEBNFKLCK(LCFKPKINCJE JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class HMPACPFKLNH : JAJFGFPHINK<HMPACPFKLNH>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum CMCCACMOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct KIJFILAJKAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public AsyncTaskMethodBuilder<CLBPNGLMFHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public HMPACPFKLNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<CLBPNGLMFHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x685B100", Offset = "0x685A300", VA = "0x18685B100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x685B4B0", Offset = "0x685A6B0", VA = "0x18685B4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private CMCCACMOIMM NKAFGAFAIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private string MLCDDCNJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private DELDHEKMCNB AENCBMJJMMB;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x68561B0", Offset = "0x68553B0", VA = "0x1868561B0")]
	internal HMPACPFKLNH(CKDPMMHNMPI AHNNJPNPLPO, ANBJHFCMHDB EPNKNGICODC, [Optional] Guid? FNMGFNFDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6855ED0", Offset = "0x68550D0", VA = "0x186855ED0")]
	public HMPACPFKLNH CMOGEDNJMJN(string ALPNBPOHMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x6855F00", Offset = "0x6855100", VA = "0x186855F00")]
	public HMPACPFKLNH DAFADLLGOAP(bool FKDFHFJFGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6856180", Offset = "0x6855380", VA = "0x186856180")]
	public HMPACPFKLNH PFDDCEBAANB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x6855F20", Offset = "0x6855120", VA = "0x186855F20", Slot = "4")]
	protected override void EOGEBNFKLCK(LCFKPKINCJE JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6856090", Offset = "0x6855290", VA = "0x186856090", Slot = "5")]
	[AsyncStateMachine(typeof(KIJFILAJKAM))]
	public override Task<CLBPNGLMFHJ> MNGHPKGCDFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x6855E90", Offset = "0x6855090", VA = "0x186855E90")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<CLBPNGLMFHJ> ACBOHFCDEKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class DILPOGCMHPK
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x684E960", Offset = "0x684DB60", VA = "0x18684E960")]
	public static void JKKHJMEPMBP(this NHDDMMGHJDJ CLBFODCFLBG, NKKGGOEDKKI FPCPKGOIGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x684E8E0", Offset = "0x684DAE0", VA = "0x18684E8E0")]
	public static void DJJPMLLDLGJ(this NKKGGOEDKKI GNBINPCIBGN, [Optional] string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class JGENIEKOGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x6858FB0", Offset = "0x68581B0", VA = "0x186858FB0")]
	public static CBHGKMFEFBA IGLDKBHBOPJ(this JDIHDKMHJMH JJCIOGGMGGH)
	{
		return default(CBHGKMFEFBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x6858F00", Offset = "0x6858100", VA = "0x186858F00")]
	public static JDIHDKMHJMH FPJIDIOJBMG(this CBHGKMFEFBA FOOLKGEMFGI)
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
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public JLHOFAIKPIE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public JLHOFAIKPIE HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private static JLHOFAIKPIE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private Dictionary<JLHOFAIKPIE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x6864BB0", Offset = "0x6863DB0", VA = "0x186864BB0")]
		public bool BKMLCEGHFKB(JLHOFAIKPIE LMKMEAKIJPP, [Out] ResultConfig GPNOOFEABCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6864C20", Offset = "0x6863E20", VA = "0x186864C20")]
		public ResultConfig LLOOFEGPOJK(JLHOFAIKPIE LGGFDGCPFCF, [Optional] HashSet<JLHOFAIKPIE> HCDPEFHCLDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x6865300", Offset = "0x6864500", VA = "0x186865300", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x6864D60", Offset = "0x6863F60", VA = "0x186864D60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA0", Offset = "0x899FA0", VA = "0x18089ADA0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class CNCAAJEELMA
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x684E390", Offset = "0x684D590", VA = "0x18684E390")]
	[KEFCCLBEAOJ(CMEECPGEPNF.GameOnly)]
	private static void PALMNDDNMFI(LEHDPNIFNIH AJCCGGFMFPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface OBBCDGFHJBJ : IEquatable<OBBCDGFHJBJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	DateTime BIJDFDKMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDEIJPAADPP();

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJPKKNKJFEH(long NCFOOPOBBIJ, long PFDCKFHEHAO, [Out] OMANNHIFEOF JBHELBFKKCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class LCBGFPELCKM : LLKJAJLMJGE
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class LEHAHHMMOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public EDCMFPOJOOL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LEHAHHMMOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x685D450", Offset = "0x685C650", VA = "0x18685D450")]
		internal object CBPANOMDEPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly MKMOFOJFOLJ CBNAJOLDANJ;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OBBCDGFHJBJ> LJBHAIGIBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x685CEE0", Offset = "0x685C0E0", VA = "0x18685CEE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x685CE30", Offset = "0x685C030", VA = "0x18685CE30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	[UnityEngine.Scripting.Preserve]
	public LCBGFPELCKM([GAGPBLHNPNO(null)] MKMOFOJFOLJ CBNAJOLDANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x685C540", Offset = "0x685B740", VA = "0x18685C540", Slot = "6")]
	public bool BGNDEPJEIIK(long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ, EDCMFPOJOOL GBMDEGJEOMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x1A79090", Offset = "0x1A78290", VA = "0x181A79090")]
	private void GCBMPLEBEJB(OBBCDGFHJBJ AMFIFOBJCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x685C3D0", Offset = "0x685B5D0", VA = "0x18685C3D0", Slot = "7")]
	public bool ANHBBBHFLMI(long NCFOOPOBBIJ, long PFDCKFHEHAO, [Out] OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x685C950", Offset = "0x685BB50", VA = "0x18685C950", Slot = "8")]
	public bool FPDJHNKFOOF(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, [Out] OBBCDGFHJBJ MAMJPFLGEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x685CA00", Offset = "0x685BC00", VA = "0x18685CA00")]
	private void MGPGBOAKGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x685C820", Offset = "0x685BA20", VA = "0x18685C820", Slot = "9")]
	public void BPLNHNKBBJO(long NCFOOPOBBIJ, long PFDCKFHEHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class JCDKHJGOFJL : MKMOFOJFOLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum JNOHIBEGLOD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class DJAHNLJKKPF : IEnumerable<OBBCDGFHJBJ>, IEnumerable, IEnumerator<OBBCDGFHJBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private OBBCDGFHJBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public JCDKHJGOFJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private EDCMFPOJOOL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public EDCMFPOJOOL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private OBBCDGFHJBJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public DJAHNLJKKPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x684EAB0", Offset = "0x684DCB0", VA = "0x18684EAB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x684ED90", Offset = "0x684DF90", VA = "0x18684ED90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x684ECE0", Offset = "0x684DEE0", VA = "0x18684ECE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OBBCDGFHJBJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x684ECE0", Offset = "0x684DEE0", VA = "0x18684ECE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class OMLHGFNCIEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public EDCMFPOJOOL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OMLHGFNCIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6861950", Offset = "0x6860B50", VA = "0x186861950")]
		internal object OPJEAGEIJPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class NLIONLHFIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public JCDKHJGOFJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NLIONLHFIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x6860F60", Offset = "0x6860160", VA = "0x186860F60")]
		internal void MLCJNCCFCCC(OFGLALMCFPK.IIJKLLMNBOI ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	protected readonly string JBFHHKMOFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly object BEMEDKONAEO;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract IHCIMLKCGLG EKPKIEDABLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6858E60", Offset = "0x6858060", VA = "0x186858E60")]
	protected JCDKHJGOFJL([CanBeNull] string KFNCOAHNOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x6858C70", Offset = "0x6857E70", VA = "0x186858C70", Slot = "5")]
	public bool JKNKCELLIOO(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, [Out] OBBCDGFHJBJ AMFIFOBJCGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x6858470", Offset = "0x6857670", VA = "0x186858470", Slot = "6")]
	[IteratorStateMachine(typeof(DJAHNLJKKPF))]
	public IEnumerable<OBBCDGFHJBJ> ELJCDLMFJEB(EDCMFPOJOOL GBMDEGJEOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void PNGGMIPFFBB(Stream ENJBPJNPFCJ, long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AFJKDFJKCPD(Stream LFOKAFOHBLF, long NCFOOPOBBIJ, long PFDCKFHEHAO, OHPLNKIIIJE GMNBAEMLECO, [Out] OMANNHIFEOF JBHELBFKKCJ);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x6858570", Offset = "0x6857770", VA = "0x186858570", Slot = "7")]
	public OBBCDGFHJBJ HFKKHHCDGIK(long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ, EDCMFPOJOOL GBMDEGJEOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo BALCFDDOOPO(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, JNOHIBEGLOD CCJAKDCOBNI);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo EFHGKKEOGPJ(EDCMFPOJOOL GBMDEGJEOMP, JNOHIBEGLOD CCJAKDCOBNI);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6858500", Offset = "0x6857700", VA = "0x186858500")]
	protected void EMKMMEBNICH(OFGLALMCFPK.IIJKLLMNBOI ENGKFDAKMMA, string BNFCMKEEELL, FileInfo LPGKKKICLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x68588E0", Offset = "0x6857AE0", VA = "0x1868588E0")]
	internal bool IPLEHHMIDNL(FileInfo JKACOPEJGDG, long NCFOOPOBBIJ, long PFDCKFHEHAO, [Out] OMANNHIFEOF JBHELBFKKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private void BAHHLMFAJCL(Exception PFDFCFFEKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class CEJHDFMEGAD : JCDKHJGOFJL
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override IHCIMLKCGLG EKPKIEDABLK
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xBFCED0", Offset = "0xBFC0D0", VA = "0x180BFCED0", Slot = "8")]
		get
		{
			return default(IHCIMLKCGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x684DDB0", Offset = "0x684CFB0", VA = "0x18684DDB0")]
	public CEJHDFMEGAD([Optional] string KFNCOAHNOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x684DAA0", Offset = "0x684CCA0", VA = "0x18684DAA0")]
	private void KODDLLGPKAN(EDCMFPOJOOL GBMDEGJEOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x684DB20", Offset = "0x684CD20", VA = "0x18684DB20", Slot = "9")]
	internal override void PNGGMIPFFBB(Stream ENJBPJNPFCJ, long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x684D250", Offset = "0x684C450", VA = "0x18684D250", Slot = "10")]
	internal override bool AFJKDFJKCPD(Stream LFOKAFOHBLF, long NCFOOPOBBIJ, long PFDCKFHEHAO, OHPLNKIIIJE GMNBAEMLECO, [Out] OMANNHIFEOF JBHELBFKKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x684D8A0", Offset = "0x684CAA0", VA = "0x18684D8A0", Slot = "11")]
	protected override FileInfo BALCFDDOOPO(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, JNOHIBEGLOD CCJAKDCOBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x684D990", Offset = "0x684CB90", VA = "0x18684D990", Slot = "12")]
	protected override DirectoryInfo EFHGKKEOGPJ(EDCMFPOJOOL GBMDEGJEOMP, JNOHIBEGLOD CCJAKDCOBNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class ICEDBPCPNIG : JCDKHJGOFJL
{
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private static readonly byte[] GOBGGNLGONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private readonly byte[] GNEFBNJLFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly byte[] HOEILHFEKKM;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override IHCIMLKCGLG EKPKIEDABLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x56F46A0", Offset = "0x56F38A0", VA = "0x1856F46A0", Slot = "8")]
		get
		{
			return default(IHCIMLKCGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x68571A0", Offset = "0x68563A0", VA = "0x1868571A0")]
	public ICEDBPCPNIG([Optional] string KFNCOAHNOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x6856E50", Offset = "0x6856050", VA = "0x186856E50", Slot = "9")]
	internal override void PNGGMIPFFBB(Stream ENJBPJNPFCJ, long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6856320", Offset = "0x6855520", VA = "0x186856320", Slot = "10")]
	internal override bool AFJKDFJKCPD(Stream LFOKAFOHBLF, long NCFOOPOBBIJ, long PFDCKFHEHAO, OHPLNKIIIJE GMNBAEMLECO, [Out] OMANNHIFEOF JBHELBFKKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x6856C80", Offset = "0x6855E80", VA = "0x186856C80")]
	private void BGENCNLDEIP(byte[] CGAHJPHALBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6856B50", Offset = "0x6855D50", VA = "0x186856B50", Slot = "11")]
	protected override FileInfo BALCFDDOOPO(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, JNOHIBEGLOD CCJAKDCOBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6856D40", Offset = "0x6855F40", VA = "0x186856D40", Slot = "12")]
	protected override DirectoryInfo EFHGKKEOGPJ(EDCMFPOJOOL GBMDEGJEOMP, JNOHIBEGLOD CCJAKDCOBNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum IHCIMLKCGLG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class MPNBFFKJJNN : MKMOFOJFOLJ
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class PBAHBPDPIPJ : IEnumerable<OBBCDGFHJBJ>, IEnumerable, IEnumerator<OBBCDGFHJBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private OBBCDGFHJBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public MPNBFFKJJNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private EDCMFPOJOOL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public EDCMFPOJOOL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private IHCIMLKCGLG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private IEnumerator<OBBCDGFHJBJ> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private OBBCDGFHJBJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public PBAHBPDPIPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6861E20", Offset = "0x6861020", VA = "0x186861E20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6861A40", Offset = "0x6860C40", VA = "0x186861A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x68619F0", Offset = "0x6860BF0", VA = "0x1868619F0")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x6861DD0", Offset = "0x6860FD0", VA = "0x186861DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x6861D20", Offset = "0x6860F20", VA = "0x186861D20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OBBCDGFHJBJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x6861D20", Offset = "0x6860F20", VA = "0x186861D20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private readonly IHCIMLKCGLG[] KHGEIPHIBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private readonly Dictionary<IHCIMLKCGLG, MKMOFOJFOLJ> DMKBCIACBOF;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IHCIMLKCGLG EKPKIEDABLK
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x685F7A0", Offset = "0x685E9A0", VA = "0x18685F7A0", Slot = "4")]
		get
		{
			return default(IHCIMLKCGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x685FCB0", Offset = "0x685EEB0", VA = "0x18685FCB0")]
	[UnityEngine.Scripting.Preserve]
	public MPNBFFKJJNN(params MKMOFOJFOLJ[] IBMEIJLBHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x685F940", Offset = "0x685EB40", VA = "0x18685F940", Slot = "5")]
	public bool JKNKCELLIOO(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, [Out] OBBCDGFHJBJ AMFIFOBJCGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x685FA90", Offset = "0x685EC90", VA = "0x18685FA90")]
	private void OGAFJMMELJC(int KBOBBKHGOKK, long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x685F7D0", Offset = "0x685E9D0", VA = "0x18685F7D0", Slot = "6")]
	[IteratorStateMachine(typeof(PBAHBPDPIPJ))]
	public IEnumerable<OBBCDGFHJBJ> ELJCDLMFJEB(EDCMFPOJOOL GBMDEGJEOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x685F860", Offset = "0x685EA60", VA = "0x18685F860", Slot = "7")]
	public OBBCDGFHJBJ HFKKHHCDGIK(long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ, EDCMFPOJOOL GBMDEGJEOMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class FCEABKKFDFP
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6850BE0", Offset = "0x684FDE0", VA = "0x186850BE0")]
	internal static byte[] ECGHEIAMKAJ(byte[] CGAHJPHALBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6850CA0", Offset = "0x684FEA0", VA = "0x186850CA0")]
	public static void EOMKFIPFLGN(Stream KIIMFPPABLA, byte[] KECPBKJDJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x6850A00", Offset = "0x684FC00", VA = "0x186850A00")]
	public static bool CDBNPIOHDLG(Stream KIIMFPPABLA, long DAGPLDIMHCP, OHPLNKIIIJE DICNOIOMOJF, [Out] byte[] EMMOEMKDAFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class ILFLCGHAJNK : OBBCDGFHJBJ, IEquatable<OBBCDGFHJBJ>, IEquatable<ILFLCGHAJNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private readonly JCDKHJGOFJL EJGKJOLOJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	public readonly FileInfo AFAEGOIHFLE;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IHCIMLKCGLG EKPKIEDABLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x6297A40", Offset = "0x6296C40", VA = "0x186297A40", Slot = "9")]
		get
		{
			return default(IHCIMLKCGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public DateTime BIJDFDKMOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x6858220", Offset = "0x6857420", VA = "0x186858220", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6858360", Offset = "0x6857560", VA = "0x186858360")]
	public ILFLCGHAJNK(JCDKHJGOFJL MJEMJHCFDBC, FileInfo JKACOPEJGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x68582B0", Offset = "0x68574B0", VA = "0x1868582B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6858160", Offset = "0x6857360", VA = "0x186858160", Slot = "5")]
	public void HDEIJPAADPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x6857E00", Offset = "0x6857000", VA = "0x186857E00", Slot = "6")]
	public bool CJPKKNKJFEH(long NCFOOPOBBIJ, long PFDCKFHEHAO, [Out] OMANNHIFEOF JBHELBFKKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6857E40", Offset = "0x6857040", VA = "0x186857E40", Slot = "7")]
	public bool Equals(OBBCDGFHJBJ NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x6857F20", Offset = "0x6857120", VA = "0x186857F20", Slot = "8")]
	public bool Equals(ILFLCGHAJNK NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6857FE0", Offset = "0x68571E0", VA = "0x186857FE0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x68580D0", Offset = "0x68572D0", VA = "0x1868580D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void OHPLNKIIIJE(OFGLALMCFPK.IIJKLLMNBOI MLJJBFKFFKJ, string JGNAJPMGGNE);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface MKMOFOJFOLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	IHCIMLKCGLG EKPKIEDABLK
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JKNKCELLIOO(long NCFOOPOBBIJ, long PFDCKFHEHAO, EDCMFPOJOOL GBMDEGJEOMP, [Out] OBBCDGFHJBJ AMFIFOBJCGP);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OBBCDGFHJBJ> ELJCDLMFJEB(EDCMFPOJOOL GBMDEGJEOMP);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OBBCDGFHJBJ HFKKHHCDGIK(long NCFOOPOBBIJ, long PFDCKFHEHAO, OMANNHIFEOF JBHELBFKKCJ, EDCMFPOJOOL GBMDEGJEOMP);
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
