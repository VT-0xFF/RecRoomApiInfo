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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EA20", Offset = "0x6F6D620", VA = "0x186F6EA20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
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
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A660", Offset = "0x6F69260", VA = "0x186F6A660", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PJFCNDDBABI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FB70", Offset = "0x6F6E770", VA = "0x186F6FB70")]
	public PJFCNDDBABI(string JIMAFLGJGFB, Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class OOOEJKJFHDK : NENKBFOMHBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JKOPIMIMBOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LKAHMCOOOOD>> <>t__builder;

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
		private TaskAwaiter<BACFHDJFCMM<LKAHMCOOOOD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F64320", Offset = "0x6F62F20", VA = "0x186F64320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F64560", Offset = "0x6F63160", VA = "0x186F64560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CKIAGIGBJHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NBMPOJDPANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<NBMPOJDPANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F55B20", Offset = "0x6F54720", VA = "0x186F55B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F55D30", Offset = "0x6F54930", VA = "0x186F55D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	[UnityEngine.Scripting.Preserve]
	public OOOEJKJFHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FA00", Offset = "0x6F6E600", VA = "0x186F6FA00", Slot = "4")]
	[AsyncStateMachine(typeof(JKOPIMIMBOK))]
	public Task<IReadOnlyList<LKAHMCOOOOD>> MGCBFAHKPHK(long NBIMAGPPMDN, long INCOHCKKKJD, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F8F0", Offset = "0x6F6E4F0", VA = "0x186F6F8F0", Slot = "5")]
	[AsyncStateMachine(typeof(CKIAGIGBJHE))]
	public Task<IReadOnlyList<NBMPOJDPANG>> JMGIIABJGLN(IReadOnlyList<int> BODDFGMAFEN, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HMKCGONNNPH : IEquatable<HMKCGONNNPH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GCEHEIAFKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	NBMPOJDPANG CGNJMDHBEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime BNDLOBEPENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KEPGBJPOLGH? FCMBGFNONIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PKCGAFNPDHM? OKNJEAMNHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JMNJNKJKGGK HJAGADOKNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FBOKJACJPGA> BHICPPJIKLN();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JMNJNKJKGGK
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NENKBFOMHBE
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<LKAHMCOOOOD>> MGCBFAHKPHK(long NBIMAGPPMDN, long INCOHCKKKJD, [Optional] CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<NBMPOJDPANG>> JMGIIABJGLN(IReadOnlyList<int> BODDFGMAFEN, [Optional] CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GLGDMFBEGMN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class OMNANCEKLFI : HMKCGONNNPH, IEquatable<HMKCGONNNPH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct NKEJCBBODHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OMNANCEKLFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private OLLALIAMOOG <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<FMLBFFJHFNC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<FBOKJACJPGA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F6E510", Offset = "0x6F6D110", VA = "0x186F6E510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F6E9B0", Offset = "0x6F6D5B0", VA = "0x186F6E9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LKAHMCOOOOD IHLCPPOBGOO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int GCEHEIAFKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NBMPOJDPANG CGNJMDHBEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime HPDIKBDEBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B42980", Offset = "0x5B41580", VA = "0x185B42980", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KEPGBJPOLGH? FCMBGFNONIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1BCA420", Offset = "0x1BC9020", VA = "0x181BCA420", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PKCGAFNPDHM? OKNJEAMNHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B42A60", Offset = "0x5B41660", VA = "0x185B42A60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JMNJNKJKGGK HJAGADOKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "10")]
			get
			{
				return default(JMNJNKJKGGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F5A0", Offset = "0x6F6E1A0", VA = "0x186F6F5A0", Slot = "9")]
		[AsyncStateMachine(typeof(NKEJCBBODHN))]
		public Task<FBOKJACJPGA> BHICPPJIKLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F890", Offset = "0x6F6E490", VA = "0x186F6F890")]
		public OMNANCEKLFI(int NCIDFIKMEEM, NBMPOJDPANG LKEJDPIGMBC, LKAHMCOOOOD IHLCPPOBGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F780", Offset = "0x6F6E380", VA = "0x186F6F780", Slot = "11")]
		public bool Equals(HMKCGONNNPH OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F6E0", Offset = "0x6F6E2E0", VA = "0x186F6F6E0", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F6A0", Offset = "0x6F6E2A0", VA = "0x186F6F6A0")]
		private bool COIKLEOOMML(OMNANCEKLFI OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F810", Offset = "0x6F6E410", VA = "0x186F6F810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class HMPFOJLJADN : HMKCGONNNPH, IEquatable<HMKCGONNNPH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct APKKFIPAMIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HMPFOJLJADN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<FBOKJACJPGA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F53000", Offset = "0x6F51C00", VA = "0x186F53000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F53230", Offset = "0x6F51E30", VA = "0x186F53230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly ACFFOKBAEJM MNCLNHBHMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KEPGBJPOLGH HKIDPPJCHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly PKCGAFNPDHM EBKAHKJLFGJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int GCEHEIAFKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F611E0", Offset = "0x6F5FDE0", VA = "0x186F611E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NBMPOJDPANG CGNJMDHBEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F61630", Offset = "0x6F60230", VA = "0x186F61630", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime HPDIKBDEBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F61510", Offset = "0x6F60110", VA = "0x186F61510", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KEPGBJPOLGH? FCMBGFNONIO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F61370", Offset = "0x6F5FF70", VA = "0x186F61370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PKCGAFNPDHM? OKNJEAMNHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F615E0", Offset = "0x6F601E0", VA = "0x186F615E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JMNJNKJKGGK HJAGADOKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D90", Offset = "0x8B3990", VA = "0x1808B4D90", Slot = "10")]
			get
			{
				return default(JMNJNKJKGGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10C28A0", Offset = "0x10C14A0", VA = "0x1810C28A0")]
		public HMPFOJLJADN(ACFFOKBAEJM EICCBKKAPGP, KEPGBJPOLGH MMKLPDAGIHD, PKCGAFNPDHM MJNIIFDMKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F61220", Offset = "0x6F5FE20", VA = "0x186F61220", Slot = "9")]
		[AsyncStateMachine(typeof(APKKFIPAMIP))]
		public Task<FBOKJACJPGA> BHICPPJIKLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F61470", Offset = "0x6F60070", VA = "0x186F61470", Slot = "11")]
		public bool Equals(HMKCGONNNPH OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F613C0", Offset = "0x6F5FFC0", VA = "0x186F613C0", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F61310", Offset = "0x6F5FF10", VA = "0x186F61310")]
		private bool COIKLEOOMML(HMPFOJLJADN OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F61560", Offset = "0x6F60160", VA = "0x186F61560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LEKBJPAEOJI : HMKCGONNNPH, IEquatable<HMKCGONNNPH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct FOBLHAMJDEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<FBOKJACJPGA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F5A0C0", Offset = "0x6F58CC0", VA = "0x186F5A0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F5A300", Offset = "0x6F58F00", VA = "0x186F5A300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly NBMPOJDPANG HBNLFOFIFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly KEPGBJPOLGH HKIDPPJCHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly PKCGAFNPDHM EBKAHKJLFGJ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int GCEHEIAFKEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F64640", Offset = "0x6F63240", VA = "0x186F64640", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public NBMPOJDPANG CGNJMDHBEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime HPDIKBDEBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KEPGBJPOLGH? FCMBGFNONIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F64810", Offset = "0x6F63410", VA = "0x186F64810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public PKCGAFNPDHM? OKNJEAMNHEM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F64B20", Offset = "0x6F63720", VA = "0x186F64B20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JMNJNKJKGGK HJAGADOKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "10")]
			get
			{
				return default(JMNJNKJKGGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10C28A0", Offset = "0x10C14A0", VA = "0x1810C28A0")]
		public LEKBJPAEOJI(NBMPOJDPANG LKEJDPIGMBC, KEPGBJPOLGH MMKLPDAGIHD, PKCGAFNPDHM MJNIIFDMKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F64660", Offset = "0x6F63260", VA = "0x186F64660", Slot = "9")]
		[AsyncStateMachine(typeof(FOBLHAMJDEP))]
		public Task<FBOKJACJPGA> BHICPPJIKLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F64860", Offset = "0x6F63460", VA = "0x186F64860", Slot = "11")]
		public bool Equals(HMKCGONNNPH OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F64970", Offset = "0x6F63570", VA = "0x186F64970", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F64A90", Offset = "0x6F63690", VA = "0x186F64A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F64730", Offset = "0x6F63330", VA = "0x186F64730")]
		private bool COIKLEOOMML(LEKBJPAEOJI OCNJFCPHJLD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct ICLANKHAEEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<HMKCGONNNPH>> <>t__builder;

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
		public GLGDMFBEGMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<LKAHMCOOOOD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<LKAHMCOOOOD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, NBMPOJDPANG account, LKAHMCOOOOD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F61760", Offset = "0x6F60360", VA = "0x186F61760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F62540", Offset = "0x6F61140", VA = "0x186F62540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MBDFAHIPGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, NBMPOJDPANG account, LKAHMCOOOOD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<LKAHMCOOOOD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public GLGDMFBEGMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<NBMPOJDPANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A840", Offset = "0x6F69440", VA = "0x186F6A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B220", Offset = "0x6F69E20", VA = "0x186F6B220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HHLNJCPAADC FLHIGKLMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NENKBFOMHBE NOFHNJECKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BABBLJBEOLE NCLMCGDAFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JGOEDLBJKBP<(long, long), IReadOnlyList<LKAHMCOOOOD>> LKLKGCJMFOE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AF00", Offset = "0x6F59B00", VA = "0x186F5AF00")]
	[UnityEngine.Scripting.Preserve]
	public GLGDMFBEGMN([GOICEJLKLIB(null)] NENKBFOMHBE IEMPAGPBFIP, [GOICEJLKLIB(null)] BABBLJBEOLE ONDNEOLBINN, [GOICEJLKLIB(null)] HHLNJCPAADC EDHAMKMHPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ADB0", Offset = "0x6F599B0", VA = "0x186F5ADB0")]
	[AsyncStateMachine(typeof(ICLANKHAEEE))]
	public Task<IList<HMKCGONNNPH>> PPOEDPJAHOJ(long NBIMAGPPMDN, long JJFCFIMNPNM, bool NKOFBEEKBMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AC10", Offset = "0x6F59810", VA = "0x186F5AC10")]
	private bool HAJAADMOMGL(DateTime? NBHGOILHJHN, long NBIMAGPPMDN, long JJFCFIMNPNM, [Out] ACFFOKBAEJM GHJLANOPNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AB00", Offset = "0x6F59700", VA = "0x186F5AB00")]
	[AsyncStateMachine(typeof(MBDFAHIPGPP))]
	private Task<IReadOnlyList<(int, NBMPOJDPANG, LKAHMCOOOOD)>> CDILKKEGKAE(IReadOnlyList<LKAHMCOOOOD> NEMGHIIGIHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BABBLJBEOLE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ACFFOKBAEJM> JNMNADIBEPC;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DCCFGDGLDIJ(long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP, CMFFNFFAOGL IELBOLKNNGD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FBLJGDLBDEL(long NBIMAGPPMDN, long JJFCFIMNPNM, [Out] ACFFOKBAEJM GHJLANOPNOI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OHFILDFJHPA(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, [Out] ACFFOKBAEJM GHJLANOPNOI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJFIMHKJJND(long NBIMAGPPMDN, long JJFCFIMNPNM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface NKKOEDLBBOE : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CAFKBMGOLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task EJMLKFDKMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFDLFEPGJEN(Task HPIAAAJAFJD, string CPPFNFCIDKI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface CCJDJLDLLLH : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBOKJACJPGA> MLKKGILDFLH(ACFFOKBAEJM GHJLANOPNOI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task POCLCNKGNJP(CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface GEBOBJKGBAO : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PJJBGFJNFKD DNPGEDNJBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPACCOMCGBA();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMMLFCBIAMD();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface ENGDOEDMANK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface CGAIKOHGGAK
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan EBJJMNFCGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan HCKAGPPJAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan EEOMINPOBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan CFHHPNPIBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NCIPBEMMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BHGGDKAFAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool AFDIKDKIEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int ICLBCDHNAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OBBBPIMCGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool CBGBPFKBEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EKJCOHHLGJO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NJEMEGLNDCA
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
public struct IHIJMGLMGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long KLANBOMCCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long INCOHCKKKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly EKJCOHHLGJO NCNNODEFPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception BFLHCOCEJPF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F62D60", Offset = "0x6F61960", VA = "0x186F62D60")]
	public IHIJMGLMGDF(long KLANBOMCCPE, long INCOHCKKKJD, EKJCOHHLGJO NCNNODEFPOG, [CanBeNull] Exception BFLHCOCEJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F62D10", Offset = "0x6F61910", VA = "0x186F62D10")]
	public static IHIJMGLMGDF EBEAKPKNDNN(NJAGFBDJADF NBBIEGKGBPO, EKJCOHHLGJO NCNNODEFPOG, [Optional] Exception BFLHCOCEJPF)
	{
		return default(IHIJMGLMGDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void EKINIBMLBML(IHIJMGLMGDF KNHDFBPPOPP);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface EHLAOHFBEMB : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPNNOJFANBF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EKINIBMLBML KDAJMEECIGN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EKINIBMLBML MKKGIFALAGB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event EKINIBMLBML MMFLMIOGIFH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NJEMEGLNDCA, bool> PCDJOAIOHAG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MNKKJHHIGAH();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FIDGJMDHPMD(IHIJMGLMGDF KNHDFBPPOPP);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HHGHHDAMMKJ(IHIJMGLMGDF KNHDFBPPOPP);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AMJNDDOFFKJ(IHIJMGLMGDF KNHDFBPPOPP);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OAONNLOMPIK(NJEMEGLNDCA NMCAEILPPGB, bool BCJBOMDKMCM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface EIGIHAALGDO : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MGJCAIKHEOD();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGHAJJCKKHB();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface HHMHLOLAALF : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus CIPALLBMODC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OAJCCMIAHGC(NJAGFBDJADF NKIDIMEMAPM, INPBHLHJDLM BFLCGAFNDHD, CancellationToken DDPMOBGAIPN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class PFGPAPMMGKP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FB20", Offset = "0x6F6E720", VA = "0x186F6FB20")]
	public static bool JJLFPAOBOAE(this HHMHLOLAALF FJHKIFNHLKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task LJCGOJOAMKH(OJAAINJGBPM AFAEGADIMPI, CancellationToken FGIAGALCIAP);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface OOMOCPAFIDB : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GOGLPBGFLIM(LJCGOJOAMKH CLJGADJHLJB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface OFPJPDGOKAO : OLLALIAMOOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken MGELIEPGELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	LLIMAHMFNLB AKMPFPHGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	OLMJDLMENAB MDINEJNMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FNAIHKNMEOK PMEGMPMPIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KCCKNNHBECO PPHPFJNLBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NOODJHPBGLM OKFCGOIDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HEKMMDDDNMH KFHPNFOHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EKDPFEKGPHI HNPDNHOJMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NKKOEDLBBOE KFKKHFINJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CCJDJLDLLLH PJKMBEIGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EHLAOHFBEMB OGFPGNAMAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EIGIHAALGDO NMPDFCCPEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HHMHLOLAALF KDKNNMJLCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OOMOCPAFIDB LAGMFFHCNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PPGGJDMBENK DEONNIGDAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FLNIOLEOHOE HGNPLPNCIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KFIGEBLHPLP CHLOPBEDNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DGHCKMAOINP PGHHDADOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AHFOCMCIPNL JBNBGAAAMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GFBHEMMFJBJ IFBJAFBOKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	GGKMOCOEPGF FCDAFJDCONL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LOBIOOMAFIE DCDAOBPBILL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DDANMONPAOD CDEFFNNCNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EPMEMOKNIAL KFJIGMAPFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GEBOBJKGBAO JNAKLANOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CGAIKOHGGAK MLPCAPIFKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MPEADMLIKDP LONBDGJLNBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BABBLJBEOLE ICJJGDBDBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	OEPHDHCALJN FJOEKECGDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MMAPHKALPKN LCFMLKBOFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NJPLNDPCKFC DGBEFGIGDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HHFFHJDJJLH(INPBHLHJDLM EGEGMPHEGCL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PPGGJDMBENK : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBOPPMJPNHG MPFJKDGCCNN(Guid AMMGFMLLGCP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IFPALOLJLCH(Guid AMMGFMLLGCP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NBNIEGEBCMN(Guid AMMGFMLLGCP, Task OHDJMABKDIB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LJMDAHFNMML(Guid AMMGFMLLGCP, FBOKJACJPGA DBFIDJCOEKE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(FBOKJACJPGA, Task)> OMOIPHHIDHF(Guid AMMGFMLLGCP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DLHJFCMGOPO : ENGDOEDMANK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FLNIOLEOHOE : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKODEGJOABB(FNFHONNECCC JIMAFLGJGFB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIMECCJCAJJ(FNFHONNECCC JIMAFLGJGFB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OPMNPHPPHHM> LDIMIAKLCAO(CancellationToken BAHONPMJFLD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KFIGEBLHPLP : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBOPPMJPNHG DOINCHPNFMB(FNFHONNECCC OGHJFBDDMAE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEDMCIJNPOM(Guid AMMGFMLLGCP, Task OHDJMABKDIB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface DGHCKMAOINP : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBOKJACJPGA> PGHHDADOKHA(FNFHONNECCC KPBJIJCEDMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface AHFOCMCIPNL : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDHGEAOPLAO> ADKMGFKMPOC(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, NJAGFBDJADF NKIDIMEMAPM, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GGKMOCOEPGF : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBOKJACJPGA EMOPAPOHMNE(OICKONADKGK LCJNNBFNDML);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KLGHDDIJBDC(string OMBOFKDENLD);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GFBHEMMFJBJ : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNFHONNECCC> DAGLDIPPNDO(FNFHONNECCC CLBGLGJCBEB, HLIBNFHHDHM GDJHHHLGCMJ, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FNFHONNECCC> GIIOGBAKOFG(CancellationToken MPLCHGMFENA, HLIBNFHHDHM GDJHHHLGCMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EFLENNBPCOG KEJMAADGGEM(FCIIDNJEMOA BKMAKKDNDCB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFLENNBPCOG HFIHBKHKBCP(FCIIDNJEMOA BKMAKKDNDCB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface LOBIOOMAFIE : ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBOKJACJPGA EPMMKKIKABD(OICKONADKGK LCJNNBFNDML, OPMNPHPPHHM CMMGCBACION);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FBOKJACJPGA LGLANGHPLOE(OICKONADKGK CEFAKBLLGJL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DDANMONPAOD
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONNIHNJLDFE(OHGDKBMNKCK CCEDMDEGFDC);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHMCEPEPHHF(OHGDKBMNKCK CCEDMDEGFDC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHCMFNDPCLH(OHGDKBMNKCK CCEDMDEGFDC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOPOIBCMFNI(OHGDKBMNKCK CCEDMDEGFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class OHGDKBMNKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly NJAGFBDJADF BEFJEIOOFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> FMCJMAOKNFB;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public GDCBCFBEPNI<string> PGDFEAKGMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public OHGDKBMNKCK(NJAGFBDJADF MDFMBBLPOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F440", Offset = "0x6F6E040", VA = "0x186F6F440")]
	public OHGDKBMNKCK GAPOBGMOABG(string DPHIOKCFMFC, string GLMEMJNJKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F510", Offset = "0x6F6E110", VA = "0x186F6F510")]
	public bool NGMPKBDCCAO([Out] IEnumerable<KeyValuePair<string, string>> JFPLBOMHHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61DEE50", Offset = "0x61DDA50", VA = "0x1861DEE50")]
	public OHGDKBMNKCK FIDDFGEKAHK(GDCBCFBEPNI<string> JKELFCJBEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MPEADMLIKDP
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HDFDEBFIBNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string OCCIOFAAOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool IBHCGMBDPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPJLBBCNCNL();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HPDICFEPHIM JBFPILDHDFB(long NFDNNKBLGNC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JHIOGODAFCO<CDMECJMNEDA, GLNEPJPIIDC> INJEOBBFENN(long NFDNNKBLGNC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JHIOGODAFCO<CDMECJMNEDA, HLKJAJHEMPF> BPBFJIIGHIB(long NFDNNKBLGNC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JHIOGODAFCO<long, JPNINDOKGHL> JJLDGMOIGFI();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GCEHCHGHDKB(long NFDNNKBLGNC, [Out] bool KALPPDGMMNA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> JGBEBOJMELN(byte[] MAOEPJEIFFB, byte[] BGJLGIFMFBL, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OLLALIAMOOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JJLFPAOBOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CBPNBADEHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	INPBHLHJDLM KOEIGOFLGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HPNNOJFANBF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EKINIBMLBML KDAJMEECIGN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EKINIBMLBML MKKGIFALAGB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EKINIBMLBML MMFLMIOGIFH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NJEMEGLNDCA, bool> PCDJOAIOHAG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NGHAJJCKKHB();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GBMBGDIFJMB LNGFMJOECNJ();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OCGDIHMGNJL JIIGNKKNOJH();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<FBOKJACJPGA> MLKKGILDFLH(ACFFOKBAEJM EICCBKKAPGP);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task POCLCNKGNJP(CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KCCKNNHBECO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PFDBNCPCGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string CDOHJFDGJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPKCBCEEKLA(Scene KNLKIFLKNBN);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CBNLAGJLFAL(HNGBNMNFADC LLDCLHKKHDB, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BBGHMIFNNPA();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FIOCLCPFJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AOEEFONAKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OLBMHJDBJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool AINHFOJFKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool CJHDHBHALIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int JPFNGFHKDBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NAJFNJNAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GJEJBNMPLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	byte MCFCKNGBCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte MIONJBPACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OMNMJLCJHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool FOCHFHPOBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool GCNDNCOGPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float PJLEMMAKKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> ENKNCMGILPK;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLIMAHMFNLB HOFJCBOFBFJ(LLIMAHMFNLB DAIMANBCFHH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAFAHKCPCNE(LLIMAHMFNLB INBELNINGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCHCOOKOEAC();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PJOGJMBPLBH(GDCBCFBEPNI<string>.LHHFCPKIPMG FIEPGIFKCIL, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PHIMJHEHHFD(float PGLOENKNCGK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGBHAHBNJMD(string JBIDNLKKEEM);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<KJBJBMMKEPB> ELHKDCBIEIG();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FHHPFABBMOL(object FBMKGECLCCA, KJBJBMMKEPB KFDNNGDEPJB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<INGJGIGNBDA> LDLFCNFDENE();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GLNEPJPIIDC ENGDJHAKPOO(IEnumerable<CBEKBKNFPHF> MICHEJOPHCB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHBPIPJDDPK(int FMEADDKOFED);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task ANFGOIBKEKP();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HAFMJMLGILP();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NKDEDDLNKJM();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task HDJFLJIGLBC(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task BFGAAAPFFDF(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<MKHFJFNOGEK> JIMLJOMLFEO(DateTime AEPEMBEJKFC, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> JNOJKCOKPAG(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CEJECHFJPJB(string JIMAFLGJGFB = "", float HOHIHOOEIIK = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BPICFALBJEJ MKINEOJDCOK(IBBGFNFNCJB BBNCOKIIPON, JCDEPKEOHOP BEPMGJBLFDD, HLKJAJHEMPF NHJJMDKNLKM, IEnumerable<PersistenceView> MNFLJMFHMPG, GKMJDNLGPCN PHAJKLEPNGI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PANOCEDBGCJ(HLKJAJHEMPF NHJJMDKNLKM);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PACOMADPJJB(CBEKBKNFPHF PDLNDIJBMLD, [In] BPICFALBJEJ NKIPHOKBIHN);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task NMJCANLGFOL(HLKJAJHEMPF FACDJHONIBI, bool MHGNNPHOCCN, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task NAMJJDOFHOK(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GPMOAEDJEDH(long NBIMAGPPMDN, long INCOHCKKKJD, FMLBFFJHFNC CCLGPLKGAAA, LKAHMCOOOOD DECKCIPLFIO, CCHFEGBILNH BOAMNEMIAIP, JLMHDEAJDIF? EHAFNJGCMAN, GNEKNEMHKHJ? BCOFBHAJHGL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EGAAOMGFIBO(long NBIMAGPPMDN, long INCOHCKKKJD, GNEKNEMHKHJ? BCOFBHAJHGL);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HELDEJFLKGK(PersistenceView CPEFLFNMPBG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool IACDNBMAEEN(PersistenceView DGNNOOCHGJF);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool GGBIELEKDEA(CBEKBKNFPHF PDLNDIJBMLD, NKGKLFPECPE FDNENODPALI, [Out] PGPKEBEONOP FKLGAEPIIHG);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task HIFKJNJAMEG(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HFFNNDDPFFL();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable CFBKBEAIFBK();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JOGAMIHGPEK(HLKJAJHEMPF FACDJHONIBI, NKGKLFPECPE FDNENODPALI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> HEGEDELMPPE(OLMJDLMENAB MPCOPBMLEML, CancellationToken MPLCHGMFENA, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NKNEBHCKKPA(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<DCMHOOJOMED> KCHJKELGLNJ(IGMFIHHKIAO CLBGLGJCBEB);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FMLBFFJHFNC> DACALJBANMA(long NBIMAGPPMDN, bool POOLGPLOAOH, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<LKAHMCOOOOD> KMBPCLGLNJO(long NBIMAGPPMDN, long INCOHCKKKJD, long DHBGHDMOAKP, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<BHFAHGDBGIJ> IHCIJMLFCPO(string GJGCIINBOKC, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<BHFAHGDBGIJ> EJEAIBNFFHA(string GJGCIINBOKC, long NBIMAGPPMDN, long INCOHCKKKJD, string MBBLLBHFMBP, LLKKKNBFDIC.FJIIBMKKKPE AFAEGADIMPI, LLKKKNBFDIC.FJIIBMKKKPE BGJLGIFMFBL, int JIILLLIPEFM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool GBLDBPFJMEH();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool MCHHECNLDPA();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool GFHDFNFLHFC(IEnumerable<PGPKEBEONOP> NDPJJCLNHGK);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void NIIKIBFKEOO(List<GameObject> INJNONKFIIA);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float GBMKLMCOKGP();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task<Scene> DAENLAIKMLG(string MFFICODDPIK, LoadSceneMode LKIFFIAHJFM, bool OOEMFHLLBED, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void EDGOEKPALHE();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void MIFLNAOOHMB(bool MPKDEMAOPIG);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void ILBDKOGIJCB();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void PFMIJEJAJII();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void EBCKBGPAFKL(NJAGFBDJADF FAFCMLOAFLH);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "67")]
	Task CFDGGLAKGKH(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task NMKFLJOFIGL(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task ILDLEPHMBEG(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task LHOJONDPJGB(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "71")]
	IDisposable PNPGFCJODIH();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IOAMDEPLAHB NAHDCCBKAGC();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task JFEHOOIJBDM(CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IOAMDEPLAHB
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DLMMHOJGAIP(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PCHCIAHDMGB(CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BPICFALBJEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> GOPFGHPBAKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum MKHFJFNOGEK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IBBGFNFNCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EGFDDAOCKAE;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NBOBHFDODPM
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	NJAGFBDJADF CGJCNHFJBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	FMLBFFJHFNC KNFJGCKIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	LIFOCOCGCNJ EIJKMNABOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool JHFKKJGHCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool AGHAPADLDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int BBLNPMLBCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IELEHGHOIAB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> AEJAFNLFPCM;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EMOANEBENHO();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.OLHDHKBAENG> GMEDOJEBDIG(long NFDNNKBLGNC, [Optional] CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CIJGMIOBMEG> JLNEGAGOFED();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NMNGPBPEJBK();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(NJAGFBDJADF, INPBHLHJDLM) OHEDLFKHPFA();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BEMAMOPOJJM PDJGHGJIBEK();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OLHGGNPHLFC(long NFDNNKBLGNC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EPMEMOKNIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELGFFNFMLKA([Out] IEnumerable<int> LGELDBMKCIC);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKLIPLJPBAC(FNLKKHGONOA FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POEKGCBNAFD(FNLKKHGONOA FGIAGALCIAP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KGFHBGMHNJI
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LBCGFOJKLHE(FBOKJACJPGA DGJONDHJOCP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KOHMEEHKFGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLONOMDEOFH(PDACHDGJNIK.LJHNIOEDDPI GMOKCBKFBAB);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCPEMPKGENE(PDACHDGJNIK.LJHNIOEDDPI GMOKCBKFBAB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NOODJHPBGLM : KOHMEEHKFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBOKJACJPGA GDIDJNPJEDP(OICKONADKGK CEFAKBLLGJL);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HEKMMDDDNMH : KOHMEEHKFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBOKJACJPGA EMOPAPOHMNE(OICKONADKGK COEGBGMLNEL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HPDICFEPHIM
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GFFELLBKJIA<HNGBNMNFADC, DICIKJENGEG>> IPHEPPFKPDC(string MBBLLBHFMBP, long NFDNNKBLGNC, long? NBIMAGPPMDN, long? INCOHCKKKJD, OFIOGMLKIJG.LHMCOONGCON IMLEDIADGDH, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface JHIOGODAFCO<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GFFELLBKJIA<IDCLJKNKGLH<TData>, DICIKJENGEG>> KHPBOBLGGFM(TGetDataArg KDGMEPEFEJC, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class ILGEFGBOJCK : OFPJPDGOKAO, OLLALIAMOOG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct DIEJBFJCKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ILGEFGBOJCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ACFFOKBAEJM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<FBOKJACJPGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F56680", Offset = "0x6F55280", VA = "0x186F56680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F56900", Offset = "0x6F55500", VA = "0x186F56900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct BPGNLEILAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public ILGEFGBOJCK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F55860", Offset = "0x6F54460", VA = "0x186F55860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F55A90", Offset = "0x6F54690", VA = "0x186F55A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FKEFFKFHIMN : IEnumerable<ENGDOEDMANK>, IEnumerable, IEnumerator<ENGDOEDMANK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ENGDOEDMANK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public ILGEFGBOJCK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		private ENGDOEDMANK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public FKEFFKFHIMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F59C10", Offset = "0x6F58810", VA = "0x186F59C10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A070", Offset = "0x6F58C70", VA = "0x186F5A070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F59FC0", Offset = "0x6F58BC0", VA = "0x186F59FC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENGDOEDMANK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F59FC0", Offset = "0x6F58BC0", VA = "0x186F59FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource HLOCGIAOMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LLIMAHMFNLB INBELNINGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool NGFFCCFEDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private HDGEFNCGGGB KBGKGILPPMB;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public OLMJDLMENAB MDINEJNMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x843390", Offset = "0x841F90", VA = "0x180843390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FNAIHKNMEOK PMEGMPMPIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x843340", Offset = "0x841F40", VA = "0x180843340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x843360", Offset = "0x841F60", VA = "0x180843360", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8434C0", Offset = "0x8420C0", VA = "0x1808434C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KCCKNNHBECO PPHPFJNLBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x848BE0", Offset = "0x8477E0", VA = "0x180848BE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x848BF0", Offset = "0x8477F0", VA = "0x180848BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NOODJHPBGLM OKFCGOIDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8432E0", Offset = "0x841EE0", VA = "0x1808432E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8434F0", Offset = "0x8420F0", VA = "0x1808434F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HEKMMDDDNMH KFHPNFOHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8431C0", Offset = "0x841DC0", VA = "0x1808431C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x843380", Offset = "0x841F80", VA = "0x180843380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public EKDPFEKGPHI HNPDNHOJMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850100", VA = "0x180851500", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8500A0", VA = "0x1808514A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public NKKOEDLBBOE KFKKHFINJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8501F0", VA = "0x1808515F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x851580", Offset = "0x850180", VA = "0x180851580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CCJDJLDLLLH PJKMBEIGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8514C0", Offset = "0x8500C0", VA = "0x1808514C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x851530", Offset = "0x850130", VA = "0x180851530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EHLAOHFBEMB OGFPGNAMAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA59020", Offset = "0xA57C20", VA = "0x180A59020", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xACE080", Offset = "0xACCC80", VA = "0x180ACE080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public EIGIHAALGDO NMPDFCCPEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8515A0", Offset = "0x8501A0", VA = "0x1808515A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x851550", Offset = "0x850150", VA = "0x180851550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public HHMHLOLAALF KDKNNMJLCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AEDE0", VA = "0x1809B01E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9B0300", Offset = "0x9AEF00", VA = "0x1809B0300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OOMOCPAFIDB LAGMFFHCNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x850760", Offset = "0x84F360", VA = "0x180850760", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x850740", Offset = "0x84F340", VA = "0x180850740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public PPGGJDMBENK DEONNIGDAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xB796A0", Offset = "0xB782A0", VA = "0x180B796A0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB81680", Offset = "0xB80280", VA = "0x180B81680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DLHJFCMGOPO OIJKOPBEMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x935CC0", Offset = "0x9348C0", VA = "0x180935CC0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x92F810", Offset = "0x92E410", VA = "0x18092F810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FLNIOLEOHOE HGNPLPNCIED
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x935460", Offset = "0x934060", VA = "0x180935460", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x936A00", Offset = "0x935600", VA = "0x180936A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public KFIGEBLHPLP CHLOPBEDNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A40", Offset = "0x8AF640", VA = "0x1808B0A40", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB816C0", Offset = "0xB802C0", VA = "0x180B816C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DGHCKMAOINP PGHHDADOKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A60", Offset = "0x8B2660", VA = "0x1808B3A60", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA90", Offset = "0xA0C690", VA = "0x180A0DA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public AHFOCMCIPNL JBNBGAAAMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x850730", Offset = "0x84F330", VA = "0x180850730", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x850790", Offset = "0x84F390", VA = "0x180850790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public GFBHEMMFJBJ IFBJAFBOKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B37D0", Offset = "0x8B23D0", VA = "0x1808B37D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9B3720", Offset = "0x9B2320", VA = "0x1809B3720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GGKMOCOEPGF FCDAFJDCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1E0", Offset = "0xA38DE0", VA = "0x180A3A1E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1B0", Offset = "0xA38DB0", VA = "0x180A3A1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public LOBIOOMAFIE DCDAOBPBILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A80", Offset = "0x8B2680", VA = "0x1808B3A80", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xB816A0", Offset = "0xB802A0", VA = "0x180B816A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public DDANMONPAOD CDEFFNNCNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A90", Offset = "0x8B2690", VA = "0x1808B3A90", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9B5750", Offset = "0x9B4350", VA = "0x1809B5750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EPMEMOKNIAL KFJIGMAPFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8B39E0", Offset = "0x8B25E0", VA = "0x1808B39E0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xB81660", Offset = "0xB80260", VA = "0x180B81660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GEBOBJKGBAO JNAKLANOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8B39F0", Offset = "0x8B25F0", VA = "0x1808B39F0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB818A0", Offset = "0xB804A0", VA = "0x180B818A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CGAIKOHGGAK MLPCAPIFKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8B38C0", Offset = "0x8B24C0", VA = "0x1808B38C0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB81860", Offset = "0xB80460", VA = "0x180B81860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public MPEADMLIKDP LONBDGJLNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8B3890", Offset = "0x8B2490", VA = "0x1808B3890", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xB817E0", Offset = "0xB803E0", VA = "0x180B817E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public BABBLJBEOLE ICJJGDBDBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8B37F0", Offset = "0x8B23F0", VA = "0x1808B37F0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public OEPHDHCALJN FJOEKECGDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAE5C50", Offset = "0xAE4850", VA = "0x180AE5C50", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public MMAPHKALPKN LCFMLKBOFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8B3A70", Offset = "0x8B2670", VA = "0x1808B3A70", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public NJPLNDPCKFC DGBEFGIGDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA4C450", Offset = "0xA4B050", VA = "0x180A4C450", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public INPBHLHJDLM KOEIGOFLGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAE4140", Offset = "0xAE2D40", VA = "0x180AE4140", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB81800", Offset = "0xB80400", VA = "0x180B81800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private bool AJJDPLIABLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F63610", Offset = "0x6F62210", VA = "0x186F63610", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool DELAILMJEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F63810", Offset = "0x6F62410", VA = "0x186F63810", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private CancellationToken GDEBJBBLJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F63450", Offset = "0x6F62050", VA = "0x186F63450", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private LLIMAHMFNLB CNCJMDMJIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action NPENDEGMAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6F62DE0", Offset = "0x6F619E0", VA = "0x186F62DE0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6F63390", Offset = "0x6F61F90", VA = "0x186F63390", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event EKINIBMLBML PPKJGBPLKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6F63190", Offset = "0x6F61D90", VA = "0x186F63190", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6F62F30", Offset = "0x6F61B30", VA = "0x186F62F30", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event EKINIBMLBML AEJFEIBEDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F63670", Offset = "0x6F62270", VA = "0x186F63670", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F637B0", Offset = "0x6F623B0", VA = "0x186F637B0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event EKINIBMLBML JMNDCEDNHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F63330", Offset = "0x6F61F30", VA = "0x186F63330", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F633F0", Offset = "0x6F61FF0", VA = "0x186F633F0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<NJEMEGLNDCA, bool> CDKLCPDDBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F62F90", Offset = "0x6F61B90", VA = "0x186F62F90", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F63750", Offset = "0x6F62350", VA = "0x186F63750", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xB81800", Offset = "0xB80400", VA = "0x180B81800", Slot = "36")]
	public void HHFFHJDJJLH(INPBHLHJDLM EGEGMPHEGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6F638E0", Offset = "0x6F624E0", VA = "0x186F638E0")]
	[UnityEngine.Scripting.Preserve]
	internal ILGEFGBOJCK([GOICEJLKLIB(null)] LLIMAHMFNLB INBELNINGBJ, [GOICEJLKLIB(null)] OLMJDLMENAB MPCOPBMLEML, [GOICEJLKLIB(null)] FNAIHKNMEOK MFGENMNCHPI, [GOICEJLKLIB(null)] FIOCLCPFJCF KHAIJLCNIAO, [GOICEJLKLIB(null)] KCCKNNHBECO JNAKOIFHIBI, [GOICEJLKLIB(null)] NOODJHPBGLM KBJHEDFJLKG, [GOICEJLKLIB(null)] HEKMMDDDNMH MLGHDAPNFDI, [GOICEJLKLIB(null)] EKDPFEKGPHI LGNFDEGCNNE, [GOICEJLKLIB(null)] NKKOEDLBBOE OHHJLPAJNEA, [GOICEJLKLIB(null)] CCJDJLDLLLH JGNHKOHOHML, [GOICEJLKLIB(null)] EHLAOHFBEMB NMIGDBGJOPJ, [GOICEJLKLIB(null)] EIGIHAALGDO PDPGFDGAIPM, [GOICEJLKLIB(null)] HHMHLOLAALF FJHKIFNHLKN, [GOICEJLKLIB(null)] OOMOCPAFIDB NMLIMFPJBDH, [GOICEJLKLIB(null)] PPGGJDMBENK BAGHCONHMMF, [GOICEJLKLIB(null)] DLHJFCMGOPO OKENLJBJLCK, [GOICEJLKLIB(null)] FLNIOLEOHOE BIOKBOJFKHC, [GOICEJLKLIB(null)] KFIGEBLHPLP JHMLJJENHEF, [GOICEJLKLIB(null)] DGHCKMAOINP MGBFAMJJLNK, [GOICEJLKLIB(null)] AHFOCMCIPNL AGHBNMONMOG, [GOICEJLKLIB(null)] GGKMOCOEPGF KMFIAJEJIGO, [GOICEJLKLIB(null)] GFBHEMMFJBJ NCHHCKCMMHA, [GOICEJLKLIB(null)] LOBIOOMAFIE NJIMNCDGLKO, [GOICEJLKLIB(null)] DDANMONPAOD EFBKICJPFHE, [GOICEJLKLIB(null)] EPMEMOKNIAL MKGCPLOGFBJ, [GOICEJLKLIB(null)] CGAIKOHGGAK BPPGADPMEGH, [GOICEJLKLIB(null)] MPEADMLIKDP GHJGBHJKOGJ, [GOICEJLKLIB(null)] BABBLJBEOLE NHHIELAHPDI, [GOICEJLKLIB(null)] OEPHDHCALJN DLPILNPPHMP, [GOICEJLKLIB(null)] MMAPHKALPKN KCIOKMJKIML, [GOICEJLKLIB(null)] NJPLNDPCKFC CLACCFGBLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F631F0", Offset = "0x6F61DF0", VA = "0x186F631F0")]
	private void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F62FF0", Offset = "0x6F61BF0", VA = "0x186F62FF0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F63890", Offset = "0x6F62490", VA = "0x186F63890", Slot = "49")]
	private void PJOOLHDDKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F63580", Offset = "0x6F62180", VA = "0x186F63580", Slot = "50")]
	private GBMBGDIFJMB IPLPKIKDKDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6F632A0", Offset = "0x6F61EA0", VA = "0x186F632A0", Slot = "51")]
	private OCGDIHMGNJL EKBDLGOOEPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6F63470", Offset = "0x6F62070", VA = "0x186F63470", Slot = "52")]
	[AsyncStateMachine(typeof(DIEJBFJCKBK))]
	private Task<FBOKJACJPGA> IMAAKFFBELO(ACFFOKBAEJM GHJLANOPNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F62E40", Offset = "0x6F61A40", VA = "0x186F62E40", Slot = "53")]
	[AsyncStateMachine(typeof(BPGNLEILAHH))]
	private Task CEABHJLOCGN(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6F636D0", Offset = "0x6F622D0", VA = "0x186F636D0")]
	[IteratorStateMachine(typeof(FKEFFKFHIMN))]
	private IEnumerable<ENGDOEDMANK> MFLGCMIGNDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F62D80", Offset = "0x6F61980", VA = "0x186F62D80")]
	[CompilerGenerated]
	private void ADELELFDBGH(ENGDOEDMANK KDODEFMCLKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ADNKHHNCHKM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0xEDCE00", Offset = "0xEDBA00", VA = "0x180EDCE00")]
	public ADNKHHNCHKM(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class DCICFCEODID : HGDLEIAFABH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct FDPEDGKBODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public DCICFCEODID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F59860", Offset = "0x6F58460", VA = "0x186F59860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F59BA0", Offset = "0x6F587A0", VA = "0x186F59BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public DCICFCEODID(OFPJPDGOKAO CAFBHCAHEEK, FIOCLCPFJCF KHAIJLCNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F562E0", Offset = "0x6F54EE0", VA = "0x186F562E0", Slot = "4")]
	[AsyncStateMachine(typeof(FDPEDGKBODP))]
	public Task<bool> FGDOCLFDCAN(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F563D0", Offset = "0x6F54FD0", VA = "0x186F563D0")]
	[CompilerGenerated]
	private object JIGHEKCHFNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class POALNJDILME : HGDLEIAFABH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct BKCDDJEBDCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public POALNJDILME <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F53A40", Offset = "0x6F52640", VA = "0x186F53A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F54150", Offset = "0x6F52D50", VA = "0x186F54150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FBE0", Offset = "0x6F6E7E0", VA = "0x186F6FBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public POALNJDILME(OFPJPDGOKAO CAFBHCAHEEK, FIOCLCPFJCF KHAIJLCNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FD10", Offset = "0x6F6E910", VA = "0x186F6FD10", Slot = "4")]
	[AsyncStateMachine(typeof(BKCDDJEBDCA))]
	public Task<bool> FGDOCLFDCAN(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FC30", Offset = "0x6F6E830", VA = "0x186F6FC30")]
	[CompilerGenerated]
	private object CHNHNNEJFJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class ADFJKDHJEEH : HGDLEIAFABH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JJBEKEGMFMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ADFJKDHJEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CIJGMIOBMEG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public NJAGFBDJADF newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JJBEKEGMFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F64120", Offset = "0x6F62D20", VA = "0x186F64120")]
		internal object ICKNNKOAEPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F642B0", Offset = "0x6F62EB0", VA = "0x186F642B0")]
		internal object OHONFEPLLMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F64210", Offset = "0x6F62E10", VA = "0x186F64210")]
		internal object KMCHHGDFBOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct ODDMFBADDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public ADFJKDHJEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private JJBEKEGMFMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<CIJGMIOBMEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EAA0", Offset = "0x6F6D6A0", VA = "0x186F6EAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F3D0", Offset = "0x6F6DFD0", VA = "0x186F6F3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F51D10", Offset = "0x6F50910", VA = "0x186F51D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public ADFJKDHJEEH(OFPJPDGOKAO CAFBHCAHEEK, FIOCLCPFJCF KHAIJLCNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F51D60", Offset = "0x6F50960", VA = "0x186F51D60", Slot = "4")]
	[AsyncStateMachine(typeof(ODDMFBADDOE))]
	public Task<bool> FGDOCLFDCAN(CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface HGDLEIAFABH
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> FGDOCLFDCAN(CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct HEJEPLFCGFF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MBKKOPFJPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public OFPJPDGOKAO manager;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MBKKOPFJPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B290", Offset = "0x6F69E90", VA = "0x186F6B290")]
		internal Task PMKMHNAJDEG(OJAAINJGBPM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HIGGEFOAHKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HEJEPLFCGFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private ACFFOKBAEJM <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<MKHFJFNOGEK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<FBOKJACJPGA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FC80", Offset = "0x6F5E880", VA = "0x186F5FC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F60210", Offset = "0x6F5EE10", VA = "0x186F60210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HIABIEPFGJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HEJEPLFCGFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F900", Offset = "0x6F5E500", VA = "0x186F5F900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FC20", Offset = "0x6F5E820", VA = "0x186F5FC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken MPLCHGMFENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly OFPJPDGOKAO DJIBBLNPCFA;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private OLMJDLMENAB MDINEJNMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B720", Offset = "0x6F5A320", VA = "0x186F5B720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B6D0", Offset = "0x6F5A2D0", VA = "0x186F5B6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B030", Offset = "0x6F59C30", VA = "0x186F5B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private CCJDJLDLLLH PJKMBEIGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B0B0", Offset = "0x6F59CB0", VA = "0x186F5B0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F90B80", Offset = "0x1F8F780", VA = "0x181F90B80")]
	public HEJEPLFCGFF(CancellationToken MPLCHGMFENA, OFPJPDGOKAO DJIBBLNPCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B510", Offset = "0x6F5A110", VA = "0x186F5B510")]
	public static LJCGOJOAMKH JBBNFAKEAAC(OFPJPDGOKAO DJIBBLNPCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B5C0", Offset = "0x6F5A1C0", VA = "0x186F5B5C0")]
	[AsyncStateMachine(typeof(HIGGEFOAHKB))]
	public Task<bool> JHMLCEABGGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B230", Offset = "0x6F59E30", VA = "0x186F5B230")]
	private bool GEKNCOPCOEB([Out] ACFFOKBAEJM GHJLANOPNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B440", Offset = "0x6F5A040", VA = "0x186F5B440")]
	[AsyncStateMachine(typeof(HIABIEPFGJJ))]
	private Task HNGLBOOCANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B100", Offset = "0x6F59D00", VA = "0x186F5B100")]
	private Task<MKHFJFNOGEK> FEGHPOHBMAM(ACFFOKBAEJM MMMOHMMPAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct NBOPPMJPNHG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly PPGGJDMBENK BAGHCONHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid AMMGFMLLGCP;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Task<(FBOKJACJPGA, Task)> PEBBJOKIENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C720", Offset = "0x6F6B320", VA = "0x186F6C720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x41E2AE0", Offset = "0x41E16E0", VA = "0x1841E2AE0")]
	public NBOPPMJPNHG(PPGGJDMBENK BAGHCONHMMF, Guid AMMGFMLLGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C6D0", Offset = "0x6F6B2D0", VA = "0x186F6C6D0")]
	public TaskAwaiter<(FBOKJACJPGA, Task)> EADJJONFAJP()
	{
		return default(TaskAwaiter<(FBOKJACJPGA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C600", Offset = "0x6F6B200", VA = "0x186F6C600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct JHMDOJBPAIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(FBOKJACJPGA, Task)> EKCEOONMEKO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Task<(FBOKJACJPGA, Task)> PEBBJOKIENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F63DD0", Offset = "0x6F629D0", VA = "0x186F63DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F63F90", Offset = "0x6F62B90", VA = "0x186F63F90")]
	public JHMDOJBPAIM(TimeSpan CJGJFNIPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F63E60", Offset = "0x6F62A60", VA = "0x186F63E60")]
	public void JMHFLIFNEIE(Task OHDJMABKDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F63D40", Offset = "0x6F62940", VA = "0x186F63D40")]
	public void BCPAIBODKPE(FBOKJACJPGA DGJONDHJOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F63E10", Offset = "0x6F62A10", VA = "0x186F63E10")]
	public void IKMAPHLICNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F63F00", Offset = "0x6F62B00", VA = "0x186F63F00")]
	internal void MPEOLANIJBK(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GJGIBOJDNOI
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BPNEJOGGACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public LKAHMCOOOOD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BPNEJOGGACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F55AF0", Offset = "0x6F546F0", VA = "0x186F55AF0")]
		internal bool GPPNHDBPMEI(LIFOCOCGCNJ s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A7F0", Offset = "0x6F593F0", VA = "0x186F5A7F0")]
	public static IDHGEAOPLAO GADNMLFOLLL(long KLANBOMCCPE, long INCOHCKKKJD, string GJGCIINBOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A500", Offset = "0x6F59100", VA = "0x186F5A500")]
	public static IDHGEAOPLAO GADNMLFOLLL(long KLANBOMCCPE, long INCOHCKKKJD, CDMECJMNEDA MAOEPJEIFFB, long DHBGHDMOAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A370", Offset = "0x6F58F70", VA = "0x186F5A370")]
	public static IDHGEAOPLAO GADNMLFOLLL(DCMHOOJOMED KDJPAONIGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A5C0", Offset = "0x6F591C0", VA = "0x186F5A5C0")]
	public static IDHGEAOPLAO GADNMLFOLLL(FMLBFFJHFNC CGHICBHGGIA, LKAHMCOOOOD NCPKFCHHOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A880", Offset = "0x6F59480", VA = "0x186F5A880")]
	public static IDHGEAOPLAO NMAILHMHKCB(this IDHGEAOPLAO FAPAFOGIGGO, FMLBFFJHFNC IOJIDMIHLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A970", Offset = "0x6F59570", VA = "0x186F5A970")]
	public static IDHGEAOPLAO OIKLAOGMAEK(this IDHGEAOPLAO FAPAFOGIGGO, LKAHMCOOOOD NECDMDNALJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class NCOGNKDNLEL : NKKOEDLBBOE, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct APOOGCGFBLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NCOGNKDNLEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F532A0", Offset = "0x6F51EA0", VA = "0x186F532A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F53930", Offset = "0x6F52530", VA = "0x186F53930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly FNLKKHGONOA FBCOOLOBICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string GCPCPFFNALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task LAFLIFFKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool CAFKBMGOLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D690", Offset = "0x6F6C290", VA = "0x186F6D690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task EJMLKFDKMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D6C0", Offset = "0x6F6C2C0", VA = "0x186F6D6C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810", Slot = "7")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D410", Offset = "0x6F6C010", VA = "0x186F6D410", Slot = "6")]
	public void HFDLFEPGJEN(Task HPIAAAJAFJD, string CPPFNFCIDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D570", Offset = "0x6F6C170", VA = "0x186F6D570")]
	[AsyncStateMachine(typeof(APOOGCGFBLL))]
	private Task IDEJOBDDHPN(Task JGOBBFOLLGJ, string CPPFNFCIDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D750", Offset = "0x6F6C350", VA = "0x186F6D750")]
	public NCOGNKDNLEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class NINEKMCOLHP : GEBOBJKGBAO, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool LGHLGCMNBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private PJJBGFJNFKD KBALNMOJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private CGAIKOHGGAK BPPGADPMEGH;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public PJJBGFJNFKD DNPGEDNJBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E4A0", Offset = "0x6F6D0A0", VA = "0x186F6E4A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E0B0", Offset = "0x6F6CCB0", VA = "0x186F6E0B0", Slot = "7")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E230", Offset = "0x6F6CE30", VA = "0x186F6E230", Slot = "5")]
	public void KPACCOMCGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E070", Offset = "0x6F6CC70", VA = "0x186F6E070", Slot = "6")]
	public void CMMLFCBIAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E3E0", Offset = "0x6F6CFE0", VA = "0x186F6E3E0")]
	private Task MBGDEHJNDHL(BJAMEPODHAC KGECOLOELOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E070", Offset = "0x6F6CC70", VA = "0x186F6E070", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NINEKMCOLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class NALLDEBODEH : CGAIKOHGGAK
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class LGPCCADIACH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly PPMGCPLFFBF FCLIIADOKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string DPHIOKCFMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T NJMAFDCOBGL;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public T EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x897580", Offset = "0x896180", VA = "0x180897580")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x99DDA0", Offset = "0x99C9A0", VA = "0x18099DDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x41FDE20", Offset = "0x41FCA20", VA = "0x1841FDE20")]
		public LGPCCADIACH(PPMGCPLFFBF FCLIIADOKAE, string DPHIOKCFMFC, T NJMAFDCOBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x41FDA80", Offset = "0x41FC680", VA = "0x1841FDA80")]
		private void FBHBJHNEEDC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly PPMGCPLFFBF FCLIIADOKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LGPCCADIACH<TimeSpan> FOAFJBENKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly LGPCCADIACH<TimeSpan> GBBOGKGHCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LGPCCADIACH<TimeSpan> DDOHHAHEJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly LGPCCADIACH<TimeSpan> JGDDLNNOMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly LGPCCADIACH<bool> LIIGLKEHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly LGPCCADIACH<bool> IHMCBFCHGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LGPCCADIACH<bool> PKNIMLCADLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly LGPCCADIACH<int> KFLOLHDDENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly LGPCCADIACH<bool> PFAILNKFLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly LGPCCADIACH<bool> EFEHIAPGIHN;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public TimeSpan EBJJMNFCGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BF90", Offset = "0x6F6AB90", VA = "0x186F6BF90", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public TimeSpan HCKAGPPJAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C090", Offset = "0x6F6AC90", VA = "0x186F6C090", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan EEOMINPOBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BF50", Offset = "0x6F6AB50", VA = "0x186F6BF50", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan CFHHPNPIBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C110", Offset = "0x6F6AD10", VA = "0x186F6C110", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool NCIPBEMMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C150", Offset = "0x6F6AD50", VA = "0x186F6C150", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool BHGGDKAFAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C010", Offset = "0x6F6AC10", VA = "0x186F6C010", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool AFDIKDKIEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C0D0", Offset = "0x6F6ACD0", VA = "0x186F6C0D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int ICLBCDHNAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BFD0", Offset = "0x6F6ABD0", VA = "0x186F6BFD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool OBBBPIMCGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BF10", Offset = "0x6F6AB10", VA = "0x186F6BF10", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool CBGBPFKBEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C050", Offset = "0x6F6AC50", VA = "0x186F6C050", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C190", Offset = "0x6F6AD90", VA = "0x186F6C190")]
	[UnityEngine.Scripting.Preserve]
	public NALLDEBODEH([GOICEJLKLIB(null)] PPMGCPLFFBF FCLIIADOKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class EEPBCOKKIAA : EHLAOHFBEMB, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class LFLIEHADHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public IHIJMGLMGDF roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LFLIEHADHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6F65040", Offset = "0x6F63C40", VA = "0x186F65040")]
		internal object DAONOHLFHDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action HPNNOJFANBF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6F57A20", Offset = "0x6F56620", VA = "0x186F57A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6F57B60", Offset = "0x6F56760", VA = "0x186F57B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event EKINIBMLBML KDAJMEECIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F57AC0", Offset = "0x6F566C0", VA = "0x186F57AC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6F57980", Offset = "0x6F56580", VA = "0x186F57980", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event EKINIBMLBML MKKGIFALAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6F57F50", Offset = "0x6F56B50", VA = "0x186F57F50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6F578B0", Offset = "0x6F564B0", VA = "0x186F578B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event EKINIBMLBML MMFLMIOGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6F57DD0", Offset = "0x6F569D0", VA = "0x186F57DD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F582D0", Offset = "0x6F56ED0", VA = "0x186F582D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NJEMEGLNDCA, bool> PCDJOAIOHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6F57EA0", Offset = "0x6F56AA0", VA = "0x186F57EA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6F58020", Offset = "0x6F56C20", VA = "0x186F58020", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "19")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F580D0", Offset = "0x6F56CD0", VA = "0x186F580D0", Slot = "14")]
	public void MNKKJHHIGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F57E70", Offset = "0x6F56A70", VA = "0x186F57E70", Slot = "15")]
	public void FIDGJMDHPMD(IHIJMGLMGDF KNHDFBPPOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F57FF0", Offset = "0x6F56BF0", VA = "0x186F57FF0", Slot = "16")]
	public void HHGHHDAMMKJ(IHIJMGLMGDF KNHDFBPPOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F57950", Offset = "0x6F56550", VA = "0x186F57950", Slot = "17")]
	public void AMJNDDOFFKJ(IHIJMGLMGDF KNHDFBPPOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F58370", Offset = "0x6F56F70", VA = "0x186F58370", Slot = "18")]
	public void OAONNLOMPIK(NJEMEGLNDCA NMCAEILPPGB, bool BCJBOMDKMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F57C00", Offset = "0x6F56800", VA = "0x186F57C00")]
	private void DOBCDLDNJAI(EKINIBMLBML KFDNNGDEPJB, IHIJMGLMGDF KNHDFBPPOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EEPBCOKKIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class DNIGEHBOJIN : EIGIHAALGDO, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct COPHBFOCAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DNIGEHBOJIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F55DA0", Offset = "0x6F549A0", VA = "0x186F55DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6F56280", Offset = "0x6F54E80", VA = "0x186F56280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct POKBONPKPJA : IAsyncStateMachine
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
		public DNIGEHBOJIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FE40", Offset = "0x6F6EA40", VA = "0x186F6FE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6F704A0", Offset = "0x6F6F0A0", VA = "0x186F704A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NGDLBCOAAJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NGDLBCOAAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E000", Offset = "0x6F6CC00", VA = "0x186F6E000")]
		internal object NKLBKIEADHC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct AMKNHJGGNEM : IAsyncStateMachine
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
		public DNIGEHBOJIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private NGDLBCOAAJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F52840", Offset = "0x6F51440", VA = "0x186F52840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F52F90", Offset = "0x6F51B90", VA = "0x186F52F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class LAKANKFODMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LAKANKFODMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F645D0", Offset = "0x6F631D0", VA = "0x186F645D0")]
		internal object MLDAMHINFLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private HGDLEIAFABH[] IKPHJJMABFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource BMBBMOBAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int BPGIBJNNPDH;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F56C80", Offset = "0x6F55880", VA = "0x186F56C80", Slot = "6")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6F56C70", Offset = "0x6F55870", VA = "0x186F56C70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6F57100", Offset = "0x6F55D00", VA = "0x186F57100", Slot = "8")]
	public void NNGDDAGLGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6F57030", Offset = "0x6F55C30", VA = "0x186F57030", Slot = "5")]
	public void NGHAJJCKKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6F56F60", Offset = "0x6F55B60", VA = "0x186F56F60", Slot = "4")]
	[AsyncStateMachine(typeof(COPHBFOCAAL))]
	public Task MGJCAIKHEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6F57300", Offset = "0x6F55F00", VA = "0x186F57300")]
	private void OMKHKOPAHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6F57200", Offset = "0x6F55E00", VA = "0x186F57200")]
	[AsyncStateMachine(typeof(POKBONPKPJA))]
	private Task ODFJCNEGIPI(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6F56970", Offset = "0x6F55570", VA = "0x186F56970")]
	[AsyncStateMachine(typeof(AMKNHJGGNEM))]
	private Task<bool> BLEEFNOLADA(int OPDMGNJCACB, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6F56AB0", Offset = "0x6F556B0", VA = "0x186F56AB0")]
	private void CODPECNOJPM(int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6F56B90", Offset = "0x6F55790", VA = "0x186F56B90")]
	private void DGNKBAJDPID(int OPDMGNJCACB, bool BCJBOMDKMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F56D00", Offset = "0x6F55900", VA = "0x186F56D00")]
	private void IGNNMKIMMKN(int OPDMGNJCACB, Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F56E30", Offset = "0x6F55A30", VA = "0x186F56E30")]
	private void KNAMDJMPFNJ(CancellationToken MPLCHGMFENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public DNIGEHBOJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class HFOJPHKENEK : HHMHLOLAALF, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct AGCIAIMIGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public INPBHLHJDLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6F51E80", Offset = "0x6F50A80", VA = "0x186F51E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F527E0", Offset = "0x6F513E0", VA = "0x186F527E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct NCLMKIEGINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public INPBHLHJDLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private GDCBCFBEPNI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private KJGBHDJPPOF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private HLIBNFHHDHM <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private OHGDKBMNKCK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C7F0", Offset = "0x6F6B3F0", VA = "0x186F6C7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D3B0", Offset = "0x6F6BFB0", VA = "0x186F6D3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class BDCBOMBAOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.AOCEBJNLNMD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MMBCKMLDDKA errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BDCBOMBAOBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F53990", Offset = "0x6F52590", VA = "0x186F53990")]
		internal object AJLNNCCPMGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JIJGPDGNADH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<IDHGEAOPLAO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JIJGPDGNADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		internal Task<IDHGEAOPLAO> IPLFGHBICHB(GDCBCFBEPNI<string>.LHHFCPKIPMG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct LMCHNBLCCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public INPBHLHJDLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HLIBNFHHDHM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private JIJGPDGNADH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private FFDHPHIIHCF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private KJGBHDJPPOF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private OEPEJKPKKLA <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.OLHDHKBAENG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private FKNKOPBLKHH <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.OLHDHKBAENG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<IDHGEAOPLAO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F65120", Offset = "0x6F63D20", VA = "0x186F65120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A600", Offset = "0x6F69200", VA = "0x186F6A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FCCAINEGILJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <disconnectTimerScope>5__3;

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
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F58DB0", Offset = "0x6F579B0", VA = "0x186F58DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F59800", Offset = "0x6F58400", VA = "0x186F59800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct LFJCLDNKKIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private LLIMAHMFNLB <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F64B70", Offset = "0x6F63770", VA = "0x186F64B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F64FE0", Offset = "0x6F63BE0", VA = "0x186F64FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct HGFCLGBNHEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.OLHDHKBAENG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.OLHDHKBAENG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F390", Offset = "0x6F5DF90", VA = "0x186F5F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F890", Offset = "0x6F5E490", VA = "0x186F5F890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct IEBIMODLOKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.OLHDHKBAENG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public HLIBNFHHDHM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<PFGMKGAHNAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F625B0", Offset = "0x6F611B0", VA = "0x186F625B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F62CB0", Offset = "0x6F618B0", VA = "0x186F62CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class ECBBAHGCPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ECBBAHGCPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6F577B0", Offset = "0x6F563B0", VA = "0x186F577B0")]
		internal object GGHBHCNHJOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6F576B0", Offset = "0x6F562B0", VA = "0x186F576B0")]
		internal string BKNLEEBCFPK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct MEEKHBKNKOK : IAsyncStateMachine
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
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private ECBBAHGCPOD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private KJGBHDJPPOF <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B2E0", Offset = "0x6F69EE0", VA = "0x186F6B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BEB0", Offset = "0x6F6AAB0", VA = "0x186F6BEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct FBDPCHBANFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HLIBNFHHDHM joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public IDHGEAOPLAO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public NJAGFBDJADF targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public FFDHPHIIHCF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6F58440", Offset = "0x6F57040", VA = "0x186F58440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F58D50", Offset = "0x6F57950", VA = "0x186F58D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct BMBBAGLFJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private KJGBHDJPPOF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6F541C0", Offset = "0x6F52DC0", VA = "0x186F541C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6F55800", Offset = "0x6F54400", VA = "0x186F55800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct NDLMILALMKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public HFOJPHKENEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<FBOKJACJPGA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D7E0", Offset = "0x6F6C3E0", VA = "0x186F6D7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F6DFA0", Offset = "0x6F6CBA0", VA = "0x186F6DFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class DHPCDBLAKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DHPCDBLAKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F564B0", Offset = "0x6F550B0", VA = "0x186F564B0")]
		internal object HMCFPLMBAJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IAILPDKDBGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IAILPDKDBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F616C0", Offset = "0x6F602C0", VA = "0x186F616C0")]
		internal void FODHFJIMJCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class FBDCCOFNHHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FBDCCOFNHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6F583C0", Offset = "0x6F56FC0", VA = "0x186F583C0")]
		internal object EOHNOCDMOGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class HGDBKENHCOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HGDBKENHCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F290", Offset = "0x6F5DE90", VA = "0x186F5F290")]
		internal string KOKPDLFNDJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly KEDKJKIEEGM IFJHFKEPCBK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly KEDKJKIEEGM IKOONIINFAC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly KEDKJKIEEGM CDGDLDDLMEG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string ENDDEAHGEEF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string PGBJOPGAAOJ;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string LHBFCJAIFCM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid EPEONAMJAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private EKDPFEKGPHI LGNFDEGCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FNAIHKNMEOK MFGENMNCHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EIGIHAALGDO PDPGFDGAIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NKKOEDLBBOE OHHJLPAJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private EHLAOHFBEMB NMIGDBGJOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private MMAPHKALPKN KCIOKMJKIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private OEPHDHCALJN DLPILNPPHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable PAGGHDEBANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly FNLKKHGONOA AGOPKBICEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly FNLKKHGONOA IMFBAJAILGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private FKNKOPBLKHH IAKELLLMBKI;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public TaskStatus CIPALLBMODC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3970", Offset = "0x8B2570", VA = "0x1808B3970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xC71580", Offset = "0xC70180", VA = "0x180C71580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C1C0", Offset = "0x6F5ADC0", VA = "0x186F5C1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C570", Offset = "0x6F5B170", VA = "0x186F5C570", Slot = "6")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C270", Offset = "0x6F5AE70", VA = "0x186F5C270", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EE60", Offset = "0x6F5DA60", VA = "0x186F5EE60", Slot = "5")]
	[AsyncStateMachine(typeof(AGCIAIMIGFB))]
	public Task OAJCCMIAHGC(NJAGFBDJADF NKIDIMEMAPM, INPBHLHJDLM BFLCGAFNDHD, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C420", Offset = "0x6F5B020", VA = "0x186F5C420")]
	[AsyncStateMachine(typeof(NCLMKIEGINO))]
	private Task EBBIBBLOHCE(NJAGFBDJADF NKIDIMEMAPM, INPBHLHJDLM BFLCGAFNDHD, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E800", Offset = "0x6F5D400", VA = "0x186F5E800")]
	private static void JPFNGPLIDON(MMAPHKALPKN KCIOKMJKIML, NJAGFBDJADF NKIDIMEMAPM, Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D7D0", Offset = "0x6F5C3D0", VA = "0x186F5D7D0")]
	private static void HCNNOMEJLIL(OHGDKBMNKCK NBEBJOEIJAJ, Exception JNLFEIJKPEF, [Optional] List<int> POEIMDDMBFP, int BPGIBJNNPDH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C2C0", Offset = "0x6F5AEC0", VA = "0x186F5C2C0")]
	[AsyncStateMachine(typeof(LMCHNBLCCKH))]
	private Task EAPCMIMPJAH(GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, NJAGFBDJADF NKIDIMEMAPM, INPBHLHJDLM BFLCGAFNDHD, HLIBNFHHDHM MFBGNNHFMFG, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BA70", Offset = "0x6F5A670", VA = "0x186F5BA70")]
	private void BBBPILCEHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E2B0", Offset = "0x6F5CEB0", VA = "0x186F5E2B0")]
	[AsyncStateMachine(typeof(FCCAINEGILJ))]
	private Task IFEPFDPNDGB(GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CC70", Offset = "0x6F5B870", VA = "0x186F5CC70")]
	private void GBPHNDMELKP(NJAGFBDJADF NKIDIMEMAPM, CancellationToken DDPMOBGAIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E080", Offset = "0x6F5CC80", VA = "0x186F5E080")]
	private void HIDLBFBBGPP(NJAGFBDJADF NKIDIMEMAPM, HLIBNFHHDHM MFBGNNHFMFG, OperationCanceledException DIPELLDNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CFA0", Offset = "0x6F5BBA0", VA = "0x186F5CFA0")]
	private void GHKBILDHOCC(NJAGFBDJADF NKIDIMEMAPM, HLIBNFHHDHM MFBGNNHFMFG, Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E3E0", Offset = "0x6F5CFE0", VA = "0x186F5E3E0")]
	private void IGBMIEJOLHK(NJAGFBDJADF NKIDIMEMAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C210", Offset = "0x6F5AE10", VA = "0x186F5C210")]
	private static IHIJMGLMGDF DGIDFICNDPN(NJAGFBDJADF NKIDIMEMAPM)
	{
		return default(IHIJMGLMGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BE80", Offset = "0x6F5AA80", VA = "0x186F5BE80")]
	[AsyncStateMachine(typeof(LFJCLDNKKIE))]
	private Task BGOCMCMKKFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D1D0", Offset = "0x6F5BDD0", VA = "0x186F5D1D0")]
	[AsyncStateMachine(typeof(HGFCLGBNHEO))]
	private Task<Matchmaking.OLHDHKBAENG> GMEDOJEBDIG(NJAGFBDJADF NKIDIMEMAPM, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B960", Offset = "0x6F5A560", VA = "0x186F5B960")]
	private static PFGMKGAHNAP ADCNFALLKKN(Matchmaking.OLHDHKBAENG FINOIPPJLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D680", Offset = "0x6F5C280", VA = "0x186F5D680")]
	[AsyncStateMachine(typeof(IEBIMODLOKI))]
	private Task HCKINBICFNH(Matchmaking.OLHDHKBAENG FINOIPPJLOH, HLIBNFHHDHM MFBGNNHFMFG, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken HHPMDKPLKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D390", Offset = "0x6F5BF90", VA = "0x186F5D390")]
	[AsyncStateMachine(typeof(MEEKHBKNKOK))]
	private Task GODBAGCCGOD(NJAGFBDJADF NKIDIMEMAPM, CancellationTokenSource MKEKLCHDCNO, Task HMDKPIKHOCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F5C050", Offset = "0x6F5AC50", VA = "0x186F5C050")]
	[AsyncStateMachine(typeof(FBDPCHBANFL))]
	private Task CDHPODIAELI(IDHGEAOPLAO BGCHEPNMKLN, FFDHPHIIHCF CNNEAHANGMN, NJAGFBDJADF BEGLIOJCDCK, HLIBNFHHDHM EONDJEEOHPO, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken JHJHOBFOLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F5B770", Offset = "0x6F5A370", VA = "0x186F5B770")]
	private HLIBNFHHDHM AAHHCCOKGEP(HLIBNFHHDHM EONDJEEOHPO, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CB40", Offset = "0x6F5B740", VA = "0x186F5CB40")]
	[AsyncStateMachine(typeof(BMBBAGLFJHN))]
	private Task FFLNLFKLBLB(GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ED40", Offset = "0x6F5D940", VA = "0x186F5ED40")]
	[AsyncStateMachine(typeof(NDLMILALMKE))]
	private Task MPDJACOBJIK(OJAAINJGBPM IMCLGJBJJKP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E680", Offset = "0x6F5D280", VA = "0x186F5E680")]
	private static void JKFNLDMCLLO(NJAGFBDJADF NKIDIMEMAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BCB0", Offset = "0x6F5A8B0", VA = "0x186F5BCB0")]
	private void BEDFLOKKGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EC20", Offset = "0x6F5D820", VA = "0x186F5EC20")]
	private void LONHNAEBAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ECB0", Offset = "0x6F5D8B0", VA = "0x186F5ECB0")]
	private void MLPFIIKKLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E5F0", Offset = "0x6F5D1F0", VA = "0x186F5E5F0")]
	private void IIHGHFNGBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BBC0", Offset = "0x6F5A7C0", VA = "0x186F5BBC0")]
	private static void BCJNIPFEDPN(NJAGFBDJADF NKIDIMEMAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5CA30", Offset = "0x6F5B630", VA = "0x186F5CA30")]
	private static CancellationTokenRegistration FDKBNOFONEP(NJAGFBDJADF NKIDIMEMAPM, CancellationToken HHPMDKPLKIK)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5BF50", Offset = "0x6F5AB50", VA = "0x186F5BF50")]
	private static void BLCEDLPLCLF(NJAGFBDJADF NKIDIMEMAPM, Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D4D0", Offset = "0x6F5C0D0", VA = "0x186F5D4D0")]
	private void GPDBOCKMCAK(NJAGFBDJADF NKIDIMEMAPM, Task HMDKPIKHOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EBC0", Offset = "0x6F5D7C0", VA = "0x186F5EBC0")]
	private static void LCOFNOOCLJC(Func<string> ICOEPJKILLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F1C0", Offset = "0x6F5DDC0", VA = "0x186F5F1C0")]
	public HFOJPHKENEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F5D330", Offset = "0x6F5BF30", VA = "0x186F5D330")]
	[CompilerGenerated]
	internal static (int, int?) GMHPNFGAPHK(MMBCKMLDDKA PFGMABBCMAM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class HKIBHKIKAJN : OOMOCPAFIDB, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct KCOHJKOFPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public HKIBHKIKAJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OJAAINJGBPM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F83D00", Offset = "0x6F82900", VA = "0x186F83D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6F840C0", Offset = "0x6F82CC0", VA = "0x186F840C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class BEMOHDGPLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public HKIBHKIKAJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public OJAAINJGBPM roomData;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BEMOHDGPLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F74050", Offset = "0x6F72C50", VA = "0x186F74050")]
		internal List<Task> LLNBKIEFBCA(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct NJPEOHOKPDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public LJCGOJOAMKH taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B2B0", Offset = "0x6F89EB0", VA = "0x186F8B2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B640", Offset = "0x6F8A240", VA = "0x186F8B640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct KFGLIINHKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HKIBHKIKAJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6F85590", Offset = "0x6F84190", VA = "0x186F85590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F85850", Offset = "0x6F84450", VA = "0x186F85850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<LJCGOJOAMKH> ELKEIMLBPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private FNAIHKNMEOK MFGENMNCHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private KJBJBMMKEPB ECKLBNBKLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private MLPLAPJKJGL AGCDPOEJABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable PAGGHDEBANL;

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F602E0", Offset = "0x6F5EEE0", VA = "0x186F602E0", Slot = "5")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F60280", Offset = "0x6F5EE80", VA = "0x186F60280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6F609B0", Offset = "0x6F5F5B0", VA = "0x186F609B0", Slot = "4")]
	public bool GOGLPBGFLIM(LJCGOJOAMKH CLJGADJHLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F60DC0", Offset = "0x6F5F9C0", VA = "0x186F60DC0")]
	private void NGEEAPBGIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F60F70", Offset = "0x6F5FB70", VA = "0x186F60F70")]
	private void OMDCMEJDCHP(OJAAINJGBPM AFAEGADIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F60CD0", Offset = "0x6F5F8D0", VA = "0x186F60CD0")]
	[AsyncStateMachine(typeof(KCOHJKOFPEF))]
	private Task MMCPGFCLBBP(OJAAINJGBPM AFAEGADIMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F60A10", Offset = "0x6F5F610", VA = "0x186F60A10")]
	private Func<CancellationToken, List<Task>> HPKFHKHLPOL(OJAAINJGBPM AFAEGADIMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F60560", Offset = "0x6F5F160", VA = "0x186F60560")]
	private List<Task> GMFGLICHDJF(OJAAINJGBPM AFAEGADIMPI, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F60AE0", Offset = "0x6F5F6E0", VA = "0x186F60AE0")]
	[AsyncStateMachine(typeof(NJPEOHOKPDL))]
	private Task IOKHPDAPMEO(LJCGOJOAMKH PLHMBOBMHLD, OJAAINJGBPM IMCLGJBJJKP, CancellationToken FGIAGALCIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F60C00", Offset = "0x6F5F800", VA = "0x186F60C00")]
	[AsyncStateMachine(typeof(KFGLIINHKGA))]
	private Task LFNJBLCEBNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F60EF0", Offset = "0x6F5FAF0", VA = "0x186F60EF0")]
	private void NNGDDAGLGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6F61150", Offset = "0x6F5FD50", VA = "0x186F61150")]
	public HKIBHKIKAJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class JKJADMGLFEG : PPGGJDMBENK, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NNALIHNGJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NNALIHNGJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B6A0", Offset = "0x6F8A2A0", VA = "0x186F8B6A0")]
		internal object HAGHIDLFMLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KPHHLFLPGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KPHHLFLPGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F87140", Offset = "0x6F85D40", VA = "0x186F87140")]
		internal object KILPMDCHJEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class EMIAKHPIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EMIAKHPIMOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class KDAPHHAPLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KDAPHHAPLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F84120", Offset = "0x6F82D20", VA = "0x186F84120")]
		internal object HCGHKOMBDIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class IIPCLMEOFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IIPCLMEOFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F100", Offset = "0x6F7DD00", VA = "0x186F7F100")]
		internal object AFNNLBGBPEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, JHMDOJBPAIM> BAGHCONHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan OEGHADPGFFO;

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "9")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F824E0", Offset = "0x6F810E0", VA = "0x186F824E0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F828E0", Offset = "0x6F814E0", VA = "0x186F828E0", Slot = "4")]
	public NBOPPMJPNHG MPFJKDGCCNN(Guid AMMGFMLLGCP)
	{
		return default(NBOPPMJPNHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F824F0", Offset = "0x6F810F0", VA = "0x186F824F0", Slot = "5")]
	public bool IFPALOLJLCH(Guid AMMGFMLLGCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F82B00", Offset = "0x6F81700", VA = "0x186F82B00", Slot = "6")]
	public bool NBNIEGEBCMN(Guid AMMGFMLLGCP, Task OHDJMABKDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F82700", Offset = "0x6F81300", VA = "0x186F82700", Slot = "7")]
	public bool LJMDAHFNMML(Guid AMMGFMLLGCP, FBOKJACJPGA DGJONDHJOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F82E30", Offset = "0x6F81A30", VA = "0x186F82E30", Slot = "8")]
	public Task<(FBOKJACJPGA, Task)> OMOIPHHIDHF(Guid AMMGFMLLGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F822B0", Offset = "0x6F80EB0", VA = "0x186F822B0")]
	private void CLCPCFKIHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F82EA0", Offset = "0x6F81AA0", VA = "0x186F82EA0")]
	public JKJADMGLFEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class IJFGLEJENFP : DLHJFCMGOPO, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class KMOADNIDNHN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly NJAGFBDJADF FAFCMLOAFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource BMBBMOBAEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken DENFOMHEOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool HMFJEGCLBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool JAMLMCMFMMA;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F86740", Offset = "0x6F85340", VA = "0x186F86740")]
		public KMOADNIDNHN(NJAGFBDJADF FAFCMLOAFLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F865F0", Offset = "0x6F851F0", VA = "0x186F865F0")]
		public void NNGDDAGLGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F865C0", Offset = "0x6F851C0", VA = "0x186F865C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class EHAGEELKABH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public BJAMEPODHAC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EHAGEELKABH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F77660", Offset = "0x6F76260", VA = "0x186F77660")]
		internal object OKIDPLHGLGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct DEOKHKPHDLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public BJAMEPODHAC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public IJFGLEJENFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F755A0", Offset = "0x6F741A0", VA = "0x186F755A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F75950", Offset = "0x6F74550", VA = "0x186F75950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class HHLCNKFAFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HHLCNKFAFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C1C0", Offset = "0x6F7ADC0", VA = "0x186F7C1C0")]
		internal object MIEINNONIGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct OEBFDAIJNDM : IAsyncStateMachine
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
		public IJFGLEJENFP <>4__this;

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
		private KJGBHDJPPOF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B860", Offset = "0x6F8A460", VA = "0x186F8B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ECBHEEDPMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public NJAGFBDJADF newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ECBHEEDPMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F75A30", Offset = "0x6F74630", VA = "0x186F75A30")]
		internal object MMBFMPJHGAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F759B0", Offset = "0x6F745B0", VA = "0x186F759B0")]
		internal object DEMENAMKBNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F759F0", Offset = "0x6F745F0", VA = "0x186F759F0")]
		internal object IKOGEBLEHHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class OADAJCILLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OADAJCILLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B700", Offset = "0x6F8A300", VA = "0x186F8B700")]
		internal void LNMLPKFECFF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct LNGGNFJJNOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public NJAGFBDJADF newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public IJFGLEJENFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public INPBHLHJDLM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private ECBHEEDPMLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private KJGBHDJPPOF <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F88060", Offset = "0x6F86C60", VA = "0x186F88060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F88FE0", Offset = "0x6F87BE0", VA = "0x186F88FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly JGAFKAJKHDN.ENLOBBAJCAN AIOOMOFMJCI;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly AGHGMAKBJLO KFLCOLGHKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private FNAIHKNMEOK MFGENMNCHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private EIGIHAALGDO PDPGFDGAIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private CGAIKOHGGAK BPPGADPMEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private HHMHLOLAALF FJHKIFNHLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long DPFNPBKNEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private KMOADNIDNHN IIEPACHPJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool ICMOGIPAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task OJIDAPKPMIK;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F330", Offset = "0x6F7DF30", VA = "0x186F7F330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool KBPJAFAHMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x90B370", Offset = "0x909F70", VA = "0x18090B370")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F320", Offset = "0x6F7DF20", VA = "0x186F7F320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F670", Offset = "0x6F7E270", VA = "0x186F7F670", Slot = "4")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F3D0", Offset = "0x6F7DFD0", VA = "0x186F7F3D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F160", Offset = "0x6F7DD60", VA = "0x186F7F160")]
	[AsyncStateMachine(typeof(DEOKHKPHDLD))]
	private Task ACNGONFILMK(BJAMEPODHAC EIAJAGFEDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FAA0", Offset = "0x6F7E6A0", VA = "0x186F7FAA0")]
	private void IELEHGHOIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F910", Offset = "0x6F7E510", VA = "0x186F7F910")]
	private void FPDFBNBMCIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F80040", Offset = "0x6F7EC40", VA = "0x186F80040")]
	private void POFLKEDNNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FC40", Offset = "0x6F7E840", VA = "0x186F7FC40")]
	private bool IPFOAOLBAGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F250", Offset = "0x6F7DE50", VA = "0x186F7F250")]
	[AsyncStateMachine(typeof(OEBFDAIJNDM))]
	private void AEJAFNLFPCM(int LDNLBCKJNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FDB0", Offset = "0x6F7E9B0", VA = "0x186F7FDB0")]
	private void PKFAPFLCNLI([Out] IDisposable MJDFIGJCLCD, [Out] IDisposable JCLAECDCHBB, [Out] IDisposable MONNJDIHBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FCB0", Offset = "0x6F7E8B0", VA = "0x186F7FCB0")]
	private bool LMDDCNOLEON(NJAGFBDJADF FAFCMLOAFLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F380", Offset = "0x6F7DF80", VA = "0x186F7F380")]
	private void DJHFEIKOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F540", Offset = "0x6F7E140", VA = "0x186F7F540")]
	[AsyncStateMachine(typeof(LNGGNFJJNOH))]
	private Task EBBIBBLOHCE(NJAGFBDJADF FAFCMLOAFLH, INPBHLHJDLM BFLCGAFNDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F80590", Offset = "0x6F7F190", VA = "0x186F80590")]
	public IJFGLEJENFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class KEPIPGHCAMC : FLNIOLEOHOE, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct LELONJCKAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<OPMNPHPPHHM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public KEPIPGHCAMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<OPMNPHPPHHM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F87260", Offset = "0x6F85E60", VA = "0x186F87260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F874F0", Offset = "0x6F860F0", VA = "0x186F874F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class KDJLGCJJLEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public FNFHONNECCC message;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KDJLGCJJLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F84180", Offset = "0x6F82D80", VA = "0x186F84180")]
		internal object IDJLEHDMGKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class LDONAEGJFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public FNFHONNECCC messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LDONAEGJFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F87200", Offset = "0x6F85E00", VA = "0x186F87200")]
		internal object NJPPFNBDDBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class LMGEABCKDNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LMGEABCKDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F88000", Offset = "0x6F86C00", VA = "0x186F88000")]
		internal object IJAGEAILGHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct IDHCPOKONMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public KEPIPGHCAMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<FCIIDNJEMOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E280", Offset = "0x6F7CE80", VA = "0x186F7E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EB40", Offset = "0x6F7D740", VA = "0x186F7EB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class CLIJGCGBBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public FNFHONNECCC operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CLIJGCGBBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F74D50", Offset = "0x6F73950", VA = "0x186F74D50")]
		internal object MIDPFKDBBGH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct KHNHKGFPPDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public FNFHONNECCC operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public KEPIPGHCAMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private HLIBNFHHDHM <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F859F0", Offset = "0x6F845F0", VA = "0x186F859F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F86560", Offset = "0x6F85160", VA = "0x186F86560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct GCJNPJFDELK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<FCIIDNJEMOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public KEPIPGHCAMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private OKAKIILGAKD.IDJLDDILAEH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private HLIBNFHHDHM <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F79840", Offset = "0x6F78440", VA = "0x186F79840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F79D60", Offset = "0x6F78960", VA = "0x186F79D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class EIDHOIKILAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public FCIIDNJEMOA operation;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EIDHOIKILAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F776F0", Offset = "0x6F762F0", VA = "0x186F776F0")]
		internal object PPFMKNDMDPP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct JIFHFECBGAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public FCIIDNJEMOA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public KEPIPGHCAMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private GDCBCFBEPNI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F81C20", Offset = "0x6F80820", VA = "0x186F81C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F82250", Offset = "0x6F80E50", VA = "0x186F82250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class HAPFEICCKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HAPFEICCKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C160", Offset = "0x6F7AD60", VA = "0x186F7C160")]
		internal object NHAKEFMMHMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class FOJDFHMNAMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FOJDFHMNAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F797E0", Offset = "0x6F783E0", VA = "0x186F797E0")]
		internal object MMIFMCPLEAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private NKKOEDLBBOE OHHJLPAJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private KFIGEBLHPLP JHMLJJENHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private GFBHEMMFJBJ NCHHCKCMMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<OPMNPHPPHHM> BOPOOCBJGKL;

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F84600", Offset = "0x6F83200", VA = "0x186F84600", Slot = "7")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F84BA0", Offset = "0x6F837A0", VA = "0x186F84BA0", Slot = "6")]
	[AsyncStateMachine(typeof(LELONJCKAFL))]
	public Task<OPMNPHPPHHM> LDIMIAKLCAO(CancellationToken BAHONPMJFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F84270", Offset = "0x6F82E70", VA = "0x186F84270", Slot = "4")]
	public void CKODEGJOABB(FNFHONNECCC JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F85120", Offset = "0x6F83D20", VA = "0x186F85120", Slot = "5")]
	public void OIMECCJCAJJ(FNFHONNECCC EJAKBENANMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F85480", Offset = "0x6F84080", VA = "0x186F85480")]
	[AsyncStateMachine(typeof(IDHCPOKONMO))]
	private Task PHBDFJLPGDA(FNFHONNECCC CLBGLGJCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F84E00", Offset = "0x6F83A00", VA = "0x186F84E00")]
	[AsyncStateMachine(typeof(KHNHKGFPPDB))]
	private Task NNMFDGHNIPH(FNFHONNECCC CMCKGMFFAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F84CB0", Offset = "0x6F838B0", VA = "0x186F84CB0")]
	[AsyncStateMachine(typeof(GCJNPJFDELK))]
	private Task<FCIIDNJEMOA> NICPLCFONGM(FNFHONNECCC CLBGLGJCBEB, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F841E0", Offset = "0x6F82DE0", VA = "0x186F841E0")]
	private HLIBNFHHDHM APDPNBHAMNH(FNFHONNECCC KPBJIJCEDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F846F0", Offset = "0x6F832F0", VA = "0x186F846F0")]
	[AsyncStateMachine(typeof(JIFHFECBGAF))]
	private Task FGCGBIDODPG(FCIIDNJEMOA PIJDNDPDOCK, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F84F10", Offset = "0x6F83B10", VA = "0x186F84F10")]
	private FCIIDNJEMOA NOJHLPJEPBM(FNFHONNECCC CLBGLGJCBEB, HLIBNFHHDHM GDJHHHLGCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC540", Offset = "0x2BCB140", VA = "0x182BCC540")]
	private T GPOLCJJPBML<T>(T GLMEMJNJKAN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F84810", Offset = "0x6F83410", VA = "0x186F84810")]
	private FCIIDNJEMOA HNKNFDINDJA(FNFHONNECCC CLBGLGJCBEB, HLIBNFHHDHM GDJHHHLGCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KEPIPGHCAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class BEGPFLPDLOI : KFIGEBLHPLP, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class HNLKLADPEEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HNLKLADPEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E210", Offset = "0x6F7CE10", VA = "0x186F7E210")]
		internal object IKMOKJKOOHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class AJJBOLICFDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AJJBOLICFDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F71100", Offset = "0x6F6FD00", VA = "0x186F71100")]
		internal object OJGCNOCMHIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private LOBIOOMAFIE NJIMNCDGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private FLNIOLEOHOE BIOKBOJFKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private PPGGJDMBENK BAGHCONHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private EPMEMOKNIAL MKGCPLOGFBJ;

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F72480", Offset = "0x6F71080", VA = "0x186F72480", Slot = "6")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F72300", Offset = "0x6F70F00", VA = "0x186F72300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F71ED0", Offset = "0x6F70AD0", VA = "0x186F71ED0", Slot = "4")]
	public NBOPPMJPNHG DOINCHPNFMB(FNFHONNECCC OGHJFBDDMAE)
	{
		return default(NBOPPMJPNHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F737E0", Offset = "0x6F723E0", VA = "0x186F737E0", Slot = "5")]
	public void PEDMCIJNPOM(Guid AMMGFMLLGCP, Task OHDJMABKDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F723B0", Offset = "0x6F70FB0", VA = "0x186F723B0")]
	private void EAFPLFALICL(byte FGGFGGPFKAI, int DCAKCMKMNFC, object PABNJNNLMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F72E00", Offset = "0x6F71A00", VA = "0x186F72E00")]
	private void JAHCPLDPIEM(KAGLBAEDJPG JFEELHKEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6F72870", Offset = "0x6F71470", VA = "0x186F72870")]
	private void GCJHKNLCBAN(KAGLBAEDJPG JFEELHKEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6F735A0", Offset = "0x6F721A0", VA = "0x186F735A0")]
	private void KMJGAMKFJJO(KAGLBAEDJPG JFEELHKEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F719E0", Offset = "0x6F705E0", VA = "0x186F719E0")]
	private FBOKJACJPGA ACLJEMLAMID(FNFHONNECCC KPBJIJCEDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F73390", Offset = "0x6F71F90", VA = "0x186F73390")]
	private void JMACOOPKBOK(FNFHONNECCC CMCKGMFFAPL, FBOKJACJPGA DGJONDHJOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F71C20", Offset = "0x6F70820", VA = "0x186F71C20")]
	private bool DLLDHCEHKEE(FNFHONNECCC CMCKGMFFAPL, FBOKJACJPGA DGJONDHJOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F725F0", Offset = "0x6F711F0", VA = "0x186F725F0")]
	private bool GCFIPGBGJJC(FNFHONNECCC GEMNGMGOHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6F72B70", Offset = "0x6F71770", VA = "0x186F72B70")]
	private bool HFILJPNOLJI(byte FGGFGGPFKAI, ExitGames.Client.Photon.Hashtable JFEELHKEMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BEGPFLPDLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class PIHFDINHHFI : DGHCKMAOINP, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class KOBHIEHNIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public OPMNPHPPHHM operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public PIHFDINHHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public FNFHONNECCC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KOBHIEHNIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6F867F0", Offset = "0x6F853F0", VA = "0x186F867F0")]
		internal object CAMACBJDGAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6F86860", Offset = "0x6F85460", VA = "0x186F86860")]
		internal object LKKAGIJCDBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct OKKOKIDOFLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public PIHFDINHHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public FNFHONNECCC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<FBOKJACJPGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C9F0", Offset = "0x6F8B5F0", VA = "0x186F8C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D080", Offset = "0x6F8BC80", VA = "0x186F8D080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class KBOLPBFPALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public OPMNPHPPHHM operationType;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KBOLPBFPALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F83C90", Offset = "0x6F82890", VA = "0x186F83C90")]
		internal object BAPLHPMLAJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class CNFGBFKJCIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CNFGBFKJCIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6F75450", Offset = "0x6F74050", VA = "0x186F75450")]
		internal object CKEILKJCPFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6F754C0", Offset = "0x6F740C0", VA = "0x186F754C0")]
		internal object HCAJABEDNFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6F753E0", Offset = "0x6F73FE0", VA = "0x186F753E0")]
		internal object CDBDMDIMFGB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct INGNJPDLMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public PIHFDINHHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private CNFGBFKJCIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private NBOPPMJPNHG <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private FBOKJACJPGA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(FBOKJACJPGA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6F80640", Offset = "0x6F7F240", VA = "0x186F80640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6F80EF0", Offset = "0x6F7FAF0", VA = "0x186F80EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private LOBIOOMAFIE NJIMNCDGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private KFIGEBLHPLP JHMLJJENHEF;

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DD90", Offset = "0x6F8C990", VA = "0x186F8DD90", Slot = "5")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DE40", Offset = "0x6F8CA40", VA = "0x186F8DE40", Slot = "4")]
	[AsyncStateMachine(typeof(OKKOKIDOFLI))]
	private Task<FBOKJACJPGA> INGPDCGEKON(FNFHONNECCC KPBJIJCEDMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DF60", Offset = "0x6F8CB60", VA = "0x186F8DF60")]
	private bool OBCFJIPLENP(OPMNPHPPHHM NMCAEILPPGB, [Out] FBOKJACJPGA JFBAIGMLPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DC50", Offset = "0x6F8C850", VA = "0x186F8DC50")]
	[AsyncStateMachine(typeof(INGNJPDLMAK))]
	private Task<FBOKJACJPGA> CNFFPCLDKLK(FNFHONNECCC CLBGLGJCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PIHFDINHHFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class LLABHJFBHIM : AHFOCMCIPNL, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct HIAMEEKDNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<IDHGEAOPLAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public LLABHJFBHIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<FMLBFFJHFNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C230", Offset = "0x6F7AE30", VA = "0x186F7C230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C6E0", Offset = "0x6F7B2E0", VA = "0x186F7C6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class OOPCHFGOHIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OOPCHFGOHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D0F0", Offset = "0x6F8BCF0", VA = "0x186F8D0F0")]
		internal object DNJDKJLGJDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct BEJPEMJBNAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<FMLBFFJHFNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public LLABHJFBHIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public NJAGFBDJADF targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private OOPCHFGOHIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<FMLBFFJHFNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6F739F0", Offset = "0x6F725F0", VA = "0x186F739F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6F73FE0", Offset = "0x6F72BE0", VA = "0x186F73FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class JCCIKDNCNDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JCCIKDNCNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x91CE90", Offset = "0x91BA90", VA = "0x18091CE90")]
		internal bool DDAIJHHKJHA(LIFOCOCGCNJ sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private NJPLNDPCKFC CLACCFGBLMI;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (CDMECJMNEDA superRoomData, long subRoomDataSaveId) NCIGMGDKKGF;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F87BB0", Offset = "0x6F867B0", VA = "0x186F87BB0", Slot = "5")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6F877B0", Offset = "0x6F863B0", VA = "0x186F877B0", Slot = "4")]
	[AsyncStateMachine(typeof(HIAMEEKDNKA))]
	public Task<IDHGEAOPLAO> ADKMGFKMPOC(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, NJAGFBDJADF NKIDIMEMAPM, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6F87A50", Offset = "0x6F86650", VA = "0x186F87A50")]
	[AsyncStateMachine(typeof(BEJPEMJBNAL))]
	private Task<FMLBFFJHFNC> COHLDDBMJNI(NJAGFBDJADF NKIDIMEMAPM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6F87910", Offset = "0x6F86510", VA = "0x186F87910")]
	private IDHGEAOPLAO CIHFKLPBKMP(NJAGFBDJADF NKIDIMEMAPM, FMLBFFJHFNC PINOGOEDJPH, long JJFCFIMNPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6F87C40", Offset = "0x6F86840", VA = "0x186F87C40")]
	private (CDMECJMNEDA, long) LAPCHLCLCNE(NJAGFBDJADF NKIDIMEMAPM, FMLBFFJHFNC PINOGOEDJPH, long JJFCFIMNPNM)
	{
		return default((CDMECJMNEDA, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LLABHJFBHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class JNIGKFMCFMC : GFBHEMMFJBJ, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class MNMOAMFLAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MNMOAMFLAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A810", Offset = "0x6F89410", VA = "0x186F8A810")]
		internal object HGDNDBEFPFO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct MAOIOHNKAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public JNIGKFMCFMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public HLIBNFHHDHM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F89040", Offset = "0x6F87C40", VA = "0x186F89040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6F89650", Offset = "0x6F88250", VA = "0x186F89650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PIGGOMADKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public JNIGKFMCFMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public HLIBNFHHDHM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<HMIOJEDGJLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D5E0", Offset = "0x6F8C1E0", VA = "0x186F8D5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DBE0", Offset = "0x6F8C7E0", VA = "0x186F8DBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class LCJHEHHLAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LCJHEHHLAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6F871A0", Offset = "0x6F85DA0", VA = "0x186F871A0")]
		internal object PBNDAFADIEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct JHNFHPCLBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public FNFHONNECCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public JNIGKFMCFMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public HLIBNFHHDHM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private CNCIMBCOJCP <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private HJNLEPCPLPG <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<HMIOJEDGJLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6F80FC0", Offset = "0x6F7FBC0", VA = "0x186F80FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6F81BB0", Offset = "0x6F807B0", VA = "0x186F81BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private GEBOBJKGBAO NHACOILCOJN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private PJJBGFJNFKD DNPGEDNJBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6F83840", Offset = "0x6F82440", VA = "0x186F83840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6F830C0", Offset = "0x6F81CC0", VA = "0x186F830C0", Slot = "8")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x6F82F60", Offset = "0x6F81B60", VA = "0x186F82F60", Slot = "4")]
	[AsyncStateMachine(typeof(MAOIOHNKAGL))]
	public Task<FNFHONNECCC> DAGLDIPPNDO(FNFHONNECCC CLBGLGJCBEB, HLIBNFHHDHM GDJHHHLGCMJ, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6F83150", Offset = "0x6F81D50", VA = "0x186F83150", Slot = "5")]
	[AsyncStateMachine(typeof(PIGGOMADKOK))]
	public Task<FNFHONNECCC> GIIOGBAKOFG(CancellationToken MPLCHGMFENA, HLIBNFHHDHM GDJHHHLGCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6F83630", Offset = "0x6F82230", VA = "0x186F83630", Slot = "6")]
	public EFLENNBPCOG KEJMAADGGEM(FCIIDNJEMOA BKMAKKDNDCB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x6F83400", Offset = "0x6F82000", VA = "0x186F83400", Slot = "7")]
	public EFLENNBPCOG HFIHBKHKBCP(FCIIDNJEMOA BKMAKKDNDCB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6F832A0", Offset = "0x6F81EA0", VA = "0x186F832A0")]
	[AsyncStateMachine(typeof(JHNFHPCLBCH))]
	private Task<FNFHONNECCC> HEKNBBJOFJC(FNFHONNECCC CLBGLGJCBEB, HLIBNFHHDHM GDJHHHLGCMJ, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2974910", Offset = "0x2973510", VA = "0x182974910")]
	private static byte[] IGLHGHHLNIK(FNFHONNECCC JIMAFLGJGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JNIGKFMCFMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class FJLDAOAMNIA : LOBIOOMAFIE, ENGDOEDMANK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private NOODJHPBGLM KBJHEDFJLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private NKKOEDLBBOE OHHJLPAJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private GGKMOCOEPGF KMFIAJEJIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private HHMHLOLAALF FJHKIFNHLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private OOMOCPAFIDB NMLIMFPJBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private CGAIKOHGGAK BPPGADPMEGH;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6F79090", Offset = "0x6F77C90", VA = "0x186F79090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private static FBOKJACJPGA MOLJEBEEKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6F79720", Offset = "0x6F78320", VA = "0x186F79720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6F790E0", Offset = "0x6F77CE0", VA = "0x186F790E0", Slot = "6")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6F79250", Offset = "0x6F77E50", VA = "0x186F79250", Slot = "4")]
	public FBOKJACJPGA EPMMKKIKABD(OICKONADKGK LCJNNBFNDML, OPMNPHPPHHM CMMGCBACION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6F79420", Offset = "0x6F78020", VA = "0x186F79420", Slot = "5")]
	public FBOKJACJPGA LGLANGHPLOE(OICKONADKGK CEFAKBLLGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6F793C0", Offset = "0x6F77FC0", VA = "0x186F793C0")]
	private static FBOKJACJPGA JLKEEDLDGJC(LNPLICNELJJ BGLFCJCCBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FJLDAOAMNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class INBCMOEICKB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6F80600", Offset = "0x6F7F200", VA = "0x186F80600")]
	public INBCMOEICKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6428EA0", Offset = "0x6427AA0", VA = "0x186428EA0")]
	public INBCMOEICKB(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class HMPLLKCOCNP : CCJDJLDLLLH, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct POPOGGCNOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public HMPLLKCOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public ACFFOKBAEJM autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private GDCBCFBEPNI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PKKKDLMLCLJ <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<FBOKJACJPGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E900", Offset = "0x6F8D500", VA = "0x186F8E900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F480", Offset = "0x6F8E080", VA = "0x186F8F480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct POBMGGANIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public HMPLLKCOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E150", Offset = "0x6F8CD50", VA = "0x186F8E150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E8A0", Offset = "0x6F8D4A0", VA = "0x186F8E8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct MEPBMHPGNOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public HMPLLKCOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6F89900", Offset = "0x6F88500", VA = "0x186F89900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6F89E10", Offset = "0x6F88A10", VA = "0x186F89E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct KOKLLMHOFLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public HMPLLKCOCNP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6F86990", Offset = "0x6F85590", VA = "0x186F86990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6F870E0", Offset = "0x6F85CE0", VA = "0x186F870E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct HLOLOPFIKLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public HMPLLKCOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D020", Offset = "0x6F7BC20", VA = "0x186F7D020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D1C0", Offset = "0x6F7BDC0", VA = "0x186F7D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct FABNDIPNJHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public HMPLLKCOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6F78910", Offset = "0x6F77510", VA = "0x186F78910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6F79030", Offset = "0x6F77C30", VA = "0x186F79030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CJMBEDNGMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public HMPLLKCOCNP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6F74880", Offset = "0x6F73480", VA = "0x186F74880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6F74CF0", Offset = "0x6F738F0", VA = "0x186F74CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct NHPACMGIKLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public HMPLLKCOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public CMFFNFFAOGL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private GDCBCFBEPNI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6F8ACF0", Offset = "0x6F898F0", VA = "0x186F8ACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B250", Offset = "0x6F89E50", VA = "0x186F8B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private OLMJDLMENAB MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private GFBHEMMFJBJ NCHHCKCMMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private NKKOEDLBBOE OHHJLPAJNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private OOMOCPAFIDB NMLIMFPJBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource BBHACCLEKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task BGDFFKHLCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> JOOCFBEACHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int HFEGJJDEJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private int DLCCCDFICLL;

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D4F0", Offset = "0x6F7C0F0", VA = "0x186F7D4F0", Slot = "6")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xA603D0", Offset = "0xA5EFD0", VA = "0x180A603D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D220", Offset = "0x6F7BE20", VA = "0x186F7D220")]
	private void AAFNHHFAPCP(float PKIDHAFAEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DD00", Offset = "0x6F7C900", VA = "0x186F7DD00", Slot = "4")]
	[AsyncStateMachine(typeof(POPOGGCNOKF))]
	public Task<FBOKJACJPGA> MLKKGILDFLH(ACFFOKBAEJM GHJLANOPNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E120", Offset = "0x6F7CD20", VA = "0x186F7E120", Slot = "5")]
	[AsyncStateMachine(typeof(POBMGGANIMN))]
	public Task POCLCNKGNJP([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xA603D0", Offset = "0xA5EFD0", VA = "0x180A603D0")]
	public void MLGOLNDGPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DB90", Offset = "0x6F7C790", VA = "0x186F7DB90")]
	private PKKKDLMLCLJ MBLKJICODBG(ACFFOKBAEJM GHJLANOPNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DF40", Offset = "0x6F7CB40", VA = "0x186F7DF40")]
	[AsyncStateMachine(typeof(MEPBMHPGNOB))]
	private Task NPCOMMCIDLO(OJAAINJGBPM KGECOLOELOJ, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D900", Offset = "0x6F7C500", VA = "0x186F7D900")]
	[AsyncStateMachine(typeof(KOKLLMHOFLO))]
	private Task FEHAFJPONID(CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E030", Offset = "0x6F7CC30", VA = "0x186F7E030")]
	[AsyncStateMachine(typeof(HLOLOPFIKLD))]
	private Task PHMFJCKPPIO([Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D400", Offset = "0x6F7C000", VA = "0x186F7D400")]
	[AsyncStateMachine(typeof(FABNDIPNJHK))]
	private Task DPDOMGOGIOL(CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D300", Offset = "0x6F7BF00", VA = "0x186F7D300")]
	[AsyncStateMachine(typeof(CJMBEDNGMMD))]
	private Task DLODANEDBGM(CancellationToken GPFFOIBICJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DA00", Offset = "0x6F7C600", VA = "0x186F7DA00")]
	private Task HGDIBCCLICO(CMFFNFFAOGL IELBOLKNNGD, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7DE30", Offset = "0x6F7CA30", VA = "0x186F7DE30")]
	[AsyncStateMachine(typeof(NHPACMGIKLE))]
	private Task NINGOBEPHMA(CMFFNFFAOGL IELBOLKNNGD, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D6A0", Offset = "0x6F7C2A0", VA = "0x186F7D6A0")]
	private bool EMOPAPOHMNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HMPLLKCOCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class MINNGDKNLCF : GGKMOCOEPGF, ENGDOEDMANK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct CNAPMBKBLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public MINNGDKNLCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private GDCBCFBEPNI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6F74E20", Offset = "0x6F73A20", VA = "0x186F74E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6F75380", Offset = "0x6F73F80", VA = "0x186F75380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private HEKMMDDDNMH MLGHDAPNFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private LOBIOOMAFIE NJIMNCDGLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private GFBHEMMFJBJ NCHHCKCMMHA;

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6F89F40", Offset = "0x6F88B40", VA = "0x186F89F40", Slot = "6")]
	public void EHHLDMLDHNI(OFPJPDGOKAO CAFBHCAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6F89EF0", Offset = "0x6F88AF0", VA = "0x186F89EF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A370", Offset = "0x6F88F70", VA = "0x186F8A370", Slot = "5")]
	[AsyncStateMachine(typeof(CNAPMBKBLAO))]
	public Task KLGHDDIJBDC(string OMBOFKDENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A220", Offset = "0x6F88E20", VA = "0x186F8A220", Slot = "4")]
	public FBOKJACJPGA EMOPAPOHMNE(OICKONADKGK LCJNNBFNDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A280", Offset = "0x6F88E80", VA = "0x186F8A280")]
	private NGBJICFCCFL KDNIMNIDKAF(string OMBOFKDENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MINNGDKNLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class HJEAAFCNGJD
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CBA0", Offset = "0x6F7B7A0", VA = "0x186F7CBA0")]
	public static void HGPDKFLGHHK(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CEC0", Offset = "0x6F7BAC0", VA = "0x186F7CEC0")]
	internal static void OLJOFDEPKPK(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CDE0", Offset = "0x6F7B9E0", VA = "0x186F7CDE0")]
	internal static void IHPHIPIGMEG(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C750", Offset = "0x6F7B350", VA = "0x186F7C750")]
	internal static void DLBNHOPFLAB(LLIMAHMFNLB INBELNINGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class EDLFNLPEMLE : PJLFIJHMNLB<FNFHONNECCC>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class IDLDFGOAMKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public FNFHONNECCC message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IDLDFGOAMKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EBA0", Offset = "0x6F7D7A0", VA = "0x186F7EBA0")]
		internal object EIEBKCCFOIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly EDLFNLPEMLE GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6F761F0", Offset = "0x6F74DF0", VA = "0x186F761F0")]
	public ExitGames.Client.Photon.Hashtable PLFEAILJDFE(FNFHONNECCC JIMAFLGJGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6F75FB0", Offset = "0x6F74BB0", VA = "0x186F75FB0", Slot = "5")]
	protected override void IKFCJBBICLI(FNFHONNECCC JIMAFLGJGFB, IDictionary<object, object> IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6F75AD0", Offset = "0x6F746D0", VA = "0x186F75AD0", Slot = "6")]
	public override FNFHONNECCC EGCBEAACMHC(IDictionary<object, object> IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6F760E0", Offset = "0x6F74CE0", VA = "0x186F760E0")]
	private static void LCOFNOOCLJC(string DFHGMPBBALO, FNFHONNECCC JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6F76320", Offset = "0x6F74F20", VA = "0x186F76320")]
	public EDLFNLPEMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6F75D00", Offset = "0x6F74900", VA = "0x186F75D00")]
	[CompilerGenerated]
	internal static string HGJGOBGJIBJ(IDHGEAOPLAO FAPAFOGIGGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class NACCGJFADGC
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public static FBOKJACJPGA MOLJEBEEKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6F79720", Offset = "0x6F78320", VA = "0x186F79720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6F8ACD0", Offset = "0x6F898D0", VA = "0x186F8ACD0")]
	public static bool HGBEDAMPONJ(this FBOKJACJPGA DGJONDHJOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6F793C0", Offset = "0x6F77FC0", VA = "0x186F793C0")]
	public static FBOKJACJPGA JLKEEDLDGJC(LNPLICNELJJ EPCFCIPBDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AAD0", Offset = "0x6F896D0", VA = "0x186F8AAD0")]
	public static FBOKJACJPGA EHLEADODFKI(IEnumerable<FBOKJACJPGA> NKONCBAGFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A870", Offset = "0x6F89470", VA = "0x186F8A870")]
	public static string DFPPEEEHEFC(this FBOKJACJPGA JFBAIGMLPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class PDACHDGJNIK : KOHMEEHKFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate FBOKJACJPGA LJHNIOEDDPI([NotNull] OICKONADKGK PGJPJIFECEH);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class JHJGLIAMIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public OICKONADKGK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JHJGLIAMIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x6622740", Offset = "0x6621340", VA = "0x186622740")]
		internal FBOKJACJPGA KMEHEBIHLGN(LJHNIOEDDPI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool NGFFCCFEDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	protected readonly HashSet<LJHNIOEDDPI> CALIFOOMNFE;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D4F0", Offset = "0x6F8C0F0", VA = "0x186F8D4F0", Slot = "4")]
	public void NLONOMDEOFH(LJHNIOEDDPI GMOKCBKFBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D1A0", Offset = "0x6F8BDA0", VA = "0x186F8D1A0", Slot = "5")]
	public void CCPEMPKGENE(LJHNIOEDDPI GMOKCBKFBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D200", Offset = "0x6F8BE00", VA = "0x186F8D200", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D250", Offset = "0x6F8BE50", VA = "0x186F8D250")]
	protected FBOKJACJPGA MEOMFDMPOCK(OICKONADKGK CEFAKBLLGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D550", Offset = "0x6F8C150", VA = "0x186F8D550")]
	protected PDACHDGJNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class EPBFAEPLAOP : PDACHDGJNIK, NOODJHPBGLM, KOHMEEHKFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class JGMNOPMOBJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public FBOKJACJPGA result;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JGMNOPMOBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F80F60", Offset = "0x6F7FB60", VA = "0x186F80F60")]
		internal object NKMNKMGEOAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F710F0", Offset = "0x6F6FCF0", VA = "0x186F710F0")]
	[UnityEngine.Scripting.Preserve]
	public EPBFAEPLAOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F78800", Offset = "0x6F77400", VA = "0x186F78800", Slot = "8")]
	public FBOKJACJPGA GDIDJNPJEDP(OICKONADKGK CEFAKBLLGJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class AIPBOLIAFGK : PDACHDGJNIK, HEKMMDDDNMH, KOHMEEHKFGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class GLFJJMBNMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public FBOKJACJPGA result;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GLFJJMBNMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BA80", Offset = "0x6F7A680", VA = "0x186F7BA80")]
		internal object FHMFLKDBNAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F710F0", Offset = "0x6F6FCF0", VA = "0x186F710F0")]
	[UnityEngine.Scripting.Preserve]
	public AIPBOLIAFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F70FE0", Offset = "0x6F6FBE0", VA = "0x186F70FE0", Slot = "8")]
	public FBOKJACJPGA EMOPAPOHMNE(OICKONADKGK COEGBGMLNEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class CALMOLNGKLF
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class MHJDAHEHMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public GDCBCFBEPNI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MHJDAHEHMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F89E70", Offset = "0x6F88A70", VA = "0x186F89E70")]
		internal object ELGKFBIGAAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F74080", Offset = "0x6F72C80", VA = "0x186F74080")]
	public static GDCBCFBEPNI<string> BGAJBOJIDIN(KEDKJKIEEGM MIIBHDDJGII, [Optional] string KFGBLBBEKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F74220", Offset = "0x6F72E20", VA = "0x186F74220")]
	public static void IPONAKMKNCD(GDCBCFBEPNI<string> JKELFCJBEII, KEDKJKIEEGM MIIBHDDJGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F74160", Offset = "0x6F72D60", VA = "0x186F74160")]
	public static string ELGKIMEMENE(FNFHONNECCC KPBJIJCEDMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class KGMHIHPLAGP
{
	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F858B0", Offset = "0x6F844B0", VA = "0x186F858B0")]
	public static void FJJEEKFDKHD(this OLMJDLMENAB MPCOPBMLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F858C0", Offset = "0x6F844C0", VA = "0x186F858C0")]
	public static void MGIALEALAKK(this OLMJDLMENAB MPCOPBMLEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F858D0", Offset = "0x6F844D0", VA = "0x186F858D0")]
	private static void PENHJINPMJD(this OLMJDLMENAB MPCOPBMLEML, bool HKJKIPLAOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class GEFPEKKLPGL : LCBHKHCGLLF, EGMEJFGIDKN, ADMMJKKDGBD, LOGMLALIPNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly EGMEJFGIDKN MNOOFHJBILH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OICKONADKGK ALMALIAEOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B940", Offset = "0x6F7A540", VA = "0x186F7B940", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public int KMLDFDFDGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B990", Offset = "0x6F7A590", VA = "0x186F7B990", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int IIAJIJIIAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B830", Offset = "0x6F7A430", VA = "0x186F7B830", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool KLKLLOMFGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int EJLHGBBKFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event HHDPBOIBCAF.NCNABMNMINP PMLKJDNNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FFEIGMPALPM GGNIBNLPABI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B740", Offset = "0x6F7A340", VA = "0x186F7B740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B8A0", Offset = "0x6F7A4A0", VA = "0x186F7B8A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> HEKDILJOGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<OICKONADKGK> CHPMBEFKLID
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JDGFJPEOEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B9E0", Offset = "0x6F7A5E0", VA = "0x186F7B9E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B6A0", Offset = "0x6F7A2A0", VA = "0x186F7B6A0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xC98650", Offset = "0xC97250", VA = "0x180C98650")]
	public GEFPEKKLPGL(EGMEJFGIDKN MNOOFHJBILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B510", Offset = "0x6F7A110", VA = "0x186F7B510", Slot = "8")]
	public bool ABPACAKLNKA(byte FGGFGGPFKAI, ExitGames.Client.Photon.Hashtable ABAAJNGEGCJ, KAACIGODHHM NDDFJEFJAGH, SendOptions AJPIBCOHPGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B5C0", Offset = "0x6F7A1C0", VA = "0x186F7B5C0", Slot = "16")]
	public OICKONADKGK CHIHGEBMIDF(int DGNNEOOFMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "19")]
	public void AEEGNOEGGHF(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "20")]
	public void IJJBENGAJPA(object FGIAGALCIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "21")]
	public void BPNIGEIEDDF(object FGIAGALCIAP, bool PPPMKKGEHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B7E0", Offset = "0x6F7A3E0", VA = "0x186F7B7E0", Slot = "22")]
	public IDisposable GJJHCLCHNKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "23")]
	private bool NHLEHEJCBLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "24")]
	public void HACPFGJIJNP(StringBuilder HNAFPGMEKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B880", Offset = "0x6F7A480", VA = "0x186F7B880", Slot = "25")]
	public bool IGGHOMPOIEH(bool FMLKHKJJNCB, [Out] string MCOFJPDPPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x95ABF0", Offset = "0x9597F0", VA = "0x18095ABF0", Slot = "28")]
	public void BFCLDBLMPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct KAGLBAEDJPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly IDictionary<object, object> JFEELHKEMNO;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	public KAGLBAEDJPG(IDictionary<object, object> JFEELHKEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F839F0", Offset = "0x6F825F0", VA = "0x186F839F0")]
	public bool JJEPCAELGON([Out] FNFHONNECCC JIMAFLGJGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F83BE0", Offset = "0x6F827E0", VA = "0x186F83BE0")]
	public Guid PKHEFPEKFOL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F83AA0", Offset = "0x6F826A0", VA = "0x186F83AA0")]
	public FBOKJACJPGA KAJNHONMBKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F83900", Offset = "0x6F82500", VA = "0x186F83900")]
	public static ExitGames.Client.Photon.Hashtable GADNMLFOLLL(FNFHONNECCC JIMAFLGJGFB, FBOKJACJPGA DGJONDHJOCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class ANOOLKFGOJN
{
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F71960", Offset = "0x6F70560", VA = "0x186F71960")]
	public static bool JONLLCPJFML(this NJAGFBDJADF MDFMBBLPOPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct MLPLAPJKJGL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct MDHGCPOKFFN : IAsyncStateMachine
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
		public MLPLAPJKJGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F896C0", Offset = "0x6F882C0", VA = "0x186F896C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F898A0", Offset = "0x6F884A0", VA = "0x186F898A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CancellationTokenSource BMBBMOBAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private bool NGFFCCFEDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private Task HPIAAAJAFJD;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GKFNCCNFNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A4C0", Offset = "0x6F890C0", VA = "0x186F8A4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A600", Offset = "0x6F89200", VA = "0x186F8A600")]
	public MLPLAPJKJGL(CancellationToken MPLCHGMFENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A4F0", Offset = "0x6F890F0", VA = "0x186F8A4F0")]
	[AsyncStateMachine(typeof(MDHGCPOKFFN))]
	public Task NFEHIBMHFGI(Func<CancellationToken, List<Task>> KMFDHDAECEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A470", Offset = "0x6F89070", VA = "0x186F8A470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct ODGJDDGHBPI<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct KCKDCMGMIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<IDCLJKNKGLH<TData>, DICIKJENGEG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public ODGJDDGHBPI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<GFFELLBKJIA<IDCLJKNKGLH<TData>, DICIKJENGEG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x4130440", Offset = "0x412F040", VA = "0x184130440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B969F0", Offset = "0x3B955F0", VA = "0x183B969F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly JHIOGODAFCO<TGetDataArg, TData> KJMCLGOJKLB;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	internal ODGJDDGHBPI(JHIOGODAFCO<TGetDataArg, TData> CFCALMONEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x4573470", Offset = "0x4572070", VA = "0x184573470")]
	[AsyncStateMachine(typeof(ODGJDDGHBPI<, >.KCKDCMGMIMD))]
	public Task<GFFELLBKJIA<IDCLJKNKGLH<TData>, DICIKJENGEG>> FEKCIFNKNFA(TGetDataArg KDGMEPEFEJC, string OLEKDAAHCBA, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class CJHDGIKNINE
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x255B2F0", Offset = "0x2559EF0", VA = "0x18255B2F0")]
	public static ODGJDDGHBPI<TGetDataArg, TData> PPOPBMPFEOP<TGetDataArg, TData>(JHIOGODAFCO<TGetDataArg, TData> CFCALMONEJL)
	{
		return default(ODGJDDGHBPI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct MMBCKMLDDKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int BGOPHJDOJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public readonly int? KHCGDKMPACE;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x41E2C20", Offset = "0x41E1820", VA = "0x1841E2C20")]
	public MMBCKMLDDKA(int FMEADDKOFED, [Optional] int? AANIPMBELAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A730", Offset = "0x6F89330", VA = "0x186F8A730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface NBFMKJGOGMH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDDEGLCLMFL();

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBFMKJGOGMH<T> JIONIKCJKEG(string DIIKHOHHLDK);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBFMKJGOGMH<T> OCPHIKJEIGG(KLFKFGIHCFB<T> AAGGCFHKBAA);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBFMKJGOGMH<T> NMGGELIOPDL(int PFGMABBCMAM);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBFMKJGOGMH<T> BPFCCLCGNAK(int PFGMABBCMAM, HBNCNHDPGHA<T> ENAKJPHKIPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface MMAPHKALPKN
{
	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBFMKJGOGMH<T> GNIMLOINPMN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OAPIMEIBHHI OJDPEBNEPIK(Exception JNLFEIJKPEF);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMBCKMLDDKA OCPOEIFCJIA(Exception JNLFEIJKPEF);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string KLFKFGIHCFB<in T>(T JNLFEIJKPEF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int HBNCNHDPGHA<in T>(T JNLFEIJKPEF) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class GDIOIEPGIMP : MMAPHKALPKN
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string KEMJOCNHADF(Exception JNLFEIJKPEF);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int CNLLMBHIOGG(Exception JNLFEIJKPEF);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class JBEGKOMDJIA<T> : NBFMKJGOGMH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class NPNKFOKFALG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public NPNKFOKFALG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			internal string IPGFMNMEDDK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class BIBNEIFMPJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public KLFKFGIHCFB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BIBNEIFMPJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x420B840", Offset = "0x420A440", VA = "0x18420B840")]
			internal string NDMBOHNDJBK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class LIPLPIHALAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public HBNCNHDPGHA<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public LIPLPIHALAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x420B840", Offset = "0x420A440", VA = "0x18420B840")]
			internal int IJBAGPBDDNH(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly GDIOIEPGIMP KCIOKMJKIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Type PKLAOGCKOEB;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x400FAC0", Offset = "0x400E6C0", VA = "0x18400FAC0")]
		internal JBEGKOMDJIA(GDIOIEPGIMP KCIOKMJKIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x400F810", Offset = "0x400E410", VA = "0x18400F810", Slot = "4")]
		public void EDDEGLCLMFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x400F840", Offset = "0x400E440", VA = "0x18400F840", Slot = "5")]
		public NBFMKJGOGMH<T> JIONIKCJKEG(string DIIKHOHHLDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x400F9A0", Offset = "0x400E5A0", VA = "0x18400F9A0", Slot = "6")]
		public NBFMKJGOGMH<T> OCPHIKJEIGG(KLFKFGIHCFB<T> AAGGCFHKBAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x400F960", Offset = "0x400E560", VA = "0x18400F960", Slot = "7")]
		public NBFMKJGOGMH<T> NMGGELIOPDL(int PFGMABBCMAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x400F6E0", Offset = "0x400E2E0", VA = "0x18400F6E0", Slot = "8")]
		public NBFMKJGOGMH<T> BPFCCLCGNAK(int PFGMABBCMAM, HBNCNHDPGHA<T> ENAKJPHKIPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class AAAHADOPNMH<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool NOFLKAADBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly List<Type> HHGJPPFBPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, TVal> HEHOJKCMLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Dictionary<Type, int> FEAGEBPBIPM;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public IReadOnlyList<Type> LCDGLFNPICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x3C2B810", Offset = "0x3C2A410", VA = "0x183C2B810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BE20", Offset = "0x3C2AA20", VA = "0x183C2BE20")]
		public AAAHADOPNMH(Dictionary<Type, int> FEAGEBPBIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BC00", Offset = "0x3C2A800", VA = "0x183C2BC00")]
		public void MPFJKDGCCNN(Type DPHIOKCFMFC, TVal CLJFFIBMODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BCB0", Offset = "0x3C2A8B0", VA = "0x183C2BCB0")]
		public bool NIFPFNNBBCH(Type PKLAOGCKOEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BB00", Offset = "0x3C2A700", VA = "0x183C2BB00")]
		public bool KDIGHAFIHNG(TVal GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BAB0", Offset = "0x3C2A6B0", VA = "0x183C2BAB0")]
		public TVal HCNFCFFAFEI(Type NCNNODEFPOG)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BA10", Offset = "0x3C2A610", VA = "0x183C2BA10")]
		[CompilerGenerated]
		private int EBOEMCCCFDK(Type BPFEFDHDPHN, Type FECKOGCLGGH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class AMDELFLLKEN : IEnumerable<MMBCKMLDDKA>, IEnumerable, IEnumerator<MMBCKMLDDKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private MMBCKMLDDKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public GDIOIEPGIMP <>4__this;

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
		private IEnumerator<MMBCKMLDDKA> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		private MMBCKMLDDKA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x387CA10", Offset = "0x387B610", VA = "0x18387CA10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MMBCKMLDDKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x6F717C0", Offset = "0x6F703C0", VA = "0x186F717C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public AMDELFLLKEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6F71810", Offset = "0x6F70410", VA = "0x186F71810", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6F71210", Offset = "0x6F6FE10", VA = "0x186F71210", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6F711C0", Offset = "0x6F6FDC0", VA = "0x186F711C0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6F71170", Offset = "0x6F6FD70", VA = "0x186F71170")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x6F71770", Offset = "0x6F70370", VA = "0x186F71770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6F716B0", Offset = "0x6F702B0", VA = "0x186F716B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MMBCKMLDDKA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x6F716B0", Offset = "0x6F702B0", VA = "0x186F716B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly MMBCKMLDDKA KNDNOIGHHCD;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private static readonly Dictionary<Type, int> ELKGNCEABMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly HashSet<Type> ONJFPMEHAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly AAAHADOPNMH<int> GKLLAAHGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly AAAHADOPNMH<CNLLMBHIOGG> EMJCHFCKCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly AAAHADOPNMH<KEMJOCNHADF> HLNJIFIKCFO;

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A3A0", Offset = "0x6F78FA0", VA = "0x186F7A3A0")]
	[FJJFAIMPJIC(JBEKPLNNIEC.GameOnly)]
	private static void GBNHEMCAJHC(LLIMAHMFNLB IADIMANELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B1D0", Offset = "0x6F79DD0", VA = "0x186F7B1D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDIOIEPGIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60", Slot = "4")]
	public NBFMKJGOGMH<T> GNIMLOINPMN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B070", Offset = "0x6F79C70", VA = "0x186F7B070", Slot = "5")]
	public OAPIMEIBHHI OJDPEBNEPIK(Exception JNLFEIJKPEF)
	{
		return default(OAPIMEIBHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AE70", Offset = "0x6F79A70", VA = "0x186F7AE70", Slot = "6")]
	public MMBCKMLDDKA OCPOEIFCJIA(Exception? JNLFEIJKPEF)
	{
		return default(MMBCKMLDDKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F79DD0", Offset = "0x6F789D0", VA = "0x186F79DD0", Slot = "7")]
	[IteratorStateMachine(typeof(AMDELFLLKEN))]
	public IEnumerable<MMBCKMLDDKA> ANDEIHBFEIP(Exception JNLFEIJKPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AAD0", Offset = "0x6F796D0", VA = "0x186F7AAD0", Slot = "8")]
	public string MENOCEELADC(Exception? JNLFEIJKPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A6E0", Offset = "0x6F792E0", VA = "0x186F7A6E0")]
	private string IOMCANGKGDO(AggregateException IICCFKHBOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F79E70", Offset = "0x6F78A70", VA = "0x186F79E70")]
	private void DBGKCOEFDBL(Type PKLAOGCKOEB, int PFGMABBCMAM, CNLLMBHIOGG? OGOFBALDLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AC20", Offset = "0x6F79820", VA = "0x186F7AC20")]
	private void MJMMJDBACJB(Type PKLAOGCKOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A410", Offset = "0x6F79010", VA = "0x186F7A410")]
	private void GMELNGFPFHF(Type PKLAOGCKOEB, KEMJOCNHADF EEMHIJEMOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A220", Offset = "0x6F78E20", VA = "0x186F7A220")]
	private static int EAIDJOEHMGB(Type PKLAOGCKOEB, Dictionary<Type, int> FEAGEBPBIPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2B0B880", Offset = "0x2B0A480", VA = "0x182B0B880")]
	private static bool MHPFDDHKEOA<TVal>(AAAHADOPNMH<TVal> DJGHJNNEKKN, Type PKLAOGCKOEB, [Out] TVal GLMEMJNJKAN) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A9F0", Offset = "0x6F795F0", VA = "0x186F7A9F0")]
	[CompilerGenerated]
	internal static int IPOMNGMPLLM(Type IKJKPBFMCCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct OAPIMEIBHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly MMBCKMLDDKA HNPAIAAMNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public readonly string IFBNEDBMANK;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B840", Offset = "0x6F8A440", VA = "0x186F8B840")]
	public OAPIMEIBHHI(string PBPPLELICPF, MMBCKMLDDKA PFGMABBCMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B7A0", Offset = "0x6F8A3A0", VA = "0x186F8B7A0")]
	public string IMDLPKNKGAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class EKDPFEKGPHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly IAJFHEPFFKH FLNJGOPEBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private string GKGEGJJNNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? IPOMEGCEIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? BKCOBLCPEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? CLIPABOOIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private string AOJDFONCNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private FNBHJFNPAHD IBDFGGNACOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private long? LAGAJMKMJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool NFMJBPENLFG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string ADCCHHPADIE
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public long CCMGGODGIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6F78460", Offset = "0x6F77060", VA = "0x186F78460")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public long ODICHBCABME
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6F78320", Offset = "0x6F76F20", VA = "0x186F78320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long ABEMOFFGPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F78540", Offset = "0x6F77140", VA = "0x186F78540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string BAJPBBJGFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x6F78380", Offset = "0x6F76F80", VA = "0x186F78380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public FNBHJFNPAHD DAHAGEKJEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xEF4D20", Offset = "0xEF3920", VA = "0x180EF4D20")]
		get
		{
			return default(FNBHJFNPAHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6F781D0", Offset = "0x6F76DD0", VA = "0x186F781D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public long DHHABMFLKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F782C0", Offset = "0x6F76EC0", VA = "0x186F782C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6F785A0", Offset = "0x6F771A0", VA = "0x186F785A0")]
	[UnityEngine.Scripting.Preserve]
	public EKDPFEKGPHI([GOICEJLKLIB(null)] IAJFHEPFFKH FLNJGOPEBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6F77F80", Offset = "0x6F76B80", VA = "0x186F77F80")]
	private void COAKLFMKIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6F77770", Offset = "0x6F76370", VA = "0x186F77770")]
	public void BKGGOMIDKOO(long NBIMAGPPMDN, long JJFCFIMNPNM, [Optional] long? NFDNNKBLGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6F783C0", Offset = "0x6F76FC0", VA = "0x186F783C0")]
	public void MOOLELJDJMG(long NFDNNKBLGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6F784C0", Offset = "0x6F770C0", VA = "0x186F784C0")]
	public void OLGEKLDNMEJ(string GMINGLOEBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6F77C00", Offset = "0x6F76800", VA = "0x186F77C00")]
	public void BMGADBPFDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class EFLENNBPCOG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CBDGGEKKDIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public FNFHONNECCC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public EFLENNBPCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<PJJBGFJNFKD.MEHDAHLHBDI<FNFHONNECCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6F742E0", Offset = "0x6F72EE0", VA = "0x186F742E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6F74810", Offset = "0x6F73410", VA = "0x186F74810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct ENDLBFLHJCK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class IICHAKJOOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public FNFHONNECCC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IICHAKJOOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F020", Offset = "0x6F7DC20", VA = "0x186F7F020")]
		internal FNFHONNECCC AMBBOMMNDMM(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct HAFNMEEJJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder<PJJBGFJNFKD.MEHDAHLHBDI<FNFHONNECCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public FNFHONNECCC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public EFLENNBPCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private CNCIMBCOJCP <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<PJJBGFJNFKD.MEHDAHLHBDI<FNFHONNECCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BAE0", Offset = "0x6F7A6E0", VA = "0x186F7BAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C0F0", Offset = "0x6F7ACF0", VA = "0x186F7C0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct DMMKMDFPOCN<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public EFLENNBPCOG <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x57F3590", Offset = "0x57F2190", VA = "0x1857F3590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x353E2A0", Offset = "0x353CEA0", VA = "0x18353E2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct EKFIEGMLFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EFLENNBPCOG <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x6F785E0", Offset = "0x6F771E0", VA = "0x186F785E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x6F787A0", Offset = "0x6F773A0", VA = "0x186F787A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class IFNGAKJIMFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IFNGAKJIMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EFC0", Offset = "0x6F7DBC0", VA = "0x186F7EFC0")]
		internal object POFGBLHBBKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EF00", Offset = "0x6F7DB00", VA = "0x186F7EF00")]
		internal bool OEIHOHCGLOC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class FJONLDCAKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FJONLDCAKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6F79780", Offset = "0x6F78380", VA = "0x186F79780")]
		internal object HNBFMNDDCJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class CMGMNPNFHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CMGMNPNFHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6F74DB0", Offset = "0x6F739B0", VA = "0x186F74DB0")]
		internal object EBBCNIEGKKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class DAPCJBDJPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DAPCJBDJPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6F75530", Offset = "0x6F74130", VA = "0x186F75530")]
		internal object EPOMOEAKGHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class LJJBLFPJHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public EFLENNBPCOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LJJBLFPJHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6F87560", Offset = "0x6F86160", VA = "0x186F87560")]
		internal object EIEBKCCFOIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Guid MHFKBEKLKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly FCIIDNJEMOA NHGNLJLPBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly PJJBGFJNFKD MJOOOPAMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly ADMMJKKDGBD MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly LOGMLALIPNJ FLPHLCOKKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private bool FMGLLKHIDCL;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6F77430", Offset = "0x6F76030", VA = "0x186F77430")]
	public EFLENNBPCOG(FCIIDNJEMOA PIJDNDPDOCK, PJJBGFJNFKD MJOOOPAMENJ, ADMMJKKDGBD MPCOPBMLEML, LOGMLALIPNJ FLPHLCOKKII, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6F767C0", Offset = "0x6F753C0", VA = "0x186F767C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6F767C0", Offset = "0x6F753C0", VA = "0x186F767C0")]
	public void OODDANOHDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6F765A0", Offset = "0x6F751A0", VA = "0x186F765A0")]
	public void CAAMPGCHIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6F76F90", Offset = "0x6F75B90", VA = "0x186F76F90")]
	public void NKLJJAAJCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6F77260", Offset = "0x6F75E60", VA = "0x186F77260")]
	[AsyncStateMachine(typeof(CBDGGEKKDIP))]
	internal Task<FNFHONNECCC> PHMDAKMDNLK(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, FNFHONNECCC KPBJIJCEDMJ, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2974910", Offset = "0x2973510", VA = "0x182974910")]
	private static byte[] NNGEHPNGCFK<T>(T JIMAFLGJGFB) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x29747C0", Offset = "0x29733C0", VA = "0x1829747C0")]
	private static T JPIENKOFCJC<T>(MessageParser<T> AIOIANOFCGH, byte[] JIMAFLGJGFB, T NBCBLAAHNCF) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6F77120", Offset = "0x6F75D20", VA = "0x186F77120")]
	[AsyncStateMachine(typeof(HAFNMEEJJGA))]
	private Task<PJJBGFJNFKD.MEHDAHLHBDI<FNFHONNECCC>> PFLGPMGGOLC(FNFHONNECCC KPBJIJCEDMJ, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2974180", Offset = "0x2972D80", VA = "0x182974180")]
	[AsyncStateMachine(typeof(DMMKMDFPOCN<>))]
	internal Task<T> BDMICALPONM<T>(CancellationToken DDPMOBGAIPN, Func<CancellationToken, Task<T>> PHOIJGBKMDC, int LGNFLAEHFJD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6F76470", Offset = "0x6F75070", VA = "0x186F76470")]
	[AsyncStateMachine(typeof(EKFIEGMLFPL))]
	internal Task BDMICALPONM(CancellationToken DDPMOBGAIPN, Func<CancellationToken, Task> PHOIJGBKMDC, int LGNFLAEHFJD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6F76F10", Offset = "0x6F75B10", VA = "0x186F76F10")]
	public ADBAIIHAEHH MIEINLOJDLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6F770A0", Offset = "0x6F75CA0", VA = "0x186F770A0")]
	public LPJKLKHELAI OKPELGPNDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6F769F0", Offset = "0x6F755F0", VA = "0x186F769F0")]
	public MJJMCHAHOKK JMCKLGEBMMJ([Optional] KEDKJKIEEGM? MIIBHDDJGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6F76660", Offset = "0x6F75260", VA = "0x186F76660")]
	public void CHJIHEDPBGJ(Func<Guid, bool> HOFFNEKJIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6F76360", Offset = "0x6F74F60", VA = "0x186F76360")]
	public void AILAOJPPPOG(Func<Guid, bool> OMAHLFOJOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6F76B40", Offset = "0x6F75740", VA = "0x186F76B40")]
	public Guid JOIEPNPLKMF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F768E0", Offset = "0x6F754E0", VA = "0x186F768E0")]
	public void JDIPLGLJGKP(Guid HOMPIBFLCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6F76CC0", Offset = "0x6F758C0", VA = "0x186F76CC0")]
	public void KGEKHDJPCGA(FNFHONNECCC MFJFAJCJACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6F76E00", Offset = "0x6F75A00", VA = "0x186F76E00")]
	public void LCOFNOOCLJC(string FOCGDBIGODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2974420", Offset = "0x2973020", VA = "0x182974420")]
	private T GPOLCJJPBML<T>(T GLMEMJNJKAN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6F77050", Offset = "0x6F75C50", VA = "0x186F77050")]
	public void OBEBINNMACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2974510", Offset = "0x2973110", VA = "0x182974510")]
	[CompilerGenerated]
	internal static string JBLFMEJMDHH<T>(byte[] HNGDLLNOPEB, int HLCPHBIOAAI, ENDLBFLHJCK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class AHPJFFADIHL : FCIIDNJEMOA
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class OHGNOGBKLIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OHGNOGBKLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3130", Offset = "0x6FA1D30", VA = "0x186FA3130")]
		internal object JLPMHPFODPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FKNMACHKEDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public AHPJFFADIHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private BEMAMOPOJJM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private LPJKLKHELAI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x6F95FB0", Offset = "0x6F94BB0", VA = "0x186F95FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6F96880", Offset = "0x6F95480", VA = "0x186F96880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct ADALGADKOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public AHPJFFADIHL <>4__this;

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
		private TaskAwaiter<FMLBFFJHFNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6F90BF0", Offset = "0x6F8F7F0", VA = "0x186F90BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6F913A0", Offset = "0x6F8FFA0", VA = "0x186F913A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct KICKLFPIJII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public AHPJFFADIHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<LKAHMCOOOOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B5F0", Offset = "0x6F9A1F0", VA = "0x186F9B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B900", Offset = "0x6F9A500", VA = "0x186F9B900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class LKPFKPGFMDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public BEMAMOPOJJM presence;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LKPFKPGFMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D820", Offset = "0x6F9C420", VA = "0x186F9D820")]
		internal object MKABDLKIHAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly KEDKJKIEEGM CNOOBMOEDOE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly KEDKJKIEEGM NMFOAEOHEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly IDHGEAOPLAO BGCHEPNMKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly NJAGFBDJADF IMIJBBNMDFL;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6F91A10", Offset = "0x6F90610", VA = "0x186F91A10")]
	public AHPJFFADIHL(IDHGEAOPLAO BGCHEPNMKLN, NJAGFBDJADF IMIJBBNMDFL, Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, HLIBNFHHDHM OKINKCNHAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F91400", Offset = "0x6F90000", VA = "0x186F91400", Slot = "7")]
	[AsyncStateMachine(typeof(FKNMACHKEDK))]
	protected override Task JOEHHBLIFFG(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F91540", Offset = "0x6F90140", VA = "0x186F91540")]
	[AsyncStateMachine(typeof(ADALGADKOGI))]
	private Task MIFLNAOOHMB(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F91640", Offset = "0x6F90240", VA = "0x186F91640")]
	[AsyncStateMachine(typeof(KICKLFPIJII))]
	private Task<byte> OFKEOFENJLG(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F91750", Offset = "0x6F90350", VA = "0x186F91750")]
	private BEMAMOPOJJM PDJGHGJIBEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class PKKKDLMLCLJ : FCIIDNJEMOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct EIBKEOCBNJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public PKKKDLMLCLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter<DCMHOOJOMED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6F935D0", Offset = "0x6F921D0", VA = "0x186F935D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x6F93F50", Offset = "0x6F92B50", VA = "0x186F93F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly int EGLBKMGJCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly ACFFOKBAEJM EICCBKKAPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long HDLBFFFLPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public readonly long OGJAPJMEPNK;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DCMHOOJOMED MFMLAMOFAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x8514C0", Offset = "0x8500C0", VA = "0x1808514C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x851530", Offset = "0x850130", VA = "0x180851530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7130", Offset = "0x6FA5D30", VA = "0x186FA7130")]
	public PKKKDLMLCLJ(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, HLIBNFHHDHM OKINKCNHAFB, int EGLBKMGJCJB, ACFFOKBAEJM EICCBKKAPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7010", Offset = "0x6FA5C10", VA = "0x186FA7010", Slot = "7")]
	[AsyncStateMachine(typeof(EIBKEOCBNJM))]
	protected override Task JOEHHBLIFFG(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class PLMLJDHNPBI : FCIIDNJEMOA
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class GEFHLNPJCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public PLMLJDHNPBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public IOAMDEPLAHB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GEFHLNPJCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6F97A00", Offset = "0x6F96600", VA = "0x186F97A00")]
		internal Task EDINOPNODDM(GDCBCFBEPNI<string>.LHHFCPKIPMG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6F97A40", Offset = "0x6F96640", VA = "0x186F97A40")]
		internal object KJCOFNKPHNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct JBOGBDEONAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public PLMLJDHNPBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private GEFHLNPJCAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6F99EF0", Offset = "0x6F98AF0", VA = "0x186F99EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A6B0", Offset = "0x6F992B0", VA = "0x186F9A6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct BCBBPPBADPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public IOAMDEPLAHB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public PLMLJDHNPBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x6F91BA0", Offset = "0x6F907A0", VA = "0x186F91BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x6F92130", Offset = "0x6F90D30", VA = "0x186F92130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6FA74E0", Offset = "0x6FA60E0", VA = "0x186FA74E0")]
	public PLMLJDHNPBI(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, HLIBNFHHDHM OKINKCNHAFB, string FPOPODGAJBG, NJEMEGLNDCA NMCAEILPPGB, bool AEIGKJLFMDN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6FA73A0", Offset = "0x6FA5FA0", VA = "0x186FA73A0", Slot = "7")]
	[AsyncStateMachine(typeof(JBOGBDEONAL))]
	protected override Task JOEHHBLIFFG(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task AKMEMMEGNJJ(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6FA7260", Offset = "0x6FA5E60", VA = "0x186FA7260")]
	[AsyncStateMachine(typeof(BCBBPPBADPO))]
	private Task EMKKIHCFOPG(IDisposable ENMDCEEIKPO, IOAMDEPLAHB BIGMIADEPKI, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class DDINCMDLCDP : FCIIDNJEMOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct CMHBCNHLIJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public DDINCMDLCDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public EFLENNBPCOG operationContext;

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
		private TaskAwaiter<CCHFEGBILNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x6F92A60", Offset = "0x6F91660", VA = "0x186F92A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6F92FD0", Offset = "0x6F91BD0", VA = "0x186F92FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly CMFFNFFAOGL IELBOLKNNGD;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6F93230", Offset = "0x6F91E30", VA = "0x186F93230")]
	public DDINCMDLCDP(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, HLIBNFHHDHM OKINKCNHAFB, CMFFNFFAOGL IELBOLKNNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6F93030", Offset = "0x6F91C30", VA = "0x186F93030", Slot = "6")]
	protected override string BCAMPGHKPLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6F93110", Offset = "0x6F91D10", VA = "0x186F93110", Slot = "7")]
	[AsyncStateMachine(typeof(CMHBCNHLIJK))]
	protected override Task JOEHHBLIFFG(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class FCIIDNJEMOA : BLBECLBEDNO
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task HFGBBLBJEED(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class JJEEMNDBIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public FCIIDNJEMOA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JJEEMNDBIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AD20", Offset = "0x6F99920", VA = "0x186F9AD20")]
		internal Task FJELHGFEJFF(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class HMEDAMLMLKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public JJEEMNDBIED CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HMEDAMLMLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F98290", Offset = "0x6F96E90", VA = "0x186F98290")]
		internal object CJANDEFJDHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct HPHEGHILOJA : IAsyncStateMachine
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
		public FCIIDNJEMOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Func<FCIIDNJEMOA, GDCBCFBEPNI<string>.LHHFCPKIPMG, EFLENNBPCOG> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private JJEEMNDBIED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EFLENNBPCOG <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<FNFHONNECCC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F98350", Offset = "0x6F96F50", VA = "0x186F98350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F99450", Offset = "0x6F98050", VA = "0x186F99450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct ENLOJPIOHJN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F94160", Offset = "0x6F92D60", VA = "0x186F94160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F94BF0", Offset = "0x6F937F0", VA = "0x186F94BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct PFMACAPNBGI : IAsyncStateMachine
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
		public FCIIDNJEMOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA69D0", Offset = "0x6FA55D0", VA = "0x186FA69D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6D30", Offset = "0x6FA5930", VA = "0x186FA6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly Guid JIMBGNGJJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly ByteString PCAHBKEDBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly HLIBNFHHDHM ELBOEPOHEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected readonly string GDGIMIPEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly bool AEIGKJLFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly Queue<HFGBBLBJEED> FOHIKLGNOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly OEPEJKPKKLA GBIIPFAKHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly NJEMEGLNDCA NMCAEILPPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private bool DMKNHCIKKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public FNBHJFNPAHD LCCCFOBKKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public FNBHJFNPAHD NOGPMCCANPN;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public OFPJPDGOKAO IOHNAIINCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x6F95340", Offset = "0x6F93F40", VA = "0x186F95340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KCCKNNHBECO PPHPFJNLBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x6F94F00", Offset = "0x6F93B00", VA = "0x186F94F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6F94E80", Offset = "0x6F93A80", VA = "0x186F94E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LFPDMHJFFCL DIEMGCJLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6F953B0", Offset = "0x6F93FB0", VA = "0x186F953B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6F94F50", Offset = "0x6F93B50", VA = "0x186F94F50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6F95680", Offset = "0x6F94280", VA = "0x186F95680")]
	protected FCIIDNJEMOA(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, HLIBNFHHDHM OKINKCNHAFB, string FPOPODGAJBG, NJEMEGLNDCA NMCAEILPPGB, bool AEIGKJLFMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6F94C50", Offset = "0x6F93850", VA = "0x186F94C50", Slot = "6")]
	protected virtual string BCAMPGHKPLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6F95620", Offset = "0x6F94220", VA = "0x186F95620")]
	public void PMNLAIEFJPD(HFGBBLBJEED PLHMBOBMHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6F95390", Offset = "0x6F93F90", VA = "0x186F95390")]
	protected void MINEADFFCOF(float GEBOGBKBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6F951F0", Offset = "0x6F93DF0", VA = "0x186F951F0")]
	[AsyncStateMachine(typeof(HPHEGHILOJA))]
	public Task JHMLCEABGGF(CancellationToken MPLCHGMFENA, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, [Optional] Func<FCIIDNJEMOA, GDCBCFBEPNI<string>.LHHFCPKIPMG, EFLENNBPCOG> NELINIEEGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6F953D0", Offset = "0x6F93FD0", VA = "0x186F953D0")]
	[AsyncStateMachine(typeof(ENLOJPIOHJN))]
	private static Task NPDGFBEILJD(Func<CancellationToken, Task> NGBDLFCLEPG, Func<CancellationToken, Task> DDIMNLJCFLL, CancellationToken DDPMOBGAIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6F94C90", Offset = "0x6F93890", VA = "0x186F94C90")]
	private void BEBIMKLOBEJ(bool BCJBOMDKMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F950E0", Offset = "0x6F93CE0", VA = "0x186F950E0")]
	private void JBCBAGBJAKJ(EFLENNBPCOG IAEAGLKGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task JOEHHBLIFFG(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F95500", Offset = "0x6F94100", VA = "0x186F95500")]
	[AsyncStateMachine(typeof(PFMACAPNBGI))]
	private Task PJKDGFEDPDF(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F94E00", Offset = "0x6F93A00", VA = "0x186F94E00")]
	public FNFHONNECCC BLLJKBPNFOA(CNCIMBCOJCP AEBECIMLLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F94F70", Offset = "0x6F93B70", VA = "0x186F94F70")]
	[CompilerGenerated]
	private Task HNECAKEIAHF(CancellationToken NEAJEANMBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F95060", Offset = "0x6F93C60", VA = "0x186F95060")]
	[CompilerGenerated]
	private object IDBACONCDMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class IMNANBFJKMI : PLMLJDHNPBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct OJBGFEDILMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public IMNANBFJKMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private IHIJMGLMGDF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private LPJKLKHELAI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4120", Offset = "0x6FA2D20", VA = "0x186FA4120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4890", Offset = "0x6FA3490", VA = "0x186FA4890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly IDHGEAOPLAO AAPAAGEOGCG;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F99950", Offset = "0x6F98550", VA = "0x186F99950")]
	public IMNANBFJKMI(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, IDHGEAOPLAO AAPAAGEOGCG, HLIBNFHHDHM OKINKCNHAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F99800", Offset = "0x6F98400", VA = "0x186F99800", Slot = "8")]
	[AsyncStateMachine(typeof(OJBGFEDILMG))]
	protected override Task AKMEMMEGNJJ(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class NGBJICFCCFL : FCIIDNJEMOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct KEFNGENFLFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public NGBJICFCCFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<CCHFEGBILNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B1E0", Offset = "0x6F99DE0", VA = "0x186F9B1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B590", Offset = "0x6F9A190", VA = "0x186F9B590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly string KBNDGOFAOGI;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1BD0", Offset = "0x6FA07D0", VA = "0x186FA1BD0")]
	public NGBJICFCCFL(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, HLIBNFHHDHM OKINKCNHAFB, string KBNDGOFAOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1AC0", Offset = "0x6FA06C0", VA = "0x186FA1AC0", Slot = "7")]
	[AsyncStateMachine(typeof(KEFNGENFLFP))]
	protected override Task JOEHHBLIFFG(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class LMHPHGJDLLC : PLMLJDHNPBI
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class PLNAHMEONDJ
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
			public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public PLNAHMEONDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<CCHFEGBILNH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<FNFHONNECCC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8BA0", Offset = "0x6FA77A0", VA = "0x186FA8BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x6FA9060", Offset = "0x6FA7C60", VA = "0x186FA9060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public LMHPHGJDLLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public MJJMCHAHOKK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public IBBGFNFNCJB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public ADBAIIHAEHH uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public GNEKNEMHKHJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PLNAHMEONDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7530", Offset = "0x6FA6130", VA = "0x186FA7530")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<FNFHONNECCC> LKGKHGGEPBG(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct GBBDBJEEHDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public LMHPHGJDLLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private PLNAHMEONDJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private IHIJMGLMGDF <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private LPJKLKHELAI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private FNFHONNECCC <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F96A40", Offset = "0x6F95640", VA = "0x186F96A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F979A0", Offset = "0x6F965A0", VA = "0x186F979A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly KEDKJKIEEGM CNOOBMOEDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private readonly int JIILLLIPEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	[CanBeNull]
	private readonly JLMHDEAJDIF EHAFNJGCMAN;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DE20", Offset = "0x6F9CA20", VA = "0x186F9DE20")]
	public LMHPHGJDLLC(Guid AMMGFMLLGCP, OFPJPDGOKAO CAFBHCAHEEK, int JIILLLIPEFM, JLMHDEAJDIF EHAFNJGCMAN, HLIBNFHHDHM OKINKCNHAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D960", Offset = "0x6F9C560", VA = "0x186F9D960", Slot = "8")]
	[AsyncStateMachine(typeof(GBBDBJEEHDP))]
	protected override Task AKMEMMEGNJJ(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DAA0", Offset = "0x6F9C6A0", VA = "0x186F9DAA0")]
	private void NPEEFEPAKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DBA0", Offset = "0x6F9C7A0", VA = "0x186F9DBA0")]
	private void ONNHBHGICIL(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, IHIJMGLMGDF KNHDFBPPOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class FNPOODPMHMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly FCIIDNJEMOA NHGNLJLPBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly EFLENNBPCOG OGDCGOJGCJB;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F96970", Offset = "0x6F95570", VA = "0x186F96970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F968E0", Offset = "0x6F954E0", VA = "0x186F968E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F969E0", Offset = "0x6F955E0", VA = "0x186F969E0")]
	protected FNPOODPMHMK(EFLENNBPCOG IAEAGLKGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F969C0", Offset = "0x6F955C0", VA = "0x186F969C0")]
	protected void LCOFNOOCLJC(string FOCGDBIGODM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct JJBDFKJHIJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<CDCGAHFDKJJ>> JBDICOAJMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public Dictionary<Guid, List<CDCGAHFDKJJ>> KOEAPOLPGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public Dictionary<Guid, List<CDCGAHFDKJJ>> PIBMNIEFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public List<Guid> POPHGKOBHFC;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A710", Offset = "0x6F99310", VA = "0x186F9A710")]
	public static JJBDFKJHIJK HCNFCFFAFEI(FIOCLCPFJCF KHAIJLCNIAO, FNBHJFNPAHD NIMBBJPPGGG, OJAAINJGBPM JJHNDPDKFAO)
	{
		return default(JJBDFKJHIJK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct LIBAGHDAKPE
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	public static LIBAGHDAKPE GADNMLFOLLL()
	{
		return default(LIBAGHDAKPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct NHJGKMDLCHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly FMLBFFJHFNC CCLGPLKGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly LIFOCOCGCNJ BANILPHCFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly string MBBLLBHFMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly CDMECJMNEDA MAOEPJEIFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly CDMECJMNEDA BGJLGIFMFBL;

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1C80", Offset = "0x6FA0880", VA = "0x186FA1C80")]
	public NHJGKMDLCHJ(FMLBFFJHFNC CCLGPLKGAAA, LIFOCOCGCNJ BANILPHCFDA, string MBBLLBHFMBP, CDMECJMNEDA MAOEPJEIFFB, CDMECJMNEDA BGJLGIFMFBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct EMEPFJIEGKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EFLENNBPCOG IAEAGLKGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly Guid HOMPIBFLCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private bool BCJBOMDKMCM;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F940B0", Offset = "0x6F92CB0", VA = "0x186F940B0")]
	public static EMEPFJIEGKC JOIEPNPLKMF(EFLENNBPCOG IAEAGLKGHNI)
	{
		return default(EMEPFJIEGKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x98DFA0", Offset = "0x98CBA0", VA = "0x18098DFA0")]
	public void CHMDGAJAEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F93FB0", Offset = "0x6F92BB0", VA = "0x186F93FB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F94110", Offset = "0x6F92D10", VA = "0x186F94110")]
	private EMEPFJIEGKC(EFLENNBPCOG IAEAGLKGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F93FB0", Offset = "0x6F92BB0", VA = "0x186F93FB0")]
	private void JDIPLGLJGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F94010", Offset = "0x6F92C10", VA = "0x186F94010")]
	private Func<Guid, bool> EIIHMLLBKLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class LPJKLKHELAI : FNPOODPMHMK, BLBECLBEDNO
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<FNBHJFNPAHD> HCMLKFAFEKI(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE JOJHBJEMMHB, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct FFOAEDHBPJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public IDHGEAOPLAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private EMEPFJIEGKC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F957E0", Offset = "0x6F943E0", VA = "0x186F957E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F95F50", Offset = "0x6F94B50", VA = "0x186F95F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct MCBBDLEODKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public IDHGEAOPLAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FC80", Offset = "0x6F9E880", VA = "0x186F9FC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0090", Offset = "0x6F9EC90", VA = "0x186FA0090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct JBLONMAJBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public IDHGEAOPLAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F99A00", Offset = "0x6F98600", VA = "0x186F99A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x6F99E90", Offset = "0x6F98A90", VA = "0x186F99E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class KLOCFCCENKI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public AsyncTaskMethodBuilder<NHJGKMDLCHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public KLOCFCCENKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private NHJGKMDLCHJ <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<FNBHJFNPAHD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private TaskAwaiter<NHJGKMDLCHJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x6FA7650", Offset = "0x6FA6250", VA = "0x186FA7650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x6FA7DE0", Offset = "0x6FA69E0", VA = "0x186FA7DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public AsyncTaskMethodBuilder<OJAAINJGBPM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public KLOCFCCENKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private OJAAINJGBPM <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter<FNBHJFNPAHD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<OJAAINJGBPM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x6FA7E50", Offset = "0x6FA6A50", VA = "0x186FA7E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA84A0", Offset = "0x6FA70A0", VA = "0x186FA84A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public IDHGEAOPLAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public OEPEJKPKKLA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public OEPEJKPKKLA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public NHJGKMDLCHJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public OEPEJKPKKLA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public OJAAINJGBPM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public OFIOGMLKIJG.LHMCOONGCON <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KLOCFCCENKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C790", Offset = "0x6F9B390", VA = "0x186F9C790")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<NHJGKMDLCHJ> KPAFKCHBLKI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C510", Offset = "0x6F9B110", VA = "0x186F9C510")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<OJAAINJGBPM> DGMLCAGCLKB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C8D0", Offset = "0x6F9B4D0", VA = "0x186F9C8D0")]
		internal void LHKCOFNLIDL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C910", Offset = "0x6F9B510", VA = "0x186F9C910")]
		internal Task MBOPIBGKEFH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C630", Offset = "0x6F9B230", VA = "0x186F9C630")]
		internal Task HHDFMLILLDG(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct LKGDFCFFPBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public IDHGEAOPLAO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private KLOCFCCENKI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter<NHJGKMDLCHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter<OJAAINJGBPM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6F9CA70", Offset = "0x6F9B670", VA = "0x186F9CA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D7C0", Offset = "0x6F9C3C0", VA = "0x186F9D7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct PDAGLFCDPJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public OJAAINJGBPM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public OEPEJKPKKLA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private BJGDPAGKNNE <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5930", Offset = "0x6FA4530", VA = "0x186FA5930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6850", Offset = "0x6FA5450", VA = "0x186FA6850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct MCLCNNHGNAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0100", Offset = "0x6F9ED00", VA = "0x186FA0100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6FA09B0", Offset = "0x6F9F5B0", VA = "0x186FA09B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct MDNHOLDDPCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0A10", Offset = "0x6F9F610", VA = "0x186FA0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1390", Offset = "0x6F9FF90", VA = "0x186FA1390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct PALJKEFMEOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6FA48F0", Offset = "0x6FA34F0", VA = "0x186FA48F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA58C0", Offset = "0x6FA44C0", VA = "0x186FA58C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct NNJEFKOIKNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public BJGDPAGKNNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1D00", Offset = "0x6FA0900", VA = "0x186FA1D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA30C0", Offset = "0x6FA1CC0", VA = "0x186FA30C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct DEIIPMCGOOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public FNBHJFNPAHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public OJAAINJGBPM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6F932D0", Offset = "0x6F91ED0", VA = "0x186F932D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6F93560", Offset = "0x6F92160", VA = "0x186F93560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class PFGLNJPKLFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public PFGLNJPKLFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private KJGBHDJPPOF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private TaskAwaiter<FNBHJFNPAHD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8510", Offset = "0x6FA7110", VA = "0x186FA8510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8B30", Offset = "0x6FA7730", VA = "0x186FA8B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public HCMLKFAFEKI masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public BJGDPAGKNNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public FNBHJFNPAHD originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PFGLNJPKLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6FA68B0", Offset = "0x6FA54B0", VA = "0x186FA68B0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FNBHJFNPAHD> PJAKJPPHOJB(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct GGEMELOLKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public HCMLKFAFEKI masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public BJGDPAGKNNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6F97AD0", Offset = "0x6F966D0", VA = "0x186F97AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6F97FD0", Offset = "0x6F96BD0", VA = "0x186F97FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct MNAJDPKFGBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private FNBHJFNPAHD <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private IEnumerator<FNBHJFNPAHD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6FA13F0", Offset = "0x6F9FFF0", VA = "0x186FA13F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1920", Offset = "0x6FA0520", VA = "0x186FA1920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct PJBANHJLCBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6D90", Offset = "0x6FA5990", VA = "0x186FA6D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6FB0", Offset = "0x6FA5BB0", VA = "0x186FA6FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct JOGHENPEFKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AE50", Offset = "0x6F99A50", VA = "0x186F9AE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B0A0", Offset = "0x6F99CA0", VA = "0x186F9B0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct OHPLHCBPLHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public OJAAINJGBPM phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public OEPEJKPKKLA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private BJGDPAGKNNE <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA31A0", Offset = "0x6FA1DA0", VA = "0x186FA31A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA40C0", Offset = "0x6FA2CC0", VA = "0x186FA40C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct KIKEBBNIKGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public LPJKLKHELAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public OEPEJKPKKLA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B970", Offset = "0x6F9A570", VA = "0x186F9B970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C4A0", Offset = "0x6F9B0A0", VA = "0x186F9C4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly FNLKKHGONOA ONCMOFAMLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly FNLKKHGONOA AMCHIDBBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly EKDPFEKGPHI LGNFDEGCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly NNPOFLHEJOB IEDKNPDFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly NFBNCADCGMB CGEADCOHLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly FFDHPHIIHCF FILCJONFCLN;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private OFPJPDGOKAO IOHNAIINCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E900", Offset = "0x6F9D500", VA = "0x186F9E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LFPDMHJFFCL DIEMGCJLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F270", Offset = "0x6F9DE70", VA = "0x186F9F270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E720", Offset = "0x6F9D320", VA = "0x186F9E720", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F9E0", Offset = "0x6F9E5E0", VA = "0x186F9F9E0")]
	public LPJKLKHELAI(EFLENNBPCOG IAEAGLKGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E170", Offset = "0x6F9CD70", VA = "0x186F9E170")]
	[AsyncStateMachine(typeof(FFOAEDHBPJB))]
	public Task EAKCGNLJFGI(IDHGEAOPLAO CLBGLGJCBEB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E5C0", Offset = "0x6F9D1C0", VA = "0x186F9E5C0")]
	[AsyncStateMachine(typeof(MCBBDLEODKA))]
	private Task<FNFHONNECCC> GEFHBCFENBC(IDHGEAOPLAO CLBGLGJCBEB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E780", Offset = "0x6F9D380", VA = "0x186F9E780")]
	[AsyncStateMachine(typeof(JBLONMAJBOF))]
	private Task GOJLFAKAEPB(IDHGEAOPLAO CLBGLGJCBEB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E970", Offset = "0x6F9D570", VA = "0x186F9E970")]
	[AsyncStateMachine(typeof(LKGDFCFFPBF))]
	private Task INENJFBLCOC(IDHGEAOPLAO CLBGLGJCBEB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken NNCGDIHFCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9ED80", Offset = "0x6F9D980", VA = "0x186F9ED80")]
	[AsyncStateMachine(typeof(PDAGLFCDPJF))]
	private Task LGGGCHGKLPH(OJAAINJGBPM MNFFHDIMGGP, OEPEJKPKKLA KPLKDGJBJEM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken OINDMEDOGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E030", Offset = "0x6F9CC30", VA = "0x186F9E030")]
	[AsyncStateMachine(typeof(MCLCNNHGNAI))]
	private Task CFDGGLAKGKH(GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F410", Offset = "0x6F9E010", VA = "0x186F9F410")]
	[AsyncStateMachine(typeof(MDNHOLDDPCO))]
	private Task OIGJECEIODJ(OJAAINJGBPM IMCLGJBJJKP, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DED0", Offset = "0x6F9CAD0", VA = "0x186F9DED0")]
	[AsyncStateMachine(typeof(PALJKEFMEOO))]
	private Task<FNBHJFNPAHD> AJBEJHDCGCM(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EC00", Offset = "0x6F9D800", VA = "0x186F9EC00")]
	[AsyncStateMachine(typeof(NNJEFKOIKNI))]
	private Task<FNBHJFNPAHD> JHHAEGMEKMM(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F290", Offset = "0x6F9DE90", VA = "0x186F9F290")]
	[AsyncStateMachine(typeof(DEIIPMCGOOE))]
	private Task<FNBHJFNPAHD> OFAGCDOLPJH(FNBHJFNPAHD NIMBBJPPGGG, OJAAINJGBPM JJHNDPDKFAO, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA, bool BDLEAMPILOH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F180", Offset = "0x6F9DD80", VA = "0x186F9F180")]
	private bool NBJFFGBHECC(OJAAINJGBPM MNFFHDIMGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F6B0", Offset = "0x6F9E2B0", VA = "0x186F9F6B0")]
	[AsyncStateMachine(typeof(GGEMELOLKBC))]
	protected Task<FNBHJFNPAHD> OPFPMKFBLOD(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA, HCMLKFAFEKI MGFLEOCNGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E2E0", Offset = "0x6F9CEE0", VA = "0x186F9E2E0")]
	[AsyncStateMachine(typeof(MNAJDPKFGBN))]
	private Task EHCEKDNOPHA(OJAAINJGBPM IMCLGJBJJKP, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E430", Offset = "0x6F9D030", VA = "0x186F9E430")]
	private void EHHAMJKPFFN(FNBHJFNPAHD PKGNAJEHACM, OEPEJKPKKLA CNNEAHANGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E740", Offset = "0x6F9D340", VA = "0x186F9E740")]
	private void GNOGMDAPNKM(FNBHJFNPAHD ENAJENDDILI, [Out] FNBHJFNPAHD FBEFADEOMJL, [Out] FNBHJFNPAHD PBDGOLOADCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F840", Offset = "0x6F9E440", VA = "0x186F9F840")]
	private Task<NHJGKMDLCHJ> PDMJNGCKIFJ(IDHGEAOPLAO CLBGLGJCBEB, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E8C0", Offset = "0x6F9D4C0", VA = "0x186F9E8C0")]
	private Task<OJAAINJGBPM> HBCINCODMJO(NHJGKMDLCHJ IMCLGJBJJKP, OFIOGMLKIJG.LHMCOONGCON IMLEDIADGDH, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F560", Offset = "0x6F9E160", VA = "0x186F9F560")]
	[AsyncStateMachine(typeof(PJBANHJLCBI))]
	private Task OJOHEDNHCOB(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA, bool GJDPDLPIDNI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E4D0", Offset = "0x6F9D0D0", VA = "0x186F9E4D0")]
	[AsyncStateMachine(typeof(JOGHENPEFKH))]
	private Task FODFJPHFKNN(OJAAINJGBPM IMCLGJBJJKP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E140", Offset = "0x6F9CD40", VA = "0x186F9E140")]
	private Task DJOMBCAPIGN(OJAAINJGBPM IMCLGJBJJKP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E930", Offset = "0x6F9D530", VA = "0x186F9E930")]
	private Task ICOPPPLJHLI(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E2C0", Offset = "0x6F9CEC0", VA = "0x186F9E2C0")]
	private Task EGIKILHJPOI(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EED0", Offset = "0x6F9DAD0", VA = "0x186F9EED0")]
	private Task MHPGMKDMEDG(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B100", Offset = "0x6F99D00", VA = "0x186F9B100")]
	private static Task EPCKDGIAMFM(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F9C0", Offset = "0x6F9E5C0", VA = "0x186F9F9C0")]
	private Task PPFINCNAGNP(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F880", Offset = "0x6F9E480", VA = "0x186F9F880")]
	private Task PODKKLIPBPG(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E480", Offset = "0x6F9D080", VA = "0x186F9E480")]
	private void ENCECELIFBB(IDHGEAOPLAO CLBGLGJCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E950", Offset = "0x6F9D550", VA = "0x186F9E950")]
	public void ILAPKFJDONH(long NFDNNKBLGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void IFIHPGMKBNC(FMLBFFJHFNC CCLGPLKGAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EAB0", Offset = "0x6F9D6B0", VA = "0x186F9EAB0")]
	[AsyncStateMachine(typeof(OHPLHCBPLHH))]
	private Task JFABBMCJHMB(OJAAINJGBPM MNFFHDIMGGP, OEPEJKPKKLA KPLKDGJBJEM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken OINDMEDOGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F020", Offset = "0x6F9DC20", VA = "0x186F9F020")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KIKEBBNIKGL))]
	private Task<FNBHJFNPAHD> MJNHHBBJHOI(OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, OEPEJKPKKLA CNNEAHANGMN, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct BMANDJMPGBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private OJAAINJGBPM IMCLGJBJJKP;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6F92490", Offset = "0x6F91090", VA = "0x186F92490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6F923B0", Offset = "0x6F90FB0", VA = "0x186F923B0")]
	public static Task JHMLCEABGGF(OFPJPDGOKAO CAFBHCAHEEK, OJAAINJGBPM IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6F92190", Offset = "0x6F90D90", VA = "0x186F92190")]
	private void JHMLCEABGGF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct KEAJHFEOKPF
{
	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B100", Offset = "0x6F99D00", VA = "0x186F9B100")]
	public static Task JHMLCEABGGF(CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct NAKBDPDIEPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct BPABFGKIAGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6F924E0", Offset = "0x6F910E0", VA = "0x186F924E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6F92A00", Offset = "0x6F91600", VA = "0x186F92A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1980", Offset = "0x6FA0580", VA = "0x186FA1980")]
	[AsyncStateMachine(typeof(BPABFGKIAGM))]
	public static Task JHMLCEABGGF(EFLENNBPCOG IAEAGLKGHNI, OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct IJGHHAFCHBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private struct ACHFEHFBNLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public BJGDPAGKNNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private FNBHJFNPAHD <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private OFPJPDGOKAO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private FIOCLCPFJCF <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private KJGBHDJPPOF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private List<(PersistenceView, CBEKBKNFPHF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private CBEKBKNFPHF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FF30", Offset = "0x6F8EB30", VA = "0x186F8FF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6F90B90", Offset = "0x6F8F790", VA = "0x186F90B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6F996B0", Offset = "0x6F982B0", VA = "0x186F996B0")]
	[AsyncStateMachine(typeof(ACHFEHFBNLE))]
	public static Task JHMLCEABGGF(EFLENNBPCOG IAEAGLKGHNI, OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x6F994B0", Offset = "0x6F980B0", VA = "0x186F994B0")]
	private static void BOOBLLBDFJM(PersistenceView DGNNOOCHGJF, CBEKBKNFPHF PDLNDIJBMLD, OJAAINJGBPM IMCLGJBJJKP, FNBHJFNPAHD NIMBBJPPGGG, bool MHGNNPHOCCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct IDKNLGEGDPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct JIJONCMOCCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public OFPJPDGOKAO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7DA0", Offset = "0x6FB69A0", VA = "0x186FB7DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB81E0", Offset = "0x6FB6DE0", VA = "0x186FB81E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6F20", Offset = "0x6FB5B20", VA = "0x186FB6F20")]
	[AsyncStateMachine(typeof(JIJONCMOCCK))]
	public static Task JHMLCEABGGF(OFPJPDGOKAO CAFBHCAHEEK, OJAAINJGBPM IMCLGJBJJKP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct AJJIDJHGOFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct ABFJPMHGGAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public OFPJPDGOKAO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x6FA93B0", Offset = "0x6FA7FB0", VA = "0x186FA93B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x6FA95C0", Offset = "0x6FA81C0", VA = "0x186FA95C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class CHEDKDOAPLD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000508")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public CHEDKDOAPLD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2E60", Offset = "0x6FC1A60", VA = "0x186FC2E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC31F0", Offset = "0x6FC1DF0", VA = "0x186FC31F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public CHEDKDOAPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x6FADC20", Offset = "0x6FAC820", VA = "0x186FADC20")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task ECPHKJMPGII(GDCBCFBEPNI<string>.LHHFCPKIPMG timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct CAKGPJAHBIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AJJIDJHGOFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD0C0", Offset = "0x6FABCC0", VA = "0x186FAD0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6FADA80", Offset = "0x6FAC680", VA = "0x186FADA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class HJJLBLDDJMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public NKGKLFPECPE version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HJJLBLDDJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x6FB68A0", Offset = "0x6FB54A0", VA = "0x186FB68A0")]
		internal object CEGGIKMFMOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6980", Offset = "0x6FB5580", VA = "0x186FB6980")]
		internal object KKDMFNFBLMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private OJAAINJGBPM IMCLGJBJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private EFLENNBPCOG IAEAGLKGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private bool GJDPDLPIDNI;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private static readonly ByteString FMGNDGMGBBC;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB840", Offset = "0x6FAA440", VA = "0x186FAB840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private NBOBHFDODPM CPIAFPIMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB4D0", Offset = "0x6FAA0D0", VA = "0x186FAB4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB5B0", Offset = "0x6FAA1B0", VA = "0x186FAB5B0")]
	[AsyncStateMachine(typeof(ABFJPMHGGAD))]
	public static Task JHMLCEABGGF(OFPJPDGOKAO CAFBHCAHEEK, OJAAINJGBPM IMCLGJBJJKP, EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA, bool GJDPDLPIDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB700", Offset = "0x6FAA300", VA = "0x186FAB700")]
	[AsyncStateMachine(typeof(CAKGPJAHBIN))]
	private Task JHMLCEABGGF(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB890", Offset = "0x6FAA490", VA = "0x186FAB890")]
	private void NAFHJMEPLFH([NotNull] HLKJAJHEMPF FACDJHONIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB570", Offset = "0x6FAA170", VA = "0x186FAB570")]
	private bool DGBKNMDPJBO(NKGKLFPECPE IDPOJNOELJM, HLKJAJHEMPF FACDJHONIBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct EBBKNEJMMMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct LPGKLADKGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<OJAAINJGBPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public EBBKNEJMMMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public OFIOGMLKIJG.LHMCOONGCON downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<(GFFELLBKJIA<HNGBNMNFADC, DICIKJENGEG>, GFFELLBKJIA<IDCLJKNKGLH<HLKJAJHEMPF>, DICIKJENGEG>, GFFELLBKJIA<IDCLJKNKGLH<GLNEPJPIIDC>, DICIKJENGEG>, GFFELLBKJIA<IDCLJKNKGLH<JPNINDOKGHL>, DICIKJENGEG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA440", Offset = "0x6FB9040", VA = "0x186FBA440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAEF0", Offset = "0x6FB9AF0", VA = "0x186FBAEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct JGNFIIFHDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<HNGBNMNFADC, DICIKJENGEG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public EBBKNEJMMMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public OFIOGMLKIJG.LHMCOONGCON downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<GFFELLBKJIA<HNGBNMNFADC, DICIKJENGEG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7720", Offset = "0x6FB6320", VA = "0x186FB7720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7D30", Offset = "0x6FB6930", VA = "0x186FB7D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private ODGJDDGHBPI<CDMECJMNEDA, GLNEPJPIIDC> IDGIDFLCKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private ODGJDDGHBPI<CDMECJMNEDA, HLKJAJHEMPF> KEMDNMICHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private ODGJDDGHBPI<long, JPNINDOKGHL> DMIPBNALCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private HPDICFEPHIM ODGGMAGLAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private FMLBFFJHFNC CCLGPLKGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private LIFOCOCGCNJ BANILPHCFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private string MBBLLBHFMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private CDMECJMNEDA MAOEPJEIFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private CDMECJMNEDA BGJLGIFMFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long NFDNNKBLGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII;

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6FB00A0", Offset = "0x6FAECA0", VA = "0x186FB00A0")]
	public static Task<OJAAINJGBPM> HJKALNKADDK(OFPJPDGOKAO CAFBHCAHEEK, [In] NHJGKMDLCHJ IMCLGJBJJKP, OFIOGMLKIJG.LHMCOONGCON IMLEDIADGDH, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0410", Offset = "0x6FAF010", VA = "0x186FB0410")]
	[AsyncStateMachine(typeof(LPGKLADKGCM))]
	private Task<OJAAINJGBPM> JHMLCEABGGF(OFIOGMLKIJG.LHMCOONGCON IMLEDIADGDH, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFEE0", Offset = "0x6FAEAE0", VA = "0x186FAFEE0")]
	[AsyncStateMachine(typeof(JGNFIIFHDPA))]
	private Task<GFFELLBKJIA<HNGBNMNFADC, DICIKJENGEG>> DELHOJCDNEO(string MBBLLBHFMBP, long NFDNNKBLGNC, long? NBIMAGPPMDN, long? INCOHCKKKJD, OFIOGMLKIJG.LHMCOONGCON IMLEDIADGDH, GDCBCFBEPNI<string>.LHHFCPKIPMG FPMJKGIINGG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct GOCJHLCFGDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct OCLCHJPJOHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public AsyncTaskMethodBuilder<NHJGKMDLCHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public GOCJHLCFGDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<NHJGKMDLCHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0AD0", Offset = "0x6FBF6D0", VA = "0x186FC0AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0ED0", Offset = "0x6FBFAD0", VA = "0x186FC0ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct ICAGEOIOIKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder<NHJGKMDLCHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public GOCJHLCFGDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<NHJGKMDLCHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6A80", Offset = "0x6FB5680", VA = "0x186FB6A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6EB0", Offset = "0x6FB5AB0", VA = "0x186FB6EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class NHNCLNLGHGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NHNCLNLGHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x91CE90", Offset = "0x91BA90", VA = "0x18091CE90")]
		internal bool MGPNFNKBJFN(LIFOCOCGCNJ sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct AIABGIENNEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public AsyncTaskMethodBuilder<NHJGKMDLCHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public CDMECJMNEDA superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public FIOCLCPFJCF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private NHNCLNLGHGF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public MPEADMLIKDP roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private FMLBFFJHFNC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private LIFOCOCGCNJ <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private CDMECJMNEDA <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private CDMECJMNEDA <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<FMLBFFJHFNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private TaskAwaiter<BHFAHGDBGIJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter<LKAHMCOOOOD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA330", Offset = "0x6FA8F30", VA = "0x186FAA330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB460", Offset = "0x6FAA060", VA = "0x186FAB460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private EKDPFEKGPHI LGNFDEGCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private MPEADMLIKDP GHJGBHJKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private long NBIMAGPPMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private long JJFCFIMNPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private long DHBGHDMOAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private string GJGCIINBOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private CDMECJMNEDA AOPOGKPMIBN;

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4A40", Offset = "0x6FB3640", VA = "0x186FB4A40")]
	public static Task<NHJGKMDLCHJ> HJKALNKADDK(OFPJPDGOKAO CAFBHCAHEEK, IDHGEAOPLAO CLBGLGJCBEB, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4CC0", Offset = "0x6FB38C0", VA = "0x186FB4CC0")]
	[AsyncStateMachine(typeof(OCLCHJPJOHN))]
	private Task<NHJGKMDLCHJ> JHMLCEABGGF(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4FE0", Offset = "0x6FB3BE0", VA = "0x186FB4FE0")]
	[AsyncStateMachine(typeof(ICAGEOIOIKH))]
	private Task<NHJGKMDLCHJ> PDMJNGCKIFJ(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4E40", Offset = "0x6FB3A40", VA = "0x186FB4E40")]
	[AsyncStateMachine(typeof(AIABGIENNEF))]
	private static Task<NHJGKMDLCHJ> PDMJNGCKIFJ(FIOCLCPFJCF KHAIJLCNIAO, MPEADMLIKDP GHJGBHJKOGJ, long NBIMAGPPMDN, long JJFCFIMNPNM, long DHBGHDMOAKP, string GJGCIINBOKC, CDMECJMNEDA AOPOGKPMIBN, CancellationToken MPLCHGMFENA, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4E10", Offset = "0x6FB3A10", VA = "0x186FB4E10")]
	private void JPBNJFCEBFE(FMLBFFJHFNC CCLGPLKGAAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct DFLCFKEIHHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct LMAEOIBIEPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public DFLCFKEIHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9360", Offset = "0x6FB7F60", VA = "0x186FB9360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB98F0", Offset = "0x6FB84F0", VA = "0x186FB98F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private OJAAINJGBPM IMCLGJBJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private float EJONKNJPPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private float OEIJMFINADK;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEC40", Offset = "0x6FAD840", VA = "0x186FAEC40")]
	public static Task GGBOONOCHJJ(OFPJPDGOKAO CAFBHCAHEEK, OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEDE0", Offset = "0x6FAD9E0", VA = "0x186FAEDE0")]
	[AsyncStateMachine(typeof(LMAEOIBIEPG))]
	public Task JHMLCEABGGF(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEA40", Offset = "0x6FAD640", VA = "0x186FAEA40")]
	private static void DKDJJOPAMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEF00", Offset = "0x6FADB00", VA = "0x186FAEF00")]
	private void JPPBJKPMACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEB80", Offset = "0x6FAD780", VA = "0x186FAEB80")]
	private static float EKCKIKFMOAI(FIOCLCPFJCF KHAIJLCNIAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF060", Offset = "0x6FADC60", VA = "0x186FAF060")]
	private static float LPFCEDAIKEH()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct FHHDCLMONOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct LPCCMJBNGDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public EFLENNBPCOG operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private FCIIDNJEMOA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private OFPJPDGOKAO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private GFLNJAECCEH.DINGHBMPBPC <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9A40", Offset = "0x6FB8640", VA = "0x186FB9A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA3E0", Offset = "0x6FB8FE0", VA = "0x186FBA3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct OHEPKLKCFNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1560", Offset = "0x6FC0160", VA = "0x186FC1560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1850", Offset = "0x6FC0450", VA = "0x186FC1850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1B30", Offset = "0x6FB0730", VA = "0x186FB1B30")]
	[AsyncStateMachine(typeof(LPCCMJBNGDP))]
	public static Task JHMLCEABGGF(EFLENNBPCOG IAEAGLKGHNI, OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1A00", Offset = "0x6FB0600", VA = "0x186FB1A00")]
	private static Task<FNFHONNECCC> DPLICMDINBL(EFLENNBPCOG IAEAGLKGHNI, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1A70", Offset = "0x6FB0670", VA = "0x186FB1A70")]
	[AsyncStateMachine(typeof(OHEPKLKCFNN))]
	private static Task GOJCNOGIFJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct FHNMMEHNINC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct OIBEIBLDMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public FHNMMEHNINC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC18B0", Offset = "0x6FC04B0", VA = "0x186FC18B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1F60", Offset = "0x6FC0B60", VA = "0x186FC1F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class EINAMEEBCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EINAMEEBCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x6FB05A0", Offset = "0x6FAF1A0", VA = "0x186FB05A0")]
		internal object NNLKOOIOBKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct AHFBGELKMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public FHNMMEHNINC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private IDFCDAGDOLL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9D10", Offset = "0x6FA8910", VA = "0x186FA9D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA2D0", Offset = "0x6FA8ED0", VA = "0x186FAA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private bool ENODCKCNDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private CancellationToken MPLCHGMFENA;

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1C70", Offset = "0x6FB0870", VA = "0x186FB1C70")]
	public static Task FFBDKPBHEJM(OFPJPDGOKAO CAFBHCAHEEK, bool ENODCKCNDNP, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken HHPMDKPLKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1CE0", Offset = "0x6FB08E0", VA = "0x186FB1CE0")]
	[AsyncStateMachine(typeof(OIBEIBLDMGM))]
	private Task JHMLCEABGGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1DD0", Offset = "0x6FB09D0", VA = "0x186FB1DD0")]
	[AsyncStateMachine(typeof(AHFBGELKMMD))]
	private Task NKOHDDHOLDM(bool OOEMFHLLBED, string MFFICODDPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	private bool MFFLJIKBDFP(bool ENODCKCNDNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct FBKOFOLILEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct NGAJACCGNNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public FBKOFOLILEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDFE0", Offset = "0x6FBCBE0", VA = "0x186FBDFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE550", Offset = "0x6FBD150", VA = "0x186FBE550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class HJNMLELDNFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HJNMLELDNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6A30", Offset = "0x6FB5630", VA = "0x186FB6A30")]
		internal object NNLKOOIOBKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct HIIAMEHKGOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public FBKOFOLILEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private IDFCDAGDOLL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6270", Offset = "0x6FB4E70", VA = "0x186FB6270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6830", Offset = "0x6FB5430", VA = "0x186FB6830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	private ICKGILJKPIL FJBLIEHCFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private bool OOPJBGGPOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private OJAAINJGBPM IMCLGJBJJKP;

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x6FB18F0", Offset = "0x6FB04F0", VA = "0x186FB18F0")]
	public static Task<Scene> OAGOJKHKJEJ(OFPJPDGOKAO CAFBHCAHEEK, ICKGILJKPIL LDLNJDMJNBG, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1680", Offset = "0x6FB0280", VA = "0x186FB1680")]
	[AsyncStateMachine(typeof(NGAJACCGNNK))]
	private Task<Scene> JHMLCEABGGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x6FB15E0", Offset = "0x6FB01E0", VA = "0x186FB15E0")]
	private bool DNHCIEBMENG(OJAAINJGBPM IMCLGJBJJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1610", Offset = "0x6FB0210", VA = "0x186FB1610")]
	private void EDGOEKPALHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x6FB17A0", Offset = "0x6FB03A0", VA = "0x186FB17A0")]
	[AsyncStateMachine(typeof(HIIAMEHKGOG))]
	private Task<Scene> NKOHDDHOLDM(string MFFICODDPIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct NFBNCADCGMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct GJCKFADFLHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public NFBNCADCGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public FNBHJFNPAHD nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public OJAAINJGBPM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter<FNBHJFNPAHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3DB0", Offset = "0x6FB29B0", VA = "0x186FB3DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4890", Offset = "0x6FB3490", VA = "0x186FB4890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct HGNEGFMEJGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder<FNBHJFNPAHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public NFBNCADCGMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public FNBHJFNPAHD state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6FB55C0", Offset = "0x6FB41C0", VA = "0x186FB55C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x6FB58A0", Offset = "0x6FB44A0", VA = "0x186FB58A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private readonly EFLENNBPCOG IAEAGLKGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private readonly EKDPFEKGPHI LGNFDEGCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private readonly NNPOFLHEJOB IEDKNPDFOFD;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private FCIIDNJEMOA NHGNLJLPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x575F550", Offset = "0x575E150", VA = "0x18575F550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD8A0", Offset = "0x6FBC4A0", VA = "0x186FBD8A0")]
	public NFBNCADCGMB(EFLENNBPCOG IAEAGLKGHNI, EKDPFEKGPHI LGNFDEGCNNE, NNPOFLHEJOB IEDKNPDFOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD720", Offset = "0x6FBC320", VA = "0x186FBD720")]
	[AsyncStateMachine(typeof(GJCKFADFLHH))]
	public Task<FNBHJFNPAHD> LNGKINEAJCJ(FNBHJFNPAHD OFAAHCAPPGE, OJAAINJGBPM JJHNDPDKFAO, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA, bool BDLEAMPILOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD570", Offset = "0x6FBC170", VA = "0x186FBD570")]
	[AsyncStateMachine(typeof(HGNEGFMEJGP))]
	private Task<FNBHJFNPAHD> CGJBAMJKHBB(GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, FNBHJFNPAHD GJEHPOMDLIP, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD6D0", Offset = "0x6FBC2D0", VA = "0x186FBD6D0")]
	private bool HOGHPKMGLBL(FNBHJFNPAHD AGLPPABBPEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD700", Offset = "0x6FBC300", VA = "0x186FBD700")]
	private void LCOFNOOCLJC(string ICOEPJKILLK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct GLCHLGKBDLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct MOGLKLFMFNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public FCIIDNJEMOA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public BJGDPAGKNNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private KJGBHDJPPOF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private List<(PersistenceView, CBEKBKNFPHF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private (PersistenceView, CBEKBKNFPHF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCDD0", Offset = "0x6FBB9D0", VA = "0x186FBCDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD3E0", Offset = "0x6FBBFE0", VA = "0x186FBD3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4900", Offset = "0x6FB3500", VA = "0x186FB4900")]
	[AsyncStateMachine(typeof(MOGLKLFMFNG))]
	public static Task JHMLCEABGGF(FCIIDNJEMOA PIJDNDPDOCK, OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct IKDGHJKFKBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct ELMJFEPEHFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public FCIIDNJEMOA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public BJGDPAGKNNE timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private NKGKLFPECPE <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private KJGBHDJPPOF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private List<(PersistenceView, CBEKBKNFPHF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private CBEKBKNFPHF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0620", Offset = "0x6FAF220", VA = "0x186FB0620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0E70", Offset = "0x6FAFA70", VA = "0x186FB0E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7030", Offset = "0x6FB5C30", VA = "0x186FB7030")]
	[AsyncStateMachine(typeof(ELMJFEPEHFF))]
	public static Task JHMLCEABGGF(FCIIDNJEMOA PIJDNDPDOCK, OJAAINJGBPM IMCLGJBJJKP, BJGDPAGKNNE GNJLBEMNHAM, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct GFLNJAECCEH
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public struct DINGHBMPBPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public List<PGPKEBEONOP> AEOBDOLKILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public List<CBEKBKNFPHF> FAPHKKGFAOM;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
		public DINGHBMPBPC(List<PGPKEBEONOP> AEOBDOLKILP, List<CBEKBKNFPHF> FAPHKKGFAOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class MJIOBHDEIOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public IEnumerable<PGPKEBEONOP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MJIOBHDEIOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBBF0", Offset = "0x6FBA7F0", VA = "0x186FBBBF0")]
		internal object BECCPKCAKKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private OFPJPDGOKAO CAFBHCAHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private OJAAINJGBPM IMCLGJBJJKP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private FIOCLCPFJCF AAMGPEDMLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3390", Offset = "0x6FB1F90", VA = "0x186FB3390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB30D0", Offset = "0x6FB1CD0", VA = "0x186FB30D0")]
	public static DINGHBMPBPC JHMLCEABGGF(OFPJPDGOKAO CAFBHCAHEEK, OJAAINJGBPM IMCLGJBJJKP)
	{
		return default(DINGHBMPBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3130", Offset = "0x6FB1D30", VA = "0x186FB3130")]
	private DINGHBMPBPC JHMLCEABGGF()
	{
		return default(DINGHBMPBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB33E0", Offset = "0x6FB1FE0", VA = "0x186FB33E0")]
	private DINGHBMPBPC LDKIEEIOKGF(HLKJAJHEMPF FACDJHONIBI, NKGKLFPECPE FDNENODPALI)
	{
		return default(DINGHBMPBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2F00", Offset = "0x6FB1B00", VA = "0x186FB2F00")]
	private bool DDLHKNBNACH(IEnumerable<PGPKEBEONOP> AEOBDOLKILP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct IKHLIHEDGHI
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class KKLHDDDIOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public GFLNJAECCEH.DINGHBMPBPC instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KKLHDDDIOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8630", Offset = "0x6FB7230", VA = "0x186FB8630")]
		internal object ECPHKJMPGII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class FDCPODLNOIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FDCPODLNOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1970", Offset = "0x6FB0570", VA = "0x186FB1970")]
		internal object FJELHGFEJFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7170", Offset = "0x6FB5D70", VA = "0x186FB7170")]
	public static void JHMLCEABGGF(FCIIDNJEMOA PIJDNDPDOCK, OJAAINJGBPM IMCLGJBJJKP, GFLNJAECCEH.DINGHBMPBPC COOGDGDEDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class NNPOFLHEJOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct CKCKDECEGFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public FNBHJFNPAHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public OJAAINJGBPM deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FADD40", Offset = "0x6FAC940", VA = "0x186FADD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE4B0", Offset = "0x6FAD0B0", VA = "0x186FAE4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class LMCLBPHNJJM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public LMCLBPHNJJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2B40", Offset = "0x6FC1740", VA = "0x186FC2B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2E00", Offset = "0x6FC1A00", VA = "0x186FC2E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LMCLBPHNJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9950", Offset = "0x6FB8550", VA = "0x186FB9950")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LGDDAICLDMN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct FNEDHDILOAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private LMCLBPHNJJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1F00", Offset = "0x6FB0B00", VA = "0x186FB1F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2430", Offset = "0x6FB1030", VA = "0x186FB2430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct DPBKPPKLOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private Dictionary<Guid, List<CDCGAHFDKJJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF8D0", Offset = "0x6FAE4D0", VA = "0x186FAF8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFE80", Offset = "0x6FAEA80", VA = "0x186FAFE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct NFOBKCMDCBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private Dictionary<Guid, List<CDCGAHFDKJJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD900", Offset = "0x6FBC500", VA = "0x186FBD900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDF80", Offset = "0x6FBCB80", VA = "0x186FBDF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class BPEIBAODEOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CDCGAHFDKJJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public BPEIBAODEOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2940", Offset = "0x6FC1540", VA = "0x186FC2940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2AE0", Offset = "0x6FC16E0", VA = "0x186FC2AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public OMCEFIMLJGO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public List<CDCGAHFDKJJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BPEIBAODEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FACD50", Offset = "0x6FAB950", VA = "0x186FACD50")]
		internal object BCHGHKCGHGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FACF30", Offset = "0x6FABB30", VA = "0x186FACF30")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KGHBLEDJLLO(CDCGAHFDKJJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FACE40", Offset = "0x6FABA40", VA = "0x186FACE40")]
		internal object GEAGBGBHALD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct CKMNGMHFKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public OMCEFIMLJGO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public List<CDCGAHFDKJJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private BPEIBAODEOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE510", Offset = "0x6FAD110", VA = "0x186FAE510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE9E0", Offset = "0x6FAD5E0", VA = "0x186FAE9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct OGIJAHEIHCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0F40", Offset = "0x6FBFB40", VA = "0x186FC0F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1500", Offset = "0x6FC0100", VA = "0x186FC1500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class GIFDFJCMOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GIFDFJCMOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3D40", Offset = "0x6FB2940", VA = "0x186FB3D40")]
		internal object PJGPIGOPLAJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct ANFHMBFKNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public OJAAINJGBPM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FABFC0", Offset = "0x6FAABC0", VA = "0x186FABFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC480", Offset = "0x6FAB080", VA = "0x186FAC480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class POPJIGCNPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public POPJIGCNPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC28D0", Offset = "0x6FC14D0", VA = "0x186FC28D0")]
		internal object DOIKOODFEAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct ENGFIJONHNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public NNPOFLHEJOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0ED0", Offset = "0x6FAFAD0", VA = "0x186FB0ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1510", Offset = "0x6FB0110", VA = "0x186FB1510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class EPBOOEGHGGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EPBOOEGHGGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1570", Offset = "0x6FB0170", VA = "0x186FB1570")]
		internal object AJJHPINLDIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private readonly EFLENNBPCOG IAEAGLKGHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private JJBDFKJHIJK IEDKNPDFOFD;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private FCIIDNJEMOA NHGNLJLPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FCBA0", Offset = "0x8FB7A0", VA = "0x1808FCBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public NNPOFLHEJOB(EFLENNBPCOG IAEAGLKGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF4E0", Offset = "0x6FBE0E0", VA = "0x186FBF4E0")]
	[AsyncStateMachine(typeof(CKCKDECEGFL))]
	public Task JHMLCEABGGF(FNBHJFNPAHD NIMBBJPPGGG, OJAAINJGBPM JJHNDPDKFAO, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF140", Offset = "0x6FBDD40", VA = "0x186FBF140")]
	[AsyncStateMachine(typeof(FNEDHDILOAN))]
	private Task HCCCDOHMGEP(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF630", Offset = "0x6FBE230", VA = "0x186FBF630")]
	[AsyncStateMachine(typeof(DPBKPPKLOOF))]
	private Task KBBFGBBLGPL(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF770", Offset = "0x6FBE370", VA = "0x186FBF770")]
	[AsyncStateMachine(typeof(NFOBKCMDCBH))]
	private Task NOFCIHAAKHF(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEFF0", Offset = "0x6FBDBF0", VA = "0x186FBEFF0")]
	[AsyncStateMachine(typeof(CKMNGMHFKGE))]
	private Task GAPKJLJGMCK(Guid DCPBKGKIMEI, List<CDCGAHFDKJJ> CFMBFEHEMFK, OMCEFIMLJGO LDCAHMCIHBB, OJAAINJGBPM IMCLGJBJJKP, CancellationToken FGIAGALCIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF3A0", Offset = "0x6FBDFA0", VA = "0x186FBF3A0")]
	[AsyncStateMachine(typeof(OGIJAHEIHCP))]
	private Task IDLLOAKMCJP(OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEEB0", Offset = "0x6FBDAB0", VA = "0x186FBEEB0")]
	[AsyncStateMachine(typeof(ANFHMBFKNLK))]
	private Task FDJODPLIFHO(Guid DCAOLNMGNFH, OJAAINJGBPM IMCLGJBJJKP, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FBED70", Offset = "0x6FBD970", VA = "0x186FBED70")]
	[AsyncStateMachine(typeof(ENGFIJONHNI))]
	private Task EGHLFCJBEHA(Guid DCAOLNMGNFH, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF280", Offset = "0x6FBDE80", VA = "0x186FBF280")]
	private void HFFOMFJLGHC(Guid DCAOLNMGNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FBECC0", Offset = "0x6FBD8C0", VA = "0x186FBECC0")]
	private void EDELMPNOKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFA90", Offset = "0x6FBE690", VA = "0x186FBFA90")]
	public Guid PIALOPJJCHM(FNBHJFNPAHD PKGNAJEHACM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF8B0", Offset = "0x6FBE4B0", VA = "0x186FBF8B0")]
	[CompilerGenerated]
	private object OGNGCDDIBEI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct DKJGBDNEKMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct POLENLOOJJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public DKJGBDNEKMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private GDCBCFBEPNI<string>.LHHFCPKIPMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private IEnumerator<INGJGIGNBDA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2190", Offset = "0x6FC0D90", VA = "0x186FC2190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2870", Offset = "0x6FC1470", VA = "0x186FC2870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private FIOCLCPFJCF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private CancellationToken MPLCHGMFENA;

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF3E0", Offset = "0x6FADFE0", VA = "0x186FAF3E0")]
	public static Task NFEHIBMHFGI(FIOCLCPFJCF KHAIJLCNIAO, GDCBCFBEPNI<string>.LHHFCPKIPMG JKELFCJBEII, CancellationToken HHPMDKPLKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF2F0", Offset = "0x6FADEF0", VA = "0x186FAF2F0")]
	[AsyncStateMachine(typeof(POLENLOOJJN))]
	private Task JHMLCEABGGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public readonly struct GNEKNEMHKHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	public readonly bool LGILLEDLACC;

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	public GNEKNEMHKHJ(bool EDLKCDEJGCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public readonly struct CCHFEGBILNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	public readonly HLKJAJHEMPF? CNGFALBCDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	public readonly EILOGJMNOML AKGBAEOENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	public readonly string? EGFDDAOCKAE;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public IReadOnlyCollection<string> CFCAAMNLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FADAE0", Offset = "0x6FAC6E0", VA = "0x186FADAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public IReadOnlyDictionary<long, int> JOMDICJMHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FADB00", Offset = "0x6FAC700", VA = "0x186FADB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FADB20", Offset = "0x6FAC720", VA = "0x186FADB20")]
	public CCHFEGBILNH(HLKJAJHEMPF? AFAEGADIMPI, EILOGJMNOML HEDGGBCBIGM, string? MBBLLBHFMBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class MJJMCHAHOKK : FNPOODPMHMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct APEJDKFJJGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<CCHFEGBILNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public MJJMCHAHOKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public JCDEPKEOHOP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public IBBGFNFNCJB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private KJGBHDJPPOF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC4E0", Offset = "0x6FAB0E0", VA = "0x186FAC4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FACB50", Offset = "0x6FAB750", VA = "0x186FACB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class KBDIOLDNPDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public JCDEPKEOHOP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public MJJMCHAHOKK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KBDIOLDNPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8390", Offset = "0x6FB6F90", VA = "0x186FB8390")]
		internal Task OLMDOCLADCE(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB82B0", Offset = "0x6FB6EB0", VA = "0x186FB82B0")]
		internal Task IAMLGBCLCFE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class JPNICFNMAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public KBDIOLDNPDE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JPNICFNMAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8240", Offset = "0x6FB6E40", VA = "0x186FB8240")]
		internal object OGHHMHLMPNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class BAHILPKOALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public KBDIOLDNPDE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BAHILPKOALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FACBC0", Offset = "0x6FAB7C0", VA = "0x186FACBC0")]
		internal Task HDDIJLDHLLB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct GCGHPFBFCFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public JCDEPKEOHOP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public MJJMCHAHOKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private JPNICFNMAOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private KJGBHDJPPOF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2630", Offset = "0x6FB1230", VA = "0x186FB2630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2EA0", Offset = "0x6FB1AA0", VA = "0x186FB2EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private static readonly TimeSpan PFIHOJDJMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private readonly MGOHIPNLMCE NHFECEAJHMG;

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCD80", Offset = "0x6FBB980", VA = "0x186FBCD80")]
	public MJJMCHAHOKK(EFLENNBPCOG IAEAGLKGHNI, MGOHIPNLMCE NHFECEAJHMG, KEDKJKIEEGM MIIBHDDJGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCBB0", Offset = "0x6FBB7B0", VA = "0x186FBCBB0")]
	[AsyncStateMachine(typeof(APEJDKFJJGJ))]
	public Task<CCHFEGBILNH> PLFEAILJDFE(long JJFCFIMNPNM, IBBGFNFNCJB BBNCOKIIPON, JCDEPKEOHOP BEPMGJBLFDD, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC910", Offset = "0x6FBB510", VA = "0x186FBC910")]
	[AsyncStateMachine(typeof(GCGHPFBFCFN))]
	private Task JFBHNGABHCM(JCDEPKEOHOP BEPMGJBLFDD, IEnumerable<PersistenceView> MNFLJMFHMPG, StringBuilder DPICFHDEGOG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBEC0", Offset = "0x6FBAAC0", VA = "0x186FBBEC0")]
	private CCHFEGBILNH FDNNHBNPGLK(long JJFCFIMNPNM, IBBGFNFNCJB BBNCOKIIPON, JCDEPKEOHOP BEPMGJBLFDD, IEnumerable<PersistenceView> MNFLJMFHMPG, StringBuilder DPICFHDEGOG)
	{
		return default(CCHFEGBILNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCA50", Offset = "0x6FBB650", VA = "0x186FBCA50")]
	private HLKJAJHEMPF PGNBCEHOMML(long JJFCFIMNPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBC70", Offset = "0x6FBA870", VA = "0x186FBBC70")]
	private void FABPBMJEHCK(HLKJAJHEMPF NHJJMDKNLKM, StringBuilder DPICFHDEGOG, IEnumerable<PersistenceView> MNFLJMFHMPG, [In] BPICFALBJEJ NKIPHOKBIHN, GKMJDNLGPCN PHAJKLEPNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC470", Offset = "0x6FBB070", VA = "0x186FBC470")]
	private void FHKLCFKMIFP(HLKJAJHEMPF NHJJMDKNLKM, StringBuilder DPICFHDEGOG, PersistenceView DGNNOOCHGJF, GKMJDNLGPCN PHAJKLEPNGI, [In] BPICFALBJEJ NKIPHOKBIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal class ADBAIIHAEHH : FNPOODPMHMK
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class MACJGDHBAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public LLKKKNBFDIC.FJIIBMKKKPE roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MACJGDHBAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAF60", Offset = "0x6FB9B60", VA = "0x186FBAF60")]
		internal object HFMHIBLGMAD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct MDFNNOKIJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder<(LLKKKNBFDIC.FJIIBMKKKPE roomDataUpload, LLKKKNBFDIC.FJIIBMKKKPE subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CCHFEGBILNH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public ADBAIIHAEHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private MACJGDHBAJL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter<LLKKKNBFDIC.FJIIBMKKKPE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAFB0", Offset = "0x6FB9BB0", VA = "0x186FBAFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB800", Offset = "0x6FBA400", VA = "0x186FBB800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct NIHECHCIKII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public AsyncTaskMethodBuilder<DCMHOOJOMED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public ADBAIIHAEHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public CCHFEGBILNH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public JLMHDEAJDIF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private TaskAwaiter<(LLKKKNBFDIC.FJIIBMKKKPE roomDataUpload, LLKKKNBFDIC.FJIIBMKKKPE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private TaskAwaiter<DCMHOOJOMED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE5C0", Offset = "0x6FBD1C0", VA = "0x186FBE5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEC50", Offset = "0x6FBD850", VA = "0x186FBEC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct HFMBPBFAKOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public AsyncTaskMethodBuilder<BHFAHGDBGIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public ADBAIIHAEHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public CCHFEGBILNH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private TaskAwaiter<(LLKKKNBFDIC.FJIIBMKKKPE roomDataUpload, LLKKKNBFDIC.FJIIBMKKKPE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private TaskAwaiter<BHFAHGDBGIJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5140", Offset = "0x6FB3D40", VA = "0x186FB5140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5550", Offset = "0x6FB4150", VA = "0x186FB5550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class MOKFJPFGBJB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400069D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400069E")]
			public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400069F")]
			public MOKFJPFGBJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			private FNFHONNECCC <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			private TaskAwaiter<BHFAHGDBGIJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			private TaskAwaiter<DCMHOOJOMED> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			private TaskAwaiter<FNFHONNECCC> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC3250", Offset = "0x6FC1E50", VA = "0x186FC3250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC41D0", Offset = "0x6FC2DD0", VA = "0x186FC41D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public ADBAIIHAEHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public CCHFEGBILNH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public JLMHDEAJDIF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public GNEKNEMHKHJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MOKFJPFGBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD440", Offset = "0x6FBC040", VA = "0x186FBD440")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<FNFHONNECCC> MLMGJALALEE(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct MEJHAEJPIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public AsyncTaskMethodBuilder<FNFHONNECCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public ADBAIIHAEHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public CCHFEGBILNH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public JLMHDEAJDIF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public GNEKNEMHKHJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public GDCBCFBEPNI<string>.LHHFCPKIPMG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private TaskAwaiter<FNFHONNECCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB870", Offset = "0x6FBA470", VA = "0x186FBB870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBB80", Offset = "0x6FBA780", VA = "0x186FBBB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private static readonly KEDKJKIEEGM CNOOBMOEDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly AHFOCMCIPNL AGHBNMONMOG;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private OFPJPDGOKAO IOHNAIINCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E900", Offset = "0x6F9D500", VA = "0x186F9E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9C80", Offset = "0x6FA8880", VA = "0x186FA9C80")]
	public ADBAIIHAEHH(EFLENNBPCOG IAEAGLKGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9930", Offset = "0x6FA8530", VA = "0x186FA9930")]
	[AsyncStateMachine(typeof(MDFNNOKIJOJ))]
	private Task<(LLKKKNBFDIC.FJIIBMKKKPE, LLKKKNBFDIC.FJIIBMKKKPE)> FKOELJOBMNN(CCHFEGBILNH BOAMNEMIAIP, long NBIMAGPPMDN, long INCOHCKKKJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9A70", Offset = "0x6FA8670", VA = "0x186FA9A70")]
	[AsyncStateMachine(typeof(NIHECHCIKII))]
	public Task<DCMHOOJOMED> IMHJFBPDEHF(int JIILLLIPEFM, [CanBeNull] JLMHDEAJDIF EHAFNJGCMAN, CCHFEGBILNH BOAMNEMIAIP, long NBIMAGPPMDN, long INCOHCKKKJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x6FA97C0", Offset = "0x6FA83C0", VA = "0x186FA97C0")]
	[AsyncStateMachine(typeof(HFMBPBFAKOA))]
	private Task<BHFAHGDBGIJ> CPIFHNAHLMO(string GJGCIINBOKC, int JIILLLIPEFM, CCHFEGBILNH BOAMNEMIAIP, long NBIMAGPPMDN, long INCOHCKKKJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9620", Offset = "0x6FA8220", VA = "0x186FA9620")]
	[AsyncStateMachine(typeof(MEJHAEJPIBD))]
	public Task<FNFHONNECCC> AMLDKPGEFEC(int JIILLLIPEFM, JLMHDEAJDIF? EHAFNJGCMAN, CCHFEGBILNH BOAMNEMIAIP, long NBIMAGPPMDN, long INCOHCKKKJD, GNEKNEMHKHJ BCOFBHAJHGL, GDCBCFBEPNI<string>.LHHFCPKIPMG PPFOACIPBMG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public abstract class PCOIFABBOLG<T> where T : PCOIFABBOLG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	internal readonly OFPJPDGOKAO AAECAHKLNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private int? BPEMGGMPAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	protected readonly Guid JIMBGNGJJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	protected readonly OPMNPHPPHHM BOFECKPCHNO;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	protected T ILLMOINLNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x46F2920", Offset = "0x46F1520", VA = "0x1846F2920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x46F2A20", Offset = "0x46F1620", VA = "0x1846F2A20")]
	internal PCOIFABBOLG(OFPJPDGOKAO PJMAJAMOLGB, OPMNPHPPHHM CMMGCBACION, [Optional] Guid? AMMGFMLLGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x46F2840", Offset = "0x46F1440", VA = "0x1846F2840")]
	private FNFHONNECCC HFABELCGNFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	protected virtual void NBLGNFGJAFA(FNFHONNECCC JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x46F2980", Offset = "0x46F1580", VA = "0x1846F2980")]
	public T PBDJCKBEKBD(OICKONADKGK COEGBGMLNEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x46F2670", Offset = "0x46F1270", VA = "0x1846F2670")]
	public T ADLKPLMPBBB(int LPFMLOEEPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x46F2710", Offset = "0x46F1310", VA = "0x1846F2710", Slot = "5")]
	public virtual Task<FBOKJACJPGA> EGFJKBCPCHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class GBMBGDIFJMB : PCOIFABBOLG<GBMBGDIFJMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	private IDHGEAOPLAO FAPAFOGIGGO;

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2560", Offset = "0x6FB1160", VA = "0x186FB2560")]
	internal GBMBGDIFJMB(OFPJPDGOKAO PJMAJAMOLGB, OPMNPHPPHHM CMMGCBACION, [Optional] Guid? AMMGFMLLGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x64FE7C0", Offset = "0x64FD3C0", VA = "0x1864FE7C0")]
	public GBMBGDIFJMB LGODMJABONN(IDHGEAOPLAO FAPAFOGIGGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2490", Offset = "0x6FB1090", VA = "0x186FB2490", Slot = "4")]
	protected override void NBLGNFGJAFA(FNFHONNECCC JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class OCGDIHMGNJL : PCOIFABBOLG<OCGDIHMGNJL>
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	internal enum GGLBGPKGAGO
	{
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct DLLIAKGLOJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public AsyncTaskMethodBuilder<FBOKJACJPGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public OCGDIHMGNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter<FBOKJACJPGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF450", Offset = "0x6FAE050", VA = "0x186FAF450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF7F0", Offset = "0x6FAE3F0", VA = "0x186FAF7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private GGLBGPKGAGO KFKKJKNPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private string HOJIKAEGGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private JLMHDEAJDIF FAPAFOGIGGO;

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0960", Offset = "0x6FBF560", VA = "0x186FC0960")]
	internal OCGDIHMGNJL(OFPJPDGOKAO PJMAJAMOLGB, OPMNPHPPHHM CMMGCBACION, [Optional] Guid? AMMGFMLLGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0930", Offset = "0x6FBF530", VA = "0x186FC0930")]
	public OCGDIHMGNJL PANJJKFGPCA(string HDGEDEGBPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0760", Offset = "0x6FBF360", VA = "0x186FC0760")]
	public OCGDIHMGNJL GCBJAEFCCMM(bool NHLDCODKIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0640", Offset = "0x6FBF240", VA = "0x186FC0640")]
	public OCGDIHMGNJL EBMOLNBOPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0780", Offset = "0x6FBF380", VA = "0x186FC0780", Slot = "4")]
	protected override void NBLGNFGJAFA(FNFHONNECCC JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0670", Offset = "0x6FBF270", VA = "0x186FC0670", Slot = "5")]
	[AsyncStateMachine(typeof(DLLIAKGLOJA))]
	public override Task<FBOKJACJPGA> EGFJKBCPCHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x6FC08F0", Offset = "0x6FBF4F0", VA = "0x186FC08F0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<FBOKJACJPGA> OIOCBEPANJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal static class ONBINGMFOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2040", Offset = "0x6FC0C40", VA = "0x186FC2040")]
	public static void NKKMNMBLPLJ(this BEMAMOPOJJM AONAMJGHNBC, NJAGFBDJADF IMIJBBNMDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1FC0", Offset = "0x6FC0BC0", VA = "0x186FC1FC0")]
	public static void JKFNLDMCLLO(this NJAGFBDJADF MDFMBBLPOPE, [Optional] string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class BAMNFOOLOJK
{
	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x6FACCB0", Offset = "0x6FAB8B0", VA = "0x186FACCB0")]
	public static CDMECJMNEDA OIKKHBLIHBL(this JNNNFDNLEMC DHOANMENAEB)
	{
		return default(CDMECJMNEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6FACC00", Offset = "0x6FAB800", VA = "0x186FACC00")]
	public static JNNNFDNLEMC EICOIIEBGNP(this CDMECJMNEDA ECMOMBOJKEO)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000192")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public LNPLICNELJJ ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public LNPLICNELJJ HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private static LNPLICNELJJ[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private Dictionary<LNPLICNELJJ, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4980", Offset = "0x6FC3580", VA = "0x186FC4980")]
		public bool CKELLPHMHFA(LNPLICNELJJ EPCFCIPBDON, [Out] ResultConfig BPPGADPMEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4840", Offset = "0x6FC3440", VA = "0x186FC4840")]
		public ResultConfig CAALIIAICPE(LNPLICNELJJ BGLFCJCCBPJ, [Optional] HashSet<LNPLICNELJJ> ODFOJBCNIAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4F50", Offset = "0x6FC3B50", VA = "0x186FC4F50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC49F0", Offset = "0x6FC35F0", VA = "0x186FC49F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8B3240", Offset = "0x8B1E40", VA = "0x1808B3240")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class GIDPCDOILBK
{
	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3990", Offset = "0x6FB2590", VA = "0x186FB3990")]
	[FJJFAIMPJIC(JBEKPLNNIEC.GameOnly)]
	private static void LLDKNAFABLI(LLIMAHMFNLB IADIMANELHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public interface ACFFOKBAEJM : IEquatable<ACFFOKBAEJM>
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	DateTime ODHOFLLDEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOFMIIJLIOM();

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PLLGINEGGON(long NBIMAGPPMDN, long JJFCFIMNPNM, [Out] CCHFEGBILNH BOAMNEMIAIP);
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
internal class LIKKPNLIEGH : BABBLJBEOLE
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class DMFAOBCFAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CMFFNFFAOGL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DMFAOBCFAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF860", Offset = "0x6FAE460", VA = "0x186FAF860")]
		internal object CIGCCNIPKIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private readonly GBBCAAEPIID KPJABPJLOJH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<ACFFOKBAEJM> JNMNADIBEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8A20", Offset = "0x6FB7620", VA = "0x186FB8A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB90E0", Offset = "0x6FB7CE0", VA = "0x186FB90E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	[UnityEngine.Scripting.Preserve]
	public LIKKPNLIEGH([GOICEJLKLIB(null)] GBBCAAEPIID KPJABPJLOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB86E0", Offset = "0x6FB72E0", VA = "0x186FB86E0", Slot = "6")]
	public bool DCCFGDGLDIJ(long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP, CMFFNFFAOGL IELBOLKNNGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x1C17130", Offset = "0x1C15D30", VA = "0x181C17130")]
	private void GJDNDNIGHKN(ACFFOKBAEJM EICCBKKAPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8AD0", Offset = "0x6FB76D0", VA = "0x186FB8AD0", Slot = "7")]
	public bool FBLJGDLBDEL(long NBIMAGPPMDN, long JJFCFIMNPNM, [Out] ACFFOKBAEJM GHJLANOPNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x6FB92B0", Offset = "0x6FB7EB0", VA = "0x186FB92B0", Slot = "8")]
	public bool OHFILDFJHPA(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, [Out] ACFFOKBAEJM GHJLANOPNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8C40", Offset = "0x6FB7840", VA = "0x186FB8C40")]
	private void FCEEDACADMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9190", Offset = "0x6FB7D90", VA = "0x186FB9190", Slot = "9")]
	public void NJFIMHKJJND(long NBIMAGPPMDN, long JJFCFIMNPNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal abstract class HHKKCIHOGDC : GBBCAAEPIID
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	protected enum PIGAPCNDLGJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class DKGDEJJOILL : IEnumerable<ACFFOKBAEJM>, IEnumerable, IEnumerator<ACFFOKBAEJM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private ACFFOKBAEJM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public HHKKCIHOGDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private CMFFNFFAOGL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public CMFFNFFAOGL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private ACFFOKBAEJM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public DKGDEJJOILL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF080", Offset = "0x6FADC80", VA = "0x186FAF080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF2A0", Offset = "0x6FADEA0", VA = "0x186FAF2A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF1F0", Offset = "0x6FADDF0", VA = "0x186FAF1F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ACFFOKBAEJM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAF1F0", Offset = "0x6FADDF0", VA = "0x186FAF1F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class BPMDMADHOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public CMFFNFFAOGL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BPMDMADHOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD020", Offset = "0x6FABC20", VA = "0x186FAD020")]
		internal object HJOKHEKOGJO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class KHPBOMDIBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public HHKKCIHOGDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KHPBOMDIBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x6FB85B0", Offset = "0x6FB71B0", VA = "0x186FB85B0")]
		internal void GAGILNNNNAC(BLOAHDFELEC.MPODJHAODGO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private readonly object LEELJLEGDCD;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected string DOHBDHALPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6FB61E0", Offset = "0x6FB4DE0", VA = "0x186FB61E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract INGKBOOCJME PCINLOMFCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB61F0", Offset = "0x6FB4DF0", VA = "0x186FB61F0")]
	protected HHKKCIHOGDC([CanBeNull] string NIABINGMLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5FA0", Offset = "0x6FB4BA0", VA = "0x186FB5FA0", Slot = "5")]
	public bool INEMBCDFOIA(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, [Out] ACFFOKBAEJM EICCBKKAPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5910", Offset = "0x6FB4510", VA = "0x186FB5910", Slot = "6")]
	[IteratorStateMachine(typeof(DKGDEJJOILL))]
	public IEnumerable<ACFFOKBAEJM> BHMIDFIOPIK(CMFFNFFAOGL IELBOLKNNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void LIIFGNMKILD(Stream HHBNMJDMGHD, long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool HAHMECODNDA(Stream IJDCBIBNNPB, long NBIMAGPPMDN, long JJFCFIMNPNM, LJJDJENHPFB GEBGFDKMAGP, [Out] CCHFEGBILNH BOAMNEMIAIP);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB59A0", Offset = "0x6FB45A0", VA = "0x186FB59A0", Slot = "7")]
	public ACFFOKBAEJM EGFLKBDHKGN(long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP, CMFFNFFAOGL IELBOLKNNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GIOCFKBDGDH(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, PIGAPCNDLGJ FCGDOELECNP);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo FDJGJHLDLIO(CMFFNFFAOGL IELBOLKNNGD, PIGAPCNDLGJ FCGDOELECNP);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6170", Offset = "0x6FB4D70", VA = "0x186FB6170")]
	protected void KOBGGGGIIBC(BLOAHDFELEC.MPODJHAODGO PFBDMGHODJE, string ICOEPJKILLK, FileInfo LNDMJAIFLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5CA0", Offset = "0x6FB48A0", VA = "0x186FB5CA0")]
	internal bool HJPFNHHAGNK(FileInfo KFLAHGEJECH, long NBIMAGPPMDN, long JJFCFIMNPNM, [Out] CCHFEGBILNH BOAMNEMIAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private void GAGLJGEIKCN(Exception JCLKODFKPHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal class OALPKIDLKLN : HHKKCIHOGDC
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override INGKBOOCJME PCINLOMFCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xC9BB10", Offset = "0xC9A710", VA = "0x180C9BB10", Slot = "8")]
		get
		{
			return default(INGKBOOCJME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x6FC05B0", Offset = "0x6FBF1B0", VA = "0x186FC05B0")]
	public OALPKIDLKLN([Optional] string NIABINGMLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0530", Offset = "0x6FBF130", VA = "0x186FC0530")]
	private void NJKELODHFJF(CMFFNFFAOGL IELBOLKNNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0300", Offset = "0x6FBEF00", VA = "0x186FC0300", Slot = "9")]
	internal override void LIIFGNMKILD(Stream HHBNMJDMGHD, long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFE10", Offset = "0x6FBEA10", VA = "0x186FBFE10", Slot = "10")]
	internal override bool HAHMECODNDA(Stream IJDCBIBNNPB, long NBIMAGPPMDN, long JJFCFIMNPNM, LJJDJENHPFB GEBGFDKMAGP, [Out] CCHFEGBILNH BOAMNEMIAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFD20", Offset = "0x6FBE920", VA = "0x186FBFD20", Slot = "11")]
	protected override FileInfo GIOCFKBDGDH(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, PIGAPCNDLGJ FCGDOELECNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFC20", Offset = "0x6FBE820", VA = "0x186FBFC20", Slot = "12")]
	protected override DirectoryInfo FDJGJHLDLIO(CMFFNFFAOGL IELBOLKNNGD, PIGAPCNDLGJ FCGDOELECNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class IINEEHLIHLJ : HHKKCIHOGDC
{
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private static readonly byte[] DPHIOKCFMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private readonly byte[] DPDLNHHEBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private readonly byte[] GDJOBHAAAOM;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public override INGKBOOCJME PCINLOMFCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5DB62E0", Offset = "0x5DB4EE0", VA = "0x185DB62E0", Slot = "8")]
		get
		{
			return default(INGKBOOCJME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x6FC72A0", Offset = "0x6FC5EA0", VA = "0x186FC72A0")]
	public IINEEHLIHLJ([Optional] string NIABINGMLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6F50", Offset = "0x6FC5B50", VA = "0x186FC6F50", Slot = "9")]
	internal override void LIIFGNMKILD(Stream HHBNMJDMGHD, long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6780", Offset = "0x6FC5380", VA = "0x186FC6780", Slot = "10")]
	internal override bool HAHMECODNDA(Stream IJDCBIBNNPB, long NBIMAGPPMDN, long JJFCFIMNPNM, LJJDJENHPFB GEBGFDKMAGP, [Out] CCHFEGBILNH BOAMNEMIAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6590", Offset = "0x6FC5190", VA = "0x186FC6590")]
	private void FNEPJMOAJLJ(byte[] HNGDLLNOPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6650", Offset = "0x6FC5250", VA = "0x186FC6650", Slot = "11")]
	protected override FileInfo GIOCFKBDGDH(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, PIGAPCNDLGJ FCGDOELECNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6470", Offset = "0x6FC5070", VA = "0x186FC6470", Slot = "12")]
	protected override DirectoryInfo FDJGJHLDLIO(CMFFNFFAOGL IELBOLKNNGD, PIGAPCNDLGJ FCGDOELECNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public enum INGKBOOCJME : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal class DBNAAMNDGKC : GBBCAAEPIID
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class DKECHLKABCN : IEnumerable<ACFFOKBAEJM>, IEnumerable, IEnumerator<ACFFOKBAEJM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private ACFFOKBAEJM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public DBNAAMNDGKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private CMFFNFFAOGL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CMFFNFFAOGL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private INGKBOOCJME[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private IEnumerator<ACFFOKBAEJM> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private ACFFOKBAEJM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public DKECHLKABCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC60C0", Offset = "0x6FC4CC0", VA = "0x186FC60C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5C10", Offset = "0x6FC4810", VA = "0x186FC5C10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5BC0", Offset = "0x6FC47C0", VA = "0x186FC5BC0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6070", Offset = "0x6FC4C70", VA = "0x186FC6070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5FC0", Offset = "0x6FC4BC0", VA = "0x186FC5FC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ACFFOKBAEJM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5FC0", Offset = "0x6FC4BC0", VA = "0x186FC5FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private readonly INGKBOOCJME[] CAKLBCBPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private readonly Dictionary<INGKBOOCJME, GBBCAAEPIID> FIJHMGNJOJD;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public INGKBOOCJME PCINLOMFCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6FC54D0", Offset = "0x6FC40D0", VA = "0x186FC54D0", Slot = "4")]
		get
		{
			return default(INGKBOOCJME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5870", Offset = "0x6FC4470", VA = "0x186FC5870")]
	[UnityEngine.Scripting.Preserve]
	public DBNAAMNDGKC(params GBBCAAEPIID[] KFPOHHADEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5720", Offset = "0x6FC4320", VA = "0x186FC5720", Slot = "5")]
	public bool INEMBCDFOIA(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, [Out] ACFFOKBAEJM EICCBKKAPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5500", Offset = "0x6FC4100", VA = "0x186FC5500")]
	private void GCCJDMCAIDA(int LPFGHJPBDNB, long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6FC52F0", Offset = "0x6FC3EF0", VA = "0x186FC52F0", Slot = "6")]
	[IteratorStateMachine(typeof(DKECHLKABCN))]
	public IEnumerable<ACFFOKBAEJM> BHMIDFIOPIK(CMFFNFFAOGL IELBOLKNNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5380", Offset = "0x6FC3F80", VA = "0x186FC5380", Slot = "7")]
	public ACFFOKBAEJM EGFLKBDHKGN(long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP, CMFFNFFAOGL IELBOLKNNGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
internal static class HJLFIEICPIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6150", Offset = "0x6FC4D50", VA = "0x186FC6150")]
	internal static byte[] ABDAAGOFLIJ(byte[] HNGDLLNOPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x6FC63F0", Offset = "0x6FC4FF0", VA = "0x186FC63F0")]
	public static void FCBDDOKOOAA(Stream DMCHAOHIHNE, byte[] HHJJLMOBPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6210", Offset = "0x6FC4E10", VA = "0x186FC6210")]
	public static bool CJLFAONLHON(Stream DMCHAOHIHNE, long MGAOFCNGLIF, LJJDJENHPFB GCNANFEOOHF, [Out] byte[] KELOOGOJDJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal sealed class NOGEDICFADG : ACFFOKBAEJM, IEquatable<ACFFOKBAEJM>, IEquatable<NOGEDICFADG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private readonly HHKKCIHOGDC GDHBOGJFJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	public readonly FileInfo HLFEHILLJNF;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public INGKBOOCJME PCINLOMFCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x69924D0", Offset = "0x69910D0", VA = "0x1869924D0", Slot = "9")]
		get
		{
			return default(INGKBOOCJME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DateTime ODHOFLLDEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7770", Offset = "0x6FC6370", VA = "0x186FC7770", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x6FC78F0", Offset = "0x6FC64F0", VA = "0x186FC78F0")]
	public NOGEDICFADG(HHKKCIHOGDC LHMHJHMIBHH, FileInfo KFLAHGEJECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7840", Offset = "0x6FC6440", VA = "0x186FC7840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC76B0", Offset = "0x6FC62B0", VA = "0x186FC76B0", Slot = "5")]
	public void IOFMIIJLIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7800", Offset = "0x6FC6400", VA = "0x186FC7800", Slot = "6")]
	public bool PLLGINEGGON(long NBIMAGPPMDN, long JJFCFIMNPNM, [Out] CCHFEGBILNH BOAMNEMIAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7390", Offset = "0x6FC5F90", VA = "0x186FC7390", Slot = "7")]
	public bool Equals(ACFFOKBAEJM OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7560", Offset = "0x6FC6160", VA = "0x186FC7560", Slot = "8")]
	public bool Equals(NOGEDICFADG OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7470", Offset = "0x6FC6070", VA = "0x186FC7470", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7620", Offset = "0x6FC6220", VA = "0x186FC7620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
public delegate void LJJDJENHPFB(BLOAHDFELEC.MPODJHAODGO HDJOJMOFOPO, string JIMAFLGJGFB);
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal interface GBBCAAEPIID
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	INGKBOOCJME PCINLOMFCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool INEMBCDFOIA(long NBIMAGPPMDN, long JJFCFIMNPNM, CMFFNFFAOGL IELBOLKNNGD, [Out] ACFFOKBAEJM EICCBKKAPGP);

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ACFFOKBAEJM> BHMIDFIOPIK(CMFFNFFAOGL IELBOLKNNGD);

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ACFFOKBAEJM EGFLKBDHKGN(long NBIMAGPPMDN, long JJFCFIMNPNM, CCHFEGBILNH BOAMNEMIAIP, CMFFNFFAOGL IELBOLKNNGD);
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
