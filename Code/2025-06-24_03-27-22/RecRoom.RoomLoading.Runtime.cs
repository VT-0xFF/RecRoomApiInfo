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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x861E050", Offset = "0x861CC50", VA = "0x18861E050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class JHGGDGBLLHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<JBLHFNLKPCH> KHGJPLEDGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task EMOCEICANGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal IHAEAKFMLLN AFGDOCKOPMC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JHGGDGBLLHI()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8619FD0", Offset = "0x8618BD0", VA = "0x188619FD0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8621B70", Offset = "0x8620770", VA = "0x188621B70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GHEAIDFLDCE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86127C0", Offset = "0x86113C0", VA = "0x1886127C0")]
	public GHEAIDFLDCE(string FNFIPKNHEOF, Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class AJGFJGNEMJL : JPGPHGAEHOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JBFFBBKCFCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MBONFMDKIOA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<GANLKDCNLCA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86176B0", Offset = "0x86162B0", VA = "0x1886176B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86178F0", Offset = "0x86164F0", VA = "0x1886178F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DAKIKBKNABD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HHAABLKIJHM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<HHAABLKIJHM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x860AA90", Offset = "0x8609690", VA = "0x18860AA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x860ACA0", Offset = "0x86098A0", VA = "0x18860ACA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[UnityEngine.Scripting.Preserve]
	public AJGFJGNEMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8602670", Offset = "0x8601270", VA = "0x188602670", Slot = "4")]
	[AsyncStateMachine(typeof(JBFFBBKCFCM))]
	public Task<IReadOnlyList<MBONFMDKIOA>> JNJPCGONPKG(long JKJNCHGDMGL, long OKLPJIPAHKD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8602790", Offset = "0x8601390", VA = "0x188602790", Slot = "5")]
	[AsyncStateMachine(typeof(DAKIKBKNABD))]
	public Task<IReadOnlyList<HHAABLKIJHM>> LOHGJEKNIEA(IReadOnlyList<int> FAPDCPLFMKG, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IFOBPAEADIE : IEquatable<IFOBPAEADIE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BOEPADPIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HHAABLKIJHM CINGPNMIBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime BMIHKBGCICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ONFEMJONKDP? GPNOMGADPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OCKADBPJKPJ? EGALDFAJPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	JCEMPPEMNLG GBIFGCJHIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PEJIBHJPOLO> MIBODFIKKNC();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum JCEMPPEMNLG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JPGPHGAEHOA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<MBONFMDKIOA>> JNJPCGONPKG(long JKJNCHGDMGL, long OKLPJIPAHKD, [Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<HHAABLKIJHM>> LOHGJEKNIEA(IReadOnlyList<int> FAPDCPLFMKG, [Optional] CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LLFKNCGEKCH
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DFMDAOHBNMP : IFOBPAEADIE, IEquatable<IFOBPAEADIE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct GLAHCCLOLNF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public DFMDAOHBNMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private CIIKPBEDJIP <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<KINJLHLHADG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<PEJIBHJPOLO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8612830", Offset = "0x8611430", VA = "0x188612830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8612DC0", Offset = "0x86119C0", VA = "0x188612DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly MBONFMDKIOA ADLABOKKKII;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BOEPADPIGLN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HHAABLKIJHM CINGPNMIBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime KFFPHKHGGCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x860B1A0", Offset = "0x8609DA0", VA = "0x18860B1A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ONFEMJONKDP? GPNOMGADPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4360", Offset = "0x2BA2F60", VA = "0x182BA4360", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OCKADBPJKPJ? EGALDFAJPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x860B080", Offset = "0x8609C80", VA = "0x18860B080", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JCEMPPEMNLG GBIFGCJHIMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA7BBF0", Offset = "0xA7A7F0", VA = "0x180A7BBF0", Slot = "10")]
			get
			{
				return default(JCEMPPEMNLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x860B0A0", Offset = "0x8609CA0", VA = "0x18860B0A0", Slot = "9")]
		[AsyncStateMachine(typeof(GLAHCCLOLNF))]
		public Task<PEJIBHJPOLO> MIBODFIKKNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x860B1C0", Offset = "0x8609DC0", VA = "0x18860B1C0")]
		public DFMDAOHBNMP(int JPAKNNGEHJF, HHAABLKIJHM BHHBDLDDAAJ, MBONFMDKIOA ADLABOKKKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x860AF30", Offset = "0x8609B30", VA = "0x18860AF30", Slot = "11")]
		public bool Equals(IFOBPAEADIE GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x860AE90", Offset = "0x8609A90", VA = "0x18860AE90", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x860AFC0", Offset = "0x8609BC0", VA = "0x18860AFC0")]
		private bool FOHFKIPFEFD(DFMDAOHBNMP GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x860B000", Offset = "0x8609C00", VA = "0x18860B000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BJOLBKBJGEO : IFOBPAEADIE, IEquatable<IFOBPAEADIE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct PDEFEGMGCBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public BJOLBKBJGEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<PEJIBHJPOLO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x861F280", Offset = "0x861DE80", VA = "0x18861F280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x861F4D0", Offset = "0x861E0D0", VA = "0x18861F4D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly KJNCMPAKDDO IFJGNEKNNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ONFEMJONKDP HJFMIKHNIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly OCKADBPJKPJ EBFAOHLDKBC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BOEPADPIGLN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8603040", Offset = "0x8601C40", VA = "0x188603040", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HHAABLKIJHM CINGPNMIBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8602FB0", Offset = "0x8601BB0", VA = "0x188602FB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime KFFPHKHGGCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x86031C0", Offset = "0x8601DC0", VA = "0x1886031C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ONFEMJONKDP? GPNOMGADPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8603080", Offset = "0x8601C80", VA = "0x188603080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public OCKADBPJKPJ? EGALDFAJPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8602F60", Offset = "0x8601B60", VA = "0x188602F60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JCEMPPEMNLG GBIFGCJHIMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC78550", Offset = "0xC77150", VA = "0x180C78550", Slot = "10")]
			get
			{
				return default(JCEMPPEMNLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC8B0", Offset = "0x1FFB4B0", VA = "0x181FFC8B0")]
		public BJOLBKBJGEO(KJNCMPAKDDO KNOPMIEECBG, ONFEMJONKDP DGDMEDBFBMG, OCKADBPJKPJ DNFLFMKLBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86030D0", Offset = "0x8601CD0", VA = "0x1886030D0", Slot = "9")]
		[AsyncStateMachine(typeof(PDEFEGMGCBD))]
		public Task<PEJIBHJPOLO> MIBODFIKKNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8602D30", Offset = "0x8601930", VA = "0x188602D30", Slot = "11")]
		public bool Equals(IFOBPAEADIE GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8602DD0", Offset = "0x86019D0", VA = "0x188602DD0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8602E80", Offset = "0x8601A80", VA = "0x188602E80")]
		private bool FOHFKIPFEFD(BJOLBKBJGEO GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8602EE0", Offset = "0x8601AE0", VA = "0x188602EE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class KBIDGILPJEH : IFOBPAEADIE, IEquatable<IFOBPAEADIE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct ACBPNNPPCHP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<PEJIBHJPOLO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x86010C0", Offset = "0x85FFCC0", VA = "0x1886010C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8601320", Offset = "0x85FFF20", VA = "0x188601320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly HHAABLKIJHM HEMDCALEGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ONFEMJONKDP HJFMIKHNIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly OCKADBPJKPJ EBFAOHLDKBC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BOEPADPIGLN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8619000", Offset = "0x8617C00", VA = "0x188619000", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public HHAABLKIJHM CINGPNMIBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime KFFPHKHGGCK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ONFEMJONKDP? GPNOMGADPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8619020", Offset = "0x8617C20", VA = "0x188619020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public OCKADBPJKPJ? EGALDFAJPBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8618FB0", Offset = "0x8617BB0", VA = "0x188618FB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JCEMPPEMNLG GBIFGCJHIMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "10")]
			get
			{
				return default(JCEMPPEMNLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC8B0", Offset = "0x1FFB4B0", VA = "0x181FFC8B0")]
		public KBIDGILPJEH(HHAABLKIJHM BHHBDLDDAAJ, ONFEMJONKDP DGDMEDBFBMG, OCKADBPJKPJ DNFLFMKLBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8619070", Offset = "0x8617C70", VA = "0x188619070", Slot = "9")]
		[AsyncStateMachine(typeof(ACBPNNPPCHP))]
		public Task<PEJIBHJPOLO> MIBODFIKKNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8618DD0", Offset = "0x86179D0", VA = "0x188618DD0", Slot = "11")]
		public bool Equals(IFOBPAEADIE GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8618D50", Offset = "0x8617950", VA = "0x188618D50", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8618F20", Offset = "0x8617B20", VA = "0x188618F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8618E40", Offset = "0x8617A40", VA = "0x188618E40")]
		private bool FOHFKIPFEFD(KBIDGILPJEH GMNGNCHKEBK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MCMAMMMEELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<IFOBPAEADIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LLFKNCGEKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<MBONFMDKIOA> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<MBONFMDKIOA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, HHAABLKIJHM account, MBONFMDKIOA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x861A350", Offset = "0x8618F50", VA = "0x18861A350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x861B1F0", Offset = "0x8619DF0", VA = "0x18861B1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GFDNMOLNDKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, HHAABLKIJHM account, MBONFMDKIOA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<MBONFMDKIOA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LLFKNCGEKCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<HHAABLKIJHM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8611D80", Offset = "0x8610980", VA = "0x188611D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8612750", Offset = "0x8611350", VA = "0x188612750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BEGDFLHHMKP FEAOBEDBCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JPGPHGAEHOA COEIKLGNJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HILDNEGHJLL FCBLBEBGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BFMIMIINNAC<(long, long), IReadOnlyList<MBONFMDKIOA>> JAFJENLDGCC;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8619A00", Offset = "0x8618600", VA = "0x188619A00")]
	[UnityEngine.Scripting.Preserve]
	public LLFKNCGEKCH([GFNPNOLPMKK(null)] JPGPHGAEHOA EKIDIIHAOHP, [GFNPNOLPMKK(null)] HILDNEGHJLL MBOFPKKAHOH, [GFNPNOLPMKK(null)] BEGDFLHHMKP HGENMGNGLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86198B0", Offset = "0x86184B0", VA = "0x1886198B0")]
	[AsyncStateMachine(typeof(MCMAMMMEELP))]
	public Task<IList<IFOBPAEADIE>> JDCGIMNBBGM(long JKJNCHGDMGL, long KBGIBOKAOOO, bool KNAHNPGBAGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8619600", Offset = "0x8618200", VA = "0x188619600")]
	private bool BPKPEKEAKBF(DateTime? BNEJCGGCCLD, long JKJNCHGDMGL, long KBGIBOKAOOO, [Out] KJNCMPAKDDO NCDCKNMIKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86197A0", Offset = "0x86183A0", VA = "0x1886197A0")]
	[AsyncStateMachine(typeof(GFDNMOLNDKK))]
	private Task<IReadOnlyList<(int, HHAABLKIJHM, MBONFMDKIOA)>> EMKCLNNHNMN(IReadOnlyList<MBONFMDKIOA> HCBPBHMNMBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HILDNEGHJLL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KJNCMPAKDDO> OEOOKBLGPMF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BEGFHJBAHDP(long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH, IGBBMPDAJMA PCAOHCHCKBL);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DKLMNFMLGEI(long JKJNCHGDMGL, long KBGIBOKAOOO, [Out] KJNCMPAKDDO NCDCKNMIKIB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NAMLKIGJOGO(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, [Out] KJNCMPAKDDO NCDCKNMIKIB);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBHENLMIPDK(long JKJNCHGDMGL, long KBGIBOKAOOO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface PPEFCDBEFHO : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LKLDMEIEHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task IPHDJLNKHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKACLMEACEJ(Task NKDMFOKACBI, string EAAJAIOPHMH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface JOLGBJADICK : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PEJIBHJPOLO> BNPLNMBHPBE(KJNCMPAKDDO NCDCKNMIKIB);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BPBKPMBKAGO(CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface CCCCPGHELOP : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ADJJNPCIJEO JMGGCOKAODP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPEONEDLPJP();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEONHKMAEGP();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface GPPJJLABMCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface LMAIAAIDCCF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan NPPMFKGJOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan APLJNIEJMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LABCLKAPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan OLLGNFGLLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DJILCHGFLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BMEEIJBFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DEAKKIIPPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int AMEFCIHMJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CHKPEMLHMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FDAKOIINKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool LLEILPPMAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum IGKGBILLJKF
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CDKBIPEOCCB
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LFGJEGOCDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long IOJMBMGDHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long OKLPJIPAHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly IGKGBILLJKF OPOPAMPKKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception DJFMMLMHIOM;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x86195E0", Offset = "0x86181E0", VA = "0x1886195E0")]
	public LFGJEGOCDII(long IOJMBMGDHLE, long OKLPJIPAHKD, IGKGBILLJKF OPOPAMPKKGD, [CanBeNull] Exception DJFMMLMHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8619590", Offset = "0x8618190", VA = "0x188619590")]
	public static LFGJEGOCDII AFAOJPNNAAP(FJAIPDANBOO LEAFBNEJFGK, IGKGBILLJKF OPOPAMPKKGD, [Optional] Exception DJFMMLMHIOM)
	{
		return default(LFGJEGOCDII);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void NMAFJGIFFBN(LFGJEGOCDII DCFHCALNHDD);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface NAOPNHOMAOE : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NMAFJGIFFBN HLJNAGDPFNN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NMAFJGIFFBN BMMOPBHKDOH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NMAFJGIFFBN MHMLKIBIBLA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<CDKBIPEOCCB, bool> ININDAMEOON;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHEDBAFNEJM(LFGJEGOCDII DCFHCALNHDD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFGPHNMFPGJ(LFGJEGOCDII DCFHCALNHDD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CFEHIANLEAN(LFGJEGOCDII DCFHCALNHDD);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ACNEFELKPCP(CDKBIPEOCCB MKMDKJJLADP, bool MBDJGJKJICC);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface GEPMPDHAMDP : GPPJJLABMCM, IDisposable, FEKBDPPMKBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IEAKGOOIGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMMPPAPCCBB();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface BKIPPFDHBMB : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus HLGIHONJOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LHMLBIMHLFI(FJAIPDANBOO EBAJJCNAANO, PKADLGDPKME BIFANKLCGAE, CancellationToken DCACDPOIBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class OMNNPANJOGM
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x861ED80", Offset = "0x861D980", VA = "0x18861ED80")]
	public static bool BHFOHDBBMEP(this BKIPPFDHBMB PCCAPAGPBLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task NBKIGDOHHEE(CancellationToken HEDGIMBCGHA, int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface FNKMNCGLMJF : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHIOPALCKIM(NBKIGDOHHEE KHEBJFKNPCB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KMLAPHJELJN : CIIKPBEDJIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken JGPPIKLDDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	PFGPAPHADOM HJDFIGODBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BHCJDNPMBCM NKAAJFIPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AHLPANAIOHK BNPAMDNACDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PIHMIMMNDBA FCMAGNJPMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JONKNFJJKMH EMKNPFFABOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	LJNGIEKFBAB KHHNLLCMMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FEKGMHDPDLC CDHJNBANDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PPEFCDBEFHO GIEHFLBFJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JOLGBJADICK DHCBAEJEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NAOPNHOMAOE GDPIFBDHMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GEPMPDHAMDP AJNJDKJEINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BKIPPFDHBMB PAKKKCMPEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FNKMNCGLMJF HEGLABBEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LFHNHIGOGPL EMJGHOEANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HLOHLLJOEPO FAHJBPHKKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	POBPCNGMOEG GNHDBCENOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AGHCGHMFDBD BLFDLKKDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IHDJLNKPAOG CCNBOLEDBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	HPDFOIEFPLD FNCGJOMCIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HIDHECKNOGP DGHJHJHJEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KDNCNHCJKIB INKLMJOPLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OBEDHHBHEAH ONLAAKOCKND
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NJKMHJOEPLN IMEJIPIMMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CCCCPGHELOP GDJGKLCAJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LMAIAAIDCCF NCFEGMDHGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NNNADOAHABC BHLAKDGFOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	HILDNEGHJLL BDEOENDDCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	BCBMJOELBCH BHMKNAOJEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	DEGILGJNEEG ENPMONEHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	FEKLGINOHBI DAGHOIKBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	KMAOLHPGECA EAGEKEFNNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool CHOGLEAEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void NKBPKAHHIED(PKADLGDPKME FNHNKKBOMNL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface LFHNHIGOGPL : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFAIMEPEPMK NKAMMCABBBC(Guid DIPCJMNHKDB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMCNGGMNMHK(Guid DIPCJMNHKDB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGBLICDMGPO(Guid DIPCJMNHKDB, Task KPHCMIAGIEL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AIKEAHEGHAK(Guid DIPCJMNHKDB, PEJIBHJPOLO HAAJDCLBBLF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(PEJIBHJPOLO, Task)> HFGIDCKKCEI(Guid DIPCJMNHKDB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface MIJCCIJBGJK : GPPJJLABMCM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface HLOHLLJOEPO : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNFGOFAMIAE(HNLLGFNPJEI FNFIPKNHEOF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDOHGHFGJLI(HNLLGFNPJEI FNFIPKNHEOF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NIDIOBFKMIA> GJBLDCJLFGK(CancellationToken IEBEAAPBOMO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface POBPCNGMOEG : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFAIMEPEPMK COEDBMEMKBP(HNLLGFNPJEI MAEGJAMICNB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHCGMOGDPHP(Guid DIPCJMNHKDB, Task KPHCMIAGIEL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface AGHCGHMFDBD : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PEJIBHJPOLO> BLFDLKKDGHJ(HNLLGFNPJEI HJHLPCOBPOB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface IHDJLNKPAOG : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FCFEBPBOLMP> JNBHILALGIM(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, FJAIPDANBOO EBAJJCNAANO, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface HIDHECKNOGP : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEJIBHJPOLO KIBICPNGCDH(BJCCECIKIFB DKOJOOELKHC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MBBMDEMOELJ(string MCLDNGJMMPC);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HPDFOIEFPLD : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNLLGFNPJEI> KCPCJOJABCH(HNLLGFNPJEI BJAGJMJPKHA, OIDEJNGNBIE OEGPEIDJGMD, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HNLLGFNPJEI> PCMEKKJAOEK(CancellationToken DKKNFNCKCEB, OIDEJNGNBIE OEGPEIDJGMD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BLJFMNNIGKD JIPABBADMMJ(ANOMBEDMGAC HBIKMFDJEPN, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BLJFMNNIGKD JEFPOFIMPMH(ANOMBEDMGAC HBIKMFDJEPN, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KDNCNHCJKIB : GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEJIBHJPOLO ONKEHDJJFDH(BJCCECIKIFB DKOJOOELKHC, NIDIOBFKMIA HMBJHAPMDJC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PEJIBHJPOLO LONIKPGJJBJ(BJCCECIKIFB JEHLDBHABMD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PPJIHPDIFOG
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int NBANMPJBCHD = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, PEBDFPGPBHD> DHCNPMELHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action LACDMKMMPLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> JHFCHJJFNCA();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BJNGAPPLEEG([Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task AJIIBJCLLPI([Optional] CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OBEDHHBHEAH
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGHFLIIGJCP(AJNIIKFDODJ BGJODIGPMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IALFELIFIPI(AJNIIKFDODJ BGJODIGPMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKOIHFPBBDM(AJNIIKFDODJ BGJODIGPMAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALHIKMIFFNF(AJNIIKFDODJ BGJODIGPMAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class AJNIIKFDODJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FJAIPDANBOO LAFHGFGEPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> IKMKFDBLCML;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public HMEJDNPIBLC<string> GNCBODDDAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public AJNIIKFDODJ(FJAIPDANBOO APNOPAAOBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8602930", Offset = "0x8601530", VA = "0x188602930")]
	public AJNIIKFDODJ OCNHELNGEBA(string MEPFFFGIFGB, string OOHGFGHCOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x86028A0", Offset = "0x86014A0", VA = "0x1886028A0")]
	public bool AKADCLLAOMB([Out] IEnumerable<KeyValuePair<string, string>> KMGPCALLMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7445AA0", Offset = "0x74446A0", VA = "0x187445AA0")]
	public AJNIIKFDODJ MEHELKLCIOH(HMEJDNPIBLC<string> KDCDPEHJICI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NNNADOAHABC
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool DLLFDBDBOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string IHIIOJDHBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool CBENAHBABOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICDEPPALOMG();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKDOBPADKDO EFFFLNHDAIB(long KAPPFCILLMP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MOENBGNBLCM<IDLFIGEMLKL, HFMEMLNGCBK> OKALEPGFMDK(long KAPPFCILLMP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MOENBGNBLCM<IDLFIGEMLKL, LCCGADBLEIF> HDLOBHDIAMO(long KAPPFCILLMP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MOENBGNBLCM<long, GJJDHOBJLAA> CBGGKFFMNPE();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<PFPKEOCLAOD>> HPJIANFMMDA(long KAPPFCILLMP, IReadOnlyCollection<PFPKEOCLAOD> EMEGBKGDOCP, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PMLFALOOKFB(long KAPPFCILLMP, [Out] bool DHNDMKANFKG);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> KJJIDCIEAOM(byte[] OLNOBDEBFAH, byte[] MAKPBGFOOLO, IReadOnlyCollection<Guid> KOFLMAOPIAN, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GNILIMCHNDI
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FCFEBPBOLMP GLOMJONEBBE(long IOJMBMGDHLE, long OKLPJIPAHKD, string OJPCFKOJIED);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCFEBPBOLMP GLOMJONEBBE(long IOJMBMGDHLE, long OKLPJIPAHKD, IDLFIGEMLKL OLNOBDEBFAH, Guid? FHFKDGOEDCH, long MEDPANLILPF, bool FACBGOABMNL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCFEBPBOLMP GLOMJONEBBE(NHMGHNEDIJJ LHKPCCDEIAC);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCFEBPBOLMP GLOMJONEBBE(KINJLHLHADG HOFCPMDMKNN, MBONFMDKIOA GHEKBPNLCFC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CIIKPBEDJIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool BHFOHDBBMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool FJFKMEDNDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool CHOGLEAEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	GNILIMCHNDI NACODKMEDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	PKADLGDPKME MLDKHCNMHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NMAFJGIFFBN HLJNAGDPFNN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NMAFJGIFFBN BMMOPBHKDOH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NMAFJGIFFBN MHMLKIBIBLA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<CDKBIPEOCCB, bool> ININDAMEOON;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PMMPPAPCCBB();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JFGKLKMBFAO OBDOBGGKKKI();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DNPPCFHAAPG HMFKJDICENA();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task GCOLKEBPBFD(int IDJFHNCGAIP, BIBLILLBLLL HFJBDNPALNN, Func<JOPODIFOAJI, JOPODIFOAJI> EPGJCAKJAJC);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PEJIBHJPOLO> BNPLNMBHPBE(KJNCMPAKDDO KNOPMIEECBG);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task BPBKPMBKAGO(CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PIHMIMMNDBA
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool MKPOGELNBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KDBPNHJCHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? MEJIPDLFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEEGPFGLDFG(Scene IPKBDFJDKCL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KPMBAPANECN(DAFILHNGNBD PGJNLCCGOOK, IReadOnlyList<DAFILHNGNBD> PNFLKJFFHEL, IReadOnlyList<DAFILHNGNBD> KCHMBMKIBOC, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJOLBBGDLEA(Guid IJGNKDKNEFC, IReadOnlyList<Guid> KOFLMAOPIAN, LKMJNFGKNOD OCJCFMIJDDH, [Optional] object KNLBJFKFFMK);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CEENEJBNAOO(IReadOnlyList<Guid> BNKGGLHPEJI, CancellationToken KBPMILFCDID);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JONEILGCLIJ PFKECFCGBJN();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task GEPHEJPDOFF();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GFKDFGIHGGC(GameObject CJBDGNIBOEE);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task OBGIHIAPAEE();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AGABMHMNIPB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool MMFCJAEAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool PFJHMDHIFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IPJLABBDNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool NJCHDGOMLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int AJCFJGLNDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool DIHOLIIEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool GCKABFBBBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int ICFEIAGKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int JAPBJCHNKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool FPOPMAGMNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool ODGOMAHOAAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool CLGKDMELNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float MEHNEKFNNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> HLKKPCFNHDC;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFGPAPHADOM DMBFMOFFFOB(PFGPAPHADOM OPPNLIGHFDB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOOJEHBIHJJ(PFGPAPHADOM MHCMGFKMEEN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJMEGPMCDJB();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task OPKCGELFEAO(HMEJDNPIBLC<string>.FIEDNALJEDE ELLBAMCAIIB, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIGAJKAEICI(float LKKJBKDJEBD);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CIHONOOHJBF(string LPICFBBADAO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<LCOFMHPCGFG> DKBDHHMCBAM();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable HDOHFCLPJBJ(object CBLPKFIJGLH, LCOFMHPCGFG BGDIJBGKCDF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<HLIEMBHHJCP> HODFJBMIPAC();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HFMEMLNGCBK OPFPHBAJMKF(IEnumerable<FJFJDBNHDLA> GEIDDCHNCEP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FNGBCBBLMJD(int MOGEIKLHIFI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LAFNBOKLKPK();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LNOHKBPPFCF();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PBMFEHPFDOM();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task GKHBKHIKNAG(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OCMLONDPHCL(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<IBAAACIAKCF> MPKHOBEEGBC(DateTime FACBMBLADKN, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> GHPIGFGAKKI(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LEAAJBBGMLF(string FNFIPKNHEOF = "", float PMNGLFBCFIN = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LBLADGEIGNI FLPMMAMDLAN(KHDDPNLIHJD JNKALBEBJLP, KBMPPKJOJGB MOJBDDDBJGK, LCCGADBLEIF GEDEAHKPPED, IEnumerable<PersistenceView> MLIDDGBCEKA, PKMLKIDDIJE LLMBEGBONAG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MNKCAALLPBM(LCCGADBLEIF GEDEAHKPPED);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IFEGEHNFGMF(FJFJDBNHDLA DPGLACKNALH, [In] LBLADGEIGNI DOMGPJHJIEF);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CDLKEOKGENM(LCCGADBLEIF CMNJPDBBKKH, bool MJEOFBKKIDG, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task FKOEHJCHKAD(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MOIJCDAPELA(long JKJNCHGDMGL, long OKLPJIPAHKD, KINJLHLHADG LLPPGIONGOK, MBONFMDKIOA EFHFNHKKFON, JOPODIFOAJI ACMODBIBOMH, BIBLILLBLLL? HFJBDNPALNN, LJJJPAOGPFE? OCNPFNCOBDN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LONFMEANLDP(long JKJNCHGDMGL, long OKLPJIPAHKD, LJJJPAOGPFE? OCNPFNCOBDN);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KFDDDOMIMPB(PersistenceView HOJCHNPOIHH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CFHCEGPDCPL(string FPIAJLOPODE, FJAIPDANBOO APNOPAAOBED, INCMOAEKENF CJODGOCPEIP, [Optional] string? PBGMGAFENDO, [Optional] string? PNLAAGGALPO, [Optional] string? JMGOFOGFPEO);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool CHHCIDPLCDH(PersistenceView HBPAMLAADAH);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KCIKJMFPDOA(FJFJDBNHDLA DPGLACKNALH, NMCPHPKNFMD MHJAOKAOKEC, [Out] GKFEOENJADM EMEOMOBNACM);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task JFEHNNDCDLD(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LCHHPICBEOA();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable DDJNCBEHHNA();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void BEIJINMBPGF(LCCGADBLEIF CMNJPDBBKKH, NMCPHPKNFMD MHJAOKAOKEC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> KBLOLCIJBLC(BHCJDNPMBCM DKIFPHGKANK, CancellationToken DKKNFNCKCEB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void DGIBJINBHMH(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NHMGHNEDIJJ> DMJKJJMBHOG(ADJAOPAAPJE BJAGJMJPKHA);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KINJLHLHADG> GJBOLBKJONF(long JKJNCHGDMGL, bool CCBGOIFDGBI, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<CLPJHDPKJPJ> IDNOCDKNBLG(long JKJNCHGDMGL, long OKLPJIPAHKD, long MEDPANLILPF, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<MBONFMDKIOA> LLNEOMCFJMB(long JKJNCHGDMGL, long OKLPJIPAHKD, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<JJNCBFJEABI> NFPFEEDOAAB(long JKJNCHGDMGL, Guid DPLAAEKCIBK, long? KBGIBOKAOOO, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	MOENBGNBLCM<JJNCBFJEABI, IEnumerable<OMCJMDHAAKM>> CDPBECLPICH();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<LNAIBELOABI> GOBMEAHFGAI(string OJPCFKOJIED, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<LNAIBELOABI> OLAKBMFKKAH(string OJPCFKOJIED, long JKJNCHGDMGL, long OKLPJIPAHKD, Guid? IJGNKDKNEFC, CMFJEOGICBC.JDDEGHHPKHM DEELHKGGHPE, CMFJEOGICBC.JDDEGHHPKHM MAKPBGFOOLO, int IDJFHNCGAIP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool MFBNADCPPAL();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool AFKJJHEHLAG();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool DDENNFHBGCG(IEnumerable<GKFEOENJADM> BBDDPJIPKLG);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void KIPGLHGBLCJ(List<GameObject> CGLNKIIHBIG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float KJFOGOOOAGM();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> JHNNMBCFEIA(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> LINPIKCPFAN(string EMOKKEEPOCM, LoadSceneMode DDHKGBKPABK, bool HIKMDDHLFEG, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void CNGMJLGGPNK(bool DAMJJNFLPNM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void HOJELHHBLPD();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void LONCLLEGBFE();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GALDNGGKOAD(bool LLGMOPGHPPN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<CMFJEOGICBC.JDDEGHHPKHM> GAAHEBGOGCN(byte[] PEDMEJIDLNB, CMFJEOGICBC.CCGBNDDIOFJ OBFNHOHEHCE, INHLBKIAFGN BOEKBFIPNEG, [Optional] IReadOnlyCollection<string>? APIPJHMMDBF, [Optional] string? MJIMCLELNIN);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void MAFJIENPPMC(FJAIPDANBOO JOOADJPODGG);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task KLNLCIONIOK(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task POIEBCGFBED(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task HOHAMBLNIPO(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task EABIFNHEPCP(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable LDAKDPBMLBE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	MGIGFDPHHAN HMIHNHNNBCO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task FPPOMLMKGNG(CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MGIGFDPHHAN
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FNDMMDEGMKO(CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OIGALGGNDFF(CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LBLADGEIGNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> IGBDKNFMJDJ;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum IBAAACIAKCF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KHDDPNLIHJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? KPPDJDHAMCC;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BMKBDBHPIME
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	FJAIPDANBOO CMAGOEIHGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	KINJLHLHADG BBCCIEDHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	CGPLGKCGOLD LHBKOCFAEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool GMNDBKJLALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool JJNMHABOBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int CIKPNBGIGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action PHBDNIBMOLH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> IBLDEPHCENG;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BLIOHMODENG();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.KHDMBIOABDG> FADNEPJPAED(long KAPPFCILLMP, [Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<INACCPCGDCK> CMIJDJHOFAF(FJAIPDANBOO APNOPAAOBED, [Optional] PKADLGDPKME BIFANKLCGAE);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<INACCPCGDCK> EPKOHNMMNPM();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EGIKCJHDNMM();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(FJAIPDANBOO, PKADLGDPKME) JKNDIHDIEOG();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DJLJJDANPIF BMAKCMFEGHJ();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CKDDBFJMFEP(long KAPPFCILLMP);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NNOJNLDFAPK(FJAIPDANBOO APNOPAAOBED, Matchmaking.HHMCCACPCPH DBJBIPJCIKA, (int Major, int? Minor)? ECHOOMPBJHE);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NJKMHJOEPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACHABEAHPED([Out] IEnumerable<int> HEEAHLPFEKD);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNPOIFKIGOG(ADHEHODAAFN HEDGIMBCGHA);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMPGFDEMEEB(ADHEHODAAFN HEDGIMBCGHA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KCONKOAGDBG
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FMBNLCFNOGC(PEJIBHJPOLO HKKCBEKOHIB);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface PNPCNFBPDFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AENINNBLPAN(IPJAEOCKBMK.AODMNBNDNJH GCFKIDAKHFM);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFMKHCJBMBK(IPJAEOCKBMK.AODMNBNDNJH GCFKIDAKHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface JONKNFJJKMH : PNPCNFBPDFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEJIBHJPOLO KGDHMHLPLOK(BJCCECIKIFB JEHLDBHABMD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface LJNGIEKFBAB : PNPCNFBPDFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEJIBHJPOLO KIBICPNGCDH(BJCCECIKIFB DMMFONEMJLA);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OKDOBPADKDO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> KDMLNMKLBLM(Guid? IJGNKDKNEFC, IReadOnlyCollection<PFPKEOCLAOD> NDJHDIJIAHD, IReadOnlyCollection<PFPKEOCLAOD> AMINNPODAKG, FCAFBNILBKI MBGEHLOEOON, long? JKJNCHGDMGL, long? OKLPJIPAHKD, ELMOKFLOKJN.PDPIOPNOHEG JMDKFJOMBGI, CancellationToken DKKNFNCKCEB, bool CJHAFPJCCFI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class BJFELDOCEDH
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public DAFILHNGNBD MJFEHPGDCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<DAFILHNGNBD> PBDBBECHCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<DAFILHNGNBD> CHOOJAILMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xCEAF50", Offset = "0xCE9B50", VA = "0x180CEAF50")]
	public BJFELDOCEDH(DAFILHNGNBD CNCFBLFLBOE, IReadOnlyList<DAFILHNGNBD> POKCKKOGJDE, IReadOnlyList<DAFILHNGNBD> CEKOAJPEFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MOENBGNBLCM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDDPJNIIBBI<KJANINJOKPF<TData>, OGEAAGEPEFJ>> NGLHEIKOPKD(TGetDataArg NOONBIFJDPN, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JNKCCGLPOOL : KMLAPHJELJN, CIIKPBEDJIP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct FDPMPEKABJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JNKCCGLPOOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KJNCMPAKDDO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<PEJIBHJPOLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8610BE0", Offset = "0x860F7E0", VA = "0x188610BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8610E60", Offset = "0x860FA60", VA = "0x188610E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KKFMFPBBNPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JNKCCGLPOOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8619140", Offset = "0x8617D40", VA = "0x188619140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8619370", Offset = "0x8617F70", VA = "0x188619370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PCMONGPDCNE : IEnumerable<GPPJJLABMCM>, IEnumerable, IEnumerator<GPPJJLABMCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private GPPJJLABMCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public JNKCCGLPOOL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private GPPJJLABMCM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public PCMONGPDCNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x861EDD0", Offset = "0x861D9D0", VA = "0x18861EDD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x861F230", Offset = "0x861DE30", VA = "0x18861F230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x861F180", Offset = "0x861DD80", VA = "0x18861F180", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GPPJJLABMCM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x861F180", Offset = "0x861DD80", VA = "0x18861F180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource KBCKMDLIKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PFGPAPHADOM MHCMGFKMEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private DNOFLPLCFPB NEJHAAPOGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool MDNIGFLCMGE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public BHCJDNPMBCM NKAAJFIPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6D0", Offset = "0xA1B2D0", VA = "0x180A1C6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AHLPANAIOHK BNPAMDNACDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6F0", Offset = "0xA1B2F0", VA = "0x180A1C6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6C0", Offset = "0xA1B2C0", VA = "0x180A1C6C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA1C690", Offset = "0xA1B290", VA = "0x180A1C690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public PIHMIMMNDBA FCMAGNJPMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA1C700", Offset = "0xA1B300", VA = "0x180A1C700", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6B0", Offset = "0xA1B2B0", VA = "0x180A1C6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JONKNFJJKMH EMKNPFFABOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA1FDD0", Offset = "0xA1E9D0", VA = "0x180A1FDD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA1FDC0", Offset = "0xA1E9C0", VA = "0x180A1FDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public LJNGIEKFBAB KHHNLLCMMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA2BE40", Offset = "0xA2AA40", VA = "0x180A2BE40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA2BDA0", Offset = "0xA2A9A0", VA = "0x180A2BDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public GNILIMCHNDI NACODKMEDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA2BE00", Offset = "0xA2AA00", VA = "0x180A2BE00", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA2BDB0", Offset = "0xA2A9B0", VA = "0x180A2BDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public FEKGMHDPDLC CDHJNBANDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA2BE50", Offset = "0xA2AA50", VA = "0x180A2BE50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA2BC90", Offset = "0xA2A890", VA = "0x180A2BC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PPEFCDBEFHO GIEHFLBFJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA835A0", Offset = "0xA821A0", VA = "0x180A835A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA804F0", Offset = "0xA7F0F0", VA = "0x180A804F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public JOLGBJADICK DHCBAEJEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA2BD10", Offset = "0xA2A910", VA = "0x180A2BD10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA2BD70", Offset = "0xA2A970", VA = "0x180A2BD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NAOPNHOMAOE GDPIFBDHMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA839C0", Offset = "0xA825C0", VA = "0x180A839C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0B0", Offset = "0xA98CB0", VA = "0x180A9A0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public GEPMPDHAMDP AJNJDKJEINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4A0", Offset = "0xA290A0", VA = "0x180A2A4A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4D0", Offset = "0xA290D0", VA = "0x180A2A4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public BKIPPFDHBMB PAKKKCMPEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA9A080", Offset = "0xA98C80", VA = "0x180A9A080", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA9A030", Offset = "0xA98C30", VA = "0x180A9A030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FNKMNCGLMJF HEGLABBEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAC42F0", Offset = "0xAC2EF0", VA = "0x180AC42F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAC4320", Offset = "0xAC2F20", VA = "0x180AC4320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public LFHNHIGOGPL EMJGHOEANNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA9A050", Offset = "0xA98C50", VA = "0x180A9A050", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4300", Offset = "0xAC2F00", VA = "0x180AC4300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public MIJCCIJBGJK FFIHCMLMOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0D0", Offset = "0xA98CD0", VA = "0x180A9A0D0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA9A010", Offset = "0xA98C10", VA = "0x180A9A010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public HLOHLLJOEPO FAHJBPHKKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA86340", Offset = "0xA84F40", VA = "0x180A86340", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A60", Offset = "0xA84660", VA = "0x180A85A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public POBPCNGMOEG GNHDBCENOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA2A510", Offset = "0xA29110", VA = "0x180A2A510", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4B0", Offset = "0xA290B0", VA = "0x180A2A4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public AGHCGHMFDBD BLFDLKKDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA86350", Offset = "0xA84F50", VA = "0x180A86350", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA85F40", Offset = "0xA84B40", VA = "0x180A85F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IHDJLNKPAOG CCNBOLEDBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA8C600", Offset = "0xA8B200", VA = "0x180A8C600", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA8CF30", Offset = "0xA8BB30", VA = "0x180A8CF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public HPDFOIEFPLD FNCGJOMCIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA8C610", Offset = "0xA8B210", VA = "0x180A8C610", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB50730", Offset = "0xB4F330", VA = "0x180B50730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HIDHECKNOGP DGHJHJHJEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA91310", Offset = "0xA8FF10", VA = "0x180A91310", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA8F530", Offset = "0xA8E130", VA = "0x180A8F530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KDNCNHCJKIB INKLMJOPLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAC08B0", Offset = "0xABF4B0", VA = "0x180AC08B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xABD0C0", Offset = "0xABBCC0", VA = "0x180ABD0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OBEDHHBHEAH ONLAAKOCKND
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA91100", Offset = "0xA8FD00", VA = "0x180A91100", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA8CF10", Offset = "0xA8BB10", VA = "0x180A8CF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public NJKMHJOEPLN IMEJIPIMMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAC0470", Offset = "0xABF070", VA = "0x180AC0470", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAC0900", Offset = "0xABF500", VA = "0x180AC0900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CCCCPGHELOP GDJGKLCAJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA912B0", Offset = "0xA8FEB0", VA = "0x180A912B0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA8FA10", Offset = "0xA8E610", VA = "0x180A8FA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public LMAIAAIDCCF NCFEGMDHGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB4AE10", Offset = "0xB49A10", VA = "0x180B4AE10", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB4E610", Offset = "0xB4D210", VA = "0x180B4E610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public NNNADOAHABC BHLAKDGFOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAC07B0", Offset = "0xABF3B0", VA = "0x180AC07B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xAB7280", Offset = "0xAB5E80", VA = "0x180AB7280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HILDNEGHJLL BDEOENDDCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xAC0460", Offset = "0xABF060", VA = "0x180AC0460", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public BCBMJOELBCH BHMKNAOJEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xB48990", Offset = "0xB47590", VA = "0x180B48990", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public DEGILGJNEEG ENPMONEHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB4E480", Offset = "0xB4D080", VA = "0x180B4E480", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public FEKLGINOHBI DAGHOIKBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xB45D90", Offset = "0xB44990", VA = "0x180B45D90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KMAOLHPGECA EAGEKEFNNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xB5AFF0", Offset = "0xB59BF0", VA = "0x180B5AFF0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PKADLGDPKME MLDKHCNMHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB417F0", Offset = "0xB403F0", VA = "0x180B417F0", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCCA230", Offset = "0xCC8E30", VA = "0x180CCA230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool MNKAFKAOJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x86186E0", Offset = "0x86172E0", VA = "0x1886186E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool MIHKKCPBNIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8618270", Offset = "0x8616E70", VA = "0x188618270", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool ENMPIHKEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2250", Offset = "0x1DA0E50", VA = "0x181DA2250", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken IDPOIADJLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x86187A0", Offset = "0x86173A0", VA = "0x1886187A0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private PFGPAPHADOM KEEDDLPNEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool JIFGNLMFGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2250", Offset = "0x1DA0E50", VA = "0x181DA2250", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E170", Offset = "0x1D9CD70", VA = "0x181D9E170", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event NMAFJGIFFBN CDGGMOPGIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8617A40", Offset = "0x8616640", VA = "0x188617A40", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8618530", Offset = "0x8617130", VA = "0x188618530", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event NMAFJGIFFBN DFMAJAEILCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8617DB0", Offset = "0x86169B0", VA = "0x188617DB0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8617D50", Offset = "0x8616950", VA = "0x188617D50", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event NMAFJGIFFBN KMOIBDPJCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x86187C0", Offset = "0x86173C0", VA = "0x1886187C0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8618820", Offset = "0x8617420", VA = "0x188618820", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<CDKBIPEOCCB, bool> JNKEHAGLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8618680", Offset = "0x8617280", VA = "0x188618680", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x86179E0", Offset = "0x86165E0", VA = "0x1886179E0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xCCA230", Offset = "0xCC8E30", VA = "0x180CCA230", Slot = "39")]
	public void NKBPKAHHIED(PKADLGDPKME FNHNKKBOMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8618880", Offset = "0x8617480", VA = "0x188618880")]
	[UnityEngine.Scripting.Preserve]
	internal JNKCCGLPOOL([GFNPNOLPMKK(null)] PFGPAPHADOM MHCMGFKMEEN, [GFNPNOLPMKK(null)] BHCJDNPMBCM DKIFPHGKANK, [GFNPNOLPMKK(null)] AHLPANAIOHK IBLGAJFAKGL, [GFNPNOLPMKK(null)] AGABMHMNIPB ECPFHMDENEE, [GFNPNOLPMKK(null)] PIHMIMMNDBA JFFNNNBMBAO, [GFNPNOLPMKK(null)] JONKNFJJKMH GDNMDPADKML, [GFNPNOLPMKK(null)] LJNGIEKFBAB GCILBAMPJFN, [GFNPNOLPMKK(null)] FEKGMHDPDLC CBKOAFBLJNL, [GFNPNOLPMKK(null)] PPEFCDBEFHO EHKNPCKNDGO, [GFNPNOLPMKK(null)] JOLGBJADICK CEIBAMPEMKE, [GFNPNOLPMKK(null)] NAOPNHOMAOE OJHGNMCGJFK, [GFNPNOLPMKK(null)] GEPMPDHAMDP MDCIJMKAOOL, [GFNPNOLPMKK(null)] BKIPPFDHBMB PCCAPAGPBLB, [GFNPNOLPMKK(null)] FNKMNCGLMJF MKCPAFAGADL, [GFNPNOLPMKK(null)] LFHNHIGOGPL GELPMKIMIBM, [GFNPNOLPMKK(null)] MIJCCIJBGJK MMJILCHLAAB, [GFNPNOLPMKK(null)] HLOHLLJOEPO IDAEIBJLKFJ, [GFNPNOLPMKK(null)] POBPCNGMOEG BLJPIKFABGA, [GFNPNOLPMKK(null)] AGHCGHMFDBD EMMPNJCKCEL, [GFNPNOLPMKK(null)] IHDJLNKPAOG FHHCOBJFLBJ, [GFNPNOLPMKK(null)] HIDHECKNOGP CIPHKPCJMHB, [GFNPNOLPMKK(null)] HPDFOIEFPLD PPIHKIJDOOJ, [GFNPNOLPMKK(null)] KDNCNHCJKIB EBFMLCCKEBK, [GFNPNOLPMKK(null)] OBEDHHBHEAH JJDCCEMKDLL, [GFNPNOLPMKK(null)] NJKMHJOEPLN LFKMJBMHBCD, [GFNPNOLPMKK(null)] LMAIAAIDCCF JLMFPIBLIFF, [GFNPNOLPMKK(null)] NNNADOAHABC OHCMELMHOMN, [GFNPNOLPMKK(null)] HILDNEGHJLL AICOFDFMPDM, [GFNPNOLPMKK(null)] BCBMJOELBCH DPJJPCLKHON, [GFNPNOLPMKK(null)] DEGILGJNEEG DMEEFMIKHMD, [GFNPNOLPMKK(null)] FEKLGINOHBI DNPJFCGIDIO, [GFNPNOLPMKK(null)] KMAOLHPGECA OJPDDNHKNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8618480", Offset = "0x8617080", VA = "0x188618480")]
	private void LEIJOMGLGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8617BC0", Offset = "0x86167C0", VA = "0x188617BC0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8617F20", Offset = "0x8616B20", VA = "0x188617F20", Slot = "51")]
	private void GBDLPBKIHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8617B30", Offset = "0x8616730", VA = "0x188617B30", Slot = "52")]
	private JFGKLKMBFAO CHDFOBFHJCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8617AA0", Offset = "0x86166A0", VA = "0x188617AA0", Slot = "53")]
	private DNPPCFHAAPG CDMEIEPDPAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8617F70", Offset = "0x8616B70", VA = "0x188617F70", Slot = "55")]
	public Task GCOLKEBPBFD(int IDJFHNCGAIP, BIBLILLBLLL HFJBDNPALNN, Func<JOPODIFOAJI, JOPODIFOAJI> EPGJCAKJAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8617E10", Offset = "0x8616A10", VA = "0x188617E10")]
	private PANLIFGJCEK FPPLOLDFAML(int IDJFHNCGAIP, BIBLILLBLLL HFJBDNPALNN, Func<JOPODIFOAJI, JOPODIFOAJI> EPGJCAKJAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8618370", Offset = "0x8616F70", VA = "0x188618370", Slot = "56")]
	[AsyncStateMachine(typeof(FDPMPEKABJM))]
	private Task<PEJIBHJPOLO> LBKIGEGOPOI(KJNCMPAKDDO NCDCKNMIKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8618590", Offset = "0x8617190", VA = "0x188618590", Slot = "57")]
	[AsyncStateMachine(typeof(KKFMFPBBNPM))]
	private Task MLOHICPDMDM(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x86182F0", Offset = "0x8616EF0", VA = "0x1886182F0")]
	[IteratorStateMachine(typeof(PCMONGPDCNE))]
	private IEnumerable<GPPJJLABMCM> KGJOOOPNCNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8618740", Offset = "0x8617340", VA = "0x188618740")]
	[CompilerGenerated]
	private void NBKOGDBHKOK(GPPJJLABMCM LBEOEMMCAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JLGOPGCPKDA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x19568A0", Offset = "0x19554A0", VA = "0x1819568A0")]
	public JLGOPGCPKDA(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class KOEMOMIGNCF : IFDHFEFMKAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AEFCCPLFALH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<IFDHFEFMKAF.ELEOLIKMJDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<FEKBDPPMKBJ.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KOEMOMIGNCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8602300", Offset = "0x8600F00", VA = "0x188602300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8602600", Offset = "0x8601200", VA = "0x188602600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string IGJEIPKBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x86193D0", Offset = "0x8617FD0", VA = "0x1886193D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public KOEMOMIGNCF(KMLAPHJELJN KFBBLAFGOAP, AGABMHMNIPB ECPFHMDENEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8619400", Offset = "0x8618000", VA = "0x188619400", Slot = "5")]
	[AsyncStateMachine(typeof(AEFCCPLFALH))]
	public Task<IFDHFEFMKAF.ELEOLIKMJDM> KOONPKGGMBG(HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI, CancellationToken DKKNFNCKCEB, FEKBDPPMKBJ.Reason HGJBCNEJGLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class CCHNLPGMPLI : DFKFKPHILDE, IFDHFEFMKAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct BOOEBCMNMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<IFDHFEFMKAF.ELEOLIKMJDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CCHNLPGMPLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<FEKBDPPMKBJ.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public FEKBDPPMKBJ.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private FJAIPDANBOO <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<IFDHFEFMKAF.ELEOLIKMJDM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x86043B0", Offset = "0x8602FB0", VA = "0x1886043B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8604D80", Offset = "0x8603980", VA = "0x188604D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly MFHMPBFKGLM ADPMIMAAEHC;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string IGJEIPKBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8604DF0", Offset = "0x86039F0", VA = "0x188604DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8604FF0", Offset = "0x8603BF0", VA = "0x188604FF0")]
	public CCHNLPGMPLI([GFNPNOLPMKK(null)] KMLAPHJELJN KFBBLAFGOAP, [GFNPNOLPMKK(null)] AGABMHMNIPB ECPFHMDENEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8604E20", Offset = "0x8603A20", VA = "0x188604E20", Slot = "5")]
	[AsyncStateMachine(typeof(BOOEBCMNMDK))]
	public Task<IFDHFEFMKAF.ELEOLIKMJDM> KOONPKGGMBG(HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI, CancellationToken DKKNFNCKCEB, FEKBDPPMKBJ.Reason HGJBCNEJGLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class NCPNDEKOJOH : DFKFKPHILDE, IFDHFEFMKAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NALIFHEJOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<IFDHFEFMKAF.ELEOLIKMJDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NCPNDEKOJOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<FEKBDPPMKBJ.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<INACCPCGDCK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<IFDHFEFMKAF.ELEOLIKMJDM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x861C760", Offset = "0x861B360", VA = "0x18861C760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x861D150", Offset = "0x861BD50", VA = "0x18861D150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string IGJEIPKBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x861D2B0", Offset = "0x861BEB0", VA = "0x18861D2B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public NCPNDEKOJOH(KMLAPHJELJN KFBBLAFGOAP, AGABMHMNIPB ECPFHMDENEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x861D2E0", Offset = "0x861BEE0", VA = "0x18861D2E0", Slot = "5")]
	[AsyncStateMachine(typeof(NALIFHEJOLL))]
	public Task<IFDHFEFMKAF.ELEOLIKMJDM> KOONPKGGMBG(HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI, CancellationToken DKKNFNCKCEB, FEKBDPPMKBJ.Reason HGJBCNEJGLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class GPEBDOOHGIB : DFKFKPHILDE, IFDHFEFMKAF
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class FIJMENCANOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public INACCPCGDCK matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FIJMENCANOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8611780", Offset = "0x8610380", VA = "0x188611780")]
		internal object FNDDGFHAHJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x86116C0", Offset = "0x86102C0", VA = "0x1886116C0")]
		internal object BLLCIHHJENA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct EHNLHMCBDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<IFDHFEFMKAF.ELEOLIKMJDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public GPEBDOOHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<FEKBDPPMKBJ.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FIJMENCANOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public FEKBDPPMKBJ.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<INACCPCGDCK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<IFDHFEFMKAF.ELEOLIKMJDM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x860F430", Offset = "0x860E030", VA = "0x18860F430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x86100C0", Offset = "0x860ECC0", VA = "0x1886100C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly MFHMPBFKGLM ADPMIMAAEHC;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string IGJEIPKBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8612E30", Offset = "0x8611A30", VA = "0x188612E30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8613030", Offset = "0x8611C30", VA = "0x188613030")]
	public GPEBDOOHGIB([GFNPNOLPMKK(null)] KMLAPHJELJN KFBBLAFGOAP, [GFNPNOLPMKK(null)] AGABMHMNIPB ECPFHMDENEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8612E60", Offset = "0x8611A60", VA = "0x188612E60", Slot = "5")]
	[AsyncStateMachine(typeof(EHNLHMCBDGJ))]
	public Task<IFDHFEFMKAF.ELEOLIKMJDM> KOONPKGGMBG(HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI, CancellationToken DKKNFNCKCEB, FEKBDPPMKBJ.Reason HGJBCNEJGLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class DFKFKPHILDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GCOPDFHEECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public JPIBGNDAFKP log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<FEKBDPPMKBJ.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public DFKFKPHILDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<FEKBDPPMKBJ.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8611800", Offset = "0x8610400", VA = "0x188611800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8611D20", Offset = "0x8610920", VA = "0x188611D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x860AE40", Offset = "0x8609A40", VA = "0x18860AE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public DFKFKPHILDE(KMLAPHJELJN KFBBLAFGOAP, AGABMHMNIPB ECPFHMDENEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x860AD10", Offset = "0x8609910", VA = "0x18860AD10")]
	[AsyncStateMachine(typeof(GCOPDFHEECB))]
	protected Task EJLDLONEOOH(JPIBGNDAFKP FAOMHPPHFKM, HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MNCECAJAOIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct IKCOOABKLCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<IFDHFEFMKAF.ELEOLIKMJDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AGABMHMNIPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8614EC0", Offset = "0x8613AC0", VA = "0x188614EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8615240", Offset = "0x8613E40", VA = "0x188615240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HEBOMFNBAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public KMLAPHJELJN roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HEBOMFNBAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8613AC0", Offset = "0x86126C0", VA = "0x188613AC0")]
		internal object DGEAOLJEKOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float MDFALOJONPC;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<FEKBDPPMKBJ.Reason> GENDLKNJODB;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x861C530", Offset = "0x861B130", VA = "0x18861C530")]
	[AsyncStateMachine(typeof(IKCOOABKLCP))]
	internal static Task<IFDHFEFMKAF.ELEOLIKMJDM> KAJCIPJONDC(AGABMHMNIPB ECPFHMDENEE, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x861C3B0", Offset = "0x861AFB0", VA = "0x18861C3B0")]
	internal static void CAFBKOEMIEN(KMLAPHJELJN KFBBLAFGOAP, JPIBGNDAFKP FAOMHPPHFKM, string FPIAJLOPODE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface IFDHFEFMKAF
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ELEOLIKMJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool MBDJGJKJICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public FEKBDPPMKBJ.Reason HGJBCNEJGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? JMGOFOGFPEO;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8610820", Offset = "0x860F420", VA = "0x188610820")]
		public static ELEOLIKMJDM BGFIBGHCIHB()
		{
			return default(ELEOLIKMJDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8610830", Offset = "0x860F430", VA = "0x188610830")]
		public static ELEOLIKMJDM HDODKFHCGEC(FEKBDPPMKBJ.Reason HGJBCNEJGLD, [Optional] Enum? JMGOFOGFPEO)
		{
			return default(ELEOLIKMJDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string PFAODGJOMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ELEOLIKMJDM> KOONPKGGMBG(HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI, CancellationToken DKKNFNCKCEB, FEKBDPPMKBJ.Reason HGJBCNEJGLD);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct OKKHBLOBIAL
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OKDMMKFNGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public KMLAPHJELJN manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OKDMMKFNGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x861E5F0", Offset = "0x861D1F0", VA = "0x18861E5F0")]
		internal Task NICEMOLAPPI(CancellationToken cancellationToken, int roomTotalVersion, KPJEMKAIFIO localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct FFLFLGBLFGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public OKKHBLOBIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private KJNCMPAKDDO <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<IBAAACIAKCF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<PEJIBHJPOLO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x86110C0", Offset = "0x860FCC0", VA = "0x1886110C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8611650", Offset = "0x8610250", VA = "0x188611650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct EOIKNBEFFNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public OKKHBLOBIAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8610860", Offset = "0x860F460", VA = "0x188610860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8610B80", Offset = "0x860F780", VA = "0x188610B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken DKKNFNCKCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly KMLAPHJELJN GMBCCEAGHDM;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private BHCJDNPMBCM NKAAJFIPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x861E690", Offset = "0x861D290", VA = "0x18861E690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x861ED30", Offset = "0x861D930", VA = "0x18861ED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x861E970", Offset = "0x861D570", VA = "0x18861E970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private JOLGBJADICK DHCBAEJEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x861E640", Offset = "0x861D240", VA = "0x18861E640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2927FA0", Offset = "0x2926BA0", VA = "0x182927FA0")]
	public OKKHBLOBIAL(CancellationToken DKKNFNCKCEB, KMLAPHJELJN GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x861E7B0", Offset = "0x861D3B0", VA = "0x18861E7B0")]
	public static NBKIGDOHHEE GGPHGKHPHHD(KMLAPHJELJN GMBCCEAGHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x861E860", Offset = "0x861D460", VA = "0x18861E860")]
	[AsyncStateMachine(typeof(FFLFLGBLFGE))]
	public Task<bool> KNAKIDBGLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x861EB20", Offset = "0x861D720", VA = "0x18861EB20")]
	private bool MBCMEKABODB([Out] KJNCMPAKDDO NCDCKNMIKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x861E6E0", Offset = "0x861D2E0", VA = "0x18861E6E0")]
	[AsyncStateMachine(typeof(EOIKNBEFFNN))]
	private Task BONKOONCJOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x861E9F0", Offset = "0x861D5F0", VA = "0x18861E9F0")]
	private Task<IBAAACIAKCF> LIPOLKLECLD(KJNCMPAKDDO ILOBBGEBLJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct FFAIMEPEPMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly LFHNHIGOGPL GELPMKIMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid DIPCJMNHKDB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(PEJIBHJPOLO, Task)> BBPNJKBPHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8610FF0", Offset = "0x860FBF0", VA = "0x188610FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5278E20", Offset = "0x5277A20", VA = "0x185278E20")]
	public FFAIMEPEPMK(LFHNHIGOGPL GELPMKIMIBM, Guid DIPCJMNHKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8610FA0", Offset = "0x860FBA0", VA = "0x188610FA0")]
	public TaskAwaiter<(PEJIBHJPOLO, Task)> LCIABKLGBLO()
	{
		return default(TaskAwaiter<(PEJIBHJPOLO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8610ED0", Offset = "0x860FAD0", VA = "0x188610ED0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct MIJKFDOPOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(PEJIBHJPOLO, Task)> PFFPNBLDIPJ;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(PEJIBHJPOLO, Task)> BBPNJKBPHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x861B3D0", Offset = "0x8619FD0", VA = "0x18861B3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x861B4B0", Offset = "0x861A0B0", VA = "0x18861B4B0")]
	public MIJKFDOPOFG(TimeSpan AJHEJELDLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x861B410", Offset = "0x861A010", VA = "0x18861B410")]
	public void PCBPCAFPAIA(Task KPHCMIAGIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x861B2B0", Offset = "0x8619EB0", VA = "0x18861B2B0")]
	public void HBDNDECEKHD(PEJIBHJPOLO HKKCBEKOHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x861B260", Offset = "0x8619E60", VA = "0x18861B260")]
	public void BKMNPOBOJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x861B340", Offset = "0x8619F40", VA = "0x18861B340")]
	internal void HPPIFJLPBKE(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class BFDNMEDEGJO
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8602A00", Offset = "0x8601600", VA = "0x188602A00")]
	public static FCFEBPBOLMP AOBMLEBILHN(this FCFEBPBOLMP ADKJHPADFOA, KINJLHLHADG NIIOOOMELDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8602BA0", Offset = "0x86017A0", VA = "0x188602BA0")]
	public static FCFEBPBOLMP HLCDDPLJBPK(this FCFEBPBOLMP ADKJHPADFOA, MBONFMDKIOA NBJCOHMPBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class HFGIMFFFLNE : GNILIMCHNDI
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IKGNKDCOABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public MBONFMDKIOA subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IKGNKDCOABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x86152B0", Offset = "0x8613EB0", VA = "0x1886152B0")]
		internal bool HHLNNJBEBDN(CGPLGKCGOLD s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly LMAIAAIDCCF NODKOBAEEFC;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public HFGIMFFFLNE(LMAIAAIDCCF JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8613BC0", Offset = "0x86127C0", VA = "0x188613BC0", Slot = "4")]
	public FCFEBPBOLMP GLOMJONEBBE(long IOJMBMGDHLE, long OKLPJIPAHKD, string OJPCFKOJIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8613C50", Offset = "0x8612850", VA = "0x188613C50", Slot = "5")]
	public FCFEBPBOLMP GLOMJONEBBE(long IOJMBMGDHLE, long OKLPJIPAHKD, IDLFIGEMLKL OLNOBDEBFAH, Guid? FHFKDGOEDCH, long MEDPANLILPF, bool FACBGOABMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8613DB0", Offset = "0x86129B0", VA = "0x188613DB0", Slot = "6")]
	public FCFEBPBOLMP GLOMJONEBBE(NHMGHNEDIJJ LHKPCCDEIAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8613FB0", Offset = "0x8612BB0", VA = "0x188613FB0", Slot = "7")]
	public FCFEBPBOLMP GLOMJONEBBE(KINJLHLHADG HOFCPMDMKNN, MBONFMDKIOA GHEKBPNLCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8614290", Offset = "0x8612E90", VA = "0x188614290")]
	private Guid? ILCKCFLJNBI(KINJLHLHADG NOOPBNECHDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class OFDIPAGKINP : PPEFCDBEFHO, GPPJJLABMCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct EICDLPPCPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public OFDIPAGKINP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8610130", Offset = "0x860ED30", VA = "0x188610130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x86107C0", Offset = "0x860F3C0", VA = "0x1886107C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ADHEHODAAFN HJDIGMFFIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string JIFEEHKDPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task MDDLBOLKPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LKLDMEIEHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x861E350", Offset = "0x861CF50", VA = "0x18861E350", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task IPHDJLNKHPN
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x861E380", Offset = "0x861CF80", VA = "0x18861E380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40", Slot = "7")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x861E0D0", Offset = "0x861CCD0", VA = "0x18861E0D0", Slot = "6")]
	public void AKACLMEACEJ(Task NKDMFOKACBI, string EAAJAIOPHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x861E230", Offset = "0x861CE30", VA = "0x18861E230")]
	[AsyncStateMachine(typeof(EICDLPPCPJD))]
	private Task EJOJLNCMLLL(Task NFMIFKJOJIN, string EAAJAIOPHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x861E410", Offset = "0x861D010", VA = "0x18861E410")]
	public OFDIPAGKINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class LPMIDCACFID : CCCCPGHELOP, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool NPJDJFBLIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ADJJNPCIJEO EPMKDOKMOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private LMAIAAIDCCF JLMFPIBLIFF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ADJJNPCIJEO JMGGCOKAODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8619B70", Offset = "0x8618770", VA = "0x188619B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8619CA0", Offset = "0x86188A0", VA = "0x188619CA0", Slot = "7")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8619E20", Offset = "0x8618A20", VA = "0x188619E20", Slot = "5")]
	public void OPEONEDLPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8619B30", Offset = "0x8618730", VA = "0x188619B30", Slot = "6")]
	public void AEONHKMAEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8619BE0", Offset = "0x86187E0", VA = "0x188619BE0")]
	private Task CLLEMKOKIIK(NOMHGALJMIA NGGJJFKLDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8619B30", Offset = "0x8618730", VA = "0x188619B30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LPMIDCACFID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class PNHJKLIJAIN : LMAIAAIDCCF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class DPMBGPJJPEN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly FJCEKCIPLIL DDNEOJGAKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string MEPFFFGIFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T IPOLOHBNCGD;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xAA8AE0", Offset = "0xAA76E0", VA = "0x180AA8AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x42DD6B0", Offset = "0x42DC2B0", VA = "0x1842DD6B0")]
		public DPMBGPJJPEN(FJCEKCIPLIL DDNEOJGAKLE, string MEPFFFGIFGB, T IPOLOHBNCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x42DD2B0", Offset = "0x42DBEB0", VA = "0x1842DD2B0")]
		private void HJKNCGNCHBO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly FJCEKCIPLIL DDNEOJGAKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly DPMBGPJJPEN<TimeSpan> BCJBAAAGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly DPMBGPJJPEN<TimeSpan> DILKKEGECGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly DPMBGPJJPEN<TimeSpan> FCOKOLDDLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly DPMBGPJJPEN<TimeSpan> KCEJGAPKNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly DPMBGPJJPEN<bool> CNIBELGPCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly DPMBGPJJPEN<bool> ECGJBBNBPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly DPMBGPJJPEN<bool> KCDIJABKLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DPMBGPJJPEN<int> OOCFLNAAFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly DPMBGPJJPEN<bool> AGCLKOPMHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly DPMBGPJJPEN<bool> ALEOIOLNBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly DPMBGPJJPEN<GECCANMBMAE> DCNILBEGMJN;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan NPPMFKGJOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8620290", Offset = "0x861EE90", VA = "0x188620290", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan APLJNIEJMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x86204A0", Offset = "0x861F0A0", VA = "0x1886204A0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan LABCLKAPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8620460", Offset = "0x861F060", VA = "0x188620460", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan OLLGNFGLLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x86204E0", Offset = "0x861F0E0", VA = "0x1886204E0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DJILCHGFLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8620350", Offset = "0x861EF50", VA = "0x188620350", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BMEEIJBFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x86202D0", Offset = "0x861EED0", VA = "0x1886202D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DEAKKIIPPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8620420", Offset = "0x861F020", VA = "0x188620420", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int AMEFCIHMJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8620250", Offset = "0x861EE50", VA = "0x188620250", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool CHKPEMLHMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8620310", Offset = "0x861EF10", VA = "0x188620310", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FDAKOIINKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8620390", Offset = "0x861EF90", VA = "0x188620390", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LLEILPPMAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x86203D0", Offset = "0x861EFD0", VA = "0x1886203D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8620520", Offset = "0x861F120", VA = "0x188620520")]
	[UnityEngine.Scripting.Preserve]
	public PNHJKLIJAIN([GFNPNOLPMKK(null)] FJCEKCIPLIL DDNEOJGAKLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class IOGKFAILLPI : NAOPNHOMAOE, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class NFNEOFJBKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LFGJEGOCDII roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NFNEOFJBKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x861D4B0", Offset = "0x861C0B0", VA = "0x18861D4B0")]
		internal object GIEABPONPEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event NMAFJGIFFBN HLJNAGDPFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8617010", Offset = "0x8615C10", VA = "0x188617010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x86170B0", Offset = "0x8615CB0", VA = "0x1886170B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NMAFJGIFFBN BMMOPBHKDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8616F70", Offset = "0x8615B70", VA = "0x188616F70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8617220", Offset = "0x8615E20", VA = "0x188617220", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event NMAFJGIFFBN MHMLKIBIBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8617560", Offset = "0x8616160", VA = "0x188617560", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8617180", Offset = "0x8615D80", VA = "0x188617180", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CDKBIPEOCCB, bool> ININDAMEOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x86172C0", Offset = "0x8615EC0", VA = "0x1886172C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8617600", Offset = "0x8616200", VA = "0x188617600", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "16")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8616F40", Offset = "0x8615B40", VA = "0x188616F40", Slot = "12")]
	public void BHEDBAFNEJM(LFGJEGOCDII DCFHCALNHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8617530", Offset = "0x8616130", VA = "0x188617530", Slot = "13")]
	public void LFGPHNMFPGJ(LFGJEGOCDII DCFHCALNHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8617150", Offset = "0x8615D50", VA = "0x188617150", Slot = "14")]
	public void CFEHIANLEAN(LFGJEGOCDII DCFHCALNHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8616EF0", Offset = "0x8615AF0", VA = "0x188616EF0", Slot = "15")]
	public void ACNEFELKPCP(CDKBIPEOCCB MKMDKJJLADP, bool MBDJGJKJICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8617370", Offset = "0x8615F70", VA = "0x188617370")]
	private void JMCDHFFLEOJ(NMAFJGIFFBN BGDIJBGKCDF, LFGJEGOCDII DCFHCALNHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public IOGKFAILLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class ADCBDMGBOLB : GEPMPDHAMDP, GPPJJLABMCM, IDisposable, FEKBDPPMKBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class ILJCLINDAPI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct DHPEDNODDAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public ILJCLINDAPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public FEKBDPPMKBJ.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private GFJANGGIPEI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private IFDHFEFMKAF[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private TaskAwaiter<IFDHFEFMKAF.ELEOLIKMJDM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x860B220", Offset = "0x8609E20", VA = "0x18860B220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x860B950", Offset = "0x860A550", VA = "0x18860B950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct PMKEEOIFBDB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public AsyncTaskMethodBuilder<IFDHFEFMKAF.ELEOLIKMJDM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public IFDHFEFMKAF fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public ILJCLINDAPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public FEKBDPPMKBJ.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private GFJANGGIPEI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private IHELKCNAFNM <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private TaskAwaiter<IFDHFEFMKAF.ELEOLIKMJDM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x861F540", Offset = "0x861E140", VA = "0x18861F540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x86201E0", Offset = "0x861EDE0", VA = "0x1886201E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class JCGGMFEIGKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public IFDHFEFMKAF fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public JCGGMFEIGKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x8617960", Offset = "0x8616560", VA = "0x188617960")]
			internal object BLHDAOCBDHB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task NKDMFOKACBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource CMAEPNBICHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public IHELKCNAFNM IPJDNCNKEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AGABMHMNIPB ECPFHMDENEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public INCMOAEKENF CJODGOCPEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FJAIPDANBOO APNOPAAOBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public IFDHFEFMKAF[] PMINBFFNONH;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool GHBNADMNCLG
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8614950", Offset = "0x8613550", VA = "0x188614950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool COINOHIOAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8614910", Offset = "0x8613510", VA = "0x188614910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8616DD0", Offset = "0x86159D0", VA = "0x188616DD0")]
		public ILJCLINDAPI(AGABMHMNIPB ECPFHMDENEE, INCMOAEKENF CJODGOCPEIP, FJAIPDANBOO APNOPAAOBED, IFDHFEFMKAF[] PMINBFFNONH, CancellationToken DKKNFNCKCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8615960", Offset = "0x8614560", VA = "0x188615960", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8615580", Offset = "0x8614180", VA = "0x188615580")]
		public void DAFPKPKNKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x86167F0", Offset = "0x86153F0", VA = "0x1886167F0")]
		public void PAHCACHLOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8616080", Offset = "0x8614C80", VA = "0x188616080")]
		public void NHJPIICBOLI(FEKBDPPMKBJ.Reason BFJBOJAPLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x86166F0", Offset = "0x86152F0", VA = "0x1886166F0")]
		[AsyncStateMachine(typeof(DHPEDNODDAE))]
		public Task OCFEDDNIKEH(FEKBDPPMKBJ.Reason HGJBCNEJGLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8615440", Offset = "0x8614040", VA = "0x188615440")]
		[AsyncStateMachine(typeof(PMKEEOIFBDB))]
		private Task<IFDHFEFMKAF.ELEOLIKMJDM> CNCPLBCPIAN(FEKBDPPMKBJ.Reason HGJBCNEJGLD, IFDHFEFMKAF NCEEBKMLLPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8615AF0", Offset = "0x86146F0", VA = "0x188615AF0")]
		private void EHAJCKDJDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8615C10", Offset = "0x8614810", VA = "0x188615C10")]
		public bool HDGMALPGCKA(FEKBDPPMKBJ.Reason CLMIMFGPFON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8615CC0", Offset = "0x86148C0", VA = "0x188615CC0")]
		private void MCEMIKPOBND(IHELKCNAFNM DKILGKEHOLM, FEKBDPPMKBJ.Reason HGJBCNEJGLD = FEKBDPPMKBJ.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x86155F0", Offset = "0x86141F0", VA = "0x1886155F0")]
		private void DGLADNBCJNA(IHELKCNAFNM DKILGKEHOLM, IFDHFEFMKAF.ELEOLIKMJDM DBJBIPJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x86157C0", Offset = "0x86143C0", VA = "0x1886157C0")]
		private void DIEJFILAKFA(IHELKCNAFNM DKILGKEHOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8616330", Offset = "0x8614F30", VA = "0x188616330")]
		private void NPANGNFJGOO(IHELKCNAFNM DKILGKEHOLM, IFDHFEFMKAF.ELEOLIKMJDM DBJBIPJCIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x86152E0", Offset = "0x8613EE0", VA = "0x1886152E0")]
		private void AIBAAJLBNGE(IHELKCNAFNM DKILGKEHOLM, Exception DFLKFAIHDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8615F70", Offset = "0x8614B70", VA = "0x188615F70")]
		private void MPNELCIKNCI(IFDHFEFMKAF NCEEBKMLLPA, FEKBDPPMKBJ.Reason HGJBCNEJGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8616950", Offset = "0x8615550", VA = "0x188616950")]
		private void PCLIPOJHNCO(IFDHFEFMKAF NCEEBKMLLPA, FEKBDPPMKBJ.Reason HGJBCNEJGLD, string JMGOFOGFPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8616A60", Offset = "0x8615660", VA = "0x188616A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class IHELKCNAFNM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<IFDHFEFMKAF.ELEOLIKMJDM> NKDMFOKACBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource CMAEPNBICHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public IFDHFEFMKAF NCEEBKMLLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public FEKBDPPMKBJ.Reason BFJBOJAPLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<FEKBDPPMKBJ.Reason> JOIHGMGPICI;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool GHBNADMNCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8614950", Offset = "0x8613550", VA = "0x188614950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool COINOHIOAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8614910", Offset = "0x8613510", VA = "0x188614910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8614970", Offset = "0x8613570", VA = "0x188614970")]
		public void LEAINMHIBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8614930", Offset = "0x8613530", VA = "0x188614930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8614AD0", Offset = "0x86136D0", VA = "0x188614AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8614E30", Offset = "0x8613A30", VA = "0x188614E30")]
		public IHELKCNAFNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class OGEBEHJIDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public FEKBDPPMKBJ.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OGEBEHJIDEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x861E580", Offset = "0x861D180", VA = "0x18861E580")]
		internal object OEJLPODAFIC(IHELKCNAFNM x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x861E4A0", Offset = "0x861D0A0", VA = "0x18861E4A0")]
		internal object FGIHPKPNFAL(ILJCLINDAPI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x861E510", Offset = "0x861D110", VA = "0x18861E510")]
		internal object MNMPLHNKFCK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct NIDGNCFGKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public FEKBDPPMKBJ.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ADCBDMGBOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private OGEBEHJIDEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x861D590", Offset = "0x861C190", VA = "0x18861D590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x861DFF0", Offset = "0x861CBF0", VA = "0x18861DFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct MLEDLNCMPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public ADCBDMGBOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public FEKBDPPMKBJ.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private ILJCLINDAPI <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x861B6E0", Offset = "0x861A2E0", VA = "0x18861B6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x861C350", Offset = "0x861AF50", VA = "0x18861C350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct IGDFGBCHNKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ADCBDMGBOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8614340", Offset = "0x8612F40", VA = "0x188614340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x86148B0", Offset = "0x86134B0", VA = "0x1886148B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly JPIBGNDAFKP IPNEIPEHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private ILJCLINDAPI PKPEEIKHIHH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8601DD0", Offset = "0x86009D0", VA = "0x188601DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool IEAKGOOIGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x256EB60", Offset = "0x256D760", VA = "0x18256EB60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool GHLNNPKFJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8601670", Offset = "0x8600270", VA = "0x188601670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8601E20", Offset = "0x8600A20", VA = "0x188601E20", Slot = "6")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8601660", Offset = "0x8600260", VA = "0x188601660", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8601C50", Offset = "0x8600850", VA = "0x188601C50", Slot = "9")]
	public void LEAINMHIBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8601B70", Offset = "0x8600770", VA = "0x188601B70")]
	private bool INEOGDFFEKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8601EA0", Offset = "0x8600AA0", VA = "0x188601EA0", Slot = "5")]
	private void MEOHDNBLMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8602150", Offset = "0x8600D50", VA = "0x188602150", Slot = "8")]
	[AsyncStateMachine(typeof(NIDGNCFGKIA))]
	public Task OOPAPDLBOJB(FEKBDPPMKBJ.Reason HGJBCNEJGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8601390", Offset = "0x85FFF90", VA = "0x188601390")]
	private bool AICKLEBAGBA(FEKBDPPMKBJ.Reason HGJBCNEJGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x86016E0", Offset = "0x86002E0", VA = "0x1886016E0")]
	private IFDHFEFMKAF[] GMMPAMMNOLE(FJAIPDANBOO PBJHBPFLBHJ, INCMOAEKENF LCKLIKJDFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8601F70", Offset = "0x8600B70", VA = "0x188601F70")]
	[AsyncStateMachine(typeof(MLEDLNCMPMI))]
	private Task MHPDHABBPHL(FEKBDPPMKBJ.Reason HGJBCNEJGLD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8602080", Offset = "0x8600C80", VA = "0x188602080")]
	[AsyncStateMachine(typeof(IGDFGBCHNKB))]
	private Task NFFNHPCEPHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public ADCBDMGBOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class ECEGFLHOMKA : BKIPPFDHBMB, GPPJJLABMCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct HAMLIKPKHGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public PKADLGDPKME customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8613100", Offset = "0x8611D00", VA = "0x188613100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8613A60", Offset = "0x8612660", VA = "0x188613A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct BLDOGFEOFHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public PKADLGDPKME customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private HMEJDNPIBLC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private GFJANGGIPEI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private OIDEJNGNBIE <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private AJNIIKFDODJ <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8603210", Offset = "0x8601E10", VA = "0x188603210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8604350", Offset = "0x8602F50", VA = "0x188604350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class MKKIOACOBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Matchmaking.HHMCCACPCPH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public LDEHOCDMOMK errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MKKIOACOBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x861B630", Offset = "0x861A230", VA = "0x18861B630")]
		internal object EADGGPBIAHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class JCCKCKFCOAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Task<FCFEBPBOLMP> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JCCKCKFCOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		internal Task<FCFEBPBOLMP> FLAJFFAGMKD(HMEJDNPIBLC<string>.FIEDNALJEDE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct CJKLOFLLDKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PKADLGDPKME customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public OIDEJNGNBIE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private JCCKCKFCOAE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private FGLHPFEEAKO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private GFJANGGIPEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private JAEEODMGAEH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private Task<Matchmaking.KHDMBIOABDG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private AFMDKGGKFEH <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<Matchmaking.KHDMBIOABDG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<FCFEBPBOLMP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x86050C0", Offset = "0x8603CC0", VA = "0x1886050C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x860AA30", Offset = "0x8609630", VA = "0x18860AA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class GEIKMLKLFPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task<FCFEBPBOLMP> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GEIKMLKLFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		internal Task<FCFEBPBOLMP> GGFNGDNKFAD(HMEJDNPIBLC<string>.FIEDNALJEDE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct NNLGOKPOJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public PKADLGDPKME customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public OIDEJNGNBIE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private FGLHPFEEAKO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private GFJANGGIPEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private JAEEODMGAEH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private Task<Matchmaking.KHDMBIOABDG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private FCFEBPBOLMP <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private JHGGDGBLLHI <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter<FCFEBPBOLMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private AFMDKGGKFEH <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private FFICKDGENGB <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private IHAEAKFMLLN <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter<JBLHFNLKPCH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter<Matchmaking.KHDMBIOABDG> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8636620", Offset = "0x8635220", VA = "0x188636620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x863BC90", Offset = "0x863A890", VA = "0x18863BC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct CILOOONBDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8625460", Offset = "0x8624060", VA = "0x188625460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8625EC0", Offset = "0x8624AC0", VA = "0x188625EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct FPMOGDGCAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private PFGPAPHADOM <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x862ADF0", Offset = "0x86299F0", VA = "0x18862ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x862B270", Offset = "0x8629E70", VA = "0x18862B270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct BBLBPDGIFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder<Matchmaking.KHDMBIOABDG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter<Matchmaking.KHDMBIOABDG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8623130", Offset = "0x8621D30", VA = "0x188623130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8623600", Offset = "0x8622200", VA = "0x188623600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct HDLJAFNBGEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public Matchmaking.KHDMBIOABDG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public OIDEJNGNBIE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter<JPCFODNEBNL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x862B850", Offset = "0x862A450", VA = "0x18862B850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x862BE90", Offset = "0x862AA90", VA = "0x18862BE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class AKACPAOKAEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AKACPAOKAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8622F30", Offset = "0x8621B30", VA = "0x188622F30")]
		internal object HMDIBPDCGNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8623030", Offset = "0x8621C30", VA = "0x188623030")]
		internal string IGIOACJCBBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct AILOHJNAGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private AKACPAOKAEK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8622340", Offset = "0x8620F40", VA = "0x188622340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8622ED0", Offset = "0x8621AD0", VA = "0x188622ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct FJIPGOCJKFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public OIDEJNGNBIE joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public FCFEBPBOLMP initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public FJAIPDANBOO targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public JHGGDGBLLHI preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public FGLHPFEEAKO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x862A4F0", Offset = "0x86290F0", VA = "0x18862A4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x862ACE0", Offset = "0x86298E0", VA = "0x18862ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct IADHKDGKPAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private GFJANGGIPEI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private GFJANGGIPEI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x862C830", Offset = "0x862B430", VA = "0x18862C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x862E010", Offset = "0x862CC10", VA = "0x18862E010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct JCAKGOIGEJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public KPJEMKAIFIO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public ECEGFLHOMKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<PEJIBHJPOLO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x862E510", Offset = "0x862D110", VA = "0x18862E510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x862ED00", Offset = "0x862D900", VA = "0x18862ED00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class EMGNDLCPEFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EMGNDLCPEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8628BC0", Offset = "0x86277C0", VA = "0x188628BC0")]
		internal object JFOBPMKJCOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class IDEKJFGOCEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IDEKJFGOCEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x862E070", Offset = "0x862CC70", VA = "0x18862E070")]
		internal void IGONBBONAMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class KGNKGBACBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KGNKGBACBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x86319C0", Offset = "0x86305C0", VA = "0x1886319C0")]
		internal object ANFMOLOCODN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class OIBICCNIOFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OIBICCNIOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x863CD50", Offset = "0x863B950", VA = "0x18863CD50")]
		internal string GMPMDBJMGHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly JPIBGNDAFKP BKANDKCOPFL;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly JPIBGNDAFKP NKIDLDJBFBI;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly JPIBGNDAFKP OJNIJBKPBNB;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly string PPKAJIGEGNO;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string BDNLGGIFABJ;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string LCEBFGOBMDO;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public static readonly Guid LPGPDNPKOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private FEKGMHDPDLC CBKOAFBLJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private AHLPANAIOHK IBLGAJFAKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private GEPMPDHAMDP MDCIJMKAOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private PPEFCDBEFHO EHKNPCKNDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NAOPNHOMAOE OJHGNMCGJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private DEGILGJNEEG DMEEFMIKHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private BCBMJOELBCH DPJJPCLKHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private IDisposable IHCKHMHDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private KMAOLHPGECA OJPDDNHKNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly ADHEHODAAFN KBNKEENIOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private AFMDKGGKFEH EKEODKILPMC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus HLGIHONJOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA44D80", Offset = "0xA43980", VA = "0x180A44D80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x147E090", Offset = "0x147CC90", VA = "0x18147E090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x860E120", Offset = "0x860CD20", VA = "0x18860E120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x860E170", Offset = "0x860CD70", VA = "0x18860E170", Slot = "6")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x860C8D0", Offset = "0x860B4D0", VA = "0x18860C8D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x860E620", Offset = "0x860D220", VA = "0x18860E620", Slot = "5")]
	[AsyncStateMachine(typeof(HAMLIKPKHGM))]
	public Task LHMLBIMHLFI(FJAIPDANBOO EBAJJCNAANO, PKADLGDPKME BIFANKLCGAE, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x860BD70", Offset = "0x860A970", VA = "0x18860BD70")]
	[AsyncStateMachine(typeof(BLDOGFEOFHD))]
	private Task CGNOLKJEKFA(FJAIPDANBOO EBAJJCNAANO, PKADLGDPKME BIFANKLCGAE, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x860C070", Offset = "0x860AC70", VA = "0x18860C070")]
	private void DAHBFOIMDLB(DEGILGJNEEG DMEEFMIKHMD, FJAIPDANBOO EBAJJCNAANO, Exception DFLKFAIHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x860CA60", Offset = "0x860B660", VA = "0x18860CA60")]
	private static void EKLCEKHIILA(AJNIIKFDODJ PPKAHMHBMAN, Exception DFLKFAIHDKI, [Optional] List<int> FNCLHJJKAEJ, int KOKDDONIMEC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x860DC30", Offset = "0x860C830", VA = "0x18860DC30")]
	[AsyncStateMachine(typeof(CJKLOFLLDKE))]
	private Task JEOOJIDGBAH(HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, FJAIPDANBOO EBAJJCNAANO, PKADLGDPKME BIFANKLCGAE, OIDEJNGNBIE ACBCONEJIPG, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x860DF30", Offset = "0x860CB30", VA = "0x18860DF30")]
	[AsyncStateMachine(typeof(NNLGOKPOJPI))]
	private Task KBAHINKNFGG(HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, FJAIPDANBOO EBAJJCNAANO, PKADLGDPKME BIFANKLCGAE, OIDEJNGNBIE ACBCONEJIPG, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x860E9B0", Offset = "0x860D5B0", VA = "0x18860E9B0")]
	private void MAIOGPJPJAE([CallerMemberName] string FFKHOMDOFGD = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x860BC40", Offset = "0x860A840", VA = "0x18860BC40")]
	[AsyncStateMachine(typeof(CILOOONBDDB))]
	private Task BOFFMGEBDHA(HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x860D3E0", Offset = "0x860BFE0", VA = "0x18860D3E0")]
	private void GLFGIPLLEDK(FJAIPDANBOO EBAJJCNAANO, CancellationToken DCACDPOIBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x860EBC0", Offset = "0x860D7C0", VA = "0x18860EBC0")]
	private void ODCOCAHJOAF(FJAIPDANBOO EBAJJCNAANO, TaskStatus EAMDNJPMPAF, string FNFIPKNHEOF, OIDEJNGNBIE ACBCONEJIPG, Exception OBGCCKHNEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x860DB50", Offset = "0x860C750", VA = "0x18860DB50")]
	private void ICBNBEECHMA(FJAIPDANBOO EBAJJCNAANO, OIDEJNGNBIE ACBCONEJIPG, OperationCanceledException JBDLMEBGBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x860DA70", Offset = "0x860C670", VA = "0x18860DA70")]
	private void HMIMILCIHDM(FJAIPDANBOO EBAJJCNAANO, OIDEJNGNBIE ACBCONEJIPG, Exception DFLKFAIHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x860C4D0", Offset = "0x860B0D0", VA = "0x18860C4D0")]
	private void DKLGCLOJGAI(FJAIPDANBOO EBAJJCNAANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x860DBD0", Offset = "0x860C7D0", VA = "0x18860DBD0")]
	private static LFGJEGOCDII IENECCHAHCJ(FJAIPDANBOO EBAJJCNAANO)
	{
		return default(LFGJEGOCDII);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x860F0D0", Offset = "0x860DCD0", VA = "0x18860F0D0")]
	[AsyncStateMachine(typeof(FPMOGDGCAKK))]
	private Task PGKCIIFLFGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x860D280", Offset = "0x860BE80", VA = "0x18860D280")]
	[AsyncStateMachine(typeof(BBLBPDGIFIE))]
	private Task<Matchmaking.KHDMBIOABDG> FADNEPJPAED(FJAIPDANBOO EBAJJCNAANO, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x860D710", Offset = "0x860C310", VA = "0x18860D710")]
	private static JPCFODNEBNL HEOECILEPED(Matchmaking.KHDMBIOABDG OKBEKAKAFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x860E860", Offset = "0x860D460", VA = "0x18860E860")]
	[AsyncStateMachine(typeof(HDLJAFNBGEL))]
	private Task LNKGLJCAOMF(Matchmaking.KHDMBIOABDG OKBEKAKAFCG, OIDEJNGNBIE ACBCONEJIPG, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken FAPJDOCGKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x860DDF0", Offset = "0x860C9F0", VA = "0x18860DDF0")]
	[AsyncStateMachine(typeof(AILOHJNAGHJ))]
	private Task JONFDACIIBM(FJAIPDANBOO EBAJJCNAANO, CancellationTokenSource NOMHBBMJOLB, Task AIBAFMNBLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x860EF50", Offset = "0x860DB50", VA = "0x18860EF50")]
	[AsyncStateMachine(typeof(FJIPGOCJKFJ))]
	private Task ONBCCHKCKDK(FCFEBPBOLMP ACGKDMFKKMI, FGLHPFEEAKO HAPILEADHHI, FJAIPDANBOO NDDAELIAMNL, OIDEJNGNBIE ENLLFGMGJEN, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken FBPLCIEPKLH, [Optional] JHGGDGBLLHI KKADINGOJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x860C6E0", Offset = "0x860B2E0", VA = "0x18860C6E0")]
	private OIDEJNGNBIE DLKLKBGAMAL(OIDEJNGNBIE ENLLFGMGJEN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x860C920", Offset = "0x860B520", VA = "0x18860C920")]
	[AsyncStateMachine(typeof(IADHKDGKPAE))]
	private Task EGANGIPIICP(HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x860EE20", Offset = "0x860DA20", VA = "0x18860EE20")]
	[AsyncStateMachine(typeof(JCAKGOIGEJN))]
	private Task OLDMNMEMGDG(CancellationToken DKKNFNCKCEB, int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x860E4A0", Offset = "0x860D0A0", VA = "0x18860E4A0")]
	private static void LFBNIEBIBKN(FJAIPDANBOO EBAJJCNAANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x860D820", Offset = "0x860C420", VA = "0x18860D820")]
	private void HKAGHKOJBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x860BBB0", Offset = "0x860A7B0", VA = "0x18860BBB0")]
	private void BHDEFBCIGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x860EB30", Offset = "0x860D730", VA = "0x18860EB30")]
	private void MNMCLKNKMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x860E090", Offset = "0x860CC90", VA = "0x18860E090")]
	private void KKJNMNENAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x860BAC0", Offset = "0x860A6C0", VA = "0x18860BAC0")]
	private static void BBCCNHBJFEE(FJAIPDANBOO EBAJJCNAANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x860B9B0", Offset = "0x860A5B0", VA = "0x18860B9B0")]
	private static CancellationTokenRegistration ABNAPGDBCMN(FJAIPDANBOO EBAJJCNAANO, CancellationToken FAPJDOCGKOD)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x860E760", Offset = "0x860D360", VA = "0x18860E760")]
	private static void LJABHGMPPEA(FJAIPDANBOO EBAJJCNAANO, Exception DFLKFAIHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x860BEC0", Offset = "0x860AAC0", VA = "0x18860BEC0")]
	private void CJMEMGDIKDH(FJAIPDANBOO EBAJJCNAANO, Task AIBAFMNBLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x860DAF0", Offset = "0x860C6F0", VA = "0x18860DAF0")]
	private static void HOEGMFFOKBK(Func<string> LLCGHFNIHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x860F3A0", Offset = "0x860DFA0", VA = "0x18860F3A0")]
	public ECEGFLHOMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x860DD90", Offset = "0x860C990", VA = "0x18860DD90")]
	[CompilerGenerated]
	internal static (int, int?) JICAMDBCJMN(LDEHOCDMOMK ECHOOMPBJHE)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.NoEngine.Common.Preserve]
internal class PPGKLDMBDPF : FNKMNCGLMJF, GPPJJLABMCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct EOOHPPHBMHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public PPGKLDMBDPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public KPJEMKAIFIO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8628D90", Offset = "0x8627990", VA = "0x188628D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8629270", Offset = "0x8627E70", VA = "0x188629270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class EKPDPADJOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public PPGKLDMBDPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public KPJEMKAIFIO localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EKPDPADJOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8628B80", Offset = "0x8627780", VA = "0x188628B80")]
		internal List<Task> HNPKOELKPGF(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct INMGAKIGPNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public NBKIGDOHHEE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public KPJEMKAIFIO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x862E110", Offset = "0x862CD10", VA = "0x18862E110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x862E4B0", Offset = "0x862D0B0", VA = "0x18862E4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct CLAOMLBFOMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public PPGKLDMBDPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8625F20", Offset = "0x8624B20", VA = "0x188625F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8626200", Offset = "0x8624E00", VA = "0x188626200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private readonly HashSet<NBKIGDOHHEE> IHHAODIOCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private AHLPANAIOHK IBLGAJFAKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private LCOFMHPCGFG AMCMPKAKGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private LNILGEDDNDG NGHFAKHIFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private IDisposable IHCKHMHDJFE;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8640690", Offset = "0x863F290", VA = "0x188640690", Slot = "5")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x86402A0", Offset = "0x863EEA0", VA = "0x1886402A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8640970", Offset = "0x863F570", VA = "0x188640970", Slot = "4")]
	public bool LHIOPALCKIM(NBKIGDOHHEE KHEBJFKNPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8640100", Offset = "0x863ED00", VA = "0x188640100")]
	private void AGHMIKGKKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x86403F0", Offset = "0x863EFF0", VA = "0x1886403F0")]
	private void INDMNJGEPKG(KGGEOPPOKLC DEELHKGGHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8640300", Offset = "0x863EF00", VA = "0x188640300")]
	[AsyncStateMachine(typeof(EOOHPPHBMHP))]
	private Task GOJLLDOPAIM(int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8641010", Offset = "0x863FC10", VA = "0x188641010")]
	private Func<CancellationToken, List<Task>> PAFGIPIPELH(int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x86409D0", Offset = "0x863F5D0", VA = "0x1886409D0")]
	private List<Task> LLKOFODJPGP(int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8640EF0", Offset = "0x863FAF0", VA = "0x188640EF0")]
	[AsyncStateMachine(typeof(INMGAKIGPNG))]
	private Task OEPCCKGCMJB(NBKIGDOHHEE NLJABCHLKFD, CancellationToken HEDGIMBCGHA, int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x86401D0", Offset = "0x863EDD0", VA = "0x1886401D0")]
	[AsyncStateMachine(typeof(CLAOMLBFOMJ))]
	private Task DBGIEGBBPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8640610", Offset = "0x863F210", VA = "0x188640610")]
	private void LEAINMHIBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x86410E0", Offset = "0x863FCE0", VA = "0x1886410E0")]
	public PPGKLDMBDPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[UnityEngine.Scripting.Preserve]
internal sealed class JFLLJJCEKHI : LFHNHIGOGPL, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class KHMEFKACCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KHMEFKACCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8631A40", Offset = "0x8630640", VA = "0x188631A40")]
		internal object NFDCEDEADPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class FBBFKPGKGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FBBFKPGKGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8629330", Offset = "0x8627F30", VA = "0x188629330")]
		internal object PNNDNLICAOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class ICIDJKNKKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ICIDJKNKKBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class MCJCAPGDJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MCJCAPGDJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8635980", Offset = "0x8634580", VA = "0x188635980")]
		internal object NGJIMHJIFHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class FBACAOMGNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FBACAOMGNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x86292D0", Offset = "0x8627ED0", VA = "0x1886292D0")]
		internal object GHHDHKGKJEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private readonly Dictionary<Guid, MIJKFDOPOFG> GELPMKIMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly TimeSpan AKKMFEACGGM;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "9")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x862F170", Offset = "0x862DD70", VA = "0x18862F170", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x862F730", Offset = "0x862E330", VA = "0x18862F730", Slot = "4")]
	public FFAIMEPEPMK NKAMMCABBBC(Guid DIPCJMNHKDB)
	{
		return default(FFAIMEPEPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x862F520", Offset = "0x862E120", VA = "0x18862F520", Slot = "5")]
	public bool HMCNGGMNMHK(Guid DIPCJMNHKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x862F180", Offset = "0x862DD80", VA = "0x18862F180", Slot = "6")]
	public bool EGBLICDMGPO(Guid DIPCJMNHKDB, Task KPHCMIAGIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x862ED60", Offset = "0x862D960", VA = "0x18862ED60", Slot = "7")]
	public bool AIKEAHEGHAK(Guid DIPCJMNHKDB, PEJIBHJPOLO HKKCBEKOHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x862F4B0", Offset = "0x862E0B0", VA = "0x18862F4B0", Slot = "8")]
	public Task<(PEJIBHJPOLO, Task)> HFGIDCKKCEI(Guid DIPCJMNHKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x862EF40", Offset = "0x862DB40", VA = "0x18862EF40")]
	private void BJBFFFEKEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x862F950", Offset = "0x862E550", VA = "0x18862F950")]
	public JFLLJJCEKHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.NoEngine.Common.Preserve]
internal class LGOJGMLACBN : MIJCCIJBGJK, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class HNPJCJMINOC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private readonly FJAIPDANBOO JOOADJPODGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly CancellationTokenSource MIJBGGNKLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public readonly CancellationToken KCBLNLMAMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private bool NNAFLILDCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool OCBGCPNOEJE;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x862C780", Offset = "0x862B380", VA = "0x18862C780")]
		public HNPJCJMINOC(FJAIPDANBOO JOOADJPODGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x862C630", Offset = "0x862B230", VA = "0x18862C630")]
		public void LEAINMHIBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x862C600", Offset = "0x862B200", VA = "0x18862C600", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class PIIAIGANHNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public NOMHGALJMIA disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PIIAIGANHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8640070", Offset = "0x863EC70", VA = "0x188640070")]
		internal object BNKHJGLKEGC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct GKJAGANLMII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NOMHGALJMIA disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public LGOJGMLACBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x862B340", Offset = "0x8629F40", VA = "0x18862B340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x862B790", Offset = "0x862A390", VA = "0x18862B790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class EEOGCHPMBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public LGOJGMLACBN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EEOGCHPMBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x86273A0", Offset = "0x8625FA0", VA = "0x1886273A0")]
		internal object BICAHLALBFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class JJAINBHLLNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public FJAIPDANBOO newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public EEOGCHPMBEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JJAINBHLLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x862FA70", Offset = "0x862E670", VA = "0x18862FA70")]
		internal object PMCCGNENKBL((FJAIPDANBOO lastLocalPlayerRoomInstance, FJAIPDANBOO newRoomInstance, GEPMPDHAMDP fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct EGFHEILEANB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public LGOJGMLACBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private GFJANGGIPEI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8627410", Offset = "0x8626010", VA = "0x188627410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class LJBBAPJFDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public FJAIPDANBOO newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LJBBAPJFDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8633C50", Offset = "0x8632850", VA = "0x188633C50")]
		internal object HLNOOLFHFBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8633CF0", Offset = "0x86328F0", VA = "0x188633CF0")]
		internal void NNPODHMMCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8633C10", Offset = "0x8632810", VA = "0x188633C10")]
		internal object AGHGCDCJFED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8633D70", Offset = "0x8632970", VA = "0x188633D70")]
		internal object OCJEDAJADDO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct MBPPDODMMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public FJAIPDANBOO newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public LGOJGMLACBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public PKADLGDPKME customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private LJBBAPJFDNP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8634960", Offset = "0x8633560", VA = "0x188634960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8635920", Offset = "0x8634520", VA = "0x188635920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly IJBOHJFCGEE.HKLPJNHIGLF ACECCPIEFDP;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly LLFKNJNFIGE IGDBAHDJCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private AHLPANAIOHK IBLGAJFAKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private GEPMPDHAMDP MDCIJMKAOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private LMAIAAIDCCF JLMFPIBLIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private BKIPPFDHBMB PCCAPAGPBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private FJAIPDANBOO GIHGLIBOJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private HNPJCJMINOC GHEGJHIJCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private bool PBKHFKGCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private Task BELOINJNBID;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8632C90", Offset = "0x8631890", VA = "0x188632C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool MBJJONEMCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xD0ED10", Offset = "0xD0D910", VA = "0x180D0ED10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8632810", Offset = "0x8631410", VA = "0x188632810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8632CE0", Offset = "0x86318E0", VA = "0x188632CE0", Slot = "4")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8632950", Offset = "0x8631550", VA = "0x188632950", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x86335A0", Offset = "0x86321A0", VA = "0x1886335A0")]
	[AsyncStateMachine(typeof(GKJAGANLMII))]
	private Task PMCMMKIONPL(NOMHGALJMIA IOFICLPAOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8633410", Offset = "0x8632010", VA = "0x188633410")]
	private void PHBDNIBMOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8632F80", Offset = "0x8631B80", VA = "0x188632F80")]
	private void MJBAMOKMJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8633690", Offset = "0x8632290", VA = "0x188633690")]
	private void PMFFBNMAJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x86333A0", Offset = "0x8631FA0", VA = "0x1886333A0")]
	private bool NMHDEOHFCKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8632BC0", Offset = "0x86317C0", VA = "0x188632BC0")]
	[AsyncStateMachine(typeof(EGFHEILEANB))]
	private void IBLDEPHCENG(int EOHMOFMBNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8633110", Offset = "0x8631D10", VA = "0x188633110")]
	private void NEMPMBMMNBG([Out] IDisposable PIOJPJDHJEP, [Out] IDisposable FDPDMDDLJHP, [Out] IDisposable OCIEDMFNMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8632AC0", Offset = "0x86316C0", VA = "0x188632AC0")]
	private bool GFHOFEPAFDP(FJAIPDANBOO JOOADJPODGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x86327C0", Offset = "0x86313C0", VA = "0x1886327C0")]
	private void CEKHPPMBHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8632820", Offset = "0x8631420", VA = "0x188632820")]
	[AsyncStateMachine(typeof(MBPPDODMMCF))]
	private Task CGNOLKJEKFA(FJAIPDANBOO JOOADJPODGG, PKADLGDPKME BIFANKLCGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8633BA0", Offset = "0x86327A0", VA = "0x188633BA0")]
	public LGOJGMLACBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[UnityEngine.Scripting.Preserve]
internal sealed class OJKEECCFGKM : HLOHLLJOEPO, GPPJJLABMCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct FCACEBNGGPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public AsyncTaskMethodBuilder<NIDIOBFKMIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public OJKEECCFGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<NIDIOBFKMIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8629390", Offset = "0x8627F90", VA = "0x188629390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8629620", Offset = "0x8628220", VA = "0x188629620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class LBMGOHCEFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public HNLLGFNPJEI message;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LBMGOHCEFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8632700", Offset = "0x8631300", VA = "0x188632700")]
		internal object KEJGCCHJFFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class JGBOBCIOLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public HNLLGFNPJEI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JGBOBCIOLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x862FA10", Offset = "0x862E610", VA = "0x18862FA10")]
		internal object INMBKJOIGGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class NLGCGLOLBMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NLGCGLOLBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x86365C0", Offset = "0x86351C0", VA = "0x1886365C0")]
		internal object HEFHJCJIIEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MMNIJKKNPPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public OJKEECCFGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter<ANOMBEDMGAC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8635BE0", Offset = "0x86347E0", VA = "0x188635BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x86364B0", Offset = "0x86350B0", VA = "0x1886364B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class AFEKACPECJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public HNLLGFNPJEI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AFEKACPECJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x86222E0", Offset = "0x8620EE0", VA = "0x1886222E0")]
		internal object GENGAJGMHCF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct DHOHJFLPIKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public HNLLGFNPJEI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public OJKEECCFGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private OIDEJNGNBIE <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8626260", Offset = "0x8624E60", VA = "0x188626260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8626DD0", Offset = "0x86259D0", VA = "0x188626DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CCIAOJOECHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<ANOMBEDMGAC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public OJKEECCFGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private LEEJDDPHEHL.BFBAKGEEJIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private OIDEJNGNBIE <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8624EC0", Offset = "0x8623AC0", VA = "0x188624EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x86253F0", Offset = "0x8623FF0", VA = "0x1886253F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class KDCGCDJFAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public ANOMBEDMGAC operation;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KDCGCDJFAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8630BA0", Offset = "0x862F7A0", VA = "0x188630BA0")]
		internal object CKEFEEKBMPJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct OFJJOMFBIOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public ANOMBEDMGAC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public OJKEECCFGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private HMEJDNPIBLC<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x863C6C0", Offset = "0x863B2C0", VA = "0x18863C6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x863CCF0", Offset = "0x863B8F0", VA = "0x18863CCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class JLCCHGLMNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JLCCHGLMNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x862FB30", Offset = "0x862E730", VA = "0x18862FB30")]
		internal object CDBHPNMGOML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class GLCCJKMNLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GLCCJKMNLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x862B7F0", Offset = "0x862A3F0", VA = "0x18862B7F0")]
		internal object BDIOCEKANBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private PPEFCDBEFHO EHKNPCKNDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private POBPCNGMOEG BLJPIKFABGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private HPDFOIEFPLD PPIHKIJDOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private TaskCompletionSource<NIDIOBFKMIA> DNIJINKFODJ;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x863DDE0", Offset = "0x863C9E0", VA = "0x18863DDE0", Slot = "7")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x863D830", Offset = "0x863C430", VA = "0x18863D830", Slot = "6")]
	[AsyncStateMachine(typeof(FCACEBNGGPK))]
	public Task<NIDIOBFKMIA> GJBLDCJLFGK(CancellationToken IEBEAAPBOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x863D4A0", Offset = "0x863C0A0", VA = "0x18863D4A0", Slot = "4")]
	public void FNFGOFAMIAE(HNLLGFNPJEI FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x863CE50", Offset = "0x863BA50", VA = "0x18863CE50", Slot = "5")]
	public void BDOHGHFGJLI(HNLLGFNPJEI MDMKDEGJDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x863DCD0", Offset = "0x863C8D0", VA = "0x18863DCD0")]
	[AsyncStateMachine(typeof(MMNIJKKNPPH))]
	private Task JFNLOHLNLOC(HNLLGFNPJEI BJAGJMJPKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x863D240", Offset = "0x863BE40", VA = "0x18863D240")]
	[AsyncStateMachine(typeof(DHOHJFLPIKE))]
	private Task CEHLENICOGL(HNLLGFNPJEI MOPMFEFCLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x863D350", Offset = "0x863BF50", VA = "0x18863D350")]
	[AsyncStateMachine(typeof(CCIAOJOECHB))]
	private Task<ANOMBEDMGAC> DJJIMGFIOAI(HNLLGFNPJEI BJAGJMJPKHA, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x863D1B0", Offset = "0x863BDB0", VA = "0x18863D1B0")]
	private OIDEJNGNBIE CBIAAAJAEGK(HNLLGFNPJEI HJHLPCOBPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x863E0E0", Offset = "0x863CCE0", VA = "0x18863E0E0")]
	[AsyncStateMachine(typeof(OFJJOMFBIOA))]
	private Task POGKMAFHOIH(ANOMBEDMGAC JLJMNCGIOCA, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x863DED0", Offset = "0x863CAD0", VA = "0x18863DED0")]
	private ANOMBEDMGAC MMMLGIFONAC(HNLLGFNPJEI BJAGJMJPKHA, OIDEJNGNBIE OEGPEIDJGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3C75400", Offset = "0x3C74000", VA = "0x183C75400")]
	private T EMOMAHBHNPL<T>(T OOHGFGHCOAJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x863D940", Offset = "0x863C540", VA = "0x18863D940")]
	private ANOMBEDMGAC HKPFMODOCFM(HNLLGFNPJEI BJAGJMJPKHA, OIDEJNGNBIE OEGPEIDJGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public OJKEECCFGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class PBFLGPJKGHK : POBPCNGMOEG, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MOPMMMHJMNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MOPMMMHJMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8636510", Offset = "0x8635110", VA = "0x188636510")]
		internal object GGDCIAFNFBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class GDHINBKACID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GDHINBKACID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x862B2D0", Offset = "0x8629ED0", VA = "0x18862B2D0")]
		internal object CCBODNMLPCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private KDNCNHCJKIB EBFMLCCKEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private HLOHLLJOEPO IDAEIBJLKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private LFHNHIGOGPL GELPMKIMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private NJKMHJOEPLN LFKMJBMHBCD;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x863FA00", Offset = "0x863E600", VA = "0x18863FA00", Slot = "6")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x863ED40", Offset = "0x863D940", VA = "0x18863ED40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x863E680", Offset = "0x863D280", VA = "0x18863E680", Slot = "4")]
	public FFAIMEPEPMK COEDBMEMKBP(HNLLGFNPJEI MAEGJAMICNB)
	{
		return default(FFAIMEPEPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x863E470", Offset = "0x863D070", VA = "0x18863E470", Slot = "5")]
	public void BHCGMOGDPHP(Guid DIPCJMNHKDB, Task KPHCMIAGIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x863FD80", Offset = "0x863E980", VA = "0x18863FD80")]
	private void OLCJFHHOPPA(DCFDGGPHAAA KHKBFEMNDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x863F480", Offset = "0x863E080", VA = "0x18863F480")]
	private void LBHKAAAIOKN(HKLMCEEIEGL AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x863E200", Offset = "0x863CE00", VA = "0x18863E200")]
	private void ALNOPPFHLJO(HKLMCEEIEGL AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x863EFF0", Offset = "0x863DBF0", VA = "0x18863EFF0")]
	private void HMDHNPBCBCH(HKLMCEEIEGL AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x863EAA0", Offset = "0x863D6A0", VA = "0x18863EAA0")]
	private PEJIBHJPOLO DKBFHPNLIBE(HNLLGFNPJEI HJHLPCOBPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x863EDF0", Offset = "0x863D9F0", VA = "0x18863EDF0")]
	private void EDAAEKEPLHC(HNLLGFNPJEI MOPMFEFCLGN, PEJIBHJPOLO HKKCBEKOHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x863FE90", Offset = "0x863EA90", VA = "0x18863FE90")]
	private bool PJHFBCKDHLL(HNLLGFNPJEI MOPMFEFCLGN, PEJIBHJPOLO HKKCBEKOHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x863FB70", Offset = "0x863E770", VA = "0x18863FB70")]
	private bool LGOJEPPPCNO(HNLLGFNPJEI BHDJLMFMDEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x863F230", Offset = "0x863DE30", VA = "0x18863F230")]
	private bool INDPOOCELGF(byte FGKFOOAONAO, ExitGames.Client.Photon.Hashtable AGFKEDPOHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PBFLGPJKGHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class DJMEEJADOIB : AGHCGHMFDBD, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class MFHFOCCCPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public NIDIOBFKMIA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public DJMEEJADOIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public HNLLGFNPJEI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MFHFOCCCPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x86359E0", Offset = "0x86345E0", VA = "0x1886359E0")]
		internal object KBCDDNELDGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8635A50", Offset = "0x8634650", VA = "0x188635A50")]
		internal object PPMHNJGDBLF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HEKAKJGODJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public DJMEEJADOIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public HNLLGFNPJEI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter<PEJIBHJPOLO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x862BEF0", Offset = "0x862AAF0", VA = "0x18862BEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x862C590", Offset = "0x862B190", VA = "0x18862C590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class ECGOOMPPKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public NIDIOBFKMIA operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ECGOOMPPKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8627330", Offset = "0x8625F30", VA = "0x188627330")]
		internal object JJIEBBMDPKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class CAIKIGDNPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CAIKIGDNPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x86244A0", Offset = "0x86230A0", VA = "0x1886244A0")]
		internal object OLKGKHBKEOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8624430", Offset = "0x8623030", VA = "0x188624430")]
		internal object AAKFCFFHKJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8624510", Offset = "0x8623110", VA = "0x188624510")]
		internal object PFHFAKLOIPM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CBPNDFKBGFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public DJMEEJADOIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private CAIKIGDNPLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private FFAIMEPEPMK <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private PEJIBHJPOLO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<(PEJIBHJPOLO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8624580", Offset = "0x8623180", VA = "0x188624580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8624E50", Offset = "0x8623A50", VA = "0x188624E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private KDNCNHCJKIB EBFMLCCKEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private POBPCNGMOEG BLJPIKFABGA;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x8627160", Offset = "0x8625D60", VA = "0x188627160", Slot = "5")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8627210", Offset = "0x8625E10", VA = "0x188627210", Slot = "4")]
	[AsyncStateMachine(typeof(HEKAKJGODJL))]
	private Task<PEJIBHJPOLO> NCDNAOPIBFI(HNLLGFNPJEI HJHLPCOBPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x8626E30", Offset = "0x8625A30", VA = "0x188626E30")]
	private bool AINAKHKHDEL(NIDIOBFKMIA MKMDKJJLADP, [Out] PEJIBHJPOLO DBJBIPJCIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8627020", Offset = "0x8625C20", VA = "0x188627020")]
	[AsyncStateMachine(typeof(CBPNDFKBGFK))]
	private Task<PEJIBHJPOLO> CIBLMLFBJBK(HNLLGFNPJEI BJAGJMJPKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DJMEEJADOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class FGPIAOGGIGD : IHDJLNKPAOG, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct BBIDIONCJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public IDLFIGEMLKL KLEACIDHGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public long MJCPBDFGJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public Guid? FHNPHOOJOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public bool MLMGGNCPLMH;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct KEKJJPEJGOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public AsyncTaskMethodBuilder<FCFEBPBOLMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FGPIAOGGIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private TaskAwaiter<KINJLHLHADG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<FCFEBPBOLMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x8631380", Offset = "0x862FF80", VA = "0x188631380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8631950", Offset = "0x8630550", VA = "0x188631950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class NPCBDMPBLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NPCBDMPBLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x863BCF0", Offset = "0x863A8F0", VA = "0x18863BCF0")]
		internal object CEBNGBCNHDM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct KDHPENAMDNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AsyncTaskMethodBuilder<KINJLHLHADG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public FGPIAOGGIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private NPCBDMPBLGP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter<KINJLHLHADG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8630C20", Offset = "0x862F820", VA = "0x188630C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8631210", Offset = "0x862FE10", VA = "0x188631210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct LLEMEPPHMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<FCFEBPBOLMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public FGPIAOGGIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public KINJLHLHADG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<BBIDIONCJEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8633DB0", Offset = "0x86329B0", VA = "0x188633DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8634320", Offset = "0x8632F20", VA = "0x188634320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class OELGKGNKFMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public KINJLHLHADG roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OELGKGNKFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xF0C150", Offset = "0xF0AD50", VA = "0x180F0C150")]
		internal bool IDIGAOFNCNJ(CGPLGKCGOLD sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x863C4E0", Offset = "0x863B0E0", VA = "0x18863C4E0")]
		internal object LPPNJPDAAHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x863C5A0", Offset = "0x863B1A0", VA = "0x18863C5A0")]
		internal object MHJLJKNPFNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x863C630", Offset = "0x863B230", VA = "0x18863C630")]
		internal object NOJDHAPIEHH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class KDLDDEPDAAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public OELGKGNKFMM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KDLDDEPDAAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8631280", Offset = "0x862FE80", VA = "0x188631280")]
		internal object BKDLBJJJCNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct KBIDPFEGAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<BBIDIONCJEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public KINJLHLHADG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public FGPIAOGGIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public FJAIPDANBOO targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private KDLDDEPDAAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private TaskAwaiter<BBIDIONCJEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<JJNCBFJEABI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x862FB90", Offset = "0x862E790", VA = "0x18862FB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8630B30", Offset = "0x862F730", VA = "0x188630B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class FNNOLIDJFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FNNOLIDJFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x862AD40", Offset = "0x8629940", VA = "0x18862AD40")]
		internal object FNFGONKFDKI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct OEDIDBGBFFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public AsyncTaskMethodBuilder<BBIDIONCJEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public CGPLGKCGOLD subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public FGPIAOGGIGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public FJAIPDANBOO dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private FNNOLIDJFNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter<MBONFMDKIOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x863BDA0", Offset = "0x863A9A0", VA = "0x18863BDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x863C470", Offset = "0x863B070", VA = "0x18863C470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private LMAIAAIDCCF JLMFPIBLIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private FEKLGINOHBI DNPJFCGIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private GNILIMCHNDI OBGEAICFOKE;

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x862A400", Offset = "0x8629000", VA = "0x18862A400", Slot = "5")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x862A2A0", Offset = "0x8628EA0", VA = "0x18862A2A0", Slot = "4")]
	[AsyncStateMachine(typeof(KEKJJPEJGOA))]
	public Task<FCFEBPBOLMP> JNBHILALGIM(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, FJAIPDANBOO EBAJJCNAANO, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8629FD0", Offset = "0x8628BD0", VA = "0x188629FD0")]
	[AsyncStateMachine(typeof(KDHPENAMDNC))]
	private Task<KINJLHLHADG> GGDBEEHJDGG(FJAIPDANBOO EBAJJCNAANO, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8629E60", Offset = "0x8628A60", VA = "0x188629E60")]
	[AsyncStateMachine(typeof(LLEMEPPHMPA))]
	private Task<FCFEBPBOLMP> EDDLDHANMOD(FJAIPDANBOO EBAJJCNAANO, KINJLHLHADG BAAHMPCCABG, long KBGIBOKAOOO, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x862A130", Offset = "0x8628D30", VA = "0x18862A130")]
	[AsyncStateMachine(typeof(KBIDPFEGAOO))]
	private Task<BBIDIONCJEF> HECKLOJHHIJ(FJAIPDANBOO EBAJJCNAANO, KINJLHLHADG BAAHMPCCABG, long KBGIBOKAOOO, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8629CF0", Offset = "0x86288F0", VA = "0x188629CF0")]
	[AsyncStateMachine(typeof(OEDIDBGBFFI))]
	private Task<BBIDIONCJEF> DGMLLJBMCEO(FJAIPDANBOO IFFIHIEMFAJ, CGPLGKCGOLD CKIBAMLGHAI, long KBGIBOKAOOO, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public FGPIAOGGIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class BGCOKOMJKIG : HPDFOIEFPLD, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class LCLHHAILMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LCLHHAILMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8632760", Offset = "0x8631360", VA = "0x188632760")]
		internal object CBPPLIHGCKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct BHIJBPNINJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public BGCOKOMJKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public OIDEJNGNBIE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8623DB0", Offset = "0x86229B0", VA = "0x188623DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x86243C0", Offset = "0x8622FC0", VA = "0x1886243C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct FGENGFLAJDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public BGCOKOMJKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public OIDEJNGNBIE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private TaskAwaiter<LEEKOLPPALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8629690", Offset = "0x8628290", VA = "0x188629690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8629C80", Offset = "0x8628880", VA = "0x188629C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class MHFLLDGHKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MHFLLDGHKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8635B80", Offset = "0x8634780", VA = "0x188635B80")]
		internal object DMMEOAGLEKO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct LBDMFLFCIKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public HNLLGFNPJEI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public BGCOKOMJKIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public OIDEJNGNBIE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private HLMMMBHGAHE <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private PDNAMGADKBD <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private TaskAwaiter<LEEKOLPPALB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8631AA0", Offset = "0x86306A0", VA = "0x188631AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8632690", Offset = "0x8631290", VA = "0x188632690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private CCCCPGHELOP BCFEBOMHFHD;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private ADJJNPCIJEO JMGGCOKAODP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8623670", Offset = "0x8622270", VA = "0x188623670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x8623BD0", Offset = "0x86227D0", VA = "0x188623BD0", Slot = "8")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x8623A70", Offset = "0x8622670", VA = "0x188623A70", Slot = "4")]
	[AsyncStateMachine(typeof(BHIJBPNINJI))]
	public Task<HNLLGFNPJEI> KCPCJOJABCH(HNLLGFNPJEI BJAGJMJPKHA, OIDEJNGNBIE OEGPEIDJGMD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8623C60", Offset = "0x8622860", VA = "0x188623C60", Slot = "5")]
	[AsyncStateMachine(typeof(FGENGFLAJDL))]
	public Task<HNLLGFNPJEI> PCMEKKJAOEK(CancellationToken DKKNFNCKCEB, OIDEJNGNBIE OEGPEIDJGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x86239C0", Offset = "0x86225C0", VA = "0x1886239C0", Slot = "6")]
	public BLJFMNNIGKD JIPABBADMMJ(ANOMBEDMGAC HBIKMFDJEPN, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8623890", Offset = "0x8622490", VA = "0x188623890", Slot = "7")]
	public BLJFMNNIGKD JEFPOFIMPMH(ANOMBEDMGAC HBIKMFDJEPN, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8623730", Offset = "0x8622330", VA = "0x188623730")]
	[AsyncStateMachine(typeof(LBDMFLFCIKC))]
	private Task<HNLLGFNPJEI> APGHLPGEOKG(HNLLGFNPJEI BJAGJMJPKHA, OIDEJNGNBIE OEGPEIDJGMD, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3838600", Offset = "0x3837200", VA = "0x183838600")]
	private static byte[] GCEFKLPAIEJ(HNLLGFNPJEI FNFIPKNHEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BGCOKOMJKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[UnityEngine.Scripting.Preserve]
internal sealed class LMBKHMOOLHN : KDNCNHCJKIB, GPPJJLABMCM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private JONKNFJJKMH GDNMDPADKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private PPEFCDBEFHO EHKNPCKNDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private HIDHECKNOGP CIPHKPCJMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private BKIPPFDHBMB PCCAPAGPBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private FNKMNCGLMJF MKCPAFAGADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private LMAIAAIDCCF JLMFPIBLIFF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x86343A0", Offset = "0x8632FA0", VA = "0x1886343A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static PEJIBHJPOLO BGFIBGHCIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8634950", Offset = "0x8633550", VA = "0x188634950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x86343F0", Offset = "0x8632FF0", VA = "0x1886343F0", Slot = "6")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x86347E0", Offset = "0x86333E0", VA = "0x1886347E0", Slot = "4")]
	public PEJIBHJPOLO ONKEHDJJFDH(BJCCECIKIFB DKOJOOELKHC, NIDIOBFKMIA HMBJHAPMDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8634560", Offset = "0x8633160", VA = "0x188634560", Slot = "5")]
	public PEJIBHJPOLO LONIKPGJJBJ(BJCCECIKIFB JEHLDBHABMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8634390", Offset = "0x8632F90", VA = "0x188634390")]
	private static PEJIBHJPOLO KOINMMPDIGF(LEBMHJAHDBC HGJBCNEJGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LMBKHMOOLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class NAOOCBFMCFM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8636580", Offset = "0x8635180", VA = "0x188636580")]
	public NAOOCBFMCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x77B0790", Offset = "0x77AF390", VA = "0x1877B0790")]
	public NAOOCBFMCFM(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[UnityEngine.Scripting.Preserve]
internal sealed class LFCFAPNBGLJ : JOLGBJADICK, GPPJJLABMCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct ADHOFIMDMBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public KJNCMPAKDDO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private HMEJDNPIBLC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private DKIFMMKPOAA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private TaskAwaiter<PEJIBHJPOLO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x86419D0", Offset = "0x86405D0", VA = "0x1886419D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x86423A0", Offset = "0x8640FA0", VA = "0x1886423A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct BBGFBHJNKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x8643580", Offset = "0x8642180", VA = "0x188643580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8643CC0", Offset = "0x86428C0", VA = "0x188643CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct MOBFIDAKDAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8658DD0", Offset = "0x86579D0", VA = "0x188658DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x86592E0", Offset = "0x8657EE0", VA = "0x1886592E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct CHMILOCEMJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8646030", Offset = "0x8644C30", VA = "0x188646030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x86467E0", Offset = "0x86453E0", VA = "0x1886467E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct AEDILOABBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8642410", Offset = "0x8641010", VA = "0x188642410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x86425B0", Offset = "0x86411B0", VA = "0x1886425B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct IMLDHAKNHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8651C80", Offset = "0x8650880", VA = "0x188651C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8652390", Offset = "0x8650F90", VA = "0x188652390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct PONIOAEOEDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x865DAF0", Offset = "0x865C6F0", VA = "0x18865DAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x865DF60", Offset = "0x865CB60", VA = "0x18865DF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct BNOLOALJOLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public LFCFAPNBGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IGBBMPDAJMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private HMEJDNPIBLC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8645420", Offset = "0x8644020", VA = "0x188645420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x86459C0", Offset = "0x86445C0", VA = "0x1886459C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private HPDFOIEFPLD PPIHKIJDOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private PPEFCDBEFHO EHKNPCKNDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private FNKMNCGLMJF MKCPAFAGADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private CancellationTokenSource JAJACAAMNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private Task BAAPADGODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private TaskCompletionSource<int> AJFGMFKNAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private int CJOHIDPJPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int MDBBEPKKKJB;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x8656890", Offset = "0x8655490", VA = "0x188656890", Slot = "6")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x141ED60", Offset = "0x141D960", VA = "0x18141ED60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x8656340", Offset = "0x8654F40", VA = "0x188656340")]
	private void IDDHFFLGBOP(float BDBDHAKHEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8655EA0", Offset = "0x8654AA0", VA = "0x188655EA0", Slot = "4")]
	[AsyncStateMachine(typeof(ADHOFIMDMBH))]
	public Task<PEJIBHJPOLO> BNPLNMBHPBE(KJNCMPAKDDO NCDCKNMIKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8655FD0", Offset = "0x8654BD0", VA = "0x188655FD0", Slot = "5")]
	[AsyncStateMachine(typeof(BBGFBHJNKPI))]
	public Task BPBKPMBKAGO([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x141ED60", Offset = "0x141D960", VA = "0x18141ED60")]
	public void GBJIGNICEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x8656B30", Offset = "0x8655730", VA = "0x188656B30")]
	private DKIFMMKPOAA MGEKJJJFDGH(KJNCMPAKDDO NCDCKNMIKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x86560C0", Offset = "0x8654CC0", VA = "0x1886560C0")]
	[AsyncStateMachine(typeof(MOBFIDAKDAB))]
	private Task HJAMGKHIOLJ(CancellationToken DCACDPOIBLL, int LDOCMOAMKBN, KPJEMKAIFIO FJNMGMFLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8656D60", Offset = "0x8655960", VA = "0x188656D60")]
	[AsyncStateMachine(typeof(CHMILOCEMJJ))]
	private Task OFFHPNPAKFB(CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x86567A0", Offset = "0x86553A0", VA = "0x1886567A0")]
	[AsyncStateMachine(typeof(AEDILOABBLB))]
	private Task LCCIIOHFABC([Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8656A40", Offset = "0x8655640", VA = "0x188656A40")]
	[AsyncStateMachine(typeof(IMLDHAKNHPK))]
	private Task LFAKICAPPOP(CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8656420", Offset = "0x8655020", VA = "0x188656420")]
	[AsyncStateMachine(typeof(PONIOAEOEDA))]
	private Task JBJGAPDIKDE(CancellationToken FEMDBMIMAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x86561B0", Offset = "0x8654DB0", VA = "0x1886561B0")]
	private Task HMJMOGNKKIL(IGBBMPDAJMA PCAOHCHCKBL, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8655D90", Offset = "0x8654990", VA = "0x188655D90")]
	[AsyncStateMachine(typeof(BNOLOALJOLK))]
	private Task AHCMPGCIJIC(IGBBMPDAJMA PCAOHCHCKBL, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8656520", Offset = "0x8655120", VA = "0x188656520")]
	private bool KIBICPNGCDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LFCFAPNBGLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[UnityEngine.Scripting.Preserve]
internal class OJLLGFJLIDJ : HIDHECKNOGP, GPPJJLABMCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct CGIIGENGJDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public OJLLGFJLIDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private HMEJDNPIBLC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x8645A20", Offset = "0x8644620", VA = "0x188645A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8645FD0", Offset = "0x8644BD0", VA = "0x188645FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038F")]
	private LJNGIEKFBAB GCILBAMPJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private KDNCNHCJKIB EBFMLCCKEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private HPDFOIEFPLD PPIHKIJDOOJ;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x865C150", Offset = "0x865AD50", VA = "0x18865C150", Slot = "6")]
	public void LEIJOMGLGOC(KMLAPHJELJN KFBBLAFGOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x865BF60", Offset = "0x865AB60", VA = "0x18865BF60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x865C430", Offset = "0x865B030", VA = "0x18865C430", Slot = "5")]
	[AsyncStateMachine(typeof(CGIIGENGJDA))]
	public Task MBBMDEMOELJ(string MCLDNGJMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x865C0F0", Offset = "0x865ACF0", VA = "0x18865C0F0", Slot = "4")]
	public PEJIBHJPOLO KIBICPNGCDH(BJCCECIKIFB DKOJOOELKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x865BFB0", Offset = "0x865ABB0", VA = "0x18865BFB0")]
	private OLNKCPKONDA GGMFNBEPPGL(string MCLDNGJMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public OJLLGFJLIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class JGODIDMFMLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8652F10", Offset = "0x8651B10", VA = "0x188652F10")]
	public static void ENPJKLFNFFH(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8653150", Offset = "0x8651D50", VA = "0x188653150")]
	internal static void FIAFEJKFPPP(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x86532B0", Offset = "0x8651EB0", VA = "0x1886532B0")]
	internal static void OPFFMOGHANI(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8652AE0", Offset = "0x86516E0", VA = "0x188652AE0")]
	internal static void DLJKOHDNPFJ(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3B237D0", Offset = "0x3B223D0", VA = "0x183B237D0")]
	private static void KCBAJACOICF<Interface, Impl, Interface>(PFGPAPHADOM MHCMGFKMEEN) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class PMMHOANJMFM : ABKFPDODFHM<HNLLGFNPJEI>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class NKFDPCKENNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public HNLLGFNPJEI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NKFDPCKENNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x865B660", Offset = "0x865A260", VA = "0x18865B660")]
		internal object LCNJCKAGNGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly PMMHOANJMFM LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x865CEC0", Offset = "0x865BAC0", VA = "0x18865CEC0")]
	public ExitGames.Client.Photon.Hashtable BLPDEIDOFHH(HNLLGFNPJEI FNFIPKNHEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x865CF50", Offset = "0x865BB50", VA = "0x18865CF50", Slot = "5")]
	protected override void DOHLCGHLOHF(HNLLGFNPJEI FNFIPKNHEOF, IDictionary<object, object> PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x865D080", Offset = "0x865BC80", VA = "0x18865D080", Slot = "6")]
	public override HNLLGFNPJEI EBAGJKMAFHO(IDictionary<object, object> PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x865D2B0", Offset = "0x865BEB0", VA = "0x18865D2B0")]
	private static void HOEGMFFOKBK(string ILKCEJAIIBJ, HNLLGFNPJEI FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x865D6F0", Offset = "0x865C2F0", VA = "0x18865D6F0")]
	public PMMHOANJMFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x865D3C0", Offset = "0x865BFC0", VA = "0x18865D3C0")]
	[CompilerGenerated]
	internal static string OPODIHDLNIP(FCFEBPBOLMP ADKJHPADFOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class PGPPMIJLMJL
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static PEJIBHJPOLO BGFIBGHCIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x865CE60", Offset = "0x865BA60", VA = "0x18865CE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x865CBF0", Offset = "0x865B7F0", VA = "0x18865CBF0")]
	public static bool KNKHBMJDLGA(this PEJIBHJPOLO HKKCBEKOHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x865CC10", Offset = "0x865B810", VA = "0x18865CC10")]
	public static PEJIBHJPOLO KOINMMPDIGF(LEBMHJAHDBC PCNCNFFOFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x865CC70", Offset = "0x865B870", VA = "0x18865CC70")]
	public static PEJIBHJPOLO OFNFKNPCOHK(IEnumerable<PEJIBHJPOLO> DBBAFCLLGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x865C9A0", Offset = "0x865B5A0", VA = "0x18865C9A0")]
	public static string IKPPMEIDOCD(this PEJIBHJPOLO DBJBIPJCIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class IPJAEOCKBMK : PNPCNFBPDFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public delegate PEJIBHJPOLO AODMNBNDNJH([NotNull] BJCCECIKIFB OLKBPIKJLJF);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class EOJKENFLFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public BJCCECIKIFB photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EOJKENFLFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x16C2520", Offset = "0x16C1120", VA = "0x1816C2520")]
		internal PEJIBHJPOLO OBGHPMPCOCF(AODMNBNDNJH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	protected readonly HashSet<AODMNBNDNJH> NKJBEBIONNI;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x86523F0", Offset = "0x8650FF0", VA = "0x1886523F0", Slot = "4")]
	public void AENINNBLPAN(AODMNBNDNJH GCFKIDAKHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x86524A0", Offset = "0x86510A0", VA = "0x1886524A0", Slot = "5")]
	public void GFMKHCJBMBK(AODMNBNDNJH GCFKIDAKHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x8652450", Offset = "0x8651050", VA = "0x188652450", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8652500", Offset = "0x8651100", VA = "0x188652500")]
	protected PEJIBHJPOLO LMINAFIOGDL(BJCCECIKIFB JEHLDBHABMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8652790", Offset = "0x8651390", VA = "0x188652790")]
	protected IPJAEOCKBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class HGINMFBCBPF : IPJAEOCKBMK, JONKNFJJKMH, PNPCNFBPDFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class EHEMJENEJKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public PEJIBHJPOLO result;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EHEMJENEJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x864AD70", Offset = "0x8649970", VA = "0x18864AD70")]
		internal object PONJBEOABPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x86509E0", Offset = "0x864F5E0", VA = "0x1886509E0")]
	[UnityEngine.Scripting.Preserve]
	public HGINMFBCBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8650B30", Offset = "0x864F730", VA = "0x188650B30", Slot = "8")]
	public PEJIBHJPOLO KGDHMHLPLOK(BJCCECIKIFB JEHLDBHABMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class GFDMPCOAFFC : IPJAEOCKBMK, LJNGIEKFBAB, PNPCNFBPDFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class JEBFKMAAFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public PEJIBHJPOLO result;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JEBFKMAAFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8652A80", Offset = "0x8651680", VA = "0x188652A80")]
		internal object EOFILOHPPBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x86509E0", Offset = "0x864F5E0", VA = "0x1886509E0")]
	[UnityEngine.Scripting.Preserve]
	public GFDMPCOAFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x86508D0", Offset = "0x864F4D0", VA = "0x1886508D0", Slot = "8")]
	public PEJIBHJPOLO KIBICPNGCDH(BJCCECIKIFB DMMFONEMJLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal static class KPIFHKJDPPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class JMOLPGJBJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public HMEJDNPIBLC<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JMOLPGJBJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8653E10", Offset = "0x8652A10", VA = "0x188653E10")]
		internal object EOHKCBOBMOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x8654930", Offset = "0x8653530", VA = "0x188654930")]
	public static HMEJDNPIBLC<string> BGMJPANKGFK(JPIBGNDAFKP FAOMHPPHFKM, [Optional] string ELPMNMBFFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8654AD0", Offset = "0x86536D0", VA = "0x188654AD0")]
	public static void NDIBFOJMIOF(HMEJDNPIBLC<string> KDCDPEHJICI, JPIBGNDAFKP FAOMHPPHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8654A10", Offset = "0x8653610", VA = "0x188654A10")]
	public static string EFNBHLHJGDA(HNLLGFNPJEI HJHLPCOBPOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class ILGODFLNDFN
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8651860", Offset = "0x8650460", VA = "0x188651860")]
	public static void PEOCNKCLDEN(this BHCJDNPMBCM DKIFPHGKANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8651730", Offset = "0x8650330", VA = "0x188651730")]
	public static void DEPICAODIAB(this BHCJDNPMBCM DKIFPHGKANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8651740", Offset = "0x8650340", VA = "0x188651740")]
	private static void ICCMKONJLBH(this BHCJDNPMBCM DKIFPHGKANK, bool NJBHJIHGPHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class ECKMLMDIOMO : MEOLDPFJGAJ, MMJMPEPLHIF, COAOCGMDAKP, JNHKOMJBMDI
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[DefaultMember("Item")]
	private class MIGEEHJAOJI : DCFDGGPHAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly byte MOGEIKLHIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly int MONEFJFBDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly object MJAOKBIBBDM;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte LDNDHBHILNN
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8AD0", Offset = "0xAA76D0", VA = "0x180AA8AD0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int JNDMEOBIFAA
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B430", Offset = "0xA6A030", VA = "0x180A6B430", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object CNBIMLOMBKB
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object HHFPMPGGMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x8658B30", Offset = "0x8657730", VA = "0x188658B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x77B7D90", Offset = "0x77B6990", VA = "0x1877B7D90")]
		public MIGEEHJAOJI(byte MOGEIKLHIFI, int MONEFJFBDPB, object MJAOKBIBBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x8658AE0", Offset = "0x86576E0", VA = "0x188658AE0", Slot = "8")]
		public bool GFPOIIGIKGC(byte MEPFFFGIFGB, [Out] object OOHGFGHCOAJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly MMJMPEPLHIF LCGDGAJNEJM;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public BJCCECIKIFB PPMLHENPPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x8649BD0", Offset = "0x86487D0", VA = "0x188649BD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int JNPEKFAAFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x864A500", Offset = "0x8649100", VA = "0x18864A500", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int BFBNKACCLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x864A0F0", Offset = "0x8648CF0", VA = "0x18864A0F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public BJCCECIKIFB JHOOIOBJNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8649E60", Offset = "0x8648A60", VA = "0x188649E60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int NJEGMIIDGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA7BBF0", Offset = "0xA7A7F0", VA = "0x180A7BBF0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string KHDGCLNKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8649DC0", Offset = "0x86489C0", VA = "0x188649DC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> BBNCPOELPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x864A550", Offset = "0x8649150", VA = "0x18864A550", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> LAFAOGMHIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<DCFDGGPHAAA> LGNANEHIMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x864A2C0", Offset = "0x8648EC0", VA = "0x18864A2C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x864A450", Offset = "0x8649050", VA = "0x18864A450", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> JFALBDHIDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BJCCECIKIFB> DLMJAAPMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action JBBHJEMNMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8649D20", Offset = "0x8648920", VA = "0x188649D20", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x864A220", Offset = "0x8648E20", VA = "0x18864A220", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x8649C20", Offset = "0x8648820", VA = "0x188649C20", Slot = "19")]
	public void APLBFOEGGCP(string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xDC5360", Offset = "0xDC3F60", VA = "0x180DC5360")]
	public ECKMLMDIOMO(MMJMPEPLHIF LCGDGAJNEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x8649FE0", Offset = "0x8648BE0", VA = "0x188649FE0", Slot = "8")]
	public bool GAMDCBCCGCB(byte FGKFOOAONAO, object IEFMHKKNIHP, MNMNIMLOHNO IAGGCEAMHCI, GOEJMBMADBN KECDBOMAAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x8649C80", Offset = "0x8648880", VA = "0x188649C80", Slot = "20")]
	public BJCCECIKIFB BAFGJJGGING(int GCGNJIOIEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x864A140", Offset = "0x8648D40", VA = "0x18864A140", Slot = "21")]
	public BJCCECIKIFB KGBJHJPDDKE(int LOOPKKAOJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x864A370", Offset = "0x8648F70", VA = "0x18864A370", Slot = "22")]
	public BJCCECIKIFB NOHEJPHHIIO(int GCGNJIOIEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8649EB0", Offset = "0x8648AB0", VA = "0x188649EB0", Slot = "23")]
	public IReadOnlyList<BJCCECIKIFB> FBJLIKODBOB(bool BANPCDJBOGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8649E20", Offset = "0x8648A20", VA = "0x188649E20", Slot = "24")]
	public IReadOnlyList<BJCCECIKIFB> EHOLAFKJHCA(bool BANPCDJBOGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "25")]
	public bool OFAICIAMOKM(BJCCECIKIFB FEPPJPJPKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "28")]
	public void NNJDBMDLECF(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "29")]
	public void CMCLMLEJGPF(object HEDGIMBCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "30")]
	public void AFOGNCKEMGO(object HEDGIMBCGHA, bool KFEPOMDHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x8649F90", Offset = "0x8648B90", VA = "0x188649F90", Slot = "31")]
	public IDisposable FNBNJBJAPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "32")]
	private bool CGOIMOAFIAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "33")]
	public void ALOAPFEBKME(StringBuilder BOGADKBFPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xFEAB90", Offset = "0xFE9790", VA = "0x180FEAB90", Slot = "34")]
	public bool HBDHJNALECP(bool BILGGPMMLFN, [Out] string AJLIMPCCGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xF79990", Offset = "0xF78590", VA = "0x180F79990", Slot = "37")]
	public void MGMMIBIIIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct HKLMCEEIEGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly IDictionary<object, object> AGFKEDPOHKE;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	public HKLMCEEIEGL(IDictionary<object, object> AGFKEDPOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x86513B0", Offset = "0x864FFB0", VA = "0x1886513B0")]
	public bool KMMGFHBJHAO([Out] HNLLGFNPJEI FNFIPKNHEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x86510E0", Offset = "0x864FCE0", VA = "0x1886510E0")]
	public Guid ACOCKLAOALF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8651190", Offset = "0x864FD90", VA = "0x188651190")]
	public PEJIBHJPOLO AMLBEDOEGCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x86512C0", Offset = "0x864FEC0", VA = "0x1886512C0")]
	public static ExitGames.Client.Photon.Hashtable GLOMJONEBBE(HNLLGFNPJEI FNFIPKNHEOF, PEJIBHJPOLO HKKCBEKOHIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal static class AKGLOBMLBEC
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8642610", Offset = "0x8641210", VA = "0x188642610")]
	public static bool FEMKPIEFBKP(this FJAIPDANBOO APNOPAAOBED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct LNILGEDDNDG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct LJCNCFGNIKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public LNILGEDDNDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x86585E0", Offset = "0x86571E0", VA = "0x1886585E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x86587C0", Offset = "0x86573C0", VA = "0x1886587C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly CancellationTokenSource MIJBGGNKLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private Task NKDMFOKACBI;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool JICHDGIBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8658980", Offset = "0x8657580", VA = "0x188658980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x86589B0", Offset = "0x86575B0", VA = "0x1886589B0")]
	public LNILGEDDNDG(CancellationToken DKKNFNCKCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8658820", Offset = "0x8657420", VA = "0x188658820")]
	[AsyncStateMachine(typeof(LJCNCFGNIKI))]
	public Task ACNHEKNGKHF(Func<CancellationToken, List<Task>> PLKDKAIGLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8658930", Offset = "0x8657530", VA = "0x188658930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public readonly struct PHNAFJFCOGJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct EEJLOMPDEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<KJANINJOKPF<TData>, OGEAAGEPEFJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public PHNAFJFCOGJ<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter<MDDPJNIIBBI<KJANINJOKPF<TData>, OGEAAGEPEFJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x471D1F0", Offset = "0x471BDF0", VA = "0x18471D1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x471DDA0", Offset = "0x471C9A0", VA = "0x18471DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private readonly MOENBGNBLCM<TGetDataArg, TData> MPDEJFBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	internal PHNAFJFCOGJ(MOENBGNBLCM<TGetDataArg, TData> FCHJEFGMLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x57D2530", Offset = "0x57D1130", VA = "0x1857D2530")]
	[AsyncStateMachine(typeof(PHNAFJFCOGJ<, >.EEJLOMPDEPC))]
	public Task<MDDPJNIIBBI<KJANINJOKPF<TData>, OGEAAGEPEFJ>> PJBGINOKBFN(TGetDataArg NOONBIFJDPN, string LCNLPCFJJPE, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class PDDAGCOOOGB
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E350", Offset = "0x3A5CF50", VA = "0x183A5E350")]
	public static PHNAFJFCOGJ<TGetDataArg, TData> JHMOIFLKJAD<TGetDataArg, TData>(MOENBGNBLCM<TGetDataArg, TData> FCHJEFGMLNE)
	{
		return default(PHNAFJFCOGJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct LDEHOCDMOMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public readonly int LDNDHBHILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int? EBJKLFMKMKO;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5274200", Offset = "0x5272E00", VA = "0x185274200")]
	public LDEHOCDMOMK(int MOGEIKLHIFI, [Optional] int? HJHDFGAPHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x8655CB0", Offset = "0x86548B0", VA = "0x188655CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface ALLOOONDEBC<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFDPIIOIBDF();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALLOOONDEBC<T> MNPNDOLEGGB(string DBMKCGLJJHI);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ALLOOONDEBC<T> IEPEGGFPLNJ(NMAPCNNDLGD<T> CACFJGDHOFD);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ALLOOONDEBC<T> BMGPAMGIJGH(int ECHOOMPBJHE);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ALLOOONDEBC<T> FINKMMKNEPM(int ECHOOMPBJHE, CJCAOGJKEOM<T> EJLCIOPMILD);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface DEGILGJNEEG
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALLOOONDEBC<T> JKDMMEHKDLL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFFCBLMMKPH FLNIGDCNNLA(Exception DFLKFAIHDKI);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LDEHOCDMOMK GNHLMNEDLGI(Exception DFLKFAIHDKI);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate string NMAPCNNDLGD<in T>(T DFLKFAIHDKI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate int CJCAOGJKEOM<in T>(T DFLKFAIHDKI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class LHFICHIPENI : DEGILGJNEEG
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate string EODHCDFACLB(Exception DFLKFAIHDKI);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate int ANCOOFKBMOM(Exception DFLKFAIHDKI);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class PICEPLEGGMI<T> : ALLOOONDEBC<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class KLDMHGIPAHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public KLDMHGIPAHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			internal string OHDGEEKFGJP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class JPMPNBINJKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public NMAPCNNDLGD<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public JPMPNBINJKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x5118E80", Offset = "0x5117A80", VA = "0x185118E80")]
			internal string AJHFJBDDMDD(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class DEFMKCHGJCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public CJCAOGJKEOM<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public DEFMKCHGJCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x5118E80", Offset = "0x5117A80", VA = "0x185118E80")]
			internal int PIOEKPNPMNB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly LHFICHIPENI DMEEFMIKHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly Type AJACCOGMFMI;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x57D2A80", Offset = "0x57D1680", VA = "0x1857D2A80")]
		internal PICEPLEGGMI(LHFICHIPENI DMEEFMIKHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x57D2950", Offset = "0x57D1550", VA = "0x1857D2950", Slot = "4")]
		public void MFDPIIOIBDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x57D2980", Offset = "0x57D1580", VA = "0x1857D2980", Slot = "5")]
		public ALLOOONDEBC<T> MNPNDOLEGGB(string DBMKCGLJJHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x57D2850", Offset = "0x57D1450", VA = "0x1857D2850", Slot = "6")]
		public ALLOOONDEBC<T> IEPEGGFPLNJ(NMAPCNNDLGD<T> CACFJGDHOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x57D26F0", Offset = "0x57D12F0", VA = "0x1857D26F0", Slot = "7")]
		public ALLOOONDEBC<T> BMGPAMGIJGH(int ECHOOMPBJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x57D2730", Offset = "0x57D1330", VA = "0x1857D2730", Slot = "8")]
		public ALLOOONDEBC<T> FINKMMKNEPM(int ECHOOMPBJHE, CJCAOGJKEOM<T> EJLCIOPMILD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class PKICICOMGIM<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private bool LNHBGIIDLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<Type> OKPMHCHFGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly Dictionary<Type, TVal> OFPKELLCDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, int> OEIOIFIKHDJ;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> DOLCJDKGCHM
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x57E0B70", Offset = "0x57DF770", VA = "0x1857E0B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x57E1040", Offset = "0x57DFC40", VA = "0x1857E1040")]
		public PKICICOMGIM(Dictionary<Type, int> OEIOIFIKHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x57E0D10", Offset = "0x57DF910", VA = "0x1857E0D10")]
		public void NKAMMCABBBC(Type MEPFFFGIFGB, TVal AGKJLFOJIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x57E0CD0", Offset = "0x57DF8D0", VA = "0x1857E0CD0")]
		public bool LMFGCKCBFHC(Type AJACCOGMFMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x57E0EF0", Offset = "0x57DFAF0", VA = "0x1857E0EF0")]
		public bool ODDOMNHALCL(TVal OOHGFGHCOAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x42E8DF0", Offset = "0x42E79F0", VA = "0x1842E8DF0")]
		public TVal LBDBFELEJGA(Type OPOPAMPKKGD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x57E0AD0", Offset = "0x57DF6D0", VA = "0x1857E0AD0")]
		[CompilerGenerated]
		private int FBDHOPLDKAL(Type GGFLCMEPAEN, Type AAFIDBHJIGE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class KGIIDKGIBGG : IEnumerable<LDEHOCDMOMK>, IEnumerable, IEnumerator<LDEHOCDMOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private LDEHOCDMOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public LHFICHIPENI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IEnumerator<LDEHOCDMOMK> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private LDEHOCDMOMK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x47B2730", Offset = "0x47B1330", VA = "0x1847B2730", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LDEHOCDMOMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x8654790", Offset = "0x8653390", VA = "0x188654790", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public KGIIDKGIBGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x86547E0", Offset = "0x86533E0", VA = "0x1886547E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x86541D0", Offset = "0x8652DD0", VA = "0x1886541D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8654130", Offset = "0x8652D30", VA = "0x188654130")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8654180", Offset = "0x8652D80", VA = "0x188654180")]
		private void JKFKJAKKDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8654740", Offset = "0x8653340", VA = "0x188654740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x8654680", Offset = "0x8653280", VA = "0x188654680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LDEHOCDMOMK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8654680", Offset = "0x8653280", VA = "0x188654680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private static readonly LDEHOCDMOMK EAECLDNGPGC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly Dictionary<Type, int> AGKIEJEPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly HashSet<Type> HMCGLDAJABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly PKICICOMGIM<int> PNJIIOJMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly PKICICOMGIM<ANCOOFKBMOM> NAPLJAOHENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly PKICICOMGIM<EODHCDFACLB> PFILDJKJPHG;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8658110", Offset = "0x8656D10", VA = "0x188658110")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void MACELCFKDEA(PFGPAPHADOM AKKHFHFGLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8658240", Offset = "0x8656E40", VA = "0x188658240")]
	[RecRoom.NoEngine.Common.Preserve]
	public LHFICHIPENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190", Slot = "4")]
	public ALLOOONDEBC<T> JKDMMEHKDLL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x86573B0", Offset = "0x8655FB0", VA = "0x1886573B0", Slot = "5")]
	public NFFCBLMMKPH FLNIGDCNNLA(Exception DFLKFAIHDKI)
	{
		return default(NFFCBLMMKPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x86575C0", Offset = "0x86561C0", VA = "0x1886575C0", Slot = "6")]
	public LDEHOCDMOMK GNHLMNEDLGI(Exception? DFLKFAIHDKI)
	{
		return default(LDEHOCDMOMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8657B70", Offset = "0x8656770", VA = "0x188657B70", Slot = "7")]
	[IteratorStateMachine(typeof(KGIIDKGIBGG))]
	public IEnumerable<LDEHOCDMOMK> KEDOKDCLLNJ(Exception DFLKFAIHDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8657C10", Offset = "0x8656810", VA = "0x188657C10", Slot = "8")]
	public string KPDPHCIOBEF(Exception? DFLKFAIHDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8656E60", Offset = "0x8655A60", VA = "0x188656E60")]
	private string ABCAGJPODJD(AggregateException AHBGDEHBACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8657D60", Offset = "0x8656960", VA = "0x188657D60")]
	private void LGEKIMJAHJM(Type AJACCOGMFMI, int ECHOOMPBJHE, ANCOOFKBMOM? JCNHKFOMJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8657160", Offset = "0x8655D60", VA = "0x188657160")]
	private void COPLKJMMJCN(Type AJACCOGMFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x86578A0", Offset = "0x86564A0", VA = "0x1886578A0")]
	private void HDJLCLNKKIK(Type AJACCOGMFMI, EODHCDFACLB NFMPKIPDODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8657440", Offset = "0x8656040", VA = "0x188657440")]
	private static int GAKAJFBJNIL(Type AJACCOGMFMI, Dictionary<Type, int> OEIOIFIKHDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3B90180", Offset = "0x3B8ED80", VA = "0x183B90180")]
	private static bool BHBHEFNGFEC<TVal>(PKICICOMGIM<TVal> AIPJHMCGMIB, Type AJACCOGMFMI, [Out] TVal OOHGFGHCOAJ) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x86577C0", Offset = "0x86563C0", VA = "0x1886577C0")]
	[CompilerGenerated]
	internal static int HALADMEHLIA(Type LKJFLLEPECN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct NFFCBLMMKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public readonly LDEHOCDMOMK LCNJOLKJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly string JOOCCANJLKO;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x865B640", Offset = "0x865A240", VA = "0x18865B640")]
	public NFFCBLMMKPH(string MAAFPIBGIOI, LDEHOCDMOMK ECHOOMPBJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x865B5A0", Offset = "0x865A1A0", VA = "0x18865B5A0")]
	public string BFIICIDAGFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class FEKGMHDPDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private readonly HOCDMBIPNHL EFDMOIIAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private string DJFLJBBKBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private long? BDOIMHFCFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? EDDEEHACBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? DLEBHDGLDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private string MELLEFBOENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private PCCOAGNMMJI GEDOKNJEDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private long? LHAMPGNFJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private bool PEDMFCGFJLO;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string ODKJCLEDGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long JLEJBJCPOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x864BF10", Offset = "0x864AB10", VA = "0x18864BF10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long IHEBLKLLBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x864BEB0", Offset = "0x864AAB0", VA = "0x18864BEB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long IOGLJNPDHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x864C7C0", Offset = "0x864B3C0", VA = "0x18864C7C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string PPEIJDHILAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x864BF70", Offset = "0x864AB70", VA = "0x18864BF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public PCCOAGNMMJI OJLFJKMOKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA50", Offset = "0xA7B650", VA = "0x180A7CA50")]
		get
		{
			return default(PCCOAGNMMJI);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x864B9F0", Offset = "0x864A5F0", VA = "0x18864B9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long ICPHNCJCNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x864BB80", Offset = "0x864A780", VA = "0x18864BB80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x864C820", Offset = "0x864B420", VA = "0x18864C820")]
	[UnityEngine.Scripting.Preserve]
	public FEKGMHDPDLC([GFNPNOLPMKK(null)] HOCDMBIPNHL EFDMOIIAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x864BC60", Offset = "0x864A860", VA = "0x18864BC60")]
	private void IMEFCOMIMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x864BFB0", Offset = "0x864ABB0", VA = "0x18864BFB0")]
	public void MMLBPBKGOMC(long JKJNCHGDMGL, long KBGIBOKAOOO, [Optional] long? KAPPFCILLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x864BAE0", Offset = "0x864A6E0", VA = "0x18864BAE0")]
	public void DPCJNJDFIOH(long KAPPFCILLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x864BBE0", Offset = "0x864A7E0", VA = "0x18864BBE0")]
	public void HEPFCCLKDKP(string FJALKCHDGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x864C440", Offset = "0x864B040", VA = "0x18864C440")]
	public void NGALOODABCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class BLJFMNNIGKD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct OAGIDKLAMMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public HNLLGFNPJEI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public BLJFMNNIGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private TaskAwaiter<ADJJNPCIJEO.FOAPOAKCCMF<HNLLGFNPJEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x865B9B0", Offset = "0x865A5B0", VA = "0x18865B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x865BEF0", Offset = "0x865AAF0", VA = "0x18865BEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct OBFGLBCJBKJ<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class BDBIAJFINEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public HNLLGFNPJEI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BDBIAJFINEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x8643D20", Offset = "0x8642920", VA = "0x188643D20")]
		internal HNLLGFNPJEI AICKHENKDFF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct CICPKFFLJKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public AsyncTaskMethodBuilder<ADJJNPCIJEO.FOAPOAKCCMF<HNLLGFNPJEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public HNLLGFNPJEI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public BLJFMNNIGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private HLMMMBHGAHE <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter<ADJJNPCIJEO.FOAPOAKCCMF<HNLLGFNPJEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8646840", Offset = "0x8645440", VA = "0x188646840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8646E50", Offset = "0x8645A50", VA = "0x188646E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct LHKPKHEAPOC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public BLJFMNNIGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x52B9D10", Offset = "0x52B8910", VA = "0x1852B9D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x471DDA0", Offset = "0x471C9A0", VA = "0x18471DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct NBLHILNCHPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public BLJFMNNIGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x865B1F0", Offset = "0x8659DF0", VA = "0x18865B1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x865B4D0", Offset = "0x865A0D0", VA = "0x18865B4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class JDLMAJAAKLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JDLMAJAAKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x8652A20", Offset = "0x8651620", VA = "0x188652A20")]
		internal object NJIIKIEFEAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8652960", Offset = "0x8651560", VA = "0x188652960")]
		internal bool FOPFLJGCAKH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class PPHPLLIACCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PPHPLLIACCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x865E1C0", Offset = "0x865CDC0", VA = "0x18865E1C0")]
		internal object LHGNCMICMFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class EBNKPFBBMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EBNKPFBBMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x8649B60", Offset = "0x8648760", VA = "0x188649B60")]
		internal object KMHJJHOOHNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class NDDILGOIJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NDDILGOIJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x865B530", Offset = "0x865A130", VA = "0x18865B530")]
		internal object PENNIHJEFIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class AKKFGHKABDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public BLJFMNNIGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AKKFGHKABDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8642690", Offset = "0x8641290", VA = "0x188642690")]
		internal object LCNJCKAGNGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly Guid BEIDLELMCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public readonly ANOMBEDMGAC BGAIKNCNNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private readonly ADJJNPCIJEO IBMIJJCFPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly COAOCGMDAKP DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly JNHKOMJBMDI BMEDNGEFFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private bool EPDLHKFGPKG;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x86450C0", Offset = "0x8643CC0", VA = "0x1886450C0")]
	public BLJFMNNIGKD(ANOMBEDMGAC JLJMNCGIOCA, ADJJNPCIJEO IBMIJJCFPBN, COAOCGMDAKP DKIFPHGKANK, JNHKOMJBMDI BMEDNGEFFAD, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x86442C0", Offset = "0x8642EC0", VA = "0x1886442C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8644F40", Offset = "0x8643B40", VA = "0x188644F40")]
	public void NPJCAPDLHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8644BF0", Offset = "0x86437F0", VA = "0x188644BF0")]
	public void MAFOKPNOKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8644B30", Offset = "0x8643730", VA = "0x188644B30")]
	public void LPKDALMLBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8644050", Offset = "0x8642C50", VA = "0x188644050")]
	[AsyncStateMachine(typeof(OAGIDKLAMMO))]
	internal Task<HNLLGFNPJEI> CADCNOMEHFJ(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, HNLLGFNPJEI HJHLPCOBPOB, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3838600", Offset = "0x3837200", VA = "0x183838600")]
	private static byte[] FNJIBKFBFKN<T>(T FNFIPKNHEOF) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3838610", Offset = "0x3837210", VA = "0x183838610")]
	private static T GGONPIBPLFM<T>(MessageParser<T> LPEBMNFIGNF, byte[] FNFIPKNHEOF, T NDMHPENFPCO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x86442D0", Offset = "0x8642ED0", VA = "0x1886442D0")]
	[AsyncStateMachine(typeof(CICPKFFLJKB))]
	private Task<ADJJNPCIJEO.FOAPOAKCCMF<HNLLGFNPJEI>> GLFJEEENMAK(HNLLGFNPJEI HJHLPCOBPOB, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3838A00", Offset = "0x3837600", VA = "0x183838A00")]
	[AsyncStateMachine(typeof(LHKPKHEAPOC<>))]
	internal Task<T> NCKNJOPNKAA<T>(CancellationToken DCACDPOIBLL, Func<CancellationToken, Task<T>> DJAGKDHEDAD, int GHIKKJJMDDF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8644E10", Offset = "0x8643A10", VA = "0x188644E10")]
	[AsyncStateMachine(typeof(NBLHILNCHPM))]
	internal Task NCKNJOPNKAA(CancellationToken DCACDPOIBLL, Func<CancellationToken, Task> DJAGKDHEDAD, int GHIKKJJMDDF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x86446A0", Offset = "0x86432A0", VA = "0x1886446A0")]
	public HBEEBMIEANC HNFMOKGNDDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8644AA0", Offset = "0x86436A0", VA = "0x188644AA0")]
	public MOMEEGHCEND KCAPLFKCNHO([Optional] JHGGDGBLLHI KKADINGOJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8644830", Offset = "0x8643430", VA = "0x188644830")]
	public EOENFKNOMNE JEGECDIAJFL([Optional] JPIBGNDAFKP? FAOMHPPHFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8644CB0", Offset = "0x86438B0", VA = "0x188644CB0")]
	public void NCIGAPBBNBP(Func<Guid, bool> IHHLJPDMCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8644410", Offset = "0x8643010", VA = "0x188644410")]
	public void GPCLNFFHAFP(Func<Guid, bool> LBAMNMKDBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8644520", Offset = "0x8643120", VA = "0x188644520")]
	public Guid HJIKLLFIBAC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x86441B0", Offset = "0x8642DB0", VA = "0x1886441B0")]
	public void DICBLFGJJIG(Guid NCHDMOCJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8643ED0", Offset = "0x8642AD0", VA = "0x188643ED0")]
	public void ABIONBKECBK(HNLLGFNPJEI HCBPPJOKJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8644720", Offset = "0x8643320", VA = "0x188644720")]
	public void HOEGMFFOKBK(string LDLMAIGKIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3838510", Offset = "0x3837110", VA = "0x183838510")]
	private T EMOMAHBHNPL<T>(T OOHGFGHCOAJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x8644000", Offset = "0x8642C00", VA = "0x188644000")]
	public void AMFDLHIKGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3838760", Offset = "0x3837360", VA = "0x183838760")]
	[CompilerGenerated]
	internal static string LOIKBNDJBIO<T>(byte[] OEOOBGJGDIH, int CHEPOIJLLIC, OBFGLBCJBKJ<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal sealed class KPIPLPBGGLB : ANOMBEDMGAC
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class JKFCPBPCJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JKFCPBPCJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8653DA0", Offset = "0x86529A0", VA = "0x188653DA0")]
		internal object LGBCCJOCEAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct GEDEOOCGJIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public KPIPLPBGGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private DJLJJDANPIF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private MOMEEGHCEND <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<CEMFGADAOBF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x864F970", Offset = "0x864E570", VA = "0x18864F970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8650870", Offset = "0x864F470", VA = "0x188650870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct DNIGPADHPFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public KPIPLPBGGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private TaskAwaiter<KINJLHLHADG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8647FF0", Offset = "0x8646BF0", VA = "0x188647FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8648790", Offset = "0x8647390", VA = "0x188648790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct FLCDONLAGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public KPIPLPBGGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter<CLPJHDPKJPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x864CE50", Offset = "0x864BA50", VA = "0x18864CE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x864D160", Offset = "0x864BD60", VA = "0x18864D160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class HAMCIOLOKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public DJLJJDANPIF presence;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HAMCIOLOKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x86509F0", Offset = "0x864F5F0", VA = "0x1886509F0")]
		internal object NAJEEKEIDFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly JPIBGNDAFKP OBKGIOBEOIF;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly JPIBGNDAFKP JEPGGGGLMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private readonly FCFEBPBOLMP ACGKDMFKKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly FJAIPDANBOO MGDFACLDPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly JHGGDGBLLHI KKADINGOJDG;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x8655190", Offset = "0x8653D90", VA = "0x188655190")]
	public KPIPLPBGGLB(FCFEBPBOLMP ACGKDMFKKMI, FJAIPDANBOO MGDFACLDPBN, Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, OIDEJNGNBIE JHOAOMGNFDK, JHGGDGBLLHI KKADINGOJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8654F70", Offset = "0x8653B70", VA = "0x188654F70", Slot = "7")]
	[AsyncStateMachine(typeof(GEDEOOCGJIE))]
	protected override Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8654D60", Offset = "0x8653960", VA = "0x188654D60")]
	[AsyncStateMachine(typeof(DNIGPADHPFB))]
	private Task CNGMJLGGPNK(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8654E60", Offset = "0x8653A60", VA = "0x188654E60")]
	[AsyncStateMachine(typeof(FLCDONLAGBM))]
	private Task<int> DNMLAFMJKIK(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8654B90", Offset = "0x8653790", VA = "0x188654B90")]
	private DJLJJDANPIF BMAKCMFEGHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class DKIFMMKPOAA : ANOMBEDMGAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct JIPBGCCPIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public DKIFMMKPOAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private TaskAwaiter<NHMGHNEDIJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8653390", Offset = "0x8651F90", VA = "0x188653390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8653D40", Offset = "0x8652940", VA = "0x188653D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly int DAPPDHABEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly KJNCMPAKDDO KNOPMIEECBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public readonly long PAKBEKGHOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long ILJCELHMKFA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NHMGHNEDIJJ IKDBLOJBGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA2BE50", Offset = "0xA2AA50", VA = "0x180A2BE50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA2BC90", Offset = "0xA2A890", VA = "0x180A2BC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x8647EC0", Offset = "0x8646AC0", VA = "0x188647EC0")]
	public DKIFMMKPOAA(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, OIDEJNGNBIE JHOAOMGNFDK, int DAPPDHABEDJ, KJNCMPAKDDO KNOPMIEECBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8647DA0", Offset = "0x86469A0", VA = "0x188647DA0", Slot = "7")]
	[AsyncStateMachine(typeof(JIPBGCCPIED))]
	protected override Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal abstract class IDKIAIFHNLD : ANOMBEDMGAC
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class BGNBJEEPKCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public IDKIAIFHNLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public MGIGFDPHHAN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BGNBJEEPKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x8643E90", Offset = "0x8642A90", VA = "0x188643E90")]
		internal Task CNMINHIEHPP(HMEJDNPIBLC<string>.FIEDNALJEDE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x8643E00", Offset = "0x8642A00", VA = "0x188643E00")]
		internal object AGNJMDAOMFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct LCGBIFOAJEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public IDKIAIFHNLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private BGNBJEEPKCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8655340", Offset = "0x8653F40", VA = "0x188655340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8655C50", Offset = "0x8654850", VA = "0x188655C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct EFLIECBOMPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public MGIGFDPHHAN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IDKIAIFHNLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x864A760", Offset = "0x8649360", VA = "0x18864A760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x864AD10", Offset = "0x8649910", VA = "0x18864AD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x86516E0", Offset = "0x86502E0", VA = "0x1886516E0")]
	public IDKIAIFHNLD(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, OIDEJNGNBIE JHOAOMGNFDK, string CLHKIKGBNML, CDKBIPEOCCB MKMDKJJLADP, bool GCDIJGHLGIE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x8651460", Offset = "0x8650060", VA = "0x188651460", Slot = "7")]
	[AsyncStateMachine(typeof(LCGBIFOAJEO))]
	protected override Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task BDPFMCODMJA(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x86515A0", Offset = "0x86501A0", VA = "0x1886515A0")]
	[AsyncStateMachine(typeof(EFLIECBOMPG))]
	private Task JHFBPBPCGAO(IDisposable JIPOIAAAADI, MGIGFDPHHAN GMNADMGJBIC, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal class KCFCBPELIMA : ANOMBEDMGAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct FGLDLNJFGDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public KCFCBPELIMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter<JOPODIFOAJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x864C860", Offset = "0x864B460", VA = "0x18864C860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x864CDF0", Offset = "0x864B9F0", VA = "0x18864CDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private readonly IGBBMPDAJMA PCAOHCHCKBL;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x8654090", Offset = "0x8652C90", VA = "0x188654090")]
	public KCFCBPELIMA(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, OIDEJNGNBIE JHOAOMGNFDK, IGBBMPDAJMA PCAOHCHCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x8653E90", Offset = "0x8652A90", VA = "0x188653E90", Slot = "6")]
	protected override string DKMPGIKAKAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8653F70", Offset = "0x8652B70", VA = "0x188653F70", Slot = "7")]
	[AsyncStateMachine(typeof(FGLDLNJFGDJ))]
	protected override Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal abstract class ANOMBEDMGAC : PAJJIFDECGF
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public delegate Task EDFEMIMAPFL(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class BNNCGPIIIHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public ANOMBEDMGAC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BNNCGPIIIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x86452F0", Offset = "0x8643EF0", VA = "0x1886452F0")]
		internal Task GLLOEJICHJB(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class PGOBJGCEBIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public BNNCGPIIIHD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PGOBJGCEBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x865C8E0", Offset = "0x865B4E0", VA = "0x18865C8E0")]
		internal object JELDNCPHIMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct DPPOPKDFMKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public ANOMBEDMGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Func<ANOMBEDMGAC, HMEJDNPIBLC<string>.FIEDNALJEDE, BLJFMNNIGKD> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private BNNCGPIIIHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private BLJFMNNIGKD <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x86487F0", Offset = "0x86473F0", VA = "0x1886487F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8649B00", Offset = "0x8648700", VA = "0x188649B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct EKNCHPHHOJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x864ADD0", Offset = "0x86499D0", VA = "0x18864ADD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x864B870", Offset = "0x864A470", VA = "0x18864B870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct PNJOFKNIEHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public ANOMBEDMGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x865D730", Offset = "0x865C330", VA = "0x18865D730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x865DA90", Offset = "0x865C690", VA = "0x18865DA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public readonly Guid GHDCEEHHGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public readonly ByteString OEBNJIIINMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly OIDEJNGNBIE IMIMAEJLNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	protected readonly string IPCKMKPBEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly bool GCDIJGHLGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly Queue<EDFEMIMAPFL> HLMIOIJCBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly JAEEODMGAEH JJMEHGHKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly CDKBIPEOCCB MKMDKJJLADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private bool HDJKAMIHFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public PCCOAGNMMJI NLIBHIDAKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public PCCOAGNMMJI DGHHANMCMGE;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public KMLAPHJELJN OACFHNOPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8643130", Offset = "0x8641D30", VA = "0x188643130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public PIHMIMMNDBA FCMAGNJPMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x8642B50", Offset = "0x8641750", VA = "0x188642B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8642F60", Offset = "0x8641B60", VA = "0x188642F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event ADPJAAAHAMD MNKFJJJOAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8642950", Offset = "0x8641550", VA = "0x188642950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8643110", Offset = "0x8641D10", VA = "0x188643110", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x8643420", Offset = "0x8642020", VA = "0x188643420")]
	protected ANOMBEDMGAC(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, OIDEJNGNBIE JHOAOMGNFDK, string CLHKIKGBNML, CDKBIPEOCCB MKMDKJJLADP, bool GCDIJGHLGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x8642970", Offset = "0x8641570", VA = "0x188642970", Slot = "6")]
	protected virtual string DKMPGIKAKAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x8642CC0", Offset = "0x86418C0", VA = "0x188642CC0")]
	public void KJNBGBCEHKE(EDFEMIMAPFL NLJABCHLKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8642B30", Offset = "0x8641730", VA = "0x188642B30")]
	protected void GBKHHNAMHMH(float MBEDIGACNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8642D20", Offset = "0x8641920", VA = "0x188642D20")]
	[AsyncStateMachine(typeof(DPPOPKDFMKP))]
	public Task KNAKIDBGLNI(CancellationToken DKKNFNCKCEB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, [Optional] Func<ANOMBEDMGAC, HMEJDNPIBLC<string>.FIEDNALJEDE, BLJFMNNIGKD> HGBNLDABPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8642FE0", Offset = "0x8641BE0", VA = "0x188642FE0")]
	[AsyncStateMachine(typeof(EKNCHPHHOJN))]
	private static Task MBMGFDPAGNO(Func<CancellationToken, Task> DLJLAHIFPGJ, Func<CancellationToken, Task> LHNGKLOAKNN, CancellationToken DCACDPOIBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x86429B0", Offset = "0x86415B0", VA = "0x1886429B0")]
	private void EOCKLMGMIED(bool MBDJGJKJICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8643200", Offset = "0x8641E00", VA = "0x188643200")]
	private void PPOKDOILHFK(BLJFMNNIGKD LDEHLLCJGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8642BA0", Offset = "0x86417A0", VA = "0x188642BA0")]
	[AsyncStateMachine(typeof(PNJOFKNIEHH))]
	private Task KFIBJADIMMK(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x8643180", Offset = "0x8641D80", VA = "0x188643180")]
	public HNLLGFNPJEI NOIJGNBEGFE(HLMMMBHGAHE BBGHHPMANMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8642E70", Offset = "0x8641A70", VA = "0x188642E70")]
	[CompilerGenerated]
	private Task LBNIODDNAPP(CancellationToken LPCHKKFEGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x86428D0", Offset = "0x86414D0", VA = "0x1886428D0")]
	[CompilerGenerated]
	private object BGFLKHNGHGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal sealed class PPEGGIENFIM : IDKIAIFHNLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct GABLCGEOFJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public PPEGGIENFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private LFGJEGOCDII <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private MOMEEGHCEND <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x864E640", Offset = "0x864D240", VA = "0x18864E640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x864EDA0", Offset = "0x864D9A0", VA = "0x18864EDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private readonly FCFEBPBOLMP BDOIJPCFEPJ;

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x865E110", Offset = "0x865CD10", VA = "0x18865E110")]
	public PPEGGIENFIM(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, FCFEBPBOLMP BDOIJPCFEPJ, OIDEJNGNBIE JHOAOMGNFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x865DFC0", Offset = "0x865CBC0", VA = "0x18865DFC0", Slot = "8")]
	[AsyncStateMachine(typeof(GABLCGEOFJA))]
	protected override Task BDPFMCODMJA(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class OLNKCPKONDA : ANOMBEDMGAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct IMACEMPMJNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public OLNKCPKONDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter<JOPODIFOAJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8651870", Offset = "0x8650470", VA = "0x188651870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x8651C20", Offset = "0x8650820", VA = "0x188651C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private readonly string IKJCEDNCJCB;

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x865C640", Offset = "0x865B240", VA = "0x18865C640")]
	public OLNKCPKONDA(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, OIDEJNGNBIE JHOAOMGNFDK, string IKJCEDNCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x865C530", Offset = "0x865B130", VA = "0x18865C530", Slot = "7")]
	[AsyncStateMachine(typeof(IMACEMPMJNA))]
	protected override Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class GBHCJJEMPDL : IDKIAIFHNLD
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class EPDIKLKEENC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			public EPDIKLKEENC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private TaskAwaiter<JOPODIFOAJI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private TaskAwaiter<HNLLGFNPJEI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x865E220", Offset = "0x865CE20", VA = "0x18865E220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x865E710", Offset = "0x865D310", VA = "0x18865E710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GBHCJJEMPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public EOENFKNOMNE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public KHDDPNLIHJD roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public HBEEBMIEANC uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public LJJJPAOGPFE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EPDIKLKEENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x864B8D0", Offset = "0x864A4D0", VA = "0x18864B8D0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<HNLLGFNPJEI> NJALPHNAFJA(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct CLNOMLFJKMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GBHCJJEMPDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private EPDIKLKEENC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private LFGJEGOCDII <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private MOMEEGHCEND <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private HNLLGFNPJEI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8646EC0", Offset = "0x8645AC0", VA = "0x188646EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x8647D40", Offset = "0x8646940", VA = "0x188647D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private static readonly JPIBGNDAFKP OBKGIOBEOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly int IDJFHNCGAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	[CanBeNull]
	private readonly BIBLILLBLLL HFJBDNPALNN;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x864F2C0", Offset = "0x864DEC0", VA = "0x18864F2C0")]
	public GBHCJJEMPDL(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, int IDJFHNCGAIP, BIBLILLBLLL HFJBDNPALNN, OIDEJNGNBIE JHOAOMGNFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x864EE00", Offset = "0x864DA00", VA = "0x18864EE00", Slot = "8")]
	[AsyncStateMachine(typeof(CLNOMLFJKMG))]
	protected override Task BDPFMCODMJA(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x864F110", Offset = "0x864DD10", VA = "0x18864F110")]
	private void OBAAGPBNKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x864EF40", Offset = "0x864DB40", VA = "0x18864EF40")]
	private void JCGCBKOMNIH(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, LFGJEGOCDII DCFHCALNHDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class PANLIFGJCEK : ANOMBEDMGAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct FPHAIDGAJHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public PANLIFGJCEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private LFGJEGOCDII <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private CLPJHDPKJPJ <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private PHKGFEHMLBA<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter<CLPJHDPKJPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<NHMGHNEDIJJ> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x864D1D0", Offset = "0x864BDD0", VA = "0x18864D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x864E5E0", Offset = "0x864D1E0", VA = "0x18864E5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly int IDJFHNCGAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private readonly BIBLILLBLLL HFJBDNPALNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private Func<JOPODIFOAJI, JOPODIFOAJI> EPGJCAKJAJC;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x865C820", Offset = "0x865B420", VA = "0x18865C820")]
	public PANLIFGJCEK(Guid DIPCJMNHKDB, KMLAPHJELJN KFBBLAFGOAP, int IDJFHNCGAIP, BIBLILLBLLL HFJBDNPALNN, Func<JOPODIFOAJI, JOPODIFOAJI> EPGJCAKJAJC, OIDEJNGNBIE JHOAOMGNFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x865C6F0", Offset = "0x865B2F0", VA = "0x18865C6F0", Slot = "7")]
	[AsyncStateMachine(typeof(FPHAIDGAJHJ))]
	protected override Task HMJFIDLOEBB(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal abstract class MJCLDGCAOMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public readonly ANOMBEDMGAC BGAIKNCNNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public readonly BLJFMNNIGKD ECCKENDNKJH;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8658D20", Offset = "0x8657920", VA = "0x188658D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8658C90", Offset = "0x8657890", VA = "0x188658C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x8658D70", Offset = "0x8657970", VA = "0x188658D70")]
	protected MJCLDGCAOMF(BLJFMNNIGKD LDEHLLCJGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x8658B80", Offset = "0x8657780", VA = "0x188658B80")]
	protected void HOEGMFFOKBK(string LDLMAIGKIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct GDPBGADNPEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public Dictionary<Guid, List<DPNJMGHIIBJ>> OFPOIJOGNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public Dictionary<Guid, List<DPNJMGHIIBJ>> LDOLEGLALFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<DPNJMGHIIBJ>> MDAOMNMJJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public List<Guid> HMAAIGKGADM;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x864F370", Offset = "0x864DF70", VA = "0x18864F370")]
	public static GDPBGADNPEN LBDBFELEJGA(AGABMHMNIPB ECPFHMDENEE, PCCOAGNMMJI EAENGAIGFCA, KGGEOPPOKLC DHIGGHNJJLN)
	{
		return default(GDPBGADNPEN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct LCABONLCDBN
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	public static LCABONLCDBN GLOMJONEBBE()
	{
		return default(LCABONLCDBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct JBLHFNLKPCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public readonly KINJLHLHADG LLPPGIONGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public readonly CGPLGKCGOLD DBAKHEJGKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly Guid? IJGNKDKNEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly IReadOnlyCollection<PFPKEOCLAOD> NDJHDIJIAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly IReadOnlyCollection<PFPKEOCLAOD> AMINNPODAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly IDLFIGEMLKL OLNOBDEBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly IDLFIGEMLKL MAKPBGFOOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly JJNCBFJEABI LNMINIGNMBI;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool BDMOEDLNJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x8652820", Offset = "0x8651420", VA = "0x188652820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x86528B0", Offset = "0x86514B0", VA = "0x1886528B0")]
	public JBLHFNLKPCH(KINJLHLHADG LLPPGIONGOK, CGPLGKCGOLD DBAKHEJGKDD, Guid? IJGNKDKNEFC, IReadOnlyList<PFPKEOCLAOD> NDJHDIJIAHD, IReadOnlyCollection<PFPKEOCLAOD> AMINNPODAKG, IDLFIGEMLKL OLNOBDEBFAH, IDLFIGEMLKL MAKPBGFOOLO, JJNCBFJEABI LNMINIGNMBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct HKANJADFFLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly BLJFMNNIGKD LDEHLLCJGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private readonly Guid NCHDMOCJMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool MBDJGJKJICC;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8650F20", Offset = "0x864FB20", VA = "0x188650F20")]
	public static HKANJADFFLC HJIKLLFIBAC(BLJFMNNIGKD LDEHLLCJGOI)
	{
		return default(HKANJADFFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x126B480", Offset = "0x126A080", VA = "0x18126B480")]
	public void GGHCKOFKMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8650F10", Offset = "0x864FB10", VA = "0x188650F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8650F50", Offset = "0x864FB50", VA = "0x188650F50")]
	private HKANJADFFLC(BLJFMNNIGKD LDEHLLCJGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8650CE0", Offset = "0x864F8E0", VA = "0x188650CE0")]
	private void DICBLFGJJIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8650C40", Offset = "0x864F840", VA = "0x188650C40")]
	private Func<Guid, bool> BENFICKJMKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal class MOMEEGHCEND : MJCLDGCAOMF, PAJJIFDECGF
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public delegate Task<PCCOAGNMMJI> JOAKNGBFKOB(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP BKCNFNKMIJN, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct FIHJCLBHOMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public FCFEBPBOLMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private HKANJADFFLC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x8666450", Offset = "0x8665050", VA = "0x188666450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8666BA0", Offset = "0x86657A0", VA = "0x188666BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct OBAMLBFLJGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public FCFEBPBOLMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8670650", Offset = "0x866F250", VA = "0x188670650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8670A80", Offset = "0x866F680", VA = "0x188670A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct ABMOGAKPBFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public FCFEBPBOLMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x865EDA0", Offset = "0x865D9A0", VA = "0x18865EDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x865F260", Offset = "0x865DE60", VA = "0x18865F260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class GOJEELHDDLP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public AsyncTaskMethodBuilder<JBLHFNLKPCH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public GOJEELHDDLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			private JBLHFNLKPCH <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			private TaskAwaiter<PCCOAGNMMJI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private TaskAwaiter<JBLHFNLKPCH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8674400", Offset = "0x8673000", VA = "0x188674400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x8674CC0", Offset = "0x86738C0", VA = "0x188674CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public AsyncTaskMethodBuilder<KGGEOPPOKLC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public GOJEELHDDLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			private KGGEOPPOKLC <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			private TaskAwaiter<PCCOAGNMMJI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private TaskAwaiter<KGGEOPPOKLC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8674D30", Offset = "0x8673930", VA = "0x188674D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8675380", Offset = "0x8673F80", VA = "0x188675380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public FCFEBPBOLMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public JAEEODMGAEH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public JAEEODMGAEH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public JBLHFNLKPCH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public JAEEODMGAEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public KGGEOPPOKLC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public ELMOKFLOKJN.PDPIOPNOHEG <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GOJEELHDDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8669860", Offset = "0x8668460", VA = "0x188669860")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<JBLHFNLKPCH> NKBNJINHDOM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x8669740", Offset = "0x8668340", VA = "0x188669740")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<KGGEOPPOKLC> MKKIEDPDHAE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x86699F0", Offset = "0x86685F0", VA = "0x1886699F0")]
		internal void PEJBMDBJBLF(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8669700", Offset = "0x8668300", VA = "0x188669700")]
		internal Task AKMBADHMOJD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x86699B0", Offset = "0x86685B0", VA = "0x1886699B0")]
		internal Task OOJKIHJFEGP(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct PGADEDILBEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public FCFEBPBOLMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private GOJEELHDDLP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private TaskAwaiter<JBLHFNLKPCH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter<KGGEOPPOKLC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x8672A10", Offset = "0x8671610", VA = "0x188672A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x86736C0", Offset = "0x86722C0", VA = "0x1886736C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct DGCEHLPIGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public KGGEOPPOKLC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public JAEEODMGAEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private JEJODNJGOPP <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8663430", Offset = "0x8662030", VA = "0x188663430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8664290", Offset = "0x8662E90", VA = "0x188664290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct LGFMJIICJII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x866E2F0", Offset = "0x866CEF0", VA = "0x18866E2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x866EAD0", Offset = "0x866D6D0", VA = "0x18866EAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct GBANLKMDCMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8666E90", Offset = "0x8665A90", VA = "0x188666E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x86676D0", Offset = "0x86662D0", VA = "0x1886676D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct GDBEHCIKIJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8667730", Offset = "0x8666330", VA = "0x188667730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x86686F0", Offset = "0x86672F0", VA = "0x1886686F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct MMJMPAAMJDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public JEJODNJGOPP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x866F4D0", Offset = "0x866E0D0", VA = "0x18866F4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x86705E0", Offset = "0x866F1E0", VA = "0x1886705E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct PNACLLKNFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public PCCOAGNMMJI operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public KGGEOPPOKLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8673720", Offset = "0x8672320", VA = "0x188673720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8673980", Offset = "0x8672580", VA = "0x188673980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class LKHCCNFNBFM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public LKHCCNFNBFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			private GFJANGGIPEI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			private TaskAwaiter<PCCOAGNMMJI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x86753F0", Offset = "0x8673FF0", VA = "0x1886753F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x8675A10", Offset = "0x8674610", VA = "0x188675A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public JOAKNGBFKOB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public JEJODNJGOPP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public PCCOAGNMMJI originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LKHCCNFNBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x866EB30", Offset = "0x866D730", VA = "0x18866EB30")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<PCCOAGNMMJI> NNFPEPOPLNH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct BNNELJPDFPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public JOAKNGBFKOB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public JEJODNJGOPP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8661F60", Offset = "0x8660B60", VA = "0x188661F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x8662480", Offset = "0x8661080", VA = "0x188662480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct AHEIMFJLCBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private PCCOAGNMMJI <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private IEnumerator<PCCOAGNMMJI> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x865F7A0", Offset = "0x865E3A0", VA = "0x18865F7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x865FCF0", Offset = "0x865E8F0", VA = "0x18865FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct EKGCEKDNBHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8665090", Offset = "0x8663C90", VA = "0x188665090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8665380", Offset = "0x8663F80", VA = "0x188665380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct DHOPLFJAHAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x86642F0", Offset = "0x8662EF0", VA = "0x1886642F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8664510", Offset = "0x8663110", VA = "0x188664510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class CHKLMBAEDEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public CHKLMBAEDEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public KGGEOPPOKLC data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public JAEEODMGAEH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			private TaskAwaiter<PCCOAGNMMJI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<OBGNMNBMKOE> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x8675A80", Offset = "0x8674680", VA = "0x188675A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x8676540", Offset = "0x8675140", VA = "0x188676540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public IHCGOCIDEPL mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CHKLMBAEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x86624F0", Offset = "0x86610F0", VA = "0x1886624F0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<PCCOAGNMMJI> HNPOHDAPLMP(KGGEOPPOKLC data, JEJODNJGOPP _, JAEEODMGAEH progressTracker, HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct KGDJOOHGIIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public KGGEOPPOKLC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public JAEEODMGAEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private CHKLMBAEDEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private JEJODNJGOPP <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x866D370", Offset = "0x866BF70", VA = "0x18866D370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x866E1C0", Offset = "0x866CDC0", VA = "0x18866E1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct AJBJJKLHJMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x865FD50", Offset = "0x865E950", VA = "0x18865FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8660150", Offset = "0x865ED50", VA = "0x188660150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct HAOIDHFEPPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public MOMEEGHCEND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public JAEEODMGAEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x866A280", Offset = "0x8668E80", VA = "0x18866A280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x866A8A0", Offset = "0x86694A0", VA = "0x18866A8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly ADHEHODAAFN IFHLOOAICBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private readonly ADHEHODAAFN BEBMJJECPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly FEKGMHDPDLC CBKOAFBLJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly OLBJMBPEDLJ FMDANEPNELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly BMLAMDJIODD LLLMAKPFPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private ProfilerCounterValue<int> PCILCMJNPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly FGLHPFEEAKO KHCLPOAEFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private readonly JHGGDGBLLHI KKADINGOJDG;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private KMLAPHJELJN OACFHNOPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x865A090", Offset = "0x8658C90", VA = "0x18865A090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event ADPJAAAHAMD MNKFJJJOAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8659380", Offset = "0x8657F80", VA = "0x188659380", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x865AAA0", Offset = "0x86596A0", VA = "0x18865AAA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x865AF00", Offset = "0x8659B00", VA = "0x18865AF00")]
	public MOMEEGHCEND(BLJFMNNIGKD LDEHLLCJGOI, JHGGDGBLLHI KKADINGOJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8659B10", Offset = "0x8658710", VA = "0x188659B10")]
	[AsyncStateMachine(typeof(FIHJCLBHOMG))]
	public Task GHBFJEHFGMC(FCFEBPBOLMP BJAGJMJPKHA, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x865AC10", Offset = "0x8659810", VA = "0x18865AC10")]
	[AsyncStateMachine(typeof(OBAMLBFLJGE))]
	private Task<HNLLGFNPJEI> NPDFFHAEGPH(FCFEBPBOLMP BJAGJMJPKHA, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x865AD70", Offset = "0x8659970", VA = "0x18865AD70")]
	[AsyncStateMachine(typeof(ABMOGAKPBFH))]
	private Task OGNAFCDLMBL(FCFEBPBOLMP BJAGJMJPKHA, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x865A0C0", Offset = "0x8658CC0", VA = "0x18865A0C0")]
	[AsyncStateMachine(typeof(PGADEDILBEP))]
	private Task JOEDMHCABIO(FCFEBPBOLMP BJAGJMJPKHA, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken HCMDMIKFILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x86593A0", Offset = "0x8657FA0", VA = "0x1886593A0")]
	[AsyncStateMachine(typeof(DGCEHLPIGJI))]
	private Task BIDNIFOJALE(KGGEOPPOKLC OOOFAFJBJMM, JAEEODMGAEH HDPNJEKLKHL, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken OCNLHKKOPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x865A340", Offset = "0x8658F40", VA = "0x18865A340")]
	[AsyncStateMachine(typeof(LGFMJIICJII))]
	private Task KLNLCIONIOK(HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x865AAC0", Offset = "0x86596C0", VA = "0x18865AAC0")]
	[AsyncStateMachine(typeof(GBANLKMDCMP))]
	private Task NKIIPMOMDPJ(KGGEOPPOKLC PEDMEJIDLNB, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x865A940", Offset = "0x8659540", VA = "0x18865A940")]
	[AsyncStateMachine(typeof(GDBEHCIKIJL))]
	private Task<PCCOAGNMMJI> MDELOGKNPMC(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x86597A0", Offset = "0x86583A0", VA = "0x1886597A0")]
	[AsyncStateMachine(typeof(MMJMPAAMJDF))]
	private Task<PCCOAGNMMJI> EDJENEKKHCB(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x865A570", Offset = "0x8659170", VA = "0x18865A570")]
	[AsyncStateMachine(typeof(PNACLLKNFEN))]
	private Task<PCCOAGNMMJI> LBMDFCCHNBB(PCCOAGNMMJI EAENGAIGFCA, KGGEOPPOKLC DHIGGHNJJLN, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB, bool JCCGELPCOBB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8659C60", Offset = "0x8658860", VA = "0x188659C60")]
	private bool GKHCOKFAPKA(KGGEOPPOKLC OOOFAFJBJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x86594F0", Offset = "0x86580F0", VA = "0x1886594F0")]
	[AsyncStateMachine(typeof(BNNELJPDFPI))]
	protected Task<PCCOAGNMMJI> BIJFMCICNOJ(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB, JOAKNGBFKOB MGMAOJAGJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8659F40", Offset = "0x8658B40", VA = "0x188659F40")]
	[AsyncStateMachine(typeof(AHEIMFJLCBL))]
	private Task JHOGFMJCDLP(KGGEOPPOKLC PEDMEJIDLNB, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8659D70", Offset = "0x8658970", VA = "0x188659D70")]
	private void ILJMGKCLINB(PCCOAGNMMJI LCGIJMEHLHH, JAEEODMGAEH HAPILEADHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8659340", Offset = "0x8657F40", VA = "0x188659340")]
	private void AMGOJLHCGKC(PCCOAGNMMJI FODNELPIODM, [Out] PCCOAGNMMJI OPMLBGAPKFB, [Out] PCCOAGNMMJI PGGJIJAGOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8659960", Offset = "0x8658560", VA = "0x188659960")]
	private Task<JBLHFNLKPCH> EJFNCBBPEMI(FCFEBPBOLMP BJAGJMJPKHA, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8659920", Offset = "0x8658520", VA = "0x188659920")]
	private Task<KGGEOPPOKLC> EEFJIGNLCPO(JBLHFNLKPCH PEDMEJIDLNB, ELMOKFLOKJN.PDPIOPNOHEG JMDKFJOMBGI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x86599A0", Offset = "0x86585A0", VA = "0x1886599A0")]
	[AsyncStateMachine(typeof(EKGCEKDNBHE))]
	private Task EJGGAJEAAIL(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB, bool AIIHEKLNJJP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x865A6F0", Offset = "0x86592F0", VA = "0x18865A6F0")]
	[AsyncStateMachine(typeof(DHOPLFJAHAP))]
	private Task LIAFOFJADJN(KGGEOPPOKLC PEDMEJIDLNB, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x8659DC0", Offset = "0x86589C0", VA = "0x188659DC0")]
	private Task IPCEPMLEOCP(KGGEOPPOKLC PEDMEJIDLNB, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8659D50", Offset = "0x8658950", VA = "0x188659D50")]
	private Task HBNOCFHBPHL(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x865AEB0", Offset = "0x8659AB0", VA = "0x18865AEB0")]
	private Task OJKKNGFJNGE(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x8659AF0", Offset = "0x86586F0", VA = "0x188659AF0")]
	private Task GADPHBMOLNE(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x865AEF0", Offset = "0x8659AF0", VA = "0x18865AEF0")]
	private static Task PPEMMOHCHJL(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x865AED0", Offset = "0x8659AD0", VA = "0x18865AED0")]
	private Task PDIGPPOCING(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x86596D0", Offset = "0x86582D0", VA = "0x1886596D0")]
	private Task CPILMKBJHLC(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8659680", Offset = "0x8658280", VA = "0x188659680")]
	private void CBOCACELBBI(FCFEBPBOLMP BJAGJMJPKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x86596F0", Offset = "0x86582F0", VA = "0x1886596F0")]
	public void DENHEBHPBMG(long KAPPFCILLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void LGPDHBIIFGA(KINJLHLHADG LLPPGIONGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8659DF0", Offset = "0x86589F0", VA = "0x188659DF0")]
	[AsyncStateMachine(typeof(KGDJOOHGIIN))]
	private Task JCMHAKNPJPM(KGGEOPPOKLC OOOFAFJBJMM, JAEEODMGAEH HDPNJEKLKHL, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken OCNLHKKOPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x865A200", Offset = "0x8658E00", VA = "0x18865A200")]
	[AsyncStateMachine(typeof(AJBJJKLHJMM))]
	private Task KAHBIOPJIDC(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x865A450", Offset = "0x8659050", VA = "0x18865A450")]
	private static JIEEKEEBHCL KNDCDCBKAPK(KGGEOPPOKLC DHIGGHNJJLN)
	{
		return default(JIEEKEEBHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x865A7E0", Offset = "0x86593E0", VA = "0x18865A7E0")]
	[AsyncStateMachine(typeof(HAOIDHFEPPO))]
	private Task<PCCOAGNMMJI> MDBFPACMJCH(KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, JAEEODMGAEH HAPILEADHHI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private void JILHGGEOPKP(PCCOAGNMMJI AOPBECFPBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct IGKNIMKMNGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private KGGEOPPOKLC PEDMEJIDLNB;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x866B730", Offset = "0x866A330", VA = "0x18866B730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x866B440", Offset = "0x866A040", VA = "0x18866B440")]
	public static Task KNAKIDBGLNI(KMLAPHJELJN KFBBLAFGOAP, KGGEOPPOKLC PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x866B520", Offset = "0x866A120", VA = "0x18866B520")]
	private void KNAKIDBGLNI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct MGDMCCKPOEG
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x866EC50", Offset = "0x866D850", VA = "0x18866EC50")]
	public static Task KNAKIDBGLNI(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct HHNFKAPDJEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BCEBMEBHAMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8661510", Offset = "0x8660110", VA = "0x188661510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8661A40", Offset = "0x8660640", VA = "0x188661A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x866A910", Offset = "0x8669510", VA = "0x18866A910")]
	[AsyncStateMachine(typeof(BCEBMEBHAMK))]
	public static Task KNAKIDBGLNI(BLJFMNNIGKD LDEHLLCJGOI, KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct ANKGOGLIECP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct GGJGPPDNILN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public JEJODNJGOPP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private KMLAPHJELJN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private AGABMHMNIPB <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private PCCOAGNMMJI <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private GFJANGGIPEI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private List<(PersistenceView, FJFJDBNHDLA)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private FJFJDBNHDLA <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x86689D0", Offset = "0x86675D0", VA = "0x1886689D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x86696A0", Offset = "0x86682A0", VA = "0x1886696A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x86603A0", Offset = "0x865EFA0", VA = "0x1886603A0")]
	[AsyncStateMachine(typeof(GGJGPPDNILN))]
	public static Task KNAKIDBGLNI(BLJFMNNIGKD LDEHLLCJGOI, KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x86601B0", Offset = "0x865EDB0", VA = "0x1886601B0")]
	private static void JPLILDJLEAN(PersistenceView HBPAMLAADAH, FJFJDBNHDLA DPGLACKNALH, KGGEOPPOKLC PEDMEJIDLNB, PCCOAGNMMJI EAENGAIGFCA, bool MJEOFBKKIDG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct HKJOAJNHBFN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct MJANBMJEMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public KMLAPHJELJN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private GFJANGGIPEI <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x866EE50", Offset = "0x866DA50", VA = "0x18866EE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x866F470", Offset = "0x866E070", VA = "0x18866F470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x866AF90", Offset = "0x8669B90", VA = "0x18866AF90")]
	[AsyncStateMachine(typeof(MJANBMJEMOM))]
	public static Task KNAKIDBGLNI(KMLAPHJELJN KFBBLAFGOAP, KGGEOPPOKLC PEDMEJIDLNB, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct ILOHIPDBLOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct OMIOBPEALKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public KMLAPHJELJN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x86722B0", Offset = "0x8670EB0", VA = "0x1886722B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x86724C0", Offset = "0x86710C0", VA = "0x1886724C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class MGGNNEMLBEK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public MGGNNEMLBEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x86765B0", Offset = "0x86751B0", VA = "0x1886765B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x8676940", Offset = "0x8675540", VA = "0x188676940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MGGNNEMLBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x866ED30", Offset = "0x866D930", VA = "0x18866ED30")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JBBBAJJJMAA(HMEJDNPIBLC<string>.FIEDNALJEDE timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct OIOLJJKPMLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public ILOHIPDBLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private GFJANGGIPEI <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x8671380", Offset = "0x866FF80", VA = "0x188671380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x8671F80", Offset = "0x8670B80", VA = "0x188671F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class JLMAGJPPPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public NMCPHPKNFMD version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JLMAGJPPPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x866D290", Offset = "0x866BE90", VA = "0x18866D290")]
		internal object PCHBNKOLAKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x866D1E0", Offset = "0x866BDE0", VA = "0x18866D1E0")]
		internal object DNDDDCHJAAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private KGGEOPPOKLC PEDMEJIDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private BLJFMNNIGKD LDEHLLCJGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private bool AIIHEKLNJJP;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static readonly ByteString EJANFKBMOHD;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x866C930", Offset = "0x866B530", VA = "0x18866C930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private BMKBDBHPIME KLGKPBCHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x866C890", Offset = "0x866B490", VA = "0x18866C890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x866C740", Offset = "0x866B340", VA = "0x18866C740")]
	[AsyncStateMachine(typeof(OMIOBPEALKP))]
	public static Task KNAKIDBGLNI(KMLAPHJELJN KFBBLAFGOAP, KGGEOPPOKLC PEDMEJIDLNB, BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB, bool AIIHEKLNJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x866C610", Offset = "0x866B210", VA = "0x18866C610")]
	[AsyncStateMachine(typeof(OIOLJJKPMLB))]
	private Task KNAKIDBGLNI(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x866C980", Offset = "0x866B580", VA = "0x18866C980")]
	private void NGIPLEBFKJK([NotNull] LCCGADBLEIF CMNJPDBBKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x866C5D0", Offset = "0x866B1D0", VA = "0x18866C5D0")]
	private bool AEDBCHPLJPB(NMCPHPKNFMD JBMEHOAGBAN, LCCGADBLEIF CMNJPDBBKKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct FFMGKIDDNLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct IGMGEAGIJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public AsyncTaskMethodBuilder<KGGEOPPOKLC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public FFMGKIDDNLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public ELMOKFLOKJN.PDPIOPNOHEG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private TaskAwaiter<IReadOnlyCollection<PFPKEOCLAOD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private TaskAwaiter<(MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>, MDDPJNIIBBI<KJANINJOKPF<LCCGADBLEIF>, OGEAAGEPEFJ>, MDDPJNIIBBI<KJANINJOKPF<HFMEMLNGCBK>, OGEAAGEPEFJ>, MDDPJNIIBBI<KJANINJOKPF<IEnumerable<OMCJMDHAAKM>>, OGEAAGEPEFJ>, MDDPJNIIBBI<KJANINJOKPF<GJJDHOBJLAA>, OGEAAGEPEFJ>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x866B780", Offset = "0x866A380", VA = "0x18866B780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x866C560", Offset = "0x866B160", VA = "0x18866C560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct CLFKPMJJLMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public FFMGKIDDNLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public IReadOnlyCollection<PFPKEOCLAOD> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public IReadOnlyCollection<PFPKEOCLAOD> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public ELMOKFLOKJN.PDPIOPNOHEG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8662650", Offset = "0x8661250", VA = "0x188662650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8662CB0", Offset = "0x86618B0", VA = "0x188662CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private PHNAFJFCOGJ<IDLFIGEMLKL, HFMEMLNGCBK> AFBCOJPBKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private PHNAFJFCOGJ<IDLFIGEMLKL, LCCGADBLEIF> ECPINFGMGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private PHNAFJFCOGJ<JJNCBFJEABI, IEnumerable<OMCJMDHAAKM>> HFEFGAPMNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private PHNAFJFCOGJ<long, GJJDHOBJLAA> CEBOJEDMOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private OKDOBPADKDO GDPHHIFGKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private KINJLHLHADG LLPPGIONGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private CGPLGKCGOLD DBAKHEJGKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private Guid? IJGNKDKNEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private IReadOnlyCollection<PFPKEOCLAOD> NDJHDIJIAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Task<IReadOnlyCollection<PFPKEOCLAOD>> PEMILOJKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IDLFIGEMLKL OLNOBDEBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private IDLFIGEMLKL MAKPBGFOOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private IDLFIGEMLKL? CGHHBEGGHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private JJNCBFJEABI LNMINIGNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8665FB0", Offset = "0x8664BB0", VA = "0x188665FB0")]
	public static Task<KGGEOPPOKLC> NPABILICFHD(KMLAPHJELJN KFBBLAFGOAP, [In] JBLHFNLKPCH PEDMEJIDLNB, ELMOKFLOKJN.PDPIOPNOHEG JMDKFJOMBGI, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x8665E00", Offset = "0x8664A00", VA = "0x188665E00")]
	[AsyncStateMachine(typeof(IGMGEAGIJPE))]
	private Task<KGGEOPPOKLC> KNAKIDBGLNI(ELMOKFLOKJN.PDPIOPNOHEG JMDKFJOMBGI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8665BD0", Offset = "0x86647D0", VA = "0x188665BD0")]
	[AsyncStateMachine(typeof(CLFKPMJJLMI))]
	private Task<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> KLAJICGNDHM(Guid? IJGNKDKNEFC, IReadOnlyCollection<PFPKEOCLAOD> NDJHDIJIAHD, IReadOnlyCollection<PFPKEOCLAOD> AMINNPODAKG, long? JKJNCHGDMGL, long? OKLPJIPAHKD, ELMOKFLOKJN.PDPIOPNOHEG JMDKFJOMBGI, HMEJDNPIBLC<string>.FIEDNALJEDE DJHPCIHNLLG, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct DCJJAJOAPPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct BNMMPDLEPPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public AsyncTaskMethodBuilder<JBLHFNLKPCH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public DCJJAJOAPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private TaskAwaiter<JBLHFNLKPCH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8661AA0", Offset = "0x86606A0", VA = "0x188661AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8661EF0", Offset = "0x8660AF0", VA = "0x188661EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct OPOFNHBGENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public AsyncTaskMethodBuilder<JBLHFNLKPCH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public DCJJAJOAPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private TaskAwaiter<JBLHFNLKPCH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8672520", Offset = "0x8671120", VA = "0x188672520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x86729A0", Offset = "0x86715A0", VA = "0x1886729A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class OMAKJKCAGGO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public OMAKJKCAGGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private TaskAwaiter<LNAIBELOABI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private TaskAwaiter<CLPJHDPKJPJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x86739F0", Offset = "0x86725F0", VA = "0x1886739F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x86743A0", Offset = "0x8672FA0", VA = "0x1886743A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public NNNADOAHABC roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public AGABMHMNIPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public IDLFIGEMLKL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public IDLFIGEMLKL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public IReadOnlyList<PFPKEOCLAOD> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public IReadOnlyList<PFPKEOCLAOD> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public KINJLHLHADG roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OMAKJKCAGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xF0C150", Offset = "0xF0AD50", VA = "0x180F0C150")]
		internal bool GFBPDINPFLL(CGPLGKCGOLD sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x86721E0", Offset = "0x8670DE0", VA = "0x1886721E0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task GDAHMGEMDBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x8671FE0", Offset = "0x8670BE0", VA = "0x188671FE0")]
		internal Task<JJNCBFJEABI> EHCOPFEPEIL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct BAKKFIPMGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<JBLHFNLKPCH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public NNNADOAHABC roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AGABMHMNIPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public IDLFIGEMLKL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private OMAKJKCAGGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private CGPLGKCGOLD <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private Task<JJNCBFJEABI> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter<KINJLHLHADG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<JJNCBFJEABI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x86604F0", Offset = "0x865F0F0", VA = "0x1886604F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x86614A0", Offset = "0x86600A0", VA = "0x1886614A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private FEKGMHDPDLC CBKOAFBLJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private NNNADOAHABC OHCMELMHOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private long JKJNCHGDMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private long KBGIBOKAOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long MEDPANLILPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private string OJPCFKOJIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private IDLFIGEMLKL KFGFDKKCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private Guid NBKKKJCMAEL;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x86631E0", Offset = "0x8661DE0", VA = "0x1886631E0")]
	public static Task<JBLHFNLKPCH> NPABILICFHD(KMLAPHJELJN KFBBLAFGOAP, FCFEBPBOLMP BJAGJMJPKHA, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x8663090", Offset = "0x8661C90", VA = "0x188663090")]
	[AsyncStateMachine(typeof(BNMMPDLEPPE))]
	private Task<JBLHFNLKPCH> KNAKIDBGLNI(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8662EF0", Offset = "0x8661AF0", VA = "0x188662EF0")]
	[AsyncStateMachine(typeof(OPOFNHBGENH))]
	private Task<JBLHFNLKPCH> EJFNCBBPEMI(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8662D20", Offset = "0x8661920", VA = "0x188662D20")]
	[AsyncStateMachine(typeof(BAKKFIPMGMG))]
	private static Task<JBLHFNLKPCH> EJFNCBBPEMI(AGABMHMNIPB ECPFHMDENEE, NNNADOAHABC OHCMELMHOMN, long JKJNCHGDMGL, long KBGIBOKAOOO, long MEDPANLILPF, string OJPCFKOJIED, IDLFIGEMLKL KFGFDKKCDNN, Guid NBKKKJCMAEL, CancellationToken DKKNFNCKCEB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8663060", Offset = "0x8661C60", VA = "0x188663060")]
	private void KBBMGHCHDFN(KINJLHLHADG LLPPGIONGOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct ECCKFEGINLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct OBENLKFJMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public ECCKFEGINLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8670AF0", Offset = "0x866F6F0", VA = "0x188670AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8671080", Offset = "0x866FC80", VA = "0x188671080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private KGGEOPPOKLC PEDMEJIDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private float FEGBKOCBICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private float BBFFFFBFAME;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x8664570", Offset = "0x8663170", VA = "0x188664570")]
	public static Task CIFDLAMJKOO(KMLAPHJELJN KFBBLAFGOAP, KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x86647D0", Offset = "0x86633D0", VA = "0x1886647D0")]
	[AsyncStateMachine(typeof(OBENLKFJMCB))]
	public Task KNAKIDBGLNI(CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8664A70", Offset = "0x8663670", VA = "0x188664A70")]
	private static void ODBMCLKAJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x86648F0", Offset = "0x86634F0", VA = "0x1886648F0")]
	private void LKAAKNOENKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8664710", Offset = "0x8663310", VA = "0x188664710")]
	private static float FDKPJOIFFFA(AGABMHMNIPB ECPFHMDENEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8664A50", Offset = "0x8663650", VA = "0x188664A50")]
	private static float MNMMIJDCDJE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct GDFKPHGAHJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct HACCGLFCJHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public BLJFMNNIGKD operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private ANOMBEDMGAC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private KMLAPHJELJN <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private PDKCHCFKJLG.ODMHHFKDOKP <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8669A30", Offset = "0x8668630", VA = "0x188669A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x866A220", Offset = "0x8668E20", VA = "0x18866A220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct IDNNCKGGFMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x866B0B0", Offset = "0x8669CB0", VA = "0x18866B0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x866B3E0", Offset = "0x8669FE0", VA = "0x18866B3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x8668760", Offset = "0x8667360", VA = "0x188668760")]
	[AsyncStateMachine(typeof(HACCGLFCJHJ))]
	public static Task KNAKIDBGLNI(BLJFMNNIGKD LDEHLLCJGOI, KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x8668960", Offset = "0x8667560", VA = "0x188668960")]
	private static Task<HNLLGFNPJEI> PINDBGHIEJH(BLJFMNNIGKD LDEHLLCJGOI, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x86688A0", Offset = "0x86674A0", VA = "0x1886688A0")]
	[AsyncStateMachine(typeof(IDNNCKGGFMK))]
	private static Task NFJDGMBMCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct FOEHBGPCPOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct FDJDCLOKGCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public FOEHBGPCPOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x86653E0", Offset = "0x8663FE0", VA = "0x1886653E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8665B70", Offset = "0x8664770", VA = "0x188665B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class LBOEOOCHHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LBOEOOCHHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x866E270", Offset = "0x866CE70", VA = "0x18866E270")]
		internal object OAKKLKBCGAP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct AEEKBNOFGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public FOEHBGPCPOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x865F2C0", Offset = "0x865DEC0", VA = "0x18865F2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x865F740", Offset = "0x865E340", VA = "0x18865F740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private bool AEFKOGJJPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private CancellationToken DKKNFNCKCEB;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x8666C00", Offset = "0x8665800", VA = "0x188666C00")]
	public static Task GCEKIANPFDE(KMLAPHJELJN KFBBLAFGOAP, bool AEFKOGJJPOJ, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken FAPJDOCGKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x8666DA0", Offset = "0x86659A0", VA = "0x188666DA0")]
	[AsyncStateMachine(typeof(FDJDCLOKGCH))]
	private Task KNAKIDBGLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8666C70", Offset = "0x8665870", VA = "0x188666C70")]
	[AsyncStateMachine(typeof(AEEKBNOFGOH))]
	private Task JJGBNNBPFPD(bool HIKMDDHLFEG, string EMOKKEEPOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	private bool EGKFJANJDEN(bool AEFKOGJJPOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct OIHHAIBFFNM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct HJHJBKMOGAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public OIHHAIBFFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x866AA50", Offset = "0x8669650", VA = "0x18866AA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x866AF20", Offset = "0x8669B20", VA = "0x18866AF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class KHDMBDJCLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KHDMBDJCLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x866E220", Offset = "0x866CE20", VA = "0x18866E220")]
		internal object OAKKLKBCGAP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct EKCOALOAJAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public OIHHAIBFFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x8664BA0", Offset = "0x86637A0", VA = "0x188664BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8665020", Offset = "0x8663C20", VA = "0x188665020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private FOIDGEPGBCO FDFMECADJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x86710E0", Offset = "0x866FCE0", VA = "0x1886710E0")]
	public static Task<Scene> CPIFDHELKPJ(KMLAPHJELJN KFBBLAFGOAP, FOIDGEPGBCO PLBCHEBMFMB, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x8671270", Offset = "0x866FE70", VA = "0x188671270")]
	[AsyncStateMachine(typeof(HJHJBKMOGAH))]
	private Task<Scene> KNAKIDBGLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8671130", Offset = "0x866FD30", VA = "0x188671130")]
	[AsyncStateMachine(typeof(EKCOALOAJAN))]
	private Task<Scene> JJGBNNBPFPD(string EMOKKEEPOCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct BMLAMDJIODD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct HCNBJIBPINC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public BMLAMDJIODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public PCCOAGNMMJI nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public KGGEOPPOKLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<PCCOAGNMMJI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x867D9B0", Offset = "0x867C5B0", VA = "0x18867D9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x867E480", Offset = "0x867D080", VA = "0x18867E480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct ALJBJHLNNPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public AsyncTaskMethodBuilder<PCCOAGNMMJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public BMLAMDJIODD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public PCCOAGNMMJI state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8677670", Offset = "0x8676270", VA = "0x188677670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8677950", Offset = "0x8676550", VA = "0x188677950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private readonly BLJFMNNIGKD LDEHLLCJGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly FEKGMHDPDLC CBKOAFBLJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly OLBJMBPEDLJ FMDANEPNELB;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private ANOMBEDMGAC BGAIKNCNNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6A86B50", Offset = "0x6A85750", VA = "0x186A86B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8678910", Offset = "0x8677510", VA = "0x188678910")]
	public BMLAMDJIODD(BLJFMNNIGKD LDEHLLCJGOI, FEKGMHDPDLC CBKOAFBLJNL, OLBJMBPEDLJ FMDANEPNELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x86785E0", Offset = "0x86771E0", VA = "0x1886785E0")]
	[AsyncStateMachine(typeof(HCNBJIBPINC))]
	public Task<PCCOAGNMMJI> BOABEBNDILL(PCCOAGNMMJI PGIKGOIFJGO, KGGEOPPOKLC DHIGGHNJJLN, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB, bool JCCGELPCOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8678780", Offset = "0x8677380", VA = "0x188678780")]
	[AsyncStateMachine(typeof(ALJBJHLNNPN))]
	private Task<PCCOAGNMMJI> LMBHINIFMEG(HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, PCCOAGNMMJI DKILGKEHOLM, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x86788E0", Offset = "0x86774E0", VA = "0x1886788E0")]
	private bool PBAFFIHHDCH(PCCOAGNMMJI IKOHAJPMIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8678760", Offset = "0x8677360", VA = "0x188678760")]
	private void HOEGMFFOKBK(string LLCGHFNIHNO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct BBPCFEMHNDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct OCOGEBNIJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public ANOMBEDMGAC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public JEJODNJGOPP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private GFJANGGIPEI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private List<(PersistenceView, FJFJDBNHDLA)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private (PersistenceView, FJFJDBNHDLA) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8687F50", Offset = "0x8686B50", VA = "0x188687F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8688610", Offset = "0x8687210", VA = "0x188688610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x8678090", Offset = "0x8676C90", VA = "0x188678090")]
	[AsyncStateMachine(typeof(OCOGEBNIJKH))]
	public static Task KNAKIDBGLNI(ANOMBEDMGAC JLJMNCGIOCA, KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct GFNNDLHIHFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct KHIMEJMNMAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public ANOMBEDMGAC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public JEJODNJGOPP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private NMCPHPKNFMD <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private GFJANGGIPEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private List<(PersistenceView, FJFJDBNHDLA)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private FJFJDBNHDLA <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8682390", Offset = "0x8680F90", VA = "0x188682390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8682C70", Offset = "0x8681870", VA = "0x188682C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x867C4F0", Offset = "0x867B0F0", VA = "0x18867C4F0")]
	[AsyncStateMachine(typeof(KHIMEJMNMAP))]
	public static Task KNAKIDBGLNI(ANOMBEDMGAC JLJMNCGIOCA, KGGEOPPOKLC PEDMEJIDLNB, JEJODNJGOPP IIKGDLJOCEI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public struct LPMELPBMIKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct JMFOFKHIHAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public LPMELPBMIKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public ELMOKFLOKJN.PDPIOPNOHEG preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private TaskAwaiter<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x867FDB0", Offset = "0x867E9B0", VA = "0x18867FDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8680430", Offset = "0x867F030", VA = "0x188680430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private long AGCGBEEDBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private long GEIPCIEKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private Guid? BBBHLPGLJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private IReadOnlyCollection<PFPKEOCLAOD> LICFHPGFEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private IReadOnlyCollection<PFPKEOCLAOD> EJJNMNNNDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private OKDOBPADKDO NIIKNOHLAJK;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x8686DC0", Offset = "0x86859C0", VA = "0x188686DC0")]
	public static Task<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> NPABILICFHD(long JKJNCHGDMGL, long KBGIBOKAOOO, CLPJHDPKJPJ OJEOKBJAEJH, ELMOKFLOKJN.PDPIOPNOHEG AEKBJJEPFOM, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x8686C60", Offset = "0x8685860", VA = "0x188686C60")]
	[AsyncStateMachine(typeof(JMFOFKHIHAN))]
	private Task<MDDPJNIIBBI<BJFELDOCEDH, OGEAAGEPEFJ>> KNAKIDBGLNI(ELMOKFLOKJN.PDPIOPNOHEG AEKBJJEPFOM, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct PDKCHCFKJLG
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public struct ODMHHFKDOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public List<GKFEOENJADM> AJCBIAHACNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public List<FJFJDBNHDLA> APJFKEPMDNI;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		public ODMHHFKDOKP(List<GKFEOENJADM> AJCBIAHACNH, List<FJFJDBNHDLA> APJFKEPMDNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class ODJCDKJIBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public IEnumerable<GKFEOENJADM> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ODJCDKJIBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x8688670", Offset = "0x8687270", VA = "0x188688670")]
		internal object NBDNKGKDBKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private KMLAPHJELJN KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private KGGEOPPOKLC PEDMEJIDLNB;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private AGABMHMNIPB KMBDPOFMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x868A640", Offset = "0x8689240", VA = "0x18868A640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x868A390", Offset = "0x8688F90", VA = "0x18868A390")]
	public static ODMHHFKDOKP KNAKIDBGLNI(KMLAPHJELJN KFBBLAFGOAP, KGGEOPPOKLC PEDMEJIDLNB)
	{
		return default(ODMHHFKDOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x868A3F0", Offset = "0x8688FF0", VA = "0x18868A3F0")]
	private ODMHHFKDOKP KNAKIDBGLNI()
	{
		return default(ODMHHFKDOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x8689DF0", Offset = "0x86889F0", VA = "0x188689DF0")]
	private ODMHHFKDOKP JMMODENJIKP(LCCGADBLEIF CMNJPDBBKKH, NMCPHPKNFMD MHJAOKAOKEC)
	{
		return default(ODMHHFKDOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8689C20", Offset = "0x8688820", VA = "0x188689C20")]
	private bool EGCOGIEFPAJ(IEnumerable<GKFEOENJADM> AJCBIAHACNH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct AGGCCMJBJHI
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class NFFGFBIHNGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public PDKCHCFKJLG.ODMHHFKDOKP instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public NFFGFBIHNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x86878A0", Offset = "0x86864A0", VA = "0x1886878A0")]
		internal object JBBBAJJJMAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class GIJABLHODPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GIJABLHODPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x867C920", Offset = "0x867B520", VA = "0x18867C920")]
		internal object GLLOEJICHJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x8676EF0", Offset = "0x8675AF0", VA = "0x188676EF0")]
	public static void KNAKIDBGLNI(ANOMBEDMGAC JLJMNCGIOCA, KGGEOPPOKLC PEDMEJIDLNB, PDKCHCFKJLG.ODMHHFKDOKP DDFMNHKAENL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal class OLBJMBPEDLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct MFFIFLDBCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public PCCOAGNMMJI operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public KGGEOPPOKLC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8686FA0", Offset = "0x8685BA0", VA = "0x188686FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8687710", Offset = "0x8686310", VA = "0x188687710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class EILDBEAKHDK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public EILDBEAKHDK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x868BF90", Offset = "0x868AB90", VA = "0x18868BF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x868C250", Offset = "0x868AE50", VA = "0x18868C250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EILDBEAKHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x867A3F0", Offset = "0x8678FF0", VA = "0x18867A3F0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KOKCAAGGMLM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct HFNLJNNEBOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private EILDBEAKHDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x867E4F0", Offset = "0x867D0F0", VA = "0x18867E4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x867EA20", Offset = "0x867D620", VA = "0x18867EA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct LFECBAPAPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private Dictionary<Guid, List<DPNJMGHIIBJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8684730", Offset = "0x8683330", VA = "0x188684730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8684D40", Offset = "0x8683940", VA = "0x188684D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct KKCCGOBCNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private Dictionary<Guid, List<DPNJMGHIIBJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8682CD0", Offset = "0x86818D0", VA = "0x188682CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8683370", Offset = "0x8681F70", VA = "0x188683370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class HHABDKFFJHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public DPNJMGHIIBJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public HHABDKFFJHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			private GFJANGGIPEI <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x868BAD0", Offset = "0x868A6D0", VA = "0x18868BAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x868BF30", Offset = "0x868AB30", VA = "0x18868BF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public KFHGIJHGELC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public List<DPNJMGHIIBJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HHABDKFFJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x867EA80", Offset = "0x867D680", VA = "0x18867EA80")]
		internal object DDMHIIBLIFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x867EC60", Offset = "0x867D860", VA = "0x18867EC60")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task HLEHGEJNMBB(DPNJMGHIIBJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x867EB70", Offset = "0x867D770", VA = "0x18867EB70")]
		internal object GMJPPOFNNNI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct LGJLIJNNPFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public KFHGIJHGELC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public List<DPNJMGHIIBJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private HHABDKFFJHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x86852C0", Offset = "0x8683EC0", VA = "0x1886852C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8685790", Offset = "0x8684390", VA = "0x188685790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct OFHNOLEFAFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x86886F0", Offset = "0x86872F0", VA = "0x1886886F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8688CB0", Offset = "0x86878B0", VA = "0x188688CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class LOEHEAKDNHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LOEHEAKDNHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8686BF0", Offset = "0x86857F0", VA = "0x188686BF0")]
		internal object MCJINGDBHBK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct LFPOADPCLNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public KGGEOPPOKLC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8684DA0", Offset = "0x86839A0", VA = "0x188684DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8685260", Offset = "0x8683E60", VA = "0x188685260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class BJKHJLNGJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BJKHJLNGJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8678570", Offset = "0x8677170", VA = "0x188678570")]
		internal object MBCHDDKHMAL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct JGNOKLIAGNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public OLBJMBPEDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private GFJANGGIPEI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x867F260", Offset = "0x867DE60", VA = "0x18867F260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x867F890", Offset = "0x867E490", VA = "0x18867F890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class DLJKFOOFGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DLJKFOOFGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8679ED0", Offset = "0x8678AD0", VA = "0x188679ED0")]
		internal object EANBKJPAKIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private readonly BLJFMNNIGKD LDEHLLCJGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private GDPBGADNPEN FMDANEPNELB;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private ANOMBEDMGAC BGAIKNCNNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x116B720", Offset = "0x116A320", VA = "0x18116B720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public OLBJMBPEDLJ(BLJFMNNIGKD LDEHLLCJGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x86895C0", Offset = "0x86881C0", VA = "0x1886895C0")]
	[AsyncStateMachine(typeof(MFFIFLDBCJL))]
	public Task KNAKIDBGLNI(PCCOAGNMMJI EAENGAIGFCA, KGGEOPPOKLC DHIGGHNJJLN, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x8689710", Offset = "0x8688310", VA = "0x188689710")]
	[AsyncStateMachine(typeof(HFNLJNNEBOD))]
	private Task MDPMNOPFDIK(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8689AE0", Offset = "0x86886E0", VA = "0x188689AE0")]
	[AsyncStateMachine(typeof(LFECBAPAPBD))]
	private Task NNIHGEOGAGL(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x86899A0", Offset = "0x86885A0", VA = "0x1886899A0")]
	[AsyncStateMachine(typeof(KKCCGOBCNBF))]
	private Task MKNKCABEKIA(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8689850", Offset = "0x8688450", VA = "0x188689850")]
	[AsyncStateMachine(typeof(LGJLIJNNPFL))]
	private Task MIGFOJCAPEC(Guid GECKAAFDHFM, List<DPNJMGHIIBJ> KKDCPNDDFEA, KFHGIJHGELC LJOECJCOPGO, KGGEOPPOKLC PEDMEJIDLNB, CancellationToken HEDGIMBCGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8689480", Offset = "0x8688080", VA = "0x188689480")]
	[AsyncStateMachine(typeof(OFHNOLEFAFO))]
	private Task IMODPJBGEEM(KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8688D10", Offset = "0x8687910", VA = "0x188688D10")]
	[AsyncStateMachine(typeof(LFPOADPCLNL))]
	private Task ACMDJAODMCF(Guid NJGNAJCMAEE, KGGEOPPOKLC PEDMEJIDLNB, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8689130", Offset = "0x8687D30", VA = "0x188689130")]
	[AsyncStateMachine(typeof(JGNOKLIAGNF))]
	private Task DLJOKCONCFB(Guid NJGNAJCMAEE, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x8689020", Offset = "0x8687C20", VA = "0x188689020")]
	private void DAIAEPMIELI(Guid NJGNAJCMAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x8689270", Offset = "0x8687E70", VA = "0x188689270")]
	private void FFMHCFHLFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x8689320", Offset = "0x8687F20", VA = "0x188689320")]
	public Guid IMDMDGPHBOL(PCCOAGNMMJI LCGIJMEHLHH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8688E50", Offset = "0x8687A50", VA = "0x188688E50")]
	[CompilerGenerated]
	private object CLPBOEGDAKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal struct CHDFGJCOFOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct FJCCJCILOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public CHDFGJCOFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private IEnumerator<HLIEMBHHJCP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x867BDF0", Offset = "0x867A9F0", VA = "0x18867BDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x867C490", Offset = "0x867B090", VA = "0x18867C490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	private AGABMHMNIPB ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	private HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private CancellationToken DKKNFNCKCEB;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x8678970", Offset = "0x8677570", VA = "0x188678970")]
	public static Task ACNHEKNGKHF(AGABMHMNIPB ECPFHMDENEE, HMEJDNPIBLC<string>.FIEDNALJEDE KDCDPEHJICI, CancellationToken FAPJDOCGKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x86789E0", Offset = "0x86775E0", VA = "0x1886789E0")]
	[AsyncStateMachine(typeof(FJCCJCILOLG))]
	private Task KNAKIDBGLNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct LJJJPAOGPFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	public readonly bool NDHBKCJKOCD;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C480", Offset = "0x2B6B080", VA = "0x182B6C480")]
	public LJJJPAOGPFE(bool KFHCEBMMDBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct JOPODIFOAJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	public readonly LCCGADBLEIF? BHLKJEIIHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly FNCPAHEOJIK MLJCMIBFNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly Guid? KPPDJDHAMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly IReadOnlyList<Guid> DHCNPMELHJL;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> DHCKJEHGJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8681790", Offset = "0x8680390", VA = "0x188681790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> NCGHCCGHGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x86817B0", Offset = "0x86803B0", VA = "0x1886817B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x86817D0", Offset = "0x86803D0", VA = "0x1886817D0")]
	public JOPODIFOAJI(LCCGADBLEIF? DEELHKGGHPE, FNCPAHEOJIK HEJCLAAMAPL, Guid? IJGNKDKNEFC, [Optional] IReadOnlyList<Guid>? IABEFLJFOHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class EOENFKNOMNE : MJCLDGCAOMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct LENLMOCNDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public AsyncTaskMethodBuilder<JOPODIFOAJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public EOENFKNOMNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public KBMPPKJOJGB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public KHDDPNLIHJD roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private GFJANGGIPEI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8684020", Offset = "0x8682C20", VA = "0x188684020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x86846C0", Offset = "0x86832C0", VA = "0x1886846C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class LNJJMHNJFKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LNJJMHNJFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8686B80", Offset = "0x8685780", VA = "0x188686B80")]
		internal object NODECCDCBHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct PKLDIJLCGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public EOENFKNOMNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public KBMPPKJOJGB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private LNJJMHNJFKI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private GFJANGGIPEI <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private JAGGGNKIKJG<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x868AFB0", Offset = "0x8689BB0", VA = "0x18868AFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x868BA70", Offset = "0x868A670", VA = "0x18868BA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400075E")]
	private static readonly TimeSpan OHIJNHCJJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly OLJOICOINLE EAEIHMKLGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private readonly BCOBJAGCKOK EIHGLPCIJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly PPJIHPDIFOG EMIONFINPKK;

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x867B9D0", Offset = "0x867A5D0", VA = "0x18867B9D0")]
	public EOENFKNOMNE(BLJFMNNIGKD LDEHLLCJGOI, OLJOICOINLE EAEIHMKLGOH, BCOBJAGCKOK HJFAMMEIODK, PPJIHPDIFOG EMIONFINPKK, JPIBGNDAFKP FAOMHPPHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x867A820", Offset = "0x8679420", VA = "0x18867A820")]
	[AsyncStateMachine(typeof(LENLMOCNDCK))]
	public Task<JOPODIFOAJI> BLPDEIDOFHH(long KBGIBOKAOOO, KHDDPNLIHJD JNKALBEBJLP, KBMPPKJOJGB MOJBDDDBJGK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x867B820", Offset = "0x867A420", VA = "0x18867B820")]
	[AsyncStateMachine(typeof(PKLDIJLCGHN))]
	private Task LPJAIKPJFAN(KBMPPKJOJGB MOJBDDDBJGK, PersistenceView[] MLIDDGBCEKA, StringBuilder MMPLDHGOINJ, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x867AFC0", Offset = "0x8679BC0", VA = "0x18867AFC0")]
	private JOPODIFOAJI HMFLCEPPMJG(long KBGIBOKAOOO, KHDDPNLIHJD JNKALBEBJLP, KBMPPKJOJGB MOJBDDDBJGK, IEnumerable<PersistenceView> MLIDDGBCEKA, StringBuilder MMPLDHGOINJ)
	{
		return default(JOPODIFOAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x867A970", Offset = "0x8679570", VA = "0x18867A970")]
	private LCCGADBLEIF HEIPCIODPKA(long KBGIBOKAOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x867B5D0", Offset = "0x867A1D0", VA = "0x18867B5D0")]
	private void KKCHMNDOHNN(LCCGADBLEIF GEDEAHKPPED, StringBuilder MMPLDHGOINJ, IEnumerable<PersistenceView> MLIDDGBCEKA, [In] LBLADGEIGNI DOMGPJHJIEF, PKMLKIDDIJE LLMBEGBONAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x867AB30", Offset = "0x8679730", VA = "0x18867AB30")]
	private void HFCONLLOINH(LCCGADBLEIF GEDEAHKPPED, StringBuilder MMPLDHGOINJ, PersistenceView HBPAMLAADAH, PKMLKIDDIJE LLMBEGBONAG, [In] LBLADGEIGNI DOMGPJHJIEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class HBEEBMIEANC : MJCLDGCAOMF
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class JFMKBBJEHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public CMFJEOGICBC.JDDEGHHPKHM roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JFMKBBJEHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x867F210", Offset = "0x867DE10", VA = "0x18867F210")]
		internal object HECFBADNIKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct LLFOCAIIMKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public AsyncTaskMethodBuilder<(CMFJEOGICBC.JDDEGHHPKHM roomDataUpload, CMFJEOGICBC.JDDEGHHPKHM subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public JOPODIFOAJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AGABMHMNIPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private JFMKBBJEHOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private TaskAwaiter<CMFJEOGICBC.JDDEGHHPKHM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x8686290", Offset = "0x8684E90", VA = "0x188686290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x8686B10", Offset = "0x8685710", VA = "0x188686B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct HPAMDHGPHMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public AsyncTaskMethodBuilder<NHMGHNEDIJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public HBEEBMIEANC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public BIBLILLBLLL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public JOPODIFOAJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		private TaskAwaiter<NHMGHNEDIJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x867ED60", Offset = "0x867D960", VA = "0x18867ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x867F000", Offset = "0x867DC00", VA = "0x18867F000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct AODHMHOEPIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public AsyncTaskMethodBuilder<NHMGHNEDIJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public AGABMHMNIPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public JOPODIFOAJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public HOHOJDIJGOC ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public BIBLILLBLLL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private TaskAwaiter<(CMFJEOGICBC.JDDEGHHPKHM roomDataUpload, CMFJEOGICBC.JDDEGHHPKHM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private TaskAwaiter<NHMGHNEDIJJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x86779C0", Offset = "0x86765C0", VA = "0x1886779C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8678020", Offset = "0x8676C20", VA = "0x188678020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct DEOAGFGCGGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public AsyncTaskMethodBuilder<LNAIBELOABI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public HBEEBMIEANC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public JOPODIFOAJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private TaskAwaiter<(CMFJEOGICBC.JDDEGHHPKHM roomDataUpload, CMFJEOGICBC.JDDEGHHPKHM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private TaskAwaiter<LNAIBELOABI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x86799B0", Offset = "0x86785B0", VA = "0x1886799B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8679E60", Offset = "0x8678A60", VA = "0x188679E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class MNMJFLPCFJK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public MNMJFLPCFJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private HNLLGFNPJEI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private TaskAwaiter<LNAIBELOABI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<NHMGHNEDIJJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<HNLLGFNPJEI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x868C2B0", Offset = "0x868AEB0", VA = "0x18868C2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x868D4B0", Offset = "0x868C0B0", VA = "0x18868D4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public HBEEBMIEANC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public JOPODIFOAJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public BIBLILLBLLL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public LJJJPAOGPFE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MNMJFLPCFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8687770", Offset = "0x8686370", VA = "0x188687770")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<HNLLGFNPJEI> FFFHMPOPJCO(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct BFLADDPAIBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public AsyncTaskMethodBuilder<HNLLGFNPJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public HBEEBMIEANC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public JOPODIFOAJI roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public BIBLILLBLLL roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public LJJJPAOGPFE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		private TaskAwaiter<HNLLGFNPJEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x86781D0", Offset = "0x8676DD0", VA = "0x1886781D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8678500", Offset = "0x8677100", VA = "0x188678500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077B")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400077C")]
	private static readonly JPIBGNDAFKP OBKGIOBEOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private readonly IHDJLNKPAOG FHHCOBJFLBJ;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private KMLAPHJELJN OACFHNOPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x865A090", Offset = "0x8658C90", VA = "0x18865A090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x867D510", Offset = "0x867C110", VA = "0x18867D510")]
	public HBEEBMIEANC(BLJFMNNIGKD LDEHLLCJGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x867D330", Offset = "0x867BF30", VA = "0x18867D330")]
	[AsyncStateMachine(typeof(LLFOCAIIMKN))]
	private static Task<(CMFJEOGICBC.JDDEGHHPKHM, CMFJEOGICBC.JDDEGHHPKHM)> PNNFCNDDHND(AGABMHMNIPB ECPFHMDENEE, JOPODIFOAJI ACMODBIBOMH, long JKJNCHGDMGL, long OKLPJIPAHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x867CCE0", Offset = "0x867B8E0", VA = "0x18867CCE0")]
	[AsyncStateMachine(typeof(HPAMDHGPHMJ))]
	public Task<NHMGHNEDIJJ> HNMLGLGMFMD(int IDJFHNCGAIP, [CanBeNull] BIBLILLBLLL HFJBDNPALNN, JOPODIFOAJI ACMODBIBOMH, long JKJNCHGDMGL, long OKLPJIPAHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x867CE50", Offset = "0x867BA50", VA = "0x18867CE50")]
	public static Task<NHMGHNEDIJJ> HNMLGLGMFMD(AGABMHMNIPB ECPFHMDENEE, int IDJFHNCGAIP, [CanBeNull] BIBLILLBLLL HFJBDNPALNN, JOPODIFOAJI ACMODBIBOMH, long JKJNCHGDMGL, long OKLPJIPAHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x867D1A0", Offset = "0x867BDA0", VA = "0x18867D1A0")]
	[AsyncStateMachine(typeof(AODHMHOEPIF))]
	public static Task<NHMGHNEDIJJ> HNMLGLGMFMD(AGABMHMNIPB ECPFHMDENEE, int IDJFHNCGAIP, [CanBeNull] BIBLILLBLLL HFJBDNPALNN, JOPODIFOAJI ACMODBIBOMH, long JKJNCHGDMGL, long OKLPJIPAHKD, HOHOJDIJGOC LONMOMMFMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x867C9B0", Offset = "0x867B5B0", VA = "0x18867C9B0")]
	[AsyncStateMachine(typeof(DEOAGFGCGGI))]
	private Task<LNAIBELOABI> GNCBKJFDBAN(string OJPCFKOJIED, int IDJFHNCGAIP, JOPODIFOAJI ACMODBIBOMH, long JKJNCHGDMGL, long OKLPJIPAHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x867CB30", Offset = "0x867B730", VA = "0x18867CB30")]
	[AsyncStateMachine(typeof(BFLADDPAIBG))]
	public Task<HNLLGFNPJEI> HNFFIANMEFP(int IDJFHNCGAIP, BIBLILLBLLL? HFJBDNPALNN, JOPODIFOAJI ACMODBIBOMH, long JKJNCHGDMGL, long OKLPJIPAHKD, LJJJPAOGPFE OCNPFNCOBDN, HMEJDNPIBLC<string>.FIEDNALJEDE FAFAKHMLIIK, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public abstract class LBHNBFHLIMG<T> where T : LBHNBFHLIMG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C3")]
	internal readonly KMLAPHJELJN PCDEBBGPKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private int? EHDADNKLPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	protected readonly Guid GHDCEEHHGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	protected readonly NIDIOBFKMIA LJACJFDKMKE;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T LHLBIPMNKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x527DC00", Offset = "0x527C800", VA = "0x18527DC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x527DF70", Offset = "0x527CB70", VA = "0x18527DF70")]
	internal LBHNBFHLIMG(KMLAPHJELJN IADODCFKBAJ, NIDIOBFKMIA HMBJHAPMDJC, [Optional] Guid? DIPCJMNHKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x527DE00", Offset = "0x527CA00", VA = "0x18527DE00")]
	private HNLLGFNPJEI LPGGOBLGHPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	protected virtual void ELKODOKHGCD(HNLLGFNPJEI FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x527DEE0", Offset = "0x527CAE0", VA = "0x18527DEE0")]
	public T MKONGFEDMBO(BJCCECIKIFB DMMFONEMJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x527DC60", Offset = "0x527C860", VA = "0x18527DC60")]
	public T EDDJANANMDJ(int KDGJCNFFGNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x527DCF0", Offset = "0x527C8F0", VA = "0x18527DCF0", Slot = "5")]
	public virtual Task<PEJIBHJPOLO> ILIEAAHCDID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class JFGKLKMBFAO : LBHNBFHLIMG<JFGKLKMBFAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	private FCFEBPBOLMP ADKJHPADFOA;

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x867F140", Offset = "0x867DD40", VA = "0x18867F140")]
	internal JFGKLKMBFAO(KMLAPHJELJN IADODCFKBAJ, NIDIOBFKMIA HMBJHAPMDJC, [Optional] Guid? DIPCJMNHKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x7869970", Offset = "0x7868570", VA = "0x187869970")]
	public JFGKLKMBFAO MNFBIFBBDAF(FCFEBPBOLMP ADKJHPADFOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x867F070", Offset = "0x867DC70", VA = "0x18867F070", Slot = "4")]
	protected override void ELKODOKHGCD(HNLLGFNPJEI FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class DNPPCFHAAPG : LBHNBFHLIMG<DNPPCFHAAPG>
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	internal enum NHMCECIANCE
	{
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	private struct PJKGKGLEABJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public AsyncTaskMethodBuilder<PEJIBHJPOLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public DNPPCFHAAPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private TaskAwaiter<PEJIBHJPOLO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x868ABA0", Offset = "0x86897A0", VA = "0x18868ABA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x868AF40", Offset = "0x8689B40", VA = "0x18868AF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private NHMCECIANCE KFLIHFCPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private string INOAFEJILNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private BIBLILLBLLL ADKJHPADFOA;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x867A280", Offset = "0x8678E80", VA = "0x18867A280")]
	internal DNPPCFHAAPG(KMLAPHJELJN IADODCFKBAJ, NIDIOBFKMIA HMBJHAPMDJC, [Optional] Guid? DIPCJMNHKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x867A250", Offset = "0x8678E50", VA = "0x18867A250")]
	public DNPPCFHAAPG OOOEGBAMMNF(string NFKNKHBBLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x867A210", Offset = "0x8678E10", VA = "0x18867A210")]
	public DNPPCFHAAPG MMKFLBEBHAE(bool FKGDKCLMOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x867A230", Offset = "0x8678E30", VA = "0x18867A230")]
	public DNPPCFHAAPG OFAPDEILOCJ(bool CDGJAAAJMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8679F40", Offset = "0x8678B40", VA = "0x188679F40")]
	public DNPPCFHAAPG DBKKEIAGIEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x8679FB0", Offset = "0x8678BB0", VA = "0x188679FB0", Slot = "4")]
	protected override void ELKODOKHGCD(HNLLGFNPJEI FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x867A120", Offset = "0x8678D20", VA = "0x18867A120", Slot = "5")]
	[AsyncStateMachine(typeof(PJKGKGLEABJ))]
	public override Task<PEJIBHJPOLO> ILIEAAHCDID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8679F70", Offset = "0x8678B70", VA = "0x188679F70")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<PEJIBHJPOLO> DOGCFLINKOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal static class AHGMHNMFIDD
{
	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x86774A0", Offset = "0x86760A0", VA = "0x1886774A0")]
	public static void FEGKOMADGOL(this DJLJJDANPIF DKIKGKNHJFL, FJAIPDANBOO MGDFACLDPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x86775F0", Offset = "0x86761F0", VA = "0x1886775F0")]
	public static void LFBNIEBIBKN(this FJAIPDANBOO APNOPAAOBED, [Optional] string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class LJLAOMAKMFL
{
	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x86861F0", Offset = "0x8684DF0", VA = "0x1886861F0")]
	public static IDLFIGEMLKL CIFENGBOHPG(this GPHBINDLDMK OGLNCLKDFPC)
	{
		return default(IDLFIGEMLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8686140", Offset = "0x8684D40", VA = "0x188686140")]
	public static GPHBINDLDMK BCJIDCCLCEI(this IDLFIGEMLKL JBPJANAMJEO)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public LEBMHJAHDBC ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public LEBMHJAHDBC HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private static LEBMHJAHDBC[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private Dictionary<LEBMHJAHDBC, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x868DBB0", Offset = "0x868C7B0", VA = "0x18868DBB0")]
		public bool LMKKLIFHLOB(LEBMHJAHDBC PCNCNFFOFEH, [Out] ResultConfig JLMFPIBLIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x868DA70", Offset = "0x868C670", VA = "0x18868DA70")]
		public ResultConfig FAOIDLCLFCI(LEBMHJAHDBC HGJBCNEJGLD, [Optional] HashSet<LEBMHJAHDBC> KPPOGCFCANE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x868E1C0", Offset = "0x868CDC0", VA = "0x18868E1C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x868DC20", Offset = "0x868C820", VA = "0x18868DC20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public class EKBMIIFAANG : KMAOLHPGECA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct GHPBKACMFOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public EKBMIIFAANG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x867C630", Offset = "0x867B230", VA = "0x18867C630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x867C8C0", Offset = "0x867B4C0", VA = "0x18867C8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct PDOBMGEKBAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public HMEJDNPIBLC<string>.FIEDNALJEDE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public KMAOLHPGECA preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private HMEJDNPIBLC<string>.FIEDNALJEDE <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x868A690", Offset = "0x8689290", VA = "0x18868A690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x868AB40", Offset = "0x8689740", VA = "0x18868AB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private readonly LFBKIBCMOLO EJMFJLCJNIE;

	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string NEOPJJDHHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x867A4E0", Offset = "0x86790E0", VA = "0x18867A4E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x867A510", Offset = "0x8679110", VA = "0x18867A510")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void FPIMJJMHECA(PFGPAPHADOM AKKHFHFGLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EKBMIIFAANG([GFNPNOLPMKK(null)] LFBKIBCMOLO EJMFJLCJNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x867A580", Offset = "0x8679180", VA = "0x18867A580", Slot = "5")]
	[AsyncStateMachine(typeof(GHPBKACMFOB))]
	public Task KNAKIDBGLNI(HMEJDNPIBLC<string>.FIEDNALJEDE MIBJENJEJGJ, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x867A690", Offset = "0x8679290", VA = "0x18867A690")]
	[AsyncStateMachine(typeof(PDOBMGEKBAB))]
	private Task MGIEMIJCOEA(KMAOLHPGECA OJPDDNHKNLA, HMEJDNPIBLC<string>.FIEDNALJEDE MIBJENJEJGJ, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface LFBKIBCMOLO : KMAOLHPGECA
{
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface KMAOLHPGECA
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string NEOPJJDHHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KNAKIDBGLNI(HMEJDNPIBLC<string>.FIEDNALJEDE MIBJENJEJGJ, CancellationToken DKKNFNCKCEB);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public static class HCHGMHAJCOF
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x867D5A0", Offset = "0x867C1A0", VA = "0x18867D5A0")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	internal static void BACILHPJJBN(PFGPAPHADOM AKKHFHFGLBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public interface KJNCMPAKDDO : IEquatable<KJNCMPAKDDO>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime DCLEJFJNIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELFCNPHMHCO();

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CENDCOJMCOD(long JKJNCHGDMGL, long KBGIBOKAOOO, [Out] JOPODIFOAJI ACMODBIBOMH);
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal class CLJCEBNCALH : HILDNEGHJLL
{
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class LIIFLDCANON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		public IGBBMPDAJMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LIIFLDCANON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x86860D0", Offset = "0x8684CD0", VA = "0x1886860D0")]
		internal object ECBEKNEPNGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F1")]
	private readonly ILDNJPIANLF BECIGFDKGJN;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<KJNCMPAKDDO> OEOOKBLGPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8679900", Offset = "0x8678500", VA = "0x188679900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x8679260", Offset = "0x8677E60", VA = "0x188679260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	[UnityEngine.Scripting.Preserve]
	public CLJCEBNCALH([GFNPNOLPMKK(null)] ILDNJPIANLF BECIGFDKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x8678DF0", Offset = "0x86779F0", VA = "0x188678DF0", Slot = "6")]
	public bool BEGFHJBAHDP(long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH, IGBBMPDAJMA PCAOHCHCKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0xE5C6C0", Offset = "0xE5B2C0", VA = "0x180E5C6C0")]
	private void BMPLNJAAKFP(KJNCMPAKDDO KNOPMIEECBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x86790F0", Offset = "0x8677CF0", VA = "0x1886790F0", Slot = "7")]
	public bool DKLMNFMLGEI(long JKJNCHGDMGL, long KBGIBOKAOOO, [Out] KJNCMPAKDDO NCDCKNMIKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8679730", Offset = "0x8678330", VA = "0x188679730", Slot = "8")]
	public bool NAMLKIGJOGO(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, [Out] KJNCMPAKDDO NCDCKNMIKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x8679310", Offset = "0x8677F10", VA = "0x188679310")]
	private void MPHDEADBKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x86797E0", Offset = "0x86783E0", VA = "0x1886797E0", Slot = "9")]
	public void NBHENLMIPDK(long JKJNCHGDMGL, long KBGIBOKAOOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal abstract class JPHMGDPCGOD : ILDNJPIANLF
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	protected enum FICEOPCNOCD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class FHKOAKBLPIO : IEnumerable<KJNCMPAKDDO>, IEnumerable, IEnumerator<KJNCMPAKDDO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private KJNCMPAKDDO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		public JPHMGDPCGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private IGBBMPDAJMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public IGBBMPDAJMA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private KJNCMPAKDDO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public FHKOAKBLPIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x867BAC0", Offset = "0x867A6C0", VA = "0x18867BAC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x867BDA0", Offset = "0x867A9A0", VA = "0x18867BDA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x867BCF0", Offset = "0x867A8F0", VA = "0x18867BCF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KJNCMPAKDDO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x867BCF0", Offset = "0x867A8F0", VA = "0x18867BCF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class ABNPKEOPCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		public IGBBMPDAJMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ABNPKEOPCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8676E50", Offset = "0x8675A50", VA = "0x188676E50")]
		internal object EDILMKFGGNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class FBNOHPFJKPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public JPHMGDPCGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FBNOHPFJKPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x867BA40", Offset = "0x867A640", VA = "0x18867BA40")]
		internal void HOILGKPIPMJ(OHJOHMMDCBL.OCGIPCNDBOG ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	private readonly object HJNKDIDIIMF;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string FBBEOHHFLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x8681C90", Offset = "0x8680890", VA = "0x188681C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract LEIOBKOCMDD INFOCFMMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x8682310", Offset = "0x8680F10", VA = "0x188682310")]
	protected JPHMGDPCGOD([CanBeNull] string JCEOADPDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x8681CA0", Offset = "0x86808A0", VA = "0x188681CA0", Slot = "5")]
	public bool KPKFMKDMPOA(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, [Out] KJNCMPAKDDO KNOPMIEECBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x8682210", Offset = "0x8680E10", VA = "0x188682210", Slot = "6")]
	[IteratorStateMachine(typeof(FHKOAKBLPIO))]
	public IEnumerable<KJNCMPAKDDO> LJNABGDOMOC(IGBBMPDAJMA PCAOHCHCKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void PPKPHDEHJBB(Stream GFPPBILOIAE, long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LFLMECDBAEO(Stream EBHGDCGEGBK, long JKJNCHGDMGL, long KBGIBOKAOOO, CFAMNIMAKLE MIKDDPMDKDN, [Out] JOPODIFOAJI ACMODBIBOMH);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8681E90", Offset = "0x8680A90", VA = "0x188681E90", Slot = "7")]
	public KJNCMPAKDDO LGDPIOAPPFA(long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH, IGBBMPDAJMA PCAOHCHCKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo EHDOJAHMKCM(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, FICEOPCNOCD HBAPIEGFIAJ);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ONNBBGFHFML(IGBBMPDAJMA PCAOHCHCKBL, FICEOPCNOCD HBAPIEGFIAJ);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x86822A0", Offset = "0x8680EA0", VA = "0x1886822A0")]
	protected void NHAAGIJBDND(OHJOHMMDCBL.OCGIPCNDBOG AMLACAHEBFL, string LLCGHFNIHNO, FileInfo OKNOKJMCICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x86818D0", Offset = "0x86804D0", VA = "0x1886818D0")]
	internal bool BGNCPJCEAOI(FileInfo PFEGAILCEFI, long JKJNCHGDMGL, long KBGIBOKAOOO, [Out] JOPODIFOAJI ACMODBIBOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private void PKPDDKCBANH(Exception OBGCCKHNEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class KOEJODMJBFM : JPHMGDPCGOD
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override LEIOBKOCMDD INFOCFMMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x139CD10", Offset = "0x139B910", VA = "0x18139CD10", Slot = "8")]
		get
		{
			return default(LEIOBKOCMDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8683FE0", Offset = "0x8682BE0", VA = "0x188683FE0")]
	public KOEJODMJBFM([Optional] string JCEOADPDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x86833D0", Offset = "0x8681FD0", VA = "0x1886833D0")]
	private void CLJJGCGFOJF(IGBBMPDAJMA PCAOHCHCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8683D30", Offset = "0x8682930", VA = "0x188683D30", Slot = "9")]
	internal override void PPKPHDEHJBB(Stream GFPPBILOIAE, long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8683540", Offset = "0x8682140", VA = "0x188683540", Slot = "10")]
	internal override bool LFLMECDBAEO(Stream EBHGDCGEGBK, long JKJNCHGDMGL, long KBGIBOKAOOO, CFAMNIMAKLE MIKDDPMDKDN, [Out] JOPODIFOAJI ACMODBIBOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8683450", Offset = "0x8682050", VA = "0x188683450", Slot = "11")]
	protected override FileInfo EHDOJAHMKCM(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, FICEOPCNOCD HBAPIEGFIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8683C30", Offset = "0x8682830", VA = "0x188683C30", Slot = "12")]
	protected override DirectoryInfo ONNBBGFHFML(IGBBMPDAJMA PCAOHCHCKBL, FICEOPCNOCD HBAPIEGFIAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal sealed class JNLIGEKDELG : JPHMGDPCGOD
{
	[Cpp2IlInjected.Token(Token = "0x4000807")]
	private static readonly byte[] MEPFFFGIFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000808")]
	private readonly byte[] AKAGPELLIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private readonly byte[] CLAFDGNOCLA;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override LEIOBKOCMDD INFOCFMMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1939990", Offset = "0x1938590", VA = "0x181939990", Slot = "8")]
		get
		{
			return default(LEIOBKOCMDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x86816A0", Offset = "0x86802A0", VA = "0x1886816A0")]
	public JNLIGEKDELG([Optional] string JCEOADPDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8681200", Offset = "0x867FE00", VA = "0x188681200", Slot = "9")]
	internal override void PPKPHDEHJBB(Stream GFPPBILOIAE, long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x8680690", Offset = "0x867F290", VA = "0x188680690", Slot = "10")]
	internal override bool LFLMECDBAEO(Stream EBHGDCGEGBK, long JKJNCHGDMGL, long KBGIBOKAOOO, CFAMNIMAKLE MIKDDPMDKDN, [Out] JOPODIFOAJI ACMODBIBOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x86804A0", Offset = "0x867F0A0", VA = "0x1886804A0")]
	private void CGCIMFIPDJM(byte[] OEOOBGJGDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8680560", Offset = "0x867F160", VA = "0x188680560", Slot = "11")]
	protected override FileInfo EHDOJAHMKCM(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, FICEOPCNOCD HBAPIEGFIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x86810F0", Offset = "0x867FCF0", VA = "0x1886810F0", Slot = "12")]
	protected override DirectoryInfo ONNBBGFHFML(IGBBMPDAJMA PCAOHCHCKBL, FICEOPCNOCD HBAPIEGFIAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
public enum LEIOBKOCMDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400080E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal class LHEGGHAEFIN : ILDNJPIANLF
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	private sealed class JJBIPCNBGOL : IEnumerable<KJNCMPAKDDO>, IEnumerable, IEnumerator<KJNCMPAKDDO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private KJNCMPAKDDO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		public LHEGGHAEFIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IGBBMPDAJMA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public IGBBMPDAJMA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private LEIOBKOCMDD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private IEnumerator<KJNCMPAKDDO> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private KJNCMPAKDDO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public JJBIPCNBGOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x867FD20", Offset = "0x867E920", VA = "0x18867FD20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x867F940", Offset = "0x867E540", VA = "0x18867F940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x867F8F0", Offset = "0x867E4F0", VA = "0x18867F8F0")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x867FCD0", Offset = "0x867E8D0", VA = "0x18867FCD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x867FC20", Offset = "0x867E820", VA = "0x18867FC20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KJNCMPAKDDO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x867FC20", Offset = "0x867E820", VA = "0x18867FC20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	private readonly LEIOBKOCMDD[] FNEKDKIGBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private readonly Dictionary<LEIOBKOCMDD, ILDNJPIANLF> PPAHLPBGJAJ;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public LEIOBKOCMDD INFOCFMMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x86857F0", Offset = "0x86843F0", VA = "0x1886857F0", Slot = "4")]
		get
		{
			return default(LEIOBKOCMDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x8685DA0", Offset = "0x86849A0", VA = "0x188685DA0")]
	[UnityEngine.Scripting.Preserve]
	public LHEGGHAEFIN(params ILDNJPIANLF[] ODCIHKBCHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x8685820", Offset = "0x8684420", VA = "0x188685820", Slot = "5")]
	public bool KPKFMKDMPOA(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, [Out] KJNCMPAKDDO KNOPMIEECBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x8685B60", Offset = "0x8684760", VA = "0x188685B60")]
	private void PMAOECJOCFD(int LILNHMALAOA, long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8685AD0", Offset = "0x86846D0", VA = "0x188685AD0", Slot = "6")]
	[IteratorStateMachine(typeof(JJBIPCNBGOL))]
	public IEnumerable<KJNCMPAKDDO> LJNABGDOMOC(IGBBMPDAJMA PCAOHCHCKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8685970", Offset = "0x8684570", VA = "0x188685970", Slot = "7")]
	public KJNCMPAKDDO LGDPIOAPPFA(long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH, IGBBMPDAJMA PCAOHCHCKBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal static class CJONELOGIFA
{
	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x8678B50", Offset = "0x8677750", VA = "0x188678B50")]
	internal static byte[] FJOGJFINGGE(byte[] OEOOBGJGDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x8678AD0", Offset = "0x86776D0", VA = "0x188678AD0")]
	public static void DGLINKJMAAG(Stream EHEOFFBMPJP, byte[] AFMBPGOACIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x8678C10", Offset = "0x8677810", VA = "0x188678C10")]
	public static bool KOMAKGJMKJF(Stream EHEOFFBMPJP, long PJCGLLNDMIC, CFAMNIMAKLE ODGLLMADECG, [Out] byte[] GJIEAOEKMOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal sealed class OADINEIMFMD : KJNCMPAKDDO, IEquatable<KJNCMPAKDDO>, IEquatable<OADINEIMFMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400081F")]
	private readonly JPHMGDPCGOD IDLEEMKOMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000820")]
	public readonly FileInfo NBOOALDEAGB;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public LEIOBKOCMDD INFOCFMMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x7F192B0", Offset = "0x7F17EB0", VA = "0x187F192B0", Slot = "9")]
		get
		{
			return default(LEIOBKOCMDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime DCLEJFJNIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8687D00", Offset = "0x8686900", VA = "0x188687D00", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8687E40", Offset = "0x8686A40", VA = "0x188687E40")]
	public OADINEIMFMD(JPHMGDPCGOD PLLMNECHKFM, FileInfo PFEGAILCEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x8687D90", Offset = "0x8686990", VA = "0x188687D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x8687990", Offset = "0x8686590", VA = "0x188687990", Slot = "5")]
	public void ELFCNPHMHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8687950", Offset = "0x8686550", VA = "0x188687950", Slot = "6")]
	public bool CENDCOJMCOD(long JKJNCHGDMGL, long KBGIBOKAOOO, [Out] JOPODIFOAJI ACMODBIBOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8687B40", Offset = "0x8686740", VA = "0x188687B40", Slot = "7")]
	public bool Equals(KJNCMPAKDDO GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8687BB0", Offset = "0x86867B0", VA = "0x188687BB0", Slot = "8")]
	public bool Equals(OADINEIMFMD GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8687A50", Offset = "0x8686650", VA = "0x188687A50", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8687C70", Offset = "0x8686870", VA = "0x188687C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
public delegate void CFAMNIMAKLE(OHJOHMMDCBL.OCGIPCNDBOG KDNGIEBGHMK, string FNFIPKNHEOF);
[Cpp2IlInjected.Token(Token = "0x20001D3")]
internal interface ILDNJPIANLF
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	LEIOBKOCMDD INFOCFMMGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPKFMKDMPOA(long JKJNCHGDMGL, long KBGIBOKAOOO, IGBBMPDAJMA PCAOHCHCKBL, [Out] KJNCMPAKDDO KNOPMIEECBG);

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KJNCMPAKDDO> LJNABGDOMOC(IGBBMPDAJMA PCAOHCHCKBL);

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KJNCMPAKDDO LGDPIOAPPFA(long JKJNCHGDMGL, long KBGIBOKAOOO, JOPODIFOAJI ACMODBIBOMH, IGBBMPDAJMA PCAOHCHCKBL);
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
