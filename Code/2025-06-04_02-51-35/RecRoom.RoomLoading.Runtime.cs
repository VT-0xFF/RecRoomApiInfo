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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DF460", Offset = "0x87DDC60", VA = "0x1887DF460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class FNAKEBMBAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<AKNNNGCPBLB> FCPGLFMGHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task LDBKFOJCKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal FDNEDNLHGAA PJKHOHNNPMO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FNAKEBMBAOD()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87D37F0", Offset = "0x87D1FF0", VA = "0x1887D37F0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87E3A60", Offset = "0x87E2260", VA = "0x1887E3A60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IGPLBDCDFAE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x87CCAE0", Offset = "0x87CB2E0", VA = "0x1887CCAE0")]
	public IGPLBDCDFAE(string ILBALOOKKCP, Exception GJEDNEMABLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class OAEEDNFPDLG : EELFGFHCNJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CHPLBDGCKOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<NJEJHBFOBPK>> <>t__builder;

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
		private TaskAwaiter<EEMONLPAJBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87C54F0", Offset = "0x87C3CF0", VA = "0x1887C54F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87C5730", Offset = "0x87C3F30", VA = "0x1887C5730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct HBPHHJFHJDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KDEGGCDDKFJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<KDEGGCDDKFJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87CA1C0", Offset = "0x87C89C0", VA = "0x1887CA1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87CA3D0", Offset = "0x87C8BD0", VA = "0x1887CA3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	[UnityEngine.Scripting.Preserve]
	public OAEEDNFPDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x87DF4E0", Offset = "0x87DDCE0", VA = "0x1887DF4E0", Slot = "4")]
	[AsyncStateMachine(typeof(CHPLBDGCKOH))]
	public Task<IReadOnlyList<NJEJHBFOBPK>> GFEEHHBOFNL(long GFHIJAKOMMI, long JPKIDMNFGFI, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x87DF600", Offset = "0x87DDE00", VA = "0x1887DF600", Slot = "5")]
	[AsyncStateMachine(typeof(HBPHHJFHJDI))]
	public Task<IReadOnlyList<KDEGGCDDKFJ>> HJAPBGOFODH(IReadOnlyList<int> DNIMFDGNNPF, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KECFOBHCPFI : IEquatable<KECFOBHCPFI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NJBAEHJNKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	KDEGGCDDKFJ DDIJHBNEAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime MDLDFCLEAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BLIFBLCKHPP? DKHNFLBICFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BCIIKMHHACJ? MKNLEIDAMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	CAILODBIHHM DLNPDNEOOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AKIGBGIOJEO> OGLDNMNCLKN();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CAILODBIHHM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EELFGFHCNJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<NJEJHBFOBPK>> GFEEHHBOFNL(long GFHIJAKOMMI, long JPKIDMNFGFI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<KDEGGCDDKFJ>> HJAPBGOFODH(IReadOnlyList<int> DNIMFDGNNPF, [Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LBMLKKLEOGK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class AFCJPBINLEJ : KECFOBHCPFI, IEquatable<KECFOBHCPFI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct IIGLHPHDFCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public AFCJPBINLEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private CKBNJKGCBIE <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<APAMIKOGBPP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<AKIGBGIOJEO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x87CCB50", Offset = "0x87CB350", VA = "0x1887CCB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x87CD0D0", Offset = "0x87CB8D0", VA = "0x1887CD0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NJEJHBFOBPK GBPICMIDGAN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NJBAEHJNKIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KDEGGCDDKFJ DDIJHBNEAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AIEOKAEBLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x87C33C0", Offset = "0x87C1BC0", VA = "0x1887C33C0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BLIFBLCKHPP? DKHNFLBICFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6390", Offset = "0x2AF4B90", VA = "0x182AF6390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BCIIKMHHACJ? MKNLEIDAMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x87C35D0", Offset = "0x87C1DD0", VA = "0x1887C35D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CAILODBIHHM DLNPDNEOOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA76E00", Offset = "0xA75600", VA = "0x180A76E00", Slot = "10")]
			get
			{
				return default(CAILODBIHHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87C35F0", Offset = "0x87C1DF0", VA = "0x1887C35F0", Slot = "9")]
		[AsyncStateMachine(typeof(IIGLHPHDFCP))]
		public Task<AKIGBGIOJEO> OGLDNMNCLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87C36F0", Offset = "0x87C1EF0", VA = "0x1887C36F0")]
		public AFCJPBINLEJ(int DLEGJIELHIP, KDEGGCDDKFJ MNAICEJCLMN, NJEJHBFOBPK GBPICMIDGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87C3480", Offset = "0x87C1C80", VA = "0x1887C3480", Slot = "11")]
		public bool Equals(KECFOBHCPFI KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87C33E0", Offset = "0x87C1BE0", VA = "0x1887C33E0", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87C3590", Offset = "0x87C1D90", VA = "0x1887C3590")]
		private bool JJBFLHIKHKG(AFCJPBINLEJ KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87C3510", Offset = "0x87C1D10", VA = "0x1887C3510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class JIEIHPOIBCG : KECFOBHCPFI, IEquatable<KECFOBHCPFI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct OGKBMOKCPOF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public JIEIHPOIBCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<AKIGBGIOJEO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x87DF710", Offset = "0x87DDF10", VA = "0x1887DF710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x87DF960", Offset = "0x87DE160", VA = "0x1887DF960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly PMABMGLDFHF DCECLOLOKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BLIFBLCKHPP HOMBGBNHOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly BCIIKMHHACJ MIGHECLOAGG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NJBAEHJNKIM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x87CEA50", Offset = "0x87CD250", VA = "0x1887CEA50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KDEGGCDDKFJ DDIJHBNEAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x87CEE50", Offset = "0x87CD650", VA = "0x1887CEE50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AIEOKAEBLMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x87CEA00", Offset = "0x87CD200", VA = "0x1887CEA00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BLIFBLCKHPP? DKHNFLBICFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x87CEBE0", Offset = "0x87CD3E0", VA = "0x1887CEBE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BCIIKMHHACJ? MKNLEIDAMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x87CED10", Offset = "0x87CD510", VA = "0x1887CED10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CAILODBIHHM DLNPDNEOOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC5FA30", Offset = "0xC5E230", VA = "0x180C5FA30", Slot = "10")]
			get
			{
				return default(CAILODBIHHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B950", Offset = "0x1F5A150", VA = "0x181F5B950")]
		public JIEIHPOIBCG(PMABMGLDFHF LPLDGBKEJIB, BLIFBLCKHPP FNKKGCGJHHL, BCIIKMHHACJ DFCPGPDBOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x87CED60", Offset = "0x87CD560", VA = "0x1887CED60", Slot = "9")]
		[AsyncStateMachine(typeof(OGKBMOKCPOF))]
		public Task<AKIGBGIOJEO> OGLDNMNCLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87CEB40", Offset = "0x87CD340", VA = "0x1887CEB40", Slot = "11")]
		public bool Equals(KECFOBHCPFI KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87CEA90", Offset = "0x87CD290", VA = "0x1887CEA90", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87CECB0", Offset = "0x87CD4B0", VA = "0x1887CECB0")]
		private bool JJBFLHIKHKG(JIEIHPOIBCG KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87CEC30", Offset = "0x87CD430", VA = "0x1887CEC30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class DCJDFHAMGDH : KECFOBHCPFI, IEquatable<KECFOBHCPFI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct EHPNHJJMFNK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<AKIGBGIOJEO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x87C8830", Offset = "0x87C7030", VA = "0x1887C8830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x87C8A90", Offset = "0x87C7290", VA = "0x1887C8A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly KDEGGCDDKFJ GEJKGLGJPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BLIFBLCKHPP HOMBGBNHOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly BCIIKMHHACJ MIGHECLOAGG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NJBAEHJNKIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x87C5C70", Offset = "0x87C4470", VA = "0x1887C5C70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public KDEGGCDDKFJ DDIJHBNEAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AIEOKAEBLMN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BLIFBLCKHPP? DKHNFLBICFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x87C5D80", Offset = "0x87C4580", VA = "0x1887C5D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BCIIKMHHACJ? MKNLEIDAMHL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x87C5F40", Offset = "0x87C4740", VA = "0x1887C5F40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public CAILODBIHHM DLNPDNEOOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "10")]
			get
			{
				return default(CAILODBIHHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B950", Offset = "0x1F5A150", VA = "0x181F5B950")]
		public DCJDFHAMGDH(KDEGGCDDKFJ MNAICEJCLMN, BLIFBLCKHPP FNKKGCGJHHL, BCIIKMHHACJ DFCPGPDBOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F90", Offset = "0x87C4790", VA = "0x1887C5F90", Slot = "9")]
		[AsyncStateMachine(typeof(EHPNHJJMFNK))]
		public Task<AKIGBGIOJEO> OGLDNMNCLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x87C5C90", Offset = "0x87C4490", VA = "0x1887C5C90", Slot = "11")]
		public bool Equals(KECFOBHCPFI KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D00", Offset = "0x87C4500", VA = "0x1887C5D00", Slot = "0")]
		public override bool Equals(object HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87C5DD0", Offset = "0x87C45D0", VA = "0x1887C5DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x87C5E60", Offset = "0x87C4660", VA = "0x1887C5E60")]
		private bool JJBFLHIKHKG(DCJDFHAMGDH KEKEFPAJGHD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FBFFALNADAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<KECFOBHCPFI>> <>t__builder;

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
		public LBMLKKLEOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<NJEJHBFOBPK> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<NJEJHBFOBPK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, KDEGGCDDKFJ account, NJEJHBFOBPK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x87C8B00", Offset = "0x87C7300", VA = "0x1887C8B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87C9930", Offset = "0x87C8130", VA = "0x1887C9930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NGKECOLKKAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, KDEGGCDDKFJ account, NJEJHBFOBPK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<NJEJHBFOBPK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LBMLKKLEOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<KDEGGCDDKFJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x87DDD60", Offset = "0x87DC560", VA = "0x1887DDD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87DE720", Offset = "0x87DCF20", VA = "0x1887DE720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KABJJPFJCMP LPPPJLJPIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EELFGFHCNJJ FCDEKOKLAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OMKFNAOGINO CMCFFAJLKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EHFEBOBIOIL<(long, long), IReadOnlyList<NJEJHBFOBPK>> MLMAHAPCFGL;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87D1450", Offset = "0x87CFC50", VA = "0x1887D1450")]
	[UnityEngine.Scripting.Preserve]
	public LBMLKKLEOGK([FAPODKMFODF(null)] EELFGFHCNJJ FCJFICFCLEG, [FAPODKMFODF(null)] OMKFNAOGINO IOCEOECNELP, [FAPODKMFODF(null)] KABJJPFJCMP MBLBANPOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87D1160", Offset = "0x87CF960", VA = "0x1887D1160")]
	[AsyncStateMachine(typeof(FBFFALNADAE))]
	public Task<IList<KECFOBHCPFI>> MECKHFJFHCH(long GFHIJAKOMMI, long PALELGDJJCI, bool PPPJGHLCEPK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87D12B0", Offset = "0x87CFAB0", VA = "0x1887D12B0")]
	private bool MIKGBCLIDLJ(DateTime? OFIENBCBGEA, long GFHIJAKOMMI, long PALELGDJJCI, [Out] PMABMGLDFHF KOKHFAJAONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x87D1050", Offset = "0x87CF850", VA = "0x1887D1050")]
	[AsyncStateMachine(typeof(NGKECOLKKAJ))]
	private Task<IReadOnlyList<(int, KDEGGCDDKFJ, NJEJHBFOBPK)>> KMGIAKDKLAE(IReadOnlyList<NJEJHBFOBPK> NCJHGMGGBEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OMKFNAOGINO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PMABMGLDFHF> NBONJFDLIME;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GECMPAGOGON(long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI, DKLOHHBNKIG LNIKDKIPDBJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KONKHEDJLFL(long GFHIJAKOMMI, long PALELGDJJCI, [Out] PMABMGLDFHF KOKHFAJAONA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NLPDCIDKHPN(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, [Out] PMABMGLDFHF KOKHFAJAONA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENFLPBLDMDB(long GFHIJAKOMMI, long PALELGDJJCI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface HJABLGDBPEI : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool COPBHEPHDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task AMGEFOLPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIANFFDEPHL(Task FEGBHCAEMDO, string PGIIDGECMIF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface PHKHLEMNFND : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AKIGBGIOJEO> KIHKCADGJON(PMABMGLDFHF KOKHFAJAONA);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HOCHKPKNBGI(CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface HNENONAPKCB : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AODBFAEMBPL KAEICOOFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCECLHOGKFP();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKEGBHBFNDB();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface GDBDNONDKIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface GLCPPLLGKIP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan IHBGCJJBBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan NKCHIHAOFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan CLFOEAJFFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan AAPJILBPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KNPPBBIDADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BBLGDOHIANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MGPCOPFJHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MHKEMKJNNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KGODCPGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FOGMEFFBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool CCMDHCJDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DELOLEHNHNM
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GJHCICIAKDP
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
public struct FPBLLGEBKEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long HKCIIPDKLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long JPKIDMNFGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly DELOLEHNHNM CEPGAJKBPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception HMJNKPJPGCJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x87C9BF0", Offset = "0x87C83F0", VA = "0x1887C9BF0")]
	public FPBLLGEBKEJ(long HKCIIPDKLEO, long JPKIDMNFGFI, DELOLEHNHNM CEPGAJKBPDM, [CanBeNull] Exception HMJNKPJPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x87C9BA0", Offset = "0x87C83A0", VA = "0x1887C9BA0")]
	public static FPBLLGEBKEJ COODOOJDJHL(LOAOCAFLNEN KKIPIIBBCLM, DELOLEHNHNM CEPGAJKBPDM, [Optional] Exception HMJNKPJPGCJ)
	{
		return default(FPBLLGEBKEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void CJKBCPOKPFH(FPBLLGEBKEJ MMOLNADADKP);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface OKPHNFNFFAF : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CJKBCPOKPFH OMMMHINAHDM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CJKBCPOKPFH HCJJIEJDEOP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CJKBCPOKPFH OPKJAKJGFAD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<GJHCICIAKDP, bool> IBFNHGMJMHK;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LODICHGODFP(FPBLLGEBKEJ MMOLNADADKP);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GFLCONPOGPK(FPBLLGEBKEJ MMOLNADADKP);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNOPFEENBEG(FPBLLGEBKEJ MMOLNADADKP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BGJLKLGFPJN(GJHCICIAKDP GOAEPFPLNNI, bool PEFHAHJOKNH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface EEFLELAHAOG : GDBDNONDKIG, IDisposable, KBPDCLGJICP
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HGMANLGCMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIMJKJPCCCL();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface FIJGONFDHGJ : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus BDMKABPIJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJDEKMFFBEN(LOAOCAFLNEN DJHGIPODCBJ, GCGPBOIBBAJ CFGIFCEABDC, CancellationToken DGACCOBPOIM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class JMKNHHKKAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x87CF290", Offset = "0x87CDA90", VA = "0x1887CF290")]
	public static bool IPAIDFHNGPD(this FIJGONFDHGJ FAGEDOEFKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task KCPCPABECLA(CancellationToken KAJENDFCCBJ, int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OFIJFBKPKIO : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILNBMIDDDGE(KCPCPABECLA LNPPBGGLCBB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GBCNJFGJIEN : CKBNJKGCBIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken GPNEFPMPKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	OIKNHNBNAFI MMOKDOMNOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KIFHCLNMNON GJDHJHDLOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	ILBAAIEHPBH BOCCLNAJFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NHINCABDBDO NDEFNCFAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HJEBBLBMFCN LBIHJKAJNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JJCPPGOLFEC PIIMDLALELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PPOCKLEIMOO APENNJDGKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HJABLGDBPEI LPMPIGDBHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PHKHLEMNFND MIDMLEHBJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OKPHNFNFFAF HMOOOMALDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EEFLELAHAOG FFHHNNKFGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	FIJGONFDHGJ JMJHIAPLPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OFIJFBKPKIO KEJBHHCBKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BGBOIJEKNFM HHOCLAEFKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HIGLOPGDPKP CJFNFPPKNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GAPJBOEFBCP FFBCAAMDMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KFDFEJKCABK HIJHBJHOCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JKMJAAFFHDI HKDMDINPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AFAONOHCBBF IKAFJMGGBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PGFIKCCMAPF EMIODLJCACK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OGLGLBIBLMO IEPJFAELMID
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DKHPINBEEOE HADIMPOLHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BOLJILCGMIK BOHCEOIHDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HNENONAPKCB KOPGEDAMCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GLCPPLLGKIP OKMIOCDLGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HMKJDDPKDJE PMDPPEOLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OMKFNAOGINO EOGFOMCLGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	IEEECBLGMDK HNGNNGEDHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	FILOJONJOBN POLLDBDNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	BKBJCAOLAHJ NLEEGCNKENA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	LNINKDJALGH NOKHBLLDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool LPNJPKBHKBI
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
	void NDFKBKDIIOP(GCGPBOIBBAJ ADJPBNCNMFP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BGBOIJEKNFM : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILMPMHDEJBN GGGBGBDKNKJ(Guid GKMDGNFGEOO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKOLMKDGPPH(Guid GKMDGNFGEOO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AGALPFAJDLK(Guid GKMDGNFGEOO, Task EAPFHGLEBFL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool POPLIBLMCBL(Guid GKMDGNFGEOO, AKIGBGIOJEO DCAKPGBGEGO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(AKIGBGIOJEO, Task)> JIPOKIMICKM(Guid GKMDGNFGEOO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface GLELJGKEICK : GDBDNONDKIG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface HIGLOPGDPKP : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPBLACLKILL(EMOHKBNEAPF ILBALOOKKCP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPOOBHBJAPL(EMOHKBNEAPF ILBALOOKKCP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<PKPMCPGHFJB> IGBCOLAOIJJ(CancellationToken BGFNBALAHON);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GAPJBOEFBCP : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILMPMHDEJBN FAICOLHJKEI(EMOHKBNEAPF GMJGODCJAPB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KACALEANOAH(Guid GKMDGNFGEOO, Task EAPFHGLEBFL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface KFDFEJKCABK : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AKIGBGIOJEO> HIJHBJHOCAN(EMOHKBNEAPF JPBGANLJNBP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JKMJAAFFHDI : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FNDPEECNEPD> MBLPMJEFPNE(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, LOAOCAFLNEN DJHGIPODCBJ, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface PGFIKCCMAPF : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKIGBGIOJEO GPKIBGOACAC(EIGONBNGIIK MDCMCPMGEHH);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ACBHHMNJACG(string KBIHAKCHLAI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface AFAONOHCBBF : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EMOHKBNEAPF> DMGHIKFOFCN(EMOHKBNEAPF FLPDPHNPDPK, BEBFLBECFCJ JMEJMAOHCJF, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EMOHKBNEAPF> PNBJOFMNKOM(CancellationToken GMEAHOBHMAD, BEBFLBECFCJ JMEJMAOHCJF);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PFGLBMLEAGJ HOCOPJEJJFC(FBBNOBMBACD HBIBIPNFAIK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFGLBMLEAGJ CJLDGGMJMGA(FBBNOBMBACD HBIBIPNFAIK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface OGLGLBIBLMO : GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKIGBGIOJEO FCGNKJPCFGL(EIGONBNGIIK MDCMCPMGEHH, PKPMCPGHFJB HFFJJCGAECD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKIGBGIOJEO NDJIGIBMBHA(EIGONBNGIIK NGHKAKJAOHD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface OPOPFKFGIIF
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int CNOKOJDDNOA = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, KILGKAOCDAI> ELJIJKEEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action OEFDHHHLKKP
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
	IReadOnlyList<Guid> OINFGMNPELO();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MGEJDPPKEDC([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FDLDIGGPJKE([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DKHPINBEEOE
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNKGPAPEKEI(ONMBGPCKGJP GOKPMOEMAIM);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCCHFMELMLO(ONMBGPCKGJP GOKPMOEMAIM);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOEOEKJKOIP(ONMBGPCKGJP GOKPMOEMAIM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHKEFJDONAP(ONMBGPCKGJP GOKPMOEMAIM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ONMBGPCKGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LOAOCAFLNEN PLMLLKPIPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> KGDLGGPCNBL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DKKFAAJNJJM<string> CGNNIMABNJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public ONMBGPCKGJP(LOAOCAFLNEN NLKCLNKGHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x87DFA60", Offset = "0x87DE260", VA = "0x1887DFA60")]
	public ONMBGPCKGJP NEIJJHAPCFH(string MNMCNOJCKAF, string MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x87DF9D0", Offset = "0x87DE1D0", VA = "0x1887DF9D0")]
	public bool ECNILCJIKPM([Out] IEnumerable<KeyValuePair<string, string>> LPNBIKPOJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7651DC0", Offset = "0x76505C0", VA = "0x187651DC0")]
	public ONMBGPCKGJP IMJCBLONGFJ(DKKFAAJNJJM<string> PFLKFIDCFJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HMKJDDPKDJE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OPADAPJLFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string PCLHNIMFODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GHJIHOFLECG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANBEOHBOBBC();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GCEGIJANLLG ENEIKAOOMHB(long HHKAEIEEJAI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CMMOHICJPAP<DOPHJNOBIJD, LPIFEJNCBGG> NBNPKHLKLLP(long HHKAEIEEJAI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CMMOHICJPAP<DOPHJNOBIJD, PCENONMPPIA> CBHOONDOEMN(long HHKAEIEEJAI);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CMMOHICJPAP<long, IIIOFLMBLND> NHPNHEGKGML();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<NKFFLFJJKEG>> IEIPNBCHLPH(long HHKAEIEEJAI, IReadOnlyCollection<NKFFLFJJKEG> GGAFAGHJKAF, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ECEEBPLNHJM(long HHKAEIEEJAI, [Out] bool OGBBBPFAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> MFLHPFBEDOC(byte[] NNOJLKJDGHO, byte[] AJDCEEKKJIC, IReadOnlyCollection<Guid> JHHKJMFGPBK, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HJKJLEGOOPN
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNDPEECNEPD INHDMBAMCNE(long HKCIIPDKLEO, long JPKIDMNFGFI, string IDCDGEEOELI);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNDPEECNEPD INHDMBAMCNE(long HKCIIPDKLEO, long JPKIDMNFGFI, DOPHJNOBIJD NNOJLKJDGHO, Guid? OLOGBCPAJIO, long LOHFPFAAEFB, bool EEEIDBPPENK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNDPEECNEPD INHDMBAMCNE(IPCPPGKOOOH NKGOHABEIIJ);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNDPEECNEPD INHDMBAMCNE(APAMIKOGBPP CGIBKHMADLE, NJEJHBFOBPK ACDAHANDEAB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CKBNJKGCBIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IPAIDFHNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool MEKBEHOPAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LPNJPKBHKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	HJKJLEGOOPN AIHHOKFOPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GCGPBOIBBAJ PGMLKCKIJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event CJKBCPOKPFH OMMMHINAHDM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event CJKBCPOKPFH HCJJIEJDEOP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CJKBCPOKPFH OPKJAKJGFAD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<GJHCICIAKDP, bool> IBFNHGMJMHK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HIMJKJPCCCL();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BINJDAAAAED HOANKNMCONH();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NONBIIEEFGF BJIHGNNHPAL();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task PFAAMKKOKPL(int JPILDFAPLHD, LGOJJLPEJAM DKGHDKKALOF, Func<DEGIKKCKCON, DEGIKKCKCON> POONKIBDCLI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<AKIGBGIOJEO> KIHKCADGJON(PMABMGLDFHF LPLDGBKEJIB);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task HOCHKPKNBGI(CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface NHINCABDBDO
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool PCNCCKCAOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HPMOKJCMJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? JGBJFHNKKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPNJKJBOAGK(Scene JAFANOHFAFK);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IDCKHNEHOOC(KKEKPLKDMHL NHGLIAMFNKD, IReadOnlyList<KKEKPLKDMHL> LPDCMCDACJA, IReadOnlyList<KKEKPLKDMHL> MADEMILOAHH, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDPMGMGMMIE(Guid DPCIEGDDHDL, IReadOnlyList<Guid> JHHKJMFGPBK, FGIGJBEFPBC ANGJEFLAONO, [Optional] object BDEPNCKLDNO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ADNNKKIPEED(IReadOnlyList<Guid> MDMFKGDDMIF, CancellationToken FPGKJOAHOBN);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OFMHNCMFBIG LHAHBIDKACJ();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task CECBBJHNOFH();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PAEIDNEPNAM(GameObject LEHCGNOJDEA);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task JHEDHIHIIOE();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LCLCIAOJCLH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NBGNCEJLICK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool GKMJCJJKKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool CDJBFGFKAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool DIFNPKAAACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int BIMMCCEHKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool ONAKMGNIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool BPDCCIDFHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int GIFPBNDDCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int GKOFMCPFIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool BMNAGIBLAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool FJGHKLDGNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool HDNBIHGPLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float JNKPGFHBNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> PCEIMGKMGCL;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIKNHNBNAFI EPAJLKCFJIE(OIKNHNBNAFI KJPICGPOAKA);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIDJJDIEHEP(OIKNHNBNAFI MBKOPLBCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLBGPHKHPHC();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DHKBIKGKIPG(DKKFAAJNJJM<string>.BNLIHIFJPDL IPMNONOAJID, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LDENAFJJPKP(float JFMGOBGJJJI);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IIGPNDDABHI(string IABPLCBPMIK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<AHFDHLNPAAB> JKKOEBNMOPN();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable NFCOCCBBNCL(object MJAGIMDGJBK, AHFDHLNPAAB HHPGBAHCBFC);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<JEEIKNNKFIG> DLGFIDMJAPI();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LPIFEJNCBGG PEJGBNPHEJD(IEnumerable<KCDFJLGNJKD> JBLIANBCKDB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void COLEBKJBAGP(int EOKPMGGJEMH);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task IBNJFKJDHBH();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IDPPJDFNDDD();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KBLLPIDFFNC();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BEANNIGLBEB(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task BFNJAHEPEOL(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<JJLKKPOGHFJ> POGLMLLDJGG(DateTime CBMABLFCLON, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> LFCJOMNNCPD(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HKIDMOLOFEK(string ILBALOOKKCP = "", float EMFFCDLDJIB = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GBMCNLAFKHG DPLCFCKFLJK(LGGCFGKNFLP FJEKLENGBNA, KPMJFDCAFMO IENPLAMADNI, PCENONMPPIA NOLICNPKGGN, IEnumerable<PersistenceView> BFFKMICOINP, OMLKBKDLMOE DKALKIDHLCF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NMMNPJAHABO(PCENONMPPIA NOLICNPKGGN);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IDBMNEFKHKK(KCDFJLGNJKD KLFCHOKODFK, [In] GBMCNLAFKHG GPCIEMBEENL);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task ODKCPOGJOEI(PCENONMPPIA HJPMKOAIJIF, bool MEDOGCKCIKM, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task DFJJFMEDHID(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ANHLHBCNBBH(long GFHIJAKOMMI, long JPKIDMNFGFI, APAMIKOGBPP DHKAOBLPBCI, NJEJHBFOBPK HHEEPFPAJJF, DEGIKKCKCON DFDCIIBGMEI, LGOJJLPEJAM? DKGHDKKALOF, CJEMFAOCIIJ? DGAEEKANLFD);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IOBNMNNLBEL(long GFHIJAKOMMI, long JPKIDMNFGFI, CJEMFAOCIIJ? DGAEEKANLFD);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void INHNDNEEJOA(PersistenceView NHKLFONILDE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JIAHJFBLGOB(string JOJKEDNBDJN, LOAOCAFLNEN NLKCLNKGHKO, MBPHGEGJLJE FNDJAEHHCBD, [Optional] string? DLMJOMDCGIO, [Optional] string? HGHJJNNCKIM, [Optional] string? FHFFOKDLLLF);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool GFPPPGPJJMF(PersistenceView KBMPEIPJGHK);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NOIEKJEFMEE(KCDFJLGNJKD KLFCHOKODFK, EIJMMJGEKKD PKBNMPFIAIA, [Out] BIIFDOPFNJN MIJMFHAKDNK);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task LHGGGMNBFFD(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void PLKJKIFIAEP();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable AKOBNGLDOHF();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void DKGLEEBHJKL(PCENONMPPIA HJPMKOAIJIF, EIJMMJGEKKD PKBNMPFIAIA);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> IGMEEODDHNI(KIFHCLNMNON FLIPFCGMCOP, CancellationToken GMEAHOBHMAD, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void LJCICHPKNGK(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<IPCPPGKOOOH> HPKMLHODNNE(CIABBBJOKNM FLPDPHNPDPK);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<APAMIKOGBPP> ECKJEPJCOKK(long GFHIJAKOMMI, bool DJKCCELCKOA, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<ICAKPDKFOPO> AKAAOFDCIIB(long GFHIJAKOMMI, long JPKIDMNFGFI, long LOHFPFAAEFB, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<NJEJHBFOBPK> ILLNCGHNNPB(long GFHIJAKOMMI, long JPKIDMNFGFI, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<JNMEENHOMDP> MPLAMJIACKG(long GFHIJAKOMMI, Guid KDIGMECGBOF, long? PALELGDJJCI, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	CMMOHICJPAP<JNMEENHOMDP, IEnumerable<FLDJPBAHJJH>> KIIGMCBFJPE();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<ONHIKKMCJNF> KDBPHHGAMGI(string IDCDGEEOELI, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<ONHIKKMCJNF> IMPCOCODPAN(string IDCDGEEOELI, long GFHIJAKOMMI, long JPKIDMNFGFI, Guid? DPCIEGDDHDL, IDMHOPBDNKH.BIGFGOMMGOB JPCNIAHCHAA, IDMHOPBDNKH.BIGFGOMMGOB AJDCEEKKJIC, int JPILDFAPLHD);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool PKJDOPGOPLB();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool JLOFMOLNGCF();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool FDMAHHENLCI(IEnumerable<BIIFDOPFNJN> FFMIBLPBNOP);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void KAFNAOBHHBK(List<GameObject> BBDFCHKACKL);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float ICCKDGADBNE();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> JLGHKFOGIFJ(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> AFFOMBLNLHM(string ANDNLMEHDMG, LoadSceneMode IDDPAKMCMKP, bool JBDNOPCAAAA, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void CJOPMOJLNLA(bool EMMOENAPJHM);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void ONINJKIBPHE();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void CGKONPDBOKJ();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MCMFEEMGBAA(bool KJHBMJNLEOD);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<IDMHOPBDNKH.BIGFGOMMGOB> NILLHMNGEOJ(byte[] IMINNNCPCJF, IDMHOPBDNKH.KEOKBOJEHAD BJJKGKONMDC, FIIOJLLPHAP BDBPKJHHNEO, [Optional] IReadOnlyCollection<string>? DEHBNOFJHIN, [Optional] string? FIJCGPJGIOL);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void CHINJAANJMM(LOAOCAFLNEN LAIHINALNIM);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task CIDABPBGNNN(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task MHCEMMGFKMD(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task IAJOCHPADNJ(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task AMGKOIHKFAG(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable BAJBMFJEGLE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IOCDNLDOLPL MDDOKCAEMFJ();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task ONLOKJEMFJL(CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IOCDNLDOLPL
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NDBJNFCEKLB(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OPJLCFNOBAE(CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct GBMCNLAFKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> JLCJFECIBPH;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum JJLKKPOGHFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LGGCFGKNFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? LABAJPNFKAB;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface OJNDGDMFDGE
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	LOAOCAFLNEN INJLKHMAOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	APAMIKOGBPP KAIJLPBKJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	NKDJCGCAECB PGBOANLEKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool PJDLKAFFKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool FELOOBONHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int HHJIEBOHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action PCIMJKPFJNA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> NBDHFLFKMDF;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CHDHCDBOJBP();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.MOEIHPIFPHA> LGMLKNJEACP(long HHKAEIEEJAI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ENHDLIGDIOB> OHIMNCFFOFL(LOAOCAFLNEN NLKCLNKGHKO, [Optional] GCGPBOIBBAJ CFGIFCEABDC);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<ENHDLIGDIOB> MJEIMAOKDJC();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task FOKOMHJMMEJ();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(LOAOCAFLNEN, GCGPBOIBBAJ) AMODFDOLDMG();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EKOGFCEADNG KKPJFGIEKAA();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JEJHPLMPJBM(long HHKAEIEEJAI);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PANLFMKNGKO(LOAOCAFLNEN NLKCLNKGHKO, Matchmaking.ILBPPMACJPK KJCFPPKBAOB, (int Major, int? Minor)? ALIHNDLFCFH);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BOLJILCGMIK
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJPBCFJALDH([Out] IEnumerable<int> JNCENILCBDA);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKEBPACEFAM(JHEECHAOLLM KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFFBGCGHHGN(JHEECHAOLLM KAJENDFCCBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PIOPDDDLELK
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JBKBFCCBAPF(AKIGBGIOJEO DAKIBMJOMIE);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface BPCLLIOINDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBJHCPDCBCH(IPFCCGNHJBO.DJFNDLJENDM KNOEBBONBND);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEEJADEINAL(IPFCCGNHJBO.DJFNDLJENDM KNOEBBONBND);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface HJEBBLBMFCN : BPCLLIOINDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKIGBGIOJEO MDPBIAIHOBC(EIGONBNGIIK NGHKAKJAOHD);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface JJCPPGOLFEC : BPCLLIOINDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKIGBGIOJEO GPKIBGOACAC(EIGONBNGIIK PCJIBHNFPNF);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface GCEGIJANLLG
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> KKPGOGMHBPC(Guid? DPCIEGDDHDL, IReadOnlyCollection<NKFFLFJJKEG> ALHNEKAHKCI, IReadOnlyCollection<NKFFLFJJKEG> PBOJNIAEAOO, ELEPONEAILP JHFGNEFLMNA, long? GFHIJAKOMMI, long? JPKIDMNFGFI, GHCBELNNDFF.DLOHDJBNJDL HCDLCJBKMMA, CancellationToken GMEAHOBHMAD, bool LEONMDCAHIM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class JIIEGHGACCB
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public KKEKPLKDMHL ENHHJHBHMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<KKEKPLKDMHL> OKGLAAKBFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<KKEKPLKDMHL> AMEECGEEDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xCC0080", Offset = "0xCBE880", VA = "0x180CC0080")]
	public JIIEGHGACCB(KKEKPLKDMHL NCBCDHDHOCF, IReadOnlyList<KKEKPLKDMHL> EBJHMKHAHNJ, IReadOnlyList<KKEKPLKDMHL> HNKGPJNBEBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CMMOHICJPAP<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AOGODOAGAAO<AIPBKEKEDCP<TData>, EMOGOMODAJG>> IGMEKNNNKPM(TGetDataArg OPAHMKOAAKD, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class HMDFNHGEGEC : GBCNJFGJIEN, CKBNJKGCBIE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BJGMMKMKBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HMDFNHGEGEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PMABMGLDFHF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<AKIGBGIOJEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x87C41D0", Offset = "0x87C29D0", VA = "0x1887C41D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x87C4450", Offset = "0x87C2C50", VA = "0x1887C4450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AJLBBOLADHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public HMDFNHGEGEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x87C3750", Offset = "0x87C1F50", VA = "0x1887C3750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x87C3980", Offset = "0x87C2180", VA = "0x1887C3980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DNMMMELPFIM : IEnumerable<GDBDNONDKIG>, IEnumerable, IEnumerator<GDBDNONDKIG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private GDBDNONDKIG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HMDFNHGEGEC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private GDBDNONDKIG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public DNMMMELPFIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x87C6F00", Offset = "0x87C5700", VA = "0x1887C6F00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x87C7360", Offset = "0x87C5B60", VA = "0x1887C7360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x87C72B0", Offset = "0x87C5AB0", VA = "0x1887C72B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GDBDNONDKIG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x87C72B0", Offset = "0x87C5AB0", VA = "0x1887C72B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource GIIOLOOPFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly OIKNHNBNAFI MBKOPLBCEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LCNJIPGDFPA IHIBJBFJHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool CGFBLFMIJLI;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KIFHCLNMNON GJDHJHDLOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public ILBAAIEHPBH BOCCLNAJFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NHINCABDBDO NDEFNCFAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public HJEBBLBMFCN LBIHJKAJNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA274D0", Offset = "0xA25CD0", VA = "0x180A274D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JJCPPGOLFEC PIIMDLALELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA35000", Offset = "0xA33800", VA = "0x180A35000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public HJKJLEGOOPN AIHHOKFOPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PPOCKLEIMOO APENNJDGKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA33780", VA = "0x180A34F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HJABLGDBPEI LPMPIGDBHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA8C920", Offset = "0xA8B120", VA = "0x180A8C920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public PHKHLEMNFND MIDMLEHBJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA35090", Offset = "0xA33890", VA = "0x180A35090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OKPHNFNFFAF HMOOOMALDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xEEFE60", Offset = "0xEEE660", VA = "0x180EEFE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public EEFLELAHAOG FFHHNNKFGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7E0", Offset = "0xA29FE0", VA = "0x180A2B7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FIJGONFDHGJ JMJHIAPLPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xEF9690", Offset = "0xEF7E90", VA = "0x180EF9690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public OFIJFBKPKIO KEJBHHCBKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xABDC30", Offset = "0xABC430", VA = "0x180ABDC30", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xABDC40", Offset = "0xABC440", VA = "0x180ABDC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public BGBOIJEKNFM HHOCLAEFKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xABDC70", Offset = "0xABC470", VA = "0x180ABDC70", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xABDCB0", Offset = "0xABC4B0", VA = "0x180ABDCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GLELJGKEICK GMJCKJKCFGK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABC4A0", VA = "0x180ABDCA0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xABDC80", Offset = "0xABC480", VA = "0x180ABDC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public HIGLOPGDPKP CJFNFPPKNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAB0840", Offset = "0xAAF040", VA = "0x180AB0840", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA80", Offset = "0xAAD280", VA = "0x180AAEA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public GAPJBOEFBCP FFBCAAMDMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7D0", Offset = "0xA29FD0", VA = "0x180A2B7D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA2B770", Offset = "0xA29F70", VA = "0x180A2B770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public KFDFEJKCABK HIJHBJHOCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAB0B40", Offset = "0xAAF340", VA = "0x180AB0B40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F40", Offset = "0xAA5740", VA = "0x180AA6F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public JKMJAAFFHDI HKDMDINPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB422B0", Offset = "0xB40AB0", VA = "0x180B422B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB412A0", Offset = "0xB3FAA0", VA = "0x180B412A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public AFAONOHCBBF IKAFJMGGBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xB26550", Offset = "0xB24D50", VA = "0x180B26550", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB25730", Offset = "0xB23F30", VA = "0x180B25730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public PGFIKCCMAPF EMIODLJCACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAB0A90", Offset = "0xAAF290", VA = "0x180AB0A90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9060", VA = "0x180AAA860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public OGLGLBIBLMO IEPJFAELMID
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAB0CD0", Offset = "0xAAF4D0", VA = "0x180AB0CD0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC850", Offset = "0xAAB050", VA = "0x180AAC850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public DKHPINBEEOE HADIMPOLHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAB0B70", Offset = "0xAAF370", VA = "0x180AB0B70", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAB0EB0", Offset = "0xAAF6B0", VA = "0x180AB0EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public BOLJILCGMIK BOHCEOIHDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAB0850", Offset = "0xAAF050", VA = "0x180AB0850", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAB0D30", Offset = "0xAAF530", VA = "0x180AB0D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public HNENONAPKCB KOPGEDAMCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAEC840", Offset = "0xAEB040", VA = "0x180AEC840", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAE7580", Offset = "0xAE5D80", VA = "0x180AE7580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public GLCPPLLGKIP OKMIOCDLGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB31270", Offset = "0xB2FA70", VA = "0x180B31270", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xB2DFE0", Offset = "0xB2C7E0", VA = "0x180B2DFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HMKJDDPKDJE PMDPPEOLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAB0BD0", Offset = "0xAAF3D0", VA = "0x180AB0BD0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAA9E00", VA = "0x180AAB600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public OMKFNAOGINO EOGFOMCLGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xAB0830", Offset = "0xAAF030", VA = "0x180AB0830", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IEEECBLGMDK HNGNNGEDHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xB32900", Offset = "0xB31100", VA = "0x180B32900", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FILOJONJOBN POLLDBDNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB380A0", Offset = "0xB368A0", VA = "0x180B380A0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BKBJCAOLAHJ NLEEGCNKENA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xB33C60", Offset = "0xB32460", VA = "0x180B33C60", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public LNINKDJALGH NOKHBLLDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xB46150", Offset = "0xB44950", VA = "0x180B46150", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GCGPBOIBBAJ PGMLKCKIJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAA0", Offset = "0xB2D2A0", VA = "0x180B2EAA0", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xCAAD80", Offset = "0xCA9580", VA = "0x180CAAD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool BHDPMBJGCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x87CACF0", Offset = "0x87C94F0", VA = "0x1887CACF0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool JAEPFOOICAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x87CB120", Offset = "0x87C9920", VA = "0x1887CB120", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool BAGKAAMGOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F320", Offset = "0x1D1DB20", VA = "0x181D1F320", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken OFNFMEAIBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x87CAA90", Offset = "0x87C9290", VA = "0x1887CAA90", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private OIKNHNBNAFI PEHHEHEOCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool CIJKIKJGPJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F320", Offset = "0x1D1DB20", VA = "0x181D1F320", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D18A10", Offset = "0x1D17210", VA = "0x181D18A10", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event CJKBCPOKPFH HNJFPMPLHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x87CB1A0", Offset = "0x87C99A0", VA = "0x1887CB1A0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x87CAC40", Offset = "0x87C9440", VA = "0x1887CAC40", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event CJKBCPOKPFH BIAHBLNNKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x87CB0C0", Offset = "0x87C98C0", VA = "0x1887CB0C0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x87CB500", Offset = "0x87C9D00", VA = "0x1887CB500", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event CJKBCPOKPFH CCOPMMFEKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x87CAA30", Offset = "0x87C9230", VA = "0x1887CAA30", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x87CA840", Offset = "0x87C9040", VA = "0x1887CA840", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<GJHCICIAKDP, bool> OMNPPPNCGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x87CAAB0", Offset = "0x87C92B0", VA = "0x1887CAAB0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x87CB000", Offset = "0x87C9800", VA = "0x1887CB000", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xCAAD80", Offset = "0xCA9580", VA = "0x180CAAD80", Slot = "39")]
	public void NDFKBKDIIOP(GCGPBOIBBAJ ADJPBNCNMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x87CB560", Offset = "0x87C9D60", VA = "0x1887CB560")]
	[UnityEngine.Scripting.Preserve]
	internal HMDFNHGEGEC([FAPODKMFODF(null)] OIKNHNBNAFI MBKOPLBCEJA, [FAPODKMFODF(null)] KIFHCLNMNON FLIPFCGMCOP, [FAPODKMFODF(null)] ILBAAIEHPBH HLCPJCICGOK, [FAPODKMFODF(null)] LCLCIAOJCLH PJHMONPOPCI, [FAPODKMFODF(null)] NHINCABDBDO ODNLOJNPCBP, [FAPODKMFODF(null)] HJEBBLBMFCN PAHHKJDMIHA, [FAPODKMFODF(null)] JJCPPGOLFEC NEPFHOEEIOP, [FAPODKMFODF(null)] PPOCKLEIMOO BDNIHLNLANP, [FAPODKMFODF(null)] HJABLGDBPEI KAMDGLOAGEC, [FAPODKMFODF(null)] PHKHLEMNFND MFMCJILLGAN, [FAPODKMFODF(null)] OKPHNFNFFAF CGEDDGPEAFA, [FAPODKMFODF(null)] EEFLELAHAOG BPBBIAFOCIM, [FAPODKMFODF(null)] FIJGONFDHGJ FAGEDOEFKNE, [FAPODKMFODF(null)] OFIJFBKPKIO PAHBMKFELFM, [FAPODKMFODF(null)] BGBOIJEKNFM AIKPHBKAPJF, [FAPODKMFODF(null)] GLELJGKEICK KPLDOLOOBJN, [FAPODKMFODF(null)] HIGLOPGDPKP FJJKBMEJINP, [FAPODKMFODF(null)] GAPJBOEFBCP CLDPEIPCDPN, [FAPODKMFODF(null)] KFDFEJKCABK KODEFGHFABI, [FAPODKMFODF(null)] JKMJAAFFHDI CNEHMBOCOLK, [FAPODKMFODF(null)] PGFIKCCMAPF PIJLIMPDCEI, [FAPODKMFODF(null)] AFAONOHCBBF EJKOCOEFMOF, [FAPODKMFODF(null)] OGLGLBIBLMO FBCKHIOAEFG, [FAPODKMFODF(null)] DKHPINBEEOE EKMAFCIBKFM, [FAPODKMFODF(null)] BOLJILCGMIK KFGOGNENPAM, [FAPODKMFODF(null)] GLCPPLLGKIP LDCOIJIBFHA, [FAPODKMFODF(null)] HMKJDDPKDJE IKOMEIGHHPE, [FAPODKMFODF(null)] OMKFNAOGINO MMINEOCJBJJ, [FAPODKMFODF(null)] IEEECBLGMDK BBPCOFHIAHD, [FAPODKMFODF(null)] FILOJONJOBN MEIBPHMNOEH, [FAPODKMFODF(null)] BKBJCAOLAHJ ILCNPPALGLN, [FAPODKMFODF(null)] LNINKDJALGH AJOOINMMHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x87CAB10", Offset = "0x87C9310", VA = "0x1887CAB10")]
	private void IEAMPCKAMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x87CA8A0", Offset = "0x87C90A0", VA = "0x1887CA8A0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x87CACA0", Offset = "0x87C94A0", VA = "0x1887CACA0", Slot = "51")]
	private void IHFPECONKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x87CA6C0", Offset = "0x87C8EC0", VA = "0x1887CA6C0", Slot = "52")]
	private BINJDAAAAED ANGBNMMPFOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x87CAD50", Offset = "0x87C9550", VA = "0x1887CAD50", Slot = "53")]
	private NONBIIEEFGF JCFPPNNOBDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x87CB200", Offset = "0x87C9A00", VA = "0x1887CB200", Slot = "55")]
	public Task PFAAMKKOKPL(int JPILDFAPLHD, LGOJJLPEJAM DKGHDKKALOF, Func<DEGIKKCKCON, DEGIKKCKCON> POONKIBDCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x87CAEF0", Offset = "0x87C96F0", VA = "0x1887CAEF0")]
	private MNLDJINICKO JDNDJPOKFGE(int JPILDFAPLHD, LGOJJLPEJAM DKGHDKKALOF, Func<DEGIKKCKCON, DEGIKKCKCON> POONKIBDCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x87CADE0", Offset = "0x87C95E0", VA = "0x1887CADE0", Slot = "56")]
	[AsyncStateMachine(typeof(BJGMMKMKBNC))]
	private Task<AKIGBGIOJEO> JCKDJHALCMJ(PMABMGLDFHF KOKHFAJAONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x87CA750", Offset = "0x87C8F50", VA = "0x1887CA750", Slot = "57")]
	[AsyncStateMachine(typeof(AJLBBOLADHG))]
	private Task ANLDILJHGND(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x87CABC0", Offset = "0x87C93C0", VA = "0x1887CABC0")]
	[IteratorStateMachine(typeof(DNMMMELPFIM))]
	private IEnumerable<GDBDNONDKIG> IEDNAELEEFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x87CB060", Offset = "0x87C9860", VA = "0x1887CB060")]
	[CompilerGenerated]
	private void MFOIEDDKMCA(GDBDNONDKIG EIBGHDHLJMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BGMKLFHFBGG : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x18FCA00", Offset = "0x18FB200", VA = "0x1818FCA00")]
	public BGMKLFHFBGG(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class BNNMNDCGGID : KHIMAEEAJNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct IFEMGECPNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<KHIMAEEAJNF.IEBLECHBOEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<KBPDCLGJICP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public BNNMNDCGGID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x87CC770", Offset = "0x87CAF70", VA = "0x1887CC770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x87CCA70", Offset = "0x87CB270", VA = "0x1887CCA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string CKIAEFLAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x87C5070", Offset = "0x87C3870", VA = "0x1887C5070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public BNNMNDCGGID(GBCNJFGJIEN KFBGJKCPJCG, LCLCIAOJCLH PJHMONPOPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x87C4F60", Offset = "0x87C3760", VA = "0x1887C4F60", Slot = "5")]
	[AsyncStateMachine(typeof(IFEMGECPNBC))]
	public Task<KHIMAEEAJNF.IEBLECHBOEG> IELMDKELBNN(HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class LNOFEEBCOEI : LHNBPCJHLLN, KHIMAEEAJNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct JGOBPOPPGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<KHIMAEEAJNF.IEBLECHBOEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LNOFEEBCOEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HashSet<KBPDCLGJICP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private LOAOCAFLNEN <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<KHIMAEEAJNF.IEBLECHBOEG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x87CE030", Offset = "0x87CC830", VA = "0x1887CE030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x87CE990", Offset = "0x87CD190", VA = "0x1887CE990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string CKIAEFLAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x87D3740", Offset = "0x87D1F40", VA = "0x1887D3740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public LNOFEEBCOEI(GBCNJFGJIEN KFBGJKCPJCG, LCLCIAOJCLH PJHMONPOPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x87D35F0", Offset = "0x87D1DF0", VA = "0x1887D35F0", Slot = "5")]
	[AsyncStateMachine(typeof(JGOBPOPPGHB))]
	public Task<KHIMAEEAJNF.IEBLECHBOEG> IELMDKELBNN(HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class FIMHMPNPMAL : LHNBPCJHLLN, KHIMAEEAJNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct PGOLHMKGKCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<KHIMAEEAJNF.IEBLECHBOEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public FIMHMPNPMAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public HashSet<KBPDCLGJICP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<ENHDLIGDIOB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<KHIMAEEAJNF.IEBLECHBOEG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x87E0270", Offset = "0x87DEA70", VA = "0x1887E0270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x87E0C60", Offset = "0x87DF460", VA = "0x1887E0C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string CKIAEFLAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x87C9AF0", Offset = "0x87C82F0", VA = "0x1887C9AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public FIMHMPNPMAL(GBCNJFGJIEN KFBGJKCPJCG, LCLCIAOJCLH PJHMONPOPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x87C99A0", Offset = "0x87C81A0", VA = "0x1887C99A0", Slot = "5")]
	[AsyncStateMachine(typeof(PGOLHMKGKCE))]
	public Task<KHIMAEEAJNF.IEBLECHBOEG> IELMDKELBNN(HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class HDLMNAOBGAC : LHNBPCJHLLN, KHIMAEEAJNF
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BIEKAODMEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ENHDLIGDIOB matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BIEKAODMEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x87C4090", Offset = "0x87C2890", VA = "0x1887C4090")]
		internal object KCHKJNFFKDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x87C4110", Offset = "0x87C2910", VA = "0x1887C4110")]
		internal object PJIGKJEBDFO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct LDLEEAGMNBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder<KHIMAEEAJNF.IEBLECHBOEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HDLMNAOBGAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HashSet<KBPDCLGJICP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private BIEKAODMEPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<ENHDLIGDIOB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter<KHIMAEEAJNF.IEBLECHBOEG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87D18B0", Offset = "0x87D00B0", VA = "0x1887D18B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x87D24D0", Offset = "0x87D0CD0", VA = "0x1887D24D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string CKIAEFLAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x87CA590", Offset = "0x87C8D90", VA = "0x1887CA590", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public HDLMNAOBGAC(GBCNJFGJIEN KFBGJKCPJCG, LCLCIAOJCLH PJHMONPOPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x87CA440", Offset = "0x87C8C40", VA = "0x1887CA440", Slot = "5")]
	[AsyncStateMachine(typeof(LDLEEAGMNBO))]
	public Task<KHIMAEEAJNF.IEBLECHBOEG> IELMDKELBNN(HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class LHNBPCJHLLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JCEBIJKIJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public BMELPJIFPCL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HashSet<KBPDCLGJICP.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public LHNBPCJHLLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private List<KBPDCLGJICP.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x87CD330", Offset = "0x87CBB30", VA = "0x1887CD330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x87CD850", Offset = "0x87CC050", VA = "0x1887CD850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	protected readonly GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E00", Offset = "0x87D1600", VA = "0x1887D2E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public LHNBPCJHLLN(GBCNJFGJIEN KFBGJKCPJCG, LCLCIAOJCLH PJHMONPOPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x87D2CD0", Offset = "0x87D14D0", VA = "0x1887D2CD0")]
	[AsyncStateMachine(typeof(JCEBIJKIJMB))]
	protected Task BOIGHBLBDHG(BMELPJIFPCL GLHOMCPEEHH, HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JMKFEHFOIIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct KOEIELMKBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AsyncTaskMethodBuilder<KHIMAEEAJNF.IEBLECHBOEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LCLCIAOJCLH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x87D0C60", Offset = "0x87CF460", VA = "0x1887D0C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x87D0FE0", Offset = "0x87CF7E0", VA = "0x1887D0FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class MGBLPEPIFJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public GBCNJFGJIEN roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MGBLPEPIFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x87D3F40", Offset = "0x87D2740", VA = "0x1887D3F40")]
		internal object FCJKGGMBCKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly float IHHALCDLMAD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal static readonly HashSet<KBPDCLGJICP.Reason> KMELAKELBPL;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x87CF060", Offset = "0x87CD860", VA = "0x1887CF060")]
	[AsyncStateMachine(typeof(KOEIELMKBAP))]
	internal static Task<KHIMAEEAJNF.IEBLECHBOEG> GIOCNDMHPCG(LCLCIAOJCLH PJHMONPOPCI, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x87CEEE0", Offset = "0x87CD6E0", VA = "0x1887CEEE0")]
	internal static void BMHNJJIAMMK(GBCNJFGJIEN KFBGJKCPJCG, BMELPJIFPCL GLHOMCPEEHH, string JOJKEDNBDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface KHIMAEEAJNF
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct IEBLECHBOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public bool PEFHAHJOKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public KBPDCLGJICP.Reason BEPEOMJMPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Enum? FHFFOKDLLLF;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x87CC730", Offset = "0x87CAF30", VA = "0x1887CC730")]
		public static IEBLECHBOEG BNFFGAJIILO()
		{
			return default(IEBLECHBOEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x87CC740", Offset = "0x87CAF40", VA = "0x1887CC740")]
		public static IEBLECHBOEG DNIMIAPBMPI(KBPDCLGJICP.Reason BEPEOMJMPKF, [Optional] Enum? FHFFOKDLLLF)
		{
			return default(IEBLECHBOEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string PJLPGKOADLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IEBLECHBOEG> IELMDKELBNN(HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct PFJEEOKHOOL
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HFAFCLKPOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public GBCNJFGJIEN manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HFAFCLKPOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x87CA640", Offset = "0x87C8E40", VA = "0x1887CA640")]
		internal Task FHIFHBCIFDD(CancellationToken cancellationToken, int roomTotalVersion, BAMAEEMHEMC localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct BMABAKHODHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public PFJEEOKHOOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private PMABMGLDFHF <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private TaskAwaiter<JJLKKPOGHFJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter<AKIGBGIOJEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x87C44C0", Offset = "0x87C2CC0", VA = "0x1887C44C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x87C4A50", Offset = "0x87C3250", VA = "0x1887C4A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct DAFFMNAFGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PFJEEOKHOOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x87C58F0", Offset = "0x87C40F0", VA = "0x1887C58F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x87C5C10", Offset = "0x87C4410", VA = "0x1887C5C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly CancellationToken GMEAHOBHMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly GBCNJFGJIEN EGOJLGMOLFK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private KIFHCLNMNON GJDHJHDLOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x87E0220", Offset = "0x87DEA20", VA = "0x1887E0220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x87DFFF0", Offset = "0x87DE7F0", VA = "0x1887DFFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x87E0150", Offset = "0x87DE950", VA = "0x1887E0150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private PHKHLEMNFND MIDMLEHBJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x87E01D0", Offset = "0x87DE9D0", VA = "0x1887E01D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x288EB50", Offset = "0x288D350", VA = "0x18288EB50")]
	public PFJEEOKHOOL(CancellationToken GMEAHOBHMAD, GBCNJFGJIEN EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x87DFC00", Offset = "0x87DE400", VA = "0x1887DFC00")]
	public static KCPCPABECLA DIMNLAJHEMD(GBCNJFGJIEN EGOJLGMOLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x87E0040", Offset = "0x87DE840", VA = "0x1887E0040")]
	[AsyncStateMachine(typeof(BMABAKHODHC))]
	public Task<bool> IHHPLANMBKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x87DFDE0", Offset = "0x87DE5E0", VA = "0x1887DFDE0")]
	private bool EJMFFEKFALP([Out] PMABMGLDFHF KOKHFAJAONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x87DFB30", Offset = "0x87DE330", VA = "0x1887DFB30")]
	[AsyncStateMachine(typeof(DAFFMNAFGDF))]
	private Task DBHHNIFNFPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x87DFCB0", Offset = "0x87DE4B0", VA = "0x1887DFCB0")]
	private Task<JJLKKPOGHFJ> DOFBOGNLHKA(PMABMGLDFHF NNGGKGDNKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct ILMPMHDEJBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly BGBOIJEKNFM AIKPHBKAPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Guid GKMDGNFGEOO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(AKIGBGIOJEO, Task)> FKAHEBFALHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x87CD260", Offset = "0x87CBA60", VA = "0x1887CD260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x524F700", Offset = "0x524DF00", VA = "0x18524F700")]
	public ILMPMHDEJBN(BGBOIJEKNFM AIKPHBKAPJF, Guid GKMDGNFGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x87CD210", Offset = "0x87CBA10", VA = "0x1887CD210")]
	public TaskAwaiter<(AKIGBGIOJEO, Task)> GAFCKONHBEH()
	{
		return default(TaskAwaiter<(AKIGBGIOJEO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x87CD140", Offset = "0x87CB940", VA = "0x1887CD140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct BPKKINMGHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly TaskCompletionSource<(AKIGBGIOJEO, Task)> MCOACBIGPKA;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(AKIGBGIOJEO, Task)> FKAHEBFALHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x87C5330", Offset = "0x87C3B30", VA = "0x1887C5330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x87C5370", Offset = "0x87C3B70", VA = "0x1887C5370")]
	public BPKKINMGHNG(TimeSpan MDFBIFEKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x87C5120", Offset = "0x87C3920", VA = "0x1887C5120")]
	public void AMLEMIIHCEF(Task EAPFHGLEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x87C51C0", Offset = "0x87C39C0", VA = "0x1887C51C0")]
	public void DCAOHHGHION(AKIGBGIOJEO DAKIBMJOMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x87C52E0", Offset = "0x87C3AE0", VA = "0x1887C52E0")]
	public void MNILJEHNJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x87C5250", Offset = "0x87C3A50", VA = "0x1887C5250")]
	internal void JFAFDCEDIJO(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class LDIOOIODNFK
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x87D1580", Offset = "0x87CFD80", VA = "0x1887D1580")]
	public static FNDPEECNEPD EJMPHNJECJE(this FNDPEECNEPD OILJBDLKBKC, APAMIKOGBPP PNPIIDHANMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x87D1720", Offset = "0x87CFF20", VA = "0x1887D1720")]
	public static FNDPEECNEPD HLAJCLEKIJI(this FNDPEECNEPD OILJBDLKBKC, NJEJHBFOBPK LDJIJABHOND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class JGKKFJEGODA : HJKJLEGOOPN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HKEEBOKHCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NJEJHBFOBPK subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HKEEBOKHCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x87CA690", Offset = "0x87C8E90", VA = "0x1887CA690")]
		internal bool PKKAKEMOMPH(NKDJCGCAECB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly GLCPPLLGKIP MNECFCFLFKC;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public JGKKFJEGODA(GLCPPLLGKIP LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x87CDDA0", Offset = "0x87CC5A0", VA = "0x1887CDDA0", Slot = "4")]
	public FNDPEECNEPD INHDMBAMCNE(long HKCIIPDKLEO, long JPKIDMNFGFI, string IDCDGEEOELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x87CD960", Offset = "0x87CC160", VA = "0x1887CD960", Slot = "5")]
	public FNDPEECNEPD INHDMBAMCNE(long HKCIIPDKLEO, long JPKIDMNFGFI, DOPHJNOBIJD NNOJLKJDGHO, Guid? OLOGBCPAJIO, long LOHFPFAAEFB, bool EEEIDBPPENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x87CDE30", Offset = "0x87CC630", VA = "0x1887CDE30", Slot = "6")]
	public FNDPEECNEPD INHDMBAMCNE(IPCPPGKOOOH NKGOHABEIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x87CDAC0", Offset = "0x87CC2C0", VA = "0x1887CDAC0", Slot = "7")]
	public FNDPEECNEPD INHDMBAMCNE(APAMIKOGBPP CGIBKHMADLE, NJEJHBFOBPK ACDAHANDEAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x87CD8B0", Offset = "0x87CC0B0", VA = "0x1887CD8B0")]
	private Guid? GLGHFONBEEG(APAMIKOGBPP KMEEHCKCEPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class MFCIMLHCGPN : HJABLGDBPEI, GDBDNONDKIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct KGPEOLIIHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public MFCIMLHCGPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x87D0570", Offset = "0x87CED70", VA = "0x1887D0570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x87D0C00", Offset = "0x87CF400", VA = "0x1887D0C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly JHEECHAOLLM NIEDHOBCEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private string KOHGPCMBGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Task JNHEKJEJKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool COPBHEPHDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x87D3CD0", Offset = "0x87D24D0", VA = "0x1887D3CD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task AMGEFOLPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x87D3E20", Offset = "0x87D2620", VA = "0x1887D3E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70", Slot = "7")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x87D3B70", Offset = "0x87D2370", VA = "0x1887D3B70", Slot = "6")]
	public void AIANFFDEPHL(Task FEGBHCAEMDO, string PGIIDGECMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x87D3D00", Offset = "0x87D2500", VA = "0x1887D3D00")]
	[AsyncStateMachine(typeof(KGPEOLIIHBC))]
	private Task GPDIJJCAGLA(Task LFLEFAMICOB, string PGIIDGECMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x87D3EB0", Offset = "0x87D26B0", VA = "0x1887D3EB0")]
	public MFCIMLHCGPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class BMJFEFKLKLJ : HNENONAPKCB, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool INJHEECIBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private AODBFAEMBPL IDFFJPFFPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private GLCPPLLGKIP LDCOIJIBFHA;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public AODBFAEMBPL KAEICOOFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x87C4D70", Offset = "0x87C3570", VA = "0x1887C4D70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x87C4DE0", Offset = "0x87C35E0", VA = "0x1887C4DE0", Slot = "7")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x87C4AC0", Offset = "0x87C32C0", VA = "0x1887C4AC0", Slot = "5")]
	public void BCECLHOGKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x87C4C70", Offset = "0x87C3470", VA = "0x1887C4C70", Slot = "6")]
	public void LKEGBHBFNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x87C4CB0", Offset = "0x87C34B0", VA = "0x1887C4CB0")]
	private Task GCGEBJMEOHH(NCGNCPFHELC FOIMOKIBLGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x87C4C70", Offset = "0x87C3470", VA = "0x1887C4C70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BMJFEFKLKLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class LMHKJDKGNPJ : GLCPPLLGKIP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class IFOPNBHODAF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly OPHBELKNMNO NJNLAMHGMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly string MNMCNOJCKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly T GJPLADDCFJL;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T HDAKFEADKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4E76080", Offset = "0x4E74880", VA = "0x184E76080")]
		public IFOPNBHODAF(OPHBELKNMNO NJNLAMHGMGI, string MNMCNOJCKAF, T GJPLADDCFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4E75920", Offset = "0x4E74120", VA = "0x184E75920")]
		private void CCEJLEABKBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly OPHBELKNMNO NJNLAMHGMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly IFOPNBHODAF<TimeSpan> OGJDLLFCBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly IFOPNBHODAF<TimeSpan> JCMCCIMFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly IFOPNBHODAF<TimeSpan> KJADGGFPMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly IFOPNBHODAF<TimeSpan> AJLILJMANNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly IFOPNBHODAF<bool> OGHAJCPGPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly IFOPNBHODAF<bool> FJCAEGLGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly IFOPNBHODAF<bool> EDOIMIONJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly IFOPNBHODAF<int> KOOJDLAOOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly IFOPNBHODAF<bool> FGIKKPEMDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly IFOPNBHODAF<bool> MOAOLLCJJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly IFOPNBHODAF<DMGJGGMGIKH> AKKLDLBDPCG;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan IHBGCJJBBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x87D2FA0", Offset = "0x87D17A0", VA = "0x1887D2FA0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan NKCHIHAOFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x87D3020", Offset = "0x87D1820", VA = "0x1887D3020", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan CLFOEAJFFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E90", Offset = "0x87D1690", VA = "0x1887D2E90", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan AAPJILBPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x87D2F60", Offset = "0x87D1760", VA = "0x1887D2F60", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KNPPBBIDADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x87D3060", Offset = "0x87D1860", VA = "0x1887D3060", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BBLGDOHIANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x87D30A0", Offset = "0x87D18A0", VA = "0x1887D30A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MGPCOPFJHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x87D2ED0", Offset = "0x87D16D0", VA = "0x1887D2ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int MHKEMKJNNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x87D2E50", Offset = "0x87D1650", VA = "0x1887D2E50", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KGODCPGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x87D2FE0", Offset = "0x87D17E0", VA = "0x1887D2FE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FOGMEFFBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x87D30E0", Offset = "0x87D18E0", VA = "0x1887D30E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool CCMDHCJDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x87D2F10", Offset = "0x87D1710", VA = "0x1887D2F10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x87D3120", Offset = "0x87D1920", VA = "0x1887D3120")]
	[UnityEngine.Scripting.Preserve]
	public LMHKJDKGNPJ([FAPODKMFODF(null)] OPHBELKNMNO NJNLAMHGMGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class MMGPGPMGIOF : OKPHNFNFFAF, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class ALFDIEOPHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public FPBLLGEBKEJ roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ALFDIEOPHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87C39E0", Offset = "0x87C21E0", VA = "0x1887C39E0")]
		internal object OBMJBIGIHOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event CJKBCPOKPFH OMMMHINAHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x87D8070", Offset = "0x87D6870", VA = "0x1887D8070", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x87D81E0", Offset = "0x87D69E0", VA = "0x1887D81E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event CJKBCPOKPFH HCJJIEJDEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x87D7FD0", Offset = "0x87D67D0", VA = "0x1887D7FD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x87D8110", Offset = "0x87D6910", VA = "0x1887D8110", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event CJKBCPOKPFH OPKJAKJGFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x87D7B70", Offset = "0x87D6370", VA = "0x1887D7B70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x87D7C60", Offset = "0x87D6460", VA = "0x1887D7C60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GJHCICIAKDP, bool> IBFNHGMJMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x87D7D30", Offset = "0x87D6530", VA = "0x1887D7D30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x87D7AC0", Offset = "0x87D62C0", VA = "0x1887D7AC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "16")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x87D81B0", Offset = "0x87D69B0", VA = "0x1887D81B0", Slot = "12")]
	public void LODICHGODFP(FPBLLGEBKEJ MMOLNADADKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x87D7FA0", Offset = "0x87D67A0", VA = "0x1887D7FA0", Slot = "13")]
	public void GFLCONPOGPK(FPBLLGEBKEJ MMOLNADADKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x87D7D00", Offset = "0x87D6500", VA = "0x1887D7D00", Slot = "14")]
	public void BNOPFEENBEG(FPBLLGEBKEJ MMOLNADADKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x87D7C10", Offset = "0x87D6410", VA = "0x1887D7C10", Slot = "15")]
	public void BGJLKLGFPJN(GJHCICIAKDP GOAEPFPLNNI, bool PEFHAHJOKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x87D7DE0", Offset = "0x87D65E0", VA = "0x1887D7DE0")]
	private void DMJBMMIBENB(CJKBCPOKPFH HHPGBAHCBFC, FPBLLGEBKEJ MMOLNADADKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MMGPGPMGIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class DCMJDHKIBII : EEFLELAHAOG, GDBDNONDKIG, IDisposable, KBPDCLGJICP
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class POJFMOJADLF : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct LGFEJLNLONL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public POJFMOJADLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public KBPDCLGJICP.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private OGBIDEAJDEB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private KHIMAEEAJNF[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private TaskAwaiter<KHIMAEEAJNF.IEBLECHBOEG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x87D2540", Offset = "0x87D0D40", VA = "0x1887D2540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x87D2C70", Offset = "0x87D1470", VA = "0x1887D2C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct IDGMHAIIGHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public AsyncTaskMethodBuilder<KHIMAEEAJNF.IEBLECHBOEG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public KHIMAEEAJNF fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public POJFMOJADLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public KBPDCLGJICP.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private OGBIDEAJDEB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private GPGOOONJPIL <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private TaskAwaiter<KHIMAEEAJNF.IEBLECHBOEG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x87CBA30", Offset = "0x87CA230", VA = "0x1887CBA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x87CC6C0", Offset = "0x87CAEC0", VA = "0x1887CC6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class NDENLPLINJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public KHIMAEEAJNF fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public NDENLPLINJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x87DDC30", Offset = "0x87DC430", VA = "0x1887DDC30")]
			internal object ELJEINCMMNM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Task FEGBHCAEMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationTokenSource KFHNGCODDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public GPGOOONJPIL LEJGMECOONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public LCLCIAOJCLH PJHMONPOPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public MBPHGEGJLJE FNDJAEHHCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public LOAOCAFLNEN NLKCLNKGHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public KHIMAEEAJNF[] CAEDFCJJPLN;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool KLEBMFMNBBH
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x87C9DB0", Offset = "0x87C85B0", VA = "0x1887C9DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool LIMGNEHFDFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x87C9D90", Offset = "0x87C8590", VA = "0x1887C9D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x87E27C0", Offset = "0x87E0FC0", VA = "0x1887E27C0")]
		public POJFMOJADLF(LCLCIAOJCLH PJHMONPOPCI, MBPHGEGJLJE FNDJAEHHCBD, LOAOCAFLNEN NLKCLNKGHKO, KHIMAEEAJNF[] CAEDFCJJPLN, CancellationToken GMEAHOBHMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x87E13C0", Offset = "0x87DFBC0", VA = "0x1887E13C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x87E1B20", Offset = "0x87E0320", VA = "0x1887E1B20")]
		public void GNFGGKMOMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x87E1550", Offset = "0x87DFD50", VA = "0x1887E1550")]
		public void EDLLNJGBDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x87E2060", Offset = "0x87E0860", VA = "0x1887E2060")]
		public void MGBALJBNKHF(KBPDCLGJICP.Reason KFECMBMGNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x87E1E40", Offset = "0x87E0640", VA = "0x1887E1E40")]
		[AsyncStateMachine(typeof(LGFEJLNLONL))]
		public Task GPCCHPEEJAB(KBPDCLGJICP.Reason BEPEOMJMPKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x87E2310", Offset = "0x87E0B10", VA = "0x1887E2310")]
		[AsyncStateMachine(typeof(IDGMHAIIGHL))]
		private Task<KHIMAEEAJNF.IEBLECHBOEG> MJCJFEFLMNO(KBPDCLGJICP.Reason BEPEOMJMPKF, KHIMAEEAJNF AHLLIHJCDKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87E1F40", Offset = "0x87E0740", VA = "0x1887E1F40")]
		private void KKCJPDHKJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x87E1A70", Offset = "0x87E0270", VA = "0x1887E1A70")]
		public bool GMLCIKLHACA(KBPDCLGJICP.Reason KMNFOCFEKGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x87E0EA0", Offset = "0x87DF6A0", VA = "0x1887E0EA0")]
		private void CLEGFIMCNEJ(GPGOOONJPIL OJGLGPLNKGO, KBPDCLGJICP.Reason BEPEOMJMPKF = KBPDCLGJICP.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x87E0CD0", Offset = "0x87DF4D0", VA = "0x1887E0CD0")]
		private void ANEMMMCFNCG(GPGOOONJPIL OJGLGPLNKGO, KHIMAEEAJNF.IEBLECHBOEG KJCFPPKBAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87E1B90", Offset = "0x87E0390", VA = "0x1887E1B90")]
		private void GNILJGAOJMA(GPGOOONJPIL OJGLGPLNKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x87E16B0", Offset = "0x87DFEB0", VA = "0x1887E16B0")]
		private void GANHNDDOCOB(GPGOOONJPIL OJGLGPLNKGO, KHIMAEEAJNF.IEBLECHBOEG KJCFPPKBAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x87E1150", Offset = "0x87DF950", VA = "0x1887E1150")]
		private void DFDEHAFHFMC(GPGOOONJPIL OJGLGPLNKGO, Exception FKONJEEEEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x87E12B0", Offset = "0x87DFAB0", VA = "0x1887E12B0")]
		private void DMGPKLHOPHD(KHIMAEEAJNF AHLLIHJCDKN, KBPDCLGJICP.Reason BEPEOMJMPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x87E1D30", Offset = "0x87E0530", VA = "0x1887E1D30")]
		private void GOCPEOPCFPK(KHIMAEEAJNF AHLLIHJCDKN, KBPDCLGJICP.Reason BEPEOMJMPKF, string FHFFOKDLLLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x87E2450", Offset = "0x87E0C50", VA = "0x1887E2450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class GPGOOONJPIL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public Task<KHIMAEEAJNF.IEBLECHBOEG> FEGBHCAEMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CancellationTokenSource KFHNGCODDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KHIMAEEAJNF AHLLIHJCDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KBPDCLGJICP.Reason KFECMBMGNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public HashSet<KBPDCLGJICP.Reason> HBIOGEIFBHB;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool KLEBMFMNBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x87C9DB0", Offset = "0x87C85B0", VA = "0x1887C9DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool LIMGNEHFDFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x87C9D90", Offset = "0x87C8590", VA = "0x1887C9D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x87C9C30", Offset = "0x87C8430", VA = "0x1887C9C30")]
		public void FBONGFMPKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x87C9C10", Offset = "0x87C8410", VA = "0x1887C9C10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x87C9DD0", Offset = "0x87C85D0", VA = "0x1887C9DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x87CA130", Offset = "0x87C8930", VA = "0x1887CA130")]
		public GPGOOONJPIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class COLFHPJAFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public KBPDCLGJICP.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public COLFHPJAFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x87C5810", Offset = "0x87C4010", VA = "0x1887C5810")]
		internal object FJGKENFNCLA(GPGOOONJPIL x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x87C57A0", Offset = "0x87C3FA0", VA = "0x1887C57A0")]
		internal object DABINPGFDNM(POJFMOJADLF x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x87C5880", Offset = "0x87C4080", VA = "0x1887C5880")]
		internal object HDIBPMPCLOL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct DPJJDJEHPID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public KBPDCLGJICP.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public DCMJDHKIBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private COLFHPJAFDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x87C73B0", Offset = "0x87C5BB0", VA = "0x1887C73B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x87C7E10", Offset = "0x87C6610", VA = "0x1887C7E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct NOANAIHGGIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DCMJDHKIBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public KBPDCLGJICP.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private POJFMOJADLF <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x87DE790", Offset = "0x87DCF90", VA = "0x1887DE790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x87DF400", Offset = "0x87DDC00", VA = "0x1887DF400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct BBBEOMALDJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public DCMJDHKIBII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x87C3AC0", Offset = "0x87C22C0", VA = "0x1887C3AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x87C4030", Offset = "0x87C2830", VA = "0x1887C4030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	internal static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	internal static readonly BMELPJIFPCL AIECLHDCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private POJFMOJADLF HJFBJLHJLPG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C00", Offset = "0x87C5400", VA = "0x1887C6C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool HGMANLGCMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x24AD020", Offset = "0x24AB820", VA = "0x1824AD020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool KAMEALFOACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x87C6400", Offset = "0x87C4C00", VA = "0x1887C6400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x87C6A90", Offset = "0x87C5290", VA = "0x1887C6A90", Slot = "6")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x87C6470", Offset = "0x87C4C70", VA = "0x1887C6470", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x87C6480", Offset = "0x87C4C80", VA = "0x1887C6480", Slot = "9")]
	public void FBONGFMPKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x87C6D60", Offset = "0x87C5560", VA = "0x1887C6D60")]
	private bool OAEIAOFEDIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x87C6060", Offset = "0x87C4860", VA = "0x1887C6060", Slot = "5")]
	private void CFNFNIECFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x87C6B10", Offset = "0x87C5310", VA = "0x1887C6B10", Slot = "8")]
	[AsyncStateMachine(typeof(DPJJDJEHPID))]
	public Task IELHMIOHKAD(KBPDCLGJICP.Reason BEPEOMJMPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x87C6130", Offset = "0x87C4930", VA = "0x1887C6130")]
	private bool CMJNEILPKFO(KBPDCLGJICP.Reason BEPEOMJMPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x87C6600", Offset = "0x87C4E00", VA = "0x1887C6600")]
	private KHIMAEEAJNF[] FFOOBKFPLHI(LOAOCAFLNEN HHMFPJEAMNH, MBPHGEGJLJE AMDCPKPJNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x87C6C50", Offset = "0x87C5450", VA = "0x1887C6C50")]
	[AsyncStateMachine(typeof(NOANAIHGGIC))]
	private Task NDABKMJJKDJ(KBPDCLGJICP.Reason BEPEOMJMPKF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x87C69C0", Offset = "0x87C51C0", VA = "0x1887C69C0")]
	[AsyncStateMachine(typeof(BBBEOMALDJO))]
	private Task HCKBAPBBPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DCMJDHKIBII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MIGJHEBNDEI : FIJGONFDHGJ, GDBDNONDKIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct EAOHDMBNCKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public GCGPBOIBBAJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x87C7E70", Offset = "0x87C6670", VA = "0x1887C7E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x87C87D0", Offset = "0x87C6FD0", VA = "0x1887C87D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct KBNBMLLKNKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public GCGPBOIBBAJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private DKKFAAJNJJM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private OGBIDEAJDEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private BEBFLBECFCJ <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private ONMBGPCKGJP <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x87CF2E0", Offset = "0x87CDAE0", VA = "0x1887CF2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x87D0420", Offset = "0x87CEC20", VA = "0x1887D0420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class NGHGEOLCDLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public Matchmaking.ILBPPMACJPK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HLCLCOKBABM errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NGHGEOLCDLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x87DDCB0", Offset = "0x87DC4B0", VA = "0x1887DDCB0")]
		internal object NDCFMNLGJCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class CPEPJDBBKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Task<FNDPEECNEPD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CPEPJDBBKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		internal Task<FNDPEECNEPD> MOMJIBIMHKB(DKKFAAJNJJM<string>.BNLIHIFJPDL _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct MOIDOHLNNGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public GCGPBOIBBAJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public BEBFLBECFCJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CPEPJDBBKBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private JFJKIGGENDI <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private OGBIDEAJDEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private DIADNJMIGGJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private Task<Matchmaking.MOEIHPIFPHA> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private NMLOPDGIGMC <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<Matchmaking.MOEIHPIFPHA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<FNDPEECNEPD> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x87D8280", Offset = "0x87D6A80", VA = "0x1887D8280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x87DDBD0", Offset = "0x87DC3D0", VA = "0x1887DDBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KIECBBINNBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task<FNDPEECNEPD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KIECBBINNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		internal Task<FNDPEECNEPD> JNOPNFEEKJN(DKKFAAJNJJM<string>.BNLIHIFJPDL _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct MKBHDHEOLHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public GCGPBOIBBAJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public BEBFLBECFCJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private JFJKIGGENDI <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private OGBIDEAJDEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private DIADNJMIGGJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private Task<Matchmaking.MOEIHPIFPHA> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private FNDPEECNEPD <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private FNAKEBMBAOD <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<FNDPEECNEPD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private NMLOPDGIGMC <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private IDHNMEIGPID <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private FDNEDNLHGAA <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter<AKNNNGCPBLB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter<Matchmaking.MOEIHPIFPHA> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x87F6610", Offset = "0x87F4E10", VA = "0x1887F6610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x87FBC60", Offset = "0x87FA460", VA = "0x1887FBC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct MMIFBNKMHNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x87FBCC0", Offset = "0x87FA4C0", VA = "0x1887FBCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x87FC720", Offset = "0x87FAF20", VA = "0x1887FC720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct OHFNHCDCGJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private OIKNHNBNAFI <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8800110", Offset = "0x87FE910", VA = "0x188800110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8800590", Offset = "0x87FED90", VA = "0x188800590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct GNLIPOGFMBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder<Matchmaking.MOEIHPIFPHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TaskAwaiter<Matchmaking.MOEIHPIFPHA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x87ED3C0", Offset = "0x87EBBC0", VA = "0x1887ED3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x87ED890", Offset = "0x87EC090", VA = "0x1887ED890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct JGCPHIINPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Matchmaking.MOEIHPIFPHA serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public BEBFLBECFCJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<AABDNGHDBOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x87EFE90", Offset = "0x87EE690", VA = "0x1887EFE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x87F04D0", Offset = "0x87EECD0", VA = "0x1887F04D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class BGCGCJOINOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BGCGCJOINOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x87E5340", Offset = "0x87E3B40", VA = "0x1887E5340")]
		internal object KKAJNKEKHIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x87E5440", Offset = "0x87E3C40", VA = "0x1887E5440")]
		internal string MNDBDJIABOC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct LAHCDBBNCLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private BGCGCJOINOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x87F2650", Offset = "0x87F0E50", VA = "0x1887F2650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x87F31E0", Offset = "0x87F19E0", VA = "0x1887F31E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct GCKEHKIOHDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public BEBFLBECFCJ joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public FNDPEECNEPD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public LOAOCAFLNEN targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FNAKEBMBAOD preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public JFJKIGGENDI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x87EBE30", Offset = "0x87EA630", VA = "0x1887EBE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x87EC620", Offset = "0x87EAE20", VA = "0x1887EC620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct LBALOHIDCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private OGBIDEAJDEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private OGBIDEAJDEB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x87F3240", Offset = "0x87F1A40", VA = "0x1887F3240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x87F4A20", Offset = "0x87F3220", VA = "0x1887F4A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct EMEDCBHMFKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public BAMAEEMHEMC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public MIGJHEBNDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter<AKIGBGIOJEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x87E9A10", Offset = "0x87E8210", VA = "0x1887E9A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x87EA200", Offset = "0x87E8A00", VA = "0x1887EA200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class EOPMLDBIMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EOPMLDBIMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x87EA440", Offset = "0x87E8C40", VA = "0x1887EA440")]
		internal object ALAHHJMEKKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class JEDNNBPBGPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JEDNNBPBGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x87EFDF0", Offset = "0x87EE5F0", VA = "0x1887EFDF0")]
		internal void OODHMBHKGKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class OMJKMOHPPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OMJKMOHPPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x88005F0", Offset = "0x87FEDF0", VA = "0x1888005F0")]
		internal object CFOJKGHJIOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class KMDOKAFCJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KMDOKAFCJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x87F2550", Offset = "0x87F0D50", VA = "0x1887F2550")]
		internal string FEOHFAIGCAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly BMELPJIFPCL GDLOPJFEEOL;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly BMELPJIFPCL MGHHGAAMLFE;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly BMELPJIFPCL AJGIIMGHLHP;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly string CCCFLLCDELI;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly string EKGOOFFFFDF;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly string AEGHMDCBBLM;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly Guid BEJHKCPJNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private PPOCKLEIMOO BDNIHLNLANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private ILBAAIEHPBH HLCPJCICGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private EEFLELAHAOG BPBBIAFOCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private HJABLGDBPEI KAMDGLOAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private OKPHNFNFFAF CGEDDGPEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private FILOJONJOBN MEIBPHMNOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private IEEECBLGMDK BBPCOFHIAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private IDisposable OHBPNFPMNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private LNINKDJALGH AJOOINMMHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly JHEECHAOLLM ANOKLNONGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NMLOPDGIGMC BJPBLJDEFCK;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus BDMKABPIJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA50730", Offset = "0xA4EF30", VA = "0x180A50730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x13E94D0", Offset = "0x13E7CD0", VA = "0x1813E94D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87D6420", Offset = "0x87D4C20", VA = "0x1887D6420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x87D5FF0", Offset = "0x87D47F0", VA = "0x1887D5FF0", Slot = "6")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x87D54F0", Offset = "0x87D3CF0", VA = "0x1887D54F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x87D4590", Offset = "0x87D2D90", VA = "0x1887D4590", Slot = "5")]
	[AsyncStateMachine(typeof(EAOHDMBNCKD))]
	public Task BJDEKMFFBEN(LOAOCAFLNEN DJHGIPODCBJ, GCGPBOIBBAJ CFGIFCEABDC, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x87D70F0", Offset = "0x87D58F0", VA = "0x1887D70F0")]
	[AsyncStateMachine(typeof(KBNBMLLKNKK))]
	private Task PBNNGBLLDND(LOAOCAFLNEN DJHGIPODCBJ, GCGPBOIBBAJ CFGIFCEABDC, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x87D5990", Offset = "0x87D4190", VA = "0x1887D5990")]
	private void HIGMJLILNIK(FILOJONJOBN MEIBPHMNOEH, LOAOCAFLNEN DJHGIPODCBJ, Exception FKONJEEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x87D4C20", Offset = "0x87D3420", VA = "0x1887D4C20")]
	private static void DGGKGEPEJPA(ONMBGPCKGJP KCHDFPBCGAO, Exception FKONJEEEEJA, [Optional] List<int> DPKKKFOAGGJ, int AJAFFHPGNCK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x87D43D0", Offset = "0x87D2BD0", VA = "0x1887D43D0")]
	[AsyncStateMachine(typeof(MOIDOHLNNGA))]
	private Task AJFECCJFFME(DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, LOAOCAFLNEN DJHGIPODCBJ, GCGPBOIBBAJ CFGIFCEABDC, BEBFLBECFCJ FPIIGDKDJOD, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x87D4040", Offset = "0x87D2840", VA = "0x1887D4040")]
	[AsyncStateMachine(typeof(MKBHDHEOLHM))]
	private Task ABLMBMJJCMI(DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, LOAOCAFLNEN DJHGIPODCBJ, GCGPBOIBBAJ CFGIFCEABDC, BEBFLBECFCJ FPIIGDKDJOD, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x87D4AA0", Offset = "0x87D32A0", VA = "0x1887D4AA0")]
	private void CNHBLKKFHIM([CallerMemberName] string PBCAHPBAEKA = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x87D41A0", Offset = "0x87D29A0", VA = "0x1887D41A0")]
	[AsyncStateMachine(typeof(MMIFBNKMHNP))]
	private Task AEGEODFFGEN(DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x87D7500", Offset = "0x87D5D00", VA = "0x1887D7500")]
	private void PMGPDGALNOB(LOAOCAFLNEN DJHGIPODCBJ, CancellationToken DGACCOBPOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x87D72A0", Offset = "0x87D5AA0", VA = "0x1887D72A0")]
	private void PJPFEKDPDIG(LOAOCAFLNEN DJHGIPODCBJ, TaskStatus ANJMMNAPMHH, string ILBALOOKKCP, BEBFLBECFCJ FPIIGDKDJOD, Exception COLJEFDGCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x87D5540", Offset = "0x87D3D40", VA = "0x1887D5540")]
	private void EAEFGGFLKHH(LOAOCAFLNEN DJHGIPODCBJ, BEBFLBECFCJ FPIIGDKDJOD, OperationCanceledException FAAPJKEEEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x87D6310", Offset = "0x87D4B10", VA = "0x1887D6310")]
	private void IMOOPFFHMEM(LOAOCAFLNEN DJHGIPODCBJ, BEBFLBECFCJ FPIIGDKDJOD, Exception FKONJEEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x87D5DE0", Offset = "0x87D45E0", VA = "0x1887D5DE0")]
	private void HLOEDGNOHGE(LOAOCAFLNEN DJHGIPODCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x87D4530", Offset = "0x87D2D30", VA = "0x1887D4530")]
	private static FPBLLGEBKEJ AMNALPKDGGN(LOAOCAFLNEN DJHGIPODCBJ)
	{
		return default(FPBLLGEBKEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x87D6F10", Offset = "0x87D5710", VA = "0x1887D6F10")]
	[AsyncStateMachine(typeof(OHFNHCDCGJD))]
	private Task NNHHNAPLMBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x87D6640", Offset = "0x87D4E40", VA = "0x1887D6640")]
	[AsyncStateMachine(typeof(GNLIPOGFMBF))]
	private Task<Matchmaking.MOEIHPIFPHA> LGMLKNJEACP(LOAOCAFLNEN DJHGIPODCBJ, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x87D6FE0", Offset = "0x87D57E0", VA = "0x1887D6FE0")]
	private static AABDNGHDBOD OKNANDOFICO(Matchmaking.MOEIHPIFPHA GLMIMBFMJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x87D6DC0", Offset = "0x87D55C0", VA = "0x1887D6DC0")]
	[AsyncStateMachine(typeof(JGCPHIINPIP))]
	private Task NCBFMOMHCNH(Matchmaking.MOEIHPIFPHA GLMIMBFMJFL, BEBFLBECFCJ FPIIGDKDJOD, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken LDELJMOBLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x87D46D0", Offset = "0x87D2ED0", VA = "0x1887D46D0")]
	[AsyncStateMachine(typeof(LAHCDBBNCLB))]
	private Task CCFBFBGKPLM(LOAOCAFLNEN DJHGIPODCBJ, CancellationTokenSource LEIFMILELJF, Task CNDAGJIDPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x87D4920", Offset = "0x87D3120", VA = "0x1887D4920")]
	[AsyncStateMachine(typeof(GCKEHKIOHDG))]
	private Task CKAENFDMHOE(FNDPEECNEPD CNNILMMCNMN, JFJKIGGENDI CJHEENINGML, LOAOCAFLNEN GHIDBNNDKMH, BEBFLBECFCJ DBCJFEGNPBG, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GHNDBHMJKJH, [Optional] FNAKEBMBAOD FDAFEEIOCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x87D67A0", Offset = "0x87D4FA0", VA = "0x1887D67A0")]
	private BEBFLBECFCJ LMNEABIDJKP(BEBFLBECFCJ DBCJFEGNPBG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x87D6500", Offset = "0x87D4D00", VA = "0x1887D6500")]
	[AsyncStateMachine(typeof(LBALOHIDCJN))]
	private Task KPCPNKKIDCA(DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x87D55C0", Offset = "0x87D3DC0", VA = "0x1887D55C0")]
	[AsyncStateMachine(typeof(EMEDCBHMFKJ))]
	private Task EAJKJIFMLHD(CancellationToken GMEAHOBHMAD, int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x87D69F0", Offset = "0x87D51F0", VA = "0x1887D69F0")]
	private static void MIPBPHHAPGG(LOAOCAFLNEN DJHGIPODCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x87D6B70", Offset = "0x87D5370", VA = "0x1887D6B70")]
	private void MKNIBNMKDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x87D6470", Offset = "0x87D4C70", VA = "0x1887D6470")]
	private void KMFCLIAFLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x87D6390", Offset = "0x87D4B90", VA = "0x1887D6390")]
	private void JFBGCEPGAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x87D5460", Offset = "0x87D3C60", VA = "0x1887D5460")]
	private void DLPCEFHNMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x87D58A0", Offset = "0x87D40A0", VA = "0x1887D58A0")]
	private static void FAPGKNACANC(LOAOCAFLNEN DJHGIPODCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x87D4810", Offset = "0x87D3010", VA = "0x1887D4810")]
	private static CancellationTokenRegistration CFGOLNFKLDK(LOAOCAFLNEN DJHGIPODCBJ, CancellationToken LDELJMOBLDL)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x87D42D0", Offset = "0x87D2AD0", VA = "0x1887D42D0")]
	private static void AHNHODBKJBF(LOAOCAFLNEN DJHGIPODCBJ, Exception FKONJEEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x87D56F0", Offset = "0x87D3EF0", VA = "0x1887D56F0")]
	private void EPPLKPCLDEE(LOAOCAFLNEN DJHGIPODCBJ, Task CNDAGJIDPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x87D6990", Offset = "0x87D5190", VA = "0x1887D6990")]
	private static void MIHGFEDHECA(Func<string> INDBGIPGMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x87D7A30", Offset = "0x87D6230", VA = "0x1887D7A30")]
	public MIGJHEBNDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x87D7240", Offset = "0x87D5A40", VA = "0x1887D7240")]
	[CompilerGenerated]
	internal static (int, int?) PJKFALLADEM(HLCLCOKBABM ALIHNDLFCFH)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RecRoom.NoEngine.Common.Preserve]
internal class HENIADGCDPE : OFIJFBKPKIO, GDBDNONDKIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct GHAIPGPNPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public HENIADGCDPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public BAMAEEMHEMC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x87EC6E0", Offset = "0x87EAEE0", VA = "0x1887EC6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x87ECBC0", Offset = "0x87EB3C0", VA = "0x1887ECBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class FEMGLBJJJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public HENIADGCDPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public BAMAEEMHEMC localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FEMGLBJJJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x87EAE70", Offset = "0x87E9670", VA = "0x1887EAE70")]
		internal List<Task> PHHPDHNIGMB(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct EJOLCKGKADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public KCPCPABECLA taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public BAMAEEMHEMC localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x87E9560", Offset = "0x87E7D60", VA = "0x1887E9560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x87E9900", Offset = "0x87E8100", VA = "0x1887E9900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct CPCGPLKDGLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public HENIADGCDPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x87E9060", Offset = "0x87E7860", VA = "0x1887E9060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x87E9340", Offset = "0x87E7B40", VA = "0x1887E9340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly HashSet<KCPCPABECLA> EFNNBAMJFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private ILBAAIEHPBH HLCPJCICGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private AHFDHLNPAAB EIGPDFEJMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private HOPHMJJAJJG PMOECBOMILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private IDisposable OHBPNFPMNGJ;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x87EE1B0", Offset = "0x87EC9B0", VA = "0x1887EE1B0", Slot = "5")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x87EDEE0", Offset = "0x87EC6E0", VA = "0x1887EDEE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x87EE490", Offset = "0x87ECC90", VA = "0x1887EE490", Slot = "4")]
	public bool ILNBMIDDDGE(KCPCPABECLA LNPPBGGLCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x87EE5C0", Offset = "0x87ECDC0", VA = "0x1887EE5C0")]
	private void KGMLEIFJAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x87EDCC0", Offset = "0x87EC4C0", VA = "0x1887EDCC0")]
	private void DIPPNELMOMJ(HDBLPJBDELH JPCNIAHCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x87EEB70", Offset = "0x87ED370", VA = "0x1887EEB70")]
	[AsyncStateMachine(typeof(GHAIPGPNPLL))]
	private Task OLNKDPIMLAK(int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x87EE0E0", Offset = "0x87EC8E0", VA = "0x1887EE0E0")]
	private Func<CancellationToken, List<Task>> GFOFIBAOEDL(int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x87EE690", Offset = "0x87ECE90", VA = "0x1887EE690")]
	private List<Task> MKPJGPLMKDM(int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x87EDF40", Offset = "0x87EC740", VA = "0x1887EDF40")]
	[AsyncStateMachine(typeof(EJOLCKGKADL))]
	private Task EAJBBOGJABA(KCPCPABECLA IPHFGIAOPLC, CancellationToken KAJENDFCCBJ, int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x87EE4F0", Offset = "0x87ECCF0", VA = "0x1887EE4F0")]
	[AsyncStateMachine(typeof(CPCGPLKDGLL))]
	private Task JBLKJMMGBAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x87EE060", Offset = "0x87EC860", VA = "0x1887EE060")]
	private void FBONGFMPKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x87EEC60", Offset = "0x87ED460", VA = "0x1887EEC60")]
	public HENIADGCDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[UnityEngine.Scripting.Preserve]
internal sealed class KCFGKJGBCGL : BGBOIJEKNFM, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class GHBAACHDADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GHBAACHDADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x87ECC20", Offset = "0x87EB420", VA = "0x1887ECC20")]
		internal object MOHHFDLIJHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class DKHFIFILNFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DKHFIFILNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x87E9410", Offset = "0x87E7C10", VA = "0x1887E9410")]
		internal object AFBAFHHGNCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class GNEINJJHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GNEINJJHMAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class GOIIKKIAKEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GOIIKKIAKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x87EDC60", Offset = "0x87EC460", VA = "0x1887EDC60")]
		internal object ADKKAAIKNKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class BEMPEOHAFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BEMPEOHAFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x87E52E0", Offset = "0x87E3AE0", VA = "0x1887E52E0")]
		internal object HNILOKMJGAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private readonly Dictionary<Guid, BPKKINMGHNG> AIKPHBKAPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly TimeSpan LCOOPPFKACC;

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "9")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x87F1440", Offset = "0x87EFC40", VA = "0x1887F1440", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x87F1450", Offset = "0x87EFC50", VA = "0x1887F1450", Slot = "4")]
	public ILMPMHDEJBN GGGBGBDKNKJ(Guid GKMDGNFGEOO)
	{
		return default(ILMPMHDEJBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x87F1670", Offset = "0x87EFE70", VA = "0x1887F1670", Slot = "5")]
	public bool HKOLMKDGPPH(Guid GKMDGNFGEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x87F1110", Offset = "0x87EF910", VA = "0x1887F1110", Slot = "6")]
	public bool AGALPFAJDLK(Guid GKMDGNFGEOO, Task EAPFHGLEBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x87F1B20", Offset = "0x87F0320", VA = "0x1887F1B20", Slot = "7")]
	public bool POPLIBLMCBL(Guid GKMDGNFGEOO, AKIGBGIOJEO DAKIBMJOMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x87F1880", Offset = "0x87F0080", VA = "0x1887F1880", Slot = "8")]
	public Task<(AKIGBGIOJEO, Task)> JIPOKIMICKM(Guid GKMDGNFGEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x87F18F0", Offset = "0x87F00F0", VA = "0x1887F18F0")]
	private void PDNICFHJCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x87F1D00", Offset = "0x87F0500", VA = "0x1887F1D00")]
	public KCFGKJGBCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[RecRoom.NoEngine.Common.Preserve]
internal class PJIMEBPBOOM : GLELJGKEICK, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class JPNMDIPGFMD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private readonly LOAOCAFLNEN LAIHINALNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly CancellationTokenSource JKCICFOHGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public readonly CancellationToken HHKMJGAKFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool IHOEHGEJCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private bool DMJNBPLABAL;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x87F1060", Offset = "0x87EF860", VA = "0x1887F1060")]
		public JPNMDIPGFMD(LOAOCAFLNEN LAIHINALNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x87F0F10", Offset = "0x87EF710", VA = "0x1887F0F10")]
		public void FBONGFMPKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x87F0EE0", Offset = "0x87EF6E0", VA = "0x1887F0EE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class NKEICDHFBJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public NCGNCPFHELC disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NKEICDHFBJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x87FDB30", Offset = "0x87FC330", VA = "0x1887FDB30")]
		internal object LAJHDEFKJMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct BCHJCMMCFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public NCGNCPFHELC disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public PJIMEBPBOOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x87E4E30", Offset = "0x87E3630", VA = "0x1887E4E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x87E5280", Offset = "0x87E3A80", VA = "0x1887E5280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class DHPCLNBAJPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public PJIMEBPBOOM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DHPCLNBAJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x87E93A0", Offset = "0x87E7BA0", VA = "0x1887E93A0")]
		internal object JPNFLKMMPCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class BLNEPFFJFED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public LOAOCAFLNEN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public DHPCLNBAJPC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BLNEPFFJFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x87E5BA0", Offset = "0x87E43A0", VA = "0x1887E5BA0")]
		internal object BGNGDKMAIMJ((LOAOCAFLNEN lastLocalPlayerRoomInstance, LOAOCAFLNEN newRoomInstance, EEFLELAHAOG fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct CDKHJMOAKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public PJIMEBPBOOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private OGBIDEAJDEB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x87E71C0", Offset = "0x87E59C0", VA = "0x1887E71C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class LHECOMLHDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public LOAOCAFLNEN newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LHECOMLHDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x87F5F30", Offset = "0x87F4730", VA = "0x1887F5F30")]
		internal object PHDEHJKFJIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x87F5E30", Offset = "0x87F4630", VA = "0x1887F5E30")]
		internal void BCBCCAGGDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x87F5EF0", Offset = "0x87F46F0", VA = "0x1887F5EF0")]
		internal object MMEAILBAALA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x87F5EB0", Offset = "0x87F46B0", VA = "0x1887F5EB0")]
		internal object MJKILCCHPJN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct BPGKBAKPPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public LOAOCAFLNEN newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public PJIMEBPBOOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public GCGPBOIBBAJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private LHECOMLHDBC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x87E5CC0", Offset = "0x87E44C0", VA = "0x1887E5CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x87E6C60", Offset = "0x87E5460", VA = "0x1887E6C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly DNIDNLHFGPB.KPDEEIHAHIJ ADCGCMNBBOA;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly LBMIHNICFPI FGONAEMPKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private ILBAAIEHPBH HLCPJCICGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private EEFLELAHAOG BPBBIAFOCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private GLCPPLLGKIP LDCOIJIBFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private FIJGONFDHGJ FAGEDOEFKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private LOAOCAFLNEN HBGGJPDKIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private JPNMDIPGFMD IJILHGEBJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool LMGOBKJKNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Task OELAPGBDFHH;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8802560", Offset = "0x8800D60", VA = "0x188802560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LPEFPDAIEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xCDDF70", Offset = "0xCDC770", VA = "0x180CDDF70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x88022C0", Offset = "0x8800AC0", VA = "0x1888022C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8802020", Offset = "0x8800820", VA = "0x188802020", Slot = "4")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8801D40", Offset = "0x8800540", VA = "0x188801D40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8802740", Offset = "0x8800F40", VA = "0x188802740")]
	[AsyncStateMachine(typeof(BCHJCMMCFBP))]
	private Task MHMIPHNHMAJ(NCGNCPFHELC GFLCIAHPGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8802A30", Offset = "0x8801230", VA = "0x188802A30")]
	private void PCIMJKPFJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x88025B0", Offset = "0x8800DB0", VA = "0x1888025B0")]
	private void KCGNDKBKAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8801B70", Offset = "0x8800370", VA = "0x188801B70")]
	private void BMFOFAGPEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8801EB0", Offset = "0x88006B0", VA = "0x188801EB0")]
	private bool FEJGBLMJLFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8802830", Offset = "0x8801030", VA = "0x188802830")]
	[AsyncStateMachine(typeof(CDKHJMOAKFL))]
	private void NBDHFLFKMDF(int FIOLDALLLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x88022D0", Offset = "0x8800AD0", VA = "0x1888022D0")]
	private void KADGJGBCIEP([Out] IDisposable EBKILOECOEL, [Out] IDisposable DHPKANDFLEB, [Out] IDisposable EMEBCBLPFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8801F20", Offset = "0x8800720", VA = "0x188801F20")]
	private bool FOLINCDENPH(LOAOCAFLNEN LAIHINALNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8801CF0", Offset = "0x88004F0", VA = "0x188801CF0")]
	private void DIKNPAJANNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8802900", Offset = "0x8801100", VA = "0x188802900")]
	[AsyncStateMachine(typeof(BPGKBAKPPKJ))]
	private Task PBNNGBLLDND(LOAOCAFLNEN LAIHINALNIM, GCGPBOIBBAJ CFGIFCEABDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8802F50", Offset = "0x8801750", VA = "0x188802F50")]
	public PJIMEBPBOOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[UnityEngine.Scripting.Preserve]
internal sealed class LCINKBGOAJA : HIGLOPGDPKP, GDBDNONDKIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct GNPENHOKPOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<PKPMCPGHFJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public LCINKBGOAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<PKPMCPGHFJB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x87ED900", Offset = "0x87EC100", VA = "0x1887ED900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x87EDB90", Offset = "0x87EC390", VA = "0x1887EDB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GNPFDLPPCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EMOHKBNEAPF message;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GNPFDLPPCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x87EDC00", Offset = "0x87EC400", VA = "0x1887EDC00")]
		internal object PKIMKNCCEDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HGILKLPBLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public EMOHKBNEAPF messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HGILKLPBLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x87EECF0", Offset = "0x87ED4F0", VA = "0x1887EECF0")]
		internal object MPOINKLHMJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class MPAFPNPHBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MPAFPNPHBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x87FD300", Offset = "0x87FBB00", VA = "0x1887FD300")]
		internal object HMGOGNOJJNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct PBGBIENBKEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public LCINKBGOAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private TaskAwaiter<FBBNOBMBACD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8801240", Offset = "0x87FFA40", VA = "0x188801240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8801B10", Offset = "0x8800310", VA = "0x188801B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class NOBAECMIJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public EMOHKBNEAPF operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NOBAECMIJPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x87FDBC0", Offset = "0x87FC3C0", VA = "0x1887FDBC0")]
		internal object GHFPEIEBCNC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct OOEHBJPKPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public EMOHKBNEAPF operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public LCINKBGOAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private BEBFLBECFCJ <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8800670", Offset = "0x87FEE70", VA = "0x188800670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x88011E0", Offset = "0x87FF9E0", VA = "0x1888011E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct MOCLDILMBDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<FBBNOBMBACD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public LCINKBGOAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private AFAPFGHCIDB.OFPGELMEJLI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private BEBFLBECFCJ <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x87FCD60", Offset = "0x87FB560", VA = "0x1887FCD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x87FD290", Offset = "0x87FBA90", VA = "0x1887FD290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class ECPPPIKKBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public FBBNOBMBACD operation;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ECPPPIKKBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x87E94E0", Offset = "0x87E7CE0", VA = "0x1887E94E0")]
		internal object IILIJBBNPNO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct KJBMPLIGKDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public FBBNOBMBACD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public LCINKBGOAJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private DKKFAAJNJJM<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x87F1EC0", Offset = "0x87F06C0", VA = "0x1887F1EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x87F24F0", Offset = "0x87F0CF0", VA = "0x1887F24F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class NHMGPPBAHPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NHMGPPBAHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x87FD360", Offset = "0x87FBB60", VA = "0x1887FD360")]
		internal object FFCJFLABPFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class GDGLACBHDGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GDGLACBHDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x87EC680", Offset = "0x87EAE80", VA = "0x1887EC680")]
		internal object KGDINGJDCEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private HJABLGDBPEI KAMDGLOAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private GAPJBOEFBCP CLDPEIPCDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private AFAONOHCBBF EJKOCOEFMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private TaskCompletionSource<PKPMCPGHFJB> CPBEBAJGPPK;

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x87F5670", Offset = "0x87F3E70", VA = "0x1887F5670", Slot = "7")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x87F5760", Offset = "0x87F3F60", VA = "0x1887F5760", Slot = "6")]
	[AsyncStateMachine(typeof(GNPENHOKPOB))]
	public Task<PKPMCPGHFJB> IGBCOLAOIJJ(CancellationToken BGFNBALAHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x87F4B90", Offset = "0x87F3390", VA = "0x1887F4B90", Slot = "4")]
	public void CPBLACLKILL(EMOHKBNEAPF ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x87F5870", Offset = "0x87F4070", VA = "0x1887F5870", Slot = "5")]
	public void JPOOBHBJAPL(EMOHKBNEAPF CEFBAGDOMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x87F4A80", Offset = "0x87F3280", VA = "0x1887F4A80")]
	[AsyncStateMachine(typeof(PBGBIENBKEL))]
	private Task BDPFOENIJFC(EMOHKBNEAPF FLPDPHNPDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x87F5D20", Offset = "0x87F4520", VA = "0x1887F5D20")]
	[AsyncStateMachine(typeof(OOEHBJPKPOE))]
	private Task NGFCLCPNCAA(EMOHKBNEAPF CEFJJINEKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x87F5BD0", Offset = "0x87F43D0", VA = "0x1887F5BD0")]
	[AsyncStateMachine(typeof(MOCLDILMBDD))]
	private Task<FBBNOBMBACD> MKOJHFPCFNP(EMOHKBNEAPF FLPDPHNPDPK, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x87F5040", Offset = "0x87F3840", VA = "0x1887F5040")]
	private BEBFLBECFCJ DKABHCFMLEF(EMOHKBNEAPF JPBGANLJNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x87F4F20", Offset = "0x87F3720", VA = "0x1887F4F20")]
	[AsyncStateMachine(typeof(KJBMPLIGKDI))]
	private Task DADEIDPCFMB(FBBNOBMBACD OPKHOBALIGI, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x87F5460", Offset = "0x87F3C60", VA = "0x1887F5460")]
	private FBBNOBMBACD HPHPMKHLAPJ(EMOHKBNEAPF FLPDPHNPDPK, BEBFLBECFCJ JMEJMAOHCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1820", Offset = "0x3AA0020", VA = "0x183AA1820")]
	private T NLKPKDBMNFC<T>(T MGONBEDEDON) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x87F50D0", Offset = "0x87F38D0", VA = "0x1887F50D0")]
	private FBBNOBMBACD GEIDKDOGFGO(EMOHKBNEAPF FLPDPHNPDPK, BEBFLBECFCJ JMEJMAOHCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LCINKBGOAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class NPAGMBOODKC : GAPJBOEFBCP, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class DPLCDAELPLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DPLCDAELPLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x87E9470", Offset = "0x87E7C70", VA = "0x1887E9470")]
		internal object FOKGHDPKDAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class FMCAHKCIDEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FMCAHKCIDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x87EB6B0", Offset = "0x87E9EB0", VA = "0x1887EB6B0")]
		internal object MCPIMGEECDO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private OGLGLBIBLMO FBCKHIOAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private HIGLOPGDPKP FJJKBMEJINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private BGBOIJEKNFM AIKPHBKAPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private BOLJILCGMIK KFGOGNENPAM;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x87FECD0", Offset = "0x87FD4D0", VA = "0x1887FECD0", Slot = "6")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x87FE1E0", Offset = "0x87FC9E0", VA = "0x1887FE1E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x87FE290", Offset = "0x87FCA90", VA = "0x1887FE290", Slot = "4")]
	public ILMPMHDEJBN FAICOLHJKEI(EMOHKBNEAPF GMJGODCJAPB)
	{
		return default(ILMPMHDEJBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x87FF0B0", Offset = "0x87FD8B0", VA = "0x1887FF0B0", Slot = "5")]
	public void KACALEANOAH(Guid GKMDGNFGEOO, Task EAPFHGLEBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x87FDC20", Offset = "0x87FC420", VA = "0x1887FDC20")]
	private void ACDKKNHNAGM(IIBEMPIBOEO CJJAIJHHKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x87FF510", Offset = "0x87FDD10", VA = "0x1887FF510")]
	private void MGMOGIFPALA(MJMABIBEGJJ NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x87FEE40", Offset = "0x87FD640", VA = "0x1887FEE40")]
	private void JGMHBOGDEHB(MJMABIBEGJJ NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x87FEA90", Offset = "0x87FD290", VA = "0x1887FEA90")]
	private void HGJLPMMMOGI(MJMABIBEGJJ NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x87FDF40", Offset = "0x87FC740", VA = "0x1887FDF40")]
	private AKIGBGIOJEO DJOLCDDMFLN(EMOHKBNEAPF JPBGANLJNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x87FE6B0", Offset = "0x87FCEB0", VA = "0x1887FE6B0")]
	private void GADOJLOIOBC(EMOHKBNEAPF CEFJJINEKOD, AKIGBGIOJEO DAKIBMJOMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x87FE8B0", Offset = "0x87FD0B0", VA = "0x1887FE8B0")]
	private bool HECBCMBHICH(EMOHKBNEAPF CEFJJINEKOD, AKIGBGIOJEO DAKIBMJOMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x87FDD30", Offset = "0x87FC530", VA = "0x1887FDD30")]
	private bool AHHCKECKPCN(EMOHKBNEAPF GGHGGOBJJJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x87FF2C0", Offset = "0x87FDAC0", VA = "0x1887FF2C0")]
	private bool LMMOMMLPLKH(byte IDIIIALCIOG, ExitGames.Client.Photon.Hashtable NPLHFNMEMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NPAGMBOODKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class BPOGLADAJFB : KFDFEJKCABK, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class NILNKEJHFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public PKPMCPGHFJB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public BPOGLADAJFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public EMOHKBNEAPF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NILNKEJHFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x87FD3C0", Offset = "0x87FBBC0", VA = "0x1887FD3C0")]
		internal object GOCNGDMCOKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x87FD430", Offset = "0x87FBC30", VA = "0x1887FD430")]
		internal object MDOLMPPFGCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct FOCMCACBBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public BPOGLADAJFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public EMOHKBNEAPF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<AKIGBGIOJEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x87EB720", Offset = "0x87E9F20", VA = "0x1887EB720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x87EBDC0", Offset = "0x87EA5C0", VA = "0x1887EBDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class JHBBFNNDDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public PKPMCPGHFJB operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JHBBFNNDDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x87F0530", Offset = "0x87EED30", VA = "0x1887F0530")]
		internal object DMPOBEKGOLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class FDOJAKPCIPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FDOJAKPCIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x87EAD90", Offset = "0x87E9590", VA = "0x1887EAD90")]
		internal object FBDGDAMPOKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x87EAE00", Offset = "0x87E9600", VA = "0x1887EAE00")]
		internal object KCBKDMBNIEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x87EAD20", Offset = "0x87E9520", VA = "0x1887EAD20")]
		internal object DMKOAALEKON()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct JHPOGMCOFNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public BPOGLADAJFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private FDOJAKPCIPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private ILMPMHDEJBN <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private AKIGBGIOJEO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private TaskAwaiter<(AKIGBGIOJEO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x87F05A0", Offset = "0x87EEDA0", VA = "0x1887F05A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x87F0E70", Offset = "0x87EF670", VA = "0x1887F0E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private OGLGLBIBLMO FBCKHIOAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private GAPJBOEFBCP CLDPEIPCDPN;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x87E6FD0", Offset = "0x87E57D0", VA = "0x1887E6FD0", Slot = "5")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x87E6CC0", Offset = "0x87E54C0", VA = "0x1887E6CC0", Slot = "4")]
	[AsyncStateMachine(typeof(FOCMCACBBCC))]
	private Task<AKIGBGIOJEO> CMPIEHFJGFF(EMOHKBNEAPF JPBGANLJNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x87E6DE0", Offset = "0x87E55E0", VA = "0x1887E6DE0")]
	private bool IAJEMHDDEFJ(PKPMCPGHFJB GOAEPFPLNNI, [Out] AKIGBGIOJEO KJCFPPKBAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x87E7080", Offset = "0x87E5880", VA = "0x1887E7080")]
	[AsyncStateMachine(typeof(JHPOGMCOFNP))]
	private Task<AKIGBGIOJEO> KKNMKGIPILO(EMOHKBNEAPF FLPDPHNPDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BPOGLADAJFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class FKGOMLAPNMI : JKMJAAFFHDI, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct KEPHIFDBGPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public DOPHJNOBIJD ODJGFOEMEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public long HJFGFMLFIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public Guid? LLFICDNCHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public bool MIMILEICNLD;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct MIPDPDCIKCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<FNDPEECNEPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public FKGOMLAPNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<APAMIKOGBPP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<FNDPEECNEPD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x87F5FD0", Offset = "0x87F47D0", VA = "0x1887F5FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x87F65A0", Offset = "0x87F4DA0", VA = "0x1887F65A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class EJPGIODIEOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EJPGIODIEOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x87E9960", Offset = "0x87E8160", VA = "0x1887E9960")]
		internal object OMOAKCFHEMO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct EPGOPMPBMHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<APAMIKOGBPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public FKGOMLAPNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private EJPGIODIEOD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private TaskAwaiter<APAMIKOGBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x87EA610", Offset = "0x87E8E10", VA = "0x1887EA610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x87EAC00", Offset = "0x87E9400", VA = "0x1887EAC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct MNLCOCNIMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public AsyncTaskMethodBuilder<FNDPEECNEPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public FKGOMLAPNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public APAMIKOGBPP roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<KEPHIFDBGPE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x87FC780", Offset = "0x87FAF80", VA = "0x1887FC780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x87FCCF0", Offset = "0x87FB4F0", VA = "0x1887FCCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class EMHFGBKCMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public APAMIKOGBPP roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EMHFGBKCMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xEF4A90", Offset = "0xEF3290", VA = "0x180EF4A90")]
		internal bool CAKNDPHAHCC(NKDJCGCAECB sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x87EA2F0", Offset = "0x87E8AF0", VA = "0x1887EA2F0")]
		internal object LELLAMAEJAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x87EA260", Offset = "0x87E8A60", VA = "0x1887EA260")]
		internal object KMGEHFKONIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x87EA3B0", Offset = "0x87E8BB0", VA = "0x1887EA3B0")]
		internal object MFCNBAPPHJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class KFGJCODGFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public EMHFGBKCMMG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KFGJCODGFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x87F1DC0", Offset = "0x87F05C0", VA = "0x1887F1DC0")]
		internal object BECALAGCOAL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct ICCPOLPBPCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder<KEPHIFDBGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public APAMIKOGBPP roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public FKGOMLAPNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public LOAOCAFLNEN targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private KFGJCODGFIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private TaskAwaiter<KEPHIFDBGPE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter<JNMEENHOMDP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x87EED50", Offset = "0x87ED550", VA = "0x1887EED50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x87EFCE0", Offset = "0x87EE4E0", VA = "0x1887EFCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class EPKECGCCJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EPKECGCCJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x87EAC70", Offset = "0x87E9470", VA = "0x1887EAC70")]
		internal object GOKKJCOGEBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct CFIEGILIIBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<KEPHIFDBGPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NKDJCGCAECB subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public FKGOMLAPNMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public LOAOCAFLNEN dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private EPKECGCCJIK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private TaskAwaiter<NJEJHBFOBPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x87E8930", Offset = "0x87E7130", VA = "0x1887E8930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x87E8FF0", Offset = "0x87E77F0", VA = "0x1887E8FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private GLCPPLLGKIP LDCOIJIBFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private BKBJCAOLAHJ ILCNPPALGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private HJKJLEGOOPN IKLEBCJPOML;

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x87EB2F0", Offset = "0x87E9AF0", VA = "0x1887EB2F0", Slot = "5")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x87EB550", Offset = "0x87E9D50", VA = "0x1887EB550", Slot = "4")]
	[AsyncStateMachine(typeof(MIPDPDCIKCB))]
	public Task<FNDPEECNEPD> MBLPMJEFPNE(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, LOAOCAFLNEN DJHGIPODCBJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x87EB190", Offset = "0x87E9990", VA = "0x1887EB190")]
	[AsyncStateMachine(typeof(EPGOPMPBMHJ))]
	private Task<APAMIKOGBPP> DDOJADALEOC(LOAOCAFLNEN DJHGIPODCBJ, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x87EB020", Offset = "0x87E9820", VA = "0x1887EB020")]
	[AsyncStateMachine(typeof(MNLCOCNIMHC))]
	private Task<FNDPEECNEPD> BCKPOBJDBKJ(LOAOCAFLNEN DJHGIPODCBJ, APAMIKOGBPP CGHNFDIDPDG, long PALELGDJJCI, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x87EB3E0", Offset = "0x87E9BE0", VA = "0x1887EB3E0")]
	[AsyncStateMachine(typeof(ICCPOLPBPCM))]
	private Task<KEPHIFDBGPE> LPPFDDJHDFB(LOAOCAFLNEN DJHGIPODCBJ, APAMIKOGBPP CGHNFDIDPDG, long PALELGDJJCI, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x87EAEB0", Offset = "0x87E96B0", VA = "0x1887EAEB0")]
	[AsyncStateMachine(typeof(CFIEGILIIBL))]
	private Task<KEPHIFDBGPE> ALBLOIEMKHE(LOAOCAFLNEN PHLDPMMDCPH, NKDJCGCAECB BKAEBHHHGHD, long PALELGDJJCI, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FKGOMLAPNMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class GHDDLJCIAOF : AFAONOHCBBF, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class BLOHGFCBGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BLOHGFCBGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x87E5C60", Offset = "0x87E4460", VA = "0x1887E5C60")]
		internal object NEGDKEADNDJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct OFEPAOEMNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public GHDDLJCIAOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public BEBFLBECFCJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x87FFA90", Offset = "0x87FE290", VA = "0x1887FFA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x88000A0", Offset = "0x87FE8A0", VA = "0x1888000A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct BIPECBFOFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public GHDDLJCIAOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public BEBFLBECFCJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private TaskAwaiter<FEGFJFNFCGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x87E5540", Offset = "0x87E3D40", VA = "0x1887E5540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x87E5B30", Offset = "0x87E4330", VA = "0x1887E5B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class IEKOPHOEJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IEKOPHOEJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x87EFD50", Offset = "0x87EE550", VA = "0x1887EFD50")]
		internal object HLJFIDLMFOM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct AGLDECINIGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public EMOHKBNEAPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public GHDDLJCIAOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public BEBFLBECFCJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private HEIDFJHKPNC <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private CHJPIHLEFJC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private TaskAwaiter<FEGFJFNFCGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x87E41D0", Offset = "0x87E29D0", VA = "0x1887E41D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x87E4DC0", Offset = "0x87E35C0", VA = "0x1887E4DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private HNENONAPKCB OLBCCBNNOEL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private AODBFAEMBPL KAEICOOFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x87ED070", Offset = "0x87EB870", VA = "0x1887ED070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x87ED1E0", Offset = "0x87EB9E0", VA = "0x1887ED1E0", Slot = "8")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x87ECDB0", Offset = "0x87EB5B0", VA = "0x1887ECDB0", Slot = "4")]
	[AsyncStateMachine(typeof(OFEPAOEMNKA))]
	public Task<EMOHKBNEAPF> DMGHIKFOFCN(EMOHKBNEAPF FLPDPHNPDPK, BEBFLBECFCJ JMEJMAOHCJF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x87ED270", Offset = "0x87EBA70", VA = "0x1887ED270", Slot = "5")]
	[AsyncStateMachine(typeof(BIPECBFOFAE))]
	public Task<EMOHKBNEAPF> PNBJOFMNKOM(CancellationToken GMEAHOBHMAD, BEBFLBECFCJ JMEJMAOHCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x87ED130", Offset = "0x87EB930", VA = "0x1887ED130", Slot = "6")]
	public PFGLBMLEAGJ HOCOPJEJJFC(FBBNOBMBACD HBIBIPNFAIK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x87ECC80", Offset = "0x87EB480", VA = "0x1887ECC80", Slot = "7")]
	public PFGLBMLEAGJ CJLDGGMJMGA(FBBNOBMBACD HBIBIPNFAIK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x87ECF10", Offset = "0x87EB710", VA = "0x1887ECF10")]
	[AsyncStateMachine(typeof(AGLDECINIGA))]
	private Task<EMOHKBNEAPF> FPFFIHKNDOC(EMOHKBNEAPF FLPDPHNPDPK, BEBFLBECFCJ JMEJMAOHCJF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1E70", Offset = "0x3BA0670", VA = "0x183BA1E70")]
	private static byte[] KOHFDHBDPGK(EMOHKBNEAPF ILBALOOKKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GHDDLJCIAOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[UnityEngine.Scripting.Preserve]
internal sealed class NJEFMGHOGPA : OGLGLBIBLMO, GDBDNONDKIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private HJEBBLBMFCN PAHHKJDMIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private HJABLGDBPEI KAMDGLOAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private PGFIKCCMAPF PIJLIMPDCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private FIJGONFDHGJ FAGEDOEFKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private OFIJFBKPKIO PAHBMKFELFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private GLCPPLLGKIP LDCOIJIBFHA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x87FD860", Offset = "0x87FC060", VA = "0x1887FD860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static AKIGBGIOJEO BNFFGAJIILO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x87FD560", Offset = "0x87FBD60", VA = "0x1887FD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x87FD6F0", Offset = "0x87FBEF0", VA = "0x1887FD6F0", Slot = "6")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x87FD570", Offset = "0x87FBD70", VA = "0x1887FD570", Slot = "4")]
	public AKIGBGIOJEO FCGNKJPCFGL(EIGONBNGIIK MDCMCPMGEHH, PKPMCPGHFJB HFFJJCGAECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x87FD8B0", Offset = "0x87FC0B0", VA = "0x1887FD8B0", Slot = "5")]
	public AKIGBGIOJEO NDJIGIBMBHA(EIGONBNGIIK NGHKAKJAOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x87FD6E0", Offset = "0x87FBEE0", VA = "0x1887FD6E0")]
	private static AKIGBGIOJEO HODDGEJGNDF(NODABIEMGKL BEPEOMJMPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NJEFMGHOGPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class JDPGAAGBGBP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x87EFDB0", Offset = "0x87EE5B0", VA = "0x1887EFDB0")]
	public JDPGAAGBGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x79B7970", Offset = "0x79B6170", VA = "0x1879B7970")]
	public JDPGAAGBGBP(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[UnityEngine.Scripting.Preserve]
internal sealed class PDDEPHLHCBG : PHKHLEMNFND, GDBDNONDKIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct INLOIKFLEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public PMABMGLDFHF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private DKKFAAJNJJM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private ILGDNHKPNBB <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter<AKIGBGIOJEO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x8810A40", Offset = "0x880F240", VA = "0x188810A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8811410", Offset = "0x880FC10", VA = "0x188811410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct NEFFBEGKNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x8817210", Offset = "0x8815A10", VA = "0x188817210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8817950", Offset = "0x8816150", VA = "0x188817950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct IIFCAMKLAMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x880E110", Offset = "0x880C910", VA = "0x18880E110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x880E620", Offset = "0x880CE20", VA = "0x18880E620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct GHAILDBCFJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x880BD80", Offset = "0x880A580", VA = "0x18880BD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x880C530", Offset = "0x880AD30", VA = "0x18880C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct NNFFMKMPCEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8818F60", Offset = "0x8817760", VA = "0x188818F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x8819100", Offset = "0x8817900", VA = "0x188819100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct EIJMNNHPAMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8806D90", Offset = "0x8805590", VA = "0x188806D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x88074A0", Offset = "0x8805CA0", VA = "0x1888074A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GEBNCKNFDIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8809D10", Offset = "0x8808510", VA = "0x188809D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x880A180", Offset = "0x8808980", VA = "0x18880A180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct LNMDHACINKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public PDDEPHLHCBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public DKLOHHBNKIG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private DKKFAAJNJJM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8813630", Offset = "0x8811E30", VA = "0x188813630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8813BD0", Offset = "0x88123D0", VA = "0x188813BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private AFAONOHCBBF EJKOCOEFMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private HJABLGDBPEI KAMDGLOAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private OFIJFBKPKIO PAHBMKFELFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private CancellationTokenSource HKHEIDELHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Task CINMBMLBCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private TaskCompletionSource<int> CMMMFCCGAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private int ENNHGKLOPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private int MHGFDECKMIC;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x881BFA0", Offset = "0x881A7A0", VA = "0x18881BFA0", Slot = "6")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x13C5400", Offset = "0x13C3C00", VA = "0x1813C5400", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x881B5A0", Offset = "0x8819DA0", VA = "0x18881B5A0")]
	private void BIBOKHCONKB(float DGJAEIEEPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x881C150", Offset = "0x881A950", VA = "0x18881C150", Slot = "4")]
	[AsyncStateMachine(typeof(INLOIKFLEKE))]
	public Task<AKIGBGIOJEO> KIHKCADGJON(PMABMGLDFHF KOKHFAJAONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x881BEB0", Offset = "0x881A6B0", VA = "0x18881BEB0", Slot = "5")]
	[AsyncStateMachine(typeof(NEFFBEGKNFC))]
	public Task HOCHKPKNBGI([Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x13C5400", Offset = "0x13C3C00", VA = "0x1813C5400")]
	public void GBAACFIJJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x881BC80", Offset = "0x881A480", VA = "0x18881BC80")]
	private ILGDNHKPNBB HFLFLECHONF(PMABMGLDFHF KOKHFAJAONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x881C580", Offset = "0x881AD80", VA = "0x18881C580")]
	[AsyncStateMachine(typeof(IIFCAMKLAMF))]
	private Task PPIJOCMGHPP(CancellationToken DGACCOBPOIM, int EKLJJBPPMCM, BAMAEEMHEMC HBKMCFDKJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x881B900", Offset = "0x881A100", VA = "0x18881B900")]
	[AsyncStateMachine(typeof(GHAILDBCFJG))]
	private Task DAIJIDIKIMA(CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x881B810", Offset = "0x881A010", VA = "0x18881B810")]
	[AsyncStateMachine(typeof(NNFFMKMPCEN))]
	private Task CPKFCKMDOPP([Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x881C380", Offset = "0x881AB80", VA = "0x18881C380")]
	[AsyncStateMachine(typeof(EIJMNNHPAMB))]
	private Task NAHBOOPBDFB(CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x881C280", Offset = "0x881AA80", VA = "0x18881C280")]
	[AsyncStateMachine(typeof(GEBNCKNFDIF))]
	private Task MLLEIPFLNDD(CancellationToken IJJKPFNKBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x881B680", Offset = "0x8819E80", VA = "0x18881B680")]
	private Task CMFCOIAIGNI(DKLOHHBNKIG LNIKDKIPDBJ, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x881C470", Offset = "0x881AC70", VA = "0x18881C470")]
	[AsyncStateMachine(typeof(LNMDHACINKM))]
	private Task OCLGKKCABPP(DKLOHHBNKIG LNIKDKIPDBJ, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x881BA00", Offset = "0x881A200", VA = "0x18881BA00")]
	private bool GPKIBGOACAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PDDEPHLHCBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[UnityEngine.Scripting.Preserve]
internal class GGCHIAJEKAA : PGFIKCCMAPF, GDBDNONDKIG, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct PMOECHIBCGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public GGCHIAJEKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private DKKFAAJNJJM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x881ED60", Offset = "0x881D560", VA = "0x18881ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x881F310", Offset = "0x881DB10", VA = "0x18881F310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private JJCPPGOLFEC NEPFHOEEIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private OGLGLBIBLMO FBCKHIOAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	private AFAONOHCBBF EJKOCOEFMOF;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x880BAA0", Offset = "0x880A2A0", VA = "0x18880BAA0", Slot = "6")]
	public void IEAMPCKAMFG(GBCNJFGJIEN KFBGJKCPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x880B8B0", Offset = "0x880A0B0", VA = "0x18880B8B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x880B7B0", Offset = "0x8809FB0", VA = "0x18880B7B0", Slot = "5")]
	[AsyncStateMachine(typeof(PMOECHIBCGN))]
	public Task ACBHHMNJACG(string KBIHAKCHLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x880BA40", Offset = "0x880A240", VA = "0x18880BA40", Slot = "4")]
	public AKIGBGIOJEO GPKIBGOACAC(EIGONBNGIIK MDCMCPMGEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x880B900", Offset = "0x880A100", VA = "0x18880B900")]
	private IHPLEKGJLEG ELJFGIPNHPO(string KBIHAKCHLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GGCHIAJEKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class EEONPIECMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8806640", Offset = "0x8804E40", VA = "0x188806640")]
	public static void LAKLCJIHGJP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x88064E0", Offset = "0x8804CE0", VA = "0x1888064E0")]
	internal static void FMMNFJKBDDF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8806CB0", Offset = "0x88054B0", VA = "0x188806CB0")]
	internal static void PGBONDODHCD(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8806880", Offset = "0x8805080", VA = "0x188806880")]
	internal static void NNNJMAELLCO(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x38416A0", Offset = "0x383FEA0", VA = "0x1838416A0")]
	private static void IICALPLEKCG<Interface, Impl, Interface>(OIKNHNBNAFI MBKOPLBCEJA) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class PJJICFNLBGJ : GKGFBDPAEIB<EMOHKBNEAPF>
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class LAAPCPPCLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public EMOHKBNEAPF message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LAAPCPPCLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x8813270", Offset = "0x8811A70", VA = "0x188813270")]
		internal object DKGJCBDCPMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly PJJICFNLBGJ HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x881E8C0", Offset = "0x881D0C0", VA = "0x18881E8C0")]
	public ExitGames.Client.Photon.Hashtable GJCNJFECIPF(EMOHKBNEAPF ILBALOOKKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x881E4F0", Offset = "0x881CCF0", VA = "0x18881E4F0", Slot = "5")]
	protected override void BILMDPOKOGH(EMOHKBNEAPF ILBALOOKKCP, IDictionary<object, object> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x881EA60", Offset = "0x881D260", VA = "0x18881EA60", Slot = "6")]
	public override EMOHKBNEAPF OLFGCACBCKJ(IDictionary<object, object> IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x881E950", Offset = "0x881D150", VA = "0x18881E950")]
	private static void MIHGFEDHECA(string LMHFEGIMILF, EMOHKBNEAPF ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x881ED20", Offset = "0x881D520", VA = "0x18881ED20")]
	public PJJICFNLBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x881E620", Offset = "0x881CE20", VA = "0x18881E620")]
	[CompilerGenerated]
	internal static string FGDEJENANPL(FNDPEECNEPD OILJBDLKBKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class MPPGHONPAHN
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static AKIGBGIOJEO BNFFGAJIILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8816CF0", Offset = "0x88154F0", VA = "0x188816CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x88171F0", Offset = "0x88159F0", VA = "0x1888171F0")]
	public static bool LLKDJDAHFOJ(this AKIGBGIOJEO DAKIBMJOMIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8816F40", Offset = "0x8815740", VA = "0x188816F40")]
	public static AKIGBGIOJEO HODDGEJGNDF(NODABIEMGKL JEMMAJLOFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8816D50", Offset = "0x8815550", VA = "0x188816D50")]
	public static AKIGBGIOJEO EFOMEINDODG(IEnumerable<AKIGBGIOJEO> MCLMNPPAMLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x8816FA0", Offset = "0x88157A0", VA = "0x188816FA0")]
	public static string IOPHPPFIODC(this AKIGBGIOJEO KJCFPPKBAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class IPFCCGNHJBO : BPCLLIOINDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public delegate AKIGBGIOJEO DJFNDLJENDM([NotNull] EIGONBNGIIK OAAEEAIGGNG);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class AEOONDKMHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public EIGONBNGIIK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AEOONDKMHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1675870", Offset = "0x1674070", VA = "0x181675870")]
		internal AKIGBGIOJEO CKKPADCAMBP(DJFNDLJENDM v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	protected readonly HashSet<DJFNDLJENDM> DHHPABIKHEN;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8811760", Offset = "0x880FF60", VA = "0x188811760", Slot = "4")]
	public void EBJHCPDCBCH(DJFNDLJENDM KNOEBBONBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x88117C0", Offset = "0x880FFC0", VA = "0x1888117C0", Slot = "5")]
	public void HEEJADEINAL(DJFNDLJENDM KNOEBBONBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x8811710", Offset = "0x880FF10", VA = "0x188811710", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8811480", Offset = "0x880FC80", VA = "0x188811480")]
	protected AKIGBGIOJEO ANEPIKINAPO(EIGONBNGIIK NGHKAKJAOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8811820", Offset = "0x8810020", VA = "0x188811820")]
	protected IPFCCGNHJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class GIACCMCLMGH : IPFCCGNHJBO, HJEBBLBMFCN, BPCLLIOINDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class AEJANPJGCLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AKIGBGIOJEO result;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AEJANPJGCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8803820", Offset = "0x8802020", VA = "0x188803820")]
		internal object AFILDEKDCLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x880C6A0", Offset = "0x880AEA0", VA = "0x18880C6A0")]
	[UnityEngine.Scripting.Preserve]
	public GIACCMCLMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x880C590", Offset = "0x880AD90", VA = "0x18880C590", Slot = "8")]
	public AKIGBGIOJEO MDPBIAIHOBC(EIGONBNGIIK NGHKAKJAOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class KDKOPJADJEM : IPFCCGNHJBO, JJCPPGOLFEC, BPCLLIOINDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class IDHBDLJABGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AKIGBGIOJEO result;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IDHBDLJABGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x880D880", Offset = "0x880C080", VA = "0x18880D880")]
		internal object CNOEMMPLCEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x880C6A0", Offset = "0x880AEA0", VA = "0x18880C6A0")]
	[UnityEngine.Scripting.Preserve]
	public KDKOPJADJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8812FD0", Offset = "0x88117D0", VA = "0x188812FD0", Slot = "8")]
	public AKIGBGIOJEO GPKIBGOACAC(EIGONBNGIIK PCJIBHNFPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal static class PIIMLDPEEBB
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class NPOCILLCDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public DKKFAAJNJJM<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NPOCILLCDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8819900", Offset = "0x8818100", VA = "0x188819900")]
		internal object DLEEBJACDIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x881E410", Offset = "0x881CC10", VA = "0x18881E410")]
	public static DKKFAAJNJJM<string> KMKPJOFILBC(BMELPJIFPCL GLHOMCPEEHH, [Optional] string BCGEPAJNGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x881E350", Offset = "0x881CB50", VA = "0x18881E350")]
	public static void HBNOJNAMMGJ(DKKFAAJNJJM<string> PFLKFIDCFJL, BMELPJIFPCL GLHOMCPEEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x881E290", Offset = "0x881CA90", VA = "0x18881E290")]
	public static string AFBMJOHJAAG(EMOHKBNEAPF JPBGANLJNBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal static class HJNCOOJNLNE
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x880CA10", Offset = "0x880B210", VA = "0x18880CA10")]
	public static void FGGOBJPEONF(this KIFHCLNMNON FLIPFCGMCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x880CA20", Offset = "0x880B220", VA = "0x18880CA20")]
	public static void FIPHONPDJGF(this KIFHCLNMNON FLIPFCGMCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x880C8F0", Offset = "0x880B0F0", VA = "0x18880C8F0")]
	private static void CLPDOPCHAPF(this KIFHCLNMNON FLIPFCGMCOP, bool CCECGJFIFMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class HLAFNLPNEPI : EINHJDEHCCO, NDPGEKOEOMO, OGBKAHNOBEK, OCMCHKKDNBL
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[DefaultMember("Item")]
	private class FGLJJBFHBEO : IIBEMPIBOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private readonly byte EOKPMGGJEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly int OHCFIGMIAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly object KJFGAOFNDIH;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte GJKKOAKOCAM
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int DGFEGJFLMJP
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object DALPEALLFLO
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object NOJAFKJLFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x8808F00", Offset = "0x8807700", VA = "0x188808F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x79BF3C0", Offset = "0x79BDBC0", VA = "0x1879BF3C0")]
		public FGLJJBFHBEO(byte EOKPMGGJEMH, int OHCFIGMIAEM, object KJFGAOFNDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x8808F50", Offset = "0x8807750", VA = "0x188808F50", Slot = "8")]
		public bool PLBNMDLFKAN(byte MNMCNOJCKAF, [Out] object MGONBEDEDON)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly NDPGEKOEOMO KLGNHJHHNOL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public EIGONBNGIIK AAIEKHMDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x880D440", Offset = "0x880BC40", VA = "0x18880D440", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int EMFDHCEPDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x880CEC0", Offset = "0x880B6C0", VA = "0x18880CEC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int IIJBNKMEAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x880CBF0", Offset = "0x880B3F0", VA = "0x18880CBF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public EIGONBNGIIK HEIMHINEGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x880D490", Offset = "0x880BC90", VA = "0x18880D490", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool IHCLLIGFBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int IKFFONJFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA76E00", Offset = "0xA75600", VA = "0x180A76E00", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string CJGMCHMOACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x880D270", Offset = "0x880BA70", VA = "0x18880D270", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> GFOEAMLKCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x880D0D0", Offset = "0x880B8D0", VA = "0x18880D0D0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> BPKKKAIGFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<IIBEMPIBOEO> DOPODGBLLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x880CB40", Offset = "0x880B340", VA = "0x18880CB40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x880CF10", Offset = "0x880B710", VA = "0x18880CF10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> EJEPCCBJHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EIGONBNGIIK> NCFLGNMOMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action GFDMFONDBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x880CDC0", Offset = "0x880B5C0", VA = "0x18880CDC0", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x880CAA0", Offset = "0x880B2A0", VA = "0x18880CAA0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x880CE60", Offset = "0x880B660", VA = "0x18880CE60", Slot = "19")]
	public void EDIANKPHPNC(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xDA8C40", Offset = "0xDA7440", VA = "0x180DA8C40")]
	public HLAFNLPNEPI(NDPGEKOEOMO KLGNHJHHNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x880CFC0", Offset = "0x880B7C0", VA = "0x18880CFC0", Slot = "8")]
	public bool HPFHOOPLKHJ(byte IDIIIALCIOG, object BMKIAGNKJFP, IKNIODLHFBI OLAJFDBFNIB, IFLICBOELMF CNCFGMMNIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x880CC40", Offset = "0x880B440", VA = "0x18880CC40", Slot = "20")]
	public EIGONBNGIIK CJBMKANACPI(int NLAPHBJBIHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x880D190", Offset = "0x880B990", VA = "0x18880D190", Slot = "21")]
	public EIGONBNGIIK IFCONGIFOKK(int DJKBOHPOLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x880D2D0", Offset = "0x880BAD0", VA = "0x18880D2D0", Slot = "22")]
	public EIGONBNGIIK LAGBMLCMEAH(int NLAPHBJBIHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x880CCE0", Offset = "0x880B4E0", VA = "0x18880CCE0", Slot = "23")]
	public IReadOnlyList<EIGONBNGIIK> DGELPEKBPOK(bool PLGNMPAKDLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x880D400", Offset = "0x880BC00", VA = "0x18880D400", Slot = "24")]
	public IReadOnlyList<EIGONBNGIIK> MNKPIGMNFNJ(bool PLGNMPAKDLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "25")]
	public bool PEEGCCOCKCL(EIGONBNGIIK LAGPABGGGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "28")]
	public void AKFMEBGGOJE(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "29")]
	public void GJNNEJBGKEF(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "30")]
	public void EBDNLEKAKLI(object KAJENDFCCBJ, bool FNEFOMNCPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x880D3B0", Offset = "0x880BBB0", VA = "0x18880D3B0", Slot = "31")]
	public IDisposable MKMBKKBGLLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "32")]
	private bool CDJOKJIJCOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "33")]
	public void GDALKJLLCNI(StringBuilder LOJNECLIFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xFDAE90", Offset = "0xFD9690", VA = "0x180FDAE90", Slot = "34")]
	public bool CMPPLPPEKLH(bool MJPIJENDBIH, [Out] string MEBFHJECJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xF4B870", Offset = "0xF4A070", VA = "0x180F4B870", Slot = "37")]
	public void ACEPGCLAPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct MJMABIBEGJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly IDictionary<object, object> NPLHFNMEMBD;

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	public MJMABIBEGJJ(IDictionary<object, object> NPLHFNMEMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8815630", Offset = "0x8813E30", VA = "0x188815630")]
	public bool EPNBDOKIMPJ([Out] EMOHKBNEAPF ILBALOOKKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8815450", Offset = "0x8813C50", VA = "0x188815450")]
	public Guid CAPMNBFIKEP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8815500", Offset = "0x8813D00", VA = "0x188815500")]
	public AKIGBGIOJEO EHIEJKMDLJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x88156E0", Offset = "0x8813EE0", VA = "0x1888156E0")]
	public static ExitGames.Client.Photon.Hashtable INHDMBAMCNE(EMOHKBNEAPF ILBALOOKKCP, AKIGBGIOJEO DAKIBMJOMIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal static class PAKMCIDKBOL
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x881B520", Offset = "0x8819D20", VA = "0x18881B520")]
	public static bool OFBMEKDAPBA(this LOAOCAFLNEN NLKCLNKGHKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct HOPHMJJAJJG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct GMAHPLFLCFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public HOPHMJJAJJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x880C6B0", Offset = "0x880AEB0", VA = "0x18880C6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x880C890", Offset = "0x880B090", VA = "0x18880C890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly CancellationTokenSource JKCICFOHGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private Task FEGBHCAEMDO;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x880D720", Offset = "0x880BF20", VA = "0x18880D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x880D750", Offset = "0x880BF50", VA = "0x18880D750")]
	public HOPHMJJAJJG(CancellationToken GMEAHOBHMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x880D610", Offset = "0x880BE10", VA = "0x18880D610")]
	[AsyncStateMachine(typeof(GMAHPLFLCFI))]
	public Task ECMBMDNJEPM(Func<CancellationToken, List<Task>> GFJFCKIKALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x880D5C0", Offset = "0x880BDC0", VA = "0x18880D5C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public readonly struct HLFBGIHNNPP<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct GMAFAOJOGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<AIPBKEKEDCP<TData>, EMOGOMODAJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public HLFBGIHNNPP<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter<AOGODOAGAAO<AIPBKEKEDCP<TData>, EMOGOMODAJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x4CA6B20", Offset = "0x4CA5320", VA = "0x184CA6B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7710", Offset = "0x4CA5F10", VA = "0x184CA7710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly CMMOHICJPAP<TGetDataArg, TData> OFNAGCEIFKB;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	internal HLFBGIHNNPP(CMMOHICJPAP<TGetDataArg, TData> GGLINDGLEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B9E0", Offset = "0x4D0A1E0", VA = "0x184D0B9E0")]
	[AsyncStateMachine(typeof(HLFBGIHNNPP<, >.GMAFAOJOGJM))]
	public Task<AOGODOAGAAO<AIPBKEKEDCP<TData>, EMOGOMODAJG>> NBBJKKCJMAB(TGetDataArg OPAHMKOAAKD, string FAKFOMCEJIL, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class EKMCFNPNELC
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x37F6EE0", Offset = "0x37F56E0", VA = "0x1837F6EE0")]
	public static HLFBGIHNNPP<TGetDataArg, TData> CCPKJDCALBG<TGetDataArg, TData>(CMMOHICJPAP<TGetDataArg, TData> GGLINDGLEPB)
	{
		return default(HLFBGIHNNPP<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public struct HLCLCOKBABM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public readonly int GJKKOAKOCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly int? AFFPIPHDBBE;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x524B250", Offset = "0x5249A50", VA = "0x18524B250")]
	public HLCLCOKBABM(int EOKPMGGJEMH, [Optional] int? KOPPKGANGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x880D4E0", Offset = "0x880BCE0", VA = "0x18880D4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface IOCAGDLIJJH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHABOGLGEFF();

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOCAGDLIJJH<T> ELOIPHLBDOL(string NCIJEBLFGJP);

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOCAGDLIJJH<T> AEEPNFAAOCK(ENDJJEINDML<T> JKBHOONHGMG);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IOCAGDLIJJH<T> BLDIHLDKMFI(int ALIHNDLFCFH);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IOCAGDLIJJH<T> MLEFAGGBILN(int ALIHNDLFCFH, MIOHFFOMDIN<T> PPOHKJNACHD);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface FILOJONJOBN
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOCAGDLIJJH<T> MFDIENCHBAL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FBNAFNDJFGC JHPNLAIGPCH(Exception FKONJEEEEJA);

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HLCLCOKBABM DOLIMFMEEDG(Exception FKONJEEEEJA);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate string ENDJJEINDML<in T>(T FKONJEEEEJA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate int MIOHFFOMDIN<in T>(T FKONJEEEEJA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class OHNEEIFEOPH : FILOJONJOBN
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate string FBHHAGNPJPD(Exception FKONJEEEEJA);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate int KBEGAOFOFON(Exception FKONJEEEEJA);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class BNEKFNLBLEE<T> : IOCAGDLIJJH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class PENFDIDKPKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public PENFDIDKPKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			internal string IHGNEGJDGKN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class PAFFFOPAPAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public ENDJJEINDML<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public PAFFFOPAPAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x50C7A80", Offset = "0x50C6280", VA = "0x1850C7A80")]
			internal string NNJBPANAJEB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class JKOGGPNJIFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public MIOHFFOMDIN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public JKOGGPNJIFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x50C7A80", Offset = "0x50C6280", VA = "0x1850C7A80")]
			internal int MGKEKMJNIPD(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private readonly OHNEEIFEOPH MEIBPHMNOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly Type JOLHCBGFJBC;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6182A70", Offset = "0x6181270", VA = "0x186182A70")]
		internal BNEKFNLBLEE(OHNEEIFEOPH MEIBPHMNOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x61827A0", Offset = "0x6180FA0", VA = "0x1861827A0", Slot = "4")]
		public void BHABOGLGEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6182810", Offset = "0x6181010", VA = "0x186182810", Slot = "5")]
		public IOCAGDLIJJH<T> ELOIPHLBDOL(string NCIJEBLFGJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6182680", Offset = "0x6180E80", VA = "0x186182680", Slot = "6")]
		public IOCAGDLIJJH<T> AEEPNFAAOCK(ENDJJEINDML<T> JKBHOONHGMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x61827D0", Offset = "0x6180FD0", VA = "0x1861827D0", Slot = "7")]
		public IOCAGDLIJJH<T> BLDIHLDKMFI(int ALIHNDLFCFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6182930", Offset = "0x6181130", VA = "0x186182930", Slot = "8")]
		public IOCAGDLIJJH<T> MLEFAGGBILN(int ALIHNDLFCFH, MIOHFFOMDIN<T> PPOHKJNACHD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class IEFEGJLGDHP<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private bool MEKOJJKLAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly List<Type> NAAMJLLLDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly Dictionary<Type, TVal> CHAJMJDIMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly Dictionary<Type, int> FBGMEKALJGP;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> KFBHKFAGJBB
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x4E6C4E0", Offset = "0x4E6ACE0", VA = "0x184E6C4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C6C0", Offset = "0x4E6AEC0", VA = "0x184E6C6C0")]
		public IEFEGJLGDHP(Dictionary<Type, int> FBGMEKALJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C3C0", Offset = "0x4E6ABC0", VA = "0x184E6C3C0")]
		public void GGGBGBDKNKJ(Type MNMCNOJCKAF, TVal AMJBMFFPJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C480", Offset = "0x4E6AC80", VA = "0x184E6C480")]
		public bool IKEJFGHDLPJ(Type JOLHCBGFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C660", Offset = "0x4E6AE60", VA = "0x184E6C660")]
		public bool OAPEOOPBALM(TVal MGONBEDEDON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C160", Offset = "0x4E6A960", VA = "0x184E6C160")]
		public TVal CEJDCFFPPDB(Type CEPGAJKBPDM)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4E6C1C0", Offset = "0x4E6A9C0", VA = "0x184E6C1C0")]
		[CompilerGenerated]
		private int EJGJCHJGINC(Type MMDLOICBGMP, Type JCFCMIEKELC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class PHCCPKPIBIM : IEnumerable<HLCLCOKBABM>, IEnumerable, IEnumerator<HLCLCOKBABM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private HLCLCOKBABM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public OHNEEIFEOPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private IEnumerator<HLCLCOKBABM> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private HLCLCOKBABM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x47BDD10", Offset = "0x47BC510", VA = "0x1847BDD10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HLCLCOKBABM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x881E0F0", Offset = "0x881C8F0", VA = "0x18881E0F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public PHCCPKPIBIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x881E140", Offset = "0x881C940", VA = "0x18881E140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x881DB30", Offset = "0x881C330", VA = "0x18881DB30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x881DAE0", Offset = "0x881C2E0", VA = "0x18881DAE0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x881DA90", Offset = "0x881C290", VA = "0x18881DA90")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x881E0A0", Offset = "0x881C8A0", VA = "0x18881E0A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x881DFE0", Offset = "0x881C7E0", VA = "0x18881DFE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HLCLCOKBABM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x881DFE0", Offset = "0x881C7E0", VA = "0x18881DFE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private static readonly HLCLCOKBABM HDGNBBIFANA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private static readonly Dictionary<Type, int> OGDMFJAFFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private readonly HashSet<Type> IEOHAJHINAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private readonly IEFEGJLGDHP<int> FCMKNLNGNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly IEFEGJLGDHP<KBEGAOFOFON> PDNLPHPKMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly IEFEGJLGDHP<FBHHAGNPJPD> PEIILJIACNA;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x8819A60", Offset = "0x8818260", VA = "0x188819A60")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void BGEJLCAAPFF(OIKNHNBNAFI ECLFBIAPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x881AD60", Offset = "0x8819560", VA = "0x18881AD60")]
	[RecRoom.NoEngine.Common.Preserve]
	public OHNEEIFEOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120", Slot = "4")]
	public IOCAGDLIJJH<T> MFDIENCHBAL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x881A350", Offset = "0x8818B50", VA = "0x18881A350", Slot = "5")]
	public FBNAFNDJFGC JHPNLAIGPCH(Exception FKONJEEEEJA)
	{
		return default(FBNAFNDJFGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8819E80", Offset = "0x8818680", VA = "0x188819E80", Slot = "6")]
	public HLCLCOKBABM DOLIMFMEEDG(Exception? FKONJEEEEJA)
	{
		return default(HLCLCOKBABM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x881A630", Offset = "0x8818E30", VA = "0x18881A630", Slot = "7")]
	[IteratorStateMachine(typeof(PHCCPKPIBIM))]
	public IEnumerable<HLCLCOKBABM> KMJOJDAKEFO(Exception FKONJEEEEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x881AB50", Offset = "0x8819350", VA = "0x18881AB50", Slot = "8")]
	public string PBPDFKNCOIN(Exception? FKONJEEEEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x881A6D0", Offset = "0x8818ED0", VA = "0x18881A6D0")]
	private string LKCOICPIFHB(AggregateException GMHGJOMNGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8819AD0", Offset = "0x88182D0", VA = "0x188819AD0")]
	private void CAMDFJMNDMJ(Type JOLHCBGFJBC, int ALIHNDLFCFH, KBEGAOFOFON? CAIEPBNAGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x881A3E0", Offset = "0x8818BE0", VA = "0x18881A3E0")]
	private void KINPMEHGFLH(Type JOLHCBGFJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x881A080", Offset = "0x8818880", VA = "0x18881A080")]
	private void FFHHGDIHGLA(Type JOLHCBGFJBC, FBHHAGNPJPD MGAJKJFHGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x881A9D0", Offset = "0x88191D0", VA = "0x18881A9D0")]
	private static int NKMBLKADJCI(Type JOLHCBGFJBC, Dictionary<Type, int> FBGMEKALJGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DFC0", Offset = "0x3B7C7C0", VA = "0x183B7DFC0")]
	private static bool IMHPEGLIBMH<TVal>(IEFEGJLGDHP<TVal> IFMNLKCJNMD, Type JOLHCBGFJBC, [Out] TVal MGONBEDEDON) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x8819980", Offset = "0x8818180", VA = "0x188819980")]
	[CompilerGenerated]
	internal static int AHHECKFKFMM(Type PGMJIKHCIMO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct FBNAFNDJFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public readonly HLCLCOKBABM OKFHJDBBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public readonly string NLNCNBOGOGI;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x8808EE0", Offset = "0x88076E0", VA = "0x188808EE0")]
	public FBNAFNDJFGC(string EPLPFEJLMBH, HLCLCOKBABM ALIHNDLFCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8808E40", Offset = "0x8807640", VA = "0x188808E40")]
	public string KODNLEHEOCB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public class PPOCKLEIMOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private readonly NHOAHDCMOCH PPMMKMDKENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private string NFCOLCBKHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private long? AIMPFKEINAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private long? JEMNBALEPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private long? EEADOGDMOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private string EDNNBNFMHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private GCBHLCMINDE GDOMMBDBILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? LAOOOPINKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private bool FILCJOHLAOO;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string OKAKKMLHBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long LPMMKNCOHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x881FEE0", Offset = "0x881E6E0", VA = "0x18881FEE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long GFFEBGPPOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x881FFE0", Offset = "0x881E7E0", VA = "0x18881FFE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long JKCDBBHKMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x881F7A0", Offset = "0x881DFA0", VA = "0x18881F7A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string NHOLILHBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x881F3F0", Offset = "0x881DBF0", VA = "0x18881F3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public GCBHLCMINDE GCCMGCGDFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xA877D0", Offset = "0xA85FD0", VA = "0x180A877D0")]
		get
		{
			return default(GCBHLCMINDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x88200A0", Offset = "0x881E8A0", VA = "0x1888200A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long MBFPJJCLMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8820040", Offset = "0x881E840", VA = "0x188820040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8820190", Offset = "0x881E990", VA = "0x188820190")]
	[UnityEngine.Scripting.Preserve]
	public PPOCKLEIMOO([FAPODKMFODF(null)] NHOAHDCMOCH PPMMKMDKENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x881F800", Offset = "0x881E000", VA = "0x18881F800")]
	private void GCJPBOPJNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x881FA50", Offset = "0x881E250", VA = "0x18881FA50")]
	public void GDEPDLMILGA(long GFHIJAKOMMI, long PALELGDJJCI, [Optional] long? HHKAEIEEJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x881FF40", Offset = "0x881E740", VA = "0x18881FF40")]
	public void IMDIIEDBFFP(long HHKAEIEEJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x881F370", Offset = "0x881DB70", VA = "0x18881F370")]
	public void AFCDJJGLHEM(string INFFBMIKNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x881F430", Offset = "0x881DC30", VA = "0x18881F430")]
	public void FHBEKBONLOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class PFGLBMLEAGJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct JNJGBOBFBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public EMOHKBNEAPF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public PFGLBMLEAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<AODBFAEMBPL.AOFCFFLEOKB<EMOHKBNEAPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8811D80", Offset = "0x8810580", VA = "0x188811D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x88122C0", Offset = "0x8810AC0", VA = "0x1888122C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct BOCBIOJFCDI<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class OPNPEFFOLPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public EMOHKBNEAPF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OPNPEFFOLPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x881B440", Offset = "0x8819C40", VA = "0x18881B440")]
		internal EMOHKBNEAPF HMJPFGEEPLF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct GFHLDADPPNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder<AODBFAEMBPL.AOFCFFLEOKB<EMOHKBNEAPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public EMOHKBNEAPF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public PFGLBMLEAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private HEIDFJHKPNC <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private TaskAwaiter<AODBFAEMBPL.AOFCFFLEOKB<EMOHKBNEAPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x880B130", Offset = "0x8809930", VA = "0x18880B130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x880B740", Offset = "0x8809F40", VA = "0x18880B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JOCGNBEBBEK<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public PFGLBMLEAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x50DC8E0", Offset = "0x50DB0E0", VA = "0x1850DC8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7710", Offset = "0x4CA5F10", VA = "0x184CA7710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct OIPEPNPHENO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public PFGLBMLEAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x881B100", Offset = "0x8819900", VA = "0x18881B100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x881B3E0", Offset = "0x8819BE0", VA = "0x18881B3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class MIPHNJMJONO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MIPHNJMJONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x8815330", Offset = "0x8813B30", VA = "0x188815330")]
		internal object FFJPPGAIEPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8815390", Offset = "0x8813B90", VA = "0x188815390")]
		internal bool LBAIBLKJPGM(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class IIBLGMPDKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IIBLGMPDKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x880E0B0", Offset = "0x880C8B0", VA = "0x18880E0B0")]
		internal object DKOCGNGPNAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class HJODNAHPGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HJODNAHPGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x880CA30", Offset = "0x880B230", VA = "0x18880CA30")]
		internal object MJKEPODOCFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class LNCMIPNPNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LNCMIPNPNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x88135C0", Offset = "0x8811DC0", VA = "0x1888135C0")]
		internal object FPMOLFBCJFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class BAHFLGPJMPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public PFGLBMLEAGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BAHFLGPJMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8804100", Offset = "0x8802900", VA = "0x188804100")]
		internal object DKGJCBDCPMK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly Guid AMGECACADJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public readonly FBBNOBMBACD FJOIPOCPLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private readonly AODBFAEMBPL MABIOHHOENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly OGBKAHNOBEK FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private readonly OCMCHKKDNBL KAOGIKLGFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private bool OGINCBEFCLK;

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x881D860", Offset = "0x881C060", VA = "0x18881D860")]
	public PFGLBMLEAGJ(FBBNOBMBACD OPKHOBALIGI, AODBFAEMBPL MABIOHHOENI, OGBKAHNOBEK FLIPFCGMCOP, OCMCHKKDNBL KAOGIKLGFLI, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x881CAA0", Offset = "0x881B2A0", VA = "0x18881CAA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x881D490", Offset = "0x881BC90", VA = "0x18881D490")]
	public void MKLKEPIOMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x881D740", Offset = "0x881BF40", VA = "0x18881D740")]
	public void PMBAIHLOCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x881C670", Offset = "0x881AE70", VA = "0x18881C670")]
	public void AAIEGGIIDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x881CFE0", Offset = "0x881B7E0", VA = "0x18881CFE0")]
	[AsyncStateMachine(typeof(JNJGBOBFBBJ))]
	internal Task<EMOHKBNEAPF> KGIKAHMOIGB(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, EMOHKBNEAPF JPBGANLJNBP, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1E70", Offset = "0x3BA0670", VA = "0x183BA1E70")]
	private static byte[] MLGKKGJMKIC<T>(T ILBALOOKKCP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1A80", Offset = "0x3BA0280", VA = "0x183BA1A80")]
	private static T HMBLMIKKOGP<T>(MessageParser<T> IJOAAFCHPBK, byte[] ILBALOOKKCP, T CKNNJHFPAKN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x881D600", Offset = "0x881BE00", VA = "0x18881D600")]
	[AsyncStateMachine(typeof(GFHLDADPPNP))]
	private Task<AODBFAEMBPL.AOFCFFLEOKB<EMOHKBNEAPF>> NPGJFEJKIHA(EMOHKBNEAPF JPBGANLJNBP, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BA17E0", Offset = "0x3B9FFE0", VA = "0x183BA17E0")]
	[AsyncStateMachine(typeof(JOCGNBEBBEK<>))]
	internal Task<T> GAFDMGIBALI<T>(CancellationToken DGACCOBPOIM, Func<CancellationToken, Task<T>> EJBAEAGJFLD, int LEDGGCNCBDH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x881CBC0", Offset = "0x881B3C0", VA = "0x18881CBC0")]
	[AsyncStateMachine(typeof(OIPEPNPHENO))]
	internal Task GAFDMGIBALI(CancellationToken DGACCOBPOIM, Func<CancellationToken, Task> EJBAEAGJFLD, int LEDGGCNCBDH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x881CF60", Offset = "0x881B760", VA = "0x18881CF60")]
	public HNJJKGPLGCF KECHIOJIEHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x881C730", Offset = "0x881AF30", VA = "0x18881C730")]
	public ILKGMGDDMAG ABIEFFEJJHK([Optional] FNAKEBMBAOD FDAFEEIOCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x881CCF0", Offset = "0x881B4F0", VA = "0x18881CCF0")]
	public NGIDKHHJHBP JLMHDJANJNO([Optional] BMELPJIFPCL? GLHOMCPEEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x881C7C0", Offset = "0x881AFC0", VA = "0x18881C7C0")]
	public void BPNEPIANKHG(Func<Guid, bool> OPEFKNPDGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x881CAB0", Offset = "0x881B2B0", VA = "0x18881CAB0")]
	public void FEILMBGNFBC(Func<Guid, bool> EBOCNBPJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x881C920", Offset = "0x881B120", VA = "0x18881C920")]
	public Guid DGLMNBMPBPJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x881D270", Offset = "0x881BA70", VA = "0x18881D270")]
	public void LMHHIIEHPLK(Guid NDBBIKEMCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x881D140", Offset = "0x881B940", VA = "0x18881D140")]
	public void KLGNOGKECPI(EMOHKBNEAPF EFJIGAPOJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x881D380", Offset = "0x881BB80", VA = "0x18881D380")]
	public void MIHGFEDHECA(string PHDKCFFAKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1E80", Offset = "0x3BA0680", VA = "0x183BA1E80")]
	private T NLKPKDBMNFC<T>(T MGONBEDEDON) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x881D5B0", Offset = "0x881BDB0", VA = "0x18881D5B0")]
	public void MMAAHIOJDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1BD0", Offset = "0x3BA03D0", VA = "0x183BA1BD0")]
	[CompilerGenerated]
	internal static string KCPMCAAJCGI<T>(byte[] LLNMEIMBBLB, int HEEBLPDLFPB, BOCBIOJFCDI<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal sealed class NOLAPLDKJOK : FBBNOBMBACD
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private sealed class EOHAGOPDNNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EOHAGOPDNNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8808000", Offset = "0x8806800", VA = "0x188808000")]
		internal object CHOMCFDJKME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct NGMKEMOMKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public NOLAPLDKJOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private EKOGFCEADNG <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private ILKGMGDDMAG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter<NIGHPONAAAI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x88179B0", Offset = "0x88161B0", VA = "0x1888179B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x88188B0", Offset = "0x88170B0", VA = "0x1888188B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GCOBCIDPHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public NOLAPLDKJOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private TaskAwaiter<APAMIKOGBPP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8809510", Offset = "0x8807D10", VA = "0x188809510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8809CB0", Offset = "0x88084B0", VA = "0x188809CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct JJOBAOEENFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public NOLAPLDKJOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<ICAKPDKFOPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x88118B0", Offset = "0x88100B0", VA = "0x1888118B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8811BC0", Offset = "0x88103C0", VA = "0x188811BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private sealed class MBFAGJKPAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public EKOGFCEADNG presence;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MBFAGJKPAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x8813C30", Offset = "0x8812430", VA = "0x188813C30")]
		internal object CIOPDMFHHEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly BMELPJIFPCL LPCJBOPABGL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private static readonly BMELPJIFPCL KPDIMONOAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly FNDPEECNEPD CNNILMMCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly LOAOCAFLNEN ICJPMJPGKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private readonly FNAKEBMBAOD FDAFEEIOCEC;

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x8819750", Offset = "0x8817F50", VA = "0x188819750")]
	public NOLAPLDKJOK(FNDPEECNEPD CNNILMMCNMN, LOAOCAFLNEN ICJPMJPGKIN, Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, BEBFLBECFCJ KNLAKDAOGAE, FNAKEBMBAOD FDAFEEIOCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8819260", Offset = "0x8817A60", VA = "0x188819260", Slot = "7")]
	[AsyncStateMachine(typeof(NGMKEMOMKPK))]
	protected override Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8819160", Offset = "0x8817960", VA = "0x188819160")]
	[AsyncStateMachine(typeof(GCOBCIDPHJN))]
	private Task CJOPMOJLNLA(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8819570", Offset = "0x8817D70", VA = "0x188819570")]
	[AsyncStateMachine(typeof(JJOBAOEENFE))]
	private Task<int> MILFBKHKFCL(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x88193B0", Offset = "0x8817BB0", VA = "0x1888193B0")]
	private EKOGFCEADNG KKPJFGIEKAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class ILGDNHKPNBB : FBBNOBMBACD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct CFAIKPKJKJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public ILGDNHKPNBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter<IPCPPGKOOOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x88057B0", Offset = "0x8803FB0", VA = "0x1888057B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8806160", Offset = "0x8804960", VA = "0x188806160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private readonly int JHDPOGLMIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly PMABMGLDFHF LPLDGBKEJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly long OKEIHPDKJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly long GJAJJHFADFG;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public IPCPPGKOOOH IEDNKKLNHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA33780", VA = "0x180A34F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x880E7A0", Offset = "0x880CFA0", VA = "0x18880E7A0")]
	public ILGDNHKPNBB(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, BEBFLBECFCJ KNLAKDAOGAE, int JHDPOGLMIHB, PMABMGLDFHF LPLDGBKEJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x880E680", Offset = "0x880CE80", VA = "0x18880E680", Slot = "7")]
	[AsyncStateMachine(typeof(CFAIKPKJKJE))]
	protected override Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal abstract class INHHCCGJKBK : FBBNOBMBACD
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class KMAKLECJDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public INHHCCGJKBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public IOCDNLDOLPL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KMAKLECJDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x8813230", Offset = "0x8811A30", VA = "0x188813230")]
		internal Task MBKNKKEBODA(DKKFAAJNJJM<string>.BNLIHIFJPDL postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x88131A0", Offset = "0x88119A0", VA = "0x1888131A0")]
		internal object APJLACNFCEF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct MLEKHPKNOCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public INHHCCGJKBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private KMAKLECJDBI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x88157D0", Offset = "0x8813FD0", VA = "0x1888157D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x88160E0", Offset = "0x88148E0", VA = "0x1888160E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct IHNPJBCHGLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public IOCDNLDOLPL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public INHHCCGJKBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x880D8E0", Offset = "0x880C0E0", VA = "0x18880D8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x880DE90", Offset = "0x880C690", VA = "0x18880DE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x88109F0", Offset = "0x880F1F0", VA = "0x1888109F0")]
	public INHHCCGJKBK(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, BEBFLBECFCJ KNLAKDAOGAE, string BMLNILPGOJD, GJHCICIAKDP GOAEPFPLNNI, bool LOGFPJJHHHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x88108B0", Offset = "0x880F0B0", VA = "0x1888108B0", Slot = "7")]
	[AsyncStateMachine(typeof(MLEKHPKNOCN))]
	protected override Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task ENHIDOGLDBH(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x8810770", Offset = "0x880EF70", VA = "0x188810770")]
	[AsyncStateMachine(typeof(IHNPJBCHGLO))]
	private Task GKMNBPHPGDG(IDisposable JNJACHIBCLG, IOCDNLDOLPL NJBHNMMNIFN, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal class AFIOFDNJGFM : FBBNOBMBACD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct NKDLPDDNPNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AFIOFDNJGFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<DEGIKKCKCON> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8818910", Offset = "0x8817110", VA = "0x188818910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8818F00", Offset = "0x8817700", VA = "0x188818F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly DKLOHHBNKIG LNIKDKIPDBJ;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x8803A80", Offset = "0x8802280", VA = "0x188803A80")]
	public AFIOFDNJGFM(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, BEBFLBECFCJ KNLAKDAOGAE, DKLOHHBNKIG LNIKDKIPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x88039A0", Offset = "0x88021A0", VA = "0x1888039A0", Slot = "6")]
	protected override string HHFOKAJIDGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8803880", Offset = "0x8802080", VA = "0x188803880", Slot = "7")]
	[AsyncStateMachine(typeof(NKDLPDDNPNF))]
	protected override Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal abstract class FBBNOBMBACD : CPIJNNKNCEA
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	public delegate Task JMBJGNNEOMM(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class FAJIHEINLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public FBBNOBMBACD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FAJIHEINLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8808070", Offset = "0x8806870", VA = "0x188808070")]
		internal Task JNGMFGJFBPF(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class KGDELBADANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public FAJIHEINLOG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KGDELBADANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x88130E0", Offset = "0x88118E0", VA = "0x1888130E0")]
		internal object KAEKJCOHNJP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct MBKPJLIIBMB : IAsyncStateMachine
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
		public FBBNOBMBACD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Func<FBBNOBMBACD, DKKFAAJNJJM<string>.BNLIHIFJPDL, PFGLBMLEAGJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private FAJIHEINLOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private PFGLBMLEAGJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x8813D70", Offset = "0x8812570", VA = "0x188813D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8815080", Offset = "0x8813880", VA = "0x188815080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct ELBDOIFFDEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8807500", Offset = "0x8805D00", VA = "0x188807500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8807FA0", Offset = "0x88067A0", VA = "0x188807FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct MNBCCEIIIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public FBBNOBMBACD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8816140", Offset = "0x8814940", VA = "0x188816140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x88164A0", Offset = "0x8814CA0", VA = "0x1888164A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public readonly Guid LNALCBHAJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public readonly ByteString FMCKAHFFCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public readonly BEBFLBECFCJ HJCCMIHCCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	protected readonly string MPIPGMOJODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private readonly GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private readonly bool LOGFPJJHHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly Queue<JMBJGNNEOMM> JLEKAKFPJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly DIADNJMIGGJ DKNEAGKIMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly GJHCICIAKDP GOAEPFPLNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private bool AOLDDDDLNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public GCBHLCMINDE IOMFMOIGFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public GCBHLCMINDE LNFLKHAIOOJ;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GBCNJFGJIEN BLNHNPMGAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8808620", Offset = "0x8806E20", VA = "0x188808620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NHINCABDBDO NDEFNCFAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x88085D0", Offset = "0x8806DD0", VA = "0x1888085D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8808A30", Offset = "0x8807230", VA = "0x188808A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event AGGEJNEFLHB DEHPGMHFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8808AB0", Offset = "0x88072B0", VA = "0x188808AB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8808A10", Offset = "0x8807210", VA = "0x188808A10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x8808CE0", Offset = "0x88074E0", VA = "0x188808CE0")]
	protected FBBNOBMBACD(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, BEBFLBECFCJ KNLAKDAOGAE, string BMLNILPGOJD, GJHCICIAKDP GOAEPFPLNNI, bool LOGFPJJHHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x88086F0", Offset = "0x8806EF0", VA = "0x1888086F0", Slot = "6")]
	protected virtual string HHFOKAJIDGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x8808C00", Offset = "0x8807400", VA = "0x188808C00")]
	public void PDKPDDFFGOF(JMBJGNNEOMM IPHFGIAOPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x88089F0", Offset = "0x88071F0", VA = "0x1888089F0")]
	protected void IOJKCKHCMPF(float LNKCJPMONLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x88088A0", Offset = "0x88070A0", VA = "0x1888088A0")]
	[AsyncStateMachine(typeof(MBKPJLIIBMB))]
	public Task IHHPLANMBKM(CancellationToken GMEAHOBHMAD, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, [Optional] Func<FBBNOBMBACD, DKKFAAJNJJM<string>.BNLIHIFJPDL, PFGLBMLEAGJ> LCICCBHMFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8808AD0", Offset = "0x88072D0", VA = "0x188808AD0")]
	[AsyncStateMachine(typeof(ELBDOIFFDEJ))]
	private static Task OKILFMGFOEP(Func<CancellationToken, Task> HBCGLGDDGDK, Func<CancellationToken, Task> JLBMKLOOICE, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8808730", Offset = "0x8806F30", VA = "0x188808730")]
	private void HOHGOGMEPJB(bool PEFHAHJOKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x88082C0", Offset = "0x8806AC0", VA = "0x1888082C0")]
	private void DPANEKJGCJC(PFGLBMLEAGJ JIJELMDGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x88081A0", Offset = "0x88069A0", VA = "0x1888081A0")]
	[AsyncStateMachine(typeof(MNBCCEIIIBB))]
	private Task CDFKHIFAJHM(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x8808670", Offset = "0x8806E70", VA = "0x188808670")]
	public EMOHKBNEAPF HDAHPOMKMDP(HEIDFJHKPNC BDEMMDCFBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x88084E0", Offset = "0x8806CE0", VA = "0x1888084E0")]
	[CompilerGenerated]
	private Task EKJCIGPLFKD(CancellationToken ODKLOJBBLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8808C60", Offset = "0x8807460", VA = "0x188808C60")]
	[CompilerGenerated]
	private object PGICLHJDHEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal sealed class DKBKNIGEBGG : INHHCCGJKBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct JONFCPCHKNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public DKBKNIGEBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private FPBLLGEBKEJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private ILKGMGDDMAG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8812330", Offset = "0x8810B30", VA = "0x188812330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8812A90", Offset = "0x8811290", VA = "0x188812A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly FNDPEECNEPD CMBMHNLHBHE;

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x8806430", Offset = "0x8804C30", VA = "0x188806430")]
	public DKBKNIGEBGG(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, FNDPEECNEPD CMBMHNLHBHE, BEBFLBECFCJ KNLAKDAOGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x88062E0", Offset = "0x8804AE0", VA = "0x1888062E0", Slot = "8")]
	[AsyncStateMachine(typeof(JONFCPCHKNE))]
	protected override Task ENHIDOGLDBH(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class IHPLEKGJLEG : FBBNOBMBACD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct KAKBFMEHBHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public IHPLEKGJLEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private TaskAwaiter<DEGIKKCKCON> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8812AF0", Offset = "0x88112F0", VA = "0x188812AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x8812F70", Offset = "0x8811770", VA = "0x188812F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly string EIPLDFINAKC;

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x880E000", Offset = "0x880C800", VA = "0x18880E000")]
	public IHPLEKGJLEG(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, BEBFLBECFCJ KNLAKDAOGAE, string EIPLDFINAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x880DEF0", Offset = "0x880C6F0", VA = "0x18880DEF0", Slot = "7")]
	[AsyncStateMachine(typeof(KAKBFMEHBHC))]
	protected override Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class GCNBIMHOJGK : INHHCCGJKBK
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private sealed class DKBBKKKKBHP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public DKBBKKKKBHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private TaskAwaiter<DEGIKKCKCON> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			private TaskAwaiter<EMOHKBNEAPF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x88201D0", Offset = "0x881E9D0", VA = "0x1888201D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x88206C0", Offset = "0x881EEC0", VA = "0x1888206C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public GCNBIMHOJGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public NGIDKHHJHBP serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public LGGCFGKNFLP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public HNJJKGPLGCF uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public CJEMFAOCIIJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DKBBKKKKBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x88061C0", Offset = "0x88049C0", VA = "0x1888061C0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<EMOHKBNEAPF> PICNFPONIFJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct GFBMBACIBEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GCNBIMHOJGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private DKBBKKKKBHP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private FPBLLGEBKEJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private ILKGMGDDMAG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private EMOHKBNEAPF <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x880A1E0", Offset = "0x88089E0", VA = "0x18880A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x880B0D0", Offset = "0x88098D0", VA = "0x18880B0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private static readonly BMELPJIFPCL LPCJBOPABGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private readonly int JPILDFAPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	[CanBeNull]
	private readonly LGOJJLPEJAM DKGHDKKALOF;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x8809460", Offset = "0x8807C60", VA = "0x188809460")]
	public GCNBIMHOJGK(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, int JPILDFAPLHD, LGOJJLPEJAM DKGHDKKALOF, BEBFLBECFCJ KNLAKDAOGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x8808FA0", Offset = "0x88077A0", VA = "0x188808FA0", Slot = "8")]
	[AsyncStateMachine(typeof(GFBMBACIBEG))]
	protected override Task ENHIDOGLDBH(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x88090E0", Offset = "0x88078E0", VA = "0x1888090E0")]
	private void FGGFBMGEJED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x88091E0", Offset = "0x88079E0", VA = "0x1888091E0")]
	private void IPEMCPKLLKF(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, FPBLLGEBKEJ MMOLNADADKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class MNLDJINICKO : FBBNOBMBACD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct BAOKCNEFAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public MNLDJINICKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private FPBLLGEBKEJ <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private ICAKPDKFOPO <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private OBKOLGEFKBC<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter<ICAKPDKFOPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter<IPCPPGKOOOH> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8804340", Offset = "0x8802B40", VA = "0x188804340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8805750", Offset = "0x8803F50", VA = "0x188805750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private readonly int JPILDFAPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private readonly LGOJJLPEJAM DKGHDKKALOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private Func<DEGIKKCKCON, DEGIKKCKCON> POONKIBDCLI;

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x8816630", Offset = "0x8814E30", VA = "0x188816630")]
	public MNLDJINICKO(Guid GKMDGNFGEOO, GBCNJFGJIEN KFBGJKCPJCG, int JPILDFAPLHD, LGOJJLPEJAM DKGHDKKALOF, Func<DEGIKKCKCON, DEGIKKCKCON> POONKIBDCLI, BEBFLBECFCJ KNLAKDAOGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x8816500", Offset = "0x8814D00", VA = "0x188816500", Slot = "7")]
	[AsyncStateMachine(typeof(BAOKCNEFAAM))]
	protected override Task GPEPGLEMHHF(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal abstract class MENJONJGINP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public readonly FBBNOBMBACD FJOIPOCPLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public readonly PFGLBMLEAGJ BONGODLPLEM;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x88150E0", Offset = "0x88138E0", VA = "0x1888150E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8815130", Offset = "0x8813930", VA = "0x188815130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x88152D0", Offset = "0x8813AD0", VA = "0x1888152D0")]
	protected MENJONJGINP(PFGLBMLEAGJ JIJELMDGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x88151C0", Offset = "0x88139C0", VA = "0x1888151C0")]
	protected void MIHGFEDHECA(string PHDKCFFAKLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct MPEICGEBDOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public Dictionary<Guid, List<NDDLKPKFGHA>> AJNNOPPFKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public Dictionary<Guid, List<NDDLKPKFGHA>> NDDFIBDPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public Dictionary<Guid, List<NDDLKPKFGHA>> LPHNFBILEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public List<Guid> IHKCPGMCBBI;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x88166F0", Offset = "0x8814EF0", VA = "0x1888166F0")]
	public static MPEICGEBDOI CEJDCFFPPDB(LCLCIAOJCLH PJHMONPOPCI, GCBHLCMINDE OPEFAJAPNKK, HDBLPJBDELH ODEKLFJBJKH)
	{
		return default(MPEICGEBDOI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct DOFFOLBILBO
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	public static DOFFOLBILBO INHDMBAMCNE()
	{
		return default(DOFFOLBILBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct AKNNNGCPBLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public readonly APAMIKOGBPP DHKAOBLPBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public readonly NKDJCGCAECB JDGDHOJOPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public readonly Guid? DPCIEGDDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public readonly IReadOnlyCollection<NKFFLFJJKEG> ALHNEKAHKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public readonly IReadOnlyCollection<NKFFLFJJKEG> PBOJNIAEAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public readonly DOPHJNOBIJD NNOJLKJDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly DOPHJNOBIJD AJDCEEKKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly JNMEENHOMDP ICMOMLFHBBK;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool IKONFEDKCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x8803FC0", Offset = "0x88027C0", VA = "0x188803FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x8804050", Offset = "0x8802850", VA = "0x188804050")]
	public AKNNNGCPBLB(APAMIKOGBPP DHKAOBLPBCI, NKDJCGCAECB JDGDHOJOPDL, Guid? DPCIEGDDHDL, IReadOnlyList<NKFFLFJJKEG> ALHNEKAHKCI, IReadOnlyCollection<NKFFLFJJKEG> PBOJNIAEAOO, DOPHJNOBIJD NNOJLKJDGHO, DOPHJNOBIJD AJDCEEKKJIC, JNMEENHOMDP ICMOMLFHBBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct AKHHPOIHBFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private readonly PFGLBMLEAGJ JIJELMDGBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private readonly Guid NDBBIKEMCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private bool PEFHAHJOKNH;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8803B20", Offset = "0x8802320", VA = "0x188803B20")]
	public static AKHHPOIHBFK DGLMNBMPBPJ(PFGLBMLEAGJ JIJELMDGBKG)
	{
		return default(AKHHPOIHBFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x122C720", Offset = "0x122AF20", VA = "0x18122C720")]
	public void ONNCEILFOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8803B50", Offset = "0x8802350", VA = "0x188803B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x8803E30", Offset = "0x8802630", VA = "0x188803E30")]
	private AKHHPOIHBFK(PFGLBMLEAGJ JIJELMDGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8803C00", Offset = "0x8802400", VA = "0x188803C00")]
	private void LMHHIIEHPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8803B60", Offset = "0x8802360", VA = "0x188803B60")]
	private Func<Guid, bool> LEBJBDJLHKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal class ILKGMGDDMAG : MENJONJGINP, CPIJNNKNCEA
{
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public delegate Task<GCBHLCMINDE> JFDDAONCKAB(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC NCHBGMPNMCM, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct DPCALGCMIJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public FNDPEECNEPD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private AKHHPOIHBFK <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x8824A40", Offset = "0x8823240", VA = "0x188824A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8825180", Offset = "0x8823980", VA = "0x188825180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct EOKBKMCCIPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public FNDPEECNEPD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8825E50", Offset = "0x8824650", VA = "0x188825E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8826280", Offset = "0x8824A80", VA = "0x188826280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct DDODKLMEHOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public FNDPEECNEPD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8823500", Offset = "0x8821D00", VA = "0x188823500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x88239C0", Offset = "0x88221C0", VA = "0x1888239C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class JIAJHKFHCID
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public AsyncTaskMethodBuilder<AKNNNGCPBLB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public JIAJHKFHCID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			private AKNNNGCPBLB <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			private TaskAwaiter<GCBHLCMINDE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			private TaskAwaiter<AKNNNGCPBLB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8836370", Offset = "0x8834B70", VA = "0x188836370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x8836C30", Offset = "0x8835430", VA = "0x188836C30", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public AsyncTaskMethodBuilder<HDBLPJBDELH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public JIAJHKFHCID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private HDBLPJBDELH <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<GCBHLCMINDE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			private TaskAwaiter<HDBLPJBDELH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8836CA0", Offset = "0x88354A0", VA = "0x188836CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x88372F0", Offset = "0x8835AF0", VA = "0x1888372F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public FNDPEECNEPD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public DIADNJMIGGJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public DIADNJMIGGJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AKNNNGCPBLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public DIADNJMIGGJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public HDBLPJBDELH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public GHCBELNNDFF.DLOHDJBNJDL <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JIAJHKFHCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x882CAD0", Offset = "0x882B2D0", VA = "0x18882CAD0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<AKNNNGCPBLB> INPKPNEMPMP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x882C930", Offset = "0x882B130", VA = "0x18882C930")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<HDBLPJBDELH> BDMJHGIHFMO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x882CA50", Offset = "0x882B250", VA = "0x18882CA50")]
		internal void CIHJCJEBKJO(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x882CA90", Offset = "0x882B290", VA = "0x18882CA90")]
		internal Task GPDHCBOABME(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x882CC20", Offset = "0x882B420", VA = "0x18882CC20")]
		internal Task OOCBJENBCEA(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct HFCGFPOIMGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public FNDPEECNEPD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private JIAJHKFHCID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<AKNNNGCPBLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private TaskAwaiter<HDBLPJBDELH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x882A500", Offset = "0x8828D00", VA = "0x18882A500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x882B1B0", Offset = "0x88299B0", VA = "0x18882B1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct JJNIHPJFGJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public HDBLPJBDELH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public DIADNJMIGGJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter<GCBHLCMINDE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private OKNAJCBGHOC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x882CC60", Offset = "0x882B460", VA = "0x18882CC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x882DAC0", Offset = "0x882C2C0", VA = "0x18882DAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct FCEJPKKPGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x88268D0", Offset = "0x88250D0", VA = "0x1888268D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x88270B0", Offset = "0x88258B0", VA = "0x1888270B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct ELKLGGJJEHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8825450", Offset = "0x8823C50", VA = "0x188825450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8825C90", Offset = "0x8824490", VA = "0x188825C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct MIBADEHDKPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x88306B0", Offset = "0x882EEB0", VA = "0x1888306B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8831670", Offset = "0x882FE70", VA = "0x188831670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct IENDBIMALMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public OKNAJCBGHOC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x882B210", Offset = "0x8829A10", VA = "0x18882B210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x882C320", Offset = "0x882AB20", VA = "0x18882C320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct CMOJLBDJNFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public GCBHLCMINDE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public HDBLPJBDELH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8822960", Offset = "0x8821160", VA = "0x188822960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8822BC0", Offset = "0x88213C0", VA = "0x188822BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class AFAHDOGHFFN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public AFAHDOGHFFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			private OGBIDEAJDEB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			private TaskAwaiter<GCBHLCMINDE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x8837360", Offset = "0x8835B60", VA = "0x188837360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x8837980", Offset = "0x8836180", VA = "0x188837980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public JFDDAONCKAB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public OKNAJCBGHOC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public GCBHLCMINDE originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AFAHDOGHFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8820D50", Offset = "0x881F550", VA = "0x188820D50")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GCBHLCMINDE> CBFFMCMCIML(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct NCDDNILJOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public JFDDAONCKAB masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public OKNAJCBGHOC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8832E10", Offset = "0x8831610", VA = "0x188832E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x8833330", Offset = "0x8831B30", VA = "0x188833330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct FOLMHIPCHNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private GCBHLCMINDE <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private IEnumerator<GCBHLCMINDE> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8827600", Offset = "0x8825E00", VA = "0x188827600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8827B50", Offset = "0x8826350", VA = "0x188827B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct FBGJMPDKMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8826580", Offset = "0x8824D80", VA = "0x188826580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8826870", Offset = "0x8825070", VA = "0x188826870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct LIOKECPLIPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x882EB00", Offset = "0x882D300", VA = "0x18882EB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x882ED20", Offset = "0x882D520", VA = "0x18882ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class EMBDPCBEJBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public EMBDPCBEJBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public HDBLPJBDELH data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public DIADNJMIGGJ progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private TaskAwaiter<GCBHLCMINDE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			private TaskAwaiter<JIJIPCHGCJC> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x88379F0", Offset = "0x88361F0", VA = "0x1888379F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x88384B0", Offset = "0x8836CB0", VA = "0x1888384B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public BANOMJHJEEG mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EMBDPCBEJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8825CF0", Offset = "0x88244F0", VA = "0x188825CF0")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<GCBHLCMINDE> KHDHCNJJPPA(HDBLPJBDELH data, OKNAJCBGHOC _, DIADNJMIGGJ progressTracker, DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct MNPNDMIHMLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public HDBLPJBDELH phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public DIADNJMIGGJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private EMBDPCBEJBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private OKNAJCBGHOC <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<GCBHLCMINDE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x88316E0", Offset = "0x882FEE0", VA = "0x1888316E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x8832530", Offset = "0x8830D30", VA = "0x188832530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct PKJNGIDCFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8835270", Offset = "0x8833A70", VA = "0x188835270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8835670", Offset = "0x8833E70", VA = "0x188835670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct FPNBABGKAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public ILKGMGDDMAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public DIADNJMIGGJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8827BB0", Offset = "0x88263B0", VA = "0x188827BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x88281D0", Offset = "0x88269D0", VA = "0x1888281D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private readonly JHEECHAOLLM LOJDDDGHFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly JHEECHAOLLM FCHDDPCEFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private readonly PPOCKLEIMOO BDNIHLNLANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly PDACHEGIGFD FGOIOHAJMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly ECOFHGCCJEJ CBOMKKPGEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private ProfilerCounterValue<int> BKNOEHBFNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly JFJKIGGENDI LBICCPLDMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly FNAKEBMBAOD FDAFEEIOCEC;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private GBCNJFGJIEN BLNHNPMGAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x880FDE0", Offset = "0x880E5E0", VA = "0x18880FDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event AGGEJNEFLHB DEHPGMHFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x880F9C0", Offset = "0x880E1C0", VA = "0x18880F9C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x880F950", Offset = "0x880E150", VA = "0x18880F950", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x8810490", Offset = "0x880EC90", VA = "0x188810490")]
	public ILKGMGDDMAG(PFGLBMLEAGJ JIJELMDGBKG, FNAKEBMBAOD FDAFEEIOCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x8810340", Offset = "0x880EB40", VA = "0x188810340")]
	[AsyncStateMachine(typeof(DPCALGCMIJH))]
	public Task PKEBAGDECFF(FNDPEECNEPD FLPDPHNPDPK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x880F100", Offset = "0x880D900", VA = "0x18880F100")]
	[AsyncStateMachine(typeof(EOKBKMCCIPN))]
	private Task<EMOHKBNEAPF> DLCOAOHNBJO(FNDPEECNEPD FLPDPHNPDPK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x880F2A0", Offset = "0x880DAA0", VA = "0x18880F2A0")]
	[AsyncStateMachine(typeof(DDODKLMEHOE))]
	private Task EDLEHCADLHP(FNDPEECNEPD FLPDPHNPDPK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x880FF50", Offset = "0x880E750", VA = "0x18880FF50")]
	[AsyncStateMachine(typeof(HFCGFPOIMGH))]
	private Task NNAJGEMCDAJ(FNDPEECNEPD FLPDPHNPDPK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken ENOIFNFAGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x880F710", Offset = "0x880DF10", VA = "0x18880F710")]
	[AsyncStateMachine(typeof(JJNIHPJFGJF))]
	private Task HCNLHMBOKIA(HDBLPJBDELH FEGMOAMMLDN, DIADNJMIGGJ PMBLJFAHHMK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GFLPMOLCIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x880EDD0", Offset = "0x880D5D0", VA = "0x18880EDD0")]
	[AsyncStateMachine(typeof(FCEJPKKPGFB))]
	private Task CIDABPBGNNN(DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x880F400", Offset = "0x880DC00", VA = "0x18880F400")]
	[AsyncStateMachine(typeof(ELKLGGJJEHM))]
	private Task EIMJFIMJCBB(HDBLPJBDELH IMINNNCPCJF, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8810090", Offset = "0x880E890", VA = "0x188810090")]
	[AsyncStateMachine(typeof(MIBADEHDKPN))]
	private Task<GCBHLCMINDE> OGDEKFNBIFM(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x880EA70", Offset = "0x880D270", VA = "0x18880EA70")]
	[AsyncStateMachine(typeof(IENDBIMALMM))]
	private Task<GCBHLCMINDE> BCAAFAEFHDB(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x880E8D0", Offset = "0x880D0D0", VA = "0x18880E8D0")]
	[AsyncStateMachine(typeof(CMOJLBDJNFG))]
	private Task<GCBHLCMINDE> APIFMDADKMO(GCBHLCMINDE OPEFAJAPNKK, HDBLPJBDELH ODEKLFJBJKH, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD, bool BOGLLAFBJJC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x880F860", Offset = "0x880E060", VA = "0x18880F860")]
	private bool HILCPJMGLEC(HDBLPJBDELH FEGMOAMMLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x880EC40", Offset = "0x880D440", VA = "0x18880EC40")]
	[AsyncStateMachine(typeof(NCDDNILJOKF))]
	protected Task<GCBHLCMINDE> CEMJONCALMB(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD, JFDDAONCKAB JOJMCLGJFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x880F5A0", Offset = "0x880DDA0", VA = "0x18880F5A0")]
	[AsyncStateMachine(typeof(FOLMHIPCHNK))]
	private Task GEBLIAFFDBI(HDBLPJBDELH IMINNNCPCJF, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x880F550", Offset = "0x880DD50", VA = "0x18880F550")]
	private void GBGHKKALKIO(GCBHLCMINDE IEDCMDGFNJG, DIADNJMIGGJ CJHEENINGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x880F970", Offset = "0x880E170", VA = "0x18880F970")]
	private void JGNODECIGMB(GCBHLCMINDE DKOFHDBEECB, [Out] GCBHLCMINDE PHJJDHMMNHM, [Out] GCBHLCMINDE NOHDPNCGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x880F260", Offset = "0x880DA60", VA = "0x18880F260")]
	private Task<AKNNNGCPBLB> EDEDKBENDMH(FNDPEECNEPD FLPDPHNPDPK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8810300", Offset = "0x880EB00", VA = "0x188810300")]
	private Task<HDBLPJBDELH> PHEIBDOPCBF(AKNNNGCPBLB IMINNNCPCJF, GHCBELNNDFF.DLOHDJBNJDL HCDLCJBKMMA, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x880EF00", Offset = "0x880D700", VA = "0x18880EF00")]
	[AsyncStateMachine(typeof(FBGJMPDKMGB))]
	private Task DAPAJFMOGOI(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD, bool AINDDNJHNBG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8810210", Offset = "0x880EA10", VA = "0x188810210")]
	[AsyncStateMachine(typeof(LIOKECPLIPN))]
	private Task PFAPEIEGEFE(HDBLPJBDELH IMINNNCPCJF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x880F9E0", Offset = "0x880E1E0", VA = "0x18880F9E0")]
	private Task LJIGIDNOAFK(HDBLPJBDELH IMINNNCPCJF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x880F6F0", Offset = "0x880DEF0", VA = "0x18880F6F0")]
	private Task GMHNGCMADBO(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x880F3E0", Offset = "0x880DBE0", VA = "0x18880F3E0")]
	private Task EFPNJJKPNKB(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x880EEE0", Offset = "0x880D6E0", VA = "0x18880EEE0")]
	private Task CJFKBNCDGLP(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x880F9B0", Offset = "0x880E1B0", VA = "0x18880F9B0")]
	private static Task KAFHLEDOLCH(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x88101F0", Offset = "0x880E9F0", VA = "0x1888101F0")]
	private Task OLNLMJDAEGK(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x880EA50", Offset = "0x880D250", VA = "0x18880EA50")]
	private Task BAGHMEENEMH(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x880EBF0", Offset = "0x880D3F0", VA = "0x18880EBF0")]
	private void BCKJPEDMKND(FNDPEECNEPD FLPDPHNPDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x880F050", Offset = "0x880D850", VA = "0x18880F050")]
	public void DKLCPLHMBEG(long HHKAEIEEJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void DKDGMCOKHOP(APAMIKOGBPP DHKAOBLPBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x880FA10", Offset = "0x880E210", VA = "0x18880FA10")]
	[AsyncStateMachine(typeof(MNPNDMIHMLN))]
	private Task MGBCFINKMEB(HDBLPJBDELH FEGMOAMMLDN, DIADNJMIGGJ PMBLJFAHHMK, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GFLPMOLCIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x880FE10", Offset = "0x880E610", VA = "0x18880FE10")]
	[AsyncStateMachine(typeof(PKJNGIDCFMO))]
	private Task NEHHDCALMOH(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x880FCC0", Offset = "0x880E4C0", VA = "0x18880FCC0")]
	private static MPOOOMKNOFE NCDJMBNJIFC(HDBLPJBDELH ODEKLFJBJKH)
	{
		return default(MPOOOMKNOFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x880FB60", Offset = "0x880E360", VA = "0x18880FB60")]
	[AsyncStateMachine(typeof(FPNBABGKAHC))]
	private Task<GCBHLCMINDE> MMLFEKLIPIO(HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DIADNJMIGGJ CJHEENINGML, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private void OIPALNFKMCG(GCBHLCMINDE IGJNOIOLMKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct IMIHGBIJDOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private HDBLPJBDELH IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x882C4D0", Offset = "0x882ACD0", VA = "0x18882C4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x882C520", Offset = "0x882AD20", VA = "0x18882C520")]
	public static Task IHHPLANMBKM(GBCNJFGJIEN KFBGJKCPJCG, HDBLPJBDELH IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x882C600", Offset = "0x882AE00", VA = "0x18882C600")]
	private void IHHPLANMBKM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct GKGGCIIHGDC
{
	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x882A1B0", Offset = "0x88289B0", VA = "0x18882A1B0")]
	public static Task IHHPLANMBKM(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct IFBINKEFDKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct CMMIPFBNEOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x88223D0", Offset = "0x8820BD0", VA = "0x1888223D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8822900", Offset = "0x8821100", VA = "0x188822900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x882C390", Offset = "0x882AB90", VA = "0x18882C390")]
	[AsyncStateMachine(typeof(CMMIPFBNEOI))]
	public static Task IHHPLANMBKM(PFGLBMLEAGJ JIJELMDGBKG, HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct KDELNINDADB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct PGONMOENGDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public OKNAJCBGHOC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private GBCNJFGJIEN <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private LCLCIAOJCLH <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private GCBHLCMINDE <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private OGBIDEAJDEB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private List<(PersistenceView, KCDFJLGNJKD)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private KCDFJLGNJKD <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8833F10", Offset = "0x8832710", VA = "0x188833F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8834BE0", Offset = "0x88333E0", VA = "0x188834BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x882E890", Offset = "0x882D090", VA = "0x18882E890")]
	[AsyncStateMachine(typeof(PGONMOENGDE))]
	public static Task IHHPLANMBKM(PFGLBMLEAGJ JIJELMDGBKG, HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x882E6A0", Offset = "0x882CEA0", VA = "0x18882E6A0")]
	private static void CIJKHJGPKJK(PersistenceView KBMPEIPJGHK, KCDFJLGNJKD KLFCHOKODFK, HDBLPJBDELH IMINNNCPCJF, GCBHLCMINDE OPEFAJAPNKK, bool MEDOGCKCIKM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct JBFDOBIAONA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct PDGLOABAHHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public GBCNJFGJIEN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private OGBIDEAJDEB <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x8833890", Offset = "0x8832090", VA = "0x188833890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8833EB0", Offset = "0x88326B0", VA = "0x188833EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x882C810", Offset = "0x882B010", VA = "0x18882C810")]
	[AsyncStateMachine(typeof(PDGLOABAHHB))]
	public static Task IHHPLANMBKM(GBCNJFGJIEN KFBGJKCPJCG, HDBLPJBDELH IMINNNCPCJF, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct LMMEKIJJMIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct EBANKOKHHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public GBCNJFGJIEN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x88251E0", Offset = "0x88239E0", VA = "0x1888251E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x88253F0", Offset = "0x8823BF0", VA = "0x1888253F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class LAPPCKMLOJJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public LAPPCKMLOJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x8838520", Offset = "0x8836D20", VA = "0x188838520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x88388B0", Offset = "0x88370B0", VA = "0x1888388B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LAPPCKMLOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x882E9E0", Offset = "0x882D1E0", VA = "0x18882E9E0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task PBMGCDGLEAN(DKKFAAJNJJM<string>.BNLIHIFJPDL timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct AJODPICCOAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public LMMEKIJJMIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private OGBIDEAJDEB <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x8820EC0", Offset = "0x881F6C0", VA = "0x188820EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x8821AB0", Offset = "0x88202B0", VA = "0x188821AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class LPJANLNDEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public EIJMMJGEKKD version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LPJANLNDEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x882F990", Offset = "0x882E190", VA = "0x18882F990")]
		internal object MOALELLFNNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x882FA70", Offset = "0x882E270", VA = "0x18882FA70")]
		internal object OLFIEHHBEKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private HDBLPJBDELH IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private PFGLBMLEAGJ JIJELMDGBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private bool AINDDNJHNBG;

	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private static readonly ByteString CDNBKJMIHHE;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x882F550", Offset = "0x882DD50", VA = "0x18882F550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private OJNDGDMFDGE MOPKMKKOBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x882F860", Offset = "0x882E060", VA = "0x18882F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x882F710", Offset = "0x882DF10", VA = "0x18882F710")]
	[AsyncStateMachine(typeof(EBANKOKHHIF))]
	public static Task IHHPLANMBKM(GBCNJFGJIEN KFBGJKCPJCG, HDBLPJBDELH IMINNNCPCJF, PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD, bool AINDDNJHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x882F5E0", Offset = "0x882DDE0", VA = "0x18882F5E0")]
	[AsyncStateMachine(typeof(AJODPICCOAG))]
	private Task IHHPLANMBKM(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x882ED80", Offset = "0x882D580", VA = "0x18882ED80")]
	private void EFLEPKDIGNN([NotNull] PCENONMPPIA HJPMKOAIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x882F5A0", Offset = "0x882DDA0", VA = "0x18882F5A0")]
	private bool HLDHBALDLBE(EIJMMJGEKKD EHCBHNLMEHF, PCENONMPPIA HJPMKOAIJIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct NAMIJDGJLGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct GEEOHABACAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public AsyncTaskMethodBuilder<HDBLPJBDELH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public NAMIJDGJLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public GHCBELNNDFF.DLOHDJBNJDL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private TaskAwaiter<IReadOnlyCollection<NKFFLFJJKEG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private TaskAwaiter<(AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>, AOGODOAGAAO<AIPBKEKEDCP<PCENONMPPIA>, EMOGOMODAJG>, AOGODOAGAAO<AIPBKEKEDCP<LPIFEJNCBGG>, EMOGOMODAJG>, AOGODOAGAAO<AIPBKEKEDCP<IEnumerable<FLDJPBAHJJH>>, EMOGOMODAJG>, AOGODOAGAAO<AIPBKEKEDCP<IIIOFLMBLND>, EMOGOMODAJG>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8828770", Offset = "0x8826F70", VA = "0x188828770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8829550", Offset = "0x8827D50", VA = "0x188829550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct MHDBIOBDEID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public NAMIJDGJLGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public IReadOnlyCollection<NKFFLFJJKEG> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public IReadOnlyCollection<NKFFLFJJKEG> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public GHCBELNNDFF.DLOHDJBNJDL downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x882FFE0", Offset = "0x882E7E0", VA = "0x18882FFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8830640", Offset = "0x882EE40", VA = "0x188830640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private HLFBGIHNNPP<DOPHJNOBIJD, LPIFEJNCBGG> PJLADNCJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private HLFBGIHNNPP<DOPHJNOBIJD, PCENONMPPIA> DNDGDCFKEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private HLFBGIHNNPP<JNMEENHOMDP, IEnumerable<FLDJPBAHJJH>> GKEDNFKJKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private HLFBGIHNNPP<long, IIIOFLMBLND> JIOOEFCOGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private GCEGIJANLLG IGPAOMIHBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private APAMIKOGBPP DHKAOBLPBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private NKDJCGCAECB JDGDHOJOPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private Guid? DPCIEGDDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private IReadOnlyCollection<NKFFLFJJKEG> ALHNEKAHKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private Task<IReadOnlyCollection<NKFFLFJJKEG>> HGHNIBFLOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private DOPHJNOBIJD NNOJLKJDGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private DOPHJNOBIJD AJDCEEKKJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private DOPHJNOBIJD? JDAKJOCCBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private JNMEENHOMDP ICMOMLFHBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8832970", Offset = "0x8831170", VA = "0x188832970")]
	public static Task<HDBLPJBDELH> OLHNOEOHKGH(GBCNJFGJIEN KFBGJKCPJCG, [In] AKNNNGCPBLB IMINNNCPCJF, GHCBELNNDFF.DLOHDJBNJDL HCDLCJBKMMA, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x8832590", Offset = "0x8830D90", VA = "0x188832590")]
	[AsyncStateMachine(typeof(GEEOHABACAI))]
	private Task<HDBLPJBDELH> IHHPLANMBKM(GHCBELNNDFF.DLOHDJBNJDL HCDLCJBKMMA, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8832740", Offset = "0x8830F40", VA = "0x188832740")]
	[AsyncStateMachine(typeof(MHDBIOBDEID))]
	private Task<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> MHDAFEOFGIN(Guid? DPCIEGDDHDL, IReadOnlyCollection<NKFFLFJJKEG> ALHNEKAHKCI, IReadOnlyCollection<NKFFLFJJKEG> PBOJNIAEAOO, long? GFHIJAKOMMI, long? JPKIDMNFGFI, GHCBELNNDFF.DLOHDJBNJDL HCDLCJBKMMA, DKKFAAJNJJM<string>.BNLIHIFJPDL KHCMHKINFED, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal struct GEIBIIMJHGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct LPLMCPGAFAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public AsyncTaskMethodBuilder<AKNNNGCPBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public GEIBIIMJHGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter<AKNNNGCPBLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x882FB20", Offset = "0x882E320", VA = "0x18882FB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x882FF70", Offset = "0x882E770", VA = "0x18882FF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct FILGEFGACGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<AKNNNGCPBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public GEIBIIMJHGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<AKNNNGCPBLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8827110", Offset = "0x8825910", VA = "0x188827110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8827590", Offset = "0x8825D90", VA = "0x188827590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class CCKPEMGPLIN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public CCKPEMGPLIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			private TaskAwaiter<ONHIKKMCJNF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private TaskAwaiter<ICAKPDKFOPO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x8835970", Offset = "0x8834170", VA = "0x188835970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x8836310", Offset = "0x8834B10", VA = "0x188836310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public HMKJDDPKDJE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public LCLCIAOJCLH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public DOPHJNOBIJD superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public DOPHJNOBIJD subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public IReadOnlyList<NKFFLFJJKEG> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public IReadOnlyList<NKFFLFJJKEG> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public APAMIKOGBPP roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CCKPEMGPLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xEF4A90", Offset = "0xEF3290", VA = "0x180EF4A90")]
		internal bool PEJCEKEIKEP(NKDJCGCAECB sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x8821B10", Offset = "0x8820310", VA = "0x188821B10")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task HIHMIMLNLBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x8821BE0", Offset = "0x88203E0", VA = "0x188821BE0")]
		internal Task<JNMEENHOMDP> KEOKEHGNBJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct DHHAOFJGBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public AsyncTaskMethodBuilder<AKNNNGCPBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public HMKJDDPKDJE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public LCLCIAOJCLH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public DOPHJNOBIJD superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private CCKPEMGPLIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private NKDJCGCAECB <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private Task<JNMEENHOMDP> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private TaskAwaiter<APAMIKOGBPP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<JNMEENHOMDP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x8823A20", Offset = "0x8822220", VA = "0x188823A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x88249D0", Offset = "0x88231D0", VA = "0x1888249D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private PPOCKLEIMOO BDNIHLNLANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private HMKJDDPKDJE IKOMEIGHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private long GFHIJAKOMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private long PALELGDJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private long LOHFPFAAEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private string IDCDGEEOELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private DOPHJNOBIJD HPJLEAECCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private Guid NDKDLCGCOIH;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x8829A80", Offset = "0x8828280", VA = "0x188829A80")]
	public static Task<AKNNNGCPBLB> OLHNOEOHKGH(GBCNJFGJIEN KFBGJKCPJCG, FNDPEECNEPD FLPDPHNPDPK, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x8829900", Offset = "0x8828100", VA = "0x188829900")]
	[AsyncStateMachine(typeof(LPLMCPGAFAC))]
	private Task<AKNNNGCPBLB> IHHPLANMBKM(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8829790", Offset = "0x8827F90", VA = "0x188829790")]
	[AsyncStateMachine(typeof(FILGEFGACGL))]
	private Task<AKNNNGCPBLB> EDEDKBENDMH(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x88295C0", Offset = "0x8827DC0", VA = "0x1888295C0")]
	[AsyncStateMachine(typeof(DHHAOFJGBCN))]
	private static Task<AKNNNGCPBLB> EDEDKBENDMH(LCLCIAOJCLH PJHMONPOPCI, HMKJDDPKDJE IKOMEIGHHPE, long GFHIJAKOMMI, long PALELGDJJCI, long LOHFPFAAEFB, string IDCDGEEOELI, DOPHJNOBIJD HPJLEAECCJJ, Guid NDKDLCGCOIH, CancellationToken GMEAHOBHMAD, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8829A50", Offset = "0x8828250", VA = "0x188829A50")]
	private void LLCLADGDHDA(APAMIKOGBPP DHKAOBLPBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct PIMNKHGKHAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct CLKDCDFKBDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public PIMNKHGKHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8821DE0", Offset = "0x88205E0", VA = "0x188821DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8822370", Offset = "0x8820B70", VA = "0x188822370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private HDBLPJBDELH IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private float EDPKJIGHPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private float NEEBJLFPMBH;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x88350D0", Offset = "0x88338D0", VA = "0x1888350D0")]
	public static Task OFEFEEAGGBH(GBCNJFGJIEN KFBGJKCPJCG, HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x8834FB0", Offset = "0x88337B0", VA = "0x188834FB0")]
	[AsyncStateMachine(typeof(CLKDCDFKBDP))]
	public Task IHHPLANMBKM(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8834C40", Offset = "0x8833440", VA = "0x188834C40")]
	private static void ACJEODEFKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8834D90", Offset = "0x8833590", VA = "0x188834D90")]
	private void GHGBGBLNFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8834EF0", Offset = "0x88336F0", VA = "0x188834EF0")]
	private static float GONIIMBMHHO(LCLCIAOJCLH PJHMONPOPCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8834D70", Offset = "0x8833570", VA = "0x188834D70")]
	private static float CDKBNFGANAL()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct HAMPAONPKCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct CONHDBHIFNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public PFGLBMLEAGJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private FBBNOBMBACD <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private GBCNJFGJIEN <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private FGELNPKJIIC.BFIPINPEFFD <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8822C30", Offset = "0x8821430", VA = "0x188822C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8823420", Offset = "0x8821C20", VA = "0x188823420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct KCODMCBJJMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x882E310", Offset = "0x882CB10", VA = "0x18882E310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x882E640", Offset = "0x882CE40", VA = "0x18882E640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x882A3C0", Offset = "0x8828BC0", VA = "0x18882A3C0")]
	[AsyncStateMachine(typeof(CONHDBHIFNE))]
	public static Task IHHPLANMBKM(PFGLBMLEAGJ JIJELMDGBKG, HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x882A350", Offset = "0x8828B50", VA = "0x18882A350")]
	private static Task<EMOHKBNEAPF> DHANOMMAICP(PFGLBMLEAGJ JIJELMDGBKG, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x882A290", Offset = "0x8828A90", VA = "0x18882A290")]
	[AsyncStateMachine(typeof(KCODMCBJJMC))]
	private static Task CJBHGGIAAAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct FAKJPAPLCPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct JNGCBJAFDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public FAKJPAPLCPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x882DB20", Offset = "0x882C320", VA = "0x18882DB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x882E2B0", Offset = "0x882CAB0", VA = "0x18882E2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class DDJABLIJFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DDJABLIJFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8823480", Offset = "0x8821C80", VA = "0x188823480")]
		internal object MEBKJELLLIK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct GGPNADOOJIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public FAKJPAPLCPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x8829CD0", Offset = "0x88284D0", VA = "0x188829CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x882A150", Offset = "0x8828950", VA = "0x18882A150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private bool OCFMOBPOKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private CancellationToken GMEAHOBHMAD;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x8826510", Offset = "0x8824D10", VA = "0x188826510")]
	public static Task KCFFIOGPCBO(GBCNJFGJIEN KFBGJKCPJCG, bool OCFMOBPOKDN, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken LDELJMOBLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x8826420", Offset = "0x8824C20", VA = "0x188826420")]
	[AsyncStateMachine(typeof(JNGCBJAFDMH))]
	private Task IHHPLANMBKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x88262F0", Offset = "0x8824AF0", VA = "0x1888262F0")]
	[AsyncStateMachine(typeof(GGPNADOOJIG))]
	private Task FOMKMKIMNFC(bool JBDNOPCAAAA, string ANDNLMEHDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	private bool CPLKDDODBEO(bool OCFMOBPOKDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct POGMDECEJEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct GCNLECFLOFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public POGMDECEJEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8828240", Offset = "0x8826A40", VA = "0x188828240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8828700", Offset = "0x8826F00", VA = "0x188828700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class AFFBGFEBAJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AFFBGFEBAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8820E70", Offset = "0x881F670", VA = "0x188820E70")]
		internal object MEBKJELLLIK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct NHDENKPGCAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public POGMDECEJEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x88333A0", Offset = "0x8831BA0", VA = "0x1888333A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8833820", Offset = "0x8832020", VA = "0x188833820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private LHHDAKGDNFC IMKDEFCBMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x88356D0", Offset = "0x8833ED0", VA = "0x1888356D0")]
	public static Task<Scene> BNLBKJPCBHA(GBCNJFGJIEN KFBGJKCPJCG, LHHDAKGDNFC MMPENJEHMAH, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x8835860", Offset = "0x8834060", VA = "0x188835860")]
	[AsyncStateMachine(typeof(GCNLECFLOFH))]
	private Task<Scene> IHHPLANMBKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8835720", Offset = "0x8833F20", VA = "0x188835720")]
	[AsyncStateMachine(typeof(NHDENKPGCAL))]
	private Task<Scene> FOMKMKIMNFC(string ANDNLMEHDMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct ECOFHGCCJEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct LJJCECJCFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public ECOFHGCCJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public GCBHLCMINDE nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public HDBLPJBDELH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<GCBHLCMINDE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8845910", Offset = "0x8844110", VA = "0x188845910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x88463E0", Offset = "0x8844BE0", VA = "0x1888463E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct GNALLHAAKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public AsyncTaskMethodBuilder<GCBHLCMINDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public ECOFHGCCJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public GCBHLCMINDE state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8840730", Offset = "0x883EF30", VA = "0x188840730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8840A10", Offset = "0x883F210", VA = "0x188840A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private readonly PFGLBMLEAGJ JIJELMDGBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private readonly PPOCKLEIMOO BDNIHLNLANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private readonly PDACHEGIGFD FGOIOHAJMCJ;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private FBBNOBMBACD FJOIPOCPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6C84810", Offset = "0x6C83010", VA = "0x186C84810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x883C550", Offset = "0x883AD50", VA = "0x18883C550")]
	public ECOFHGCCJEJ(PFGLBMLEAGJ JIJELMDGBKG, PPOCKLEIMOO BDNIHLNLANP, PDACHEGIGFD FGOIOHAJMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x883C220", Offset = "0x883AA20", VA = "0x18883C220")]
	[AsyncStateMachine(typeof(LJJCECJCFMG))]
	public Task<GCBHLCMINDE> KLDAKOBNPND(GCBHLCMINDE OBOACBHAEMF, HDBLPJBDELH ODEKLFJBJKH, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD, bool BOGLLAFBJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x883C3A0", Offset = "0x883ABA0", VA = "0x18883C3A0")]
	[AsyncStateMachine(typeof(GNALLHAAKPK))]
	private Task<GCBHLCMINDE> LDPEMFHNKFM(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, GCBHLCMINDE OJGLGPLNKGO, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x883C520", Offset = "0x883AD20", VA = "0x18883C520")]
	private bool PJMGLPOGPKE(GCBHLCMINDE GAJBGKFMEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x883C500", Offset = "0x883AD00", VA = "0x18883C500")]
	private void MIHGFEDHECA(string INDBGIPGMPI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal struct LCDBHMIENLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct MIEOPAACIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public FBBNOBMBACD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public OKNAJCBGHOC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private OGBIDEAJDEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private List<(PersistenceView, KCDFJLGNJKD)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private (PersistenceView, KCDFJLGNJKD) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x88472A0", Offset = "0x8845AA0", VA = "0x1888472A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8847960", Offset = "0x8846160", VA = "0x188847960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x88452A0", Offset = "0x8843AA0", VA = "0x1888452A0")]
	[AsyncStateMachine(typeof(MIEOPAACIFI))]
	public static Task IHHPLANMBKM(FBBNOBMBACD OPKHOBALIGI, HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal struct MODAEIPDALH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct HLJOOIFCAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public FBBNOBMBACD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public OKNAJCBGHOC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private EIJMMJGEKKD <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private OGBIDEAJDEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private List<(PersistenceView, KCDFJLGNJKD)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private KCDFJLGNJKD <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8841A80", Offset = "0x8840280", VA = "0x188841A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8842360", Offset = "0x8840B60", VA = "0x188842360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x8847AF0", Offset = "0x88462F0", VA = "0x188847AF0")]
	[AsyncStateMachine(typeof(HLJOOIFCAOO))]
	public static Task IHHPLANMBKM(FBBNOBMBACD OPKHOBALIGI, HDBLPJBDELH IMINNNCPCJF, OKNAJCBGHOC FCDDFBOPGBB, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public struct HPCDIEHLOFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct KNGJALEHCLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public HPCDIEHLOFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public GHCBELNNDFF.DLOHDJBNJDL preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8844550", Offset = "0x8842D50", VA = "0x188844550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8844BC0", Offset = "0x88433C0", VA = "0x188844BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private long AHDFOGAPKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private long OJAHBGGPHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private Guid? OFPJGHJANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private IReadOnlyCollection<NKFFLFJJKEG> JOKCELAOFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private IReadOnlyCollection<NKFFLFJJKEG> GENKNEILGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private GCEGIJANLLG LLPIJJOKLGJ;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x8843110", Offset = "0x8841910", VA = "0x188843110")]
	public static Task<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> OLHNOEOHKGH(long GFHIJAKOMMI, long PALELGDJJCI, ICAKPDKFOPO GDFDNNEAGGD, GHCBELNNDFF.DLOHDJBNJDL MHFCBFDLJCK, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x8842FB0", Offset = "0x88417B0", VA = "0x188842FB0")]
	[AsyncStateMachine(typeof(KNGJALEHCLI))]
	private Task<AOGODOAGAAO<JIIEGHGACCB, EMOGOMODAJG>> IHHPLANMBKM(GHCBELNNDFF.DLOHDJBNJDL MHFCBFDLJCK, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal struct FGELNPKJIIC
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public struct BFIPINPEFFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public List<BIIFDOPFNJN> NCEIMJCDMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public List<KCDFJLGNJKD> EPLCEGHJHBL;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
		public BFIPINPEFFD(List<BIIFDOPFNJN> NCEIMJCDMJN, List<KCDFJLGNJKD> EPLCEGHJHBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class ANHJJGPHOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public IEnumerable<BIIFDOPFNJN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ANHJJGPHOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x88390A0", Offset = "0x88378A0", VA = "0x1888390A0")]
		internal object IKMGKDGPMBC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private GBCNJFGJIEN KFBGJKCPJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private HDBLPJBDELH IMINNNCPCJF;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private LCLCIAOJCLH COAFEMCPNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x883E5C0", Offset = "0x883CDC0", VA = "0x18883E5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x883E610", Offset = "0x883CE10", VA = "0x18883E610")]
	public static BFIPINPEFFD IHHPLANMBKM(GBCNJFGJIEN KFBGJKCPJCG, HDBLPJBDELH IMINNNCPCJF)
	{
		return default(BFIPINPEFFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x883E670", Offset = "0x883CE70", VA = "0x18883E670")]
	private BFIPINPEFFD IHHPLANMBKM()
	{
		return default(BFIPINPEFFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x883E020", Offset = "0x883C820", VA = "0x18883E020")]
	private BFIPINPEFFD CDLCBBPKMAB(PCENONMPPIA HJPMKOAIJIF, EIJMMJGEKKD PKBNMPFIAIA)
	{
		return default(BFIPINPEFFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x883E8C0", Offset = "0x883D0C0", VA = "0x18883E8C0")]
	private bool JCKNENGPJAH(IEnumerable<BIIFDOPFNJN> NCEIMJCDMJN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018A")]
internal struct GKGONINFMKL
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class KLLLMAAFBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public FGELNPKJIIC.BFIPINPEFFD instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KLLLMAAFBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x88444A0", Offset = "0x8842CA0", VA = "0x1888444A0")]
		internal object PBMGCDGLEAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class NLIANFKKONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NLIANFKKONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8849970", Offset = "0x8848170", VA = "0x188849970")]
		internal object JNGMFGJFBPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x8840180", Offset = "0x883E980", VA = "0x188840180")]
	public static void IHHPLANMBKM(FBBNOBMBACD OPKHOBALIGI, HDBLPJBDELH IMINNNCPCJF, FGELNPKJIIC.BFIPINPEFFD NMJFIMAAOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal class PDACHEGIGFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct FHEEFGIEFFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public GCBHLCMINDE operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public HDBLPJBDELH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x883EA90", Offset = "0x883D290", VA = "0x18883EA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x883F200", Offset = "0x883DA00", VA = "0x18883F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class MGLPPDLODJP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public MGLPPDLODJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x884DEC0", Offset = "0x884C6C0", VA = "0x18884DEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x884E180", Offset = "0x884C980", VA = "0x18884E180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MGLPPDLODJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8846B20", Offset = "0x8845320", VA = "0x188846B20")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task PGECLJAMOHD(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct OPGNFIMLPOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private MGLPPDLODJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x884B580", Offset = "0x8849D80", VA = "0x18884B580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x884BAB0", Offset = "0x884A2B0", VA = "0x18884BAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct LAIOEIBIGHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private Dictionary<Guid, List<NDDLKPKFGHA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8844C30", Offset = "0x8843430", VA = "0x188844C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8845240", Offset = "0x8843A40", VA = "0x188845240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct ICNFNHCNKGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private Dictionary<Guid, List<NDDLKPKFGHA>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x88432F0", Offset = "0x8841AF0", VA = "0x1888432F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8843990", Offset = "0x8842190", VA = "0x188843990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class ABDOLGDLNIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			public NDDLKPKFGHA handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			public ABDOLGDLNIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			private OGBIDEAJDEB <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x884DA00", Offset = "0x884C200", VA = "0x18884DA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x884DE60", Offset = "0x884C660", VA = "0x18884DE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public GCBLKAHKCKN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public List<NDDLKPKFGHA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ABDOLGDLNIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8838DC0", Offset = "0x88375C0", VA = "0x188838DC0")]
		internal object LJKKLNGKDHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8838EB0", Offset = "0x88376B0", VA = "0x188838EB0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task MOBAAMNPIEI(NDDLKPKFGHA handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8838FB0", Offset = "0x88377B0", VA = "0x188838FB0")]
		internal object ODDIEECKOIG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct LDMHKFFJIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public GCBLKAHKCKN runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public List<NDDLKPKFGHA> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private ABDOLGDLNIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x88453E0", Offset = "0x8843BE0", VA = "0x1888453E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x88458B0", Offset = "0x88440B0", VA = "0x1888458B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct OJEHIJMOMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x884A960", Offset = "0x8849160", VA = "0x18884A960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x884AF20", Offset = "0x8849720", VA = "0x18884AF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class OKPAAKMLPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OKPAAKMLPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x884AFF0", Offset = "0x88497F0", VA = "0x18884AFF0")]
		internal object MJKIKIJDIIA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct CCBJDMMNMJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public HDBLPJBDELH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x883A490", Offset = "0x8838C90", VA = "0x18883A490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x883A950", Offset = "0x8839150", VA = "0x18883A950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class COBHEFDEJLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public COBHEFDEJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x883BA20", Offset = "0x883A220", VA = "0x18883BA20")]
		internal object HPKIDJEGELA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct MHOEFLKGKAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public PDACHEGIGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private OGBIDEAJDEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x8846C10", Offset = "0x8845410", VA = "0x188846C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8847240", Offset = "0x8845A40", VA = "0x188847240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class OKMIOHLOPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public OKMIOHLOPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x884AF80", Offset = "0x8849780", VA = "0x18884AF80")]
		internal object NPHLIGOODDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private readonly PFGLBMLEAGJ JIJELMDGBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private MPEICGEBDOI FGOIOHAJMCJ;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private FBBNOBMBACD FJOIPOCPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x115AC40", Offset = "0x1159440", VA = "0x18115AC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public PDACHEGIGFD(PFGLBMLEAGJ JIJELMDGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x884CA30", Offset = "0x884B230", VA = "0x18884CA30")]
	[AsyncStateMachine(typeof(FHEEFGIEFFJ))]
	public Task IHHPLANMBKM(GCBHLCMINDE OPEFAJAPNKK, HDBLPJBDELH ODEKLFJBJKH, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x884C8F0", Offset = "0x884B0F0", VA = "0x18884C8F0")]
	[AsyncStateMachine(typeof(OPGNFIMLPOJ))]
	private Task CJMAFILHIFA(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x884C670", Offset = "0x884AE70", VA = "0x18884C670")]
	[AsyncStateMachine(typeof(LAIOEIBIGHA))]
	private Task CANFJNJNCPG(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x884CB80", Offset = "0x884B380", VA = "0x18884CB80")]
	[AsyncStateMachine(typeof(ICNFNHCNKGI))]
	private Task INPPNHIOOAH(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x884C3E0", Offset = "0x884ABE0", VA = "0x18884C3E0")]
	[AsyncStateMachine(typeof(LDMHKFFJIPK))]
	private Task BDOJHCOKOEB(Guid ICKGBHIKCJF, List<NDDLKPKFGHA> BNPDOGNNGFN, GCBLKAHKCKN JDGLHNMLCLI, HDBLPJBDELH IMINNNCPCJF, CancellationToken KAJENDFCCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x884C7B0", Offset = "0x884AFB0", VA = "0x18884C7B0")]
	[AsyncStateMachine(typeof(OJEHIJMOMBC))]
	private Task CEPPEDHMHNA(HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x884C530", Offset = "0x884AD30", VA = "0x18884C530")]
	[AsyncStateMachine(typeof(CCBJDMMNMJB))]
	private Task BEICAHPFMPF(Guid JDCJGOFNLAM, HDBLPJBDELH IMINNNCPCJF, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x884D050", Offset = "0x884B850", VA = "0x18884D050")]
	[AsyncStateMachine(typeof(MHOEFLKGKAM))]
	private Task LOCGBIGAMHJ(Guid JDCJGOFNLAM, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x884CD70", Offset = "0x884B570", VA = "0x18884CD70")]
	private void KPOCHCJMJKD(Guid JDCJGOFNLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x884CCC0", Offset = "0x884B4C0", VA = "0x18884CCC0")]
	private void JCDNKJICJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x884D190", Offset = "0x884B990", VA = "0x18884D190")]
	public Guid MMENHEDJDBB(GCBHLCMINDE IEDCMDGFNJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x884CE80", Offset = "0x884B680", VA = "0x18884CE80")]
	[CompilerGenerated]
	private object LJKBCAJOEEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal struct DCJKIJKGMFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private struct FBECDADGGNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public DCJKIJKGMFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private IEnumerator<JEEIKNNKFIG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x883D930", Offset = "0x883C130", VA = "0x18883D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x883DFC0", Offset = "0x883C7C0", VA = "0x18883DFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private LCLCIAOJCLH PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private CancellationToken GMEAHOBHMAD;

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x883BA90", Offset = "0x883A290", VA = "0x18883BA90")]
	public static Task ECMBMDNJEPM(LCLCIAOJCLH PJHMONPOPCI, DKKFAAJNJJM<string>.BNLIHIFJPDL PFLKFIDCFJL, CancellationToken LDELJMOBLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x883BB00", Offset = "0x883A300", VA = "0x18883BB00")]
	[AsyncStateMachine(typeof(FBECDADGGNJ))]
	private Task IHHPLANMBKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct CJEMFAOCIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000754")]
	public readonly bool HOCNJNHDHFO;

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2AA99A0", Offset = "0x2AA81A0", VA = "0x182AA99A0")]
	public CJEMFAOCIIJ(bool JPOKAPECOCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct DEGIKKCKCON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000755")]
	public readonly PCENONMPPIA? DFCJEOFDNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000756")]
	public readonly CPEHNNLLNFC BCNLIIGKNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000757")]
	public readonly Guid? LABAJPNFKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000758")]
	public readonly IReadOnlyList<Guid> ELJIJKEEFKK;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> GKPBEEBGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x883BC10", Offset = "0x883A410", VA = "0x18883BC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> KFIMNMDFLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x883BBF0", Offset = "0x883A3F0", VA = "0x18883BBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x883BC30", Offset = "0x883A430", VA = "0x18883BC30")]
	public DEGIKKCKCON(PCENONMPPIA? JPCNIAHCHAA, CPEHNNLLNFC GGIBBOPHGMM, Guid? DPCIEGDDHDL, [Optional] IReadOnlyList<Guid>? CCBBJFIGLKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class NGIDKHHJHBP : MENJONJGINP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private struct PKBADEAOIHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public AsyncTaskMethodBuilder<DEGIKKCKCON> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public NGIDKHHJHBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public KPMJFDCAFMO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public LGGCFGKNFLP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private OGBIDEAJDEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x884D2F0", Offset = "0x884BAF0", VA = "0x18884D2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x884D990", Offset = "0x884C190", VA = "0x18884D990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class IEIELAAOAMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IEIELAAOAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x88439F0", Offset = "0x88421F0", VA = "0x1888439F0")]
		internal object CHEJECADPAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct MOPBBCOIDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public NGIDKHHJHBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public KPMJFDCAFMO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private IEIELAAOAMB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private OGBIDEAJDEB <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private FJODPEEPKJK<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8847C30", Offset = "0x8846430", VA = "0x188847C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x88486F0", Offset = "0x8846EF0", VA = "0x1888486F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000759")]
	private readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400075A")]
	private static readonly TimeSpan BMIEJNHEFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	private readonly KLJDHLNOMBG LPBIMLHBFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	private readonly GGLIHEOLBGE APGPNEDLHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private readonly OPOPFKFGIIF KACCHIAMMPH;

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x8849900", Offset = "0x8848100", VA = "0x188849900")]
	public NGIDKHHJHBP(PFGLBMLEAGJ JIJELMDGBKG, KLJDHLNOMBG LPBIMLHBFNF, GGLIHEOLBGE MNCBLJEFFEN, OPOPFKFGIIF KACCHIAMMPH, BMELPJIFPCL GLHOMCPEEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8848E30", Offset = "0x8847630", VA = "0x188848E30")]
	[AsyncStateMachine(typeof(PKBADEAOIHJ))]
	public Task<DEGIKKCKCON> GJCNJFECIPF(long PALELGDJJCI, LGGCFGKNFLP FJEKLENGBNA, KPMJFDCAFMO IENPLAMADNI, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8849140", Offset = "0x8847940", VA = "0x188849140")]
	[AsyncStateMachine(typeof(MOPBBCOIDBK))]
	private Task LHLBGNAABFI(KPMJFDCAFMO IENPLAMADNI, PersistenceView[] BFFKMICOINP, StringBuilder AODPCCFEJMC, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8849280", Offset = "0x8847A80", VA = "0x188849280")]
	private DEGIKKCKCON PHJNBFPJLEA(long PALELGDJJCI, LGGCFGKNFLP FJEKLENGBNA, KPMJFDCAFMO IENPLAMADNI, IEnumerable<PersistenceView> BFFKMICOINP, StringBuilder AODPCCFEJMC)
	{
		return default(DEGIKKCKCON);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8848F80", Offset = "0x8847780", VA = "0x188848F80")]
	private PCENONMPPIA HDKBNHOGHDL(long PALELGDJJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8848750", Offset = "0x8846F50", VA = "0x188848750")]
	private void CBGHDLMMNPL(PCENONMPPIA NOLICNPKGGN, StringBuilder AODPCCFEJMC, IEnumerable<PersistenceView> BFFKMICOINP, [In] GBMCNLAFKHG GPCIEMBEENL, OMLKBKDLMOE DKALKIDHLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x88489A0", Offset = "0x88471A0", VA = "0x1888489A0")]
	private void FGCKPBLJKCC(PCENONMPPIA NOLICNPKGGN, StringBuilder AODPCCFEJMC, PersistenceView KBMPEIPJGHK, OMLKBKDLMOE DKALKIDHLCF, [In] GBMCNLAFKHG GPCIEMBEENL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class HNJJKGPLGCF : MENJONJGINP
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class GHKNGJNNHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public IDMHOPBDNKH.BIGFGOMMGOB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GHKNGJNNHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8840130", Offset = "0x883E930", VA = "0x188840130")]
		internal object OLHKAMMEEBJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct IICAJAKNDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public AsyncTaskMethodBuilder<(IDMHOPBDNKH.BIGFGOMMGOB roomDataUpload, IDMHOPBDNKH.BIGFGOMMGOB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public DEGIKKCKCON roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public LCLCIAOJCLH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private GHKNGJNNHBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		private TaskAwaiter<IDMHOPBDNKH.BIGFGOMMGOB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x8843BB0", Offset = "0x88423B0", VA = "0x188843BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x8844430", Offset = "0x8842C30", VA = "0x188844430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct GNGHDENOBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public AsyncTaskMethodBuilder<IPCPPGKOOOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public HNJJKGPLGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public LGOJJLPEJAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public DEGIKKCKCON roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		private TaskAwaiter<IPCPPGKOOOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8840A80", Offset = "0x883F280", VA = "0x188840A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8840D20", Offset = "0x883F520", VA = "0x188840D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct BEAOHCDNBFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public AsyncTaskMethodBuilder<IPCPPGKOOOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public LCLCIAOJCLH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public DEGIKKCKCON roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public NKBADGLOMOI ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public LGOJJLPEJAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private TaskAwaiter<(IDMHOPBDNKH.BIGFGOMMGOB roomDataUpload, IDMHOPBDNKH.BIGFGOMMGOB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private TaskAwaiter<IPCPPGKOOOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8839C20", Offset = "0x8838420", VA = "0x188839C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x883A280", Offset = "0x8838A80", VA = "0x18883A280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct OLKKJFHAGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public AsyncTaskMethodBuilder<ONHIKKMCJNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public HNJJKGPLGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public DEGIKKCKCON roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private TaskAwaiter<(IDMHOPBDNKH.BIGFGOMMGOB roomDataUpload, IDMHOPBDNKH.BIGFGOMMGOB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private TaskAwaiter<ONHIKKMCJNF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x884B060", Offset = "0x8849860", VA = "0x18884B060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x884B510", Offset = "0x8849D10", VA = "0x18884B510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class MOCAAHPJLOO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public MOCAAHPJLOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private EMOHKBNEAPF <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			private TaskAwaiter<ONHIKKMCJNF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			private TaskAwaiter<IPCPPGKOOOH> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private TaskAwaiter<EMOHKBNEAPF> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x884E1E0", Offset = "0x884C9E0", VA = "0x18884E1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x884F3E0", Offset = "0x884DBE0", VA = "0x18884F3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public HNJJKGPLGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public DEGIKKCKCON roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public LGOJJLPEJAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public CJEMFAOCIIJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MOCAAHPJLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x88479C0", Offset = "0x88461C0", VA = "0x1888479C0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<EMOHKBNEAPF> LBEMFFHOHHO(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[CompilerGenerated]
	private struct LNCOMFEFHHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public AsyncTaskMethodBuilder<EMOHKBNEAPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		public HNJJKGPLGCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		public DEGIKKCKCON roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public LGOJJLPEJAM roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public CJEMFAOCIIJ roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private TaskAwaiter<EMOHKBNEAPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8846780", Offset = "0x8844F80", VA = "0x188846780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8846AB0", Offset = "0x88452B0", VA = "0x188846AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000777")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000778")]
	private static readonly BMELPJIFPCL LPCJBOPABGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000779")]
	private readonly JKMJAAFFHDI CNEHMBOCOLK;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private GBCNJFGJIEN BLNHNPMGAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x880FDE0", Offset = "0x880E5E0", VA = "0x18880FDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x8842F20", Offset = "0x8841720", VA = "0x188842F20")]
	public HNJJKGPLGCF(PFGLBMLEAGJ JIJELMDGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x8842570", Offset = "0x8840D70", VA = "0x188842570")]
	[AsyncStateMachine(typeof(IICAJAKNDDE))]
	private static Task<(IDMHOPBDNKH.BIGFGOMMGOB, IDMHOPBDNKH.BIGFGOMMGOB)> EBPKAJADOFG(LCLCIAOJCLH PJHMONPOPCI, DEGIKKCKCON DFDCIIBGMEI, long GFHIJAKOMMI, long JPKIDMNFGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x8842B90", Offset = "0x8841390", VA = "0x188842B90")]
	[AsyncStateMachine(typeof(GNGHDENOBAH))]
	public Task<IPCPPGKOOOH> IBOAEEMIFLC(int JPILDFAPLHD, [CanBeNull] LGOJJLPEJAM DKGHDKKALOF, DEGIKKCKCON DFDCIIBGMEI, long GFHIJAKOMMI, long JPKIDMNFGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8842840", Offset = "0x8841040", VA = "0x188842840")]
	public static Task<IPCPPGKOOOH> IBOAEEMIFLC(LCLCIAOJCLH PJHMONPOPCI, int JPILDFAPLHD, [CanBeNull] LGOJJLPEJAM DKGHDKKALOF, DEGIKKCKCON DFDCIIBGMEI, long GFHIJAKOMMI, long JPKIDMNFGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8842D00", Offset = "0x8841500", VA = "0x188842D00")]
	[AsyncStateMachine(typeof(BEAOHCDNBFL))]
	public static Task<IPCPPGKOOOH> IBOAEEMIFLC(LCLCIAOJCLH PJHMONPOPCI, int JPILDFAPLHD, [CanBeNull] LGOJJLPEJAM DKGHDKKALOF, DEGIKKCKCON DFDCIIBGMEI, long GFHIJAKOMMI, long JPKIDMNFGFI, NKBADGLOMOI LIEIGDIKGDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x88426C0", Offset = "0x8840EC0", VA = "0x1888426C0")]
	[AsyncStateMachine(typeof(OLKKJFHAGPB))]
	private Task<ONHIKKMCJNF> GJPDCMPMLCJ(string IDCDGEEOELI, int JPILDFAPLHD, DEGIKKCKCON DFDCIIBGMEI, long GFHIJAKOMMI, long JPKIDMNFGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x88423C0", Offset = "0x8840BC0", VA = "0x1888423C0")]
	[AsyncStateMachine(typeof(LNCOMFEFHHH))]
	public Task<EMOHKBNEAPF> AOKIMNOGLDG(int JPILDFAPLHD, LGOJJLPEJAM? DKGHDKKALOF, DEGIKKCKCON DFDCIIBGMEI, long GFHIJAKOMMI, long JPKIDMNFGFI, CJEMFAOCIIJ DGAEEKANLFD, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public abstract class OPBILCPNOPH<T> where T : OPBILCPNOPH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007BF")]
	internal readonly GBCNJFGJIEN MHHCFOMAHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private int? PGMFMDDAFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	protected readonly Guid LNALCBHAJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C2")]
	protected readonly PKPMCPGHFJB KEJHOGOPNPO;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T GPPFAMGBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x5769090", Offset = "0x5767890", VA = "0x185769090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x57691A0", Offset = "0x57679A0", VA = "0x1857691A0")]
	internal OPBILCPNOPH(GBCNJFGJIEN ADGAANLDCJF, PKPMCPGHFJB HFFJJCGAECD, [Optional] Guid? GKMDGNFGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x5768DE0", Offset = "0x57675E0", VA = "0x185768DE0")]
	private EMOHKBNEAPF FEFMFNJKCCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	protected virtual void NLIONEAGNPM(EMOHKBNEAPF ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x5768EC0", Offset = "0x57676C0", VA = "0x185768EC0")]
	public T FFMEFEBABDI(EIGONBNGIIK PCJIBHNFPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x57690F0", Offset = "0x57678F0", VA = "0x1857690F0")]
	public T OOBPKBLOLDG(int IGOIMDCLCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x5768F60", Offset = "0x5767760", VA = "0x185768F60", Slot = "5")]
	public virtual Task<AKIGBGIOJEO> JCCPKFNHPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class BINJDAAAAED : OPBILCPNOPH<BINJDAAAAED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C3")]
	private FNDPEECNEPD OILJBDLKBKC;

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x883A3C0", Offset = "0x8838BC0", VA = "0x18883A3C0")]
	internal BINJDAAAAED(GBCNJFGJIEN ADGAANLDCJF, PKPMCPGHFJB HFFJJCGAECD, [Optional] Guid? GKMDGNFGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FFC0", Offset = "0x7A6E7C0", VA = "0x187A6FFC0")]
	public BINJDAAAAED FKLGCNOOJBJ(FNDPEECNEPD OILJBDLKBKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x883A2F0", Offset = "0x8838AF0", VA = "0x18883A2F0", Slot = "4")]
	protected override void NLIONEAGNPM(EMOHKBNEAPF ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class NONBIIEEFGF : OPBILCPNOPH<NONBIIEEFGF>
{
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	internal enum OOEKBHHDFIA
	{
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	private struct FPAPAGAOBLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		public AsyncTaskMethodBuilder<AKIGBGIOJEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		public NONBIIEEFGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private TaskAwaiter<AKIGBGIOJEO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x883FD20", Offset = "0x883E520", VA = "0x18883FD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x88400C0", Offset = "0x883E8C0", VA = "0x1888400C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private OOEKBHHDFIA CMIKGJDNPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	private string MDJLMNNFAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private LGOJJLPEJAM OILJBDLKBKC;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8849D40", Offset = "0x8848540", VA = "0x188849D40")]
	internal NONBIIEEFGF(GBCNJFGJIEN ADGAANLDCJF, PKPMCPGHFJB HFFJJCGAECD, [Optional] Guid? GKMDGNFGEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x8849B30", Offset = "0x8848330", VA = "0x188849B30")]
	public NONBIIEEFGF JOBOPCDEELN(string LLAMBGFCPPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8849D00", Offset = "0x8848500", VA = "0x188849D00")]
	public NONBIIEEFGF NPFLPOOFAHM(bool OIHOLKOGHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8849D20", Offset = "0x8848520", VA = "0x188849D20")]
	public NONBIIEEFGF PHGNLOIFLCC(bool FHPPCLLPBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8849B60", Offset = "0x8848360", VA = "0x188849B60")]
	public NONBIIEEFGF LDFCDPKEOGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x8849B90", Offset = "0x8848390", VA = "0x188849B90", Slot = "4")]
	protected override void NLIONEAGNPM(EMOHKBNEAPF ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8849A40", Offset = "0x8848240", VA = "0x188849A40", Slot = "5")]
	[AsyncStateMachine(typeof(FPAPAGAOBLM))]
	public override Task<AKIGBGIOJEO> JCCPKFNHPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8849A00", Offset = "0x8848200", VA = "0x188849A00")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<AKIGBGIOJEO> FIFBFGFEIEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal static class DLDHGIFMFFN
{
	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x883BD30", Offset = "0x883A530", VA = "0x18883BD30")]
	public static void IACDNCKHCBP(this EKOGFCEADNG PHJAGJLEMPF, LOAOCAFLNEN ICJPMJPGKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x883BE80", Offset = "0x883A680", VA = "0x18883BE80")]
	public static void MIPBPHHAPGG(this LOAOCAFLNEN NLKCLNKGHKO, [Optional] string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public static class IGDPFCFHAFK
{
	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x8843B10", Offset = "0x8842310", VA = "0x188843B10")]
	public static DOPHJNOBIJD JGFDMHOFGAK(this JFGLICMFKEJ PMNEIJLJOEE)
	{
		return default(DOPHJNOBIJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8843A60", Offset = "0x8842260", VA = "0x188843A60")]
	public static JFGLICMFKEJ EKAJFKFEKPM(this DOPHJNOBIJD CBIAMEMFFJG)
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
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public NODABIEMGKL ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public NODABIEMGKL HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		private static NODABIEMGKL[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private Dictionary<NODABIEMGKL, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x884F9A0", Offset = "0x884E1A0", VA = "0x18884F9A0")]
		public bool FPGNNDNJIHB(NODABIEMGKL JEMMAJLOFOL, [Out] ResultConfig LDCOIJIBFHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x884FA10", Offset = "0x884E210", VA = "0x18884FA10")]
		public ResultConfig KKAPKPNEHFP(NODABIEMGKL BEPEOMJMPKF, [Optional] HashSet<NODABIEMGKL> KEBJNLJJFBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x8850080", Offset = "0x884E880", VA = "0x188850080", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x884FB50", Offset = "0x884E350", VA = "0x18884FB50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public class NPPEBJAIDGH : LNINKDJALGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct OGKIHJLOEKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		public NPPEBJAIDGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x884A670", Offset = "0x8848E70", VA = "0x18884A670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x884A900", Offset = "0x8849100", VA = "0x18884A900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct APECGHAPHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public LNINKDJALGH preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x8839120", Offset = "0x8837920", VA = "0x188839120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x88395C0", Offset = "0x8837DC0", VA = "0x1888395C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private readonly HCBJEOALAOL DJAANFILGDF;

	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string DDFODOPEEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x8849F90", Offset = "0x8848790", VA = "0x188849F90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x8849F20", Offset = "0x8848720", VA = "0x188849F20")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void EJEHBAIOEFG(OIKNHNBNAFI ECLFBIAPGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NPPEBJAIDGH([FAPODKMFODF(null)] HCBJEOALAOL DJAANFILGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x884A0E0", Offset = "0x88488E0", VA = "0x18884A0E0", Slot = "5")]
	[AsyncStateMachine(typeof(OGKIHJLOEKK))]
	public Task IHHPLANMBKM(DKKFAAJNJJM<string>.BNLIHIFJPDL FKOJDFELNFH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x8849FC0", Offset = "0x88487C0", VA = "0x188849FC0")]
	[AsyncStateMachine(typeof(APECGHAPHMA))]
	private Task HGGMFBEPEJM(LNINKDJALGH AJOOINMMHHN, DKKFAAJNJJM<string>.BNLIHIFJPDL FKOJDFELNFH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface HCBJEOALAOL : LNINKDJALGH
{
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface LNINKDJALGH
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string DDFODOPEEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IHHPLANMBKM(DKKFAAJNJJM<string>.BNLIHIFJPDL FKOJDFELNFH, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public static class ODEHONOCJCM
{
	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x884A260", Offset = "0x8848A60", VA = "0x18884A260")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void MNKNDOLBIJB(OIKNHNBNAFI ECLFBIAPGIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public interface PMABMGLDFHF : IEquatable<PMABMGLDFHF>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime FBPBOLDGDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHNCOHNAMPN();

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFGLHJOJFGL(long GFHIJAKOMMI, long PALELGDJJCI, [Out] DEGIKKCKCON DFDCIIBGMEI);
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal class CNKLLPNDPJH : OMKFNAOGINO
{
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class NPLIPELHBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public DKLOHHBNKIG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NPLIPELHBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x8849EB0", Offset = "0x88486B0", VA = "0x188849EB0")]
		internal object FFCCGKOODOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007ED")]
	private readonly AOJGNMEOOCJ JJBLOGJFJMK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<PMABMGLDFHF> NBONJFDLIME
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x883B330", Offset = "0x8839B30", VA = "0x18883B330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x883AF80", Offset = "0x8839780", VA = "0x18883AF80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	[UnityEngine.Scripting.Preserve]
	public CNKLLPNDPJH([FAPODKMFODF(null)] AOJGNMEOOCJ JJBLOGJFJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x883B030", Offset = "0x8839830", VA = "0x18883B030", Slot = "6")]
	public bool GECMPAGOGON(long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI, DKLOHHBNKIG LNIKDKIPDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0xE496E0", Offset = "0xE47EE0", VA = "0x180E496E0")]
	private void ENLBLKBFCIO(PMABMGLDFHF LPLDGBKEJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x883B3E0", Offset = "0x8839BE0", VA = "0x18883B3E0", Slot = "7")]
	public bool KONKHEDJLFL(long GFHIJAKOMMI, long PALELGDJJCI, [Out] PMABMGLDFHF KOKHFAJAONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x883B550", Offset = "0x8839D50", VA = "0x18883B550", Slot = "8")]
	public bool NLPDCIDKHPN(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, [Out] PMABMGLDFHF KOKHFAJAONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x883B600", Offset = "0x8839E00", VA = "0x18883B600")]
	private void PGJAOIDKKLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x883AE70", Offset = "0x8839670", VA = "0x18883AE70", Slot = "9")]
	public void ENFLPBLDMDB(long GFHIJAKOMMI, long PALELGDJJCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal abstract class FNKCJAPFCKC : AOJGNMEOOCJ
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	protected enum NJBIAHIDLMH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class LLFKPOLLNMK : IEnumerable<PMABMGLDFHF>, IEnumerable, IEnumerator<PMABMGLDFHF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private PMABMGLDFHF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		public FNKCJAPFCKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private DKLOHHBNKIG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		public DKLOHHBNKIG <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private PMABMGLDFHF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public LLFKPOLLNMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x8846450", Offset = "0x8844C50", VA = "0x188846450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x8846730", Offset = "0x8844F30", VA = "0x188846730", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x8846680", Offset = "0x8844E80", VA = "0x188846680", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMABMGLDFHF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8846680", Offset = "0x8844E80", VA = "0x188846680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class HKMCFIDCENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		public DKLOHHBNKIG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HKMCFIDCENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8840D90", Offset = "0x883F590", VA = "0x188840D90")]
		internal object EOJDJFKLPMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class EHJJDNBPJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public FNKCJAPFCKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public EHJJDNBPJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x883C5B0", Offset = "0x883ADB0", VA = "0x18883C5B0")]
		internal void NJBAOEAMFEG(DHBBHKCFFAB.DPNOJHDAHHN ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly object FEADODABEFF;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string IDOILDPDLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x883F260", Offset = "0x883DA60", VA = "0x18883F260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract JJIHAPPBLLA MDFINOLAPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x883FCA0", Offset = "0x883E4A0", VA = "0x18883FCA0")]
	protected FNKCJAPFCKC([CanBeNull] string LFBGOMBEIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x883F6A0", Offset = "0x883DEA0", VA = "0x18883F6A0", Slot = "5")]
	public bool MJCJIBGIIKJ(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, [Out] PMABMGLDFHF LPLDGBKEJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x883F890", Offset = "0x883E090", VA = "0x18883F890", Slot = "6")]
	[IteratorStateMachine(typeof(LLFKPOLLNMK))]
	public IEnumerable<PMABMGLDFHF> MPNCHOAKBEN(DKLOHHBNKIG LNIKDKIPDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void MADCGGMIEPD(Stream KJFLMPDOELM, long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI);

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool OPJPLIINEEA(Stream AMHNJACBICO, long GFHIJAKOMMI, long PALELGDJJCI, FOFEJPABBBI BPGBNENOBCA, [Out] DEGIKKCKCON DFDCIIBGMEI);

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x883F920", Offset = "0x883E120", VA = "0x18883F920", Slot = "7")]
	public PMABMGLDFHF POKOMMBLFEM(long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI, DKLOHHBNKIG LNIKDKIPDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo OPGBCGJBDNL(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, NJBIAHIDLMH NNKGOBCNJGA);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo CNLELPFNPPC(DKLOHHBNKIG LNIKDKIPDBJ, NJBIAHIDLMH NNKGOBCNJGA);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x883F630", Offset = "0x883DE30", VA = "0x18883F630")]
	protected void LOKBAEFECDN(DHBBHKCFFAB.DPNOJHDAHHN BFALPMIMIKC, string INDBGIPGMPI, FileInfo PCPFOANMLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x883F270", Offset = "0x883DA70", VA = "0x18883F270")]
	internal bool KBEKJCNIGFG(FileInfo CJJJEDEMONE, long GFHIJAKOMMI, long PALELGDJJCI, [Out] DEGIKKCKCON DFDCIIBGMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private void HBADBNDBNOC(Exception COLJEFDGCGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal class HKPFABLLECM : FNKCJAPFCKC
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override JJIHAPPBLLA MDFINOLAPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1339B00", Offset = "0x1338300", VA = "0x181339B00", Slot = "8")]
		get
		{
			return default(JJIHAPPBLLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x8841A40", Offset = "0x8840240", VA = "0x188841A40")]
	public HKPFABLLECM([Optional] string LFBGOMBEIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8840F30", Offset = "0x883F730", VA = "0x188840F30")]
	private void JLNDJFHPDKB(DKLOHHBNKIG LNIKDKIPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x8840FB0", Offset = "0x883F7B0", VA = "0x188840FB0", Slot = "9")]
	internal override void MADCGGMIEPD(Stream KJFLMPDOELM, long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8841350", Offset = "0x883FB50", VA = "0x188841350", Slot = "10")]
	internal override bool OPJPLIINEEA(Stream AMHNJACBICO, long GFHIJAKOMMI, long PALELGDJJCI, FOFEJPABBBI BPGBNENOBCA, [Out] DEGIKKCKCON DFDCIIBGMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8841260", Offset = "0x883FA60", VA = "0x188841260", Slot = "11")]
	protected override FileInfo OPGBCGJBDNL(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, NJBIAHIDLMH NNKGOBCNJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8840E30", Offset = "0x883F630", VA = "0x188840E30", Slot = "12")]
	protected override DirectoryInfo CNLELPFNPPC(DKLOHHBNKIG LNIKDKIPDBJ, NJBIAHIDLMH NNKGOBCNJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal sealed class EONGCNDJBGN : FNKCJAPFCKC
{
	[Cpp2IlInjected.Token(Token = "0x4000803")]
	private static readonly byte[] MNMCNOJCKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000804")]
	private readonly byte[] GKFGIGPFJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000805")]
	private readonly byte[] BPFMCELPJFF;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override JJIHAPPBLLA MDFINOLAPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x18D69A0", Offset = "0x18D51A0", VA = "0x1818D69A0", Slot = "8")]
		get
		{
			return default(JJIHAPPBLLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x883D840", Offset = "0x883C040", VA = "0x18883D840")]
	public EONGCNDJBGN([Optional] string LFBGOMBEIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x883C800", Offset = "0x883B000", VA = "0x18883C800", Slot = "9")]
	internal override void MADCGGMIEPD(Stream KJFLMPDOELM, long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x883CD40", Offset = "0x883B540", VA = "0x18883CD40", Slot = "10")]
	internal override bool OPJPLIINEEA(Stream AMHNJACBICO, long GFHIJAKOMMI, long PALELGDJJCI, FOFEJPABBBI BPGBNENOBCA, [Out] DEGIKKCKCON DFDCIIBGMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x883C740", Offset = "0x883AF40", VA = "0x18883C740")]
	private void IDBKPIDBBOA(byte[] LLNMEIMBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x883CC10", Offset = "0x883B410", VA = "0x18883CC10", Slot = "11")]
	protected override FileInfo OPGBCGJBDNL(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, NJBIAHIDLMH NNKGOBCNJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x883C630", Offset = "0x883AE30", VA = "0x18883C630", Slot = "12")]
	protected override DirectoryInfo CNLELPFNPPC(DKLOHHBNKIG LNIKDKIPDBJ, NJBIAHIDLMH NNKGOBCNJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
public enum JJIHAPPBLLA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
internal class PCINLMCKANB : AOJGNMEOOCJ
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	private sealed class CKEOPFKMFJJ : IEnumerable<PMABMGLDFHF>, IEnumerable, IEnumerator<PMABMGLDFHF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private PMABMGLDFHF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		public PCINLMCKANB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private DKLOHHBNKIG autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		public DKLOHHBNKIG <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private JJIHAPPBLLA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private IEnumerator<PMABMGLDFHF> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private PMABMGLDFHF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public CKEOPFKMFJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x883ADE0", Offset = "0x88395E0", VA = "0x18883ADE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x883AA00", Offset = "0x8839200", VA = "0x18883AA00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x883A9B0", Offset = "0x88391B0", VA = "0x18883A9B0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x883AD90", Offset = "0x8839590", VA = "0x18883AD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x883ACE0", Offset = "0x88394E0", VA = "0x18883ACE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PMABMGLDFHF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x883ACE0", Offset = "0x88394E0", VA = "0x18883ACE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400080C")]
	private readonly JJIHAPPBLLA[] IJMAELNIBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	private readonly Dictionary<JJIHAPPBLLA, AOJGNMEOOCJ> OAABKJPLCBH;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public JJIHAPPBLLA MDFINOLAPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x884BB10", Offset = "0x884A310", VA = "0x18884BB10", Slot = "4")]
		get
		{
			return default(JJIHAPPBLLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x884C0B0", Offset = "0x884A8B0", VA = "0x18884C0B0")]
	[UnityEngine.Scripting.Preserve]
	public PCINLMCKANB(params AOJGNMEOOCJ[] KPMLGICEJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x884BB40", Offset = "0x884A340", VA = "0x18884BB40", Slot = "5")]
	public bool MJCJIBGIIKJ(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, [Out] PMABMGLDFHF LPLDGBKEJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x884BD20", Offset = "0x884A520", VA = "0x18884BD20")]
	private void OAACEKPLPOE(int GPGKGHBNDAI, long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x884BC90", Offset = "0x884A490", VA = "0x18884BC90", Slot = "6")]
	[IteratorStateMachine(typeof(CKEOPFKMFJJ))]
	public IEnumerable<PMABMGLDFHF> MPNCHOAKBEN(DKLOHHBNKIG LNIKDKIPDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x884BF50", Offset = "0x884A750", VA = "0x18884BF50", Slot = "7")]
	public PMABMGLDFHF POKOMMBLFEM(long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI, DKLOHHBNKIG LNIKDKIPDBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal static class EAMLIFMCJGH
{
	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x883BF80", Offset = "0x883A780", VA = "0x18883BF80")]
	internal static byte[] JGLAAPJBAEA(byte[] LLNMEIMBBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x883BF00", Offset = "0x883A700", VA = "0x18883BF00")]
	public static void AJDDAAMBLDD(Stream HGGLOALDKIO, byte[] FIAMIKCLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x883C040", Offset = "0x883A840", VA = "0x18883C040")]
	public static bool KCNIAHMMIHG(Stream HGGLOALDKIO, long FNMNCGPHJGF, FOFEJPABBBI NIKPDPGCMLM, [Out] byte[] DJOIMGFKAID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal sealed class BBACDKNOOOL : PMABMGLDFHF, IEquatable<PMABMGLDFHF>, IEquatable<BBACDKNOOOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400081B")]
	private readonly FNKCJAPFCKC JJAIPELJNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400081C")]
	public readonly FileInfo POPFMNMBBIG;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public JJIHAPPBLLA MDFINOLAPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x80F37C0", Offset = "0x80F1FC0", VA = "0x1880F37C0", Slot = "9")]
		get
		{
			return default(JJIHAPPBLLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime FBPBOLDGDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8839620", Offset = "0x8837E20", VA = "0x188839620", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8839B10", Offset = "0x8838310", VA = "0x188839B10")]
	public BBACDKNOOOL(FNKCJAPFCKC OHOGPHICADC, FileInfo CJJJEDEMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x8839A60", Offset = "0x8838260", VA = "0x188839A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x8839960", Offset = "0x8838160", VA = "0x188839960", Slot = "5")]
	public void LHNCOHNAMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8839A20", Offset = "0x8838220", VA = "0x188839A20", Slot = "6")]
	public bool NFGLHJOJFGL(long GFHIJAKOMMI, long PALELGDJJCI, [Out] DEGIKKCKCON DFDCIIBGMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x88396B0", Offset = "0x8837EB0", VA = "0x1888396B0", Slot = "7")]
	public bool Equals(PMABMGLDFHF KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8839720", Offset = "0x8837F20", VA = "0x188839720", Slot = "8")]
	public bool Equals(BBACDKNOOOL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x88397E0", Offset = "0x8837FE0", VA = "0x1888397E0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x88398D0", Offset = "0x88380D0", VA = "0x1888398D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
public delegate void FOFEJPABBBI(DHBBHKCFFAB.DPNOJHDAHHN GBHNFHKKFLM, string ILBALOOKKCP);
[Cpp2IlInjected.Token(Token = "0x20001D3")]
internal interface AOJGNMEOOCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	JJIHAPPBLLA MDFINOLAPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MJCJIBGIIKJ(long GFHIJAKOMMI, long PALELGDJJCI, DKLOHHBNKIG LNIKDKIPDBJ, [Out] PMABMGLDFHF LPLDGBKEJIB);

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<PMABMGLDFHF> MPNCHOAKBEN(DKLOHHBNKIG LNIKDKIPDBJ);

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMABMGLDFHF POKOMMBLFEM(long GFHIJAKOMMI, long PALELGDJJCI, DEGIKKCKCON DFDCIIBGMEI, DKLOHHBNKIG LNIKDKIPDBJ);
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
