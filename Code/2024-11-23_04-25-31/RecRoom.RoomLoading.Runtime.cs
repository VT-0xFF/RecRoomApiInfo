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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x74DC390", Offset = "0x74DAD90", VA = "0x1874DC390")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74D9F60", Offset = "0x74D8960", VA = "0x1874D9F60", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x74E5860", Offset = "0x74E4260", VA = "0x1874E5860", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OHKJMMCMOEJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74DC7E0", Offset = "0x74DB1E0", VA = "0x1874DC7E0")]
	public OHKJMMCMOEJ(string FCMDIEEAPHD, Exception DMCKMBGEFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class MLMMGMLBDDG : EGILGJDIFKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BEFOADFFMML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PDGFGDEMNEN>> <>t__builder;

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
		private TaskAwaiter<GGAEDHJGBKG<PDGFGDEMNEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74CBED0", Offset = "0x74CA8D0", VA = "0x1874CBED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74CC110", Offset = "0x74CAB10", VA = "0x1874CC110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CJKCEFFDCID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PLMAHGPAIDM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<PLMAHGPAIDM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74CD5F0", Offset = "0x74CBFF0", VA = "0x1874CD5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74CD800", Offset = "0x74CC200", VA = "0x1874CD800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	[UnityEngine.Scripting.Preserve]
	public MLMMGMLBDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74DA950", Offset = "0x74D9350", VA = "0x1874DA950", Slot = "4")]
	[AsyncStateMachine(typeof(BEFOADFFMML))]
	public Task<IReadOnlyList<PDGFGDEMNEN>> DIAGJFLJLEL(long NPGHGEFGHLA, long GDENKKEDKLA, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74DAA70", Offset = "0x74D9470", VA = "0x1874DAA70", Slot = "5")]
	[AsyncStateMachine(typeof(CJKCEFFDCID))]
	public Task<IReadOnlyList<PLMAHGPAIDM>> HKAPGPKIJGF(IReadOnlyList<int> JBLLHBDILNP, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MADEAKIMBBE : IEquatable<MADEAKIMBBE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HKLBFGEGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	PLMAHGPAIDM DOIJCPIEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime JOMICMBCLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FFGDPIFLKJN? DHGOCLLKPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KDJCOAHDIIN? FKLEMABOLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	KKIDKBAKOAN HCELEDJIIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ICNNFOGCALN> HEBIGIBLIGO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KKIDKBAKOAN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EGILGJDIFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<PDGFGDEMNEN>> DIAGJFLJLEL(long NPGHGEFGHLA, long GDENKKEDKLA, [Optional] CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<PLMAHGPAIDM>> HKAPGPKIJGF(IReadOnlyList<int> JBLLHBDILNP, [Optional] CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AHOOCFIONGM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class NLLGBNONNKO : MADEAKIMBBE, IEquatable<MADEAKIMBBE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct NNLLCKGEDFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public NLLGBNONNKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private GCBBJGEAAKC <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<IJINIJPNMHJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<ICNNFOGCALN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x74DBE60", Offset = "0x74DA860", VA = "0x1874DBE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x74DC320", Offset = "0x74DAD20", VA = "0x1874DC320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PDGFGDEMNEN MHIFOIJPHEH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HKLBFGEGACG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D20", Offset = "0x8B3720", VA = "0x1808B4D20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PLMAHGPAIDM DOIJCPIEFAD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IFDOGJANIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FD95B0", Offset = "0x5FD7FB0", VA = "0x185FD95B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FFGDPIFLKJN? DHGOCLLKPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x94D4C0", Offset = "0x94BEC0", VA = "0x18094D4C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KDJCOAHDIIN? FKLEMABOLOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9690", Offset = "0x5FD8090", VA = "0x185FD9690", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KKIDKBAKOAN HCELEDJIIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "10")]
			get
			{
				return default(KKIDKBAKOAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74DBCC0", Offset = "0x74DA6C0", VA = "0x1874DBCC0", Slot = "9")]
		[AsyncStateMachine(typeof(NNLLCKGEDFO))]
		public Task<ICNNFOGCALN> HEBIGIBLIGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74DBE00", Offset = "0x74DA800", VA = "0x1874DBE00")]
		public NLLGBNONNKO(int BBBBDPFPAHE, PLMAHGPAIDM MIKHPIICABC, PDGFGDEMNEN MHIFOIJPHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74DBB10", Offset = "0x74DA510", VA = "0x1874DBB10", Slot = "11")]
		public bool Equals(MADEAKIMBBE GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74DBBA0", Offset = "0x74DA5A0", VA = "0x1874DBBA0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74DBDC0", Offset = "0x74DA7C0", VA = "0x1874DBDC0")]
		private bool JOKAGNBAMHN(NLLGBNONNKO GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74DBC40", Offset = "0x74DA640", VA = "0x1874DBC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class JLGCHNFNKIK : MADEAKIMBBE, IEquatable<MADEAKIMBBE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct PGGKAOOEAAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public JLGCHNFNKIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<ICNNFOGCALN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x74E3600", Offset = "0x74E2000", VA = "0x1874E3600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x74E3850", Offset = "0x74E2250", VA = "0x1874E3850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HODNKPFLLHK CHFNDJPBCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly FFGDPIFLKJN EHLCHNPPLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KDJCOAHDIIN LIGBLAFNJDH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HKLBFGEGACG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x74D69A0", Offset = "0x74D53A0", VA = "0x1874D69A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PLMAHGPAIDM DOIJCPIEFAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x74D67C0", Offset = "0x74D51C0", VA = "0x1874D67C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IFDOGJANIPA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x74D6950", Offset = "0x74D5350", VA = "0x1874D6950", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FFGDPIFLKJN? DHGOCLLKPAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74D68B0", Offset = "0x74D52B0", VA = "0x1874D68B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KDJCOAHDIIN? FKLEMABOLOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x74D6900", Offset = "0x74D5300", VA = "0x1874D6900", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KKIDKBAKOAN HCELEDJIIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x93C4F0", Offset = "0x93AEF0", VA = "0x18093C4F0", Slot = "10")]
			get
			{
				return default(KKIDKBAKOAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x177E170", Offset = "0x177CB70", VA = "0x18177E170")]
		public JLGCHNFNKIK(HODNKPFLLHK JAFKJGHEDHG, FFGDPIFLKJN OOELFCNNFOC, KDJCOAHDIIN BBOGFNJMEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74D66D0", Offset = "0x74D50D0", VA = "0x1874D66D0", Slot = "9")]
		[AsyncStateMachine(typeof(PGGKAOOEAAK))]
		public Task<ICNNFOGCALN> HEBIGIBLIGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74D65B0", Offset = "0x74D4FB0", VA = "0x1874D65B0", Slot = "11")]
		public bool Equals(MADEAKIMBBE GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74D6500", Offset = "0x74D4F00", VA = "0x1874D6500", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74D6850", Offset = "0x74D5250", VA = "0x1874D6850")]
		private bool JOKAGNBAMHN(JLGCHNFNKIK GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74D6650", Offset = "0x74D5050", VA = "0x1874D6650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class APJKAALGJGK : MADEAKIMBBE, IEquatable<MADEAKIMBBE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct HPFHGPBJDJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<ICNNFOGCALN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x74D5BA0", Offset = "0x74D45A0", VA = "0x1874D5BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x74D5E00", Offset = "0x74D4800", VA = "0x1874D5E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly PLMAHGPAIDM DFLKBJAPJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly FFGDPIFLKJN EHLCHNPPLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly KDJCOAHDIIN LIGBLAFNJDH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HKLBFGEGACG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x74C8470", Offset = "0x74C6E70", VA = "0x1874C8470", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public PLMAHGPAIDM DOIJCPIEFAD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IFDOGJANIPA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FFGDPIFLKJN? DHGOCLLKPAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x74C83D0", Offset = "0x74C6DD0", VA = "0x1874C83D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KDJCOAHDIIN? FKLEMABOLOC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x74C8420", Offset = "0x74C6E20", VA = "0x1874C8420", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KKIDKBAKOAN HCELEDJIIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "10")]
			get
			{
				return default(KKIDKBAKOAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x177E170", Offset = "0x177CB70", VA = "0x18177E170")]
		public APJKAALGJGK(PLMAHGPAIDM MIKHPIICABC, FFGDPIFLKJN OOELFCNNFOC, KDJCOAHDIIN BBOGFNJMEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74C8220", Offset = "0x74C6C20", VA = "0x1874C8220", Slot = "9")]
		[AsyncStateMachine(typeof(HPFHGPBJDJJ))]
		public Task<ICNNFOGCALN> HEBIGIBLIGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74C80A0", Offset = "0x74C6AA0", VA = "0x1874C80A0", Slot = "11")]
		public bool Equals(MADEAKIMBBE GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74C8110", Offset = "0x74C6B10", VA = "0x1874C8110", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74C8190", Offset = "0x74C6B90", VA = "0x1874C8190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74C82F0", Offset = "0x74C6CF0", VA = "0x1874C82F0")]
		private bool JOKAGNBAMHN(APJKAALGJGK GDOGPMPJPOO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct COKGJFDPFBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<MADEAKIMBBE>> <>t__builder;

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
		public AHOOCFIONGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<PDGFGDEMNEN> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<PDGFGDEMNEN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, PLMAHGPAIDM account, PDGFGDEMNEN roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74CD870", Offset = "0x74CC270", VA = "0x1874CD870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x74CE6B0", Offset = "0x74CD0B0", VA = "0x1874CE6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LMPCIOIHKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, PLMAHGPAIDM account, PDGFGDEMNEN roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<PDGFGDEMNEN> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AHOOCFIONGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<PLMAHGPAIDM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74D9020", Offset = "0x74D7A20", VA = "0x1874D9020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74D9A00", Offset = "0x74D8400", VA = "0x1874D9A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IOHIPJCLGHP OECMIPDABOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EGILGJDIFKE ONODCDPCDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BPAMECECBJC JMHNKKDDNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CHLDBCECJHG<(long, long), IReadOnlyList<PDGFGDEMNEN>> DCFIANLOJKE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74C7880", Offset = "0x74C6280", VA = "0x1874C7880")]
	[UnityEngine.Scripting.Preserve]
	public AHOOCFIONGM([CCLEDEMDDDH(null)] EGILGJDIFKE BCIKKIJJACC, [CCLEDEMDDDH(null)] BPAMECECBJC KCKCFMBDBOD, [CCLEDEMDDDH(null)] IOHIPJCLGHP JFLDFPOAPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74C7590", Offset = "0x74C5F90", VA = "0x1874C7590")]
	[AsyncStateMachine(typeof(COKGJFDPFBL))]
	public Task<IList<MADEAKIMBBE>> OFKJGOHPKKN(long NPGHGEFGHLA, long OKPAMGANILI, bool DAIPKIJOLDI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74C76E0", Offset = "0x74C60E0", VA = "0x1874C76E0")]
	private bool OIKAECEACMF(DateTime? EKKIPOJNMGD, long NPGHGEFGHLA, long OKPAMGANILI, [Out] HODNKPFLLHK JCEPEPKPAGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74C7480", Offset = "0x74C5E80", VA = "0x1874C7480")]
	[AsyncStateMachine(typeof(LMPCIOIHKEH))]
	private Task<IReadOnlyList<(int, PLMAHGPAIDM, PDGFGDEMNEN)>> HBOHMAPBOGN(IReadOnlyList<PDGFGDEMNEN> PBFCAPNFBIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BPAMECECBJC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HODNKPFLLHK> KHKLHDOKECF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDKOGDKGBOE(long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL, BAKCOMBJMKD NACGOOKCKAA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JECHHGBDGBJ(long NPGHGEFGHLA, long OKPAMGANILI, [Out] HODNKPFLLHK JCEPEPKPAGE);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLOBOJJMCLI(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, [Out] HODNKPFLLHK JCEPEPKPAGE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKHGLCBPDIL(long NPGHGEFGHLA, long OKPAMGANILI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IGPBEMDEPGN : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LMAGFJCBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task AOJAGOHACID
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABFOBPCDIMK(Task LPAAFOGOHKE, string HIEMBAHHPHH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface OMEBFBKKFLB : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ICNNFOGCALN> GPMKFFHNCMJ(HODNKPFLLHK JCEPEPKPAGE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KNPKIEFKKGC(CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface MFAGGGGAHJC : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LBJBADDKLDA GALDJJCLJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKECHDLJLKC();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOFKABPEGMG();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface BGABJPPAMJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface GLMJNFIMHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JMGLABKNNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan HFNPIGCMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan BKOEHCFMMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan APJBMFEKMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JGMJAAKHELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CDMPKPAGEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IFBHGONJKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int HBCIKMDGLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OBIEBBIOLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NJJOAGPCLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum AMFMBGDEDME
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EFFOBLOOKHB
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
public struct PPGGANEOPEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long DFBAGBMPJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long GDENKKEDKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly AMFMBGDEDME BKKHBFLPOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception MEJOMIECILB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74E5180", Offset = "0x74E3B80", VA = "0x1874E5180")]
	public PPGGANEOPEN(long DFBAGBMPJJF, long GDENKKEDKLA, AMFMBGDEDME BKKHBFLPOHJ, [CanBeNull] Exception MEJOMIECILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74E5130", Offset = "0x74E3B30", VA = "0x1874E5130")]
	public static PPGGANEOPEN NEICLLJACJM(OABHCPGEKDA KPHJBPAOIBF, AMFMBGDEDME BKKHBFLPOHJ, [Optional] Exception MEJOMIECILB)
	{
		return default(PPGGANEOPEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void CFHNALMKLMA(PPGGANEOPEN JFBLNKBHMAM);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface DPJHKHBBEOG : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CPBOPCBHMHC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CFHNALMKLMA KJHDEBHKFGA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CFHNALMKLMA JDGHOLPCOGM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CFHNALMKLMA MDJCECFDODB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EFFOBLOOKHB, bool> NHCPENDGDEI;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CAKHLALFMOK();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MFKJOLDEJOD(PPGGANEOPEN JFBLNKBHMAM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NOBKMNGGIDI(PPGGANEOPEN JFBLNKBHMAM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LALHHCBJAGF(PPGGANEOPEN JFBLNKBHMAM);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NBIBJEEIEKH(EFFOBLOOKHB MCFACOPHFFE, bool HDKDMAHLAFI);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface DDBNMLNEHIP : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NJCOGDGMBCA();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKIMNMODEON();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface NPKEPDCOMBP : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus IPCBCGGHFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHLONABFCKK(OABHCPGEKDA LHCPGGNLCPO, PJKJDBDNPNA BEKFCPHIIBE, CancellationToken AGFJCKJDLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class LIPFOEBIJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74D82B0", Offset = "0x74D6CB0", VA = "0x1874D82B0")]
	public static bool IIMKMADILBF(this NPKEPDCOMBP NMEFFLKAPDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task HENJFNIBNNB(CancellationToken AICEIDIHFDO, int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface LOHPJEPNHKG : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFABOMJDHPB(HENJFNIBNNB CLANKLMLIHD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface FBPDAHOOPKF : GCBBJGEAAKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken HBBMBHGICAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KNPHAFHLPCE ILMFPBOLFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AFIFLHJBILJ EOOAFGCKNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DOOOEJMHPPN JFNIDAFIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OLDOMICMCLE IGJKHCHGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	GHMLDOKPIEJ MJOGHEKDFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DBGOGJCAPOP HMLPCDPOOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NABBJMIMBHJ BDAANEJDDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IGPBEMDEPGN CPNGCOCKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	OMEBFBKKFLB JJCBNCPFMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	DPJHKHBBEOG GMANJBCMDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DDBNMLNEHIP IPMGDPDDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NPKEPDCOMBP FBIHHPOFOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LOHPJEPNHKG KNDGHHLIIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	FMLMHOJGBKM DGIOMCPHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LIPLGMABIAE JIEEFAHPFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IOALELDLDFJ COHANOMHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BIAJFCCKFCN LGKNEMBOHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BGKNBPLJCOM GNLOKGIOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EKJOFOMEOLD EJKLOAPDDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DDKLCJFENGE JOHPNGPBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FDFLOOOBEGF FCDFCMJJLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NJHOEBOADMN GLCFKNNBIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EHDAEHMMJMI HNHLPDCENHB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	MFAGGGGAHJC HEODMJKILJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GLMJNFIMHHJ JCHFCBHCKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FBCIJNEHIMJ LAJNPGAHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BPAMECECBJC PPKGLABPPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DEKHBKBDPPA GCAEPGDCAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	NHLHBFNNCBA GOEBPHDLCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JHDOIICAKMG FFKCPDMLDHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	ODMFCPKINFP JNJIMJOOMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	new bool BNKGHPDKOKN
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
	void BKEAPLAGHHC(PJKJDBDNPNA MGLFGDPIFMG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FMLMHOJGBKM : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPNHNLKELFB NOEGDDICEDP(Guid GGNKLHDGNDO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJOABDGMIKH(Guid GGNKLHDGNDO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FODGDHNKOOG(Guid GGNKLHDGNDO, Task ICOJFKOPMEO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBIHPKCLNJA(Guid GGNKLHDGNDO, ICNNFOGCALN OGHNNKDLAAG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(ICNNFOGCALN, Task)> JAFGNDABKEC(Guid GGNKLHDGNDO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FJDOHFHFGLG : BGABJPPAMJK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LIPLGMABIAE : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMHENBJJOOM(JDBONLEIIML FCMDIEEAPHD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJIHOIBNPNN(JDBONLEIIML FCMDIEEAPHD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DOFMJKPJLKG> EDMAJJJCDOG(CancellationToken HLAJCDPELGO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface IOALELDLDFJ : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPNHNLKELFB JEEEKOEPMHA(JDBONLEIIML PBNIEMAFBKN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHMDHFHHPIE(Guid GGNKLHDGNDO, Task ICOJFKOPMEO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface BIAJFCCKFCN : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ICNNFOGCALN> LGKNEMBOHAP(JDBONLEIIML IACBCDAPDHF);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface BGKNBPLJCOM : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMBGKEDMCPG> FCFGFHBGNFF(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, OABHCPGEKDA LHCPGGNLCPO, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DDKLCJFENGE : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICNNFOGCALN MMNBJCNMALP(OGOAPNICIIH MFEKEOGJGAE);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PINODNCJKPK(string MHHANLDHFOC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface EKJOFOMEOLD : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JDBONLEIIML> DICMKLJDDHK(JDBONLEIIML PGCEOMNLPAE, KBEJLAHBIDN LBEMCAHBNHB, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JDBONLEIIML> ILIJLGDLKEF(CancellationToken PPLDCJFFMEP, KBEJLAHBIDN LBEMCAHBNHB);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEFBPLBIKCE CAKGGGNMECD(KJKAGGHNJFC DOGIDIDNGGA, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEFBPLBIKCE PIGGELNBEJJ(KJKAGGHNJFC DOGIDIDNGGA, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface FDFLOOOBEGF : BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICNNFOGCALN ADCDFJCKIGE(OGOAPNICIIH MFEKEOGJGAE, DOFMJKPJLKG ILCOEDDFLME);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICNNFOGCALN MHEGCPLNGFK(OGOAPNICIIH NFFJINNFCGC);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface NJHOEBOADMN
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJLNOEHOOJM(NCCOJAPKPJB PBOOGCOCHAD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIPJNKOLMGJ(NCCOJAPKPJB PBOOGCOCHAD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODPKEPIEGGF(NCCOJAPKPJB PBOOGCOCHAD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGJLBKDILLI(NCCOJAPKPJB PBOOGCOCHAD);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NCCOJAPKPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OABHCPGEKDA JINLBPPPBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> CIDKFLPLCLP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FILMNPNNHPJ<string> KBLCPOIEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD750", Offset = "0x8AC150", VA = "0x1808AD750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public NCCOJAPKPJB(OABHCPGEKDA BOLIKBEKJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74DB750", Offset = "0x74DA150", VA = "0x1874DB750")]
	public NCCOJAPKPJB IHNJGHDHHNA(string PNABAFEIDND, string PKCLPFEIPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74DB6C0", Offset = "0x74DA0C0", VA = "0x1874DB6C0")]
	public bool EBMICICOGNO([Out] IEnumerable<KeyValuePair<string, string>> GEFELFOLKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66C2570", Offset = "0x66C0F70", VA = "0x1866C2570")]
	public NCCOJAPKPJB APAJDFJPHBO(FILMNPNNHPJ<string> PILOCADBFFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface FBCIJNEHIMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KGJMJDFFOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string EMDHKPOMLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HGELOEOCKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPMCIBDGPIH();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ENFEAPLJLEB CDOOKPAJGBB(long PDPMPEEFJNK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BIOBOKHFEHE<OAGGCGDDFAC, GOMCODJKDBA> AKOJIMLOENB(long PDPMPEEFJNK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BIOBOKHFEHE<OAGGCGDDFAC, FNEPJCIGLHI> KGBODJJGHEC(long PDPMPEEFJNK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BIOBOKHFEHE<long, PBLIOBODKJG> PAGDCEGLPIF();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KAPNNDGJKHF(long PDPMPEEFJNK, [Out] bool JKJNAJCCILF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> LPBILOCBALC(byte[] FGOFNGOIJIL, byte[] DFDBLOHMKKB, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GCBBJGEAAKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IIMKMADILBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OCCIIIHINPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool BNKGHPDKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PJKJDBDNPNA PIOAINDMGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action CPBOPCBHMHC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CFHNALMKLMA KJHDEBHKFGA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CFHNALMKLMA JDGHOLPCOGM;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CFHNALMKLMA MDJCECFDODB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<EFFOBLOOKHB, bool> NHCPENDGDEI;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EKIMNMODEON();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PPMFHAJFKFP KNJKLPDFMFI();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GHACJEKPKON JPNKCABBBFA();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<ICNNFOGCALN> GPMKFFHNCMJ(HODNKPFLLHK JAFKJGHEDHG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task KNPKIEFKKGC(CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OLDOMICMCLE
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool MIAIGGFCALM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string LAMJEFKLKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJFAJHEFJPM(Scene NCDAKEKGFPG);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EHDAOJJDFIO(IFDKCMANFCK NKAMIDGJJPD, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LPKCDGKEGJJ();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PABILDOPGFD();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KJJEFGMNENB
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EJAEFFGMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool PECLFMLIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool CJEAGGLJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool AEFOFNJPCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int NADDILGFAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool AIDKDCFGNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool HPIADLOMFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	int ONJEJJNFMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int NJMAPBFGABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool EOGDFBGPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool LAFIABBOBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool BHPLDMECGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float LOKHHDJBHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> NPKAGHAPANC;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNPHAFHLPCE EOJNHOAANPE(KNPHAFHLPCE HHNKILPHFCD);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOANGCKMOLO(KNPHAFHLPCE DNJEODDCEHK);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLBDAFNFJBL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task AELLPGCMMDH(FILMNPNNHPJ<string>.EEFAEMIIABD CLBDFCDNFNA, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GBLINFJGMME(float JFMNBPDMIIF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDFOAPNLONJ(string GBOPPJLEHFB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<LFIFNCDGBCI> EAABNCMAOAP();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FAEKECPPMGB(object KMDNOIPDFGB, LFIFNCDGBCI CJMBIMOEFGE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<AFEMDEJPPNP> PAJCNODLMJJ();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GOMCODJKDBA NLOPILJOPCN(IEnumerable<INNJJHKNLDI> AONGMDCDHCL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OODDAHDEMEF(int LNMOKLDMMAH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task FHHFLNLFIME();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AGPPLPJJHJD();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PPGEDGDNMAD();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task CELFCEFMMPD(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task FCJPEOAPKMC(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<NPEFLHBCDBA> NEELBJGGOOB(DateTime OPKJHAPKJNP, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> HBHDLJFOMBL(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OMJLKAOMKAI(string FCMDIEEAPHD = "", float NOMMEIKOKMM = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JDNNIPIALOM PKBNHCOFHEP(OFNJDMAAPJA GEGDNCFBIGP, BKOCDJHIDIE COIGBAPOAOG, FNEPJCIGLHI GBLKBNKKKHI, IEnumerable<PersistenceView> JJHHCLNMMCD, ABDCKNOIGKC PHNENPJMKOF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LAKDJNIBKFP(FNEPJCIGLHI GBLKBNKKKHI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FGEGEFIFDNN(INNJJHKNLDI MDLHGFCNBNN, [In] JDNNIPIALOM FDHOOFMLFAM);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task BHFINPHLBAA(FNEPJCIGLHI ECOALFPMDCI, bool MNHNPHKHPHG, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task LFDDNHEADGK(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AHOCHIIBLLC(long NPGHGEFGHLA, long GDENKKEDKLA, IJINIJPNMHJ MGDHFCBGAAG, PDGFGDEMNEN MGLMJLIJAHL, HLPAOIDBMBB LBAJBEGJANL, JBJGKGNCJFN? BHMCOFGNKDJ, ACDALMNGNFK? AEBPOCBDKFD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void MHDJCANGKOJ(long NPGHGEFGHLA, long GDENKKEDKLA, ACDALMNGNFK? AEBPOCBDKFD);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ANJMOOOHDNG(PersistenceView FELHHHBBCOG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool HCLGHCKEDEP(PersistenceView EPCOPABAPDA);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool IKIDMOFEHBP(INNJJHKNLDI MDLHGFCNBNN, CAMCIKNBNLL KLLFMDHFLLE, [Out] OFNMBFBPNPO FAABHIOJPHB);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task NFDBLBGDANM(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KLJNIHNBABL();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable IKLGEBHNEBF();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HKFDBNAPJJL(FNEPJCIGLHI ECOALFPMDCI, CAMCIKNBNLL KLLFMDHFLLE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> BGEJOAOOEBN(AFIFLHJBILJ PPPAPIDLOLG, CancellationToken PPLDCJFFMEP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void LFGMIDDNDFO(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<AFCCLGFOAKC> NIIOBKPKJGG(NFNMJNHLNCI PGCEOMNLPAE);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<IJINIJPNMHJ> PGOAGMKJNFM(long NPGHGEFGHLA, bool COKFPGHBJAN, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<PDGFGDEMNEN> NLABBDBBGKF(long NPGHGEFGHLA, long GDENKKEDKLA, long IOJIAKJKDMD, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<PDGFGDEMNEN> NPMEJIGCNGI(long NPGHGEFGHLA, long GDENKKEDKLA, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<OGJPACLLFCJ> PHODMDKKLJA(string DEBCIKJGCDH, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<OGJPACLLFCJ> MEFKJOCLCOG(string DEBCIKJGCDH, long NPGHGEFGHLA, long GDENKKEDKLA, string BKELLPBJGPP, HDPIOIMFMGI.PBLKJKKBDKN GJLDCFIFFGA, HDPIOIMFMGI.PBLKJKKBDKN DFDBLOHMKKB, int EHKPDKPBKCL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool APEJHIODJKM();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool NKFBNMEOAAM();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool DPCJLPBHIMO(IEnumerable<OFNMBFBPNPO> EJEPJDEHNLC);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HDNCBKNHDDL(List<GameObject> MDCJENBLMGO);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float GBMIIIMGKME();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> CLEHANIPHGF(string DNDEFCJDLEP, LoadSceneMode KCBOLLPDEGF, bool JGLGJDPAMFJ, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JDDNELCBELJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IPJFLMCJFOA(bool FNEAOIOIFKL);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ANJKNDMJDAG();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void JLADFJMOMAC();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void JNFKCLGAPLD(OABHCPGEKDA CPOHCGKKOHM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task MIPAGEJGMGC(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task LKHAKOKAPHN(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task NDEEALAHNMO(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task BDNCLLNDHEH(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable IENOBIBFPIH();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "73")]
	PEOKBLMALEB HOFPINJOJAJ();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task LKJEKJGKBNM(CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface PEOKBLMALEB
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KLKHHAFKJPI(CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LHDLBGAFCNP(CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JDNNIPIALOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> MENMLPKAFFF;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum NPEFLHBCDBA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct OFNJDMAAPJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string AGOMJDJOMCG;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface PKKFJLINELL
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	OABHCPGEKDA HIJHLAGAKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	IJINIJPNMHJ LDJJIDBLMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EFEKMJJDMGI HHNLDLNNKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool DEGFDDEFKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool MJKAADPFANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int LHMDJDKMPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action LFJGIMMMJLF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> KHPOIAOGJJK;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLHNNNAECAM();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LELKPOPMNFG> DGEIONBNEJG(long PDPMPEEFJNK, [Optional] CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CLHBOPIGKGE> HJGFNFGCIOJ();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task IMCLOEJJFPG();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(OABHCPGEKDA, PJKJDBDNPNA) AEKJNPEFNGM();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MMPBFABBMCN NJOHOGKPJNB();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PNBJNKMFMOM(long PDPMPEEFJNK);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BPFOPDLMALB(OABHCPGEKDA BOLIKBEKJMB, Matchmaking.HBLONCNLFEI KIBAOEBFCJF, (int Major, int? Minor)? IJKGJPCAEHK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EHDAEHMMJMI
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJLIKMGAINH([Out] IEnumerable<int> JJLJPDIHCCF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILLBKEBODDJ(LLKIGIOJMJI AICEIDIHFDO);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFMPAPEIGJM(LLKIGIOJMJI AICEIDIHFDO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HNOPGILJPGH
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JOPHLKBPKBE(ICNNFOGCALN HDKFJJMEOOB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BNIGADOOPEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGBPBKIGGDM(BPLJDAAHOGG.HPDOENODODH CLBBFKJOOPG);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAKBJAOOHJC(BPLJDAAHOGG.HPDOENODODH CLBBFKJOOPG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GHMLDOKPIEJ : BNIGADOOPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICNNFOGCALN JPDECCCHOBH(OGOAPNICIIH NFFJINNFCGC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DBGOGJCAPOP : BNIGADOOPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICNNFOGCALN MMNBJCNMALP(OGOAPNICIIH CKKFCDKPFAG);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface ENFEAPLJLEB
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKPKCEBGDLD<IFDKCMANFCK, JMDMKJMGBCA>> OKFILGMHCOA(string BKELLPBJGPP, long PDPMPEEFJNK, long? NPGHGEFGHLA, long? GDENKKEDKLA, OMLEINKKIDN.NOOFNPPCJMN PJOPMGKFLBD, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BIOBOKHFEHE<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKPKCEBGDLD<EIIKFAFHFIO<TData>, JMDMKJMGBCA>> LCGJHOHAJDC(TGetDataArg BCHPPGPOGNC, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DLNBAALPHKO : FBPDAHOOPKF, GCBBJGEAAKC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NDMNJIBPPAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DLNBAALPHKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HODNKPFLLHK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<ICNNFOGCALN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x74DB820", Offset = "0x74DA220", VA = "0x1874DB820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x74DBAA0", Offset = "0x74DA4A0", VA = "0x1874DBAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct OLFAIDOHONA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DLNBAALPHKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF90", Offset = "0x74DB990", VA = "0x1874DCF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x74DD1C0", Offset = "0x74DBBC0", VA = "0x1874DD1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FJJFBBKJOGB : IEnumerable<BGABJPPAMJK>, IEnumerable, IEnumerator<BGABJPPAMJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private BGABJPPAMJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DLNBAALPHKO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		private BGABJPPAMJK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public FJJFBBKJOGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x74D1260", Offset = "0x74CFC60", VA = "0x1874D1260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x74D16C0", Offset = "0x74D00C0", VA = "0x1874D16C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x74D1610", Offset = "0x74D0010", VA = "0x1874D1610", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BGABJPPAMJK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x74D1610", Offset = "0x74D0010", VA = "0x1874D1610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource JBOMOFMGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KNPHAFHLPCE DNJEODDCEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DPJAACBNDJI KDOADKOMJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool OFKBLLLJDAM;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AFIFLHJBILJ EOOAFGCKNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1E0", Offset = "0x8A9BE0", VA = "0x1808AB1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DOOOEJMHPPN JFNIDAFIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1B0", Offset = "0x8A9BB0", VA = "0x1808AB1B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8AB240", Offset = "0x8A9C40", VA = "0x1808AB240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8AB230", Offset = "0x8A9C30", VA = "0x1808AB230", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8AB200", Offset = "0x8A9C00", VA = "0x1808AB200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OLDOMICMCLE IGJKHCHGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1C0", Offset = "0x8A9BC0", VA = "0x1808AB1C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8AB210", Offset = "0x8A9C10", VA = "0x1808AB210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public GHMLDOKPIEJ MJOGHEKDFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8AB220", Offset = "0x8A9C20", VA = "0x1808AB220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1F0", Offset = "0x8A9BF0", VA = "0x1808AB1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DBGOGJCAPOP HMLPCDPOOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B96F0", Offset = "0x8B80F0", VA = "0x1808B96F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B9690", Offset = "0x8B8090", VA = "0x1808B9690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NABBJMIMBHJ BDAANEJDDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8B96A0", Offset = "0x8B80A0", VA = "0x1808B96A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8B96D0", Offset = "0x8B80D0", VA = "0x1808B96D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IGPBEMDEPGN CPNGCOCKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8B9770", Offset = "0x8B8170", VA = "0x1808B9770", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8B97E0", Offset = "0x8B81E0", VA = "0x1808B97E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public OMEBFBKKFLB JJCBNCPFMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x934310", Offset = "0x932D10", VA = "0x180934310", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xE08460", Offset = "0xE06E60", VA = "0x180E08460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public DPJHKHBBEOG GMANJBCMDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B9840", Offset = "0x8B8240", VA = "0x1808B9840", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B9820", Offset = "0x8B8220", VA = "0x1808B9820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public DDBNMLNEHIP IPMGDPDDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9FF200", Offset = "0x9FDC00", VA = "0x1809FF200", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9FF250", Offset = "0x9FDC50", VA = "0x1809FF250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NPKEPDCOMBP FBIHHPOFOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B69A0", Offset = "0x8B53A0", VA = "0x1808B69A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5310", VA = "0x1808B6910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LOHPJEPNHKG KNDGHHLIIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9824B0", Offset = "0x980EB0", VA = "0x1809824B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4D0", Offset = "0xA0DED0", VA = "0x180A0F4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FMLMHOJGBKM DGIOMCPHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x97E8D0", Offset = "0x97D2D0", VA = "0x18097E8D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xE289E0", Offset = "0xE273E0", VA = "0x180E289E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FJDOHFHFGLG JCMBAMODAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x97E8E0", Offset = "0x97D2E0", VA = "0x18097E8E0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xC97F70", Offset = "0xC96970", VA = "0x180C97F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public LIPLGMABIAE JIEEFAHPFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x97E8C0", Offset = "0x97D2C0", VA = "0x18097E8C0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x925CE0", Offset = "0x9246E0", VA = "0x180925CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public IOALELDLDFJ COHANOMHJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x97E6A0", Offset = "0x97D0A0", VA = "0x18097E6A0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA876A0", Offset = "0xA860A0", VA = "0x180A876A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BIAJFCCKFCN LGKNEMBOHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B6970", Offset = "0x8B5370", VA = "0x1808B6970", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8B6980", Offset = "0x8B5380", VA = "0x1808B6980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BGKNBPLJCOM GNLOKGIOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x97E870", Offset = "0x97D270", VA = "0x18097E870", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xD21910", Offset = "0xD20310", VA = "0x180D21910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public EKJOFOMEOLD EJKLOAPDDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x97E860", Offset = "0x97D260", VA = "0x18097E860", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xECBB60", Offset = "0xECA560", VA = "0x180ECBB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DDKLCJFENGE JOHPNGPBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8F79A0", Offset = "0x8F63A0", VA = "0x1808F79A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x924980", Offset = "0x923380", VA = "0x180924980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FDFLOOOBEGF FCDFCMJJLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97D150", VA = "0x18097E750", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xD22600", Offset = "0xD21000", VA = "0x180D22600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public NJHOEBOADMN GLCFKNNBIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x97E970", Offset = "0x97D370", VA = "0x18097E970", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9FD370", Offset = "0x9FBD70", VA = "0x1809FD370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public EHDAEHMMJMI HNHLPDCENHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x97E830", Offset = "0x97D230", VA = "0x18097E830", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xECBCE0", Offset = "0xECA6E0", VA = "0x180ECBCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public MFAGGGGAHJC HEODMJKILJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x97E7C0", Offset = "0x97D1C0", VA = "0x18097E7C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xECBCC0", Offset = "0xECA6C0", VA = "0x180ECBCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public GLMJNFIMHHJ JCHFCBHCKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x97E7E0", Offset = "0x97D1E0", VA = "0x18097E7E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xECBC20", Offset = "0xECA620", VA = "0x180ECBC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public FBCIJNEHIMJ LAJNPGAHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x922930", Offset = "0x921330", VA = "0x180922930", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x91F240", Offset = "0x91DC40", VA = "0x18091F240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public BPAMECECBJC PPKGLABPPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x97E7D0", Offset = "0x97D1D0", VA = "0x18097E7D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DEKHBKBDPPA GCAEPGDCAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x97E7F0", Offset = "0x97D1F0", VA = "0x18097E7F0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public NHLHBFNNCBA GOEBPHDLCAD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x97E800", Offset = "0x97D200", VA = "0x18097E800", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public JHDOIICAKMG FFKCPDMLDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x97E810", Offset = "0x97D210", VA = "0x18097E810", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public ODMFCPKINFP JNJIMJOOMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9173E0", Offset = "0x915DE0", VA = "0x1809173E0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PJKJDBDNPNA PIOAINDMGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA557A0", Offset = "0xA541A0", VA = "0x180A557A0", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D30", Offset = "0xAE1730", VA = "0x180AE2D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private bool EHGDPDJBHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x74CF210", Offset = "0x74CDC10", VA = "0x1874CF210", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool BJPHGINBFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x74CF0B0", Offset = "0x74CDAB0", VA = "0x1874CF0B0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool KJPPGKPBKHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x110E260", Offset = "0x110CC60", VA = "0x18110E260", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private CancellationToken ODEFBFIEFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x74CEDD0", Offset = "0x74CD7D0", VA = "0x1874CEDD0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private KNPHAFHLPCE CAJFIAJDFML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private bool HDHEGEHDNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x110E260", Offset = "0x110CC60", VA = "0x18110E260", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x110E5C0", Offset = "0x110CFC0", VA = "0x18110E5C0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action LGPMHAOKENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x74CEA60", Offset = "0x74CD460", VA = "0x1874CEA60", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x74CED70", Offset = "0x74CD770", VA = "0x1874CED70", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event CFHNALMKLMA BDJONJNAGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x74CF050", Offset = "0x74CDA50", VA = "0x1874CF050", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x74CEF90", Offset = "0x74CD990", VA = "0x1874CEF90", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event CFHNALMKLMA BMCKCKMAPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x74CE870", Offset = "0x74CD270", VA = "0x1874CE870", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x74CF130", Offset = "0x74CDB30", VA = "0x1874CF130", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event CFHNALMKLMA EBKANGGNAON
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x74CEEE0", Offset = "0x74CD8E0", VA = "0x1874CEEE0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x74CEFF0", Offset = "0x74CD9F0", VA = "0x1874CEFF0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<EFFOBLOOKHB, bool> LOOMGJEIEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x74CE720", Offset = "0x74CD120", VA = "0x1874CE720", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x74CE810", Offset = "0x74CD210", VA = "0x1874CE810", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xAE2D30", Offset = "0xAE1730", VA = "0x180AE2D30", Slot = "39")]
	public void BKEAPLAGHHC(PJKJDBDNPNA MGLFGDPIFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x74CF270", Offset = "0x74CDC70", VA = "0x1874CF270")]
	[UnityEngine.Scripting.Preserve]
	internal DLNBAALPHKO([CCLEDEMDDDH(null)] KNPHAFHLPCE DNJEODDCEHK, [CCLEDEMDDDH(null)] AFIFLHJBILJ PPPAPIDLOLG, [CCLEDEMDDDH(null)] DOOOEJMHPPN PLHIEMHOPEN, [CCLEDEMDDDH(null)] KJJEFGMNENB LPMHKEAJABJ, [CCLEDEMDDDH(null)] OLDOMICMCLE GHPOCDJEIKE, [CCLEDEMDDDH(null)] GHMLDOKPIEJ LECPPJMHGPI, [CCLEDEMDDDH(null)] DBGOGJCAPOP EHBONKLPEJA, [CCLEDEMDDDH(null)] NABBJMIMBHJ IHIBLLDLEOK, [CCLEDEMDDDH(null)] IGPBEMDEPGN IIDIIILHIBL, [CCLEDEMDDDH(null)] OMEBFBKKFLB MIICODMIGPJ, [CCLEDEMDDDH(null)] DPJHKHBBEOG MMCIPCCEHPC, [CCLEDEMDDDH(null)] DDBNMLNEHIP CCJOCOODAJD, [CCLEDEMDDDH(null)] NPKEPDCOMBP NMEFFLKAPDF, [CCLEDEMDDDH(null)] LOHPJEPNHKG CLNLGBEAIIE, [CCLEDEMDDDH(null)] FMLMHOJGBKM NBKPNKMOCKK, [CCLEDEMDDDH(null)] FJDOHFHFGLG MHCOCCPNFIM, [CCLEDEMDDDH(null)] LIPLGMABIAE HPKIHFDGOLI, [CCLEDEMDDDH(null)] IOALELDLDFJ NCJNKANAMGG, [CCLEDEMDDDH(null)] BIAJFCCKFCN BPCICBJAHNP, [CCLEDEMDDDH(null)] BGKNBPLJCOM PNAMJGDBFLH, [CCLEDEMDDDH(null)] DDKLCJFENGE KEEAHJFOMOA, [CCLEDEMDDDH(null)] EKJOFOMEOLD JCALHDINLHE, [CCLEDEMDDDH(null)] FDFLOOOBEGF IPMEMBNNJOO, [CCLEDEMDDDH(null)] NJHOEBOADMN BLCMHIPFLJL, [CCLEDEMDDDH(null)] EHDAEHMMJMI BLHFHKECOAL, [CCLEDEMDDDH(null)] GLMJNFIMHHJ BLHPPLPBDDE, [CCLEDEMDDDH(null)] FBCIJNEHIMJ KOMKCDKPFFA, [CCLEDEMDDDH(null)] BPAMECECBJC KDFCJCBEFGB, [CCLEDEMDDDH(null)] DEKHBKBDPPA JPKJIMJDOAB, [CCLEDEMDDDH(null)] NHLHBFNNCBA CANPPHMHKPK, [CCLEDEMDDDH(null)] JHDOIICAKMG IKFIPKNPGAA, [CCLEDEMDDDH(null)] ODMFCPKINFP KOIKCMMDLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x74CEB50", Offset = "0x74CD550", VA = "0x1874CEB50")]
	private void GCHKJEOLKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x74CE8D0", Offset = "0x74CD2D0", VA = "0x1874CE8D0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x74CEF40", Offset = "0x74CD940", VA = "0x1874CEF40", Slot = "53")]
	private void JHDLMEFDBJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x74CEAC0", Offset = "0x74CD4C0", VA = "0x1874CEAC0", Slot = "54")]
	private PPMFHAJFKFP FFNBHPJIMKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x74CE780", Offset = "0x74CD180", VA = "0x1874CE780", Slot = "55")]
	private GHACJEKPKON BCJJCHEAAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x74CEC00", Offset = "0x74CD600", VA = "0x1874CEC00", Slot = "56")]
	[AsyncStateMachine(typeof(NDMNJIBPPAD))]
	private Task<ICNNFOGCALN> GFPAAPIFKJM(HODNKPFLLHK JCEPEPKPAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x74CEDF0", Offset = "0x74CD7F0", VA = "0x1874CEDF0", Slot = "57")]
	[AsyncStateMachine(typeof(OLFAIDOHONA))]
	private Task JCCAJELNACI(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x74CF190", Offset = "0x74CDB90", VA = "0x1874CF190")]
	[IteratorStateMachine(typeof(FJJFBBKJOGB))]
	private IEnumerable<BGABJPPAMJK> PENNADGOMKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x74CED10", Offset = "0x74CD710", VA = "0x1874CED10")]
	[CompilerGenerated]
	private void HJCMGGGKHIB(BGABJPPAMJK LHCHHCODKCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IKEFNAAEBHB : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x125B4F0", Offset = "0x1259EF0", VA = "0x18125B4F0")]
	public IKEFNAAEBHB(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class KGGGNEFFBAM : ICCNGKALNLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct NBNJGIFOAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KGGGNEFFBAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x74DB310", Offset = "0x74D9D10", VA = "0x1874DB310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x74DB650", Offset = "0x74DA050", VA = "0x1874DB650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public KGGGNEFFBAM(FBPDAHOOPKF GDNLGDEFCDG, KJJEFGMNENB LPMHKEAJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x74D7350", Offset = "0x74D5D50", VA = "0x1874D7350", Slot = "4")]
	[AsyncStateMachine(typeof(NBNJGIFOAHO))]
	public Task<bool> FOEGGLADAGJ(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x74D7270", Offset = "0x74D5C70", VA = "0x1874D7270")]
	[CompilerGenerated]
	private object EOKBNEENFEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class ILPDGONHGJF : ICCNGKALNLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JOIJNHDNPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public ILPDGONHGJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x74D69E0", Offset = "0x74D53E0", VA = "0x1874D69E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x74D7120", Offset = "0x74D5B20", VA = "0x1874D7120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x74D5E70", Offset = "0x74D4870", VA = "0x1874D5E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public ILPDGONHGJF(FBPDAHOOPKF GDNLGDEFCDG, KJJEFGMNENB LPMHKEAJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x74D5EC0", Offset = "0x74D48C0", VA = "0x1874D5EC0", Slot = "4")]
	[AsyncStateMachine(typeof(JOIJNHDNPNH))]
	public Task<bool> FOEGGLADAGJ(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x74D5FF0", Offset = "0x74D49F0", VA = "0x1874D5FF0")]
	[CompilerGenerated]
	private object GNONPKOCPNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class PELHCIKMBEG : ICCNGKALNLH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EFAHILPEILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public PELHCIKMBEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CLHBOPIGKGE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public OABHCPGEKDA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EFAHILPEILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x74CF800", Offset = "0x74CE200", VA = "0x1874CF800")]
		internal object JNAKBLIEENN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x74CF6F0", Offset = "0x74CE0F0", VA = "0x1874CF6F0")]
		internal object AFODMADMCGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x74CF760", Offset = "0x74CE160", VA = "0x1874CF760")]
		internal object HCIEGCPHJHM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct GPCJMPCKLCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public PELHCIKMBEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private EFAHILPEILJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<CLHBOPIGKGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x74D4390", Offset = "0x74D2D90", VA = "0x1874D4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x74D4D30", Offset = "0x74D3730", VA = "0x1874D4D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x74E3490", Offset = "0x74E1E90", VA = "0x1874E3490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public PELHCIKMBEG(FBPDAHOOPKF GDNLGDEFCDG, KJJEFGMNENB LPMHKEAJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x74E34E0", Offset = "0x74E1EE0", VA = "0x1874E34E0", Slot = "4")]
	[AsyncStateMachine(typeof(GPCJMPCKLCP))]
	public Task<bool> FOEGGLADAGJ(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface ICCNGKALNLH
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> FOEGGLADAGJ(CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct OLDFDAOAMHP
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class FGBJLGIJMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FBPDAHOOPKF manager;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FGBJLGIJMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x74D1210", Offset = "0x74CFC10", VA = "0x1874D1210")]
		internal Task CEFGEPABCKB(CancellationToken cancellationToken, int roomTotalVersion, AMGEEFGMLAH localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct KPHMOCPDNIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public OLDFDAOAMHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HODNKPFLLHK <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<NPEFLHBCDBA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter<ICNNFOGCALN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x74D7440", Offset = "0x74D5E40", VA = "0x1874D7440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x74D79D0", Offset = "0x74D63D0", VA = "0x1874D79D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct JLFLOOADAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public OLDFDAOAMHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x74D6180", Offset = "0x74D4B80", VA = "0x1874D6180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x74D64A0", Offset = "0x74D4EA0", VA = "0x1874D64A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CancellationToken PPLDCJFFMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly FBPDAHOOPKF PLJBPLDMFHL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private AFIFLHJBILJ EOOAFGCKNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x74DCDE0", Offset = "0x74DB7E0", VA = "0x1874DCDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF40", Offset = "0x74DB940", VA = "0x1874DCF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x74DC8A0", Offset = "0x74DB2A0", VA = "0x1874DC8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private OMEBFBKKFLB JJCBNCPFMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x74DC850", Offset = "0x74DB250", VA = "0x1874DC850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2296490", Offset = "0x2294E90", VA = "0x182296490")]
	public OLDFDAOAMHP(CancellationToken PPLDCJFFMEP, FBPDAHOOPKF PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x74DC920", Offset = "0x74DB320", VA = "0x1874DC920")]
	public static HENJFNIBNNB JCPEKMAGKOE(FBPDAHOOPKF PLJBPLDMFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x74DCE30", Offset = "0x74DB830", VA = "0x1874DCE30")]
	[AsyncStateMachine(typeof(KPHMOCPDNIJ))]
	public Task<bool> LDLLGDHEPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x74DCBD0", Offset = "0x74DB5D0", VA = "0x1874DCBD0")]
	private bool KIIBFNPAINE([Out] HODNKPFLLHK JCEPEPKPAGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x74DC9D0", Offset = "0x74DB3D0", VA = "0x1874DC9D0")]
	[AsyncStateMachine(typeof(JLFLOOADAPP))]
	private Task JGMHFLAEHOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x74DCAA0", Offset = "0x74DB4A0", VA = "0x1874DCAA0")]
	private Task<NPEFLHBCDBA> JLPNPOPCPMC(HODNKPFLLHK LICLIODPNFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct EPNHNLKELFB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly FMLMHOJGBKM NBKPNKMOCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Guid GGNKLHDGNDO;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Task<(ICNNFOGCALN, Task)> IOMOPDBBKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x74D1140", Offset = "0x74CFB40", VA = "0x1874D1140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x46493C0", Offset = "0x4647DC0", VA = "0x1846493C0")]
	public EPNHNLKELFB(FMLMHOJGBKM NBKPNKMOCKK, Guid GGNKLHDGNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x74D10F0", Offset = "0x74CFAF0", VA = "0x1874D10F0")]
	public TaskAwaiter<(ICNNFOGCALN, Task)> IFHANBOIBIK()
	{
		return default(TaskAwaiter<(ICNNFOGCALN, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x74D1020", Offset = "0x74CFA20", VA = "0x1874D1020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct OAGBAEKDJDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly TaskCompletionSource<(ICNNFOGCALN, Task)> MELAMMFCFNJ;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task<(ICNNFOGCALN, Task)> IOMOPDBBKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x74DC620", Offset = "0x74DB020", VA = "0x1874DC620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x74DC660", Offset = "0x74DB060", VA = "0x1874DC660")]
	public OAGBAEKDJDM(TimeSpan GELCEFJHMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x74DC4F0", Offset = "0x74DAEF0", VA = "0x1874DC4F0")]
	public void KMMABBDEPAO(Task ICOJFKOPMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x74DC590", Offset = "0x74DAF90", VA = "0x1874DC590")]
	public void MELLEFHKCHN(ICNNFOGCALN HDKFJJMEOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74DC4A0", Offset = "0x74DAEA0", VA = "0x1874DC4A0")]
	public void KBFCINKOFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x74DC410", Offset = "0x74DAE10", VA = "0x1874DC410")]
	internal void GAFAJNHGCCB(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NBNEODOEKOH
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PNNNKPCCEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public PDGFGDEMNEN subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PNNNKPCCEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x74E38C0", Offset = "0x74E22C0", VA = "0x1874E38C0")]
		internal bool CLAEKOPBIDH(EFEKMJJDMGI s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x74DAE00", Offset = "0x74D9800", VA = "0x1874DAE00")]
	public static CMBGKEDMCPG LNCAGMGJJFK(long DFBAGBMPJJF, long GDENKKEDKLA, string DEBCIKJGCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x74DB250", Offset = "0x74D9C50", VA = "0x1874DB250")]
	public static CMBGKEDMCPG LNCAGMGJJFK(long DFBAGBMPJJF, long GDENKKEDKLA, OAGGCGDDFAC FGOFNGOIJIL, long IOJIAKJKDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74DAE90", Offset = "0x74D9890", VA = "0x1874DAE90")]
	public static CMBGKEDMCPG LNCAGMGJJFK(AFCCLGFOAKC MBJLPPNAHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x74DB020", Offset = "0x74D9A20", VA = "0x1874DB020")]
	public static CMBGKEDMCPG LNCAGMGJJFK(IJINIJPNMHJ KIEEHCIFBCM, PDGFGDEMNEN IHKLOOOPBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x74DAB80", Offset = "0x74D9580", VA = "0x1874DAB80")]
	public static CMBGKEDMCPG BGEPBKNAHDE(this CMBGKEDMCPG ELHNCLABHAD, IJINIJPNMHJ FMNMMPIOMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x74DAC70", Offset = "0x74D9670", VA = "0x1874DAC70")]
	public static CMBGKEDMCPG EIBFGKGMOFA(this CMBGKEDMCPG ELHNCLABHAD, PDGFGDEMNEN LGMNLEHBAJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class KPMKFCPDHPA : IGPBEMDEPGN, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct EGCLLBGANGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public KPMKFCPDHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x74CF8F0", Offset = "0x74CE2F0", VA = "0x1874CF8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x74CFF80", Offset = "0x74CE980", VA = "0x1874CFF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly LLKIGIOJMJI EMCMPNPPFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string FKMJGKEGHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Task DFLNGBBDPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool LMAGFJCBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x74D7D50", Offset = "0x74D6750", VA = "0x1874D7D50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Task AOJAGOHACID
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x74D7BA0", Offset = "0x74D65A0", VA = "0x1874D7BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB30", Offset = "0x8AC530", VA = "0x1808ADB30", Slot = "7")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x74D7A40", Offset = "0x74D6440", VA = "0x1874D7A40", Slot = "6")]
	public void ABFOBPCDIMK(Task LPAAFOGOHKE, string HIEMBAHHPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x74D7C30", Offset = "0x74D6630", VA = "0x1874D7C30")]
	[AsyncStateMachine(typeof(EGCLLBGANGI))]
	private Task JLALHDLDJJC(Task GDGIBOIDLDJ, string HIEMBAHHPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x74D7D80", Offset = "0x74D6780", VA = "0x1874D7D80")]
	public KPMKFCPDHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class LAMPDONAEPP : MFAGGGGAHJC, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool ICDFHABJAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private LBJBADDKLDA AIFOMNFOFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private GLMJNFIMHHJ BLHPPLPBDDE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public LBJBADDKLDA GALDJJCLJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x74D7FD0", Offset = "0x74D69D0", VA = "0x1874D7FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x74D7E50", Offset = "0x74D6850", VA = "0x1874D7E50", Slot = "7")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x74D8100", Offset = "0x74D6B00", VA = "0x1874D8100", Slot = "5")]
	public void IKECHDLJLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x74D7E10", Offset = "0x74D6810", VA = "0x1874D7E10", Slot = "6")]
	public void GOFKABPEGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x74D8040", Offset = "0x74D6A40", VA = "0x1874D8040")]
	private Task GNMLNNAPKJI(BGPLHEJKADL HBABIBCNPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x74D7E10", Offset = "0x74D6810", VA = "0x1874D7E10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public LAMPDONAEPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class AMNKABHCNKN : GLMJNFIMHHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class LIPHFJOKFAB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly CLNMMCDHJBN LNJEDLFHNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly string PNABAFEIDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly T PFGHNJEFBFP;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x930140", Offset = "0x92EB40", VA = "0x180930140")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x9A2C60", Offset = "0x9A1660", VA = "0x1809A2C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x466D4E0", Offset = "0x466BEE0", VA = "0x18466D4E0")]
		public LIPHFJOKFAB(CLNMMCDHJBN LNJEDLFHNGJ, string PNABAFEIDND, T PFGHNJEFBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x466D1D0", Offset = "0x466BBD0", VA = "0x18466D1D0")]
		private void BPAENACODHK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly CLNMMCDHJBN LNJEDLFHNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LIPHFJOKFAB<TimeSpan> MFBHOOMCBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly LIPHFJOKFAB<TimeSpan> NOHJAJJFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly LIPHFJOKFAB<TimeSpan> HJAGOCLIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly LIPHFJOKFAB<TimeSpan> EGPMFIPBPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LIPHFJOKFAB<bool> EPPOEIEKLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly LIPHFJOKFAB<bool> HGICLACOLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly LIPHFJOKFAB<bool> FMEPCBFLPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly LIPHFJOKFAB<int> OIDOPMNFNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly LIPHFJOKFAB<bool> ODKHNKNBECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly LIPHFJOKFAB<bool> HHBADAPJNCP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan JMGLABKNNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x74C7BB0", Offset = "0x74C65B0", VA = "0x1874C7BB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan HFNPIGCMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x74C79B0", Offset = "0x74C63B0", VA = "0x1874C79B0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan BKOEHCFMMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x74C79F0", Offset = "0x74C63F0", VA = "0x1874C79F0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TimeSpan APJBMFEKMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x74C7A30", Offset = "0x74C6430", VA = "0x1874C7A30", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JGMJAAKHELO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x74C7BF0", Offset = "0x74C65F0", VA = "0x1874C7BF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CDMPKPAGEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x74C7A70", Offset = "0x74C6470", VA = "0x1874C7A70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool IFBHGONJKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x74C7B70", Offset = "0x74C6570", VA = "0x1874C7B70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int HBCIKMDGLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x74C7AB0", Offset = "0x74C64B0", VA = "0x1874C7AB0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OBIEBBIOLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x74C7B30", Offset = "0x74C6530", VA = "0x1874C7B30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool NJJOAGPCLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x74C7AF0", Offset = "0x74C64F0", VA = "0x1874C7AF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x74C7C30", Offset = "0x74C6630", VA = "0x1874C7C30")]
	[UnityEngine.Scripting.Preserve]
	public AMNKABHCNKN([CCLEDEMDDDH(null)] CLNMMCDHJBN LNJEDLFHNGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class BOFIHGBEPJO : DPJHKHBBEOG, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class KBJAICKEHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public PPGGANEOPEN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KBJAICKEHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x74D7190", Offset = "0x74D5B90", VA = "0x1874D7190")]
		internal object NDCCDMLGJCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action CPBOPCBHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x74CCBA0", Offset = "0x74CB5A0", VA = "0x1874CCBA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x74CCB00", Offset = "0x74CB500", VA = "0x1874CCB00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event CFHNALMKLMA KJHDEBHKFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x74CD4A0", Offset = "0x74CBEA0", VA = "0x1874CD4A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x74CCE30", Offset = "0x74CB830", VA = "0x1874CCE30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event CFHNALMKLMA JDGHOLPCOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x74CCF80", Offset = "0x74CB980", VA = "0x1874CCF80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x74CD020", Offset = "0x74CBA20", VA = "0x1874CD020", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CFHNALMKLMA MDJCECFDODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x74CD320", Offset = "0x74CBD20", VA = "0x1874CD320", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x74CD0C0", Offset = "0x74CBAC0", VA = "0x1874CD0C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EFFOBLOOKHB, bool> NHCPENDGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x74CCED0", Offset = "0x74CB8D0", VA = "0x1874CCED0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x74CD3C0", Offset = "0x74CBDC0", VA = "0x1874CD3C0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "19")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x74CCC40", Offset = "0x74CB640", VA = "0x1874CCC40", Slot = "14")]
	public void CAKHLALFMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x74CD540", Offset = "0x74CBF40", VA = "0x1874CD540", Slot = "15")]
	public void MFKJOLDEJOD(PPGGANEOPEN JFBLNKBHMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x74CD5C0", Offset = "0x74CBFC0", VA = "0x1874CD5C0", Slot = "16")]
	public void NOBKMNGGIDI(PPGGANEOPEN JFBLNKBHMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x74CD470", Offset = "0x74CBE70", VA = "0x1874CD470", Slot = "17")]
	public void LALHHCBJAGF(PPGGANEOPEN JFBLNKBHMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x74CD570", Offset = "0x74CBF70", VA = "0x1874CD570", Slot = "18")]
	public void NBIBJEEIEKH(EFFOBLOOKHB MCFACOPHFFE, bool HDKDMAHLAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x74CD160", Offset = "0x74CBB60", VA = "0x1874CD160")]
	private void GHJBKJMLHEK(CFHNALMKLMA CJMBIMOEFGE, PPGGANEOPEN JFBLNKBHMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public BOFIHGBEPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class LLJOGJOFNLF : DDBNMLNEHIP, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct OLGFNKHBPIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public LLJOGJOFNLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x74DD220", Offset = "0x74DBC20", VA = "0x1874DD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x74DD7A0", Offset = "0x74DC1A0", VA = "0x1874DD7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct GJFILJDDJCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public LLJOGJOFNLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x74D3C20", Offset = "0x74D2620", VA = "0x1874D3C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x74D42C0", Offset = "0x74D2CC0", VA = "0x1874D42C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GMEDDPKMINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GMEDDPKMINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x74D4320", Offset = "0x74D2D20", VA = "0x1874D4320")]
		internal object GJNNCNKJBLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FPKBAALMFLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public LLJOGJOFNLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private GMEDDPKMINC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x74D2D00", Offset = "0x74D1700", VA = "0x1874D2D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x74D3450", Offset = "0x74D1E50", VA = "0x1874D3450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class PBIPMFBPEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PBIPMFBPEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x74E3420", Offset = "0x74E1E20", VA = "0x1874E3420")]
		internal object FPPBCIEDECN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private ICCNGKALNLH[] NIFJGFPAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource KPJNJINNMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int EHBMPKFEFFI;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x74D83E0", Offset = "0x74D6DE0", VA = "0x1874D83E0", Slot = "6")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x74D8300", Offset = "0x74D6D00", VA = "0x1874D8300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x74D8770", Offset = "0x74D7170", VA = "0x1874D8770", Slot = "8")]
	public void JACDBNOBCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x74D8310", Offset = "0x74D6D10", VA = "0x1874D8310", Slot = "5")]
	public void EKIMNMODEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x74D89B0", Offset = "0x74D73B0", VA = "0x1874D89B0", Slot = "4")]
	[AsyncStateMachine(typeof(OLGFNKHBPIK))]
	public Task NJCOGDGMBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x74D8A80", Offset = "0x74D7480", VA = "0x1874D8A80")]
	private void ODNMDBEPJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x74D8590", Offset = "0x74D6F90", VA = "0x1874D8590")]
	[AsyncStateMachine(typeof(GJFILJDDJCI))]
	private Task HMDGNEHCFEJ(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x74D8870", Offset = "0x74D7270", VA = "0x1874D8870")]
	[AsyncStateMachine(typeof(FPKBAALMFLI))]
	private Task<bool> JFEDBMMILIA(int GCBONJOGHCD, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x74D8D90", Offset = "0x74D7790", VA = "0x1874D8D90")]
	private void OKBHGPMOECD(int GCBONJOGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x74D8690", Offset = "0x74D7090", VA = "0x1874D8690")]
	private void HOEDDPHPEBC(int GCBONJOGHCD, bool HDKDMAHLAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x74D8460", Offset = "0x74D6E60", VA = "0x1874D8460")]
	private void GJKFEDFLGDM(int GCBONJOGHCD, Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x74D8E70", Offset = "0x74D7870", VA = "0x1874D8E70")]
	private void PPLNCGOKFCD(CancellationToken PPLDCJFFMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public LLJOGJOFNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class BBFLLBKDKCA : NPKEPDCOMBP, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct FNJAJPMPONC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public PJKJDBDNPNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x74D1710", Offset = "0x74D0110", VA = "0x1874D1710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x74D2070", Offset = "0x74D0A70", VA = "0x1874D2070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct HEOINLPHFKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PJKJDBDNPNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private FILMNPNNHPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private HIEPCOOLPHO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private KBEJLAHBIDN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private NCCOJAPKPJB <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x74D4E90", Offset = "0x74D3890", VA = "0x1874D4E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x74D5B40", Offset = "0x74D4540", VA = "0x1874D5B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class JFBPLDHMIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Matchmaking.HBLONCNLFEI result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FDMGJGCOOAA errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JFBPLDHMIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x74D60D0", Offset = "0x74D4AD0", VA = "0x1874D60D0")]
		internal object ILIKLOBLCLL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class CMHCAFBDDFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Task<CMBGKEDMCPG> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CMHCAFBDDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		internal Task<CMBGKEDMCPG> GPILOBADHGD(FILMNPNNHPJ<string>.EEFAEMIIABD _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PAIHMANGLJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PJKJDBDNPNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KBEJLAHBIDN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private CMHCAFBDDFO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private PECEMKMFHAP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private HIEPCOOLPHO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private FJEHGFKNFIJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Task<Matchmaking.LELKPOPMNFG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private HBFIPCLCOOK <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<Matchmaking.LELKPOPMNFG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<CMBGKEDMCPG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x74DDA00", Offset = "0x74DC400", VA = "0x1874DDA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x74E33C0", Offset = "0x74E1DC0", VA = "0x1874E33C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct EMOAJPPNMBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x74D0560", Offset = "0x74CEF60", VA = "0x1874D0560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x74D0FC0", Offset = "0x74CF9C0", VA = "0x1874D0FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct LNIOMPFIMEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private KNPHAFHLPCE <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x74D9A70", Offset = "0x74D8470", VA = "0x1874D9A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x74D9F00", Offset = "0x74D8900", VA = "0x1874D9F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct EJDFEOAKBIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<Matchmaking.LELKPOPMNFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<Matchmaking.LELKPOPMNFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x74CFFE0", Offset = "0x74CE9E0", VA = "0x1874CFFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x74D04F0", Offset = "0x74CEEF0", VA = "0x1874D04F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct GDDHOGHLHMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Matchmaking.LELKPOPMNFG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public KBEJLAHBIDN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<JAABJCJLCGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x74D34C0", Offset = "0x74D1EC0", VA = "0x1874D34C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x74D3BC0", Offset = "0x74D25C0", VA = "0x1874D3BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class OLKLEGILDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OLKLEGILDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x74DD800", Offset = "0x74DC200", VA = "0x1874DD800")]
		internal object CKMCIBPMFBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x74DD900", Offset = "0x74DC300", VA = "0x1874DD900")]
		internal string KFMMDELJNAE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct FNLDFANCJEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private OLKLEGILDBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x74D20D0", Offset = "0x74D0AD0", VA = "0x1874D20D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x74D2CA0", Offset = "0x74D16A0", VA = "0x1874D2CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct BFGJDAIAEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public KBEJLAHBIDN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CMBGKEDMCPG initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public OABHCPGEKDA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PECEMKMFHAP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x74CC180", Offset = "0x74CAB80", VA = "0x1874CC180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x74CCAA0", Offset = "0x74CB4A0", VA = "0x1874CCAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct POKDMOIEGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private HIEPCOOLPHO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private HIEPCOOLPHO <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x74E38F0", Offset = "0x74E22F0", VA = "0x1874E38F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x74E50D0", Offset = "0x74E3AD0", VA = "0x1874E50D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct MLJHHCPFNNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AMGEEFGMLAH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public BBFLLBKDKCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<ICNNFOGCALN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x74DA180", Offset = "0x74D8B80", VA = "0x1874DA180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x74DA8F0", Offset = "0x74D92F0", VA = "0x1874DA8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class ABCLNPPIKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ABCLNPPIKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x74E6520", Offset = "0x74E4F20", VA = "0x1874E6520")]
		internal object FECOOCEFLIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class EEINJHCOBNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EEINJHCOBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x74EE3A0", Offset = "0x74ECDA0", VA = "0x1874EE3A0")]
		internal void BCMEJOCAJGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class CJPPHFDLNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CJPPHFDLNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x74EA110", Offset = "0x74E8B10", VA = "0x1874EA110")]
		internal object IDHFMONNBFA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CDNLBJOEPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CDNLBJOEPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x74E93B0", Offset = "0x74E7DB0", VA = "0x1874E93B0")]
		internal string BLIAGCOLGNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly KLEHBGEJMBN CFKDOOGJPPE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly KLEHBGEJMBN IILPLAJAEHO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly KLEHBGEJMBN EMJIEPILPOC;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string GNCDHGCGEIK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string BBOIDDIOIHH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string LGIJLDOFNIH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid OEIDBOMBCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NABBJMIMBHJ IHIBLLDLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private DOOOEJMHPPN PLHIEMHOPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private DDBNMLNEHIP CCJOCOODAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IGPBEMDEPGN IIDIIILHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private DPJHKHBBEOG MMCIPCCEHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NHLHBFNNCBA CANPPHMHKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private DEKHBKBDPPA JPKJIMJDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private IDisposable EJNPJLEIAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private ODMFCPKINFP KOIKCMMDLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly LLKIGIOJMJI INKJGDKDBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private HBFIPCLCOOK KEHPAAMAKLN;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TaskStatus IPCBCGGHFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC0", Offset = "0x8D29C0", VA = "0x1808D3FC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE003F0", Offset = "0xDFEDF0", VA = "0x180E003F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x74C9B10", Offset = "0x74C8510", VA = "0x1874C9B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x74C9BC0", Offset = "0x74C85C0", VA = "0x1874C9BC0", Slot = "6")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x74C9AC0", Offset = "0x74C84C0", VA = "0x1874C9AC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x74C9320", Offset = "0x74C7D20", VA = "0x1874C9320", Slot = "5")]
	[AsyncStateMachine(typeof(FNJAJPMPONC))]
	public Task CHLONABFCKK(OABHCPGEKDA LHCPGGNLCPO, PJKJDBDNPNA BEKFCPHIIBE, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x74CAD20", Offset = "0x74C9720", VA = "0x1874CAD20")]
	[AsyncStateMachine(typeof(HEOINLPHFKI))]
	private Task LCMAGFAOMPE(OABHCPGEKDA LHCPGGNLCPO, PJKJDBDNPNA BEKFCPHIIBE, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x74C9EF0", Offset = "0x74C88F0", VA = "0x1874C9EF0")]
	private void GPMAKGMCBIP(NHLHBFNNCBA CANPPHMHKPK, OABHCPGEKDA LHCPGGNLCPO, Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x74C8AE0", Offset = "0x74C74E0", VA = "0x1874C8AE0")]
	private static void BBJEMPKPAJO(NCCOJAPKPJB BJDNGABLKEC, Exception AENFONOHPNM, [Optional] List<int> ANGGDBIIFKK, int EHBMPKFEFFI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x74CA5F0", Offset = "0x74C8FF0", VA = "0x1874CA5F0")]
	[AsyncStateMachine(typeof(PAIHMANGLJO))]
	private Task IEAMBOOBDDM(FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, OABHCPGEKDA LHCPGGNLCPO, PJKJDBDNPNA BEKFCPHIIBE, KBEJLAHBIDN KGIEHKLDBAL, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x74C86D0", Offset = "0x74C70D0", VA = "0x1874C86D0")]
	private void ACNHKKKPEDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x74CB350", Offset = "0x74C9D50", VA = "0x1874CB350")]
	[AsyncStateMachine(typeof(EMOAJPPNMBO))]
	private Task MMEECMFJIIM(FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x74CB020", Offset = "0x74C9A20", VA = "0x1874CB020")]
	private void MHFJHGGEFDL(OABHCPGEKDA LHCPGGNLCPO, CancellationToken AGFJCKJDLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x74CB850", Offset = "0x74CA250", VA = "0x1874CB850")]
	private void PLMPEEHOCNP(OABHCPGEKDA LHCPGGNLCPO, KBEJLAHBIDN KGIEHKLDBAL, OperationCanceledException MIJDMHFFDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x74CA8C0", Offset = "0x74C92C0", VA = "0x1874CA8C0")]
	private void JPONBIIEEPB(OABHCPGEKDA LHCPGGNLCPO, KBEJLAHBIDN KGIEHKLDBAL, Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x74CAB10", Offset = "0x74C9510", VA = "0x1874CAB10")]
	private void KNAOAJINCFJ(OABHCPGEKDA LHCPGGNLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x74CA860", Offset = "0x74C9260", VA = "0x1874CA860")]
	private static PPGGANEOPEN JGMAHCGOAOI(OABHCPGEKDA LHCPGGNLCPO)
	{
		return default(PPGGANEOPEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x74C8820", Offset = "0x74C7220", VA = "0x1874C8820")]
	[AsyncStateMachine(typeof(LNIOMPFIMEH))]
	private Task AHKPOJIBJFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x74C9960", Offset = "0x74C8360", VA = "0x1874C9960")]
	[AsyncStateMachine(typeof(EJDFEOAKBIO))]
	private Task<Matchmaking.LELKPOPMNFG> DGEIONBNEJG(OABHCPGEKDA LHCPGGNLCPO, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x74CA4E0", Offset = "0x74C8EE0", VA = "0x1874CA4E0")]
	private static JAABJCJLCGG IBHNBPLCIJA(Matchmaking.LELKPOPMNFG LPALEPFOLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x74C9810", Offset = "0x74C8210", VA = "0x1874C9810")]
	[AsyncStateMachine(typeof(GDDHOGHLHMH))]
	private Task DFLDGCFDEMJ(Matchmaking.LELKPOPMNFG LPALEPFOLDA, KBEJLAHBIDN KGIEHKLDBAL, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken BIDJOLCDMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x74C9460", Offset = "0x74C7E60", VA = "0x1874C9460")]
	[AsyncStateMachine(typeof(FNLDFANCJEI))]
	private Task COFDPPCELEC(OABHCPGEKDA LHCPGGNLCPO, CancellationTokenSource EDOFEECPDJB, Task LDBAGOHMJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x74C95A0", Offset = "0x74C7FA0", VA = "0x1874C95A0")]
	[AsyncStateMachine(typeof(BFGJDAIAEEC))]
	private Task COLNEBBKDDL(CMBGKEDMCPG ILIGNFDOOJF, PECEMKMFHAP PDCHMKBJFFI, OABHCPGEKDA IFLIICDFCDL, KBEJLAHBIDN NIOBMBBNOKE, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken BCMAHIFGPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x74C88F0", Offset = "0x74C72F0", VA = "0x1874C88F0")]
	private KBEJLAHBIDN BAGIOEMHNKC(KBEJLAHBIDN NIOBMBBNOKE, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x74CBB00", Offset = "0x74CA500", VA = "0x1874CBB00")]
	[AsyncStateMachine(typeof(POKDMOIEGMM))]
	private Task PPBADLGFIDK(FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x74CB600", Offset = "0x74CA000", VA = "0x1874CB600")]
	[AsyncStateMachine(typeof(MLJHHCPFNNM))]
	private Task NEJBPKFOJHG(CancellationToken PPLDCJFFMEP, int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x74CA360", Offset = "0x74C8D60", VA = "0x1874CA360")]
	private static void HLNDGBJJGOD(OABHCPGEKDA LHCPGGNLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x74C8490", Offset = "0x74C6E90", VA = "0x1874C8490")]
	private void ACBNLFONHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x74CB7C0", Offset = "0x74CA1C0", VA = "0x1874CB7C0")]
	private void OGINIFFDCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x74CB730", Offset = "0x74CA130", VA = "0x1874CB730")]
	private void NICDCCGKGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x74CB570", Offset = "0x74C9F70", VA = "0x1874CB570")]
	private void MPOOFHLNLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x74CB480", Offset = "0x74C9E80", VA = "0x1874CB480")]
	private static void MPILCDBJJCP(OABHCPGEKDA LHCPGGNLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x74CA750", Offset = "0x74C9150", VA = "0x1874CA750")]
	private static CancellationTokenRegistration IFPIMHDNPHJ(OABHCPGEKDA LHCPGGNLCPO, CancellationToken BIDJOLCDMDJ)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x74C9710", Offset = "0x74C8110", VA = "0x1874C9710")]
	private static void DCJEAABBJKK(OABHCPGEKDA LHCPGGNLCPO, Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x74CAE70", Offset = "0x74C9870", VA = "0x1874CAE70")]
	private void MCNJDANMHKP(OABHCPGEKDA LHCPGGNLCPO, Task LDBAGOHMJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x74CBAA0", Offset = "0x74CA4A0", VA = "0x1874CBAA0")]
	private static void PMAPEFGPDFK(Func<string> EDMGDMNLJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x74CBE40", Offset = "0x74CA840", VA = "0x1874CBE40")]
	public BBFLLBKDKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x74C9B60", Offset = "0x74C8560", VA = "0x1874C9B60")]
	[CompilerGenerated]
	internal static (int, int?) FNEIHIHJPHI(FDMGJGCOOAA IJKGJPCAEHK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class FOCLJIBGGFO : LOHPJEPNHKG, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct DKDLHHKHIGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public FOCLJIBGGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AMGEEFGMLAH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x74ED240", Offset = "0x74EBC40", VA = "0x1874ED240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x74ED6A0", Offset = "0x74EC0A0", VA = "0x1874ED6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class ILAJMCPFNPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public FOCLJIBGGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AMGEEFGMLAH localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ILAJMCPFNPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x74F6780", Offset = "0x74F5180", VA = "0x1874F6780")]
		internal List<Task> NDNBGOACFNP(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct PPGINOKGHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public HENJFNIBNNB taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AMGEEFGMLAH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7504200", Offset = "0x7502C00", VA = "0x187504200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x75045A0", Offset = "0x7502FA0", VA = "0x1875045A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct HCNMHAPOGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public FOCLJIBGGFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x74F2D60", Offset = "0x74F1760", VA = "0x1874F2D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x74F3040", Offset = "0x74F1A40", VA = "0x1874F3040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly HashSet<HENJFNIBNNB> PNDHLEJEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private DOOOEJMHPPN PLHIEMHOPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private LFIFNCDGBCI IMLCMGFEAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private LEEBKNONMND AGCCOLEMHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private IDisposable EJNPJLEIAIE;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x74F07C0", Offset = "0x74EF1C0", VA = "0x1874F07C0", Slot = "5")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x74F0610", Offset = "0x74EF010", VA = "0x1874F0610", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x74F0690", Offset = "0x74EF090", VA = "0x1874F0690", Slot = "4")]
	public bool EFABOMJDHPB(HENJFNIBNNB CLANKLMLIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x74F06F0", Offset = "0x74EF0F0", VA = "0x1874F06F0")]
	private void GAGENLJOODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x74F12E0", Offset = "0x74EFCE0", VA = "0x1874F12E0")]
	private void NADPAGOAFEA(LKMBJDMKDPJ GJLDCFIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x74F1120", Offset = "0x74EFB20", VA = "0x1874F1120")]
	[AsyncStateMachine(typeof(DKDLHHKHIGJ))]
	private Task MBNFNMHPPKA(int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x74F0FA0", Offset = "0x74EF9A0", VA = "0x1874F0FA0")]
	private Func<CancellationToken, List<Task>> IBMHENMONNG(int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x74F0AC0", Offset = "0x74EF4C0", VA = "0x1874F0AC0")]
	private List<Task> HFIAHDKLMEL(int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x74F04F0", Offset = "0x74EEEF0", VA = "0x1874F04F0")]
	[AsyncStateMachine(typeof(PPGINOKGHPK))]
	private Task AMIHMCHJIKC(HENJFNIBNNB CNHGHEFAGAD, CancellationToken AICEIDIHFDO, int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x74F1210", Offset = "0x74EFC10", VA = "0x1874F1210")]
	[AsyncStateMachine(typeof(HCNMHAPOGAM))]
	private Task MGMMPCBFGOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x74F1070", Offset = "0x74EFA70", VA = "0x1874F1070")]
	private void JACDBNOBCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x74F1500", Offset = "0x74EFF00", VA = "0x1874F1500")]
	public FOCLJIBGGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class CMIBPCFLKCN : FMLMHOJGBKM, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KMEGNJDDOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KMEGNJDDOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x74F9790", Offset = "0x74F8190", VA = "0x1874F9790")]
		internal object GGAJHMMAPPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class LPCJLLLJIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LPCJLLLJIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x74FD610", Offset = "0x74FC010", VA = "0x1874FD610")]
		internal object ILBGLEHAAFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class BGPEILDJBCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BGPEILDJBCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class IEFONDPHEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IEFONDPHEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x74F4950", Offset = "0x74F3350", VA = "0x1874F4950")]
		internal object IOJJMFHJMBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class LKNCIGCPHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LKNCIGCPHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x74FC020", Offset = "0x74FAA20", VA = "0x1874FC020")]
		internal object LLHCNCHOJLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, OAGBAEKDJDM> NBKPNKMOCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan BPPEPKPJLNG;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "9")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x74EA3C0", Offset = "0x74E8DC0", VA = "0x1874EA3C0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x74EA950", Offset = "0x74E9350", VA = "0x1874EA950", Slot = "4")]
	public EPNHNLKELFB NOEGDDICEDP(Guid GGNKLHDGNDO)
	{
		return default(EPNHNLKELFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x74EAB70", Offset = "0x74E9570", VA = "0x1874EAB70", Slot = "5")]
	public bool PJOABDGMIKH(Guid GGNKLHDGNDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x74EA3D0", Offset = "0x74E8DD0", VA = "0x1874EA3D0", Slot = "6")]
	public bool FODGDHNKOOG(Guid GGNKLHDGNDO, Task ICOJFKOPMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x74EA700", Offset = "0x74E9100", VA = "0x1874EA700", Slot = "7")]
	public bool HBIHPKCLNJA(Guid GGNKLHDGNDO, ICNNFOGCALN HDKFJJMEOOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x74EA8E0", Offset = "0x74E92E0", VA = "0x1874EA8E0", Slot = "8")]
	public Task<(ICNNFOGCALN, Task)> JAFGNDABKEC(Guid GGNKLHDGNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x74EA190", Offset = "0x74E8B90", VA = "0x1874EA190")]
	private void BJEIPKCGKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x74EAD80", Offset = "0x74E9780", VA = "0x1874EAD80")]
	public CMIBPCFLKCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class IIECGHCDGPC : FJDOHFHFGLG, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class FCEFJNACIJL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly OABHCPGEKDA CPOHCGKKOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource KPJNJINNMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken NMEFDPMOOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool BEHBOEGHDHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool IFCFLPBDAAE;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x74EEF40", Offset = "0x74ED940", VA = "0x1874EEF40")]
		public FCEFJNACIJL(OABHCPGEKDA CPOHCGKKOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x74EEDF0", Offset = "0x74ED7F0", VA = "0x1874EEDF0")]
		public void JACDBNOBCLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x74EEDC0", Offset = "0x74ED7C0", VA = "0x1874EEDC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class BIHLAOFGMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public BGPLHEJKADL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BIHLAOFGMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x74E8BC0", Offset = "0x74E75C0", VA = "0x1874E8BC0")]
		internal object BINCAHOPLBF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CMLIKMOLJPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public BGPLHEJKADL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public IIECGHCDGPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x74EAE40", Offset = "0x74E9840", VA = "0x1874EAE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x74EB240", Offset = "0x74E9C40", VA = "0x1874EB240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class FGAOJCCFKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FGAOJCCFKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x74EFC20", Offset = "0x74EE620", VA = "0x1874EFC20")]
		internal object JNADGONCBFO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct DHEMDIPKCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public IIECGHCDGPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private HIEPCOOLPHO <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x74EB870", Offset = "0x74EA270", VA = "0x1874EB870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class IKAGLEGHMOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public OABHCPGEKDA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IKAGLEGHMOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x74F5F00", Offset = "0x74F4900", VA = "0x1874F5F00")]
		internal object MCDCDELOMOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x74F5EC0", Offset = "0x74F48C0", VA = "0x1874F5EC0")]
		internal object IMJPNNMNJLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x74F5FA0", Offset = "0x74F49A0", VA = "0x1874F5FA0")]
		internal object MJEFEKANOGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class IKAFJBOAKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IKAFJBOAKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x74F5E20", Offset = "0x74F4820", VA = "0x1874F5E20")]
		internal void CJGGCKHJMME()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct PBOKAMJELJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public OABHCPGEKDA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public IIECGHCDGPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public PJKJDBDNPNA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private IKAGLEGHMOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7502A20", Offset = "0x7501420", VA = "0x187502A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x75039B0", Offset = "0x75023B0", VA = "0x1875039B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly EMGGFFOCNGH.KHDLAGHOLOJ BEMJOOHPJAE;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly HLIICKAHJNC GALKGOJADFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private DOOOEJMHPPN PLHIEMHOPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private DDBNMLNEHIP CCJOCOODAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private GLMJNFIMHHJ BLHPPLPBDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NPKEPDCOMBP NMEFFLKAPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private OABHCPGEKDA IMIHMMMFJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private FCEFJNACIJL LJNPCBMJPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool ENBNONMAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task DNJOMIFBIOJ;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x74F4CF0", Offset = "0x74F36F0", VA = "0x1874F4CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool LHJKDFCBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA895D0", Offset = "0xA87FD0", VA = "0x180A895D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x74F58F0", Offset = "0x74F42F0", VA = "0x1874F58F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x74F5040", Offset = "0x74F3A40", VA = "0x1874F5040", Slot = "4")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x74F4B80", Offset = "0x74F3580", VA = "0x1874F4B80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x74F52E0", Offset = "0x74F3CE0", VA = "0x1874F52E0")]
	[AsyncStateMachine(typeof(CMLIKMOLJPJ))]
	private Task GMDANCMDOFB(BGPLHEJKADL OGMBHOPMOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x74F5760", Offset = "0x74F4160", VA = "0x1874F5760")]
	private void LFJGIMMMJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x74F53D0", Offset = "0x74F3DD0", VA = "0x1874F53D0")]
	private void JEGNEAECCMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x74F49B0", Offset = "0x74F33B0", VA = "0x1874F49B0")]
	private void BAKLOCLDODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x74F4FD0", Offset = "0x74F39D0", VA = "0x1874F4FD0")]
	private bool GCCPPEOKGAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x74F5560", Offset = "0x74F3F60", VA = "0x1874F5560")]
	[AsyncStateMachine(typeof(DHEMDIPKCML))]
	private void KHPOIAOGJJK(int KDHNKHNNOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x74F4D40", Offset = "0x74F3740", VA = "0x1874F4D40")]
	private void FBLBCHJEMMA([Out] IDisposable OKPEENLECPE, [Out] IDisposable NBGMKBIHGMH, [Out] IDisposable CJKOGPLMAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x74F5900", Offset = "0x74F4300", VA = "0x1874F5900")]
	private bool PNCOELKOMMM(OABHCPGEKDA CPOHCGKKOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x74F4B30", Offset = "0x74F3530", VA = "0x1874F4B30")]
	private void CKOMMPNNOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x74F5630", Offset = "0x74F4030", VA = "0x1874F5630")]
	[AsyncStateMachine(typeof(PBOKAMJELJK))]
	private Task LCMAGFAOMPE(OABHCPGEKDA CPOHCGKKOHM, PJKJDBDNPNA BEKFCPHIIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x74F5DB0", Offset = "0x74F47B0", VA = "0x1874F5DB0")]
	public IIECGHCDGPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class LAEJFKLHDAD : LIPLGMABIAE, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct HONBPHFDHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<DOFMJKPJLKG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public LAEJFKLHDAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<DOFMJKPJLKG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x74F3FB0", Offset = "0x74F29B0", VA = "0x1874F3FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x74F4240", Offset = "0x74F2C40", VA = "0x1874F4240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class EJGDHFPBEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JDBONLEIIML message;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EJGDHFPBEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x74EE4F0", Offset = "0x74ECEF0", VA = "0x1874EE4F0")]
		internal object FKOKPGOLFHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class DPDMHCNAOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public JDBONLEIIML messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DPDMHCNAOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x74ED9E0", Offset = "0x74EC3E0", VA = "0x1874ED9E0")]
		internal object BLEJJDKIEME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class DJBPDFKCJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DJBPDFKCJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x74ED0C0", Offset = "0x74EBAC0", VA = "0x1874ED0C0")]
		internal object HOANMHMKAIL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct HDNEGFDHALL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public LAEJFKLHDAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<KJKAGGHNJFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x74F30A0", Offset = "0x74F1AA0", VA = "0x1874F30A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x74F3970", Offset = "0x74F2370", VA = "0x1874F3970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class AHFICFCDLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public JDBONLEIIML operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AHFICFCDLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x74E7250", Offset = "0x74E5C50", VA = "0x1874E7250")]
		internal object DPIGLADHDHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct NIHGMNGOGCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public JDBONLEIIML operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public LAEJFKLHDAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private KBEJLAHBIDN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x74FE5B0", Offset = "0x74FCFB0", VA = "0x1874FE5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x74FF120", Offset = "0x74FDB20", VA = "0x1874FF120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct FFNKOJIMCHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<KJKAGGHNJFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public LAEJFKLHDAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private GLAGHCHJEMO.GBAFAAODKGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private KBEJLAHBIDN <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x74EF680", Offset = "0x74EE080", VA = "0x1874EF680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x74EFBB0", Offset = "0x74EE5B0", VA = "0x1874EFBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class PFANMBEPNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public KJKAGGHNJFC operation;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PFANMBEPNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7504180", Offset = "0x7502B80", VA = "0x187504180")]
		internal object FGIJPIGNJLO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct HPDIFOLKCOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public KJKAGGHNJFC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public LAEJFKLHDAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private FILMNPNNHPJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x74F42B0", Offset = "0x74F2CB0", VA = "0x1874F42B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x74F48F0", Offset = "0x74F32F0", VA = "0x1874F48F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class MNNPGPPDMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MNNPGPPDMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x74FD670", Offset = "0x74FC070", VA = "0x1874FD670")]
		internal object MKEJBINAOLL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class LMHBANNBKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LMHBANNBKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x74FCCE0", Offset = "0x74FB6E0", VA = "0x1874FCCE0")]
		internal object EDOKDECMNON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private IGPBEMDEPGN IIDIIILHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private IOALELDLDFJ NCJNKANAMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private EKJOFOMEOLD JCALHDINLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<DOFMJKPJLKG> GLNCBNADJAF;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x74F9FE0", Offset = "0x74F89E0", VA = "0x1874F9FE0", Slot = "7")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x74F9C60", Offset = "0x74F8660", VA = "0x1874F9C60", Slot = "6")]
	[AsyncStateMachine(typeof(HONBPHFDHMA))]
	public Task<DOFMJKPJLKG> EDMAJJJCDOG(CancellationToken HLAJCDPELGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x74FA0D0", Offset = "0x74F8AD0", VA = "0x1874FA0D0", Slot = "4")]
	public void GMHENBJJOOM(JDBONLEIIML FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x74F97F0", Offset = "0x74F81F0", VA = "0x1874F97F0", Slot = "5")]
	public void AJIHOIBNPNN(JDBONLEIIML JMNLFKFHNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x74FA880", Offset = "0x74F9280", VA = "0x1874FA880")]
	[AsyncStateMachine(typeof(HDNEGFDHALL))]
	private Task JFNOPIBKAIN(JDBONLEIIML PGCEOMNLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x74F9B50", Offset = "0x74F8550", VA = "0x1874F9B50")]
	[AsyncStateMachine(typeof(NIHGMNGOGCG))]
	private Task DNMKPPEFGJE(JDBONLEIIML OPGPMIMMOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x74F9D70", Offset = "0x74F8770", VA = "0x1874F9D70")]
	[AsyncStateMachine(typeof(FFNKOJIMCHB))]
	private Task<KJKAGGHNJFC> ENMFFHBNBFG(JDBONLEIIML PGCEOMNLPAE, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x74FA460", Offset = "0x74F8E60", VA = "0x1874FA460")]
	private KBEJLAHBIDN IIPMJPNCAGG(JDBONLEIIML IACBCDAPDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x74F9EC0", Offset = "0x74F88C0", VA = "0x1874F9EC0")]
	[AsyncStateMachine(typeof(HPDIFOLKCOH))]
	private Task FABIDMIFEIC(KJKAGGHNJFC FAGENEAKFKC, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x74FA990", Offset = "0x74F9390", VA = "0x1874FA990")]
	private KJKAGGHNJFC MHJBAMKDFMB(JDBONLEIIML PGCEOMNLPAE, KBEJLAHBIDN LBEMCAHBNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FAADA0", Offset = "0x2FA97A0", VA = "0x182FAADA0")]
	private T KOEMBMFEKAB<T>(T PKCLPFEIPFH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x74FA4F0", Offset = "0x74F8EF0", VA = "0x1874FA4F0")]
	private KJKAGGHNJFC JAAFODJPIBK(JDBONLEIIML PGCEOMNLPAE, KBEJLAHBIDN LBEMCAHBNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public LAEJFKLHDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class OPMEELOJEEG : IOALELDLDFJ, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class EABEEDBBFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EABEEDBBFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x74EDA40", Offset = "0x74EC440", VA = "0x1874EDA40")]
		internal object LJCBMOBJAOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NAFKLJDBNMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NAFKLJDBNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x74FE540", Offset = "0x74FCF40", VA = "0x1874FE540")]
		internal object KPPFFGJFNOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private FDFLOOOBEGF IPMEMBNNJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private LIPLGMABIAE HPKIHFDGOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private FMLMHOJGBKM NBKPNKMOCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private EHDAEHMMJMI BLHFHKECOAL;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7500E20", Offset = "0x74FF820", VA = "0x187500E20", Slot = "6")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7500A70", Offset = "0x74FF470", VA = "0x187500A70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7501700", Offset = "0x7500100", VA = "0x187501700", Slot = "4")]
	public EPNHNLKELFB JEEEKOEPMHA(JDBONLEIIML PBNIEMAFBKN)
	{
		return default(EPNHNLKELFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7502010", Offset = "0x7500A10", VA = "0x187502010", Slot = "5")]
	public void PHMDHFHHPIE(Guid GGNKLHDGNDO, Task ICOJFKOPMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7500D50", Offset = "0x74FF750", VA = "0x187500D50")]
	private void EPMEPKIJHPC(byte HCEEEMIELAD, int NLOAIMAADNO, object NAFOOCJIEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7501190", Offset = "0x74FFB90", VA = "0x187501190")]
	private void IBAGNIPMILM(NNOAGEILLCM JEAABFEJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7500530", Offset = "0x74FEF30", VA = "0x187500530")]
	private void BEJFNPDMMLK(NNOAGEILLCM JEAABFEJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7500830", Offset = "0x74FF230", VA = "0x187500830")]
	private void CILHNPHAMDE(NNOAGEILLCM JEAABFEJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7500B20", Offset = "0x74FF520", VA = "0x187500B20")]
	private ICNNFOGCALN EAFAPOKGHEB(JDBONLEIIML IACBCDAPDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7500F90", Offset = "0x74FF990", VA = "0x187500F90")]
	private void GEGIAPFKDHF(JDBONLEIIML OPGPMIMMOBB, ICNNFOGCALN HDKFJJMEOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7500290", Offset = "0x74FEC90", VA = "0x187500290")]
	private bool ABHFMELOOCH(JDBONLEIIML OPGPMIMMOBB, ICNNFOGCALN HDKFJJMEOOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7501DA0", Offset = "0x75007A0", VA = "0x187501DA0")]
	private bool KGKELOBOLGA(JDBONLEIIML IJICMGMJOHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7501B20", Offset = "0x7500520", VA = "0x187501B20")]
	private bool JPPCCOAANKN(byte HCEEEMIELAD, ExitGames.Client.Photon.Hashtable JEAABFEJJGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public OPMEELOJEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class GPEPHLECPAI : BIAJFCCKFCN, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class GHOMJCHAMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public DOFMJKPJLKG operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public GPEPHLECPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public JDBONLEIIML roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GHOMJCHAMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x74F1D90", Offset = "0x74F0790", VA = "0x1874F1D90")]
		internal object EGGLIAJBFAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x74F1C60", Offset = "0x74F0660", VA = "0x1874F1C60")]
		internal object BNDEHBNIOID()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct GIPLHBDGPFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public GPEPHLECPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public JDBONLEIIML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<ICNNFOGCALN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x74F1E00", Offset = "0x74F0800", VA = "0x1874F1E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x74F24A0", Offset = "0x74F0EA0", VA = "0x1874F24A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class CABPHCCEFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public DOFMJKPJLKG operationType;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CABPHCCEFGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x74E9340", Offset = "0x74E7D40", VA = "0x1874E9340")]
		internal object NGMLFEBOFPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class BBHBKHIMDCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BBHBKHIMDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x74E8B50", Offset = "0x74E7550", VA = "0x1874E8B50")]
		internal object KECGJAFOIKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x74E8AE0", Offset = "0x74E74E0", VA = "0x1874E8AE0")]
		internal object BKFMACPGCDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x74E8A70", Offset = "0x74E7470", VA = "0x1874E8A70")]
		internal object ADANMGEFMOD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct JCHGPDKGFDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public GPEPHLECPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private BBHBKHIMDCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private EPNHNLKELFB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private ICNNFOGCALN <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(ICNNFOGCALN validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x74F67C0", Offset = "0x74F51C0", VA = "0x1874F67C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x74F7090", Offset = "0x74F5A90", VA = "0x1874F7090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private FDFLOOOBEGF IPMEMBNNJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private IOALELDLDFJ NCJNKANAMGG;

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x74F2960", Offset = "0x74F1360", VA = "0x1874F2960", Slot = "5")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x74F2650", Offset = "0x74F1050", VA = "0x1874F2650", Slot = "4")]
	[AsyncStateMachine(typeof(GIPLHBDGPFE))]
	private Task<ICNNFOGCALN> DGHKIEAKNFG(JDBONLEIIML IACBCDAPDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x74F2770", Offset = "0x74F1170", VA = "0x1874F2770")]
	private bool DOPKMAGFEAC(DOFMJKPJLKG MCFACOPHFFE, [Out] ICNNFOGCALN KIBAOEBFCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x74F2510", Offset = "0x74F0F10", VA = "0x1874F2510")]
	[AsyncStateMachine(typeof(JCHGPDKGFDA))]
	private Task<ICNNFOGCALN> BCAKCACCMMK(JDBONLEIIML PGCEOMNLPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GPEPHLECPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class ENDJPAIDBKB : BGKNBPLJCOM, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct AEBIJHAJBHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<CMBGKEDMCPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public ENDJPAIDBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<IJINIJPNMHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<CMBGKEDMCPG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x74E66F0", Offset = "0x74E50F0", VA = "0x1874E66F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x74E6CC0", Offset = "0x74E56C0", VA = "0x1874E6CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class AILIALFPDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AILIALFPDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x74E72B0", Offset = "0x74E5CB0", VA = "0x1874E72B0")]
		internal object GBJNEEKJEGJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct DIJBPLEBFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<IJINIJPNMHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public ENDJPAIDBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private AILIALFPDJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<IJINIJPNMHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x74ECA60", Offset = "0x74EB460", VA = "0x1874ECA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x74ED050", Offset = "0x74EBA50", VA = "0x1874ED050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct GBHHJFEPPIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<CMBGKEDMCPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ENDJPAIDBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public IJINIJPNMHJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<(OAGGCGDDFAC superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x74F1790", Offset = "0x74F0190", VA = "0x1874F1790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x74F1BF0", Offset = "0x74F05F0", VA = "0x1874F1BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class HJDMKAFIEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HJDMKAFIEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CD10", Offset = "0xA0B710", VA = "0x180A0CD10")]
		internal bool LPBBKMCEPNA(EFEKMJJDMGI sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct ONNMCJFJMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<(OAGGCGDDFAC superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public IJINIJPNMHJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public ENDJPAIDBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public OABHCPGEKDA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<(OAGGCGDDFAC superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x74FFB80", Offset = "0x74FE580", VA = "0x1874FFB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7500220", Offset = "0x74FEC20", VA = "0x187500220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class EGFLILFOCBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EGFLILFOCBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x74EE440", Offset = "0x74ECE40", VA = "0x1874EE440")]
		internal object CHFMLKGILIN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct KDMLMHIHAKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<(OAGGCGDDFAC superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public EFEKMJJDMGI subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public ENDJPAIDBKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public OABHCPGEKDA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private EGFLILFOCBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<PDGFGDEMNEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x74F8FF0", Offset = "0x74F79F0", VA = "0x1874F8FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x74F9720", Offset = "0x74F8120", VA = "0x1874F9720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly (OAGGCGDDFAC superRoomData, long subRoomDataSaveId) IIPCILDOOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private JHDOIICAKMG IKFIPKNPGAA;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x74EE820", Offset = "0x74ED220", VA = "0x1874EE820", Slot = "5")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x74EE6C0", Offset = "0x74ED0C0", VA = "0x1874EE6C0", Slot = "4")]
	[AsyncStateMachine(typeof(AEBIJHAJBHE))]
	public Task<CMBGKEDMCPG> FCFGFHBGNFF(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, OABHCPGEKDA LHCPGGNLCPO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x74EE8B0", Offset = "0x74ED2B0", VA = "0x1874EE8B0")]
	[AsyncStateMachine(typeof(DIJBPLEBFBD))]
	private Task<IJINIJPNMHJ> IMOBKHALKPL(OABHCPGEKDA LHCPGGNLCPO, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x74EEA10", Offset = "0x74ED410", VA = "0x1874EEA10")]
	[AsyncStateMachine(typeof(GBHHJFEPPIE))]
	private Task<CMBGKEDMCPG> MNLHGKBLCHE(OABHCPGEKDA LHCPGGNLCPO, IJINIJPNMHJ ENLBBOBGKGH, long OKPAMGANILI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x74EEB80", Offset = "0x74ED580", VA = "0x1874EEB80")]
	[AsyncStateMachine(typeof(ONNMCJFJMDI))]
	private Task<(OAGGCGDDFAC, long)> NBOENBDBMOA(OABHCPGEKDA LHCPGGNLCPO, IJINIJPNMHJ ENLBBOBGKGH, long OKPAMGANILI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x74EE550", Offset = "0x74ECF50", VA = "0x1874EE550")]
	[AsyncStateMachine(typeof(KDMLMHIHAKI))]
	private Task<(OAGGCGDDFAC, long)> BHNFEDDPBEJ(OABHCPGEKDA DJAEGJFIKDH, EFEKMJJDMGI FDBKAGKKILF, long OKPAMGANILI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public ENDJPAIDBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class FKPFEPEDBOA : EKJOFOMEOLD, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class BJCPDAEOLJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BJCPDAEOLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x74E8D10", Offset = "0x74E7710", VA = "0x1874E8D10")]
		internal object LGPNMMDNJBA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct NNMLEANGGLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public FKPFEPEDBOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public KBEJLAHBIDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x74FF180", Offset = "0x74FDB80", VA = "0x1874FF180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x74FF790", Offset = "0x74FE190", VA = "0x1874FF790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct JLBNPGCNDEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public FKPFEPEDBOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public KBEJLAHBIDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<PKOFFEJGNCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x74F8350", Offset = "0x74F6D50", VA = "0x1874F8350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x74F8940", Offset = "0x74F7340", VA = "0x1874F8940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class BMECBPNGPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BMECBPNGPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x74E8D70", Offset = "0x74E7770", VA = "0x1874E8D70")]
		internal object NBKAJFHELHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct LLGAFNGFHMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public JDBONLEIIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public FKPFEPEDBOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public KBEJLAHBIDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private DGMDPGGICDB <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private AMDAGACNFIC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<PKOFFEJGNCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x74FC080", Offset = "0x74FAA80", VA = "0x1874FC080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x74FCC70", Offset = "0x74FB670", VA = "0x1874FCC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private MFAGGGGAHJC BOHJLGDFHNG;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private LBJBADDKLDA GALDJJCLJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x74EFF30", Offset = "0x74EE930", VA = "0x1874EFF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x74EFEA0", Offset = "0x74EE8A0", VA = "0x1874EFEA0", Slot = "8")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x74EFD40", Offset = "0x74EE740", VA = "0x1874EFD40", Slot = "4")]
	[AsyncStateMachine(typeof(NNMLEANGGLN))]
	public Task<JDBONLEIIML> DICMKLJDDHK(JDBONLEIIML PGCEOMNLPAE, KBEJLAHBIDN LBEMCAHBNHB, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x74EFFF0", Offset = "0x74EE9F0", VA = "0x1874EFFF0", Slot = "5")]
	[AsyncStateMachine(typeof(JLBNPGCNDEE))]
	public Task<JDBONLEIIML> ILIJLGDLKEF(CancellationToken PPLDCJFFMEP, KBEJLAHBIDN LBEMCAHBNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x74EFC90", Offset = "0x74EE690", VA = "0x1874EFC90", Slot = "6")]
	public CEFBPLBIKCE CAKGGGNMECD(KJKAGGHNJFC DOGIDIDNGGA, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x74F02A0", Offset = "0x74EECA0", VA = "0x1874F02A0", Slot = "7")]
	public CEFBPLBIKCE PIGGELNBEJJ(KJKAGGHNJFC DOGIDIDNGGA, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x74F0140", Offset = "0x74EEB40", VA = "0x1874F0140")]
	[AsyncStateMachine(typeof(LLGAFNGFHMK))]
	private Task<JDBONLEIIML> OFBJHACEOEG(JDBONLEIIML PGCEOMNLPAE, KBEJLAHBIDN LBEMCAHBNHB, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8010", Offset = "0x2CE6A10", VA = "0x182CE8010")]
	private static byte[] ELMMIIALBBG(JDBONLEIIML FCMDIEEAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public FKPFEPEDBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class JOLFBDPNDBB : FDFLOOOBEGF, BGABJPPAMJK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private GHMLDOKPIEJ LECPPJMHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private IGPBEMDEPGN IIDIIILHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private DDKLCJFENGE KEEAHJFOMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private NPKEPDCOMBP NMEFFLKAPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private LOHPJEPNHKG CLNLGBEAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private GLMJNFIMHHJ BLHPPLPBDDE;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x74F8B20", Offset = "0x74F7520", VA = "0x1874F8B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private static ICNNFOGCALN JOODNDOEDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x74E6DB0", Offset = "0x74E57B0", VA = "0x1874E6DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x74F8B70", Offset = "0x74F7570", VA = "0x1874F8B70", Slot = "6")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x74F89B0", Offset = "0x74F73B0", VA = "0x1874F89B0", Slot = "4")]
	public ICNNFOGCALN ADCDFJCKIGE(OGOAPNICIIH MFEKEOGJGAE, DOFMJKPJLKG ILCOEDDFLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x74F8CE0", Offset = "0x74F76E0", VA = "0x1874F8CE0", Slot = "5")]
	public ICNNFOGCALN MHEGCPLNGFK(OGOAPNICIIH NFFJINNFCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x74E6D50", Offset = "0x74E5750", VA = "0x1874E6D50")]
	private static ICNNFOGCALN BEOFJLAPNJD(LDJHPKBNKJN OMJKCNAHEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JOLFBDPNDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class FEKFBPFDEMM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x74EF0D0", Offset = "0x74EDAD0", VA = "0x1874EF0D0")]
	public FEKFBPFDEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x68F6B70", Offset = "0x68F5570", VA = "0x1868F6B70")]
	public FEKFBPFDEMM(string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class JIMAOOJDMFM : OMEBFBKKFLB, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct CGBFFNJPGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public HODNKPFLLHK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private FILMNPNNHPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KGKJJOLNAOA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<ICNNFOGCALN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x74E94B0", Offset = "0x74E7EB0", VA = "0x1874E94B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x74EA040", Offset = "0x74E8A40", VA = "0x1874EA040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LKMBKGIKLPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x74FB880", Offset = "0x74FA280", VA = "0x1874FB880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x74FBFC0", Offset = "0x74FA9C0", VA = "0x1874FBFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct FELJGECGKNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x74EF110", Offset = "0x74EDB10", VA = "0x1874EF110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x74EF620", Offset = "0x74EE020", VA = "0x1874EF620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct IKPNMNGHPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x74F5FE0", Offset = "0x74F49E0", VA = "0x1874F5FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x74F6720", Offset = "0x74F5120", VA = "0x1874F6720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct GAHBBEGPAKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x74F1590", Offset = "0x74EFF90", VA = "0x1874F1590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x74F1730", Offset = "0x74F0130", VA = "0x1874F1730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct PCIPAMONIPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7503A10", Offset = "0x7502410", VA = "0x187503A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7504120", Offset = "0x7502B20", VA = "0x187504120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct LHFLJEPHNLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x74FB3B0", Offset = "0x74F9DB0", VA = "0x1874FB3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x74FB820", Offset = "0x74FA220", VA = "0x1874FB820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct ABAMJNJKDGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public JIMAOOJDMFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public BAKCOMBJMKD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private FILMNPNNHPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x74E5F60", Offset = "0x74E4960", VA = "0x1874E5F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x74E64C0", Offset = "0x74E4EC0", VA = "0x1874E64C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private AFIFLHJBILJ PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private EKJOFOMEOLD JCALHDINLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private IGPBEMDEPGN IIDIIILHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private LOHPJEPNHKG CLNLGBEAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CancellationTokenSource JINPODPBBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private Task NFNLFCIOMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private TaskCompletionSource<int> ELFBNLJEKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private int KBAMLGBJHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private int GEKLLNFGLPK;

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x74F7520", Offset = "0x74F5F20", VA = "0x1874F7520", Slot = "6")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xDCCEA0", Offset = "0xDCB8A0", VA = "0x180DCCEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x74F7440", Offset = "0x74F5E40", VA = "0x1874F7440")]
	private void DIIMHNNNBMC(float PMMOEFKIIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x74F78B0", Offset = "0x74F62B0", VA = "0x1874F78B0", Slot = "4")]
	[AsyncStateMachine(typeof(CGBFFNJPGBG))]
	public Task<ICNNFOGCALN> GPMKFFHNCMJ(HODNKPFLLHK JCEPEPKPAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x74F7CE0", Offset = "0x74F66E0", VA = "0x1874F7CE0", Slot = "5")]
	[AsyncStateMachine(typeof(LKMBKGIKLPG))]
	public Task KNPKIEFKKGC([Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xDCCEA0", Offset = "0xDCB8A0", VA = "0x180DCCEA0")]
	public void JGKKEJOJMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x74F7B70", Offset = "0x74F6570", VA = "0x1874F7B70")]
	private KGKJJOLNAOA IIFMDCNBFOE(HODNKPFLLHK JCEPEPKPAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x74F8160", Offset = "0x74F6B60", VA = "0x1874F8160")]
	[AsyncStateMachine(typeof(FELJGECGKNN))]
	private Task MPOINGOEHBE(CancellationToken AGFJCKJDLDL, int HKKBIOOJIGP, AMGEEFGMLAH BEDLHLEJBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x74F7340", Offset = "0x74F5D40", VA = "0x1874F7340")]
	[AsyncStateMachine(typeof(IKPNMNGHPMI))]
	private Task ABBFENGODNC(CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x74F77C0", Offset = "0x74F61C0", VA = "0x1874F77C0")]
	[AsyncStateMachine(typeof(GAHBBEGPAKA))]
	private Task GJACIDDDKCG([Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x74F76D0", Offset = "0x74F60D0", VA = "0x1874F76D0")]
	[AsyncStateMachine(typeof(PCIPAMONIPI))]
	private Task GEDFOILPNKC(CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x74F8250", Offset = "0x74F6C50", VA = "0x1874F8250")]
	[AsyncStateMachine(typeof(LHFLJEPHNLI))]
	private Task PNMNACFGJJC(CancellationToken PMPDBEJNJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x74F79E0", Offset = "0x74F63E0", VA = "0x1874F79E0")]
	private Task HEMOKMGCGHG(BAKCOMBJMKD NACGOOKCKAA, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x74F7DD0", Offset = "0x74F67D0", VA = "0x1874F7DD0")]
	[AsyncStateMachine(typeof(ABAMJNJKDGB))]
	private Task MLCLJCOBNOE(BAKCOMBJMKD NACGOOKCKAA, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x74F7EE0", Offset = "0x74F68E0", VA = "0x1874F7EE0")]
	private bool MMNBJCNMALP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JIMAOOJDMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class HJALPIJBNNF : DDKLCJFENGE, BGABJPPAMJK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct DCHNOEKIOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public HJALPIJBNNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private FILMNPNNHPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x74EB2A0", Offset = "0x74E9CA0", VA = "0x1874EB2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x74EB810", Offset = "0x74EA210", VA = "0x1874EB810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private DBGOGJCAPOP EHBONKLPEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private FDFLOOOBEGF IPMEMBNNJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private EKJOFOMEOLD JCALHDINLHE;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x74F3B10", Offset = "0x74F2510", VA = "0x1874F3B10", Slot = "6")]
	public void GCHKJEOLKFE(FBPDAHOOPKF GDNLGDEFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x74F3AC0", Offset = "0x74F24C0", VA = "0x1874F3AC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x74F3E50", Offset = "0x74F2850", VA = "0x1874F3E50", Slot = "5")]
	[AsyncStateMachine(typeof(DCHNOEKIOCG))]
	public Task PINODNCJKPK(string MHHANLDHFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x74F3DF0", Offset = "0x74F27F0", VA = "0x1874F3DF0", Slot = "4")]
	public ICNNFOGCALN MMNBJCNMALP(OGOAPNICIIH MFEKEOGJGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x74F39D0", Offset = "0x74F23D0", VA = "0x1874F39D0")]
	private OHIAEGMOGNH DPGEKDMPOOP(string MHHANLDHFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public HJALPIJBNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class LNBKHAOEKOL
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x74FD270", Offset = "0x74FBC70", VA = "0x1874FD270")]
	public static void MCFLDDMCNHA(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x74FD4B0", Offset = "0x74FBEB0", VA = "0x1874FD4B0")]
	internal static void NMGHILKOMJA(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x74FCD40", Offset = "0x74FB740", VA = "0x1874FCD40")]
	internal static void EBODLFGJNLE(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x74FCE20", Offset = "0x74FB820", VA = "0x1874FCE20")]
	internal static void FGGIABELDNF(KNPHAFHLPCE DNJEODDCEHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class EDBCBLMCEGP : EAEHOCDKPBG<JDBONLEIIML>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class GPIKCBNEGEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public JDBONLEIIML message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GPIKCBNEGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x74F2A10", Offset = "0x74F1410", VA = "0x1874F2A10")]
		internal object MMAMOMKEIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly EDBCBLMCEGP JOLICDCBKGF;

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x74EDE90", Offset = "0x74EC890", VA = "0x1874EDE90")]
	public ExitGames.Client.Photon.Hashtable HLGBFIEHJDG(JDBONLEIIML FCMDIEEAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x74EDD60", Offset = "0x74EC760", VA = "0x1874EDD60", Slot = "5")]
	protected override void GNFENHJIHBP(JDBONLEIIML FCMDIEEAPHD, IDictionary<object, object> GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x74EDB30", Offset = "0x74EC530", VA = "0x1874EDB30", Slot = "6")]
	public override JDBONLEIIML DLDAMIHNNNK(IDictionary<object, object> GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x74EE1C0", Offset = "0x74ECBC0", VA = "0x1874EE1C0")]
	private static void PMAPEFGPDFK(string IEFJIAFNCKH, JDBONLEIIML FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x74EE360", Offset = "0x74ECD60", VA = "0x1874EE360")]
	public EDBCBLMCEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x74EDF20", Offset = "0x74EC920", VA = "0x1874EDF20")]
	[CompilerGenerated]
	internal static string PBHEDKPGJEH(CMBGKEDMCPG ELHNCLABHAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class AHABOBMNFIF
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public static ICNNFOGCALN JOODNDOEDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x74E6DB0", Offset = "0x74E57B0", VA = "0x1874E6DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x74E6D30", Offset = "0x74E5730", VA = "0x1874E6D30")]
	public static bool ALGILKFKMEG(this ICNNFOGCALN HDKFJJMEOOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x74E6D50", Offset = "0x74E5750", VA = "0x1874E6D50")]
	public static ICNNFOGCALN BEOFJLAPNJD(LDJHPKBNKJN IBCIMOMCIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x74E6E10", Offset = "0x74E5810", VA = "0x1874E6E10")]
	public static ICNNFOGCALN GHPAOOBAFHC(IEnumerable<ICNNFOGCALN> OKIMDDHKBFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x74E7000", Offset = "0x74E5A00", VA = "0x1874E7000")]
	public static string LGNGGBKHKPN(this ICNNFOGCALN KIBAOEBFCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class BPLJDAAHOGG : BNIGADOOPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate ICNNFOGCALN HPDOENODODH([NotNull] OGOAPNICIIH FONFDDLBDFO);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class HHEJHPEHPGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public OGOAPNICIIH photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HHEJHPEHPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C5A0", Offset = "0x6B0AFA0", VA = "0x186B0C5A0")]
		internal ICNNFOGCALN KOHONODMJCD(HPDOENODODH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	protected readonly HashSet<HPDOENODODH> ILFPFLJJDOF;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x74E8F10", Offset = "0x74E7910", VA = "0x1874E8F10", Slot = "4")]
	public void BGBPBKIGGDM(HPDOENODODH CLBBFKJOOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x74E9250", Offset = "0x74E7C50", VA = "0x1874E9250", Slot = "5")]
	public void LAKBJAOOHJC(HPDOENODODH CLBBFKJOOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x74E8F70", Offset = "0x74E7970", VA = "0x1874E8F70", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x74E8FC0", Offset = "0x74E79C0", VA = "0x1874E8FC0")]
	protected ICNNFOGCALN KBEBHJOPAPK(OGOAPNICIIH NFFJINNFCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x74E92B0", Offset = "0x74E7CB0", VA = "0x1874E92B0")]
	protected BPLJDAAHOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class FNOENHCLIEA : BPLJDAAHOGG, GHMLDOKPIEJ, BNIGADOOPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class HKEDLEMJJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public ICNNFOGCALN result;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HKEDLEMJJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x74F3F50", Offset = "0x74F2950", VA = "0x1874F3F50")]
		internal object APMJBBONPOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x74ED230", Offset = "0x74EBC30", VA = "0x1874ED230")]
	[UnityEngine.Scripting.Preserve]
	public FNOENHCLIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x74F03E0", Offset = "0x74EEDE0", VA = "0x1874F03E0", Slot = "8")]
	public ICNNFOGCALN JPDECCCHOBH(OGOAPNICIIH NFFJINNFCGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class DJLMOBLDLCE : BPLJDAAHOGG, DBGOGJCAPOP, BNIGADOOPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class CIOMOCBOAMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public ICNNFOGCALN result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CIOMOCBOAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x74EA0B0", Offset = "0x74E8AB0", VA = "0x1874EA0B0")]
		internal object PDJFDAKOCPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x74ED230", Offset = "0x74EBC30", VA = "0x1874ED230")]
	[UnityEngine.Scripting.Preserve]
	public DJLMOBLDLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x74ED120", Offset = "0x74EBB20", VA = "0x1874ED120", Slot = "8")]
	public ICNNFOGCALN MMNBJCNMALP(OGOAPNICIIH CKKFCDKPFAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class DNAECDECIDP
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class DOKLIMHACDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public FILMNPNNHPJ<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DOKLIMHACDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x74ED960", Offset = "0x74EC360", VA = "0x1874ED960")]
		internal object JFHPFJKJMBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x74ED700", Offset = "0x74EC100", VA = "0x1874ED700")]
	public static FILMNPNNHPJ<string> GIDKCCHMDNJ(KLEHBGEJMBN DAKGLLFOGCM, [Optional] string EJHFDGLHAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x74ED8A0", Offset = "0x74EC2A0", VA = "0x1874ED8A0")]
	public static void KCNHKENFPFL(FILMNPNNHPJ<string> PILOCADBFFI, KLEHBGEJMBN DAKGLLFOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x74ED7E0", Offset = "0x74EC1E0", VA = "0x1874ED7E0")]
	public static string IKDOALCHCOF(JDBONLEIIML IACBCDAPDHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class BNBLIPJAHPE
{
	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x74E8F00", Offset = "0x74E7900", VA = "0x1874E8F00")]
	public static void KGCGCPFFCFN(this AFIFLHJBILJ PPPAPIDLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x74E8EF0", Offset = "0x74E78F0", VA = "0x1874E8EF0")]
	public static void GDFMCHHMNPM(this AFIFLHJBILJ PPPAPIDLOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x74E8DD0", Offset = "0x74E77D0", VA = "0x1874E8DD0")]
	private static void EFGDHIGJGNM(this AFIFLHJBILJ PPPAPIDLOLG, bool HFIMCDCIIDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class LDOIBGCFMBL : BGGANJJONKE, GEKPEGFEAND, NMAOFHHAHIH, NCBDKMOODGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly GEKPEGFEAND GILHKJGCJFC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public OGOAPNICIIH LPMJBEMNAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x74FB0A0", Offset = "0x74F9AA0", VA = "0x1874FB0A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int MHLODLBBMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x74FAFB0", Offset = "0x74F99B0", VA = "0x1874FAFB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int POBAANODKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x74FABA0", Offset = "0x74F95A0", VA = "0x1874FABA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool AMMJCMAEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int DJEIHKPGLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x941F40", Offset = "0x940940", VA = "0x180941F40", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event DAFFNGOPPNB.OBFEHNFPOGL JCGPJHFLCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event DKLCPBLAGNA LPCJAMJICJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x74FAE30", Offset = "0x74F9830", VA = "0x1874FAE30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x74FABF0", Offset = "0x74F95F0", VA = "0x1874FABF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> LAIFEEKLHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<OGOAPNICIIH> PLCEADIDHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action DGHEPJKKOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x74FAD40", Offset = "0x74F9740", VA = "0x1874FAD40", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x74FB000", Offset = "0x74F9A00", VA = "0x1874FB000", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xD9BDD0", Offset = "0xD9A7D0", VA = "0x180D9BDD0")]
	public LDOIBGCFMBL(GEKPEGFEAND GILHKJGCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x74FAC90", Offset = "0x74F9690", VA = "0x1874FAC90", Slot = "8")]
	public bool HPJNFEIFLPB(byte HCEEEMIELAD, ExitGames.Client.Photon.Hashtable EILJAPHFJCE, JNFIDICLOBG EKMFNDHFFKL, SendOptions JBIDPMAMIFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x74FAED0", Offset = "0x74F98D0", VA = "0x1874FAED0", Slot = "16")]
	public OGOAPNICIIH JDGGDDLNMJD(int KGOMJEMDBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "19")]
	public void KAJJEJFIIIF(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "20")]
	public void HLBIBDJEJAD(object AICEIDIHFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "21")]
	public void AGACFBNGBIK(object AICEIDIHFDO, bool BMFFIAMNJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x74FADE0", Offset = "0x74F97E0", VA = "0x1874FADE0", Slot = "22")]
	public IDisposable IOJPJFFKDGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "23")]
	private bool BOGGANOILIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "24")]
	public void CJIJONPBDNA(StringBuilder AANHGECCPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xAED2F0", Offset = "0xAEBCF0", VA = "0x180AED2F0", Slot = "25")]
	public bool MOHPDAIKCKA(bool BKPEKDIKMPM, [Out] string BHAOKKINJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xA0ECD0", Offset = "0xA0D6D0", VA = "0x180A0ECD0", Slot = "28")]
	public void NPIBNNHHAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct NNOAGEILLCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly IDictionary<object, object> JEAABFEJJGG;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	public NNOAGEILLCM(IDictionary<object, object> JEAABFEJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x74FF800", Offset = "0x74FE200", VA = "0x1874FF800")]
	public bool BIKEDLIBNDJ([Out] JDBONLEIIML FCMDIEEAPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x74FF9A0", Offset = "0x74FE3A0", VA = "0x1874FF9A0")]
	public Guid MNLDKOPNOKB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x74FFA50", Offset = "0x74FE450", VA = "0x1874FFA50")]
	public ICNNFOGCALN PHCGHAFGIEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x74FF8B0", Offset = "0x74FE2B0", VA = "0x1874FF8B0")]
	public static ExitGames.Client.Photon.Hashtable LNCAGMGJJFK(JDBONLEIIML FCMDIEEAPHD, ICNNFOGCALN HDKFJJMEOOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class ECNBGDHLICO
{
	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x74EDAB0", Offset = "0x74EC4B0", VA = "0x1874EDAB0")]
	public static bool KKAFHPMAPAJ(this OABHCPGEKDA BOLIKBEKJMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct LEEBKNONMND : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct JEJLBACDPNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public LEEBKNONMND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x74F7100", Offset = "0x74F5B00", VA = "0x1874F7100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x74F72E0", Offset = "0x74F5CE0", VA = "0x1874F72E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly CancellationTokenSource KPJNJINNMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private Task LPAAFOGOHKE;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MCOKBKCIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x74FB0F0", Offset = "0x74F9AF0", VA = "0x1874FB0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x74FB280", Offset = "0x74F9C80", VA = "0x1874FB280")]
	public LEEBKNONMND(CancellationToken PPLDCJFFMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x74FB170", Offset = "0x74F9B70", VA = "0x1874FB170")]
	[AsyncStateMachine(typeof(JEJLBACDPNJ))]
	public Task JGPLPBOOOBJ(Func<CancellationToken, List<Task>> JBEABAHCPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x74FB120", Offset = "0x74F9B20", VA = "0x1874FB120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct CKKDGGGLGCC<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct KMLADLFLDIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<EIIKFAFHFIO<TData>, JMDMKJMGBCA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CKKDGGGLGCC<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<OKPKCEBGDLD<EIIKFAFHFIO<TData>, JMDMKJMGBCA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x45666B0", Offset = "0x45650B0", VA = "0x1845666B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x40B1F90", Offset = "0x40B0990", VA = "0x1840B1F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly BIOBOKHFEHE<TGetDataArg, TData> HMOBFPGDOND;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	internal CKKDGGGLGCC(BIOBOKHFEHE<TGetDataArg, TData> JOIGIEDFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x560E980", Offset = "0x560D380", VA = "0x18560E980")]
	[AsyncStateMachine(typeof(CKKDGGGLGCC<, >.KMLADLFLDIG))]
	public Task<OKPKCEBGDLD<EIIKFAFHFIO<TData>, JMDMKJMGBCA>> IFEPBEIMOAO(TGetDataArg BCHPPGPOGNC, string DGCPNIEANGA, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class HIABEBIDDLL
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A2C0", Offset = "0x2D28CC0", VA = "0x182D2A2C0")]
	public static CKKDGGGLGCC<TGetDataArg, TData> AELHPDENENI<TGetDataArg, TData>(BIOBOKHFEHE<TGetDataArg, TData> JOIGIEDFOGO)
	{
		return default(CKKDGGGLGCC<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct FDMGJGCOOAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly int AKHABMINPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly int? PMKAHEPAKNF;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x46496A0", Offset = "0x46480A0", VA = "0x1846496A0")]
	public FDMGJGCOOAA(int LNMOKLDMMAH, [Optional] int? PIAJOJBIAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x74EEFF0", Offset = "0x74ED9F0", VA = "0x1874EEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface FJCFPBNMNLE<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOFEPPMKJLJ();

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJCFPBNMNLE<T> MNKFPGOLMAG(string HEJCCGDENJJ);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJCFPBNMNLE<T> IPEHGKAKINF(ABGBCGNEBPG<T> FFBFNFFNIMM);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FJCFPBNMNLE<T> KPOMJHKLKAL(int IJKGJPCAEHK);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJCFPBNMNLE<T> AOKDIMHAFKL(int IJKGJPCAEHK, OPAHONEFEKL<T> JKAALLIJCKN);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface NHLHBFNNCBA
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJCFPBNMNLE<T> CCHKKKKPNKB<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BILKLPGEBOL OLINDHIEKNG(Exception AENFONOHPNM);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FDMGJGCOOAA AFINMAHAEAJ(Exception AENFONOHPNM);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string ABGBCGNEBPG<in T>(T AENFONOHPNM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int OPAHONEFEKL<in T>(T AENFONOHPNM) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class AKMJFDLHPJA : NHLHBFNNCBA
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string KLLLFBAADAC(Exception AENFONOHPNM);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int JOPJMKPEFMO(Exception AENFONOHPNM);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class HDLDCFMBEJB<T> : FJCFPBNMNLE<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class MOKJLHJFEKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public MOKJLHJFEKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			internal string JPNNOJNPHIL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class CNBAIPIFEON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ABGBCGNEBPG<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public CNBAIPIFEON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x424BFB0", Offset = "0x424A9B0", VA = "0x18424BFB0")]
			internal string FAFFDHGENCJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class IHICKNGBIMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public OPAHONEFEKL<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public IHICKNGBIMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x424BFB0", Offset = "0x424A9B0", VA = "0x18424BFB0")]
			internal int FGCHHMKALJK(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly AKMJFDLHPJA CANPPHMHKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly Type NCOHIIOLOFF;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x4176E20", Offset = "0x4175820", VA = "0x184176E20")]
		internal HDLDCFMBEJB(AKMJFDLHPJA CANPPHMHKPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4176C90", Offset = "0x4175690", VA = "0x184176C90", Slot = "4")]
		public void JOFEPPMKJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x4176D00", Offset = "0x4175700", VA = "0x184176D00", Slot = "5")]
		public FJCFPBNMNLE<T> MNKFPGOLMAG(string HEJCCGDENJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x4176B70", Offset = "0x4175570", VA = "0x184176B70", Slot = "6")]
		public FJCFPBNMNLE<T> IPEHGKAKINF(ABGBCGNEBPG<T> FFBFNFFNIMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x4176CC0", Offset = "0x41756C0", VA = "0x184176CC0", Slot = "7")]
		public FJCFPBNMNLE<T> KPOMJHKLKAL(int IJKGJPCAEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x4176A30", Offset = "0x4175430", VA = "0x184176A30", Slot = "8")]
		public FJCFPBNMNLE<T> AOKDIMHAFKL(int IJKGJPCAEHK, OPAHONEFEKL<T> JKAALLIJCKN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class NPIBEHOOOBI<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private bool HMAMCHIBELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly List<Type> FFJPKPHMAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Dictionary<Type, TVal> GHHPCEGCKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Dictionary<Type, int> FGNLELLKPKD;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public IReadOnlyList<Type> IPLIGBDFKIN
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x496D990", Offset = "0x496C390", VA = "0x18496D990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x496DC30", Offset = "0x496C630", VA = "0x18496DC30")]
		public NPIBEHOOOBI(Dictionary<Type, int> FGNLELLKPKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x496DB10", Offset = "0x496C510", VA = "0x18496DB10")]
		public void NOEGDDICEDP(Type PNABAFEIDND, TVal JBKDPHAINMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x496DBD0", Offset = "0x496C5D0", VA = "0x18496DBD0")]
		public bool PNFFCEMJAJK(Type NCOHIIOLOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x496D870", Offset = "0x496C270", VA = "0x18496D870")]
		public bool JCEGJEJOMAE(TVal PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x40D53C0", Offset = "0x40D3DC0", VA = "0x1840D53C0")]
		public TVal KJCABELIABF(Type BKKHBFLPOHJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x496D7D0", Offset = "0x496C1D0", VA = "0x18496D7D0")]
		[CompilerGenerated]
		private int FJIEECHBJJI(Type FGLFNPEDBIN, Type DALCOANFPLH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class PBHMPMIDFEN : IEnumerable<FDMGJGCOOAA>, IEnumerable, IEnumerator<FDMGJGCOOAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private FDMGJGCOOAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AKMJFDLHPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private IEnumerator<FDMGJGCOOAA> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private FDMGJGCOOAA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x3BFE7E0", Offset = "0x3BFD1E0", VA = "0x183BFE7E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FDMGJGCOOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x7502880", Offset = "0x7501280", VA = "0x187502880", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public PBHMPMIDFEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x75028D0", Offset = "0x75012D0", VA = "0x1875028D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7502270", Offset = "0x7500C70", VA = "0x187502270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x7502220", Offset = "0x7500C20", VA = "0x187502220")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7502720", Offset = "0x7501120", VA = "0x187502720")]
		private void OKCPBNJHCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7502830", Offset = "0x7501230", VA = "0x187502830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7502770", Offset = "0x7501170", VA = "0x187502770", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FDMGJGCOOAA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7502770", Offset = "0x7501170", VA = "0x187502770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly FDMGJGCOOAA HCABELHINLE;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private static readonly Dictionary<Type, int> CFDBFEOGMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HashSet<Type> OJDNAHNOFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly NPIBEHOOOBI<int> NGDELDJACGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly NPIBEHOOOBI<JOPJMKPEFMO> NOJNLKAAPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly NPIBEHOOOBI<KLLLFBAADAC> KCAIFNNOFFD;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x74E8280", Offset = "0x74E6C80", VA = "0x1874E8280")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	internal static void DJJNDGGBFEG(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x74E8740", Offset = "0x74E7140", VA = "0x1874E8740")]
	[RecRoom.NoEngine.Common.Preserve]
	public AKMJFDLHPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660", Slot = "4")]
	public FJCFPBNMNLE<T> CCHKKKKPNKB<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x74E85F0", Offset = "0x74E6FF0", VA = "0x1874E85F0", Slot = "5")]
	public BILKLPGEBOL OLINDHIEKNG(Exception AENFONOHPNM)
	{
		return default(BILKLPGEBOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x74E7660", Offset = "0x74E6060", VA = "0x1874E7660", Slot = "6")]
	public FDMGJGCOOAA AFINMAHAEAJ(Exception? AENFONOHPNM)
	{
		return default(FDMGJGCOOAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x74E82F0", Offset = "0x74E6CF0", VA = "0x1874E82F0", Slot = "7")]
	[IteratorStateMachine(typeof(PBHMPMIDFEN))]
	public IEnumerable<FDMGJGCOOAA> GFNOLAIHFHI(Exception AENFONOHPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x74E7860", Offset = "0x74E6260", VA = "0x1874E7860", Slot = "8")]
	public string AGBLAHNIGLI(Exception? AENFONOHPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x74E7360", Offset = "0x74E5D60", VA = "0x1874E7360")]
	private string AENMPBPMDKC(AggregateException PFOCCMDIECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x74E7ED0", Offset = "0x74E68D0", VA = "0x1874E7ED0")]
	private void DENAICBECHG(Type NCOHIIOLOFF, int IJKGJPCAEHK, JOPJMKPEFMO? CFGNNOFELMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x74E79B0", Offset = "0x74E63B0", VA = "0x1874E79B0")]
	private void CECEMCJBPAO(Type NCOHIIOLOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x74E7C00", Offset = "0x74E6600", VA = "0x1874E7C00")]
	private void CGOCONMEFOP(Type NCOHIIOLOFF, KLLLFBAADAC MNBIIPGINAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x74E8390", Offset = "0x74E6D90", VA = "0x1874E8390")]
	private static int LNEIFLBEFHJ(Type NCOHIIOLOFF, Dictionary<Type, int> FGNLELLKPKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x35C31E0", Offset = "0x35C1BE0", VA = "0x1835C31E0")]
	private static bool FDDEACAKADE<TVal>(NPIBEHOOOBI<TVal> KJCKFFGBDON, Type NCOHIIOLOFF, [Out] TVal PKCLPFEIPFH) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x74E8510", Offset = "0x74E6F10", VA = "0x1874E8510")]
	[CompilerGenerated]
	internal static int OKOLPNFOHHF(Type BBJCDLCGLGL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct BILKLPGEBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly FDMGJGCOOAA JNLKNHBDOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly string DMOLIDCGDDC;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x74E8CF0", Offset = "0x74E76F0", VA = "0x1874E8CF0")]
	public BILKLPGEBOL(string LOKKPPBOABC, FDMGJGCOOAA IJKGJPCAEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x74E8C50", Offset = "0x74E7650", VA = "0x1874E8C50")]
	public string HLABNNBECJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class NABBJMIMBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly PGAINGHNNBN CEEFHKMEANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string LACFEPMLEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? FBCKFIEMKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private long? OACMKHJGCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? HMKMELGFNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private string DOJLIJMIFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private JIEGGJGCECL EANBIGAEBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? GBEBEDLDKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool CBJKADMPHGJ;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string FFEOMMKNIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public long EFCEOFKBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x74FD830", Offset = "0x74FC230", VA = "0x1874FD830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long HOJEDDFLJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x74FDD80", Offset = "0x74FC780", VA = "0x1874FDD80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long LOCDJOKJOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x74FD730", Offset = "0x74FC130", VA = "0x1874FD730")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string NEJINFEBPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x74FDDE0", Offset = "0x74FC7E0", VA = "0x1874FDDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JIEGGJGCECL OAIFHOHIOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x948EE0", Offset = "0x9478E0", VA = "0x180948EE0")]
		get
		{
			return default(JIEGGJGCECL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x74FDC90", Offset = "0x74FC690", VA = "0x1874FDC90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long OHKPAHAEFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x74FD6D0", Offset = "0x74FC0D0", VA = "0x1874FD6D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x74FE500", Offset = "0x74FCF00", VA = "0x1874FE500")]
	[UnityEngine.Scripting.Preserve]
	public NABBJMIMBHJ([CCLEDEMDDDH(null)] PGAINGHNNBN CEEFHKMEANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x74FDE20", Offset = "0x74FC820", VA = "0x1874FDE20")]
	private void MICBKLOGIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x74FE070", Offset = "0x74FCA70", VA = "0x1874FE070")]
	public void PONGHCMLJFN(long NPGHGEFGHLA, long OKPAMGANILI, [Optional] long? PDPMPEEFJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x74FD790", Offset = "0x74FC190", VA = "0x1874FD790")]
	public void CDMOONPIBOF(long PDPMPEEFJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x74FD890", Offset = "0x74FC290", VA = "0x1874FD890")]
	public void CKCNDLCEEIB(string ADBMEIHFDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x74FD910", Offset = "0x74FC310", VA = "0x1874FD910")]
	public void FMECNHLONPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class CEFBPLBIKCE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HNKBCEFEAEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public JDBONLEIIML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public CEFBPLBIKCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<LBJBADDKLDA.ADNMCFGOCCC<JDBONLEIIML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x7514FE0", Offset = "0x75139E0", VA = "0x187514FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7515520", Offset = "0x7513F20", VA = "0x187515520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct ALFEKNHGBDE<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class JNLDDBDMGDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public JDBONLEIIML roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JNLDDBDMGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7517320", Offset = "0x7515D20", VA = "0x187517320")]
		internal JDBONLEIIML HPAHHFGJMCP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct HMEIALHJEHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<LBJBADDKLDA.ADNMCFGOCCC<JDBONLEIIML>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public JDBONLEIIML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public CEFBPLBIKCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private DGMDPGGICDB <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<LBJBADDKLDA.ADNMCFGOCCC<JDBONLEIIML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7514960", Offset = "0x7513360", VA = "0x187514960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7514F70", Offset = "0x7513970", VA = "0x187514F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct HDFONEHILMH<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CEFBPLBIKCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x4175D50", Offset = "0x4174750", VA = "0x184175D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x38CF520", Offset = "0x38CDF20", VA = "0x1838CF520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct OGOLMAJDFKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CEFBPLBIKCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x751B310", Offset = "0x7519D10", VA = "0x18751B310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x751B4D0", Offset = "0x7519ED0", VA = "0x18751B4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class ENHBMEHOBPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ENHBMEHOBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7512200", Offset = "0x7510C00", VA = "0x187512200")]
		internal object IOMHBAFOICB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7512140", Offset = "0x7510B40", VA = "0x187512140")]
		internal bool FCCAMGLMFPB(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class FEGNKNOMILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FEGNKNOMILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x75125A0", Offset = "0x7510FA0", VA = "0x1875125A0")]
		internal object JFDICJECAGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class MHLGFLNNICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MHLGFLNNICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7519E90", Offset = "0x7518890", VA = "0x187519E90")]
		internal object AEJFIDJKLBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class OPIBJACFPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OPIBJACFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x751BF40", Offset = "0x751A940", VA = "0x18751BF40")]
		internal object PECKIGGEJCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class OIHLOEEDNOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public CEFBPLBIKCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OIHLOEEDNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x751B6F0", Offset = "0x751A0F0", VA = "0x18751B6F0")]
		internal object MMAMOMKEIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly Guid IJFEJMJLCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly KJKAGGHNJFC CGBHONIHJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly LBJBADDKLDA IAIMLBIEOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly NMAOFHHAHIH PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly NCBDKMOODGB KPBOFJFIOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool IKKKDHJDPPK;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x750B410", Offset = "0x7509E10", VA = "0x18750B410")]
	public CEFBPLBIKCE(KJKAGGHNJFC FAGENEAKFKC, LBJBADDKLDA IAIMLBIEOAG, NMAOFHHAHIH PPPAPIDLOLG, NCBDKMOODGB KPBOFJFIOEA, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x750A450", Offset = "0x7508E50", VA = "0x18750A450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x750AFF0", Offset = "0x75099F0", VA = "0x18750AFF0")]
	public void LOEGDDGFOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x750B2F0", Offset = "0x7509CF0", VA = "0x18750B2F0")]
	public void PMCFJJCPEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x750AC50", Offset = "0x7509650", VA = "0x18750AC50")]
	public void KCPIJPGOGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x750AD10", Offset = "0x7509710", VA = "0x18750AD10")]
	[AsyncStateMachine(typeof(HNKBCEFEAEL))]
	internal Task<JDBONLEIIML> KFMKMOMHICK(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, JDBONLEIIML IACBCDAPDHF, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8010", Offset = "0x2CE6A10", VA = "0x182CE8010")]
	private static byte[] CNPOFGCMAKE<T>(T FCMDIEEAPHD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8020", Offset = "0x2CE6A20", VA = "0x182CE8020")]
	private static T DAKDFNKOHKK<T>(MessageParser<T> BNKGKLEPBGG, byte[] FCMDIEEAPHD, T KKKOPPBCANH) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x750A990", Offset = "0x7509390", VA = "0x18750A990")]
	[AsyncStateMachine(typeof(HMEIALHJEHH))]
	private Task<LBJBADDKLDA.ADNMCFGOCCC<JDBONLEIIML>> HNNMFDAIGNH(JDBONLEIIML IACBCDAPDHF, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7AD0", Offset = "0x2CE64D0", VA = "0x182CE7AD0")]
	[AsyncStateMachine(typeof(HDFONEHILMH<>))]
	internal Task<T> AIDBNMPPHBE<T>(CancellationToken AGFJCKJDLDL, Func<CancellationToken, Task<T>> IDAMNCBNCAP, int NDHGPLFLEON = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x750A320", Offset = "0x7508D20", VA = "0x18750A320")]
	[AsyncStateMachine(typeof(OGOLMAJDFKG))]
	internal Task AIDBNMPPHBE(CancellationToken AGFJCKJDLDL, Func<CancellationToken, Task> IDAMNCBNCAP, int NDHGPLFLEON = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x750A460", Offset = "0x7508E60", VA = "0x18750A460")]
	public HGDPLJDIHHN ECLBAGCFGML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x750B110", Offset = "0x7509B10", VA = "0x18750B110")]
	public AHBFPENIKKK MLNNFDEBHLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x750AAD0", Offset = "0x75094D0", VA = "0x18750AAD0")]
	public BMBAOBPEKJJ IGIPLPPNNBP([Optional] KLEHBGEJMBN? DAKGLLFOGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x750A720", Offset = "0x7509120", VA = "0x18750A720")]
	public void GIGJIAMBPGN(Func<Guid, bool> KCBGNNGNGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x750A880", Offset = "0x7509280", VA = "0x18750A880")]
	public void HHLNMAJMECC(Func<Guid, bool> ONDOJKDDOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x750AE70", Offset = "0x7509870", VA = "0x18750AE70")]
	public Guid LALGNCLKLII()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x750A4E0", Offset = "0x7508EE0", VA = "0x18750A4E0")]
	public void FNDJBIDDLGF(Guid EKEBCNNGINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x750A5F0", Offset = "0x7508FF0", VA = "0x18750A5F0")]
	public void GBJKIIJEFJG(JDBONLEIIML HHFDDKNNGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x750B1E0", Offset = "0x7509BE0", VA = "0x18750B1E0")]
	public void PMAPEFGPDFK(string KFCGGOONMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8170", Offset = "0x2CE6B70", VA = "0x182CE8170")]
	private T KOEMBMFEKAB<T>(T PKCLPFEIPFH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x750B190", Offset = "0x7509B90", VA = "0x18750B190")]
	public void PDMBJKNACMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D70", Offset = "0x2CE6770", VA = "0x182CE7D70")]
	[CompilerGenerated]
	internal static string CFBPBANNEKL<T>(byte[] FFGGPAIGPAA, int FGAJAFBGABE, ALFEKNHGBDE<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class IEFOEFAKFAM : KJKAGGHNJFC
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class KKJJHCPKHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KKJJHCPKHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7518D50", Offset = "0x7517750", VA = "0x187518D50")]
		internal object LNCAOAEDEDK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct KALFEEMLPKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public IEFOEFAKFAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private MMPBFABBMCN <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private AHBFPENIKKK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7517400", Offset = "0x7515E00", VA = "0x187517400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7517CD0", Offset = "0x75166D0", VA = "0x187517CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct HBHECLOCCLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IEFOEFAKFAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter<IJINIJPNMHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x75139D0", Offset = "0x75123D0", VA = "0x1875139D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x7514120", Offset = "0x7512B20", VA = "0x187514120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct PKMKEHIDNME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public IEFOEFAKFAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<PDGFGDEMNEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x751C070", Offset = "0x751AA70", VA = "0x18751C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x751C380", Offset = "0x751AD80", VA = "0x18751C380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class FACGHFFINDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public MMPBFABBMCN presence;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FACGHFFINDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7512260", Offset = "0x7510C60", VA = "0x187512260")]
		internal object KAKIJJMHKHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static readonly KLEHBGEJMBN ENDMIGONNPN;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static readonly KLEHBGEJMBN IJKOCDNFHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly CMBGKEDMCPG ILIGNFDOOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private readonly OABHCPGEKDA IPPONHLLGPI;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x7515D90", Offset = "0x7514790", VA = "0x187515D90")]
	public IEFOEFAKFAM(CMBGKEDMCPG ILIGNFDOOJF, OABHCPGEKDA IPPONHLLGPI, Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, KBEJLAHBIDN PFOIPFHCCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x7515B80", Offset = "0x7514580", VA = "0x187515B80", Slot = "7")]
	[AsyncStateMachine(typeof(KALFEEMLPKE))]
	protected override Task OOACOAAELPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x75158A0", Offset = "0x75142A0", VA = "0x1875158A0")]
	[AsyncStateMachine(typeof(HBHECLOCCLO))]
	private Task IPJFLMCJFOA(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7515790", Offset = "0x7514190", VA = "0x187515790")]
	[AsyncStateMachine(typeof(PKMKEHIDNME))]
	private Task<int> EPNHIJNGFHE(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x75159A0", Offset = "0x75143A0", VA = "0x1875159A0")]
	private MMPBFABBMCN NJOHOGKPJNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class KGKJJOLNAOA : KJKAGGHNJFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct DJOJBCIAFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public KGKJJOLNAOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<AFCCLGFOAKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x750DC10", Offset = "0x750C610", VA = "0x18750DC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x750E5C0", Offset = "0x750CFC0", VA = "0x18750E5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly int MHJMILJMDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly HODNKPFLLHK JAFKJGHEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly long FFMKJNBFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly long GAHMFGAOOJM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public AFCCLGFOAKC AONEGGMCBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8B9770", Offset = "0x8B8170", VA = "0x1808B9770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8B97E0", Offset = "0x8B81E0", VA = "0x1808B97E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x7517F70", Offset = "0x7516970", VA = "0x187517F70")]
	public KGKJJOLNAOA(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, KBEJLAHBIDN PFOIPFHCCHI, int MHJMILJMDMM, HODNKPFLLHK JAFKJGHEDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x7517E50", Offset = "0x7516850", VA = "0x187517E50", Slot = "7")]
	[AsyncStateMachine(typeof(DJOJBCIAFPC))]
	protected override Task OOACOAAELPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class HABNMBLDJMH : KJKAGGHNJFC
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class DACOPLLENJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public HABNMBLDJMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public PEOKBLMALEB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DACOPLLENJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x750C5C0", Offset = "0x750AFC0", VA = "0x18750C5C0")]
		internal Task MAGOLMOIGHB(FILMNPNNHPJ<string>.EEFAEMIIABD postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x750C530", Offset = "0x750AF30", VA = "0x18750C530")]
		internal object DGEGBHDJANM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct GBGNKOJLONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public HABNMBLDJMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private DACOPLLENJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x7512850", Offset = "0x7511250", VA = "0x187512850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7513010", Offset = "0x7511A10", VA = "0x187513010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct CCPJMEMGAAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public PEOKBLMALEB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public HABNMBLDJMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x7509D20", Offset = "0x7508720", VA = "0x187509D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x750A2C0", Offset = "0x7508CC0", VA = "0x18750A2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7513980", Offset = "0x7512380", VA = "0x187513980")]
	public HABNMBLDJMH(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, KBEJLAHBIDN PFOIPFHCCHI, string HAIECJPHCFL, EFFOBLOOKHB MCFACOPHFFE, bool JHEONJMJBCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x7513840", Offset = "0x7512240", VA = "0x187513840", Slot = "7")]
	[AsyncStateMachine(typeof(GBGNKOJLONO))]
	protected override Task OOACOAAELPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task CFKAOFEPINJ(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7513700", Offset = "0x7512100", VA = "0x187513700")]
	[AsyncStateMachine(typeof(CCPJMEMGAAI))]
	private Task HMCLGAIKACA(IDisposable FDMAIDILJJM, PEOKBLMALEB LENNLGMCFKA, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class NJNOMPOFACG : KJKAGGHNJFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct PLFPADEHKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public NJNOMPOFACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter<HLPAOIDBMBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x751C3F0", Offset = "0x751ADF0", VA = "0x18751C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x751C960", Offset = "0x751B360", VA = "0x18751C960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly BAKCOMBJMKD NACGOOKCKAA;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x751AD00", Offset = "0x7519700", VA = "0x18751AD00")]
	public NJNOMPOFACG(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, KBEJLAHBIDN PFOIPFHCCHI, BAKCOMBJMKD NACGOOKCKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x751AB00", Offset = "0x7519500", VA = "0x18751AB00", Slot = "6")]
	protected override string JILGONKPCEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x751ABE0", Offset = "0x75195E0", VA = "0x18751ABE0", Slot = "7")]
	[AsyncStateMachine(typeof(PLFPADEHKLN))]
	protected override Task OOACOAAELPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class KJKAGGHNJFC : EGIGOEOGAJB
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task EMJLDBDKLMI(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class GGGLNKONKJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public KJKAGGHNJFC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GGGLNKONKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x75135D0", Offset = "0x7511FD0", VA = "0x1875135D0")]
		internal Task LGPBIOHLDJJ(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class PENIIBNOEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public GGGLNKONKJN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PENIIBNOEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x751BFB0", Offset = "0x751A9B0", VA = "0x18751BFB0")]
		internal object HIBJBNENAIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct ECLIMLJIANI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public KJKAGGHNJFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<KJKAGGHNJFC, FILMNPNNHPJ<string>.EEFAEMIIABD, CEFBPLBIKCE> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private GGGLNKONKJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private CEFBPLBIKCE <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<JDBONLEIIML> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x750F510", Offset = "0x750DF10", VA = "0x18750F510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x75106D0", Offset = "0x750F0D0", VA = "0x1875106D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct BABKLGKPBON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7508830", Offset = "0x7507230", VA = "0x187508830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x75092D0", Offset = "0x7507CD0", VA = "0x1875092D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct MJGNOGIPBGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public KJKAGGHNJFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7519F00", Offset = "0x7518900", VA = "0x187519F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x751A260", Offset = "0x7518C60", VA = "0x18751A260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly Guid CJBBCHHPBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly ByteString JJKCKBIKELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public readonly KBEJLAHBIDN PMHKDFGLNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	protected readonly string PADPJNJAEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly bool JHEONJMJBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly Queue<EMJLDBDKLMI> AGGKDHLOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly FJEHGFKNFIJ AFHBKJANMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly EFFOBLOOKHB MCFACOPHFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool MCAKPBKGPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public JIEGGJGCECL JAJEKIPDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public JIEGGJGCECL AAOKODHBPMD;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public FBPDAHOOPKF KPAEPEJLFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x75189F0", Offset = "0x75173F0", VA = "0x1875189F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public OLDOMICMCLE IGJKHCHGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7518730", Offset = "0x7517130", VA = "0x187518730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x75181E0", Offset = "0x7516BE0", VA = "0x1875181E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BANMMHGDGON KBEOBJHGGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7518A40", Offset = "0x7517440", VA = "0x187518A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x75180A0", Offset = "0x7516AA0", VA = "0x1875180A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7518BF0", Offset = "0x75175F0", VA = "0x187518BF0")]
	protected KJKAGGHNJFC(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, KBEJLAHBIDN PFOIPFHCCHI, string HAIECJPHCFL, EFFOBLOOKHB MCFACOPHFFE, bool JHEONJMJBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x75187E0", Offset = "0x75171E0", VA = "0x1875187E0", Slot = "6")]
	protected virtual string JILGONKPCEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7518780", Offset = "0x7517180", VA = "0x187518780")]
	public void IFGMBGFCBOH(EMJLDBDKLMI CNHGHEFAGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7518BD0", Offset = "0x75175D0", VA = "0x187518BD0")]
	protected void PNPCCNKOOAN(float CGOKOAJMBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x75188A0", Offset = "0x75172A0", VA = "0x1875188A0")]
	[AsyncStateMachine(typeof(ECLIMLJIANI))]
	public Task LDLLGDHEPIB(CancellationToken PPLDCJFFMEP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, [Optional] Func<KJKAGGHNJFC, FILMNPNNHPJ<string>.EEFAEMIIABD, CEFBPLBIKCE> EOCAOJBJAKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7518600", Offset = "0x7517000", VA = "0x187518600")]
	[AsyncStateMachine(typeof(BABKLGKPBON))]
	private static Task GFMLKIGPNLG(Func<CancellationToken, Task> BKAIAENEKIG, Func<CancellationToken, Task> JEBIFCGPBBF, CancellationToken AGFJCKJDLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7518480", Offset = "0x7516E80", VA = "0x187518480")]
	private void FDCDKALNJMH(bool HDKDMAHLAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x7518260", Offset = "0x7516C60", VA = "0x187518260")]
	private void EPFPGBDNJJK(CEFBPLBIKCE MJHPIPKJDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task OOACOAAELPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x75180C0", Offset = "0x7516AC0", VA = "0x1875180C0")]
	[AsyncStateMachine(typeof(MJGNOGIPBGD))]
	private Task DPELJGNPDHJ(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x7518A60", Offset = "0x7517460", VA = "0x187518A60")]
	public JDBONLEIIML PFGLAHFPIAJ(DGMDPGGICDB BMNECHEDJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7518AE0", Offset = "0x75174E0", VA = "0x187518AE0")]
	[CompilerGenerated]
	private Task PKILGCNAENB(CancellationToken FOFGABNNIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7518820", Offset = "0x7517220", VA = "0x187518820")]
	[CompilerGenerated]
	private object JOLNEEAGFMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class FEDNHEICPHO : HABNMBLDJMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct IKOJLBJOAAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public FEDNHEICPHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private PPGGANEOPEN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private AHBFPENIKKK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x7515F20", Offset = "0x7514920", VA = "0x187515F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7516690", Offset = "0x7515090", VA = "0x187516690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private readonly CMBGKEDMCPG BHOKJADPKNN;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x75124F0", Offset = "0x7510EF0", VA = "0x1875124F0")]
	public FEDNHEICPHO(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, CMBGKEDMCPG BHOKJADPKNN, KBEJLAHBIDN PFOIPFHCCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x75123A0", Offset = "0x7510DA0", VA = "0x1875123A0", Slot = "8")]
	[AsyncStateMachine(typeof(IKOJLBJOAAE))]
	protected override Task CFKAOFEPINJ(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class OHIAEGMOGNH : KJKAGGHNJFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct MAPEBFCGNOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public OHIAEGMOGNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<HLPAOIDBMBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x75195E0", Offset = "0x7517FE0", VA = "0x1875195E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x7519990", Offset = "0x7518390", VA = "0x187519990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly string IIOMOGICPGI;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x751B640", Offset = "0x751A040", VA = "0x18751B640")]
	public OHIAEGMOGNH(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, KBEJLAHBIDN PFOIPFHCCHI, string IIOMOGICPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x751B530", Offset = "0x7519F30", VA = "0x18751B530", Slot = "7")]
	[AsyncStateMachine(typeof(MAPEBFCGNOF))]
	protected override Task OOACOAAELPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class OGJAGEPLJPP : HABNMBLDJMH
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class KCLMOKDDGPI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public KCLMOKDDGPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<HLPAOIDBMBB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<JDBONLEIIML> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x751DEC0", Offset = "0x751C8C0", VA = "0x18751DEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x751E380", Offset = "0x751CD80", VA = "0x18751E380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public OGJAGEPLJPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public BMBAOBPEKJJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public OFNJDMAAPJA roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public HGDPLJDIHHN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public ACDALMNGNFK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KCLMOKDDGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7517D30", Offset = "0x7516730", VA = "0x187517D30")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JDBONLEIIML> LNOKJKDIFLJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct AIPFKMFPANN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public OGJAGEPLJPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private KCLMOKDDGPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PPGGANEOPEN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private AHBFPENIKKK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private JDBONLEIIML <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7506AD0", Offset = "0x75054D0", VA = "0x187506AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7507A50", Offset = "0x7506450", VA = "0x187507A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private static readonly KLEHBGEJMBN ENDMIGONNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int EHKPDKPBKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[CanBeNull]
	private readonly JBJGKGNCJFN BHMCOFGNKDJ;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x751B260", Offset = "0x7519C60", VA = "0x18751B260")]
	public OGJAGEPLJPP(Guid GGNKLHDGNDO, FBPDAHOOPKF GDNLGDEFCDG, int EHKPDKPBKCL, JBJGKGNCJFN BHMCOFGNKDJ, KBEJLAHBIDN PFOIPFHCCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x751ADA0", Offset = "0x75197A0", VA = "0x18751ADA0", Slot = "8")]
	[AsyncStateMachine(typeof(AIPFKMFPANN))]
	protected override Task CFKAOFEPINJ(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x751AEE0", Offset = "0x75198E0", VA = "0x18751AEE0")]
	private void KJDIBLHLJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x751AFE0", Offset = "0x75199E0", VA = "0x18751AFE0")]
	private void MCKLELNAIII(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, PPGGANEOPEN JFBLNKBHMAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class FNMLBODPJAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public readonly KJKAGGHNJFC CGBHONIHJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public readonly CEFBPLBIKCE CAIBGAGHBIP;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7512690", Offset = "0x7511090", VA = "0x187512690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7512600", Offset = "0x7511000", VA = "0x187512600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x75127F0", Offset = "0x75111F0", VA = "0x1875127F0")]
	protected FNMLBODPJAO(CEFBPLBIKCE MJHPIPKJDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x75126E0", Offset = "0x75110E0", VA = "0x1875126E0")]
	protected void PMAPEFGPDFK(string KFCGGOONMHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct LACCCNLELJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<LBMIFONNPIK>> JGCJENOGDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public Dictionary<Guid, List<LBMIFONNPIK>> NDIKFJHHOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public Dictionary<Guid, List<LBMIFONNPIK>> EBIONCFFBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public List<Guid> DGNHAOKHOCM;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7518EC0", Offset = "0x75178C0", VA = "0x187518EC0")]
	public static LACCCNLELJA KJCABELIABF(KJJEFGMNENB LPMHKEAJABJ, JIEGGJGCECL GOBCNOLHEEI, LKMBJDMKDPJ ALBPBBBPAAI)
	{
		return default(LACCCNLELJA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct DAELIELCJML
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	public static DAELIELCJML LNCAGMGJJFK()
	{
		return default(DAELIELCJML);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct OJIGAOODEMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly IJINIJPNMHJ MGDHFCBGAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly EFEKMJJDMGI GENIEJMMLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly string BKELLPBJGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly OAGGCGDDFAC FGOFNGOIJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly OAGGCGDDFAC DFDBLOHMKKB;

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x751B930", Offset = "0x751A330", VA = "0x18751B930")]
	public OJIGAOODEMF(IJINIJPNMHJ MGDHFCBGAAG, EFEKMJJDMGI GENIEJMMLII, string BKELLPBJGPP, OAGGCGDDFAC FGOFNGOIJIL, OAGGCGDDFAC DFDBLOHMKKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct DGELBPNGHLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly CEFBPLBIKCE MJHPIPKJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Guid EKEBCNNGINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private bool HDKDMAHLAFI;

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x750D9B0", Offset = "0x750C3B0", VA = "0x18750D9B0")]
	public static DGELBPNGHLN LALGNCLKLII(CEFBPLBIKCE MJHPIPKJDHP)
	{
		return default(DGELBPNGHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xCC40F0", Offset = "0xCC2AF0", VA = "0x180CC40F0")]
	public void PCJCPJELGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x750D770", Offset = "0x750C170", VA = "0x18750D770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x750DA80", Offset = "0x750C480", VA = "0x18750DA80")]
	private DGELBPNGHLN(CEFBPLBIKCE MJHPIPKJDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x750D780", Offset = "0x750C180", VA = "0x18750D780")]
	private void FNDJBIDDLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x750D9E0", Offset = "0x750C3E0", VA = "0x18750D9E0")]
	private Func<Guid, bool> OAMNCNPBLIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class AHBFPENIKKK : FNMLBODPJAO, EGIGOEOGAJB
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<JIEGGJGCECL> KLHDNCEHIMI(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO KKIHJPPJNEE, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct HIHIMILADDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CMBGKEDMCPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private DGELBPNGHLN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7514180", Offset = "0x7512B80", VA = "0x187514180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7514900", Offset = "0x7513300", VA = "0x187514900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct MHHJNLJDCMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public CMBGKEDMCPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x75199F0", Offset = "0x75183F0", VA = "0x1875199F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7519E20", Offset = "0x7518820", VA = "0x187519E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct EEMBPGIOICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CMBGKEDMCPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7511950", Offset = "0x7510350", VA = "0x187511950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7511F90", Offset = "0x7510990", VA = "0x187511F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class GCHAKGHBMHB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public AsyncTaskMethodBuilder<OJIGAOODEMF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public GCHAKGHBMHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private OJIGAOODEMF <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter<JIEGGJGCECL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private TaskAwaiter<OJIGAOODEMF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x751C9C0", Offset = "0x751B3C0", VA = "0x18751C9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x751D120", Offset = "0x751BB20", VA = "0x18751D120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public AsyncTaskMethodBuilder<LKMBJDMKDPJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public GCHAKGHBMHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private LKMBJDMKDPJ <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<JIEGGJGCECL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private TaskAwaiter<LKMBJDMKDPJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x751D190", Offset = "0x751BB90", VA = "0x18751D190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x751D7C0", Offset = "0x751C1C0", VA = "0x18751D7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public CMBGKEDMCPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public FJEHGFKNFIJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public FJEHGFKNFIJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public OJIGAOODEMF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public FJEHGFKNFIJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public LKMBJDMKDPJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public OMLEINKKIDN.NOOFNPPCJMN <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GCHAKGHBMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x7513070", Offset = "0x7511A70", VA = "0x187513070")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<OJIGAOODEMF> COFNDPMHPOM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7513310", Offset = "0x7511D10", VA = "0x187513310")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<LKMBJDMKDPJ> HFFKIEKDIOH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7513430", Offset = "0x7511E30", VA = "0x187513430")]
		internal void HIIMHGGJGHB(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7513470", Offset = "0x7511E70", VA = "0x187513470")]
		internal Task IICJMIHNFCA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x75131B0", Offset = "0x7511BB0", VA = "0x1875131B0")]
		internal Task GCJDFDBGCLM(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct AKACAGLGHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CMBGKEDMCPG request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private GCHAKGHBMHB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<OJIGAOODEMF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<LKMBJDMKDPJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7507AB0", Offset = "0x75064B0", VA = "0x187507AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x75087D0", Offset = "0x75071D0", VA = "0x1875087D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct DOKEEPHKMBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public LKMBJDMKDPJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public FJEHGFKNFIJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<JIEGGJGCECL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private PLCAPLLLHFO <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x750E620", Offset = "0x750D020", VA = "0x18750E620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x750F4B0", Offset = "0x750DEB0", VA = "0x18750F4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct JEDJMBEAPDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x75166F0", Offset = "0x75150F0", VA = "0x1875166F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7516FB0", Offset = "0x75159B0", VA = "0x187516FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct CAJNKFGNLOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7509330", Offset = "0x7507D30", VA = "0x187509330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x7509CC0", Offset = "0x75086C0", VA = "0x187509CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct EEJKDGBHIIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x7510730", Offset = "0x750F130", VA = "0x187510730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x75118E0", Offset = "0x75102E0", VA = "0x1875118E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct DADPGLDEJAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public PLCAPLLLHFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x750C600", Offset = "0x750B000", VA = "0x18750C600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x750D700", Offset = "0x750C100", VA = "0x18750D700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct JMKKNMECBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public JIEGGJGCECL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public LKMBJDMKDPJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7517010", Offset = "0x7515A10", VA = "0x187517010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x75172B0", Offset = "0x7515CB0", VA = "0x1875172B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class LGJBJNPDLLN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public LGJBJNPDLLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private HIEPCOOLPHO <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private TaskAwaiter<JIEGGJGCECL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x751D830", Offset = "0x751C230", VA = "0x18751D830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x751DE50", Offset = "0x751C850", VA = "0x18751DE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public KLHDNCEHIMI masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public PLCAPLLLHFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public JIEGGJGCECL originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LGJBJNPDLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x75194C0", Offset = "0x7517EC0", VA = "0x1875194C0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<JIEGGJGCECL> GFIGCKMPIBH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct OOEKDPIDKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public KLHDNCEHIMI masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public PLCAPLLLHFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x751B9B0", Offset = "0x751A3B0", VA = "0x18751B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x751BED0", Offset = "0x751A8D0", VA = "0x18751BED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct MMAKJGOHFKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private JIEGGJGCECL <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private IEnumerator<JIEGGJGCECL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x751A2C0", Offset = "0x7518CC0", VA = "0x18751A2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x751A820", Offset = "0x7519220", VA = "0x18751A820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct NAOBIGCCGDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x751A880", Offset = "0x7519280", VA = "0x18751A880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x751AAA0", Offset = "0x75194A0", VA = "0x18751AAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct IAOBPMFLJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7515590", Offset = "0x7513F90", VA = "0x187515590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7515730", Offset = "0x7514130", VA = "0x187515730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct CEOOAGEBAMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public LKMBJDMKDPJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public FJEHGFKNFIJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<JIEGGJGCECL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private PLCAPLLLHFO <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x750B640", Offset = "0x750A040", VA = "0x18750B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x750C4D0", Offset = "0x750AED0", VA = "0x18750C4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct HJMDCLFGCIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public AHBFPENIKKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public FJEHGFKNFIJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7529350", Offset = "0x7527D50", VA = "0x187529350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x752A050", Offset = "0x7528A50", VA = "0x18752A050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly LLKIGIOJMJI AIJCOMMEPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly LLKIGIOJMJI HIPMBGDOBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly NABBJMIMBHJ IHIBLLDLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly MGJCBILPHEP MJBODFHEJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly NGLACFOCPHA MPEAGIHIGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private ProfilerCounterValue<int> AOPLMKEMNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly PECEMKMFHAP ILKILGOKNIF;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private FBPDAHOOPKF KPAEPEJLFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7505F00", Offset = "0x7504900", VA = "0x187505F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BANMMHGDGON KBEOBJHGGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7506680", Offset = "0x7505080", VA = "0x187506680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x75057C0", Offset = "0x75041C0", VA = "0x1875057C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7506800", Offset = "0x7505200", VA = "0x187506800")]
	public AHBFPENIKKK(CEFBPLBIKCE MJHPIPKJDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x75053B0", Offset = "0x7503DB0", VA = "0x1875053B0")]
	[AsyncStateMachine(typeof(HIHIMILADDN))]
	public Task BDPKCKODJMJ(CMBGKEDMCPG PGCEOMNLPAE, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x75066A0", Offset = "0x75050A0", VA = "0x1875066A0")]
	[AsyncStateMachine(typeof(MHHJNLJDCMO))]
	private Task<JDBONLEIIML> PJMFGFJHCOI(CMBGKEDMCPG PGCEOMNLPAE, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7505BF0", Offset = "0x75045F0", VA = "0x187505BF0")]
	[AsyncStateMachine(typeof(EEMBPGIOICL))]
	private Task EKNCNFBEBFD(CMBGKEDMCPG PGCEOMNLPAE, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x7505FB0", Offset = "0x75049B0", VA = "0x187505FB0")]
	[AsyncStateMachine(typeof(AKACAGLGHNN))]
	private Task HKLFMJPKKPP(CMBGKEDMCPG PGCEOMNLPAE, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken FMEBDANOOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7505AA0", Offset = "0x75044A0", VA = "0x187505AA0")]
	[AsyncStateMachine(typeof(DOKEEPHKMBB))]
	private Task DMAODKNMACK(LKMBJDMKDPJ KMDFCCNGPPJ, FJEHGFKNFIJ BDHAJOIHFMO, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken JAAKIFIPLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7506570", Offset = "0x7504F70", VA = "0x187506570")]
	[AsyncStateMachine(typeof(JEDJMBEAPDK))]
	private Task MIPAGEJGMGC(FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7504F80", Offset = "0x7503980", VA = "0x187504F80")]
	[AsyncStateMachine(typeof(CAJNKFGNLOC))]
	private Task AHIKBIAMLBC(LKMBJDMKDPJ GGEMPJLCHFC, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x75060F0", Offset = "0x7504AF0", VA = "0x1875060F0")]
	[AsyncStateMachine(typeof(EEJKDGBHIIL))]
	private Task<JIEGGJGCECL> HPJPOHJAEIK(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7505D80", Offset = "0x7504780", VA = "0x187505D80")]
	[AsyncStateMachine(typeof(DADPGLDEJAK))]
	private Task<JIEGGJGCECL> FIDFFGMAMLB(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x75062A0", Offset = "0x7504CA0", VA = "0x1875062A0")]
	[AsyncStateMachine(typeof(JMKKNMECBOI))]
	private Task<JIEGGJGCECL> JJKDIOBBFJE(JIEGGJGCECL GOBCNOLHEEI, LKMBJDMKDPJ ALBPBBBPAAI, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP, bool GMNDCHHMPMB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7505810", Offset = "0x7504210", VA = "0x187505810")]
	private bool CMNFBMMMMCD(LKMBJDMKDPJ KMDFCCNGPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7505630", Offset = "0x7504030", VA = "0x187505630")]
	[AsyncStateMachine(typeof(OOEKDPIDKMJ))]
	protected Task<JIEGGJGCECL> CFIJJELIDNP(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP, KLHDNCEHIMI BKJFCHBJLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7506420", Offset = "0x7504E20", VA = "0x187506420")]
	[AsyncStateMachine(typeof(MMAKJGOHFKI))]
	private Task KHODNKAAFBM(LKMBJDMKDPJ GGEMPJLCHFC, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7506250", Offset = "0x7504C50", VA = "0x187506250")]
	private void JJBLKKEDGBN(JIEGGJGCECL EPNLMLMKOJP, FJEHGFKNFIJ PDCHMKBJFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x75050D0", Offset = "0x7503AD0", VA = "0x1875050D0")]
	private void AMINJPFMDFE(JIEGGJGCECL INHKPJOCEJI, [Out] JIEGGJGCECL PLBJGOFFEAA, [Out] JIEGGJGCECL KBBHDAKPMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7505900", Offset = "0x7504300", VA = "0x187505900")]
	private Task<OJIGAOODEMF> DAOCEHEOABG(CMBGKEDMCPG PGCEOMNLPAE, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x75055F0", Offset = "0x7503FF0", VA = "0x1875055F0")]
	private Task<LKMBJDMKDPJ> BMJMDLGNNCM(OJIGAOODEMF GGEMPJLCHFC, OMLEINKKIDN.NOOFNPPCJMN PJOPMGKFLBD, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7505260", Offset = "0x7503C60", VA = "0x187505260")]
	[AsyncStateMachine(typeof(NAOBIGCCGDG))]
	private Task AOLMHGNILNM(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP, bool JJPJIPIGEJL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7505500", Offset = "0x7503F00", VA = "0x187505500")]
	[AsyncStateMachine(typeof(IAOBPMFLJBD))]
	private Task BIAHANJKPKD(LKMBJDMKDPJ GGEMPJLCHFC, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x75057E0", Offset = "0x75041E0", VA = "0x1875057E0")]
	private Task CLMGOJJJCBJ(LKMBJDMKDPJ GGEMPJLCHFC, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7505F70", Offset = "0x7504970", VA = "0x187505F70")]
	private Task HAGIILNMFAG(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7505F90", Offset = "0x7504990", VA = "0x187505F90")]
	private Task HALAKKLNJLI(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7505D60", Offset = "0x7504760", VA = "0x187505D60")]
	private Task FEGJDFMMFPB(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x7505D50", Offset = "0x7504750", VA = "0x187505D50")]
	private static Task ENJPFAILDGL(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7505F30", Offset = "0x7504930", VA = "0x187505F30")]
	private Task GFOHIGMGIMK(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7505D30", Offset = "0x7504730", VA = "0x187505D30")]
	private Task ENDLNCHEOEB(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7504F30", Offset = "0x7503930", VA = "0x187504F30")]
	private void AEAIPEJNPFK(CMBGKEDMCPG PGCEOMNLPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7505F50", Offset = "0x7504950", VA = "0x187505F50")]
	public void GMHPPACCMBB(long PDPMPEEFJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void BDPMKGKDFOI(IJINIJPNMHJ MGDHFCBGAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x7505110", Offset = "0x7503B10", VA = "0x187505110")]
	[AsyncStateMachine(typeof(CEOOAGEBAMJ))]
	private Task ANDLNNGJNIK(LKMBJDMKDPJ KMDFCCNGPPJ, FJEHGFKNFIJ BDHAJOIHFMO, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken JAAKIFIPLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x7505940", Offset = "0x7504340", VA = "0x187505940")]
	[AsyncStateMachine(typeof(HJMDCLFGCIE))]
	[CompilerGenerated]
	private Task<JIEGGJGCECL> DDAPHMFIGFD(LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FJEHGFKNFIJ PDCHMKBJFFI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct DDIACONPBJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private LKMBJDMKDPJ GGEMPJLCHFC;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7522E50", Offset = "0x7521850", VA = "0x187522E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7522D70", Offset = "0x7521770", VA = "0x187522D70")]
	public static Task LDLLGDHEPIB(FBPDAHOOPKF GDNLGDEFCDG, LKMBJDMKDPJ GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7522B50", Offset = "0x7521550", VA = "0x187522B50")]
	private void LDLLGDHEPIB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct HCFKNMGGCKB
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7528200", Offset = "0x7526C00", VA = "0x187528200")]
	public static Task LDLLGDHEPIB(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct DAMDAHNMHHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct BPEHNLBHCAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x7521920", Offset = "0x7520320", VA = "0x187521920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7521E50", Offset = "0x7520850", VA = "0x187521E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x75223E0", Offset = "0x7520DE0", VA = "0x1875223E0")]
	[AsyncStateMachine(typeof(BPEHNLBHCAO))]
	public static Task LDLLGDHEPIB(CEFBPLBIKCE MJHPIPKJDHP, LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct IAAAINKJBGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct LLACAFKBJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public PLCAPLLLHFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private JIEGGJGCECL <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private FBPDAHOOPKF <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private KJJEFGMNENB <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private HIEPCOOLPHO <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private List<(PersistenceView, INNJJHKNLDI)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private INNJJHKNLDI <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x752F8E0", Offset = "0x752E2E0", VA = "0x18752F8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7530570", Offset = "0x752EF70", VA = "0x187530570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x752B540", Offset = "0x7529F40", VA = "0x18752B540")]
	[AsyncStateMachine(typeof(LLACAFKBJKH))]
	public static Task LDLLGDHEPIB(CEFBPLBIKCE MJHPIPKJDHP, LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x752B350", Offset = "0x7529D50", VA = "0x18752B350")]
	private static void CGDIHKIDEMB(PersistenceView EPCOPABAPDA, INNJJHKNLDI MDLHGFCNBNN, LKMBJDMKDPJ GGEMPJLCHFC, JIEGGJGCECL GOBCNOLHEEI, bool MNHNPHKHPHG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct LNBMCCMOFHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct IPLCMLMNOHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public FBPDAHOOPKF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private HIEPCOOLPHO <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x752D210", Offset = "0x752BC10", VA = "0x18752D210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x752D830", Offset = "0x752C230", VA = "0x18752D830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x75305D0", Offset = "0x752EFD0", VA = "0x1875305D0")]
	[AsyncStateMachine(typeof(IPLCMLMNOHE))]
	public static Task LDLLGDHEPIB(FBPDAHOOPKF GDNLGDEFCDG, LKMBJDMKDPJ GGEMPJLCHFC, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct DPDCAPJIIKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct HGEKBINMBLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public FBPDAHOOPKF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x7528A30", Offset = "0x7527430", VA = "0x187528A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7528C40", Offset = "0x7527640", VA = "0x187528C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class DLFJAGCMKNC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public DLFJAGCMKNC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x75379E0", Offset = "0x75363E0", VA = "0x1875379E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x7537D70", Offset = "0x7536770", VA = "0x187537D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DLFJAGCMKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x7523390", Offset = "0x7521D90", VA = "0x187523390")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task KNIMIHCKACM(FILMNPNNHPJ<string>.EEFAEMIIABD timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct LOIAJLGMFHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public DPDCAPJIIKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private HIEPCOOLPHO <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x75306F0", Offset = "0x752F0F0", VA = "0x1875306F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x7531300", Offset = "0x752FD00", VA = "0x187531300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class EGAONMFCMDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public CAMCIKNBNLL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EGAONMFCMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x75254C0", Offset = "0x7523EC0", VA = "0x1875254C0")]
		internal object PKHDMPPOBLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7525410", Offset = "0x7523E10", VA = "0x187525410")]
		internal object FKNEEDLPIDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private LKMBJDMKDPJ GGEMPJLCHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private CEFBPLBIKCE MJHPIPKJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private bool JJPJIPIGEJL;

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly ByteString CAKPJOIFFDN;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7523DD0", Offset = "0x75227D0", VA = "0x187523DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private PKKFJLINELL KLMJCKEMFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7523A70", Offset = "0x7522470", VA = "0x187523A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7523C80", Offset = "0x7522680", VA = "0x187523C80")]
	[AsyncStateMachine(typeof(HGEKBINMBLD))]
	public static Task LDLLGDHEPIB(FBPDAHOOPKF GDNLGDEFCDG, LKMBJDMKDPJ GGEMPJLCHFC, CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP, bool JJPJIPIGEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x7523B50", Offset = "0x7522550", VA = "0x187523B50")]
	[AsyncStateMachine(typeof(LOIAJLGMFHE))]
	private Task LDLLGDHEPIB(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7523E20", Offset = "0x7522820", VA = "0x187523E20")]
	private void PLEHNFGKEBJ([NotNull] FNEPJCIGLHI ECOALFPMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7523B10", Offset = "0x7522510", VA = "0x187523B10")]
	private bool JEBHLFFGLJM(CAMCIKNBNLL OCMGGEGAGNJ, FNEPJCIGLHI ECOALFPMDCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct KGPPCLACHDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct PMOOJCONMDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<LKMBJDMKDPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public KGPPCLACHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public OMLEINKKIDN.NOOFNPPCJMN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(OKPKCEBGDLD<IFDKCMANFCK, JMDMKJMGBCA>, OKPKCEBGDLD<EIIKFAFHFIO<FNEPJCIGLHI>, JMDMKJMGBCA>, OKPKCEBGDLD<EIIKFAFHFIO<GOMCODJKDBA>, JMDMKJMGBCA>, OKPKCEBGDLD<EIIKFAFHFIO<PBLIOBODKJG>, JMDMKJMGBCA>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x75366E0", Offset = "0x75350E0", VA = "0x1875366E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7537190", Offset = "0x7535B90", VA = "0x187537190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct GFFIFCMNLDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<IFDKCMANFCK, JMDMKJMGBCA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public KGPPCLACHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public OMLEINKKIDN.NOOFNPPCJMN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<OKPKCEBGDLD<IFDKCMANFCK, JMDMKJMGBCA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7527280", Offset = "0x7525C80", VA = "0x187527280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7527890", Offset = "0x7526290", VA = "0x187527890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private CKKDGGGLGCC<OAGGCGDDFAC, GOMCODJKDBA> BCOEILCOMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private CKKDGGGLGCC<OAGGCGDDFAC, FNEPJCIGLHI> ENMMIANIPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private CKKDGGGLGCC<long, PBLIOBODKJG> MGIOKAPPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private ENFEAPLJLEB BBNBDOJKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private IJINIJPNMHJ MGDHFCBGAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private EFEKMJJDMGI GENIEJMMLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string BKELLPBJGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private OAGGCGDDFAC FGOFNGOIJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private OAGGCGDDFAC DFDBLOHMKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long PDPMPEEFJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x752EFE0", Offset = "0x752D9E0", VA = "0x18752EFE0")]
	public static Task<LKMBJDMKDPJ> ODPJGJCHDNC(FBPDAHOOPKF GDNLGDEFCDG, [In] OJIGAOODEMF GGEMPJLCHFC, OMLEINKKIDN.NOOFNPPCJMN PJOPMGKFLBD, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x752EE50", Offset = "0x752D850", VA = "0x18752EE50")]
	[AsyncStateMachine(typeof(PMOOJCONMDC))]
	private Task<LKMBJDMKDPJ> LDLLGDHEPIB(OMLEINKKIDN.NOOFNPPCJMN PJOPMGKFLBD, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x752EC90", Offset = "0x752D690", VA = "0x18752EC90")]
	[AsyncStateMachine(typeof(GFFIFCMNLDL))]
	private Task<OKPKCEBGDLD<IFDKCMANFCK, JMDMKJMGBCA>> CDBHGGIHOHA(string BKELLPBJGPP, long PDPMPEEFJNK, long? NPGHGEFGHLA, long? GDENKKEDKLA, OMLEINKKIDN.NOOFNPPCJMN PJOPMGKFLBD, FILMNPNNHPJ<string>.EEFAEMIIABD HOGGOOBFJLP, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct ECDODFPKBML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct DMOMACCONKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<OJIGAOODEMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public ECDODFPKBML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<OJIGAOODEMF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x75234B0", Offset = "0x7521EB0", VA = "0x1875234B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x75238C0", Offset = "0x75222C0", VA = "0x1875238C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct PMGEAFMHLFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<OJIGAOODEMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public ECDODFPKBML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<OJIGAOODEMF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x7536240", Offset = "0x7534C40", VA = "0x187536240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7536670", Offset = "0x7535070", VA = "0x187536670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class PEONCMCPBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PEONCMCPBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA0CD10", Offset = "0xA0B710", VA = "0x180A0CD10")]
		internal bool DDFOBGKCMKG(EFEKMJJDMGI sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct AOKNAFGHBNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<OJIGAOODEMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public OAGGCGDDFAC superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public KJJEFGMNENB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private PEONCMCPBGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public FBCIJNEHIMJ roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private IJINIJPNMHJ <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private EFEKMJJDMGI <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private OAGGCGDDFAC <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private OAGGCGDDFAC <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<IJINIJPNMHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<OGJPACLLFCJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<PDGFGDEMNEN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x751E730", Offset = "0x751D130", VA = "0x18751E730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x751F890", Offset = "0x751E290", VA = "0x18751F890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private NABBJMIMBHJ IHIBLLDLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private FBCIJNEHIMJ KOMKCDKPFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long NPGHGEFGHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long OKPAMGANILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long IOJIAKJKDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string DEBCIKJGCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private OAGGCGDDFAC KFEMJGBJJDJ;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x75251E0", Offset = "0x7523BE0", VA = "0x1875251E0")]
	public static Task<OJIGAOODEMF> ODPJGJCHDNC(FBPDAHOOPKF GDNLGDEFCDG, CMBGKEDMCPG PGCEOMNLPAE, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7525090", Offset = "0x7523A90", VA = "0x187525090")]
	[AsyncStateMachine(typeof(DMOMACCONKK))]
	private Task<OJIGAOODEMF> LDLLGDHEPIB(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x7524F00", Offset = "0x7523900", VA = "0x187524F00")]
	[AsyncStateMachine(typeof(PMGEAFMHLFK))]
	private Task<OJIGAOODEMF> DAOCEHEOABG(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7524D60", Offset = "0x7523760", VA = "0x187524D60")]
	[AsyncStateMachine(typeof(AOKNAFGHBNI))]
	private static Task<OJIGAOODEMF> DAOCEHEOABG(KJJEFGMNENB LPMHKEAJABJ, FBCIJNEHIMJ KOMKCDKPFFA, long NPGHGEFGHLA, long OKPAMGANILI, long IOJIAKJKDMD, string DEBCIKJGCDH, OAGGCGDDFAC KFEMJGBJJDJ, CancellationToken PPLDCJFFMEP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7525060", Offset = "0x7523A60", VA = "0x187525060")]
	private void KGLMDNJAJCF(IJINIJPNMHJ MGDHFCBGAAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct DBBPMILMFHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct PGCPNNGNBJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public DBBPMILMFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7535C50", Offset = "0x7534650", VA = "0x187535C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x75361E0", Offset = "0x7534BE0", VA = "0x1875361E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private LKMBJDMKDPJ GGEMPJLCHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float HHIACOLGDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float NGDHNAAHCDL;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x75229B0", Offset = "0x75213B0", VA = "0x1875229B0")]
	public static Task NEDHEIKMMCN(FBPDAHOOPKF GDNLGDEFCDG, LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x7522740", Offset = "0x7521140", VA = "0x187522740")]
	[AsyncStateMachine(typeof(PGCPNNGNBJA))]
	public Task LDLLGDHEPIB(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x7522880", Offset = "0x7521280", VA = "0x187522880")]
	private static void MLFPKEBHDGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x7522520", Offset = "0x7520F20", VA = "0x187522520")]
	private void GPHPBBHNPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x7522680", Offset = "0x7521080", VA = "0x187522680")]
	private static float HBPOGGMMLBP(KJJEFGMNENB LPMHKEAJABJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7522860", Offset = "0x7521260", VA = "0x187522860")]
	private static float MHENAJPDLNI()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct OBGOFEFKDCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct IJEINICNPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CEFBPLBIKCE operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private KJKAGGHNJFC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private FBPDAHOOPKF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private JFBOHNMOLEL.JGAGBBEGGAM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x752BD60", Offset = "0x752A760", VA = "0x18752BD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x752C580", Offset = "0x752AF80", VA = "0x18752C580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct CJFDCJKIGFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7521EB0", Offset = "0x75208B0", VA = "0x187521EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x75221E0", Offset = "0x7520BE0", VA = "0x1875221E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x7534150", Offset = "0x7532B50", VA = "0x187534150")]
	[AsyncStateMachine(typeof(IJEINICNPEF))]
	public static Task LDLLGDHEPIB(CEFBPLBIKCE MJHPIPKJDHP, LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x7534290", Offset = "0x7532C90", VA = "0x187534290")]
	private static Task<JDBONLEIIML> OCPDOMBBBPB(CEFBPLBIKCE MJHPIPKJDHP, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x7534300", Offset = "0x7532D00", VA = "0x187534300")]
	[AsyncStateMachine(typeof(CJFDCJKIGFG))]
	private static Task PGBMMLAFNJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct OLECAODPCEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct EABGDCJMADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public OLECAODPCEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7524650", Offset = "0x7523050", VA = "0x187524650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7524D00", Offset = "0x7523700", VA = "0x187524D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class JJDCCMHNEPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JJDCCMHNEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x752E780", Offset = "0x752D180", VA = "0x18752E780")]
		internal object GMFOGGAOGKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct ONKPKCHLBED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public OLECAODPCEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7535070", Offset = "0x7533A70", VA = "0x187535070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x75354F0", Offset = "0x7533EF0", VA = "0x1875354F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool AHILIAIGMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken PPLDCJFFMEP;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x7534DE0", Offset = "0x75337E0", VA = "0x187534DE0")]
	public static Task BHCGKCFCJPG(FBPDAHOOPKF GDNLGDEFCDG, bool AHILIAIGMFF, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken BIDJOLCDMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x7534F80", Offset = "0x7533980", VA = "0x187534F80")]
	[AsyncStateMachine(typeof(EABGDCJMADG))]
	private Task LDLLGDHEPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x7534E50", Offset = "0x7533850", VA = "0x187534E50")]
	[AsyncStateMachine(typeof(ONKPKCHLBED))]
	private Task HIDOEOCHCCP(bool JGLGJDPAMFJ, string DNDEFCJDLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	private bool BNJAGAFNCFC(bool AHILIAIGMFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct BNIOMADJEOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct ELLAHLJGMGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public BNIOMADJEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7525C90", Offset = "0x7524690", VA = "0x187525C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x7526200", Offset = "0x7524C00", VA = "0x187526200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class OCANEAFLAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OCANEAFLAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x75343C0", Offset = "0x7532DC0", VA = "0x1875343C0")]
		internal object GMFOGGAOGKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct DIELDMEKIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public BNIOMADJEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7522EA0", Offset = "0x75218A0", VA = "0x187522EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7523320", Offset = "0x7521D20", VA = "0x187523320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private FLKNJMLJCPI PMHLAIBAIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool JGNNGEHBLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private LKMBJDMKDPJ GGEMPJLCHFC;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x7521780", Offset = "0x7520180", VA = "0x187521780")]
	public static Task<Scene> KNLHOIDFOMK(FBPDAHOOPKF GDNLGDEFCDG, FLKNJMLJCPI FBJDPHGOEHE, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x7521800", Offset = "0x7520200", VA = "0x187521800")]
	[AsyncStateMachine(typeof(ELLAHLJGMGP))]
	private Task<Scene> LDLLGDHEPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x75216E0", Offset = "0x75200E0", VA = "0x1875216E0")]
	private bool HNGFGDOBEKJ(LKMBJDMKDPJ GGEMPJLCHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7521710", Offset = "0x7520110", VA = "0x187521710")]
	private void JDDNELCBELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7521590", Offset = "0x751FF90", VA = "0x187521590")]
	[AsyncStateMachine(typeof(DIELDMEKIGN))]
	private Task<Scene> HIDOEOCHCCP(string DNDEFCJDLEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct NGLACFOCPHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct APLKHKPIMHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public NGLACFOCPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public JIEGGJGCECL nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public LKMBJDMKDPJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<JIEGGJGCECL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x751F900", Offset = "0x751E300", VA = "0x18751F900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x75203D0", Offset = "0x751EDD0", VA = "0x1875203D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct GKOHPDKDGAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<JIEGGJGCECL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public NGLACFOCPHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public JIEGGJGCECL state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7527EB0", Offset = "0x75268B0", VA = "0x187527EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7528190", Offset = "0x7526B90", VA = "0x187528190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly CEFBPLBIKCE MJHPIPKJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly NABBJMIMBHJ IHIBLLDLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly MGJCBILPHEP MJBODFHEJMF;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private KJKAGGHNJFC CGBHONIHJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C18BE0", Offset = "0x5C175E0", VA = "0x185C18BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x75332F0", Offset = "0x7531CF0", VA = "0x1875332F0")]
	public NGLACFOCPHA(CEFBPLBIKCE MJHPIPKJDHP, NABBJMIMBHJ IHIBLLDLEOK, MGJCBILPHEP MJBODFHEJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x7533150", Offset = "0x7531B50", VA = "0x187533150")]
	[AsyncStateMachine(typeof(APLKHKPIMHJ))]
	public Task<JIEGGJGCECL> NBNLOJKCBKP(JIEGGJGCECL AOIHACBJIIG, LKMBJDMKDPJ ALBPBBBPAAI, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP, bool GMNDCHHMPMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x7532FC0", Offset = "0x75319C0", VA = "0x187532FC0")]
	[AsyncStateMachine(typeof(GKOHPDKDGAL))]
	private Task<JIEGGJGCECL> GGPEKMEJFDN(FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, JIEGGJGCECL DPGCKOGOMEN, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x7533120", Offset = "0x7531B20", VA = "0x187533120")]
	private bool INFLNHGENLO(JIEGGJGCECL FKHGKALHGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x75332D0", Offset = "0x7531CD0", VA = "0x1875332D0")]
	private void PMAPEFGPDFK(string EDMGDMNLJKL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct FEAHGGOPKCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct HIIHCHJGJFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public KJKAGGHNJFC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public PLCAPLLLHFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private HIEPCOOLPHO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, INNJJHKNLDI)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, INNJJHKNLDI) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7528CA0", Offset = "0x75276A0", VA = "0x187528CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x75292F0", Offset = "0x7527CF0", VA = "0x1875292F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x7526970", Offset = "0x7525370", VA = "0x187526970")]
	[AsyncStateMachine(typeof(HIIHCHJGJFO))]
	public static Task LDLLGDHEPIB(KJKAGGHNJFC FAGENEAKFKC, LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct DNNOJLGLPDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct ILNDIHMHKGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public KJKAGGHNJFC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public PLCAPLLLHFO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private CAMCIKNBNLL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private HIEPCOOLPHO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, INNJJHKNLDI)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private INNJJHKNLDI <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x752C5E0", Offset = "0x752AFE0", VA = "0x18752C5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x752CE90", Offset = "0x752B890", VA = "0x18752CE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x7523930", Offset = "0x7522330", VA = "0x187523930")]
	[AsyncStateMachine(typeof(ILNDIHMHKGD))]
	public static Task LDLLGDHEPIB(KJKAGGHNJFC FAGENEAKFKC, LKMBJDMKDPJ GGEMPJLCHFC, PLCAPLLLHFO MMGGAGAAGOP, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct JFBOHNMOLEL
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct JGAGBBEGGAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<OFNMBFBPNPO> LEAKCKNODAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<INNJJHKNLDI> GBLGAONEHNE;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
		public JGAGBBEGGAM(List<OFNMBFBPNPO> LEAKCKNODAC, List<INNJJHKNLDI> GBLGAONEHNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class OENDJABHLLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<OFNMBFBPNPO> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OENDJABHLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7534410", Offset = "0x7532E10", VA = "0x187534410")]
		internal object LKEPDKDKBAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private FBPDAHOOPKF GDNLGDEFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private LKMBJDMKDPJ GGEMPJLCHFC;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private KJJEFGMNENB NBHKINAHGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x752E730", Offset = "0x752D130", VA = "0x18752E730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x752E6D0", Offset = "0x752D0D0", VA = "0x18752E6D0")]
	public static JGAGBBEGGAM LDLLGDHEPIB(FBPDAHOOPKF GDNLGDEFCDG, LKMBJDMKDPJ GGEMPJLCHFC)
	{
		return default(JGAGBBEGGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x752E480", Offset = "0x752CE80", VA = "0x18752E480")]
	private JGAGBBEGGAM LDLLGDHEPIB()
	{
		return default(JGAGBBEGGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x752DED0", Offset = "0x752C8D0", VA = "0x18752DED0")]
	private JGAGBBEGGAM KKCDLJKGGDC(FNEPJCIGLHI ECOALFPMDCI, CAMCIKNBNLL KLLFMDHFLLE)
	{
		return default(JGAGBBEGGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x752DD00", Offset = "0x752C700", VA = "0x18752DD00")]
	private bool AKIINDNKALB(IEnumerable<OFNMBFBPNPO> LEAKCKNODAC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct GGJOPAKGFNH
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class IELNOOFELBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public JFBOHNMOLEL.JGAGBBEGGAM instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IELNOOFELBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x752BCB0", Offset = "0x752A6B0", VA = "0x18752BCB0")]
		internal object KNIMIHCKACM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class OIHFAADPDJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OIHFAADPDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7534D50", Offset = "0x7533750", VA = "0x187534D50")]
		internal object LGPBIOHLDJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x7527900", Offset = "0x7526300", VA = "0x187527900")]
	public static void LDLLGDHEPIB(KJKAGGHNJFC FAGENEAKFKC, LKMBJDMKDPJ GGEMPJLCHFC, JFBOHNMOLEL.JGAGBBEGGAM IBCCNIMNNCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class MGJCBILPHEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct GBINLCBJIDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public JIEGGJGCECL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public LKMBJDMKDPJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x7526AB0", Offset = "0x75254B0", VA = "0x187526AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7527220", Offset = "0x7525C20", VA = "0x187527220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class JDEEBPCIJML
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public JDEEBPCIJML <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x75376C0", Offset = "0x75360C0", VA = "0x1875376C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x7537980", Offset = "0x7536380", VA = "0x187537980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JDEEBPCIJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x752D890", Offset = "0x752C290", VA = "0x18752D890")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task BGEELBKAOLD(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct LDKHNLNMAOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private JDEEBPCIJML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x752F350", Offset = "0x752DD50", VA = "0x18752F350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x752F880", Offset = "0x752E280", VA = "0x18752F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct HLBNFCPMJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<LBMIFONNPIK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x752A220", Offset = "0x7528C20", VA = "0x18752A220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x752A830", Offset = "0x7529230", VA = "0x18752A830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct FBBNCFHOJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<LBMIFONNPIK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7526270", Offset = "0x7524C70", VA = "0x187526270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7526910", Offset = "0x7525310", VA = "0x187526910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class IOAFIBCBEFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public LBMIFONNPIK handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public IOAFIBCBEFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private HIEPCOOLPHO <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x7537200", Offset = "0x7535C00", VA = "0x187537200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x7537660", Offset = "0x7536060", VA = "0x187537660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CMAADBCGEKH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<LBMIFONNPIK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IOAFIBCBEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x752D030", Offset = "0x752BA30", VA = "0x18752D030")]
		internal object MIIHECLLOBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x752CF30", Offset = "0x752B930", VA = "0x18752CF30")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task IOOIJPKKNLN(LBMIFONNPIK handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x752D120", Offset = "0x752BB20", VA = "0x18752D120")]
		internal object PAOEAPJEBII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct NKPOGGCJOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CMAADBCGEKH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public List<LBMIFONNPIK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private IOAFIBCBEFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7533C20", Offset = "0x7532620", VA = "0x187533C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x75340F0", Offset = "0x7532AF0", VA = "0x1875340F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct IDKNNCNPIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x752B690", Offset = "0x752A090", VA = "0x18752B690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x752BC50", Offset = "0x752A650", VA = "0x18752BC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class MGAGBJIDOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MGAGBJIDOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x7531AB0", Offset = "0x75304B0", VA = "0x187531AB0")]
		internal object JAHPNPLHAHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct NBEIFFLGFJL : IAsyncStateMachine
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
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public LKMBJDMKDPJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7532AA0", Offset = "0x75314A0", VA = "0x187532AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x7532F60", Offset = "0x7531960", VA = "0x187532F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class MIBHFJLEPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MIBHFJLEPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7532A30", Offset = "0x7531430", VA = "0x187532A30")]
		internal object HEIBENEIEOJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct HMNDECAAHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public MGJCBILPHEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x752ACC0", Offset = "0x75296C0", VA = "0x18752ACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x752B2F0", Offset = "0x7529CF0", VA = "0x18752B2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class CLKOGMKCJNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CLKOGMKCJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x7522240", Offset = "0x7520C40", VA = "0x187522240")]
		internal object GPAOOGKLACO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly CEFBPLBIKCE MJHPIPKJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private LACCCNLELJA MJBODFHEJMF;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private KJKAGGHNJFC CGBHONIHJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xC69AB0", Offset = "0xC684B0", VA = "0x180C69AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public MGJCBILPHEP(CEFBPLBIKCE MJHPIPKJDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x75321E0", Offset = "0x7530BE0", VA = "0x1875321E0")]
	[AsyncStateMachine(typeof(GBINLCBJIDD))]
	public Task LDLLGDHEPIB(JIEGGJGCECL GOBCNOLHEEI, LKMBJDMKDPJ ALBPBBBPAAI, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7531F60", Offset = "0x7530960", VA = "0x187531F60")]
	[AsyncStateMachine(typeof(LDKHNLNMAOA))]
	private Task JKEPAKDGBBE(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x75320A0", Offset = "0x7530AA0", VA = "0x1875320A0")]
	[AsyncStateMachine(typeof(HLBNFCPMJBA))]
	private Task KPFKFDJJJBO(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x7532330", Offset = "0x7530D30", VA = "0x187532330")]
	[AsyncStateMachine(typeof(FBBNCFHOJPP))]
	private Task MFEMBDPCKEK(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7532640", Offset = "0x7531040", VA = "0x187532640")]
	[AsyncStateMachine(typeof(NKPOGGCJOCL))]
	private Task PBBIDDBHAHN(Guid MLGOIKPLKPK, List<LBMIFONNPIK> NBLNFEHFDGH, CMAADBCGEKH JLPIKPNACLH, LKMBJDMKDPJ GGEMPJLCHFC, CancellationToken AICEIDIHFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7531C60", Offset = "0x7530660", VA = "0x187531C60")]
	[AsyncStateMachine(typeof(IDKNNCNPIJF))]
	private Task FCMLJIADIBC(LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x7531B20", Offset = "0x7530520", VA = "0x187531B20")]
	[AsyncStateMachine(typeof(NBEIFFLGFJL))]
	private Task EBCGJCGCJIN(Guid JNCGIMKBNKD, LKMBJDMKDPJ GGEMPJLCHFC, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x75328F0", Offset = "0x75312F0", VA = "0x1875328F0")]
	[AsyncStateMachine(typeof(HMNDECAAHOA))]
	private Task PPEOICBLFNL(Guid JNCGIMKBNKD, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x7531DA0", Offset = "0x75307A0", VA = "0x187531DA0")]
	private void FLDOJIGMOJO(Guid JNCGIMKBNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7531EB0", Offset = "0x75308B0", VA = "0x187531EB0")]
	private void GGIKLIJJGAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x7532790", Offset = "0x7531190", VA = "0x187532790")]
	public Guid PJNPFMDHHOO(JIEGGJGCECL EPNLMLMKOJP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7532470", Offset = "0x7530E70", VA = "0x187532470")]
	[CompilerGenerated]
	private object NGHJKOEFHFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct HKDIKHONNND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct OOCOCJIDKFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public HKDIKHONNND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private IEnumerator<AFEMDEJPPNP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7535550", Offset = "0x7533F50", VA = "0x187535550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7535BF0", Offset = "0x75345F0", VA = "0x187535BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private KJJEFGMNENB LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private CancellationToken PPLDCJFFMEP;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x752A0C0", Offset = "0x7528AC0", VA = "0x18752A0C0")]
	public static Task JGPLPBOOOBJ(KJJEFGMNENB LPMHKEAJABJ, FILMNPNNHPJ<string>.EEFAEMIIABD PILOCADBFFI, CancellationToken BIDJOLCDMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x752A130", Offset = "0x7528B30", VA = "0x18752A130")]
	[AsyncStateMachine(typeof(OOCOCJIDKFB))]
	private Task LDLLGDHEPIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct ACDALMNGNFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly bool MNPJABBNJMM;

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x2452AC0", Offset = "0x24514C0", VA = "0x182452AC0")]
	public ACDALMNGNFK(bool HDIIJAJFELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct HLPAOIDBMBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly FNEPJCIGLHI? JFCPHIKJNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	public readonly FJAFJJHPBFH HACLIJFJKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	public readonly string? AGOMJDJOMCG;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IReadOnlyCollection<string> DFAEMADINAH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x752AB80", Offset = "0x7529580", VA = "0x18752AB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyDictionary<long, int> MEEBAABACDG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x752ABA0", Offset = "0x75295A0", VA = "0x18752ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x752ABC0", Offset = "0x75295C0", VA = "0x18752ABC0")]
	public HLPAOIDBMBB(FNEPJCIGLHI? GJLDCFIFFGA, FJAFJJHPBFH HJGICBPINAN, string? BKELLPBJGPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class BMBAOBPEKJJ : FNMLBODPJAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct EGDPMGLKLLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder<HLPAOIDBMBB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public BMBAOBPEKJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public BKOCDJHIDIE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public OFNJDMAAPJA roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private HIEPCOOLPHO <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x75255A0", Offset = "0x7523FA0", VA = "0x1875255A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7525C20", Offset = "0x7524620", VA = "0x187525C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class HLIOKMMIJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public BKOCDJHIDIE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public BMBAOBPEKJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HLIOKMMIJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x752A970", Offset = "0x7529370", VA = "0x18752A970")]
		internal Task KEDFOBPGHDJ(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x752A890", Offset = "0x7529290", VA = "0x18752A890")]
		internal Task DGKFBICPHKE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class HCLFGGJNONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public HLIOKMMIJOB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public HCLFGGJNONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x75282E0", Offset = "0x7526CE0", VA = "0x1875282E0")]
		internal object EKENEGAHEKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class IMJHNACEEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public HLIOKMMIJOB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IMJHNACEEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x752CEF0", Offset = "0x752B8F0", VA = "0x18752CEF0")]
		internal Task MCPNEEAOGLF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct OGBFKJOBPNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public BKOCDJHIDIE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public BMBAOBPEKJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private HCLFGGJNONJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private HIEPCOOLPHO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7534490", Offset = "0x7532E90", VA = "0x187534490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x7534CF0", Offset = "0x75336F0", VA = "0x187534CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private static readonly TimeSpan OPAJBLJKIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly OONDIHGFJAE BJFIDLMCCJM;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x7521540", Offset = "0x751FF40", VA = "0x187521540")]
	public BMBAOBPEKJJ(CEFBPLBIKCE MJHPIPKJDHP, OONDIHGFJAE BJFIDLMCCJM, KLEHBGEJMBN DAKGLLFOGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x7520A00", Offset = "0x751F400", VA = "0x187520A00")]
	[AsyncStateMachine(typeof(EGDPMGLKLLD))]
	public Task<HLPAOIDBMBB> HLGBFIEHJDG(long OKPAMGANILI, OFNJDMAAPJA GEGDNCFBIGP, BKOCDJHIDIE COIGBAPOAOG, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x7521390", Offset = "0x751FD90", VA = "0x187521390")]
	[AsyncStateMachine(typeof(OGBFKJOBPNN))]
	private Task PNCNCGMKDGK(BKOCDJHIDIE COIGBAPOAOG, IEnumerable<PersistenceView> JJHHCLNMMCD, StringBuilder LLJCDNCCGAJ, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x7520440", Offset = "0x751EE40", VA = "0x187520440")]
	private HLPAOIDBMBB FLOALGMANBB(long OKPAMGANILI, OFNJDMAAPJA GEGDNCFBIGP, BKOCDJHIDIE COIGBAPOAOG, IEnumerable<PersistenceView> JJHHCLNMMCD, StringBuilder LLJCDNCCGAJ)
	{
		return default(HLPAOIDBMBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x7521240", Offset = "0x751FC40", VA = "0x187521240")]
	private FNEPJCIGLHI OKJLODHKPHH(long OKPAMGANILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x7520B60", Offset = "0x751F560", VA = "0x187520B60")]
	private void NCJFLIEOKNJ(FNEPJCIGLHI GBLKBNKKKHI, StringBuilder LLJCDNCCGAJ, IEnumerable<PersistenceView> JJHHCLNMMCD, [In] JDNNIPIALOM FDHOOFMLFAM, ABDCKNOIGKC PHNENPJMKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x7520DB0", Offset = "0x751F7B0", VA = "0x187520DB0")]
	private void NDJLFNCDFFJ(FNEPJCIGLHI GBLKBNKKKHI, StringBuilder LLJCDNCCGAJ, PersistenceView EPCOPABAPDA, ABDCKNOIGKC PHNENPJMKOF, [In] JDNNIPIALOM FDHOOFMLFAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class HGDPLJDIHHN : FNMLBODPJAO
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class MDAFGLBDHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public HDPIOIMFMGI.PBLKJKKBDKN roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public MDAFGLBDHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x7531A60", Offset = "0x7530460", VA = "0x187531A60")]
		internal object HPFBOCGMNCM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct NKJEBGLOMPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<(HDPIOIMFMGI.PBLKJKKBDKN roomDataUpload, HDPIOIMFMGI.PBLKJKKBDKN subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public HLPAOIDBMBB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public HGDPLJDIHHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private MDAFGLBDHNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private TaskAwaiter<HDPIOIMFMGI.PBLKJKKBDKN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7533350", Offset = "0x7531D50", VA = "0x187533350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x7533BB0", Offset = "0x75325B0", VA = "0x187533BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct MAGABNKIOAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public AsyncTaskMethodBuilder<AFCCLGFOAKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public HGDPLJDIHHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public HLPAOIDBMBB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public JBJGKGNCJFN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter<(HDPIOIMFMGI.PBLKJKKBDKN roomDataUpload, HDPIOIMFMGI.PBLKJKKBDKN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<AFCCLGFOAKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7531360", Offset = "0x752FD60", VA = "0x187531360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x75319F0", Offset = "0x75303F0", VA = "0x1875319F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct KDCPFMILJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public AsyncTaskMethodBuilder<OGJPACLLFCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public HGDPLJDIHHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public HLPAOIDBMBB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private TaskAwaiter<(HDPIOIMFMGI.PBLKJKKBDKN roomDataUpload, HDPIOIMFMGI.PBLKJKKBDKN subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter<OGJPACLLFCJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x752E800", Offset = "0x752D200", VA = "0x18752E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x752EC20", Offset = "0x752D620", VA = "0x18752EC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class CPBLMHHAHKC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public CPBLMHHAHKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private JDBONLEIIML <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<OGJPACLLFCJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter<AFCCLGFOAKC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			private TaskAwaiter<JDBONLEIIML> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x7537DD0", Offset = "0x75367D0", VA = "0x187537DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x7538DE0", Offset = "0x75377E0", VA = "0x187538DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public HGDPLJDIHHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public HLPAOIDBMBB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public JBJGKGNCJFN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public ACDALMNGNFK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CPBLMHHAHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x75222B0", Offset = "0x7520CB0", VA = "0x1875222B0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JDBONLEIIML> GPFDEAAKCOL(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct JFBKMMEEKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public AsyncTaskMethodBuilder<JDBONLEIIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public HGDPLJDIHHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public HLPAOIDBMBB roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public JBJGKGNCJFN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public ACDALMNGNFK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter<JDBONLEIIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x752D980", Offset = "0x752C380", VA = "0x18752D980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x752DC90", Offset = "0x752C690", VA = "0x18752DC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private static readonly KLEHBGEJMBN ENDMIGONNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly BGKNBPLJCOM PNAMJGDBFLH;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private FBPDAHOOPKF KPAEPEJLFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7505F00", Offset = "0x7504900", VA = "0x187505F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x75289A0", Offset = "0x75273A0", VA = "0x1875289A0")]
	public HGDPLJDIHHN(CEFBPLBIKCE MJHPIPKJDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x7528350", Offset = "0x7526D50", VA = "0x187528350")]
	[AsyncStateMachine(typeof(NKJEBGLOMPE))]
	private Task<(HDPIOIMFMGI.PBLKJKKBDKN, HDPIOIMFMGI.PBLKJKKBDKN)> AJKNJHCKHCE(HLPAOIDBMBB LBAJBEGJANL, long NPGHGEFGHLA, long GDENKKEDKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x75287A0", Offset = "0x75271A0", VA = "0x1875287A0")]
	[AsyncStateMachine(typeof(MAGABNKIOAH))]
	public Task<AFCCLGFOAKC> KADPAGLNCAK(int EHKPDKPBKCL, [CanBeNull] JBJGKGNCJFN BHMCOFGNKDJ, HLPAOIDBMBB LBAJBEGJANL, long NPGHGEFGHLA, long GDENKKEDKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x7528630", Offset = "0x7527030", VA = "0x187528630")]
	[AsyncStateMachine(typeof(KDCPFMILJBL))]
	private Task<OGJPACLLFCJ> INIEDLENCOC(string DEBCIKJGCDH, int EHKPDKPBKCL, HLPAOIDBMBB LBAJBEGJANL, long NPGHGEFGHLA, long GDENKKEDKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7528490", Offset = "0x7526E90", VA = "0x187528490")]
	[AsyncStateMachine(typeof(JFBKMMEEKJO))]
	public Task<JDBONLEIIML> DNGDJJKNOHF(int EHKPDKPBKCL, JBJGKGNCJFN? BHMCOFGNKDJ, HLPAOIDBMBB LBAJBEGJANL, long NPGHGEFGHLA, long GDENKKEDKLA, ACDALMNGNFK AEBPOCBDKFD, FILMNPNNHPJ<string>.EEFAEMIIABD GPICPPEACBO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class DCHOOFBLOHJ<T> where T : DCHOOFBLOHJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	internal readonly FBPDAHOOPKF MDGMIKECBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private int? OIDHBBNCCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	protected readonly Guid CJBBCHHPBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	protected readonly DOFMJKPJLKG KHJKDBMKBII;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected T APGHIHEFMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x5C75950", Offset = "0x5C74350", VA = "0x185C75950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x5C75B00", Offset = "0x5C74500", VA = "0x185C75B00")]
	internal DCHOOFBLOHJ(FBPDAHOOPKF GDNMBOIKODA, DOFMJKPJLKG ILCOEDDFLME, [Optional] Guid? GGNKLHDGNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x5C75740", Offset = "0x5C74140", VA = "0x185C75740")]
	private JDBONLEIIML EKJDLGDJPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	protected virtual void APBKNAGDMOJ(JDBONLEIIML FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x5C75A60", Offset = "0x5C74460", VA = "0x185C75A60")]
	public T PCECFICIKKI(OGOAPNICIIH CKKFCDKPFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x5C759B0", Offset = "0x5C743B0", VA = "0x185C759B0")]
	public T JNNGAFLCENH(int OPFFEHLKBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x5C75820", Offset = "0x5C74220", VA = "0x185C75820", Slot = "5")]
	public virtual Task<ICNNFOGCALN> HKEOGAFGCNC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class PPMFHAJFKFP : DCHOOFBLOHJ<PPMFHAJFKFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private CMBGKEDMCPG ELHNCLABHAD;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x753FBE0", Offset = "0x753E5E0", VA = "0x18753FBE0")]
	internal PPMFHAJFKFP(FBPDAHOOPKF GDNMBOIKODA, DOFMJKPJLKG ILCOEDDFLME, [Optional] Guid? GGNKLHDGNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x69C8050", Offset = "0x69C6A50", VA = "0x1869C8050")]
	public PPMFHAJFKFP CALPJDCGMEP(CMBGKEDMCPG ELHNCLABHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x753FB10", Offset = "0x753E510", VA = "0x18753FB10", Slot = "4")]
	protected override void APBKNAGDMOJ(JDBONLEIIML FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class GHACJEKPKON : DCHOOFBLOHJ<GHACJEKPKON>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum GLBBHOGJABI
	{
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct BLFHLILBCFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public AsyncTaskMethodBuilder<ICNNFOGCALN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public GHACJEKPKON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter<ICNNFOGCALN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x753AEB0", Offset = "0x75398B0", VA = "0x18753AEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x753B260", Offset = "0x7539C60", VA = "0x18753B260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private GLBBHOGJABI DFGLGKIFGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private string PBHAILNDNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private JBJGKGNCJFN ELHNCLABHAD;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x753C3D0", Offset = "0x753ADD0", VA = "0x18753C3D0")]
	internal GHACJEKPKON(FBPDAHOOPKF GDNMBOIKODA, DOFMJKPJLKG ILCOEDDFLME, [Optional] Guid? GGNKLHDGNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x753C3A0", Offset = "0x753ADA0", VA = "0x18753C3A0")]
	public GHACJEKPKON LAKGFKIGIIH(string IGIOLLIFOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x753C0B0", Offset = "0x753AAB0", VA = "0x18753C0B0")]
	public GHACJEKPKON AFLAHLOKBAA(bool OIGLBAFMEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x753C240", Offset = "0x753AC40", VA = "0x18753C240")]
	public GHACJEKPKON FKKCHPEIAEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x753C0D0", Offset = "0x753AAD0", VA = "0x18753C0D0", Slot = "4")]
	protected override void APBKNAGDMOJ(JDBONLEIIML FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x753C2B0", Offset = "0x753ACB0", VA = "0x18753C2B0", Slot = "5")]
	[AsyncStateMachine(typeof(BLFHLILBCFH))]
	public override Task<ICNNFOGCALN> HKEOGAFGCNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x753C270", Offset = "0x753AC70", VA = "0x18753C270")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<ICNNFOGCALN> FPHNPGIJIIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class HJNFMKOEEJA
{
	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x753D190", Offset = "0x753BB90", VA = "0x18753D190")]
	public static void NPJMDLBBIPN(this MMPBFABBMCN HIHCAGELBKO, OABHCPGEKDA IPPONHLLGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x753D110", Offset = "0x753BB10", VA = "0x18753D110")]
	public static void HLNDGBJJGOD(this OABHCPGEKDA BOLIKBEKJMB, [Optional] string FCMDIEEAPHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class LEGONMDPDBK
{
	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x753E430", Offset = "0x753CE30", VA = "0x18753E430")]
	public static OAGGCGDDFAC GFKFCKHIIAO(this OMFPNAACNCE IAFEBONJPKB)
	{
		return default(OAGGCGDDFAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x753E4D0", Offset = "0x753CED0", VA = "0x18753E4D0")]
	public static OMFPNAACNCE PJKHNEJAJFJ(this OAGGCGDDFAC KNBPEJFEHBF)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public LDJHPKBNKJN ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public LDJHPKBNKJN HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private static LDJHPKBNKJN[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private Dictionary<LDJHPKBNKJN, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x75400B0", Offset = "0x753EAB0", VA = "0x1875400B0")]
		public bool NCNBMPEPANJ(LDJHPKBNKJN IBCIMOMCIDH, [Out] ResultConfig BLHPPLPBDDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x753FF70", Offset = "0x753E970", VA = "0x18753FF70")]
		public ResultConfig EPGAJGCKFBE(LDJHPKBNKJN OMJKCNAHEJC, [Optional] HashSet<LDJHPKBNKJN> FLIEPHKJHAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x75406D0", Offset = "0x753F0D0", VA = "0x1875406D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7540120", Offset = "0x753EB20", VA = "0x187540120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA828F0", Offset = "0xA812F0", VA = "0x180A828F0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class JBGIMEMBMAC : ODMFCPKINFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct IJANPKMFCKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public JBGIMEMBMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x753DD80", Offset = "0x753C780", VA = "0x18753DD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x753E010", Offset = "0x753CA10", VA = "0x18753E010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct GCHLBCEBMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public FILMNPNNHPJ<string>.EEFAEMIIABD timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public ODMFCPKINFP preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private FILMNPNNHPJ<string>.EEFAEMIIABD <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x753BB30", Offset = "0x753A530", VA = "0x18753BB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x753C050", Offset = "0x753AA50", VA = "0x18753C050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private readonly DBCPHOHHKFB CLCBOPNJBNG;

	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string MAALMJOAKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x753E0F0", Offset = "0x753CAF0", VA = "0x18753E0F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x753E240", Offset = "0x753CC40", VA = "0x18753E240")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	internal static void LAKIIFNFKHP(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JBGIMEMBMAC([CCLEDEMDDDH(null)] DBCPHOHHKFB CLCBOPNJBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x753E2B0", Offset = "0x753CCB0", VA = "0x18753E2B0", Slot = "5")]
	[AsyncStateMachine(typeof(IJANPKMFCKO))]
	public Task LDLLGDHEPIB(FILMNPNNHPJ<string>.EEFAEMIIABD MBOLAEMDCKO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x753E120", Offset = "0x753CB20", VA = "0x18753E120")]
	[AsyncStateMachine(typeof(GCHLBCEBMOO))]
	private Task DEGIDHDOOOL(ODMFCPKINFP KOIKCMMDLBG, FILMNPNNHPJ<string>.EEFAEMIIABD MBOLAEMDCKO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface DBCPHOHHKFB : ODMFCPKINFP
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface ODMFCPKINFP
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string MAALMJOAKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LDLLGDHEPIB(FILMNPNNHPJ<string>.EEFAEMIIABD MBOLAEMDCKO, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class OAFJBEFFIOE
{
	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x753F700", Offset = "0x753E100", VA = "0x18753F700")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	internal static void EHEFGOAOAHF(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface HODNKPFLLHK : IEquatable<HODNKPFLLHK>
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	DateTime HLAOFCAJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEIMJLIILOF();

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDLEOFODKIK(long NPGHGEFGHLA, long OKPAMGANILI, [Out] HLPAOIDBMBB LBAJBEGJANL);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class BFOADELDGAG : BPAMECECBJC
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class CMNGOLLBHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public BAKCOMBJMKD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CMNGOLLBHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x753B2D0", Offset = "0x7539CD0", VA = "0x18753B2D0")]
		internal object AAKMFIDNPPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly IGJHKMPFMPF LGPDMHJCALA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HODNKPFLLHK> KHKLHDOKECF
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x7539990", Offset = "0x7538390", VA = "0x187539990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x75393E0", Offset = "0x7537DE0", VA = "0x1875393E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	[UnityEngine.Scripting.Preserve]
	public BFOADELDGAG([CCLEDEMDDDH(null)] IGJHKMPFMPF LGPDMHJCALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x7539490", Offset = "0x7537E90", VA = "0x187539490", Slot = "6")]
	public bool JDKOGDKGBOE(long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL, BAKCOMBJMKD NACGOOKCKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x96DE90", Offset = "0x96C890", VA = "0x18096DE90")]
	private void AJEAPLHMDGB(HODNKPFLLHK JAFKJGHEDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x7539770", Offset = "0x7538170", VA = "0x187539770", Slot = "7")]
	public bool JECHHGBDGBJ(long NPGHGEFGHLA, long OKPAMGANILI, [Out] HODNKPFLLHK JCEPEPKPAGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x75398E0", Offset = "0x75382E0", VA = "0x1875398E0", Slot = "8")]
	public bool MLOBOJJMCLI(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, [Out] HODNKPFLLHK JCEPEPKPAGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7539A40", Offset = "0x7538440", VA = "0x187539A40")]
	private void NAMGABHFAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x7539E70", Offset = "0x7538870", VA = "0x187539E70", Slot = "9")]
	public void OKHGLCBPDIL(long NPGHGEFGHLA, long OKPAMGANILI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class ICLLLJBFHJC : IGJHKMPFMPF
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum LIMLCEFNJHB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class FBAKAMEKPEG : IEnumerable<HODNKPFLLHK>, IEnumerable, IEnumerator<HODNKPFLLHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private HODNKPFLLHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public ICLLLJBFHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private BAKCOMBJMKD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public BAKCOMBJMKD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private HODNKPFLLHK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public FBAKAMEKPEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x753B800", Offset = "0x753A200", VA = "0x18753B800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x753BAE0", Offset = "0x753A4E0", VA = "0x18753BAE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x753BA30", Offset = "0x753A430", VA = "0x18753BA30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HODNKPFLLHK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x753BA30", Offset = "0x753A430", VA = "0x18753BA30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class GHHHKIHJMEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public BAKCOMBJMKD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public GHHHKIHJMEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x753C540", Offset = "0x753AF40", VA = "0x18753C540")]
		internal object IFDPDLBPJMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class IKLIBABMFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public ICLLLJBFHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IKLIBABMFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x753E070", Offset = "0x753CA70", VA = "0x18753E070")]
		internal void DBNHHEBDEGI(NBACGCHMHNO.JHICMAHFFEL ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly object CIIECACMNBG;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	protected string MDOEGCAACED
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x753D690", Offset = "0x753C090", VA = "0x18753D690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract GHMNMPCGNLG KOEOGCCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x753DD00", Offset = "0x753C700", VA = "0x18753DD00")]
	protected ICLLLJBFHJC([CanBeNull] string EKMMKMKGIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x753D7A0", Offset = "0x753C1A0", VA = "0x18753D7A0", Slot = "5")]
	public bool OOJADJNOLKB(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, [Out] HODNKPFLLHK JAFKJGHEDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x753D6A0", Offset = "0x753C0A0", VA = "0x18753D6A0", Slot = "6")]
	[IteratorStateMachine(typeof(FBAKAMEKPEG))]
	public IEnumerable<HODNKPFLLHK> EILFBPNMJDJ(BAKCOMBJMKD NACGOOKCKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DODLHPHJKEH(Stream JDNCEAJJIMM, long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FOJFAMPACOM(Stream JIEPEDJCLEN, long NPGHGEFGHLA, long OKPAMGANILI, CGDODKMFPAE FBFJJLHKEGA, [Out] HLPAOIDBMBB LBAJBEGJANL);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x753D990", Offset = "0x753C390", VA = "0x18753D990", Slot = "7")]
	public HODNKPFLLHK PFOANIFBBKO(long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL, BAKCOMBJMKD NACGOOKCKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo DAGIOAFKGMI(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, LIMLCEFNJHB COKFBPLOKPA);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NFOAJOEEPID(BAKCOMBJMKD NACGOOKCKAA, LIMLCEFNJHB COKFBPLOKPA);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x753D730", Offset = "0x753C130", VA = "0x18753D730")]
	protected void FBOOLDDBKPD(NBACGCHMHNO.JHICMAHFFEL IGCCPMGEIMF, string EDMGDMNLJKL, FileInfo EPOAFJIMIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x753D2E0", Offset = "0x753BCE0", VA = "0x18753D2E0")]
	internal bool AEJNGMNIFMB(FileInfo MOKHBHCOIKN, long NPGHGEFGHLA, long OKPAMGANILI, [Out] HLPAOIDBMBB LBAJBEGJANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private void OHBDECFJMBO(Exception HMCKAKHHODE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class HBEELFANCIM : ICLLLJBFHJC
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override GHMNMPCGNLG KOEOGCCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x16DB9F0", Offset = "0x16DA3F0", VA = "0x1816DB9F0", Slot = "8")]
		get
		{
			return default(GHMNMPCGNLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x753D0D0", Offset = "0x753BAD0", VA = "0x18753D0D0")]
	public HBEELFANCIM([Optional] string EKMMKMKGIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x753CF50", Offset = "0x753B950", VA = "0x18753CF50")]
	private void MFLGMKMLJLE(BAKCOMBJMKD NACGOOKCKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x753C6D0", Offset = "0x753B0D0", VA = "0x18753C6D0", Slot = "9")]
	internal override void DODLHPHJKEH(Stream JDNCEAJJIMM, long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x753C960", Offset = "0x753B360", VA = "0x18753C960", Slot = "10")]
	internal override bool FOJFAMPACOM(Stream JIEPEDJCLEN, long NPGHGEFGHLA, long OKPAMGANILI, CGDODKMFPAE FBFJJLHKEGA, [Out] HLPAOIDBMBB LBAJBEGJANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x753C5E0", Offset = "0x753AFE0", VA = "0x18753C5E0", Slot = "11")]
	protected override FileInfo DAGIOAFKGMI(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, LIMLCEFNJHB COKFBPLOKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x753CFD0", Offset = "0x753B9D0", VA = "0x18753CFD0", Slot = "12")]
	protected override DirectoryInfo NFOAJOEEPID(BAKCOMBJMKD NACGOOKCKAA, LIMLCEFNJHB COKFBPLOKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class BKMLJFPJJBM : ICLLLJBFHJC
{
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private static readonly byte[] PNABAFEIDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly byte[] IKDPKGEAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly byte[] EGJMEKJAJFK;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public override GHMNMPCGNLG KOEOGCCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x6254800", Offset = "0x6253200", VA = "0x186254800", Slot = "8")]
		get
		{
			return default(GHMNMPCGNLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x753ADC0", Offset = "0x75397C0", VA = "0x18753ADC0")]
	public BKMLJFPJJBM([Optional] string EKMMKMKGIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x753A0D0", Offset = "0x7538AD0", VA = "0x18753A0D0", Slot = "9")]
	internal override void DODLHPHJKEH(Stream JDNCEAJJIMM, long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x753A380", Offset = "0x7538D80", VA = "0x18753A380", Slot = "10")]
	internal override bool FOJFAMPACOM(Stream JIEPEDJCLEN, long NPGHGEFGHLA, long OKPAMGANILI, CGDODKMFPAE FBFJJLHKEGA, [Out] HLPAOIDBMBB LBAJBEGJANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x753AB60", Offset = "0x7539560", VA = "0x18753AB60")]
	private void KFOLCELEJFD(byte[] FFGGPAIGPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7539FA0", Offset = "0x75389A0", VA = "0x187539FA0", Slot = "11")]
	protected override FileInfo DAGIOAFKGMI(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, LIMLCEFNJHB COKFBPLOKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x753AC20", Offset = "0x7539620", VA = "0x18753AC20", Slot = "12")]
	protected override DirectoryInfo NFOAJOEEPID(BAKCOMBJMKD NACGOOKCKAA, LIMLCEFNJHB COKFBPLOKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum GHMNMPCGNLG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class MCNAFPHHMCH : IGJHKMPFMPF
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class ECPEDGGAGDL : IEnumerable<HODNKPFLLHK>, IEnumerable, IEnumerator<HODNKPFLLHK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private HODNKPFLLHK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public MCNAFPHHMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private BAKCOMBJMKD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public BAKCOMBJMKD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private GHMNMPCGNLG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private IEnumerator<HODNKPFLLHK> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		private HODNKPFLLHK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public ECPEDGGAGDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x753B770", Offset = "0x753A170", VA = "0x18753B770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x753B390", Offset = "0x7539D90", VA = "0x18753B390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x753B340", Offset = "0x7539D40", VA = "0x18753B340")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x753B720", Offset = "0x753A120", VA = "0x18753B720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x753B670", Offset = "0x753A070", VA = "0x18753B670", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HODNKPFLLHK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x753B670", Offset = "0x753A070", VA = "0x18753B670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private readonly GHMNMPCGNLG[] DDGKMKEPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private readonly Dictionary<GHMNMPCGNLG, IGJHKMPFMPF> LAFHBNHFOAF;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public GHMNMPCGNLG KOEOGCCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x753E930", Offset = "0x753D330", VA = "0x18753E930", Slot = "4")]
		get
		{
			return default(GHMNMPCGNLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x753EDD0", Offset = "0x753D7D0", VA = "0x18753EDD0")]
	[UnityEngine.Scripting.Preserve]
	public MCNAFPHHMCH(params IGJHKMPFMPF[] DIIKIGNEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x753EBA0", Offset = "0x753D5A0", VA = "0x18753EBA0", Slot = "5")]
	public bool OOJADJNOLKB(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, [Out] HODNKPFLLHK JAFKJGHEDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x753E960", Offset = "0x753D360", VA = "0x18753E960")]
	private void OMAOCDDOMHB(int JBLALKBGCFH, long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x753E8A0", Offset = "0x753D2A0", VA = "0x18753E8A0", Slot = "6")]
	[IteratorStateMachine(typeof(ECPEDGGAGDL))]
	public IEnumerable<HODNKPFLLHK> EILFBPNMJDJ(BAKCOMBJMKD NACGOOKCKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x753ECF0", Offset = "0x753D6F0", VA = "0x18753ECF0", Slot = "7")]
	public HODNKPFLLHK PFOANIFBBKO(long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL, BAKCOMBJMKD NACGOOKCKAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class MCJBMKFEOLL
{
	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x753E580", Offset = "0x753CF80", VA = "0x18753E580")]
	internal static byte[] EICIAAIGEIN(byte[] FFGGPAIGPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x753E640", Offset = "0x753D040", VA = "0x18753E640")]
	public static void LCLKCMPBLKC(Stream CHHHDKLHEOP, byte[] CFGINNOMAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x753E6C0", Offset = "0x753D0C0", VA = "0x18753E6C0")]
	public static bool OCFOCJLOKDK(Stream CHHHDKLHEOP, long KMHDPHOGGOI, CGDODKMFPAE MOLMDFEMIII, [Out] byte[] IOANFBMBHOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class MDJNCIENGMB : HODNKPFLLHK, IEquatable<HODNKPFLLHK>, IEquatable<MDJNCIENGMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	private readonly ICLLLJBFHJC CKIBCKNJILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly FileInfo EKNBJOIIMDA;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GHMNMPCGNLG KOEOGCCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7530", Offset = "0x6ED5F30", VA = "0x186ED7530", Slot = "9")]
		get
		{
			return default(GHMNMPCGNLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DateTime HLAOFCAJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x753F3E0", Offset = "0x753DDE0", VA = "0x18753F3E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x753F5F0", Offset = "0x753DFF0", VA = "0x18753F5F0")]
	public MDJNCIENGMB(ICLLLJBFHJC MDCBDJMDAIH, FileInfo MOKHBHCOIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x753F540", Offset = "0x753DF40", VA = "0x18753F540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x753F320", Offset = "0x753DD20", VA = "0x18753F320", Slot = "5")]
	public void FEIMJLIILOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x753F500", Offset = "0x753DF00", VA = "0x18753F500", Slot = "6")]
	public bool HDLEOFODKIK(long NPGHGEFGHLA, long OKPAMGANILI, [Out] HLPAOIDBMBB LBAJBEGJANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x753F2B0", Offset = "0x753DCB0", VA = "0x18753F2B0", Slot = "7")]
	public bool Equals(HODNKPFLLHK GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x753F100", Offset = "0x753DB00", VA = "0x18753F100", Slot = "8")]
	public bool Equals(MDJNCIENGMB GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x753F1C0", Offset = "0x753DBC0", VA = "0x18753F1C0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x753F470", Offset = "0x753DE70", VA = "0x18753F470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void CGDODKMFPAE(NBACGCHMHNO.JHICMAHFFEL OMNEJMPDBFI, string FCMDIEEAPHD);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface IGJHKMPFMPF
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	GHMNMPCGNLG KOEOGCCLAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOJADJNOLKB(long NPGHGEFGHLA, long OKPAMGANILI, BAKCOMBJMKD NACGOOKCKAA, [Out] HODNKPFLLHK JAFKJGHEDHG);

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HODNKPFLLHK> EILFBPNMJDJ(BAKCOMBJMKD NACGOOKCKAA);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HODNKPFLLHK PFOANIFBBKO(long NPGHGEFGHLA, long OKPAMGANILI, HLPAOIDBMBB LBAJBEGJANL, BAKCOMBJMKD NACGOOKCKAA);
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
